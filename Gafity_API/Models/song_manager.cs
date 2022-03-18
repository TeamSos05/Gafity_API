namespace Gafity_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sosteam.song_manager")]
    public partial class song_manager
    {
        [Key]
        public int no { get; set; }

        public int song_id { get; set; }

        public int artist_id { get; set; }

        public virtual artist artist { get; set; }

        public virtual song song { get; set; }
    }
}
