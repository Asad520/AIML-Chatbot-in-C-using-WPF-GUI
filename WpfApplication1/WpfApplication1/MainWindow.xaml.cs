using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using AIMLbot;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool firstTime;
        int plot = 0;
        string userName;
        void defineTheDay(){
            string day = DateTime.Now.ToString("dddd", CultureInfo.GetCultureInfo("en-us"));
            switch (day)
            {
                case "Sunday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Monday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Tuesday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Wednesday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Thursday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Friday":
                    tb_alpha.Text += "It's " + day;
                    break;
                case "Saturday":
                    tb_alpha.Text += "It's " + day;
                    break;
            }
            tb_alpha.Text += Environment.NewLine;
        }
        public MainWindow()
        {
            InitializeComponent();
            Title = "A SAD BOT :'(";
            tb_alpha.Text = "Bot: Hello there!";
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            Bot b = new Bot();
            b.loadSettings();
            b.loadAIMLFromFiles();
            b.isAcceptingUserInput = false;
            User u = new User("Asad", b);
            b.isAcceptingUserInput = true;
            Request r = new Request(tb.Text, u, b);
            Result res = b.Chat(r);
            tb_alpha.Text = "Bot: " + res.Output;
        }

        private void tb_alpha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
