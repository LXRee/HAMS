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
using MySql.Data.MySqlClient;

namespace StudentHAMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string constr = "server=182.92.220.26;Uid=HAMS;password=123456;Database=HAMS";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            MySqlCommand mycmd = new MySqlCommand("insert into admin(adminId,password,name,sex) values('12345678911','dikd3939','紫梓','女')", conn);
            if (mycmd.ExecuteNonQuery() > 0)
            {

                MessageBox.Show("插入成功");

            }
            Console.ReadLine();
            conn.Close();
            

        }
    }
}
