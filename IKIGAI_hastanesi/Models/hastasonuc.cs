namespace IKIGAI_hastanesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hastasonuc")]
    public partial class hastasonuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hastasonuc()
        {
            hepsi = new HashSet<hepsi>();
        }

        public int hastasonucid { get; set; }

        [StringLength(50)]
        public string hastaad { get; set; }

        [StringLength(50)]
        public string hastasoyad { get; set; }

        [StringLength(50)]
        public string hastatc { get; set; }

        [StringLength(50)]
        public string hastadogum { get; set; }

        [StringLength(50)]
        public string hastabolum { get; set; }

        [StringLength(50)]
        public string hastadoktor { get; set; }

        [StringLength(50)]
        public string hastateshis { get; set; }

        [StringLength(50)]
        public string hastailac { get; set; }

        [StringLength(50)]
        public string lab { get; set; }

        [StringLength(50)]
        public string ameliyat { get; set; }

        [StringLength(50)]
        public string ucreta { get; set; }

        [StringLength(50)]
        public string ucretlab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hepsi> hepsi { get; set; }
    }
}
