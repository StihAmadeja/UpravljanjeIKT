using System.ComponentModel.DataAnnotations;

namespace UIKT_App
{
    public class Form
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Ime { get; set; }
        [Required]
        public string Priimek { get; set; }
        [Required]
        public DateTime DatumRojstva { get; set; }
        [Required]
        public string KrajRojstva { get; set; }
        [Required]
        public string Drzavljanstvo { get; set; }
        [Required]
        public string OsebniDokument { get; set; }
        [Required]
        public int StevilkaDokumenta {  get; set; }
        [Required]
        public string KrajIzdajeDokumenta { get; set; }
        [Required]
        public DateTime DatumIzdajeDokumenta { get; set; }
        [Required]
        public DateTime DatumVeljavnostiDokumenta { get; set; }
        [Required]
        public string PrebivalisceTujina { get; set; }
        [Required]
        public string PrebivalisceSLO { get; set; }
        [Required]
        public int TelefonskaStevilka { get; set; }
        [Required]
        public string Enaslov { get; set; }
        [Required]
        public string NacinObvescanje { get; set; }
        [Required]
        public string Poklic { get; set; }
        [Required]
        public bool JeKvalificiran { get; set; }
        [Required]
        public string ImeUstanove { get; set; }
        [Required]
        public string NaslovUstanove { get; set; }
        [Required]
        public string DrzavaUstanove { get; set; }
        [Required]
        public string Priloga { get; set; }
        [Required]
        public string Dokazilo { get; set; }
        [Required]
        public DateTime DatumOddajeVloge { get; set; }
    }
}
