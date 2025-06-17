using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Navigation;
using LatypovDinarDemo2025.Databases;

namespace LatypovDinarDemo2025.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditMaterialPage.xaml
    /// </summary>
    public partial class AddEditMaterialPage : Page
    {
        Material Material;
        public AddEditMaterialPage(Material material)
        {
            InitializeComponent();
            Material = material;

            if(material.Id == 0) //Если продукт новый и у него ID = 0 то заголовок добавление
                TitleTb.Text =  "Добавление материала";
            else //Иначе редактирование
                TitleTb.Text = "Редактирование материала";

            TypeMaterialCb.ItemsSource = App.db.MaterialType.ToList();
            UnitCb.ItemsSource = App.db.Unit.ToList();

            DataContext = Material;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Material.Id == 0) //Если материал новый, то добавляем в базу
                App.db.Material.Add(Material);
            App.db.SaveChanges(); //Сохранияем изменения
            NavigationService.Navigate(new MaterialListPage()); //Обратно идем на список материалов

            MessageBox.Show("Изменения успешно сохранены!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
