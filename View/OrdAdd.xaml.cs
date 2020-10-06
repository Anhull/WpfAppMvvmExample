using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для OrdAdd.xaml
    /// </summary>
    public partial class OrdAdd : Window
    {
        public OrdAdd(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
