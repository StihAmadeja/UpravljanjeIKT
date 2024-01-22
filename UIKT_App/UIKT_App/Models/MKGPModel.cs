using System.ComponentModel.DataAnnotations;

namespace UIKT_App
{
    public class MKGPModel
    {
        [Key] public string Id { get; set; }

        [Required]
        [Display(Name = "Kandidat: ")]
        public string Kandidat { get; set; }

        [Required]
        [Display(Name = "Odpri vlogo: ")]
        public string OdpriVlogo { get; set; }

        [Required]
        [Display(Name = "Odpri mnenje: ")]
        public string OdpriMnenje { get; set; }

        [Required]
        [Display(Name = "Ali je vloga odobrena?")]
        public bool JeOdobrenaVloga { get; set; }
    }
}
