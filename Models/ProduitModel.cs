using System.ComponentModel.DataAnnotations;

namespace ExoFacture.Models
{
    public class ProduitModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description_Produit { get; set; }

        [Required]
        public decimal PrixUnitaire { get; set; }
    }
}
