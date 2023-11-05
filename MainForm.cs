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
    public partial class MainForm : Form
    {
        string transferstring;
        string searchstring;
        string[] mas_strok;
        int[] mas_index;
        public static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ProjectDB.mdb";
        OleDbConnection myConnection;

        public MainForm()
        {
            //this.BackColor = Color.FromArgb(14, 42, 71);
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            dataGridView1.Columns[3].Width = 150;
            
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

        private void редактироватьToolStripButton_Click(object sender, EventArgs e)
        {
            EditorForm f2 = new EditorForm();
            f2.Show();
        }

        private void добавитьToolStripButton_Click(object sender, EventArgs e)
        {
            AddForm f3 = new AddForm();
            f3.Show();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            searchstring = textBox2.Text;
            mas_strok = new string[dataGridView1.Rows.Count];
            mas_index = new int[dataGridView1.Rows.Count];
            for (int i = 0; i < mas_strok.Length; i++)
            {
                mas_strok[i] = Convert.ToString(dataGridView1[1, i].Value);
            }
            int g = 0;
            for (int i = 0; i < mas_strok.Length; i++)
            {
                bool finded = mas_strok[i].Contains(searchstring);
                if(finded == true)
                {
                    
                    mas_index[g] = i;g++;
                    listBox1.Items.Add(g + ") " + mas_strok[i]);
                }
            }
 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ошибкиTableAdapter.Fill(this.projectDBDataSet.Ошибки);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int current = listBox1.SelectedIndex;
            int index = mas_index[current];
            panel1.Visible = false;
            panel2.Visible = true;
            richTextBox1.Text = Convert.ToString(dataGridView1[1, index].Value);
            richTextBox2.Text = Convert.ToString(dataGridView1[2, index].Value);
            richTextBox3.Text = Convert.ToString(dataGridView1[3, index].Value);
            transferstring = Convert.ToString(dataGridView1[4, index].Value);
        }

        private void наглавнуюToolStripButton_Click(object sender, EventArgs e)
        {
            panel1.Visible =true;
            panel2.Visible = false;
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExplanationForm ef = new ExplanationForm();
            ef.TransferText(transferstring);
            ef.Show();
        }
    }
}
