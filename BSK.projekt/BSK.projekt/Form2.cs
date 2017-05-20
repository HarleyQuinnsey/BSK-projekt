using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSK.projekt
{
    public partial class Form2 : Form
    {
        Form1 main_form = null;
        User current_user = null;
        User chosen_user = null;
        String table_name;

        public Form2(Form1 form, String table_name, User current_user, User chosen_user)
        {
            InitializeComponent();
            this.main_form = form;
            this.current_user = current_user;
            this.chosen_user = chosen_user;

            char[] delimiterChars = { ' ' };
            string[] words = table_name.Split(delimiterChars);

            table_name = words[0] + " " + words[1];
            this.table_name = table_name;
            Table current_table = null;
            if (current_user != null)
            {
                foreach (Table table in current_user.tables)
                    if (table.name.Equals(table_name)) current_table = table;
            }
            else
            {
                foreach (Table table2 in chosen_user.tables)
                    if (table2.name.Equals(table_name)) current_table = table2;
            }

            if (current_table.permissions[0] == true) checkBox1.Checked = true;
            if (current_table.permissions[1] == true) checkBox2.Checked = true;
            if (current_table.permissions[2] == true) checkBox3.Checked = true;
            if (current_table.permissions[3] == true) checkBox4.Checked = true;
        }

        public void Modify()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table current_table = null;
            foreach (Table table in chosen_user.tables)
                if (table.name.Equals(table_name)) current_table = table;

            current_table.permissions[0] = checkBox1.Checked;
            current_table.permissions[1] = checkBox2.Checked;
            current_table.permissions[2] = checkBox3.Checked;
            current_table.permissions[3] = checkBox4.Checked;
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
