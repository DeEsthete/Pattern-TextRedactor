using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pattern_TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LanguageManager languageManager;
        private List<string> languages;
        public MainWindow()
        {
            InitializeComponent();

            languageManager = new LanguageManager();
            languages = DataManager.ReadFileLanguageList();

            for (int i = 0; i < languages.Count; i++)
            {
                languageComboBox.Items.Add(languages[i]);
            }
        }
        private void ApplyButtonClick(object sender, RoutedEventArgs e)
        {
            string current = languageComboBox.SelectedItem as string;
            bool isTrue = false;

            foreach (var i in languageManager.Languages)
            {
                if (i.Key == current)
                {
                    isTrue = true;
                }
            }
            if (!isTrue)
            {
                languageManager.Languages.Add(current, DataManager.ReadFileStrategy(current));
            }

            languageManager.Languages[current].Apllying(this);
        }
    }
}



//languageManager = new LanguageManager();
//Strategy english = new Strategy();
//english.WordLibrary.Add("Fatty", "Fatty");
//english.ButtonWidthLibrary.Add("Fatty", 44);
//english.WordLibrary.Add("Italics", "Italics");
//english.ButtonWidthLibrary.Add("Italics", 41);
//english.WordLibrary.Add("Underlined", "Underlined");
//english.ButtonWidthLibrary.Add("Underlined", 69);
//english.WordLibrary.Add("Save", "Save");
//english.ButtonWidthLibrary.Add("Save", 34);
//languageManager.Languages.Add("English", english);
//DataManager.WriteFile(english, "English");

//Strategy russian = new Strategy();
//russian.WordLibrary.Add("Fatty", "Жирный");
//russian.ButtonWidthLibrary.Add("Fatty", 55);
//russian.WordLibrary.Add("Italics", "Курсив");
//russian.ButtonWidthLibrary.Add("Italics", 47);
//russian.WordLibrary.Add("Underlined", "Подчеркнутыйййй");
//russian.ButtonWidthLibrary.Add("Underlined", 109);
//russian.WordLibrary.Add("Save", "Сохранить");
//russian.ButtonWidthLibrary.Add("Save", 69);
//languageManager.Languages.Add("Русский", russian);
//DataManager.WriteFile(russian, "Russian");