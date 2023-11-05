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
    public partial class EditorForm : Form
    {
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ProjectDB.mdb";
        OleDbConnection myConnection;
        AddForm f2;
        public EditorForm()
        {
            
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            dataGridView1.Columns[3].Width = 150;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm f3 = new AddForm();
            f3.Show();
            this.ошибкиTableAdapter.Fill(this.projectDBDataSet.Ошибки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Ошибки WHERE [Уникальный номер] = " + kod;
            OleDbCommand command = new OleDbCommand(query,myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("deleted");
            this.ошибкиTableAdapter.Fill(this.projectDBDataSet.Ошибки);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectDBDataSet.Ошибки". При необходимости она может быть перемещена или удалена.
            this.ошибкиTableAdapter.Fill(this.projectDBDataSet.Ошибки);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ошибкиTableAdapter.Fill(this.projectDBDataSet.Ошибки);

        }
    }
}
