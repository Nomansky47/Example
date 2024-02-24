namespace Example
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int TicketID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TDate { get; set; }

        public int PlayID { get; set; }

        public int TRow { get; set; }

        public int TSeat { get; set; }

        public int TCost { get; set; }

        public virtual Play Play { get; set; }
    }
}
