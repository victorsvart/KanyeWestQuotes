using Application.Services;
using Core.Models;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace KanyeQuotes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KanyeQuoteController : ControllerBase
    {
        private readonly IServiceQuote service;

        private readonly ILogger<KanyeQuoteController> _logger;

        public KanyeQuoteController(ILogger<KanyeQuoteController> logger)
        {
            _logger = logger;
            service = new QuoteService();
        }
        [HttpGet]
        public string GetNewQuote()
        {
            var Task = service.RunAsync();
            var quote = Task.Result;
            return quote; 
            
           
        }

       
    }
}