using CaseConverter.Core;
using Microsoft.AspNetCore.Mvc;

namespace CaseConverter.WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaseConverterController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string str)
        {
            string output = CaseConversionHelper.ConvertPascalCaseToSnakeCase(str);
            return Ok(output);
        }
    }
}
