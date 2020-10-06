using System.Windows;
using WpfAppMvvm.ViewModel;


namespace WpfAppMvvm.View
{
    /// <summary>
    /// Логика взаимодействия для AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
            DataContext = new VMapp();
        }
        //Открытие формы добавления сотрудника
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            EmpAdd empAdd = new EmpAdd(DataContext);
            empAdd.ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            EmpEdit empEdit = new EmpEdit(DataContext);
            empEdit.ShowDialog();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            DepAdd depAdd = new DepAdd(DataContext);
            depAdd.ShowDialog();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            OrdAdd ordAdd = new OrdAdd(DataContext);
            ordAdd.ShowDialog();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            DepEdit depEdit = new DepEdit(DataContext);
            depEdit.ShowDialog();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            OrdEdit ordEdit = new OrdEdit(DataContext);
            ordEdit.ShowDialog();
        }
    }
}
