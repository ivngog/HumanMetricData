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
using System.Drawing.Configuration;
using HumanMetricData.Windows;
using HumanMetricData.SQLOperations;

namespace HumanMetricData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainAppWindow mainApp = new MainAppWindow();
        LoadDataToMainAppWindow loadData = new LoadDataToMainAppWindow();
        
        public MainWindow()
        {
            InitializeComponent();
            mainApp.Show();
            
        }

       
        
        private void OpenClient_Click(object sender, RoutedEventArgs e)
        {

            if (LoginToClient.Text != string.Empty & PswdToClient.Text != string.Empty)
            {
                loadData.LoadDataApp(LoginToClient.Text, PswdToClient.Text);
                if(loadData.openApp == true)
                {
                    mainApp.Show();
                    this.Hide();

                }
                
            }

            else { MessageBox.Show("Not all fields had filled"); }

        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

       

        private void OpenSettings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
