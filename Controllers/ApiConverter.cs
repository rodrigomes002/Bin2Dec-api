using Bin2Dec.DTO;
using Bin2Dec.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bin2Dec.Controllers
{
    [Route("api/converter")]
    [ApiController]
    public class ApiConverter : ControllerBase
    {
        private readonly ConverterService service;
        public ApiConverter(ConverterService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult<int> Converter(ConverterDTO dto)
        {
            return Ok(this.service.Converter(dto));
        }
    }
}
