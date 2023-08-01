namespace ImageViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonExcute = new System.Windows.Forms.Button();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.clbCopyTo = new System.Windows.Forms.CheckedListBox();
            this.buttonRename = new System.Windows.Forms.Button();
            this.tbOutPath = new System.Windows.Forms.TextBox();
            this.buttonSelectOutFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResize = new System.Windows.Forms.CheckBox();
            this.btnResize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPrevious.Location = new System.Drawing.Point(618, 78);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(66, 21);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "前へ";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(706, 78);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(66, 21);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "次へ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonExcute
            // 
            this.buttonExcute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExcute.Location = new System.Drawing.Point(706, 430);
            this.buttonExcute.Name = "buttonExcute";
            this.buttonExcute.Size = new System.Drawing.Size(66, 21);
            this.buttonExcute.TabIndex = 0;
            this.buttonExcute.Text = "実行";
            this.buttonExcute.UseVisualStyleBackColor = true;
            this.buttonExcute.Click += new System.EventHandler(this.buttonExcute_Click);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(618, 430);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(82, 21);
            this.buttonSelectFolder.TabIndex = 0;
            this.buttonSelectFolder.Text = "フォルダ選択";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagePictureBox.MinimumSize = new System.Drawing.Size(600, 400);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(600, 400);
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            // 
            // clbCopyTo
            // 
            this.clbCopyTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCopyTo.CheckOnClick = true;
            this.clbCopyTo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clbCopyTo.FormattingEnabled = true;
            this.clbCopyTo.Items.AddRange(new object[] {
            "1",
            "2_本物",
            "3_偽物",
            "その他"});
            this.clbCopyTo.Location = new System.Drawing.Point(618, 12);
            this.clbCopyTo.Name = "clbCopyTo";
            this.clbCopyTo.Size = new System.Drawing.Size(154, 60);
            this.clbCopyTo.TabIndex = 5;
            this.clbCopyTo.SelectedIndexChanged += new System.EventHandler(this.clbCopyTo_SelectedIndexChanged);
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRename.Location = new System.Drawing.Point(518, 430);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(94, 21);
            this.buttonRename.TabIndex = 6;
            this.buttonRename.Text = "ファイル名変更";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // tbOutPath
            // 
            this.tbOutPath.Location = new System.Drawing.Point(57, 430);
            this.tbOutPath.Name = "tbOutPath";
            this.tbOutPath.Size = new System.Drawing.Size(400, 19);
            this.tbOutPath.TabIndex = 7;
            // 
            // buttonSelectOutFolder
            // 
            this.buttonSelectOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectOutFolder.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectOutFolder.Location = new System.Drawing.Point(463, 430);
            this.buttonSelectOutFolder.Name = "buttonSelectOutFolder";
            this.buttonSelectOutFolder.Size = new System.Drawing.Size(25, 21);
            this.buttonSelectOutFolder.TabIndex = 8;
            this.buttonSelectOutFolder.Text = "...";
            this.buttonSelectOutFolder.UseVisualStyleBackColor = true;
            this.buttonSelectOutFolder.Click += new System.EventHandler(this.buttonSelectOutFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "出力先：";
            // 
            // cbResize
            // 
            this.cbResize.AutoSize = true;
            this.cbResize.Location = new System.Drawing.Point(618, 114);
            this.cbResize.Name = "cbResize";
            this.cbResize.Size = new System.Drawing.Size(60, 16);
            this.cbResize.TabIndex = 10;
            this.cbResize.Text = "リサイズ";
            this.cbResize.UseVisualStyleBackColor = true;
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnResize.Location = new System.Drawing.Point(695, 111);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(77, 21);
            this.btnResize.TabIndex = 11;
            this.btnResize.Text = "サイズ設定";
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.cbResize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectOutFolder);
            this.Controls.Add(this.tbOutPath);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.clbCopyTo);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.buttonExcute);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "画像仕分け";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonExcute;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.CheckedListBox clbCopyTo;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TextBox tbOutPath;
        private System.Windows.Forms.Button buttonSelectOutFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbResize;
        private System.Windows.Forms.Button btnResize;
    }
}

