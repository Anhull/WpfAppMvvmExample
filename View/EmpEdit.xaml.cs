using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для EmpEdit.xaml
    /// </summary>
    public partial class EmpEdit : Window
    {
        public EmpEdit(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
