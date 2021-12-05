using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using offerpool_bl.Data;
using offerpool_bl.ModelDTO;
using offerpool_bl.Models;

namespace offerpool_bl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly DataContext _context;

        public OfferController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Offer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfferDTO>>> GetOffer()
        {
            return await _context.Offer
            .Select(x => OfferToDTO(x))
            .ToListAsync();
        }

        // GET: api/Offer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfferDTO>> GetOffer(int id)
        {
            var offer = await _context.Offer.FindAsync(id);

            if (offer == null)
            {
                return NotFound();
            }

            return OfferToDTO(offer);
        }

        // PUT: api/Offer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffer(int iOfferId, OfferDTO offerDTO)
        {
            if (iOfferId != offerDTO.offer_id)
            {
                return BadRequest();
            }

            var oOffer = await _context.Offer.FindAsync(iOfferId);
            if (oOffer == null)
            {
                return NotFound();
            }
            oOffer.offer_header = offerDTO.offer_header;
            oOffer.offer_contact = offerDTO.offer_contact;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!OfferExists(iOfferId))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Offer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfferDTO>> CreateOffer(OfferDTO offerDTO)
        {
            Offer offer = new Offer
            {
                offer_contact = offerDTO.offer_contact,
                offer_header = offerDTO.offer_header
            };

            _context.Offer.Add(offer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetOffer), new {id = offer.offer_id},
                OfferToDTO(offer) 
            );
        }

        // DELETE: api/Offer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            var offer = await _context.Offer.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }

            _context.Offer.Remove(offer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfferExists(int id)
        {
            return _context.Offer.Any(e => e.offer_id == id);
        }

        private static OfferDTO OfferToDTO(Offer offer) => 
        new OfferDTO
        {
            offer_id = offer.offer_id,
            offer_header = offer.offer_header,
            offer_contact = offer.offer_contact
        };
    }
}
