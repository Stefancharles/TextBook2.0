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
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Configuration;
using System.Data.SqlClient;

namespace TextbookManagementUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
   
        DispatcherTimer timer = new DispatcherTimer();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
                
            }
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.To =0 ;
            doubleAnimation.From = grid.Opacity;
            doubleAnimation.Duration = TimeSpan.FromSeconds(1);
            grid.BeginAnimation(Grid.OpacityProperty, doubleAnimation);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Border_Initialized(object sender, EventArgs e)
        {
            //BeginStoryboard(Resources["begin animation"] as System.Windows.Media.Animation.Storyboard);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.To = grid.Opacity;
            doubleAnimation.From = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(1);
            grid.BeginAnimation(Grid.OpacityProperty, doubleAnimation);


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {   //创建连接对象，并打开
            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sqlstr = "SELECT * FROM userinfo WHERE username=@username";
            cmd.CommandText = sqlstr;
            cmd.Parameters.AddWithValue("username", txt_username.Text);
            SqlDataReader DataRd = cmd.ExecuteReader();
            //读取一行数据
            DataRd.Read();
            string pw = txt_password.Password;
            if (pw==DataRd[1].ToString()) 
            {

                TextbookManagementUI.MainWindow login1 = new TextbookManagementUI.MainWindow();
                login1.Show();  //打开新窗口
            }
            else
            {
                btn_Login.IsEnabled = false;
                MessageBox.Show("Username or password is incorrect,Please try again!");
            }
            Close();  //关闭当前
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (cbx_Terms.IsChecked == true)
            {
                btn_Login.IsEnabled = true;
                btn_Login.Opacity = 1.0;
            }

             
        }

     
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn_Login.IsEnabled = false;
            btn_Login.Opacity = 0.8;
        }

        private void Cbx_Terms_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_Login.IsEnabled = false;
            btn_Login.Opacity = 0.8;
        }

        private void Cbx_Terms_MouseMove(object sender, MouseEventArgs e)
        {
            cbx_Terms.ToolTip = "Check here to log in! ";
            
        }

        private void Txt_username_MouseMove(object sender, MouseEventArgs e)
        {
            txt_username.ToolTip = "Check here to input your username! ";
        }

        private void Txt_password_MouseMove(object sender, MouseEventArgs e)
        {
            txt_password.ToolTip = "Check here to input your password! ";
        }

        private void btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            TextbookManagementUI.RegisterWindow register = new TextbookManagementUI.RegisterWindow();
            register.Show();
            Hide();
        }

    }
}
