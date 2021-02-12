using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerTest.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Index(
            [FromQuery, Required] int int2,
            [FromQuery] string? string1,
            [FromQuery] string string2,
            [FromQuery] int? int1 = null)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Index([FromBody] TestDto dto)
        {
            return Ok();
        }

        [HttpGet("Enum")]
        public ActionResult EnumTest([FromQuery] TestEnum t)
        {
            return Ok();
        }
    }

    public class TestDto
    {
        public int? NullableInt { get; set; }
        public int NonNullableInt { get; set; }
        public string? NullableString { get; set; }
        public string NonNullableString { get; set; }
        public TestEnum TestEnum { get; set; }
    }

    public enum TestEnum
    {
        Item1 = 1,
        Item2 = 2
    }
}