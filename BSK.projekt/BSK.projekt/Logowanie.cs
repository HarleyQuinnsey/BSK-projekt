using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSK.projekt
{
    public partial class Logowanie : Form
    {
        public string typedLogin = "", typedPassword = "";
        DatabaseConnector ourDB;
        public Logowanie()
        {
            InitializeComponent();
        }




        private void label2_Click(object sender, EventArgs e)  { }
        private void logInPassword_TextChanged(object sender, EventArgs e) { }
        private void logInUserName_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Logowanie_Load(object sender, EventArgs e) { }


        
        private void logInButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            ourDB = new DatabaseConnector("test", "VERONYA\\SQLEXPRESS", "SurfBurger");
            logInPassword.PasswordChar = '*';
            logInPassword.PasswordChar = '*';
            typedLogin = logInUserName.Text;
            typedPassword = logInPassword.Text;
            


            DataTable row = ourDB.getData("SELECT * FROM Uzytkownik WHERE LoginUsera = '" + typedLogin + "' AND HasloUsera = '" + typedPassword + "'");

            if (!row.Equals(null))
            {
                Form1 app = new Form1(typedLogin);
                this.Hide();
                app.Show();
            }
            else
                MessageBox.Show("Niepoprawny login lub haslo.");
        }
        
    }
}
