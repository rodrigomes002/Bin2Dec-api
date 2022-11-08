using Bin2Dec.DTO;
using Bin2Dec.Services;
using Microsoft.AspNetCore.Mvc;
using System;

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
            try
            {
                return Ok(this.service.Converter(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
