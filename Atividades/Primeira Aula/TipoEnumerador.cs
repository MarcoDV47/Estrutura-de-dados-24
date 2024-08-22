using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira_Aula
{
    public class TipoEnumerador
    {
        public enum Language
        {
            PTBR, EN, RU
        }
        public Language _language = Language.PTBR;

        public TipoEnumerador()
        {

        }
        public Language GetLanguageEnum(string lang)
        {
            switch (lang.ToLower())
            {
                case "português":
                    return Language.PTBR;
                case "inglês":
                    return Language.EN;
                case "russo":
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
}