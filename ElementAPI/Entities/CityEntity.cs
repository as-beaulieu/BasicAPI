using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElementAPI.Entities
{
    public class CityEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        public IEnumerable<LandmarkEntity> Landmarks { get; set; }
            //= new List<LandmarkModel>(); //Initalizing as an empty list to avoid null excemption

    }
}
