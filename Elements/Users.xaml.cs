
using System.Windows.Controls;


namespace Pr13.Elements
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        public Models.Users ThisUser;
        public Users(Models.Users User)
        {
            InitializeComponent();
            ThisUser = User;
            FIO.Text = User.FIO;
        }

        private void SelectUser(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.SelectUser(ThisUser);
        }
    }
}
