using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Imaging;

namespace SpriteSheetCreator
{
    public partial class Form1 : Form
    {
        List<Image> imageContainer = new List<Image>();
        List<Image> animImages = new List<Image>();
        bool playAnimation = false;
        public System.Timers.Timer timer;
        int imageNumber = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseImageDialog = new OpenFileDialog();
            chooseImageDialog.Multiselect = true;
            chooseImageDialog.Filter = "Image files|*.png;*.jpg;*.gif | All files|*.*";
            //chooseImageDialog.ShowDialog();

            DialogResult dr = chooseImageDialog.ShowDialog(); //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filenames?view=netframework-4.7.1
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in chooseImageDialog.FileNames)
                {
                    try
                    {
                        Image loadedImage = Image.FromFile(file);
                        imageContainer.Add(loadedImage);
                        IMG_SpriteDisplay.Image = loadedImage;
                        LST_FilesInProj.Items.Add(loadedImage);
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void BTN_playAnim_Click(object sender, EventArgs e)
        {
            playAnimation = !playAnimation;
            LoopAnimation();
            timer1.Start();
        }

        private void LoopAnimation()
        {
            if (playAnimation == true)
            {
                if (imageNumber < animImages.Count - 1)
                    imageNumber++;
                else
                    imageNumber = 0;
                IMG_SpriteDisplay.Image = animImages[imageNumber];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoopAnimation();
        }

        private void BTN_ExportSpriteSheet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.DefaultExt = "png";
            saveImageDialog.FileName = "SpriteSheet";
            saveImageDialog.Filter = "Image files|*.png;*.jpg;*.gif | All files|*.*";

            DialogResult saveresult = saveImageDialog.ShowDialog();
            if (saveresult == System.Windows.Forms.DialogResult.OK) //Om man trycker på spara i dialogrutan
            {
                Bitmap finalImage = new Bitmap(imageContainer[0].Width*imageContainer.Count, imageContainer[0].Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics g = Graphics.FromImage(finalImage);
                Rectangle destRect;
                g.Clear(Color.Transparent);

                // Add drawing commands here
                for (int i = 0; i < imageContainer.Count; i++)
                {
                    destRect = new Rectangle(imageContainer[0].Width*i, 0, imageContainer[0].Width, imageContainer[0].Height);
                    g.DrawImage(imageContainer[i], destRect);
                }

                finalImage.Save(saveImageDialog.FileName, ImageFormat.Png);
                //System.Drawing.Imaging.EncoderParameters parameters = new System.Drawing.Imaging.EncoderParameters(2);
                //parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)EncoderValue.CompressionCCITT4);
                //parameters.Param[1] = new EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                //parameters.Param[1] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.SaveFlag, (long)EncoderValue.FrameDimensionPage);
                //imageContainer[0].Save(saveImageDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                //imageContainer[1].SaveAdd(imageContainer[0], parameters);
            }
        }

        private void LST_FilesInProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            animImages.Clear();
            foreach(Image img in LST_FilesInProj.SelectedItems)
            {
                Image displayImg = (Image)LST_FilesInProj.SelectedItem;
                IMG_SpriteDisplay.Image = displayImg;
                animImages.Add(img);
            }
            //if (LST_FilesInProj.SelectedItem is Image) //Om man har klickat på ett objekt med typen Image
            //{
            //    Image displayImg = (Image)LST_FilesInProj.SelectedItem;
            //    IMG_SpriteDisplay.Image = displayImg;
            //}
        }

        private void BTN_AddAnimSet_Click(object sender, EventArgs e)
        {
            string setName = TXT_SetName.Text;  //Namnet på animation setet
            ImageHolder animSet = new ImageHolder(setName, animImages); //Skapar ett animSet med namnet från setName, och med bilderna som finns i listan animImages
            LST_AnimSets.Items.Add(animSet);
        }

        private void LST_AnimSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_AnimSets.SelectedItem is ImageHolder)
            {
                ImageHolder selectedIMGs = (ImageHolder)LST_AnimSets.SelectedItem;
                LST_FilesInProj.ClearSelected();
                foreach (Image img in selectedIMGs.GetImageList())
                {
                    if(LST_FilesInProj.Items.IndexOf(img) > -1)//Om bilden finns med i listan som innehåller alla bilder i projektet
                    {
                        LST_FilesInProj.SetSelected(LST_FilesInProj.Items.IndexOf(img), true); //Markerar objektet som finns på den hittade bildens position i projektboxen
                    }
                }
            }
        }
    }
}
