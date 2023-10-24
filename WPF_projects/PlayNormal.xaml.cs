using System.Windows;
using WPF_projects.ActionListeners;

namespace WPF_projects
{
    public partial class PlayNormal : Window
    {
        CardsQuestions cq = new CardsQuestions();
        CardsAnswers ans = new CardsAnswers();
        public PlayNormal()
        {
            InitializeComponent();
            lblQuestion.Text = cq.GetNextQuestion();
        }
        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            lblQuestion.Text = cq.GetNextQuestion();
        }

        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {
            lblQuestion.Text = cq.GetNextQuestion();
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            lblQuestion.Text = cq.GetNextQuestion();
        }

        private void btnMerciless_Click(object sender, RoutedEventArgs e)
        {
            lblQuestion.Text = cq.GetNextQuestion();
        }

        private void btnShowAnswer_Click(object sender, RoutedEventArgs e)
        {
            txtbxAnswer.Text = ans.GetNextAnswer();
        }
    }
}
