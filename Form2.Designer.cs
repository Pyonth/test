namespace ImageViewer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.clbCopyTo = new System.Windows.Forms.CheckedListBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonExcute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagePictureBox.MinimumSize = new System.Drawing.Size(600, 400);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(600, 400);
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // clbCopyTo
            // 
            this.clbCopyTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCopyTo.CheckOnClick = true;
            this.clbCopyTo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clbCopyTo.FormattingEnabled = true;
            this.clbCopyTo.Items.AddRange(new object[] {
            "1_front",
            "2_up",
            "3_down",
            "4_right",
            "5_left",
            "6_near",
            "7_far"});
            this.clbCopyTo.Location = new System.Drawing.Point(618, 12);
            this.clbCopyTo.Name = "clbCopyTo";
            this.clbCopyTo.Size = new System.Drawing.Size(154, 116);
            this.clbCopyTo.TabIndex = 9;
            this.clbCopyTo.SelectedIndexChanged += new System.EventHandler(this.clbCopyTo_SelectedIndexChanged);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(606, 428);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(94, 21);
            this.buttonSelectFolder.TabIndex = 6;
            this.buttonSelectFolder.Text = "フォルダ選択";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNext.Location = new System.Drawing.Point(706, 134);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(66, 21);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "次へ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPrevious.Location = new System.Drawing.Point(618, 134);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(66, 21);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "前へ";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonExcute
            // 
            this.buttonExcute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExcute.Location = new System.Drawing.Point(706, 428);
            this.buttonExcute.Name = "buttonExcute";
            this.buttonExcute.Size = new System.Drawing.Size(66, 21);
            this.buttonExcute.TabIndex = 10;
            this.buttonExcute.Text = "実行";
            this.buttonExcute.UseVisualStyleBackColor = true;
            this.buttonExcute.Click += new System.EventHandler(this.buttonExcute_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonExcute);
            this.Controls.Add(this.clbCopyTo);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.imagePictureBox);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form2";
            this.Text = "ファイル名変更";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.CheckedListBox clbCopyTo;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonExcute;
    }
}