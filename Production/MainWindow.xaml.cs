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

namespace Production
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StaffName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            StaffName.Text = "";
            StaffName.Focus();
        }

        private void showWorkPlan_Click(object sender, RoutedEventArgs e)
        {
            WorkPlan.Items.Add(StaffName.Text);
        }
    }
}
