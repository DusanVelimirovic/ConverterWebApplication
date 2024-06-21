namespace Converter_Web_Application.Utilitie
{
    public static class InputValidator
    {
        public static bool ValidateUserMenuInput(string menu)
        {
            if (!int.TryParse(menu, out int choice) || choice < 1)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateUserConversionValue(string value)
        {
            if (!double.TryParse(value, out double conversionValue) || conversionValue < 0 || conversionValue > double.MaxValue || conversionValue < double.MinValue)
            {
                return false;
            }
            return true;
        }
    }
}
