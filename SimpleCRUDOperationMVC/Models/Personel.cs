using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUDOperationMVC.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        [Required]
        public string  Name { get; set; }

        [Column(TypeName ="nvarchar(40)")]
        [Required]
        public string  Surname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string  Position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string  Address { get; set; }
    }
}
