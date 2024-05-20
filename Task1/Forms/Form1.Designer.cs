namespace Task1.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BttnWorkClients = new Button();
            BttnWorkPlayments = new Button();
            SuspendLayout();
            // 
            // BttnWorkClients
            // 
            BttnWorkClients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnWorkClients.Location = new Point(12, 12);
            BttnWorkClients.Name = "BttnWorkClients";
            BttnWorkClients.Size = new Size(333, 77);
            BttnWorkClients.TabIndex = 0;
            BttnWorkClients.Text = "Клиенты";
            BttnWorkClients.UseVisualStyleBackColor = true;
            BttnWorkClients.Click += BttnWorkClients_Click;
            // 
            // BttnWorkPlayments
            // 
            BttnWorkPlayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BttnWorkPlayments.Location = new Point(12, 95);
            BttnWorkPlayments.Name = "BttnWorkPlayments";
            BttnWorkPlayments.Size = new Size(333, 77);
            BttnWorkPlayments.TabIndex = 1;
            BttnWorkPlayments.Text = "Оплата";
            BttnWorkPlayments.UseVisualStyleBackColor = true;
            BttnWorkPlayments.Click += BttnWorkPlayments_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 182);
            Controls.Add(BttnWorkPlayments);
            Controls.Add(BttnWorkClients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задание";
            ResumeLayout(false);
        }

        #endregion

        private Button BttnWorkClients;
        private Button BttnWorkPlayments;
    }
}
