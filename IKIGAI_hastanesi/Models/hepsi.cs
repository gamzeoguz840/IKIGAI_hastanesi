namespace IKIGAI_hastanesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hepsi")]
    public partial class hepsi
    {
        public int hepsiid { get; set; }

        public int? doktorid { get; set; }

        public int? hastaid { get; set; }

        public int? hastasonucid { get; set; }

        public virtual doktorlogin doktorlogin { get; set; }

        public virtual hasta hasta { get; set; }

        public virtual hastasonuc hastasonuc { get; set; }
    }
}
