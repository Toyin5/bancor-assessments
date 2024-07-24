using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ScratchCard.interfaces;
using ScratchCard.Models;

namespace ScratchCard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
       

        private readonly ILogger<CardController> _logger;
        private readonly ICardRepository _cardRepository;

        public CardController(ILogger<CardController> logger, ICardRepository cardRepository)
        {
            _logger = logger;
            _cardRepository = cardRepository;
        }

        [HttpPost("generatecards")]
        public async Task<ActionResult> GenerateCards([FromBody] int count)
        {
            await _cardRepository.GenerateCards(count);
            return Ok("Generated successfully");
        }

        [HttpGet("Getallcards")]
        public async Task<ActionResult> GetAllCards([FromQuery] CardStatus cardStatus)
        {
            var result = await _cardRepository.GetCards(cardStatus);
            return Ok(result);
        }
    }
}
