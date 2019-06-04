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

        public string ConvertToBase64(Image bild)
        {
            using (MemoryStream m = new MemoryStream())
            {
                bild.Save(m, bild.RawFormat);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}