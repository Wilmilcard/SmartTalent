using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("Room")]
    public class Room : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("RoomId")]
        public int RoomId { get; set; }

        [Column("RoomNumber")]
        public string RoomNumber { get; set; }
        public bool Availability { get; set; }
        public int MaxGuest { get; set; }

        //Foreing Key
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }

        //Virtuals
        public virtual Hotel Hotel { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
