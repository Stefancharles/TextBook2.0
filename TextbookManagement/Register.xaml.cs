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
    public partial class RegisterWindow : Window
    {
   
        DispatcherTimer timer = new DispatcherTimer();
        public RegisterWindow()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextbookManagementUI.LoginWindow login = new TextbookManagementUI.LoginWindow();
            login.Show();
            Close();
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

        private void btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            //获取连接字符串
            string connectionstr = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            //创建连接对象
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand();
            //设置命令对象的Connection属性
            cmd.Connection = con;
            //在数据库中插入数据，设置2个参数。ps：后期再加一个确认密码
            string sqlstr = "INSERT INTO userinfo(username,password) VALUES(@username,@password)";
            cmd.CommandText = sqlstr;
            //为参数赋值
            cmd.Parameters.AddWithValue("username", txt_username.Text);
            cmd.Parameters.AddWithValue("password", txt_password.Password);
            //执行SQL命令，返回受影响的行数
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration success!");
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (cbx_Terms.IsChecked == true)
            {
                btn_Signin.IsEnabled = true;
                btn_Signin.Opacity = 1.0;
            }

             
        }

     
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn_Signin.IsEnabled = false;
            btn_Signin.Opacity = 0.8;
        }

        private void Cbx_Terms_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_Signin.IsEnabled = false;
            btn_Signin.Opacity = 0.8;
        }

        private void Cbx_Terms_MouseMove(object sender, MouseEventArgs e)
        {
            cbx_Terms.ToolTip = "Check here to Sign in! ";
            
        }

        private void Txt_username_MouseMove(object sender, MouseEventArgs e)
        {
            txt_username.ToolTip = "Check here to input your username!";
        }

        private void Txt_password_MouseMove(object sender, MouseEventArgs e)
        {
            txt_password.ToolTip = "Check here to input your password!";
        }
    }
}
