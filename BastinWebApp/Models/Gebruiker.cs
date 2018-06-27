using System;
using System.ComponentModel.DataAnnotations;

namespace BastinWebApp.Models
{
    public class Gebruiker
    {
        public int ID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Paswoord { get; set; }
        public string Privileges { get; set; }
    } 
}
