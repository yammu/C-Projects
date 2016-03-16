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
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.sample1ConnectionString);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sample1;Integrated Security=True");
        try
        {
            string query;
            query = "insert into logInTable (name,username,password,emailId) values ('" + name1.Text + "','" + uname.Text + "','" + pword.Text + "','"+ email.Text+ "')";
            SqlCommand command = new SqlCommand(query, con);
           
            con.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully!");           
        }
        catch(SqlException ex)
        {
            MessageBox.Show("Error is "+ ex);
        }
        finally
        {
            con.Close();
           // MessageBox.Show("Connection Closed");
        }
}
        }
    }
