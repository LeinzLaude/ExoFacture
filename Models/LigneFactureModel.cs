using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace ExoFacture.Models
{
    public class LigneFactureModel
    {
        public int IdLigneFacture { get; set; }

        [ForeignKey(nameof(Produit))]
        public int IdProduit { get; set; }
        public ProduitModel Produit { get; set; }

        [ForeignKey(nameof(IdFacture))]
        public int IdFacture { get; set; }
        public FacturesModel Facture { get; set; }

        [Required]
        public decimal PrixUnitaire { get; set; }

        [Required]
        public int Quantite { get; set; }

        public decimal Total => Quantite * PrixUnitaire;

    }
}
