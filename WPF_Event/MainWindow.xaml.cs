using System.Windows;

namespace WPF_Event
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myButton.Click += button_MyOtherClick;
        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            otherLabel.Content = "Hello again!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello world!";
        }
    }
}
