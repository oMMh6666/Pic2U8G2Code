namespace Pic2U8G2Code
{
    partial class frmPic2U8G2Code
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkGIF2CodeAddBit = new System.Windows.Forms.CheckBox();
            this.btnGIF2Code = new System.Windows.Forms.Button();
            this.lblGIFFileInfo = new System.Windows.Forms.Label();
            this.btnChooseGIFFile = new System.Windows.Forms.Button();
            this.txtGIFFileFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPicFolderFileInfo = new System.Windows.Forms.Label();
            this.chkFolderPic2CodeAddBit = new System.Windows.Forms.CheckBox();
            this.btnFolderPic2Code = new System.Windows.Forms.Button();
            this.btnChoosePicFolder = new System.Windows.Forms.Button();
            this.txtPicFolderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 118);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkGIF2CodeAddBit);
            this.tabPage1.Controls.Add(this.btnGIF2Code);
            this.tabPage1.Controls.Add(this.lblGIFFileInfo);
            this.tabPage1.Controls.Add(this.btnChooseGIFFile);
            this.tabPage1.Controls.Add(this.txtGIFFileFullName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GIF动图(不能有透明色)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkGIF2CodeAddBit
            // 
            this.chkGIF2CodeAddBit.AutoSize = true;
            this.chkGIF2CodeAddBit.Location = new System.Drawing.Point(91, 67);
            this.chkGIF2CodeAddBit.Name = "chkGIF2CodeAddBit";
            this.chkGIF2CodeAddBit.Size = new System.Drawing.Size(156, 16);
            this.chkGIF2CodeAddBit.TabIndex = 9;
            this.chkGIF2CodeAddBit.Text = "每行不足8个点剩余点补1";
            this.chkGIF2CodeAddBit.UseVisualStyleBackColor = true;
            // 
            // btnGIF2Code
            // 
            this.btnGIF2Code.Location = new System.Drawing.Point(11, 63);
            this.btnGIF2Code.Name = "btnGIF2Code";
            this.btnGIF2Code.Size = new System.Drawing.Size(75, 23);
            this.btnGIF2Code.TabIndex = 8;
            this.btnGIF2Code.Text = "生成代码";
            this.btnGIF2Code.UseVisualStyleBackColor = true;
            this.btnGIF2Code.Click += new System.EventHandler(this.btnGIF2Code_Click);
            // 
            // lblGIFFileInfo
            // 
            this.lblGIFFileInfo.AutoSize = true;
            this.lblGIFFileInfo.Location = new System.Drawing.Point(10, 42);
            this.lblGIFFileInfo.Name = "lblGIFFileInfo";
            this.lblGIFFileInfo.Size = new System.Drawing.Size(77, 12);
            this.lblGIFFileInfo.TabIndex = 7;
            this.lblGIFFileInfo.Text = "GIF文件信息:";
            // 
            // btnChooseGIFFile
            // 
            this.btnChooseGIFFile.Location = new System.Drawing.Point(726, 8);
            this.btnChooseGIFFile.Name = "btnChooseGIFFile";
            this.btnChooseGIFFile.Size = new System.Drawing.Size(99, 23);
            this.btnChooseGIFFile.TabIndex = 5;
            this.btnChooseGIFFile.Text = "选择GIF动图...";
            this.btnChooseGIFFile.UseVisualStyleBackColor = true;
            this.btnChooseGIFFile.Click += new System.EventHandler(this.btnChooseGIFFile_Click);
            // 
            // txtGIFFileFullName
            // 
            this.txtGIFFileFullName.Location = new System.Drawing.Point(71, 9);
            this.txtGIFFileFullName.Name = "txtGIFFileFullName";
            this.txtGIFFileFullName.Size = new System.Drawing.Size(649, 21);
            this.txtGIFFileFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "GIF文件:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPicFolderFileInfo);
            this.tabPage2.Controls.Add(this.chkFolderPic2CodeAddBit);
            this.tabPage2.Controls.Add(this.btnFolderPic2Code);
            this.tabPage2.Controls.Add(this.btnChoosePicFolder);
            this.tabPage2.Controls.Add(this.txtPicFolderPath);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量图片(不能有透明色)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPicFolderFileInfo
            // 
            this.lblPicFolderFileInfo.AutoSize = true;
            this.lblPicFolderFileInfo.Location = new System.Drawing.Point(10, 42);
            this.lblPicFolderFileInfo.Name = "lblPicFolderFileInfo";
            this.lblPicFolderFileInfo.Size = new System.Drawing.Size(59, 12);
            this.lblPicFolderFileInfo.TabIndex = 12;
            this.lblPicFolderFileInfo.Text = "图片信息:";
            // 
            // chkFolderPic2CodeAddBit
            // 
            this.chkFolderPic2CodeAddBit.AutoSize = true;
            this.chkFolderPic2CodeAddBit.Location = new System.Drawing.Point(91, 67);
            this.chkFolderPic2CodeAddBit.Name = "chkFolderPic2CodeAddBit";
            this.chkFolderPic2CodeAddBit.Size = new System.Drawing.Size(156, 16);
            this.chkFolderPic2CodeAddBit.TabIndex = 11;
            this.chkFolderPic2CodeAddBit.Text = "每行不足8个点剩余点补1";
            this.chkFolderPic2CodeAddBit.UseVisualStyleBackColor = true;
            // 
            // btnFolderPic2Code
            // 
            this.btnFolderPic2Code.Location = new System.Drawing.Point(11, 63);
            this.btnFolderPic2Code.Name = "btnFolderPic2Code";
            this.btnFolderPic2Code.Size = new System.Drawing.Size(75, 23);
            this.btnFolderPic2Code.TabIndex = 10;
            this.btnFolderPic2Code.Text = "生成代码";
            this.btnFolderPic2Code.UseVisualStyleBackColor = true;
            this.btnFolderPic2Code.Click += new System.EventHandler(this.btnFolderPic2Code_Click);
            // 
            // btnChoosePicFolder
            // 
            this.btnChoosePicFolder.Location = new System.Drawing.Point(726, 8);
            this.btnChoosePicFolder.Name = "btnChoosePicFolder";
            this.btnChoosePicFolder.Size = new System.Drawing.Size(106, 23);
            this.btnChoosePicFolder.TabIndex = 6;
            this.btnChoosePicFolder.Text = "选择图片目录...";
            this.btnChoosePicFolder.UseVisualStyleBackColor = true;
            this.btnChoosePicFolder.Click += new System.EventHandler(this.btnChoosePicFolder_Click);
            // 
            // txtPicFolderPath
            // 
            this.txtPicFolderPath.Location = new System.Drawing.Point(71, 9);
            this.txtPicFolderPath.Name = "txtPicFolderPath";
            this.txtPicFolderPath.Size = new System.Drawing.Size(649, 21);
            this.txtPicFolderPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图片目录:";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(16, 143);
            this.txtCode.MaxLength = 0;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(934, 463);
            this.txtCode.TabIndex = 6;
            this.txtCode.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "C代码:";
            // 
            // frmPic2U8G2Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPic2U8G2Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pic2U8G2Code";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseGIFFile;
        private System.Windows.Forms.TextBox txtGIFFileFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGIF2CodeAddBit;
        private System.Windows.Forms.Button btnGIF2Code;
        private System.Windows.Forms.Label lblGIFFileInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPicFolderPath;
        private System.Windows.Forms.Button btnChoosePicFolder;
        private System.Windows.Forms.CheckBox chkFolderPic2CodeAddBit;
        private System.Windows.Forms.Button btnFolderPic2Code;
        private System.Windows.Forms.Label lblPicFolderFileInfo;
    }
}

