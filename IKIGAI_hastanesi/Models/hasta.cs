namespace IKIGAI_hastanesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hasta")]
    public partial class hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hasta()
        {
            hepsi = new HashSet<hepsi>();
        }

        public int hastaid { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hepsi> hepsi { get; set; }
    }
}
