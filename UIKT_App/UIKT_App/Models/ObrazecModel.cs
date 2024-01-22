using System.ComponentModel.DataAnnotations;

namespace UIKT_App.Models
{
    public class ObrazecModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ime: ")]
        public string Ime { get; set; }

        [Required]
        [Display(Name = "Priimek: ")]
        public string Priimek { get; set; }

        [Required]
        [Display(Name = "Datum rojstva: ")]
        [DataType(DataType.Date)]
        public DateTime DatumRojstva { get; set; }

        [Required]
        [Display(Name = "Kraj rojstva:")]
        public string KrajRojstva { get; set; }

        [Required]
        [Display(Name = "Državljanstvo:")]
        public string Drzavljanstvo { get; set; }

        [Required]
        [Display(Name = "Vrsta osebnega dokumenta:")]
        public string OsebniDokument { get; set; }

        [Required]
        [Display(Name = "Številka dokumenta:")]
        public int StevilkaDokumenta { get; set; }

        [Required]
        [Display(Name = "Kraj izdaje dokumenta:")]
        public string KrajIzdajeDokumenta { get; set; }

        [Required]
        [Display(Name = "Datum izdaje dokumenta:")]
        [DataType(DataType.Date)]
        public DateTime DatumIzdajeDokumenta { get; set; }

        [Required]
        [Display(Name = "Do kdaj dokument velja:")]
        [DataType(DataType.Date)]
        public DateTime DatumVeljavnostiDokumenta { get; set; }

        [Required]
        [Display(Name = "Naslov prebivališča v tujini:")]
        public string PrebivalisceTujina { get; set; }

        [Required]
        [Display(Name = "Naslov prebivališča v Sloveniji:")]
        public string PrebivalisceSLO { get; set; }

        [Required]
        [Display(Name = "Telefonska številka:")]
        public int TelefonskaStevilka { get; set; }

        [Required]
        [Display(Name = "E-poštni naslov:")]
        [DataType(DataType.EmailAddress)]
        public string Enaslov { get; set; }

        [Required]
        [Display(Name = "Način obveščanja:")]
        public string NacinObvescanje { get; set; }

        [Required]
        [Display(Name = "Izbira regularnega poklica:")]
        public string Poklic { get; set; }

        [Required]
        [Display(Name = "Ali ste v državi čanici iz katere prihajate kvalificirani za opravljanje zgoraj navedenega reguliranega poklica oziroma dejavnosti? (DA/NE):")]
        public string JeKvalificiran { get; set; }

        [Required]
        [Display(Name = "Ime izobraževalne ustanove:")]
        public string ImeUstanove { get; set; }

        [Required]
        [Display(Name = "Naslov izobraževalne ustanove:")]
        public string NaslovUstanove { get; set; }

        [Required]
        [Display(Name = "Država:")]
        public string DrzavaUstanove { get; set; }
        [Required]
        [Display(Name = "Dodaj prilogo (diplomo/spričevalo) :")]
        public string Priloga { get; set; }
        [Required]
        [Display(Name = "Dodaj ostala dokazila (plačilo...) :")]
        public string Dokazilo { get; set; }

        [Required]
        [Display(Name = "Datum oddaje vloge:")]
        [DataType(DataType.Date)]
        public DateTime DatumOddajeVloge { get; set; }
    }
}
