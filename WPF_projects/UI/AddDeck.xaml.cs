using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using WPF_projects.ActionListeners;

namespace WPF_projects.UI
{
    /// <summary>
    /// Interaction logic for AddDeck.xaml
    /// </summary>
    public partial class AddDeck : Window
    {
        AddQuestionsAnswers addQA = new AddQuestionsAnswers();
        public AddDeck()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
            {
                List<AddQuestionsAnswers> list = addQA.GetAllCardsInfo();
                dgCards.ItemsSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertData()
        {
            try
            {
                string questions = txtQuestions.Text;
                string answers = txtAnswers.Text;
                if (questions != null && answers != null)
                {
                    addQA.AddData(questions, answers, 1);
                }
                else
                {
                    MessageBox.Show("Please insert a question or answer");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            InsertData();
            loadData();
        }
 
    }
}
