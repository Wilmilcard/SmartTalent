using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain.Models
{
    [Table("Person")]
    public class Person : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PersonId")]
        public int PersonId { get; set; }

        [StringLength(100)]
        [Column(TypeName = "VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Name { get; set; }
        
        [StringLength(100)]
        [Column(TypeName = "VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string LastName { get; set; }

        [Column("Birth")]
        public DateTime Birth { get; set; }

        [Column("Gender")]
        public char Gender { get; set; }

        [Column("Document")]
        public char Document { get; set; }

        [Column("Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("Phone")]
        [StringLength(30)]
        public string Phone { get; set; }
        
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }

        //Foreing Key
        public int DocTypeId { get; set; }
        public int RolTypeId { get; set; }

        //Virtuals
        public virtual DocType DocType { get; set; }
        public virtual RolType RolType { get; set; }

    }
}
