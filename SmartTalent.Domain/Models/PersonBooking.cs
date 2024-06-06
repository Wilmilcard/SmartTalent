using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("PersonBooking")]
    public class PersonBooking : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PersonBookingId")]
        public int PersonBookingId { get; set; }

        //Foreing Key
        public int BookingId { get; set; }
        public int PersonId { get; set; }

        //Virtuals
        public virtual Booking Booking { get; set; }
        public virtual Person Person { get; set; }
    }
}
