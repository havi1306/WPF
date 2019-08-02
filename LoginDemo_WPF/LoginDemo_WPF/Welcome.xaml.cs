using Dapper;
using LoginDemo_WPF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace LoginDemo_WPF
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public List<User> List { get; set; }
        public Welcome()
        {
            InitializeComponent();
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            //using (var db = new SqlConnection("Data Source=.;Initial Catalog=LOGIN;Integrated Security=True"))
            //{
            //    if (db.State == ConnectionState.Closed)
            //        db.Open();
            //    //Get data from sql database

            //    var list = db.Query<User>("select * from TB_USER", commandType: CommandType.Text);
            //    this.List = list.ToList();
            //    //GridControl.ItemsSource = new EntityServerModeSource()
            //    //{
            //    //    ElementType = typeof(Product),
            //    //    KeyExpression = "ProductID",
            //    //    QueryableSource = dataContext.Products
            //    //};
            //}
        }
    }
}
