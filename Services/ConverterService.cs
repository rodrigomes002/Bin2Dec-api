using Bin2Dec.DTO;
using System;

namespace Bin2Dec.Services
{
    public class ConverterService
    {
        public int Converter(ConverterDTO dto)
        {
            return Convert.ToInt32(dto.Binary, 2);
        }
    }
}
