
namespace ChangeScmlImageInfo {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_idle = new System.Windows.Forms.TextBox();
            this.tx_folder = new System.Windows.Forms.TextBox();
            this.bt_idle = new System.Windows.Forms.Button();
            this.bt_folder = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.openFileDialog_scml = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "模版\r\nscml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "动  画\r\n文件夹";
            // 
            // tx_idle
            // 
            this.tx_idle.Location = new System.Drawing.Point(64, 12);
            this.tx_idle.Name = "tx_idle";
            this.tx_idle.Size = new System.Drawing.Size(174, 21);
            this.tx_idle.TabIndex = 2;
            // 
            // tx_folder
            // 
            this.tx_folder.Location = new System.Drawing.Point(64, 44);
            this.tx_folder.Name = "tx_folder";
            this.tx_folder.Size = new System.Drawing.Size(174, 21);
            this.tx_folder.TabIndex = 3;
            // 
            // bt_idle
            // 
            this.bt_idle.Location = new System.Drawing.Point(245, 9);
            this.bt_idle.Name = "bt_idle";
            this.bt_idle.Size = new System.Drawing.Size(19, 24);
            this.bt_idle.TabIndex = 4;
            this.bt_idle.Text = "◎";
            this.bt_idle.UseVisualStyleBackColor = true;
            this.bt_idle.Click += new System.EventHandler(this.bt_idle_Click);
            // 
            // bt_folder
            // 
            this.bt_folder.Location = new System.Drawing.Point(244, 44);
            this.bt_folder.Name = "bt_folder";
            this.bt_folder.Size = new System.Drawing.Size(19, 24);
            this.bt_folder.TabIndex = 5;
            this.bt_folder.Text = "◎";
            this.bt_folder.UseVisualStyleBackColor = true;
            this.bt_folder.Click += new System.EventHandler(this.bt_folder_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(64, 71);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(174, 41);
            this.bt_start.TabIndex = 6;
            this.bt_start.Text = "开始";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // openFileDialog_scml
            // 
            this.openFileDialog_scml.DefaultExt = "scml";
            this.openFileDialog_scml.FileName = "openFileDialog1";
            this.openFileDialog_scml.Filter = "Scml|*.scml";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "待转换的scml文件夹";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 124);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_folder);
            this.Controls.Add(this.bt_idle);
            this.Controls.Add(this.tx_folder);
            this.Controls.Add(this.tx_idle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Picture信息同步";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_idle;
        private System.Windows.Forms.TextBox tx_folder;
        private System.Windows.Forms.Button bt_idle;
        private System.Windows.Forms.Button bt_folder;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog_scml;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

