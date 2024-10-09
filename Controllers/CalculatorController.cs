using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using calservice.Interfaces;
using calservice.Services;

namespace calservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorServices _calculatorService;

        public CalculatorController(ICalculatorServices calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public IActionResult Add(double num1, double num2)
        {
            return Ok(_calculatorService.Add(num1, num2));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double num1, double num2)
        {
            return Ok(_calculatorService.Subtract(num1, num2));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double num1, double num2)
        {
            return Ok(_calculatorService.Multiply(num1, num2));
        }

        [HttpGet("divide")]
        public IActionResult Divide(double num1, double num2)
        {
            try
            {
                return Ok(_calculatorService.Divide(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
