using LolEntityDatabase.Context;
using LolEntityDatabase.Data;
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

namespace LolEntityDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtName.Text;


            LolDbContext Edc = new LolDbContext();

            Users user = new Users();
            //user.Seq = 1;
            user.Name = name;
            user.Email = email;
            //user.Created = DateTime.Now;




                
            Edc.Users.Add(user);
            Edc.SaveChanges();
        }
    }
}
