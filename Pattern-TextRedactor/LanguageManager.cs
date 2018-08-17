using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_TextRedactor
{
    public class LanguageManager
    {
        public Dictionary<string, Strategy> Languages { get; set; }

        public LanguageManager()
        {
            Languages = new Dictionary<string, Strategy>();
        }
    }
}
