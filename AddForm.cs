using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    static public class lastnumber
    {
        static public int number = -1;
    }
    public partial class AddForm : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ProjectDB.mdb";
        OleDbConnection myConnection;
        public AddForm()
        {
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = 0;
            if (textBox1.Text != "") kod = Convert.ToInt32(textBox1.Text);
            string oshibka = textBox2.Text;
            string primer = textBox3.Text;
            string prav_primer = textBox4.Text;
            string poyasnenie = textBox5.Text;
            string query = "INSERT INTO Ошибки ([Уникальный номер], [Текст ошибки], Пример, [Исправленный пример], Пояснение) " +
                "VALUES (" + kod + ", '" + oshibka + "', '" + primer + "', '" + prav_primer + "', '" + poyasnenie + "')";
            OleDbCommand command = new OleDbCommand(query,myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("added");

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
