using System.ComponentModel.DataAnnotations;

namespace UIKT_App.Models
{
    public class VetModel
    {
        [Key] public string Id { get; set; }

        [Required]
        [Display(Name = "Kandidat: ")]
        public string Kandidat { get; set; }

        [Required]
        [Display(Name = "Mnenje: ")]
        public string Mnenje { get; set; }

        [Required]
        [Display(Name = "Ali kandidat opravil izobraževanje?")]
        public bool JeOpravil { get; set; }
    }
}
