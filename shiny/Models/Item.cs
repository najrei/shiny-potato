namespace shiny.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        public int ItemID { get; set; }

        public string SpeicherOrt { get; set; }

        [Column(TypeName = "money")]
        public decimal? Preis { get; set; }

        public int? Lager { get; set; }

        public int? Verkauft { get; set; }
    }
}
