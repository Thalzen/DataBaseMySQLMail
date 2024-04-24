using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;
using System.Text.RegularExpressions;


namespace DataBaseMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select ID,Name,Age,Sexe,Email From MailDB Where id=@id", conn);
            cmd.Parameters.AddWithValue("ID", textID.Text.Trim());
            MySqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                textName.Text = myreader["Name"].ToString();
                textAge.Text = myreader["Age"].ToString();
                textSexe.Text = myreader["Sexe"].ToString();
                textEmail.Text = myreader["Email"].ToString();
            }
            else
            {

                textName.Text = "";
                textAge.Text = "";
                textSexe.Text = "";
                textEmail.Text = "";
                MessageBox.Show("No Data Found");

            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textEmail.Text, @"^(?!(?:[^@]*@){2})(?!(?:[^.]*\.){2})[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid E-mail address");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Update MailDB Set Name = @Name,Age = @Age,Sexe = @Sexe,Email = @Email Where id=@id", conn);
                cmd.Parameters.AddWithValue("ID", textID.Text.Trim());
                cmd.Parameters.AddWithValue("Name", textName.Text.Trim());
                cmd.Parameters.AddWithValue("Age", textAge.Text.Trim());
                cmd.Parameters.AddWithValue("Sexe", textSexe.Text.Trim());
                cmd.Parameters.AddWithValue("Email", textEmail.Text.Trim());
                cmd.ExecuteNonQuery();
                conn.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textEmail.Text, @"^(?!(?:[^@]*@){2})(?!(?:[^.]*\.){2})[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {

                MessageBox.Show("Please enter a valid E-mail address");

            }
            else
            {
                MySqlConnection conn = new MySqlConnection("");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into MailDB (Name, Age, Sexe, Email) Values (@Name, @Age, @Sexe, @Email)", conn);
                cmd.Parameters.AddWithValue("Name", textName.Text.Trim());
                cmd.Parameters.AddWithValue("Age", textAge.Text.Trim());
                cmd.Parameters.AddWithValue("Sexe", textSexe.Text.Trim());
                cmd.Parameters.AddWithValue("Email", textEmail.Text.Trim());
                cmd.ExecuteNonQuery();
                conn.Close();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM MailDB Where id=@id", conn);
            cmd.Parameters.AddWithValue("ID", textID.Text.Trim());
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            var form = new Form2();
            form.Show();
            form.textRecipient.Text = textEmail.Text;


        }

        private void button6_Click(object sender, EventArgs e)
        {

            CreateJson();


        }

        private void CreateCSV()
        {

            Person person = new Person()
            {
                name = textName.Text,
                age = textAge.Text,
                sexe = textSexe.Text,
                email = textEmail.Text,
            };
            List<Person> personlist = new List<Person>() { person };
            string folderpath = Directory.GetCurrentDirectory();
            string csvFolderPath = Path.Combine(folderpath, "CSV_Files");
            if (!File.Exists(csvFolderPath))
            {
                Directory.CreateDirectory(csvFolderPath);
            }

            string csvFilesPath = Path.Combine(csvFolderPath, "Person.csv");


            using (var writer = new StreamWriter(csvFilesPath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(personlist);
                MessageBox.Show("CSV files has been created" + MessageBoxButtons.OK);
            }


        }

        private void CreateJson()
        {
            //textName.Text, textAge.Text, textSexe.Text, textEmail.Text
            Person person = new Person()
            {
                name = textName.Text,
                age = textAge.Text,
                sexe = textSexe.Text,
                email = textEmail.Text,
            };

            string strResultJson = JsonConvert.SerializeObject(person);
            List<Person> personlist = new List<Person>() { person };
            string folderpath = Directory.GetCurrentDirectory();
            string jsonFolderPath = Path.Combine(folderpath, "JSON_Files");
            if (!File.Exists(jsonFolderPath))
            {
                Directory.CreateDirectory(jsonFolderPath);

            }
            File.WriteAllText(@"Person.json", strResultJson);
            string jsonFilesPath = Path.Combine(jsonFolderPath, "Person.json");


        }

        private void textSexe_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(textSexe.Text, "[fF]") && !Regex.IsMatch(textSexe.Text, "[mM]") && textSexe.Text != "")
            {
                textSexe.Text = "";
                MessageBox.Show("Please enter a valid sexe");

            }
        }
        private void DataTest()
        {




        }

    }

    class Person
    {

        public string name {  get; set; }
        public string age { get; set; }
        public string sexe { get; set; }
        public string email { get; set; }
       
        public Person()
        {

          

        }

    }
}
