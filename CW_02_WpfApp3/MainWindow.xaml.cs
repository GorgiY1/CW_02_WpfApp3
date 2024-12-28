using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CW_02_WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button button = new Button
            {
                Name = "Button1",
                Content = "Button1",
                Margin = new Thickness(20, 5, 10, 5),
                Width = 100,
                Height = 30

            };
            button.Click += Button_Click;
            stack.Children.Add(button);

            //if (this.Content is StackPanel panel)
            //{
            //    int namber = panel.Children.Count;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(password.ToString());
            //tb.Visibility
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {

        }
    }
}
