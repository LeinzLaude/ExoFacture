using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace ExoFacture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturesController : ControllerBase
    {

        private readonly BDD _context;

        public FacturesController(BDD context)
        {
            _context = context;
        }

        // GET: api/Factures
        [HttpGet]
        public ActionResult<IEnumerable<FacturesController>> GetFactures()
        {
            return _context.Factures.ToList();
        }

        // GET: api/Factures/5
        [HttpGet("{id}")]
        public ActionResult<FacturesController> GetFacture(int id)
        {
            var facture = _context.Factures.Find(id);

            if (facture == null)
            {
                return NotFound();
            }

            return facture;
        }

        // POST: api/Factures
        [HttpPost]
        public ActionResult<FacturesController> PostFacture(FacturesController facture)
        {
            _context.Factures.Add(facture);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetFacture), new { id = facture.IdFacture }, facture);
        }

        // PUT: api/Factures/5
        [HttpPut("{id}")]
        public IActionResult PutFacture(int id, FacturesController facture)
        {
            if (id != facture.IdFacture)
            {
                return BadRequest();
            }

            _context.Entry(facture).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Factures/5
        [HttpDelete("{id}")]
        public IActionResult DeleteFacture(int id)
        {
            var facture = _context.Factures.Find(id);

            if (facture == null)
            {
                return NotFound();
            }

            _context.Factures.Remove(facture);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
