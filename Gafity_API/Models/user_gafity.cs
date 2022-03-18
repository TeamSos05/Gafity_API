namespace Gafity_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sosteam.user_gafity")]
    public partial class user_gafity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_gafity()
        {
            playlists = new HashSet<playlist>();
        }

        [Key]
        [StringLength(255)]
        public string username { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(4)]
        public string isVip { get; set; }

        [Column(TypeName = "date")]
        public DateTime expried_date { get; set; }

        [Required]
        [StringLength(255)]
        public string url_user_pic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<playlist> playlists { get; set; }
    }
}
