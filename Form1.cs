using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentIndex;
        private bool[] faceImageCheked;
        private bool[] realImageCheked;
        private bool[] fakeImageCheked;
        private bool[] etcCheked;
        private string userEmail;
        private string userName;
        private string originalImageOutFolder;
        private string faceImageOutFolder;
        private string realImageOutFolder;
        private string fakeImageOutFolder;
        private string etcImageOutFolder;
        
        private string rootOutFolderPath;
 
        public Form1()
        {
            InitializeComponent();
            rootOutFolderPath = "C:\\Users\\runni\\Desktop\\検証用データ";
            tbOutPath.Text = rootOutFolderPath;
            clbCopyTo.Enabled = false;
        }

        private void buttonSelectOutFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new CommonOpenFileDialog()
            {
                Title = "出力先のフォルダを選択してください。",
                IsFolderPicker = true,
            })
            {
                if (folderDialog.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                rootOutFolderPath = folderDialog.FileName;
                tbOutPath.Text = rootOutFolderPath;
            }
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {

            using (var folderDialog = new CommonOpenFileDialog()
            {
                Title = "収集データのフォルダを選択してください。",
                IsFolderPicker = true,
            })
            {
                if (folderDialog.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                string imageFolderPath = folderDialog.FileName;
                imageFiles = Directory.GetFiles(imageFolderPath)
                        .Where(file => file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".jpeg") || file.ToLower().EndsWith(".png"))
                        .ToArray();

                if (imageFiles.Length > 0)
                {
                    currentIndex = 0;
                    faceImageCheked = new bool[imageFiles.Length];
                    realImageCheked = new bool[imageFiles.Length];
                    fakeImageCheked = new bool[imageFiles.Length];
                    etcCheked = new bool[imageFiles.Length];
                    userEmail = new DirectoryInfo(imageFolderPath).Name;
                    userName = userEmail.Split('@')[0];
                    originalImageOutFolder = Path.Combine(rootOutFolderPath, userEmail, "01_");
                    faceImageOutFolder = Path.Combine(rootOutFolderPath, userEmail, "02_", userName);
                    realImageOutFolder = Path.Combine(rootOutFolderPath, userEmail, "03_", userName + "_real"); 
                    fakeImageOutFolder = Path.Combine(rootOutFolderPath, userEmail, "03_", userName + "_fake");
                    etcImageOutFolder = Path.Combine(rootOutFolderPath, userEmail);
                    clbCopyTo.Enabled = true;
                    DisplayImage(imageFiles[currentIndex]);
                }
                else
                {
                    MessageBox.Show("選択したフォルダに画像ファイルが見つかりませんでした。", "確認");
                }
            }

        }


        private void DisplayImage(string imagePath)
        {
            // 画像を表示するPictureBoxのImageプロパティに画像を設定
            imagePictureBox.ImageLocation = imagePath;
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            clbCopyTo.SetItemChecked(0, faceImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(1, realImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(2, fakeImageCheked[currentIndex]);
            clbCopyTo.SetItemChecked(3, etcCheked[currentIndex]);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(currentIndex > 0)
            {
                currentIndex--;
                DisplayImage(imageFiles[currentIndex]);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                DisplayImage(imageFiles[currentIndex]);
            }
        }

        private void clbCopyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            faceImageCheked[currentIndex] = clbCopyTo.GetItemChecked(0);
            realImageCheked[currentIndex] = clbCopyTo.GetItemChecked(1);
            fakeImageCheked[currentIndex] = clbCopyTo.GetItemChecked(2);
            etcCheked[currentIndex] = clbCopyTo.GetItemChecked(3);
        }

        private void buttonExcute_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(originalImageOutFolder))
            {
                Directory.CreateDirectory(originalImageOutFolder);
            }
            if (!Directory.Exists(faceImageOutFolder))
            {
                Directory.CreateDirectory(faceImageOutFolder);
            }
            if (!Directory.Exists(realImageOutFolder))
            {
                Directory.CreateDirectory(realImageOutFolder);
            }
            if (!Directory.Exists(fakeImageOutFolder))
            {
                Directory.CreateDirectory(fakeImageOutFolder);
            }

            for (int i = 0; i < imageFiles.Length; i++)
            {
                File.Copy(imageFiles[i], Path.Combine(originalImageOutFolder, Path.GetFileName(imageFiles[i])), overwrite: true);

                if (faceImageCheked[i])
                {
                    File.Copy(imageFiles[i], Path.Combine(faceImageOutFolder, Path.GetFileName(imageFiles[i])), overwrite: true);
                }
                if (realImageCheked[i])
                {
                    File.Copy(imageFiles[i], Path.Combine(realImageOutFolder, Path.GetFileName(imageFiles[i])), overwrite: true);
                }
                if (fakeImageCheked[i])
                {
                    File.Copy(imageFiles[i], Path.Combine(fakeImageOutFolder, Path.GetFileName(imageFiles[i])), overwrite: true);
                }
                if (etcCheked[i])
                {
                    File.Copy(imageFiles[i], Path.Combine(etcImageOutFolder, Path.GetFileName(imageFiles[i])), overwrite: true);
                }
            }

            MessageBox.Show("画像のコピーが完了しました。");
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            if(faceImageOutFolder != null)
            {
                form2.LoadImageFiles(faceImageOutFolder);
            }
        }


    }
}
