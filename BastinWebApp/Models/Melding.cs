using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BastinWebApp.Models
{
    public class Melding
    {
        public int ID { get; set; }
        public TypeMelding TypeMelding { get; set; }
        public DateTime Datum { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public DateTime AgendaDatum { get; set; }       // Enkel voor Agendapunt (5)
        public string Titel { get; set; }
        public string Ondertitel { get; set; }
        public string Omschrijving { get; set; }
        public Afdeling Afdeling { get; set; }
        public Machine Machine { get; set; }
        public string Klant { get; set; }               // Enkel voor Klacht (1) / Afwijking (2)
        public string Link { get; set; }                // Enkel voor Mededeling (4) / Agendapunt (5)
        public string AfbeeldingPad { get; set; }       // Enkel voor Mededeling (4) / Agendapunt (5)
        public string ProcedurePad { get; set; }        // Enkel voor BRC / ISO (3)
    }

    public enum TypeMelding
    {
        [Display(Name = "Klacht")] Klacht = 1,
        [Display(Name = "Interne Afwijking")] InterneAfwijking = 2,
        [Display(Name = "ISO / BRC")] ISOBRC = 3,
        [Display(Name = "Mededeling")]Mededeling = 4,
        [Display(Name = "Agendapunt")]Agendapunt = 5
    }


    public enum Afdeling 
    {
        Drukkerij = 1,
        Lamineuse = 2,
        Snijafdeling = 3,
        Zakkenafdeling = 4,
        [Display(Name = "Productie Algemeen")] ProductieAlgemeen = 5,
        [Display(Name = "Technische Dienst")] TechnischeDienst = 6,
        Administratie = 7,
        Sales = 8
    }


    public enum Machine
    {
        Allstein = 1,
        [Display(Name = "F&K")]FK = 2,
        Comexi = 3,
        Lamineuse = 4,
        Pantheira1 = 5,
        Pantheira2 = 6,
        Pantheira3 = 7,
        CP3 = 8,
        Triumph1 = 9,
        Triumph2 = 10,
        Triumph2B = 11,
        Triumph3 = 12,
        Coupeuse = 13
    }

}