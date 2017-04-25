using System;
using System.ComponentModel.DataAnnotations;

namespace TrainFinder.Domain.Entities
{
    public class Train
    {      
        public int TrainID { get; set; }
        
        public int Number { get; set; }

        
        [Required(ErrorMessage ="Proszę podać odpowiedni numer Peronu.")]
        [Display(Name = "Peron")]
        public int Platform { get; set; }

        [Required(ErrorMessage ="Proszę podać ostatnią stację pociągu.")]
        [Display(Name = "Aktualne położenie")]
        public string Localization { get; set; }

        [Required(ErrorMessage ="Proszę podać cel podróży pociągu.")]
        [Display(Name = "Cel")]
        public string Destination { get; set; }
      
        [Required(ErrorMessage ="Proszę podać czas przyjazdu pociągu.")]
        [Display(Name = "Godzina przyjazdu")]
        public TimeSpan Arrival { get; set; }

        [Required(ErrorMessage ="Prosze podać czas odjazdu pociągu.")]
        [Display(Name = "Godzina odjazdu")]
        public TimeSpan Departure { get; set; }

        [Required(ErrorMessage ="Proszę podać aktualny satus pociągu.")]
        public string Status { get; set; }
    }
}
