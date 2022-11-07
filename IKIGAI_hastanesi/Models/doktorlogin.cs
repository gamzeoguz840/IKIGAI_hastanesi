namespace IKIGAI_hastanesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("doktorlogin")]
    public partial class doktorlogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktorlogin()
        {
            hepsi = new HashSet<hepsi>();
        }

        [Key]
        public int doktorid { get; set; }

        [StringLength(11)]
        public string doktortc { get; set; }

        [StringLength(8)]
        public string doktorsifre { get; set; }

        [StringLength(50)]
        public string doktorad { get; set; }

        [StringLength(50)]
        public string doktorsoyad { get; set; }

        [StringLength(50)]
        public string doktorbolum { get; set; }

        [StringLength(50)]
        public string doktoryas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hepsi> hepsi { get; set; }
    }
}
