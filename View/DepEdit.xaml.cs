using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для DepEdit.xaml
    /// </summary>
    public partial class DepEdit : Window
    {
        public DepEdit(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
