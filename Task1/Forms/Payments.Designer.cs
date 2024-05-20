namespace Task1.Forms
{
    partial class Payments
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
            comboBox1 = new ComboBox();
            BttnRemoveAll = new Button();
            BttnRemove = new Button();
            BttnReset = new Button();
            BttnAdd = new Button();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(BttnRemoveAll);
            panel1.Controls.Add(BttnRemove);
            panel1.Controls.Add(BttnReset);
            panel1.Controls.Add(BttnAdd);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 188);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(64, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 38;
            // 
            // BttnRemoveAll
            // 
            BttnRemoveAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnRemoveAll.Location = new Point(450, 104);
            BttnRemoveAll.Name = "BttnRemoveAll";
            BttnRemoveAll.Size = new Size(142, 41);
            BttnRemoveAll.TabIndex = 37;
            BttnRemoveAll.Text = "Удалить все";
            BttnRemoveAll.UseVisualStyleBackColor = true;
            BttnRemoveAll.Click += BttnRemoveAll_Click;
            // 
            // BttnRemove
            // 
            BttnRemove.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnRemove.Location = new Point(450, 60);
            BttnRemove.Name = "BttnRemove";
            BttnRemove.Size = new Size(142, 41);
            BttnRemove.TabIndex = 36;
            BttnRemove.Text = "Удалить";
            BttnRemove.UseVisualStyleBackColor = true;
            BttnRemove.Click += BttnRemove_Click;
            // 
            // BttnReset
            // 
            BttnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnReset.Location = new Point(305, 104);
            BttnReset.Name = "BttnReset";
            BttnReset.Size = new Size(142, 41);
            BttnReset.TabIndex = 35;
            BttnReset.Text = "Сбросить";
            BttnReset.UseVisualStyleBackColor = true;
            BttnReset.Click += BttnReset_Click;
            // 
            // BttnAdd
            // 
            BttnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnAdd.Location = new Point(305, 60);
            BttnAdd.Name = "BttnAdd";
            BttnAdd.Size = new Size(142, 41);
            BttnAdd.TabIndex = 34;
            BttnAdd.Text = "Принять";
            BttnAdd.UseVisualStyleBackColor = true;
            BttnAdd.Click += BttnAdd_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(64, 136);
            numericUpDown1.Maximum = new decimal(new int[] { 1250, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 31;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 118);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 30;
            label5.Text = "Месячная оплата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(64, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 74);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 26;
            label3.Text = "Дата оплаты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 23;
            label1.Text = "ID клиента";
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Payments";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оплата";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button BttnRemoveAll;
        private Button BttnRemove;
        private Button BttnReset;
        private Button BttnAdd;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
    }
}