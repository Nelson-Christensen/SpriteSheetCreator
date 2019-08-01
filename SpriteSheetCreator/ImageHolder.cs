using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpriteSheetCreator
{
    public class ImageHolder
    {
        string name = "";
        List<Image> imgList = new List<Image>();
        Image singImage;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public ImageHolder(string name, Image img)
        {
            Width = img.Width;
            Height = img.Height;
            singImage = img;
            this.name = name;
        }
        public ImageHolder(string name, List<Image> imgList)
        {
            foreach(Image img in imgList)
            {
                Width += img.Width;
                Height += img.Height;
                this.imgList.Add(img);
            }
            this.name = name;
        }
        public Image GetImage()
        {
            return singImage;
        }
        public List<Image> GetImageList()
        {
            return imgList;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
