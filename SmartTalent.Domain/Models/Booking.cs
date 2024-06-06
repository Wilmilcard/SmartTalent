using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("Booking")]
    public class Booking : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("BookingId")]
        public int BookingId { get; set; }
        [StringLength(6)]
        public string Code { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Availability { get; set; }
        public double TotalGuest { get; set; }
        public double BaseCost { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }

        //Foreing Key
        public int RoomId { get; set; }
        public int PersonId { get; set; }

        //Virtuals
        public virtual Room Room { get; set; }
        public virtual Person Person { get; set; }

    }
}
