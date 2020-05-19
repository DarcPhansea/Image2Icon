using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

//thanks to https://gist.github.com/darkfall/1656050

namespace Png2Ico {
    class Converter {

        private static bool Convert(Stream instream, Stream outstream, float percent = 1, bool keepRatio = false) {
            Bitmap inbits = (Bitmap)Bitmap.FromStream(instream);
            if (inbits == null) return false;

            float width = (inbits.Width * percent), size = (inbits.Width * percent), height = (inbits.Width * percent);
            
            //keep the aspect ratio of img
            if (keepRatio) {
                if (inbits.Width > inbits.Height)
                    height = (((float)inbits.Height / inbits.Width) * size);
                else
                    width = (((float)inbits.Width / inbits.Height) * size);
            }

            //create a new resized image in memory
            Bitmap newbits = new Bitmap(inbits, new Size((int)width, (int)height));
            if (newbits == null) return false;

            using (MemoryStream memData = new MemoryStream()) {
                newbits.Save(memData, ImageFormat.Png);

                //Create the icon writer
                BinaryWriter icoWriter = new BinaryWriter(outstream);
                if (outstream == null || icoWriter == null) return false;

                //Create the icon
                icoWriter.Write((byte)0); //reserved
                icoWriter.Write((byte)0); //reserved
                icoWriter.Write((short)1); //img Type (1 = ico, 2 = cur)
                icoWriter.Write((short)1); //# of images
                icoWriter.Write((byte)width); //width
                icoWriter.Write((byte)height); //height
                icoWriter.Write((byte)0); //# of colors
                icoWriter.Write((byte)0); //reserved
                icoWriter.Write((short)0); //color planes
                icoWriter.Write((short)32); //bits per pixel
                icoWriter.Write((int)memData.Length); //size of img data
                icoWriter.Write((int)(6 + 16)); //offset of img data
                icoWriter.Write(memData.ToArray()); //img data
                icoWriter.Flush();
            }

            return true;
        }

        public static bool Convert(string input, string output, float percent = 100, bool keepRatio = false) {
            using (FileStream instream = new FileStream(input, FileMode.Open))
            using (FileStream outstream = new FileStream(output, FileMode.OpenOrCreate)) {
                return Convert(instream, outstream, (percent / 100), keepRatio);
            }
        }
    }
}
