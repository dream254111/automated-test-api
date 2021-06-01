using AutomatedTestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IUtility _utility;

        public CalculatorController(IUtility utility)
        {
            _utility = utility;
        }

        public IActionResult CalculateGCD([FromBody] NumberRequestDTO input)
        {
            if (input == null)
            {
                NumberResponseDTO error = new NumberResponseDTO
                {
                    Message = "There is no input"
                };

                return BadRequest(error);
            }

            if (input.Number == null)
            {
                NumberResponseDTO error = new NumberResponseDTO
                {
                    Message = "There is no \"number\" property"
                };

                return BadRequest(error);
            }

            int length = input.Number.Length;

            while (length > 1)
            {
                input.Number[length - 2] = _utility.GetGCD(input.Number[length - 1], input.Number[length - 2]);
                length--;
            }

            NumberResponseDTO output = new NumberResponseDTO
            {
                GCD = input.Number[0],
                Message = "Success"
            };

            return Ok(output);
        }
    }
}
