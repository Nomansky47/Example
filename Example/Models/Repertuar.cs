namespace Example
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Repertuar")]
    public partial class Repertuar
    {
        [Key]
        public int RepertuarID { get; set; }
        [Required]
        public int PlayID { get; set; }

        [Column(Order = 1, TypeName = "date")]
        public DateTime RDate { get; set; }

        [Column(Order = 2)]
        public TimeSpan RTime { get; set; }

        public virtual Play Play { get; set; }
    }
}
