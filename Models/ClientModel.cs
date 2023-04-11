using System.ComponentModel.DataAnnotations;

namespace ExoFacture.Models
{
    public class ClientModel
    {
        [Key]
        public int IdClient { get; set; }

        [Required(ErrorMessage = "Le nom du client est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "L'adresse du client est obligatoire")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal du client est obligatoire")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "La ville du client est obligatoire")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Le pays du client est obligatoire")]
        public string Pays { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
    }
}
