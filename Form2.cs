using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form2 : Form
    {
        private string[] imageFiles;
        private int currentIndex;
        private bool[] frontImageCheked;
        private bool[] upImageCheked;
        private bool[] downImageCheked;
        private bool[] rightImageCheked;
        private bool[] leftImageCheked;
        private bool[] nearImageCheked;
        private bool[] farImageCheked;
        private string frontImageName = "01_front";
        private string upImageName = "02_up";
        private string downImageName = "03_down";
        private string rightImageName = "04_right";
        private string leftImageName = "05_left";
        private string nearImageName = "06_near";
        private string farImageName = "07_far";



        public Form2()
        {
            InitializeComponent();
            clbCopyTo.Enabled = false;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new CommonOpenFileDialog()
            {
                Title = "画像フォルダを選択してください。",
                IsFolderPicker = true,
            })
            {
                if (folderDialog.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                string imageFolderPath = folderDialog.FileName;
                LoadImageFiles(imageFolderPath);
            }
        }

        internal void LoadImageFiles(string imageFolderPath)
        {
            imageFiles = Directory.GetFiles(imageFolderPath)
            .Where(file => file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".jpeg") || file.ToLower().EndsWith(".png"))
            .ToArray();

            if (imageFiles.Length > 0)
            {
                currentIndex = 0;
                frontImageCheked = new bool[imageFiles.Length];
                upImageCheked = new bool[imageFiles.Length];
                downImageCheked = new bool[imageFiles.Length];
                rightImageCheked = new bool[imageFiles.Length];
                leftImageCheked = new bool[imageFiles.Length];
                nearImageCheked = new bool[imageFiles.Length];
                farImageCheked = new bool[imageFiles.Length];
                clbCopyTo.Enabled = true;
                DisplayImage(imageFiles[currentIndex]);
            }
            else
            {
                MessageBox.Show("選択したフォルダに画像ファイルが見つかりませんでした。", "確認");
            }
        }

        private void DisplayImage(string imagePath)
        {
            // 画像を表示するPictureBoxのImageプロパティに画像を設定
            imagePictureBox.ImageLocation = imagePath;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            clbCopyTo.SetItemChecked(0, frontImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(1, upImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(2, downImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(3, rightImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(4, leftImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(5, nearImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(6, farImageCheked[currentIndex]);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayImage(imageFiles[currentIndex]);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                DisplayImage(imageFiles[currentIndex]);
            }
        }

        private void clbCopyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            frontImageCheked[currentIndex] = clbCopyTo.GetItemChecked(0);
            upImageCheked[currentIndex] = clbCopyTo.GetItemChecked(1);
            downImageCheked[currentIndex] = clbCopyTo.GetItemChecked(2);
            rightImageCheked[currentIndex] = clbCopyTo.GetItemChecked(3);
            leftImageCheked[currentIndex] = clbCopyTo.GetItemChecked(4);
            nearImageCheked[currentIndex] = clbCopyTo.GetItemChecked(5);
            farImageCheked[currentIndex] = clbCopyTo.GetItemChecked(6);
        }

        private void buttonExcute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < imageFiles.Length; i++)
            {
                if (frontImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), frontImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);
                }
                else if (upImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), upImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);

                }
                else if (downImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), downImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);

                }
                else if (rightImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), rightImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);
                }
                else if (leftImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), leftImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);
                }
                else if (nearImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), nearImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);
                }
                else if (farImageCheked[i])
                {
                    string extension = Path.GetExtension(imageFiles[i]);
                    string targetFilePath = Path.Combine(Path.GetDirectoryName(imageFiles[i]), farImageName + extension);
                    File.Move(imageFiles[i], targetFilePath);
                }
            }

            MessageBox.Show("画像のリネームが完了しました。");
        }
    }
}
