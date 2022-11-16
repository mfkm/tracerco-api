using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerco_api.Interfaces;

namespace tracerco_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {
        private readonly ISimpleCalculator _calculatorService;

        [HttpGet]
        [Route("Add")]
        public int Add(int start, int amount)
        {
            return _calculatorService.Add(start, amount);
        }

        [HttpGet]
        [Route("Divide")]
        public int Divide(int start, int by)
        {
            return _calculatorService.Divide(start, by);
        }

        [HttpGet]
        [Route("Multiply")]
        public int Multiply(int start, int by)
        {
            return _calculatorService.Multiply(start, by);
        }

        [HttpGet]
        [Route("Subtract")]
        public int Subtract(int start, int amount)
        {
            return _calculatorService.Subtract(start, amount);
        }

    }
}
