using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace Converter_Web_Application.Service
{
    public class ConversionManagerService
    {
        private readonly List<IConversion> _conversions = new List<IConversion>();

        public void RegisterConversion(IConversion conversion)
        {
            _conversions.Add(conversion);
        }

        public IConversion GetConversion(int id)
        {
            return _conversions.FirstOrDefault(c => c.Id == id);
        }

        public List<IConversion> GetAllConversions()
        {
            return _conversions;
        }
    }
}
