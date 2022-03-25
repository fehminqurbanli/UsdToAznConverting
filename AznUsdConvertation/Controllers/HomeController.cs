using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AznUsdConvertation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("addnumbers")]
        public IActionResult AddNumbers(double num1, double num2, double num3)
        {
            string pathForUsd = @"D:\gunluk_csharp_ornekler\SmartSolution\AznUsdConvertation\Usd_Currency_.txt";
            string pathForAzn = @"D:\gunluk_csharp_ornekler\SmartSolution\AznUsdConvertation\Azn_Currency_.txt";

            using (StreamWriter sw = new StreamWriter(pathForUsd))
            {
                sw.WriteLine("$ " + num1);
                sw.WriteLine("$ " + num2);
                sw.WriteLine("$ " + num3);
            }
            using (StreamWriter sw = new StreamWriter(pathForAzn))
            {
                double aznNum1 = num1 * 1.7;
                double aznNum2 = num2 * 1.7;
                double aznNum3 = num3 * 1.7;

                sw.WriteLine(aznNum1 + " Azn");
                sw.WriteLine(aznNum2 + " Azn");
                sw.WriteLine(aznNum3 + " Azn");
            }
            return Ok();
        }
    }
}
