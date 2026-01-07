using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddController : ControllerBase
    {
        [HttpPost]
        [Route("AddTwoNumbers/{firstNumber}/{secondNumber}")]
        public string Add(int firstNumber, int secondNumber)
        {
            int sum=firstNumber+secondNumber;
            return $"{firstNumber} plus {secondNumber} makes {sum}.";
        }
    }
}