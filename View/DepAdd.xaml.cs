using System.Windows;

namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для DepAdd.xaml
    /// </summary>
    public partial class DepAdd : Window
    {
        public DepAdd(object vMapp)
        {
            InitializeComponent();
            DataContext = vMapp;
        }
    }
}
