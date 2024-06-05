using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("RoomType")]
    public class RoomType : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("RoomTypeId")]
        public int RoomTypeId { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int ValuePerNight { get; set; }
    }
}
