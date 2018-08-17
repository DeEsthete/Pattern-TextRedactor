using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pattern_TextRedactor
{
    public class Strategy
    {
        public Dictionary<string, string> WordLibrary { get; set; }
        public Dictionary<string, int> ButtonWidthLibrary { get; set; }

        public Strategy()
        {
            WordLibrary = new Dictionary<string, string>();
            ButtonWidthLibrary = new Dictionary<string, int>();
        }

        public virtual void Apllying(MainWindow window)
        {
            (window.FindName("fattyButton") as Button).Content = WordLibrary["Fatty"];
            (window.FindName("fattyButton") as Button).Width= ButtonWidthLibrary["Fatty"];

            (window.FindName("italicsButton") as Button).Content = WordLibrary["Italics"];
            (window.FindName("italicsButton") as Button).Width = ButtonWidthLibrary["Italics"];

            (window.FindName("underlinedButton") as Button).Content = WordLibrary["Underlined"];
            (window.FindName("underlinedButton") as Button).Width = ButtonWidthLibrary["Underlined"];

            (window.FindName("saveButton") as Button).Content = WordLibrary["Save"];
            (window.FindName("saveButton") as Button).Width = ButtonWidthLibrary["Save"];
        }
    }
}
