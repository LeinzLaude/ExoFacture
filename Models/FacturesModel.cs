using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;


namespace ExoFacture.Models
{
    public class FacturesModel
    {
        [Key]
        public int IdFacture { get; set; }

        [Required]
        public DateTime DateFacturation { get; set; }

        public int IdClient { get; set; }

        [ForeignKey(nameof(IdClient))]
        public ClientModel Client { get; set; }

        public ICollection<LigneFactureModel> LignesFacture { get; set; }
    }
}
