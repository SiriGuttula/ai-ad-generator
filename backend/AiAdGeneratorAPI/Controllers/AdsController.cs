using AiAdGeneratorAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AiAdGeneratorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdsController : ControllerBase
    {
        private readonly OpenAIService _openAI;

        public AdsController(OpenAIService openAI)
        {
            _openAI = openAI;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateAd([FromBody] AdRequest request)
        {
            string prompt = $@"
Create a marketing advertisement.

Product: {request.ProductName}
Description: {request.Description}
Audience: {request.Audience}
Platform: {request.Platform}

Provide:
Headline
Description
Call To Action
";

            var result = await _openAI.GenerateAd(prompt);

            return Ok(result);
        }
    }
}