namespace ExoFacture.Models
{
    public class TvaModel
    {
        public int Id { get; set; }
        public float Taux { get; set; }
        public DateTime DateDebutTVA { get; set; }
        public DateTime DateFinTVA { get; set; }
    }
}
