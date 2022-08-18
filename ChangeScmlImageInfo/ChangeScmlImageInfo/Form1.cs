using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ChangeScmlImageInfo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bt_idle_Click(object sender, EventArgs e) {
            if(openFileDialog_scml.ShowDialog() == DialogResult.OK) {
                tx_idle.Text = openFileDialog_scml.FileName;
            }
        }

        private void bt_folder_Click(object sender, EventArgs e) {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK) {
               tx_folder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void bt_start_Click(object sender, EventArgs e) {
            string[] files = Directory.GetFiles(tx_folder.Text,"*.scml");
            foreach(string file in files) {
                if(file == tx_idle.Text) {  continue; }

                XmlDocument target = new XmlDocument();
                target.Load(file);
                var targetroot = target.FirstChild.NextSibling;

                XmlDocument idle = new XmlDocument();
                idle.Load(tx_idle.Text);
                var idleroot = idle.FirstChild.NextSibling;

                foreach(XmlElement t in targetroot) {
                    if(t.Name != "folder") { break; }

                    string tname = t.GetAttribute("name");
                    foreach(XmlElement v in idleroot) {
                        if(v.Name != "folder") { break; }

                        if(v.GetAttribute("name") == tname) {
                            Console.WriteLine(tname);
                            foreach(XmlElement tfile in t) {
                                string name = tfile.GetAttribute("name");
                                foreach(XmlElement vfile in v) {
                                    if(vfile.GetAttribute("name") == name) {
                                        Console.WriteLine("\t" + name);
                                        tfile.SetAttribute("width", vfile.GetAttribute("width"));
                                        tfile.SetAttribute("height", vfile.GetAttribute("height"));
                                        tfile.SetAttribute("pivot_x", vfile.GetAttribute("pivot_x"));
                                        tfile.SetAttribute("pivot_y", vfile.GetAttribute("pivot_y"));
                                    }
                                }
                            }
                        }
                    }
                }
                target.Save(file);
            }
            MessageBox.Show("同步成功!");
        }
    }
}
