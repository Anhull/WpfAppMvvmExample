using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для EmpAdd.xaml
    /// </summary>
    public partial class EmpAdd : Window
    {
        public EmpAdd(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
