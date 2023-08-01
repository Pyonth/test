using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    internal class Resize
    {
        private int sizeKB;
        private int width;
        private int height;
        
        public Resize(int sizeKB, int width, int height)
        {
            SizeKB = sizeKB;
            Width = width;
            Height = height;

        }

        public int SizeKB
        {
            get { return sizeKB; }
            set { sizeKB  = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void resizeKB(int sizeKB)
        {

        }
    }


}
