using Zeats.Legacy.StringExtensions;

namespace Zeats.Legacy.CEP
{
    public static class CepHelper
    {
        public static bool IsValid(string cep)
        {
            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
                return false;

            return cep.HasOnlyNumbers();
        }

        public static string Format(string cep)
        {
            if (!IsValid(cep))
                return cep;

            cep = $"{cep.Substring(0, 2)}.{cep.Substring(2, 3)}-{cep.Substring(5, 3)}";

            return cep;
        }
    }
}