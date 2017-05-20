using System.Windows.Forms;

namespace BSK.projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.passInsertCheckBox = new System.Windows.Forms.CheckBox();
            this.passDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.passUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.passSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.insertCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.updateCheckBox = new System.Windows.Forms.CheckBox();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenUserTextBox = new System.Windows.Forms.TextBox();
            this.przejmij = new System.Windows.Forms.Button();
            this.przekaz = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.questionResult = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.conditionValueTextBox = new System.Windows.Forms.TextBox();
            this.conditionColumnTextBox = new System.Windows.Forms.TextBox();
            this.conditionValueLabel = new System.Windows.Forms.Label();
            this.conditionColumnLabel = new System.Windows.Forms.Label();
            this.typedInValuesTextBox = new System.Windows.Forms.TextBox();
            this.chooseValuesLabel = new System.Windows.Forms.Label();
            this.makeQuestionButton = new System.Windows.Forms.Button();
            this.availableColumns = new System.Windows.Forms.TextBox();
            this.chooseColumnsLabel = new System.Windows.Forms.Label();
            this.typedInColumnsTextBox = new System.Windows.Forms.TextBox();
            this.tableNameActivitiesOnBase = new System.Windows.Forms.ComboBox();
            this.availableColumnsLabel = new System.Windows.Forms.Label();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yourPowersGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.yourPowersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.selectComboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.passInsertCheckBox);
            this.groupBox1.Controls.Add(this.passDeleteCheckBox);
            this.groupBox1.Controls.Add(this.passUpdateCheckBox);
            this.groupBox1.Controls.Add(this.passSelectCheckBox);
            this.groupBox1.Controls.Add(this.insertCheckBox);
            this.groupBox1.Controls.Add(this.deleteCheckBox);
            this.groupBox1.Controls.Add(this.updateCheckBox);
            this.groupBox1.Controls.Add(this.selectCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chosenUserTextBox);
            this.groupBox1.Controls.Add(this.przejmij);
            this.groupBox1.Controls.Add(this.przekaz);
            this.groupBox1.Controls.Add(this.usun);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DZIAŁANIA NA USERACH";
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(166, 77);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(160, 21);
            this.selectComboBox.TabIndex = 23;
            this.selectComboBox.Text = "Wybierz tabelę";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 38);
            this.button2.TabIndex = 22;
            this.button2.Text = "Zaznacz wszystko";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // passInsertCheckBox
            // 
            this.passInsertCheckBox.AutoSize = true;
            this.passInsertCheckBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.passInsertCheckBox.Location = new System.Drawing.Point(101, 148);
            this.passInsertCheckBox.Name = "passInsertCheckBox";
            this.passInsertCheckBox.Size = new System.Drawing.Size(63, 17);
            this.passInsertCheckBox.TabIndex = 21;
            this.passInsertCheckBox.Text = "przekaz";
            this.passInsertCheckBox.UseVisualStyleBackColor = false;
            this.passInsertCheckBox.CheckedChanged += new System.EventHandler(this.passInsertCheckBox_CheckedChanged);
            // 
            // passDeleteCheckBox
            // 
            this.passDeleteCheckBox.AutoSize = true;
            this.passDeleteCheckBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.passDeleteCheckBox.Location = new System.Drawing.Point(101, 125);
            this.passDeleteCheckBox.Name = "passDeleteCheckBox";
            this.passDeleteCheckBox.Size = new System.Drawing.Size(63, 17);
            this.passDeleteCheckBox.TabIndex = 20;
            this.passDeleteCheckBox.Text = "przekaz";
            this.passDeleteCheckBox.UseVisualStyleBackColor = false;
            this.passDeleteCheckBox.CheckedChanged += new System.EventHandler(this.passDeleteCheckBox_CheckedChanged);
            // 
            // passUpdateCheckBox
            // 
            this.passUpdateCheckBox.AutoSize = true;
            this.passUpdateCheckBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.passUpdateCheckBox.Location = new System.Drawing.Point(101, 102);
            this.passUpdateCheckBox.Name = "passUpdateCheckBox";
            this.passUpdateCheckBox.Size = new System.Drawing.Size(63, 17);
            this.passUpdateCheckBox.TabIndex = 19;
            this.passUpdateCheckBox.Text = "przekaz";
            this.passUpdateCheckBox.UseVisualStyleBackColor = false;
            this.passUpdateCheckBox.CheckedChanged += new System.EventHandler(this.passUpdateCheckBox_CheckedChanged);
            // 
            // passSelectCheckBox
            // 
            this.passSelectCheckBox.AutoSize = true;
            this.passSelectCheckBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.passSelectCheckBox.Location = new System.Drawing.Point(101, 79);
            this.passSelectCheckBox.Name = "passSelectCheckBox";
            this.passSelectCheckBox.Size = new System.Drawing.Size(63, 17);
            this.passSelectCheckBox.TabIndex = 18;
            this.passSelectCheckBox.Text = "przekaz";
            this.passSelectCheckBox.UseVisualStyleBackColor = false;
            this.passSelectCheckBox.CheckedChanged += new System.EventHandler(this.passSelectCheckBox_CheckedChanged);
            // 
            // insertCheckBox
            // 
            this.insertCheckBox.AutoSize = true;
            this.insertCheckBox.Location = new System.Drawing.Point(6, 148);
            this.insertCheckBox.Name = "insertCheckBox";
            this.insertCheckBox.Size = new System.Drawing.Size(96, 17);
            this.insertCheckBox.TabIndex = 13;
            this.insertCheckBox.Text = "insert...............";
            this.insertCheckBox.UseVisualStyleBackColor = true;
            this.insertCheckBox.CheckedChanged += new System.EventHandler(this.insertCheckBox_CheckedChanged);
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Location = new System.Drawing.Point(6, 125);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(97, 17);
            this.deleteCheckBox.TabIndex = 12;
            this.deleteCheckBox.Text = "delete..............";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            this.deleteCheckBox.CheckedChanged += new System.EventHandler(this.deleteCheckBox_CheckedChanged);
            // 
            // updateCheckBox
            // 
            this.updateCheckBox.AutoSize = true;
            this.updateCheckBox.Location = new System.Drawing.Point(6, 102);
            this.updateCheckBox.Name = "updateCheckBox";
            this.updateCheckBox.Size = new System.Drawing.Size(95, 17);
            this.updateCheckBox.TabIndex = 11;
            this.updateCheckBox.Text = "update............";
            this.updateCheckBox.UseVisualStyleBackColor = true;
            this.updateCheckBox.CheckedChanged += new System.EventHandler(this.updateCheckBox_CheckedChanged);
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.AutoSize = true;
            this.selectCheckBox.Location = new System.Drawing.Point(6, 79);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(96, 17);
            this.selectCheckBox.TabIndex = 9;
            this.selectCheckBox.Text = "select..............";
            this.selectCheckBox.UseVisualStyleBackColor = true;
            this.selectCheckBox.CheckedChanged += new System.EventHandler(this.selectCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jakie działanie wykonać na powyższym użytkowniku?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Na jakim użytkowniku chcesz wykonać działanie?";
            // 
            // chosenUserTextBox
            // 
            this.chosenUserTextBox.Location = new System.Drawing.Point(6, 48);
            this.chosenUserTextBox.Name = "chosenUserTextBox";
            this.chosenUserTextBox.Size = new System.Drawing.Size(245, 20);
            this.chosenUserTextBox.TabIndex = 6;
            this.chosenUserTextBox.TextChanged += new System.EventHandler(this.chosenUserTextBox_TextChanged);
            // 
            // przejmij
            // 
            this.przejmij.Location = new System.Drawing.Point(6, 240);
            this.przejmij.Name = "przejmij";
            this.przejmij.Size = new System.Drawing.Size(73, 43);
            this.przejmij.TabIndex = 5;
            this.przejmij.Text = "Przejmij uprawnienia";
            this.przejmij.UseVisualStyleBackColor = true;
            this.przejmij.Click += new System.EventHandler(this.przejmij_Click);
            // 
            // przekaz
            // 
            this.przekaz.AccessibleName = "";
            this.przekaz.Location = new System.Drawing.Point(85, 240);
            this.przekaz.Name = "przekaz";
            this.przekaz.Size = new System.Drawing.Size(75, 43);
            this.przekaz.TabIndex = 4;
            this.przekaz.Text = "Przekaz uprawnienia";
            this.przekaz.UseVisualStyleBackColor = true;
            this.przekaz.Click += new System.EventHandler(this.przekaz_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(251, 240);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 43);
            this.usun.TabIndex = 3;
            this.usun.Text = "Dezaktywuj usera";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(166, 240);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(79, 43);
            this.add.TabIndex = 2;
            this.add.Text = "Dodaj  usera";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // questionResult
            // 
            this.questionResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionResult.Location = new System.Drawing.Point(496, 22);
            this.questionResult.Name = "questionResult";
            this.questionResult.Size = new System.Drawing.Size(531, 464);
            this.questionResult.TabIndex = 1;
            this.questionResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox3.Controls.Add(this.conditionValueTextBox);
            this.groupBox3.Controls.Add(this.conditionColumnTextBox);
            this.groupBox3.Controls.Add(this.conditionValueLabel);
            this.groupBox3.Controls.Add(this.conditionColumnLabel);
            this.groupBox3.Controls.Add(this.typedInValuesTextBox);
            this.groupBox3.Controls.Add(this.chooseValuesLabel);
            this.groupBox3.Controls.Add(this.makeQuestionButton);
            this.groupBox3.Controls.Add(this.availableColumns);
            this.groupBox3.Controls.Add(this.chooseColumnsLabel);
            this.groupBox3.Controls.Add(this.typedInColumnsTextBox);
            this.groupBox3.Controls.Add(this.tableNameActivitiesOnBase);
            this.groupBox3.Controls.Add(this.availableColumnsLabel);
            this.groupBox3.Controls.Add(this.tableNameLabel);
            this.groupBox3.Controls.Add(this.insertButton);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.selectButton);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(14, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 342);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DZIAŁANIA NA BAZIE";
            // 
            // conditionValueTextBox
            // 
            this.conditionValueTextBox.Location = new System.Drawing.Point(241, 239);
            this.conditionValueTextBox.Multiline = true;
            this.conditionValueTextBox.Name = "conditionValueTextBox";
            this.conditionValueTextBox.Size = new System.Drawing.Size(218, 40);
            this.conditionValueTextBox.TabIndex = 34;
            this.conditionValueTextBox.Visible = false;
            // 
            // conditionColumnTextBox
            // 
            this.conditionColumnTextBox.Location = new System.Drawing.Point(10, 239);
            this.conditionColumnTextBox.Multiline = true;
            this.conditionColumnTextBox.Name = "conditionColumnTextBox";
            this.conditionColumnTextBox.Size = new System.Drawing.Size(212, 40);
            this.conditionColumnTextBox.TabIndex = 33;
            this.conditionColumnTextBox.Visible = false;
            // 
            // conditionValueLabel
            // 
            this.conditionValueLabel.AutoSize = true;
            this.conditionValueLabel.Location = new System.Drawing.Point(238, 223);
            this.conditionValueLabel.Name = "conditionValueLabel";
            this.conditionValueLabel.Size = new System.Drawing.Size(193, 13);
            this.conditionValueLabel.TabIndex = 32;
            this.conditionValueLabel.Text = "Wartość kolumny po lewej do warunku:";
            this.conditionValueLabel.Visible = false;
            // 
            // conditionColumnLabel
            // 
            this.conditionColumnLabel.AutoSize = true;
            this.conditionColumnLabel.Location = new System.Drawing.Point(7, 223);
            this.conditionColumnLabel.Name = "conditionColumnLabel";
            this.conditionColumnLabel.Size = new System.Drawing.Size(110, 13);
            this.conditionColumnLabel.TabIndex = 31;
            this.conditionColumnLabel.Text = "Kolumna do warunku:";
            this.conditionColumnLabel.Visible = false;
            // 
            // typedInValuesTextBox
            // 
            this.typedInValuesTextBox.Location = new System.Drawing.Point(10, 200);
            this.typedInValuesTextBox.Name = "typedInValuesTextBox";
            this.typedInValuesTextBox.Size = new System.Drawing.Size(450, 20);
            this.typedInValuesTextBox.TabIndex = 30;
            this.typedInValuesTextBox.Visible = false;
            // 
            // chooseValuesLabel
            // 
            this.chooseValuesLabel.AutoSize = true;
            this.chooseValuesLabel.Location = new System.Drawing.Point(7, 184);
            this.chooseValuesLabel.Name = "chooseValuesLabel";
            this.chooseValuesLabel.Size = new System.Drawing.Size(340, 13);
            this.chooseValuesLabel.TabIndex = 29;
            this.chooseValuesLabel.Text = "Wpisz po przecinku wartości, jakie mają mieć wybrane wyżej kolumny :";
            this.chooseValuesLabel.Visible = false;
            // 
            // makeQuestionButton
            // 
            this.makeQuestionButton.Location = new System.Drawing.Point(10, 296);
            this.makeQuestionButton.Name = "makeQuestionButton";
            this.makeQuestionButton.Size = new System.Drawing.Size(154, 34);
            this.makeQuestionButton.TabIndex = 28;
            this.makeQuestionButton.Text = "Wykonaj zapytanie";
            this.makeQuestionButton.UseVisualStyleBackColor = true;
            this.makeQuestionButton.Visible = false;
            this.makeQuestionButton.Click += new System.EventHandler(this.makeQuestionButton_Click);
            // 
            // availableColumns
            // 
            this.availableColumns.Enabled = false;
            this.availableColumns.Location = new System.Drawing.Point(10, 83);
            this.availableColumns.MaximumSize = new System.Drawing.Size(450, 50);
            this.availableColumns.MinimumSize = new System.Drawing.Size(379, 40);
            this.availableColumns.Multiline = true;
            this.availableColumns.Name = "availableColumns";
            this.availableColumns.Size = new System.Drawing.Size(450, 40);
            this.availableColumns.TabIndex = 27;
            this.availableColumns.Visible = false;
            this.availableColumns.TextChanged += new System.EventHandler(this.availableColumns_TextChanged);
            // 
            // chooseColumnsLabel
            // 
            this.chooseColumnsLabel.AutoSize = true;
            this.chooseColumnsLabel.Location = new System.Drawing.Point(7, 135);
            this.chooseColumnsLabel.Name = "chooseColumnsLabel";
            this.chooseColumnsLabel.Size = new System.Drawing.Size(227, 13);
            this.chooseColumnsLabel.TabIndex = 26;
            this.chooseColumnsLabel.Text = "Wpisz nazwy wybranych kolumn po przecinku:";
            this.chooseColumnsLabel.Visible = false;
            // 
            // typedInColumnsTextBox
            // 
            this.typedInColumnsTextBox.Location = new System.Drawing.Point(10, 151);
            this.typedInColumnsTextBox.Name = "typedInColumnsTextBox";
            this.typedInColumnsTextBox.Size = new System.Drawing.Size(450, 20);
            this.typedInColumnsTextBox.TabIndex = 25;
            this.typedInColumnsTextBox.Visible = false;
            this.typedInColumnsTextBox.TextChanged += new System.EventHandler(this.typedInColumnsTextBox_TextChanged);
            // 
            // tableNameActivitiesOnBase
            // 
            this.tableNameActivitiesOnBase.FormattingEnabled = true;
            this.tableNameActivitiesOnBase.Location = new System.Drawing.Point(351, 32);
            this.tableNameActivitiesOnBase.Name = "tableNameActivitiesOnBase";
            this.tableNameActivitiesOnBase.Size = new System.Drawing.Size(100, 21);
            this.tableNameActivitiesOnBase.TabIndex = 24;
            this.tableNameActivitiesOnBase.Text = "Wybierz ";
            this.tableNameActivitiesOnBase.Visible = false;
            this.tableNameActivitiesOnBase.SelectedIndexChanged += new System.EventHandler(this.tableNameActivitiesOnBase_SelectedIndexChanged);
            // 
            // availableColumnsLabel
            // 
            this.availableColumnsLabel.AutoSize = true;
            this.availableColumnsLabel.Location = new System.Drawing.Point(7, 67);
            this.availableColumnsLabel.Name = "availableColumnsLabel";
            this.availableColumnsLabel.Size = new System.Drawing.Size(98, 13);
            this.availableColumnsLabel.TabIndex = 11;
            this.availableColumnsLabel.Text = "Dostępne kolumny:";
            this.availableColumnsLabel.Visible = false;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(348, 12);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(71, 13);
            this.tableNameLabel.TabIndex = 9;
            this.tableNameLabel.Text = "Nazwa tabeli:";
            this.tableNameLabel.Visible = false;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(251, 19);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 34);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(170, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(89, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(10, 19);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 34);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(10, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kliknij tu, aby zobaczyć swoje aktualne uprawnienia.";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // yourPowersGroupBox
            // 
            this.yourPowersGroupBox.BackColor = System.Drawing.Color.IndianRed;
            this.yourPowersGroupBox.Controls.Add(this.textBox1);
            this.yourPowersGroupBox.Controls.Add(this.button3);
            this.yourPowersGroupBox.Controls.Add(this.button1);
            this.yourPowersGroupBox.Location = new System.Drawing.Point(496, 514);
            this.yourPowersGroupBox.Name = "yourPowersGroupBox";
            this.yourPowersGroupBox.Size = new System.Drawing.Size(531, 166);
            this.yourPowersGroupBox.TabIndex = 2;
            this.yourPowersGroupBox.TabStop = false;
            this.yourPowersGroupBox.Text = "TWOJE UPRAWNIENIA";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(203, 30);
            this.textBox1.MaximumSize = new System.Drawing.Size(379, 50);
            this.textBox1.MinimumSize = new System.Drawing.Size(50, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 41);
            this.textBox1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(10, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Kliknij tu, aby zobaczyć historię Twoich uprawnień.";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1049, 691);
            this.Controls.Add(this.yourPowersGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.questionResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Magic MsSQL Super DAC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.yourPowersGroupBox.ResumeLayout(false);
            this.yourPowersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button przejmij;
        private System.Windows.Forms.Button przekaz;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView questionResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chosenUserTextBox;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.CheckBox insertCheckBox;
        private System.Windows.Forms.CheckBox deleteCheckBox;
        private System.Windows.Forms.CheckBox updateCheckBox;
        private CheckBox passInsertCheckBox;
        private CheckBox passDeleteCheckBox;
        private CheckBox passUpdateCheckBox;
        private CheckBox passSelectCheckBox;
        private Button button2;
        private GroupBox groupBox3;
        private Button insertButton;
        private Button deleteButton;
        private Button updateButton;
        private Button selectButton;
        private Button button1;
        private GroupBox yourPowersGroupBox;
        private Button button3;
        private ComboBox selectComboBox;
        private Label availableColumnsLabel;
        private Label tableNameLabel;
        private Button makeQuestionButton;
        private TextBox availableColumns;
        private Label chooseColumnsLabel;
        private TextBox typedInColumnsTextBox;
        private ComboBox tableNameActivitiesOnBase;
        private TextBox textBox1;
        private TextBox typedInValuesTextBox;
        private Label chooseValuesLabel;
        private TextBox conditionValueTextBox;
        private TextBox conditionColumnTextBox;
        private Label conditionValueLabel;
        private Label conditionColumnLabel;
    }
}

