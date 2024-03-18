using laba1.lab1DataSetTableAdapters;
using System.Windows;


namespace laba1
{
    public partial class MainWindow : Window
    {
        driversTableAdapter driversTableAdapter = new driversTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            DriversDataGrid.ItemsSource = driversTableAdapter.FullData();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DriversDataGrid.Columns[0].Visibility = Visibility.Collapsed;
            DriversDataGrid.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
