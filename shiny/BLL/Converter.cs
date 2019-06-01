using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace shiny.BLL
{
    public class Converter
    {
        public Bitmap ConvertToBitmap(byte[] bild)
        {
            var ms = new MemoryStream(bild);
            return new Bitmap(ms);
            

        }

        public byte[] ConvertToByteArray(Image bild)
        {
            ImageConverter convert = new ImageConverter();
            return (byte[])convert.ConvertTo(bild, typeof(byte[]));
        }
    }
}