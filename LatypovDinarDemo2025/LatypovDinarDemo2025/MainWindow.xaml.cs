using System.Windows;
using LatypovDinarDemo2025.Pages;

namespace LatypovDinarDemo2025
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Закинул на Frame объект страницы MaterialListPage
            MainFrame.Navigate(new MaterialListPage());
        }
    }
}
