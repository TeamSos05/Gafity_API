namespace Gafity_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sosteam.artist")]
    public partial class artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artist()
        {
            song_manager = new HashSet<song_manager>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string artist_name { get; set; }

        [Required]
        [StringLength(7000)]
        public string biography { get; set; }

        [Required]
        [StringLength(255)]
        public string url_profile_pic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<song_manager> song_manager { get; set; }
    }
}
