using Bin2Dec.DTO;
using System;

namespace Bin2Dec.Services
{
    public class ConverterService
    {
        public int Converter(ConverterDTO dto)
        {
            this.Validate(dto.Binary);

            return Convert.ToInt32(dto.Binary, 2);
        }

        private void Validate(string binary)
        {
            if (binary.Length > 8) throw new ApplicationException("Só é permitido 8 digitos!");
            if (string.IsNullOrWhiteSpace(binary)) throw new ApplicationException("Preencha o número binário!");
        }
    }
}
