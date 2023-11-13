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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_projects.ScrambleWords.Commons;

namespace WPF_projects.ScrambleWords.Views
{
    /// <summary>
    /// Interaction logic for GameForm.xaml
    /// </summary>
    public partial class GameForm : Window
    {

        public GameForm()
        {
            InitializeComponent();

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            TxtBlkScramble.Text = CoreOjects.CheckUsedInteger();
        }
    }
}
