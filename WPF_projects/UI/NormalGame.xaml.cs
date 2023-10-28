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
using System.Windows.Shapes;
using WPF_projects.ActionListeners;

namespace WPF_projects.UI
{
    /// <summary>
    /// Interaction logic for NormalGame.xaml
    /// </summary>
    public partial class NormalGame : Window
    {
        CardsQuestions cq = new CardsQuestions();
        CardsAnswers ans = new CardsAnswers();
        public NormalGame()
        {
            InitializeComponent();
            HideButtons();
            lblQuestion.Text = cq.GetNextQuestion();
        }
        /// <summary>
        /// Action Listeners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAnswer_Click(object sender, RoutedEventArgs e)
        {
            HideAnswerButton();
            ShowButtons();
            txtbxAnswer.Text = ans.GetNextAnswer();
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ShowAnswerButton();
            showNextQuestion();
        }
        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ShowAnswerButton();
            showNextQuestion();
        }
        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ShowAnswerButton();
            showNextQuestion();
        }
        private void btnMerciless_Click(object sender, RoutedEventArgs e)
        {
            HideButtons();
            ShowAnswerButton();
            showNextQuestion();
        }
        /// <summary>
        /// buttons visibility functions
        /// </summary>
        private void ShowButtons()
        {
            btnEasy.Visibility = Visibility.Visible;
            btnAverage.Visibility = Visibility.Visible;
            btnHard.Visibility = Visibility.Visible;
            btnMerciless.Visibility = Visibility.Visible;
        }
        private void HideButtons()
        {
            btnEasy.Visibility = Visibility.Collapsed;
            btnAverage.Visibility = Visibility.Collapsed;
            btnHard.Visibility = Visibility.Collapsed;
            btnMerciless.Visibility = Visibility.Collapsed;
        }
        private void ShowAnswerButton()
        {
            btnShowAnswer.Visibility = Visibility.Visible;
        }
        private void HideAnswerButton()
        {
            btnShowAnswer.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// clears the answer textblock
        /// </summary>
        private void showNextQuestion()
        {
            txtbxAnswer.Text = string.Empty;
            lblQuestion.Text = cq.GetNextQuestion();
        }

    }
}
