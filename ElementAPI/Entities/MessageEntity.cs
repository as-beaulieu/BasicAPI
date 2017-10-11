using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Entities
{
    public class MessageEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SecondId { get; set; }
        public Guid ThirdId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        

    }
}
