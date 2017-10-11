using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElementAPI.Entities
{
    public class LandmarkEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        //Navigation Properties to parent City
        [ForeignKey("CityId")]
        public CityEntity City { get; set; }
        public int CityId { get; set; }
    }
}
