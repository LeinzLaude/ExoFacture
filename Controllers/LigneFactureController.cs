using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace ExoFacture.Controllers
{
    public class LigneFactureController : Controller
    {
        private readonly BDD _context;

        public LigneFactureController(BDD context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LigneFactureController>> GetLignesFacture()
        {
            return _context.LignesFacture.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<LigneFactureController> GetLigneFacture(int id)
        {
            var ligneFacture = _context.LignesFacture.Find(id);

            if (ligneFacture == null)
            {
                return NotFound();
            }

            return ligneFacture;
        }

        [HttpPost]
        public ActionResult<LigneFactureController> PostLigneFacture(LigneFactureController ligneFacture)
        {
            _context.LignesFacture.Add(ligneFacture);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetLigneFacture), new { id = ligneFacture.IdLigneFacture }, ligneFacture);
        }

        [HttpPut("{id}")]
        public IActionResult PutLigneFacture(int id, LigneFactureController ligneFacture)
        {
            if (id != ligneFacture.IdLigneFacture)
            {
                return BadRequest();
            }

            _context.Entry(ligneFacture).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLigneFacture(int id)
        {
            var ligneFacture = _context.LignesFacture.Find(id);

            if (ligneFacture == null)
            {
                return NotFound();
            }

            _context.LignesFacture.Remove(ligneFacture);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
