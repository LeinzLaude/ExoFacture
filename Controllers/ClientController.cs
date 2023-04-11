using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace ExoFacture.Controllers
{
    public class ClientController : Controller
    {
        private readonly BDD _context;

        public ClientController(BDD context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClientController>> GetClients()
        {
            return _context.Clients.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ClientController> GetClient(int id)
        {
            var client = _context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        [HttpPost]
        public ActionResult<ClientController> PostClient(ClientController client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
        }

        [HttpPut("{id}")]
        public IActionResult PutClient(int id, ClientController client)
        {
            if (id != client.IdClient)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
