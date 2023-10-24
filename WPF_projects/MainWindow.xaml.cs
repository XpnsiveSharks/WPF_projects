using System.Windows;
using MaterialDesignThemes.Wpf;
using System.Windows.Input;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using System;

namespace WPF_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MySqlConnection connection;
        public MainWindow()
        {

            InitializeComponent();
            connection = new MySqlConnection("server=3333;database=sharstj;uid=root;password=root");
        }
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);

            }
            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit the Sharks app?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Cancelled.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        /*private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            
                Window1 newWindow = new Window1();
                newWindow.Show();
                this.Close();
            
        }*/
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            // Get the username and password from the login form
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Check if the username and password are correct
            if (username != "root" || password != "")
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            // Open the MySQL connection
            connection.Open();

            // Create a SQL query to get the data from the database
            string sql = "SELECT * FROM users";

            // Execute the SQL query and get the results
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            // Iterate over the results and display them
            while (reader.Read())
            {
                Console.WriteLine(reader["name"] + " " + reader["email"]);
            }

            // Close the MySQL connection
            connection.Close();
        }
    }
}
