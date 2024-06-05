using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("Favorites")]
    public class Favorites : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("FavoritesId")]
        public int FavoritesId { get; set; }

        //Foreing Key
        public int RoomId { get; set; }
        public int PersonId { get; set; }

        //Virtuals
        public virtual Room Room { get; set; }
        public virtual Person Person { get; set; }
    }
}
