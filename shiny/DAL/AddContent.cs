using shiny.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace shiny.DAL
{
    public class AddContent
    {
        DBContext db = new DBContext();

        public void Insert()
        {
            Item it = new Item();

            Bitmap bm = new Bitmap(@"C:\Users\me\Desktop\SockeHerz.jpg");

            it.Lager = 999;
            it.Preis = 14.99m;
            it.SpeicherOrt = @"C:\Users\me\Desktop\SockeHerz.jpg";
            it.Verkauft = 0;
            it.Bild = new BLL.Converter().ConvertToBase64(bm);
            it.Name = "Herzchensocken";


            db.Items.Add(it);
            db.SaveChanges();
            
        }
    }
}