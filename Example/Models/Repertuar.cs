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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime RDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public TimeSpan RTime { get; set; }

        public virtual Play Play { get; set; }
    }
}
