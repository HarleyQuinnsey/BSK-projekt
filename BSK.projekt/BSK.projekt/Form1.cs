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
    public partial class Form1 : Form
    {
        private int user_count = 0, tableNumber;
        string recipient, typedLogin, tableName, chosenActivityOnBase = ""; //recipient to biorca
        bool goOn = false; //goOn jest po to, że jak użytkownik zaznaczy uprawnienie, którego nie ma i kliknie "przekaż" to nie powstanie wpis w bazie
        DataTable queryResult;
        
        DatabaseConnector ourDB = new DatabaseConnector("test", "VERONYA\\SQLEXPRESS", "SurfBurger");


        public Form1(string _typedLogin)
        {
            InitializeComponent();

            typedLogin = _typedLogin;
           
            selectComboBox.Items.Add("Faktura");
            selectComboBox.Items.Add("Historia");
            selectComboBox.Items.Add("Potrawa");
            selectComboBox.Items.Add("Pracownik");
            selectComboBox.Items.Add("Restauracja");
            selectComboBox.Items.Add("Uzytkownik");

            tableNameActivitiesOnBase.Items.Add("Faktura");
            tableNameActivitiesOnBase.Items.Add("Historia");
            tableNameActivitiesOnBase.Items.Add("Potrawa");
            tableNameActivitiesOnBase.Items.Add("Pracownik");
            tableNameActivitiesOnBase.Items.Add("Restauracja");
            tableNameActivitiesOnBase.Items.Add("Uzytkownik");
        }
      
// PUSTE FUNKCJE start -------------------------------------------------------------------------------------------------------
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void updateCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void selectCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void chosenUserTextBox_TextChanged(object sender, EventArgs e) { }
        private void usun_Click(object sender, EventArgs e)  { }
        private void przejmij_Click(object sender, EventArgs e) { }
        private void availableColumns_TextChanged(object sender, EventArgs e) { }
        private void typedInColumnsTextBox_TextChanged(object sender, EventArgs e) { }
        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void insertCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void passSelectCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void passUpdateCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void passDeleteCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void passInsertCheckBox_CheckedChanged(object sender, EventArgs e) { }

// PUSTE FUNKCJE koniec ----------------------------------------------------------------------------------------------------------------


        private void add_Click(object sender, EventArgs e)
        {
            TworzenieNowegoUzytkownika3 cnu = new TworzenieNowegoUzytkownika3();
            cnu.Show();
        }
        

        private void przekaz_Click(object sender, EventArgs e)
        {
            queryResult = ourDB.getData("SELECT * FROM Historia WHERE Biorca = '" + typedLogin + "' and CzyAktualne = 1"); //dopisac, ze jak to admin, to ownedPowers=wszystkie
            string ownedPowers = queryResult.Rows[0][5].ToString();
            string powersToPass = "", powersToPassTEMP = "", chosenTable = "";
            string textToShow = "Uzytkownik " + recipient + " posiada juz uprawnienie ";
            bool showText = false;
            string parents = queryResult.Rows[0][6].ToString();

            chosenTable = selectComboBox.SelectedIndex.ToString();
            recipient = chosenUserTextBox.Text;

            queryResult = ourDB.getData("SELECT PESELpracownika FROM Uzytkownik WHERE LoginUsera = '" + recipient + "'");
            bool IcannotpassToThisPerson = parents.Contains(queryResult.Rows[0][0].ToString());

            //wyciągnięcie do stringa wcześniejszych uprawnień osoby, której chcemy coś przekazać
            string earlierPowersOfRecipient = ourDB.getData("SELECT WszystkiePosiadaneUprawnienia FROM Historia WHERE Biorca = '" + recipient + "' and CzyAktualne = 1").Rows[0][0].ToString();
           

            if (!IcannotpassToThisPerson) //jesli osoba, ktorej chce cos przekazac nie jest moim rodzicem w drzewie
            {
                //SELECT
                if (selectCheckBox.Checked)
                {
                    if (ownedPowers.Contains("S" + chosenTable))
                    {
                        if (passSelectCheckBox.Checked)
                        {
                            powersToPassTEMP += "S" + chosenTable;
                            goOn = true;
                        }
                        else
                        {
                            powersToPassTEMP += "s" + chosenTable;
                            goOn = true;
                        }
                        
                    }
                    else if (ownedPowers.Contains("s" + chosenTable))
                    {
                        if (!passSelectCheckBox.Checked)
                        {
                            powersToPassTEMP += "s" + chosenTable;
                            goOn = true;
                        }
                        else
                            MessageBox.Show("Nie posiadasz uprawnienia select z możliwością przekazania dalej");  //może zamiast miliona komunikatów zrobić odpowiednie checjboxy nieaktywne?    
                    }
                    else
                        MessageBox.Show("Nie posiadasz wogóle uprawnienia select");

                    if (earlierPowersOfRecipient.Contains(powersToPassTEMP))
                    {
                        textToShow += "select";
                        showText = true;
                    }
                    else
                        powersToPass += powersToPassTEMP;
                }

                //UPDATE
                if (updateCheckBox.Checked)
                {
                    if (ownedPowers.Contains("U" + chosenTable))
                    {
                        if (passUpdateCheckBox.Checked)
                        {
                            powersToPassTEMP += "U" + chosenTable;
                            goOn = true;
                        }
                        else
                        {
                            powersToPassTEMP += "u" + chosenTable;
                            goOn = true;
                        }
                    }
                    else if (ownedPowers.Contains("u" + chosenTable))
                    {
                        if (!passUpdateCheckBox.Checked)
                        {
                            powersToPassTEMP += "u" + chosenTable;
                            goOn = true;
                        }
                        else
                            MessageBox.Show("Nie posiadasz uprawnienia update z możliwością przekazania dalej");  //może zamiast miliona komunikatów zrobić odpowiednie checjboxy nieaktywne?    
                    }
                    else
                        MessageBox.Show("Nie posiadasz wogóle uprawnienia update");

                    if (earlierPowersOfRecipient.Contains(powersToPassTEMP))
                    {
                        textToShow += ", update";
                        showText = true;
                    }
                    else
                        powersToPass += powersToPassTEMP;
                }

                //DELETE    
                if (deleteCheckBox.Checked)
                {
                    if (ownedPowers.Contains("D" + chosenTable))
                    {
                        if (passDeleteCheckBox.Checked)
                        {
                            powersToPassTEMP += "D" + chosenTable;
                            goOn = true;
                        }
                        else
                        {
                            powersToPassTEMP += "d" + chosenTable;
                            goOn = true;
                        }
                    }
                    else if (ownedPowers.Contains("d" + chosenTable))
                    {
                        if (!passDeleteCheckBox.Checked)
                        {
                            powersToPassTEMP += "d" + chosenTable;
                            goOn = true;
                        }
                        else
                            MessageBox.Show("Nie posiadasz uprawnienia delete z możliwością przekazania dalej");  //może zamiast miliona komunikatów zrobić odpowiednie checjboxy nieaktywne?    
                    }
                    else
                        MessageBox.Show("Nie posiadasz wogóle uprawnienia delete");

                    if (earlierPowersOfRecipient.Contains(powersToPassTEMP))
                    {
                        textToShow += ", delete";
                        showText = true;
                    }
                    else
                        powersToPass += powersToPassTEMP;
                }

                //INSERT   
                if (insertCheckBox.Checked)
                {
                    if (ownedPowers.Contains("I" + chosenTable))
                    {
                        if (passInsertCheckBox.Checked)
                        {
                            powersToPassTEMP += "I" + chosenTable;
                            goOn = true;
                        }
                        else
                        {
                            powersToPassTEMP += "i" + chosenTable;
                            goOn = true;
                        }
                    }
                    else if (ownedPowers.Contains("i" + chosenTable))
                    {
                        if (!passInsertCheckBox.Checked)
                        {
                            powersToPassTEMP += "i" + chosenTable;
                            goOn = true;
                        }
                        else
                            MessageBox.Show("Nie posiadasz uprawnienia insert z możliwością przekazania dalej");  //może zamiast miliona komunikatów zrobić odpowiednie checjboxy nieaktywne?    
                    }
                    else
                        MessageBox.Show("Nie posiadasz wogóle uprawnienia insert");

                    if (earlierPowersOfRecipient.Contains(powersToPassTEMP))
                    {
                        textToShow += ", insert";
                        showText = true;
                    }
                    else
                        powersToPass += powersToPassTEMP;
                }

                if (showText)
                    MessageBox.Show(textToShow + " do tabeli " + selectComboBox.Text + " .\nPominieto przekazanie wymienionych uprawnien.");
            }
            else
                MessageBox.Show("Nie możesz przekazać nic tej osobie.");//bo ta osoba jest Twoim rodziecem w drzewie


            if (recipient.Equals(""))
            {
                goOn = false;
                MessageBox.Show("Wpisz login użytkownika, na którym chcesz wykonać działanie!");
            }

            if (goOn && powersToPass != "")
            {
                //ustawianie poprzedniego wpisu o uprawnieniach biorcy, jako nieaktualny
                string query = "UPDATE Historia SET CzyAktualne = 0 WHERE Biorca = @BiorcaUpdate and CzyAktualne = 1";
                SqlCommand command = new SqlCommand(query, ourDB.connection);
                command.Parameters.Add("@BiorcaUpdate", recipient);
                command.ExecuteNonQuery();

                //pobranie peselu osoby, które robi aktualnie przekazywanie
                string peselOfNewParent = ourDB.getData("SELECT PESELpracownika FROM Uzytkownik WHERE LoginUsera = '" + typedLogin + "'").Rows[0][0].ToString();
                
                //wpis do bazy
                query = "INSERT INTO Historia (Dawca, Biorca, RodzajOperacji, Uprawnienia, WszystkiePosiadaneUprawnienia, RodziceWDrzewie, CzyAktualne) values (@Dawca, @Biorca, @RodzajOperacji, @Uprawnienia, @WszystkiePosiadaneUprawnienia, @RodziceWDrzewie, 1)";
                command = new SqlCommand(query, ourDB.connection);
                command.Parameters.Add("@Dawca", typedLogin);
                command.Parameters.Add("@Biorca", recipient);
                command.Parameters.Add("@RodzajOperacji", "przekaz");
                command.Parameters.Add("@Uprawnienia", powersToPass);
                command.Parameters.Add("@WszystkiePosiadaneUprawnienia", earlierPowersOfRecipient + powersToPass);
                command.Parameters.Add("@RodziceWDrzewie", parents + ", " + peselOfNewParent);
                command.ExecuteNonQuery();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Logowanie loguj = new Logowanie();
            loguj.Show();
            DatabaseConnector ourDB = new DatabaseConnector("sys", "VERONYA\\SQLEXPRESS", "SurfBurger");
            questionResult.DataSource = ourDB.getData("select * from Restauracja");
        }

        private void tableNameActivitiesOnBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableColumns.Text = "";
            tableNumber = tableNameActivitiesOnBase.SelectedIndex;
            tableName = tableNameActivitiesOnBase.Text;
            queryResult = ourDB.getData("SELECT WszystkiePosiadaneUprawnienia FROM Historia WHERE Biorca = '" + typedLogin + "' and CzyAktualne = '1'");
            string powers = queryResult.Rows[0][0].ToString();

            if (   ((powers.Contains("s" + tableNumber) || powers.Contains("S" + tableNumber)) && chosenActivityOnBase == "select")
                   || ((powers.Contains("d" + tableNumber) || powers.Contains("D" + tableNumber)) && chosenActivityOnBase == "delete")
                   || ((powers.Contains("i" + tableNumber) || powers.Contains("I" + tableNumber)) && chosenActivityOnBase == "insert")
                   || ((powers.Contains("u" + tableNumber) || powers.Contains("U" + tableNumber)) && chosenActivityOnBase == "update")    )
            {
                queryResult = ourDB.getData("SELECT * FROM " + tableName);
                int i = 0;

                foreach (DataColumn column in queryResult.Columns)
                {
                    
                    availableColumns.Text += column.ColumnName;
                    if (i < (queryResult.Columns.Count - 1))
                        availableColumns.Text += ",";
                    i++;
                }
            }
            else
                MessageBox.Show("Nie masz uprawnienia do wybranej tabeli");
        }
        


        private void makeElementsVisible()
        {
            tableNameLabel.Visible = true;
            tableNameActivitiesOnBase.Visible = true;
            availableColumnsLabel.Visible = true;
            availableColumns.Visible = true;
            chooseColumnsLabel.Visible = true;
            typedInColumnsTextBox.Visible = true;
            makeQuestionButton.Visible = true;
            
            chooseValuesLabel.Visible = true;
            typedInValuesTextBox.Visible = true;
            conditionColumnLabel.Visible = false;
            conditionColumnTextBox.Visible = false;
            conditionValueLabel.Visible = false;
            conditionValueTextBox.Visible = false;
                
            if (chosenActivityOnBase.Equals("insert"))
            {
                chooseColumnsLabel.Visible = false;
                typedInColumnsTextBox.Visible = false;
            }
            else if(chosenActivityOnBase.Equals("select"))
            {
                chooseValuesLabel.Visible = false;
                typedInValuesTextBox.Visible = false;
            }
            else
            {
                if (chosenActivityOnBase.Equals("update"))
                {
                    conditionColumnLabel.Visible = true;
                    conditionColumnTextBox.Visible = true;
                    conditionValueLabel.Visible = true;
                    conditionValueTextBox.Visible = true;
                }
           }
        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            chosenActivityOnBase = "update";
            this.makeElementsVisible();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            chosenActivityOnBase = "insert";
            this.makeElementsVisible();
        }


        private void selectButton_Click(object sender, EventArgs e)
        {
            chosenActivityOnBase = "select";
            this.makeElementsVisible();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            chosenActivityOnBase = "delete";
            this.makeElementsVisible();
        }


        private void makeQuestionButton_Click(object sender, EventArgs e)
        {
            string typedInColumns = typedInColumnsTextBox.Text;
            tableNumber = tableNameActivitiesOnBase.SelectedIndex;
            DataTable table;
            SqlCommand command = new SqlCommand();
            string[] typedInColumnsTable;
            string[] typedInValuesTable;
            string[] availableColumnsTable;
            string typedInValues, query;

            switch (chosenActivityOnBase)
            {
                case "select":
                    if (typedInColumns.Equals("wszystkie"))
                        questionResult.DataSource = ourDB.getData("SELECT * FROM " + tableName);
                    else
                        questionResult.DataSource = ourDB.getData("SELECT " + typedInColumns + " FROM " + tableName);
                    typedInColumnsTextBox.Text = "";
                    break;

                case "delete":
                    typedInColumnsTable = typedInColumnsTextBox.Text.Split(',');
                    typedInValuesTable = typedInValuesTextBox.Text.Split(',');
                    typedInValues = "";
                    typedInColumns = "";
                    query = "DELETE FROM " + tableName + " WHERE ";

                    for(int i = 0; i < typedInColumnsTable.Length; i++)
                    {
                        query += typedInColumnsTable[i] + " = '" + typedInValuesTable[i] + "'"; //czy to zadziała też na intach?
                        if (i < typedInColumnsTable.Length - 1)
                            query += " and ";
                    }

                    command = new SqlCommand(query, ourDB.connection);
                    command.ExecuteNonQuery();
                    typedInValuesTextBox.Text = "";
                    typedInColumnsTextBox.Text = "";
                    break;

                case "insert":
                    //trzeba dopisać dużo warunków na to, żeby wykonanie się komendy zablokowało się, gdy np.ktoś wpisuje coś do tabeli z referencją i w miejscu referencji wpisze nieistniejącą wartość, bo narazie się na tym wywala
                    //dopisać, że taki login już istnieje
                    typedInValuesTable = typedInValuesTextBox.Text.Split(',');
                    typedInValues = "";
                    availableColumnsTable = availableColumns.Text.Split(',');
                    query = "INSERT INTO " + tableName + " values (";

                    for (int i = 0; i < availableColumnsTable.Length; i++)
                    {
                        query +="'" + typedInValuesTable[i] + "'"; //czy to zadziała też na intach?
                        if (i < availableColumnsTable.Length - 1)
                            query += ",";
                    }

                    query += ")";
                    //trzeba wyświetlić tu pesele istniejących pracowników?

                    command = new SqlCommand(query, ourDB.connection);
                    command.ExecuteNonQuery();
                    typedInValuesTextBox.Text = "";
                    break;

                case "update":
                    typedInColumnsTable = typedInColumnsTextBox.Text.Split(',');
                    typedInValuesTable = typedInValuesTextBox.Text.Split(',');
                    typedInValues = "";
                    typedInColumns = "";
                    query = "UPDATE " + tableName + " SET " ;

                    for (int i = 0; i < typedInColumnsTable.Length; i++)
                    {
                        query += typedInColumnsTable[i] + " = '" + typedInValuesTable[i] + "'"; //czy to zadziała też na intach?
                        if (i < typedInColumnsTable.Length - 1)
                            query += ", ";
                    }

                    query += " WHERE ";

                    string [] conditionColumnTable = conditionColumnTextBox.Text.Split(',');
                    string [] conditionValuesTable = conditionValueTextBox.Text.Split(',');

                    for (int i = 0; i < conditionColumnTable.Length; i++)
                    {
                        query += conditionColumnTable[i] + " = '" + conditionValuesTable[i] + "'"; //czy to zadziała też na intach?
                        if (i < typedInColumnsTable.Length - 1)
                            query += ", ";
                    }
                    command = new SqlCommand(query, ourDB.connection);
                    command.ExecuteNonQuery();
                    typedInColumnsTextBox.Text = "";
                    typedInValuesTextBox.Text = "";
                    conditionColumnTextBox.Text = "";
                    conditionValueTextBox.Text = "";

                    break;
            }

            availableColumns.Text = "";
            MessageBox.Show("WYKONANO ZAPYTANIE");
        }
    }



}
