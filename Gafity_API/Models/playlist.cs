namespace Gafity_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sosteam.playlist")]
    public partial class playlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public playlist()
        {
            playlist_manager = new HashSet<playlist_manager>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string url_playlist_pic { get; set; }

        [Required]
        [StringLength(255)]
        public string username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<playlist_manager> playlist_manager { get; set; }

        public virtual user_gafity user_gafity { get; set; }
    }
}
