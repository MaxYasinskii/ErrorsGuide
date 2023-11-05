
namespace WindowsFormsApp1
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.уникальныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстОшибкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исправленныйПримерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пояснениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ошибкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new WindowsFormsApp1.ProjectDBDataSet();
            this.ошибкиTableAdapter = new WindowsFormsApp1.ProjectDBDataSetTableAdapters.ОшибкиTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ошибкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(726, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 174);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить ошибку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер ошибки: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.уникальныйНомерDataGridViewTextBoxColumn,
            this.текстОшибкиDataGridViewTextBoxColumn,
            this.примерDataGridViewTextBoxColumn,
            this.исправленныйПримерDataGridViewTextBoxColumn,
            this.пояснениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ошибкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 236);
            this.dataGridView1.TabIndex = 5;
            // 
            // уникальныйНомерDataGridViewTextBoxColumn
            // 
            this.уникальныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Уникальный номер";
            this.уникальныйНомерDataGridViewTextBoxColumn.HeaderText = "Уникальный номер";
            this.уникальныйНомерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.уникальныйНомерDataGridViewTextBoxColumn.Name = "уникальныйНомерDataGridViewTextBoxColumn";
            this.уникальныйНомерDataGridViewTextBoxColumn.Width = 125;
            // 
            // текстОшибкиDataGridViewTextBoxColumn
            // 
            this.текстОшибкиDataGridViewTextBoxColumn.DataPropertyName = "Текст ошибки";
            this.текстОшибкиDataGridViewTextBoxColumn.HeaderText = "Текст ошибки";
            this.текстОшибкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.текстОшибкиDataGridViewTextBoxColumn.Name = "текстОшибкиDataGridViewTextBoxColumn";
            this.текстОшибкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // примерDataGridViewTextBoxColumn
            // 
            this.примерDataGridViewTextBoxColumn.DataPropertyName = "Пример";
            this.примерDataGridViewTextBoxColumn.HeaderText = "Пример";
            this.примерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.примерDataGridViewTextBoxColumn.Name = "примерDataGridViewTextBoxColumn";
            this.примерDataGridViewTextBoxColumn.Width = 125;
            // 
            // исправленныйПримерDataGridViewTextBoxColumn
            // 
            this.исправленныйПримерDataGridViewTextBoxColumn.DataPropertyName = "Исправленный пример";
            this.исправленныйПримерDataGridViewTextBoxColumn.HeaderText = "Исправленный пример";
            this.исправленныйПримерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.исправленныйПримерDataGridViewTextBoxColumn.Name = "исправленныйПримерDataGridViewTextBoxColumn";
            this.исправленныйПримерDataGridViewTextBoxColumn.Width = 125;
            // 
            // пояснениеDataGridViewTextBoxColumn
            // 
            this.пояснениеDataGridViewTextBoxColumn.DataPropertyName = "Пояснение";
            this.пояснениеDataGridViewTextBoxColumn.HeaderText = "Пояснение";
            this.пояснениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пояснениеDataGridViewTextBoxColumn.Name = "пояснениеDataGridViewTextBoxColumn";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(729, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(929, 471);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ошибкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource ошибкиBindingSource;
        private ProjectDBDataSetTableAdapters.ОшибкиTableAdapter ошибкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn уникальныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстОшибкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исправленныйПримерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пояснениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}

