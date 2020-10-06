using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для OrdEdit.xaml
    /// </summary>
    public partial class OrdEdit : Window
    {
        public OrdEdit(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
