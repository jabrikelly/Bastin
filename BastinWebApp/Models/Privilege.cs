using System;
using System.ComponentModel.DataAnnotations;

namespace BastinWebApp.Models
{
    public class Privilege
    {
        [Key]
        public int ID { get; set; }
        public string Privileges { get; set; }
    }
}
