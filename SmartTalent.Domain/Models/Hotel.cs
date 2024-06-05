using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("Hotel")]
    public class Hotel : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("HotelId")]
        public int HotelId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public bool Availability { get; set; }

        //Foreing Key
        public int CityId { get; set; }

        //Virtuals
        public virtual City City { get; set; }
    }
}
