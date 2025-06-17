using System.Windows;
using LatypovDinarDemo2025.Databases;

namespace LatypovDinarDemo2025
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LatypovDinarDemo2025Entities db = new LatypovDinarDemo2025Entities();
    }
}
