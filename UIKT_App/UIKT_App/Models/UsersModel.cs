using System.ComponentModel.DataAnnotations;

namespace UIKT_App
{
    public class UsersModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Uporabniško ime:")]
        public string username { get; set; }

        [Required]
        [Display(Name = "Geslo:")]
        public string password { get; set; }

        
    }
}
