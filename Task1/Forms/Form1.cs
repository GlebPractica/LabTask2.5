using Microsoft.EntityFrameworkCore;
using Task1.Classes;

namespace Task1.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            BttnWorkClients.Enabled = false;
            BttnWorkPlayments.Enabled = false;
            
            this.Focus();

            Task.Run(() => MessageBox.Show("Загружаем базу данных..."));
            
            this.Focus();
            
            await CreateDatabaseAsync();

            this.Focus();
        }

        private async Task CreateDatabaseAsync()
        {
            this.Focus();
            try
            {
                using (ApplicationContextDB context = new ApplicationContextDB())
                {
                    this.Focus();

                    await context.Database.EnsureCreatedAsync();

                    this.Focus();

                    MessageBox.Show("База данных загружена", "Результат");

                    this.Focus();

                    BttnWorkPlayments.Enabled = true;
                    BttnWorkClients.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Environment.Exit(1);
            }
        }

        private async Task OpenFormClients()
        {
            BttnWorkClients.Enabled = false;

            using (Clients formClients = new Clients())
            {
                formClients.FormClosed += (sender, args) =>
                {
                    if (BttnWorkClients.InvokeRequired)
                        BttnWorkClients.Invoke(new MethodInvoker(() => BttnWorkClients.Enabled = true));
                    else
                        BttnWorkClients.Enabled = false;
                };

                await Task.Run(() =>
                {
                    formClients.ShowDialog();
                    formClients.Dispose();
                });
            }
        }

        private async Task OpenFormPayments()
        {
            BttnWorkPlayments.Enabled = false;

            using (Payments formPayments = new Payments())
            {
                formPayments.FormClosed += (sender, args) =>
                {
                    if (BttnWorkPlayments.InvokeRequired)
                        BttnWorkPlayments.Invoke(new MethodInvoker(() => BttnWorkPlayments.Enabled = true));
                    else
                        BttnWorkPlayments.Enabled = false;
                };

                await Task.Run(() =>
                {
                    formPayments.ShowDialog();
                    formPayments.Dispose();
                });
            }
        }

        private async void BttnWorkClients_Click(object sender, EventArgs e)
        {
            await OpenFormClients();
        }

        private async void BttnWorkPlayments_Click(object sender, EventArgs e)
        {
            await OpenFormPayments();
        }
    }
}
