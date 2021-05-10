
namespace Philately_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actionsBlock = new System.Windows.Forms.GroupBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Owners = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadDataGridView2 = new System.Windows.Forms.Button();
            this.updateDataGridView2 = new System.Windows.Forms.Button();
            this.deleteDataGridView2 = new System.Windows.Forms.Button();
            this.addDataGridView2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country_Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.TabPage();
            this.m_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.circulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.actionsBlock.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Owners.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Marks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.действиеToolStripMenuItem.Text = "Дії";
            this.действиеToolStripMenuItem.Click += new System.EventHandler(this.действиеToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.оПрограммеToolStripMenuItem.Text = "Про програму";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.выходToolStripMenuItem.Text = "Вихід";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_code,
            this.country,
            this.cost,
            this.year,
            this.circulation});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // actionsBlock
            // 
            this.actionsBlock.Controls.Add(this.downloadButton);
            this.actionsBlock.Controls.Add(this.updateButton);
            this.actionsBlock.Controls.Add(this.deleteButton);
            this.actionsBlock.Controls.Add(this.addButton);
            this.actionsBlock.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionsBlock.Location = new System.Drawing.Point(656, 3);
            this.actionsBlock.Name = "actionsBlock";
            this.actionsBlock.Size = new System.Drawing.Size(239, 211);
            this.actionsBlock.TabIndex = 3;
            this.actionsBlock.TabStop = false;
            this.actionsBlock.Text = "Дії";
            this.actionsBlock.Enter += new System.EventHandler(this.actionsBlock_Enter);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(6, 49);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(227, 23);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Загрузить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 136);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(227, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 107);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(227, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(227, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Owners);
            this.tabControl1.Controls.Add(this.Marks);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 243);
            this.tabControl1.TabIndex = 4;
            // 
            // Owners
            // 
            this.Owners.Controls.Add(this.groupBox1);
            this.Owners.Controls.Add(this.dataGridView2);
            this.Owners.Location = new System.Drawing.Point(4, 22);
            this.Owners.Name = "Owners";
            this.Owners.Padding = new System.Windows.Forms.Padding(3);
            this.Owners.Size = new System.Drawing.Size(898, 217);
            this.Owners.TabIndex = 0;
            this.Owners.Text = "Власники";
            this.Owners.UseVisualStyleBackColor = true;
            this.Owners.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadDataGridView2);
            this.groupBox1.Controls.Add(this.updateDataGridView2);
            this.groupBox1.Controls.Add(this.deleteDataGridView2);
            this.groupBox1.Controls.Add(this.addDataGridView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(652, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дії";
            // 
            // downloadDataGridView2
            // 
            this.downloadDataGridView2.Location = new System.Drawing.Point(8, 50);
            this.downloadDataGridView2.Name = "downloadDataGridView2";
            this.downloadDataGridView2.Size = new System.Drawing.Size(227, 23);
            this.downloadDataGridView2.TabIndex = 8;
            this.downloadDataGridView2.Text = "Загрузить";
            this.downloadDataGridView2.UseVisualStyleBackColor = true;
            this.downloadDataGridView2.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateDataGridView2
            // 
            this.updateDataGridView2.Location = new System.Drawing.Point(8, 137);
            this.updateDataGridView2.Name = "updateDataGridView2";
            this.updateDataGridView2.Size = new System.Drawing.Size(227, 23);
            this.updateDataGridView2.TabIndex = 7;
            this.updateDataGridView2.Text = "Обновить";
            this.updateDataGridView2.UseVisualStyleBackColor = true;
            this.updateDataGridView2.Click += new System.EventHandler(this.updateDataGridView2_Click);
            // 
            // deleteDataGridView2
            // 
            this.deleteDataGridView2.Location = new System.Drawing.Point(8, 108);
            this.deleteDataGridView2.Name = "deleteDataGridView2";
            this.deleteDataGridView2.Size = new System.Drawing.Size(227, 23);
            this.deleteDataGridView2.TabIndex = 6;
            this.deleteDataGridView2.Text = "Удалить";
            this.deleteDataGridView2.UseVisualStyleBackColor = true;
            this.deleteDataGridView2.Click += new System.EventHandler(this.deleteDataGridView2_Click);
            // 
            // addDataGridView2
            // 
            this.addDataGridView2.Location = new System.Drawing.Point(8, 79);
            this.addDataGridView2.Name = "addDataGridView2";
            this.addDataGridView2.Size = new System.Drawing.Size(227, 23);
            this.addDataGridView2.TabIndex = 5;
            this.addDataGridView2.Text = "Добавить";
            this.addDataGridView2.UseVisualStyleBackColor = true;
            this.addDataGridView2.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_code,
            this.Surname,
            this.Namee,
            this.Country_Owner,
            this.Mark_Code,
            this.Mark_Count});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 211);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // id_code
            // 
            this.id_code.HeaderText = "ID";
            this.id_code.Name = "id_code";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Призвіще";
            this.Surname.Name = "Surname";
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Ім\'я";
            this.Namee.Name = "Namee";
            // 
            // Country_Owner
            // 
            this.Country_Owner.HeaderText = "Країна";
            this.Country_Owner.Name = "Country_Owner";
            // 
            // Mark_Code
            // 
            this.Mark_Code.HeaderText = "Код марки";
            this.Mark_Code.Name = "Mark_Code";
            // 
            // Mark_Count
            // 
            this.Mark_Count.HeaderText = "Кількість";
            this.Mark_Count.Name = "Mark_Count";
            // 
            // Marks
            // 
            this.Marks.Controls.Add(this.dataGridView1);
            this.Marks.Controls.Add(this.actionsBlock);
            this.Marks.Location = new System.Drawing.Point(4, 22);
            this.Marks.Name = "Marks";
            this.Marks.Padding = new System.Windows.Forms.Padding(3);
            this.Marks.Size = new System.Drawing.Size(898, 217);
            this.Marks.TabIndex = 1;
            this.Marks.Text = "Марки";
            this.Marks.UseVisualStyleBackColor = true;
            this.Marks.Click += new System.EventHandler(this.Marks_Click);
            // 
            // m_code
            // 
            this.m_code.HeaderText = "ID";
            this.m_code.Name = "m_code";
            // 
            // country
            // 
            this.country.HeaderText = "Країна";
            this.country.Name = "country";
            // 
            // cost
            // 
            this.cost.HeaderText = "Вартість";
            this.cost.Name = "cost";
            // 
            // year
            // 
            this.year.HeaderText = "Рік";
            this.year.Name = "year";
            // 
            // circulation
            // 
            this.circulation.HeaderText = "Тираж";
            this.circulation.Name = "circulation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 267);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Philately Manager v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.actionsBlock.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Owners.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Marks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox actionsBlock;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Owners;
        private System.Windows.Forms.TabPage Marks;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button downloadDataGridView2;
        private System.Windows.Forms.Button updateDataGridView2;
        private System.Windows.Forms.Button deleteDataGridView2;
        private System.Windows.Forms.Button addDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country_Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn circulation;
    }
}

