
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.уникальныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстОшибкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исправленныйПримерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пояснениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ошибкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new WindowsFormsApp1.ProjectDBDataSet();
            this.ошибкиTableAdapter = new WindowsFormsApp1.ProjectDBDataSetTableAdapters.ОшибкиTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.добавитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.редактироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.наглавнуюToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ошибкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.уникальныйНомерDataGridViewTextBoxColumn,
            this.текстОшибкиDataGridViewTextBoxColumn,
            this.примерDataGridViewTextBoxColumn,
            this.исправленныйПримерDataGridViewTextBoxColumn,
            this.пояснениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ошибкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(856, 384);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 244);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // уникальныйНомерDataGridViewTextBoxColumn
            // 
            this.уникальныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Уникальный номер";
            this.уникальныйНомерDataGridViewTextBoxColumn.HeaderText = "Уникальный номер";
            this.уникальныйНомерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.уникальныйНомерDataGridViewTextBoxColumn.Name = "уникальныйНомерDataGridViewTextBoxColumn";
            this.уникальныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.уникальныйНомерDataGridViewTextBoxColumn.Width = 125;
            // 
            // текстОшибкиDataGridViewTextBoxColumn
            // 
            this.текстОшибкиDataGridViewTextBoxColumn.DataPropertyName = "Текст ошибки";
            this.текстОшибкиDataGridViewTextBoxColumn.HeaderText = "Текст ошибки";
            this.текстОшибкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.текстОшибкиDataGridViewTextBoxColumn.Name = "текстОшибкиDataGridViewTextBoxColumn";
            this.текстОшибкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.текстОшибкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // примерDataGridViewTextBoxColumn
            // 
            this.примерDataGridViewTextBoxColumn.DataPropertyName = "Пример";
            this.примерDataGridViewTextBoxColumn.HeaderText = "Пример";
            this.примерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.примерDataGridViewTextBoxColumn.Name = "примерDataGridViewTextBoxColumn";
            this.примерDataGridViewTextBoxColumn.ReadOnly = true;
            this.примерDataGridViewTextBoxColumn.Width = 125;
            // 
            // исправленныйПримерDataGridViewTextBoxColumn
            // 
            this.исправленныйПримерDataGridViewTextBoxColumn.DataPropertyName = "Исправленный пример";
            this.исправленныйПримерDataGridViewTextBoxColumn.HeaderText = "Исправленный пример";
            this.исправленныйПримерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.исправленныйПримерDataGridViewTextBoxColumn.Name = "исправленныйПримерDataGridViewTextBoxColumn";
            this.исправленныйПримерDataGridViewTextBoxColumn.ReadOnly = true;
            this.исправленныйПримерDataGridViewTextBoxColumn.Width = 125;
            // 
            // пояснениеDataGridViewTextBoxColumn
            // 
            this.пояснениеDataGridViewTextBoxColumn.DataPropertyName = "Пояснение";
            this.пояснениеDataGridViewTextBoxColumn.HeaderText = "Пояснение";
            this.пояснениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пояснениеDataGridViewTextBoxColumn.Name = "пояснениеDataGridViewTextBoxColumn";
            this.пояснениеDataGridViewTextBoxColumn.ReadOnly = true;
            this.пояснениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ошибкиBindingSource
            // 
            this.ошибкиBindingSource.DataMember = "Ошибки";
            this.ошибкиBindingSource.DataSource = this.projectDBDataSet;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ошибкиTableAdapter
            // 
            this.ошибкиTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripButton,
            this.редактироватьToolStripButton,
            this.наглавнуюToolStripButton,
            this.toolStripButton1,
            this.toolStripSeparator,
            this.справкаToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(549, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 505);
            this.panel1.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(18, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(880, 356);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Результаты:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(599, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 45);
            this.button2.TabIndex = 29;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 27);
            this.textBox2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Поиск по тексту ошибки:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 505);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(749, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 69);
            this.button1.TabIndex = 37;
            this.button1.Text = "Дополнительная информация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Решение:";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(468, 140);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(450, 362);
            this.richTextBox3.TabIndex = 35;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Пример:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 140);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(450, 362);
            this.richTextBox2.TabIndex = 33;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Текст ошибки:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(742, 69);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // добавитьToolStripButton
            // 
            this.добавитьToolStripButton.Image = global::WindowsFormsApp1.Properties.Resources.icon_add;
            this.добавитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.добавитьToolStripButton.Name = "добавитьToolStripButton";
            this.добавитьToolStripButton.Size = new System.Drawing.Size(100, 24);
            this.добавитьToolStripButton.Text = "&Добавить";
            this.добавитьToolStripButton.Click += new System.EventHandler(this.добавитьToolStripButton_Click);
            // 
            // редактироватьToolStripButton
            // 
            this.редактироватьToolStripButton.Image = global::WindowsFormsApp1.Properties.Resources.icon_edit;
            this.редактироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.редактироватьToolStripButton.Name = "редактироватьToolStripButton";
            this.редактироватьToolStripButton.Size = new System.Drawing.Size(135, 24);
            this.редактироватьToolStripButton.Text = "&Редактировать";
            this.редактироватьToolStripButton.Click += new System.EventHandler(this.редактироватьToolStripButton_Click);
            // 
            // наглавнуюToolStripButton
            // 
            this.наглавнуюToolStripButton.Image = global::WindowsFormsApp1.Properties.Resources._21bb7231a240f8e116582835af4290a5;
            this.наглавнуюToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.наглавнуюToolStripButton.Name = "наглавнуюToolStripButton";
            this.наглавнуюToolStripButton.Size = new System.Drawing.Size(114, 24);
            this.наглавнуюToolStripButton.Text = "&На главную";
            this.наглавнуюToolStripButton.Click += new System.EventHandler(this.наглавнуюToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 24);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(91, 24);
            this.справкаToolStripButton.Text = "Спр&авка";
            this.справкаToolStripButton.Click += new System.EventHandler(this.справкаToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 600);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник ошибок C++ для начинающего программиста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ошибкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource ошибкиBindingSource;
        private ProjectDBDataSetTableAdapters.ОшибкиTableAdapter ошибкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn уникальныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстОшибкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исправленныйПримерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пояснениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton редактироватьToolStripButton;
        private System.Windows.Forms.ToolStripButton добавитьToolStripButton;
        private System.Windows.Forms.ToolStripButton наглавнуюToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

