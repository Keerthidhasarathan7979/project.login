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

namespace password_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string username = "XYZ";
        string password = "password";
        int retry = 0;
        

        public MainWindow()
        {
            InitializeComponent();
        }
     
          

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username == txtusername.Text && password == psdval.Password )
            {
                MessageBox.Show("Hi welcome, successfully logged in");
            }
            else
            {
                if (retry == 0)
                {
                    MessageBoxResult msgresult = MessageBox.Show(" Your user id and password is Wrong,Do You want Continue", "ERROR", MessageBoxButton.YesNo, MessageBoxImage.Error);

                    if (msgresult == MessageBoxResult.Yes) ;
                    {
                        retry++;
                    }
                   
                }

                
                else if(retry==1)
                {
                    
                    
                        MessageBoxResult msgresult = MessageBox.Show(" incorrect user name and password,Do You want retry ","WARNING", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        {

                            if (msgresult == MessageBoxResult.Yes );
                            retry++;
                        }
                    }
                 else if (retry==2)
                {
                    MessageBoxResult msgresult = MessageBox.Show("your id is locked try later", "login", MessageBoxButton.OK, MessageBoxImage.Error);
                    {
                        if (msgresult == MessageBoxResult.Yes);
                        retry++;
                    }
                }

                }
            }
         


        }   
           
               
              
    }

