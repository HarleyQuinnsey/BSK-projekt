using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BSK.projekt
{
    public partial class TworzenieNowegoUzytkownika3 : Form
    {
        string addedLogin, addedPassword, addedPasswordAgain, nameSurname, addedPESEL;
        public TworzenieNowegoUzytkownika3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //User addedUser = new User(1);
            addedPESEL = textBoxID.Text;
            addedLogin = textBoxLogin.Text;
            addedPassword = textBoxPassword.Text;
            addedPasswordAgain = textBoxPasswordAgain.Text;

            if (addedPassword != addedPasswordAgain)
            {
                MessageBox.Show("Hasla sa niezgodne!");
            }
            else
            {  //DODAć SPRAWDZANIE CZY NIE MA JUZ USERA O TYM PESELU!!!
                //ZROBIć TAK, ŻEBY UŻYWAć ourDB STWORZONEGO W LOGOWANIU
                DatabaseConnector ourDB = new DatabaseConnector("test", "10.0.1.8\\SQLEXPRESS", "SurfBurger");

                string query = "INSERT INTO Uzytkownik (LoginUsera, HasloUsera, PESELpracownika) values (@LoginUsera, @HasloUsera, @PESELpracownika)";
                SqlCommand command = new SqlCommand(query, ourDB.connection);
                command.Parameters.Add("@LoginUsera", addedLogin);
                command.Parameters.Add("@HasloUsera", addedPassword);
                command.Parameters.Add("@PESELpracownika", addedPESEL);
                command.ExecuteNonQuery();

                //query = "INSERT INTO Uprawnienia (LoginUsera, czyMaSelect, czyMaUpdate, czyMaDelete, czyMaInsert) values ('0', '0', '0', '0')";
                //command.CommandText = query;
                //command.ExecuteNonQuery();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
