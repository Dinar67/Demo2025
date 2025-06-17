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
using LatypovDinarDemo2025.Databases;

namespace LatypovDinarDemo2025.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialListPage.xaml
    /// </summary>
    public partial class MaterialListPage : Page
    {
        public MaterialListPage()
        {
            InitializeComponent();
            Refresh();
        }

        /// <summary>
        /// Метод обновляет список материалов на странице MaterialListPage
        /// </summary>
        public void Refresh()
        {
            MainListView.ItemsSource = App.db.Material.ToList();
        }

        private void MainListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var material = MainListView.SelectedItem as Material;
            if (material != null)
            {
                NavigationService.Navigate(new AddEditMaterialPage(material));
            }
            else MessageBox.Show("Выберите материал из списка!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditMaterialPage(new Material()));
        }
    }
}
