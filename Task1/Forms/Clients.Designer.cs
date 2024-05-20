namespace Task1.Forms
{
    partial class Clients
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            BttnRemoveAll = new Button();
            BttnRemove = new Button();
            BttnReset = new Button();
            BttnAdd = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 174);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(784, 387);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(BttnRemoveAll);
            panel1.Controls.Add(BttnRemove);
            panel1.Controls.Add(BttnReset);
            panel1.Controls.Add(BttnAdd);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 174);
            panel1.TabIndex = 1;
            // 
            // BttnRemoveAll
            // 
            BttnRemoveAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnRemoveAll.Location = new Point(630, 92);
            BttnRemoveAll.Name = "BttnRemoveAll";
            BttnRemoveAll.Size = new Size(142, 41);
            BttnRemoveAll.TabIndex = 21;
            BttnRemoveAll.Text = "Удалить все";
            BttnRemoveAll.UseVisualStyleBackColor = true;
            BttnRemoveAll.Click += BttnRemoveAll_Click;
            // 
            // BttnRemove
            // 
            BttnRemove.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnRemove.Location = new Point(630, 48);
            BttnRemove.Name = "BttnRemove";
            BttnRemove.Size = new Size(142, 41);
            BttnRemove.TabIndex = 20;
            BttnRemove.Text = "Удалить";
            BttnRemove.UseVisualStyleBackColor = true;
            BttnRemove.Click += BttnRemove_Click;
            // 
            // BttnReset
            // 
            BttnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnReset.Location = new Point(485, 92);
            BttnReset.Name = "BttnReset";
            BttnReset.Size = new Size(142, 41);
            BttnReset.TabIndex = 16;
            BttnReset.Text = "Сбросить";
            BttnReset.UseVisualStyleBackColor = true;
            BttnReset.Click += BttnReset_Click;
            // 
            // BttnAdd
            // 
            BttnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnAdd.Location = new Point(485, 48);
            BttnAdd.Name = "BttnAdd";
            BttnAdd.Size = new Size(142, 41);
            BttnAdd.TabIndex = 15;
            BttnAdd.Text = "Принять";
            BttnAdd.UseVisualStyleBackColor = true;
            BttnAdd.Click += BttnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "08:00 - 10:00", "10:00 - 12:00", "13:00 -15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            comboBox1.Location = new Point(250, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 106);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 13;
            label6.Text = "Время занятий";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(250, 80);
            numericUpDown1.Maximum = new decimal(new int[] { 1250, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 62);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Месячная оплата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 18);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Пол";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 106);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Дата рождения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Номер телефона";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Clients";
            ShowIcon = false;
            Text = "Окно работы с клиентами";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Button BttnReset;
        private Button BttnAdd;
        private ComboBox comboBox1;
        private Button BttnRemove;
        private Button BttnRemoveAll;
    }
}