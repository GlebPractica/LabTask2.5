using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1.Forms
{
    public partial class Payments : Form
    {
        private Payment? _selectedPayment;
        private Dictionary<int, int> memberIndexMap;

        public Payments()
        {
            InitializeComponent();
            this.Load += Payments_Load;
        }

        private void Payments_Load(object? sender, EventArgs e)
        {
            LoadPayments();
            LoadMembers();
        }

        //Start User Functions

        private void LoadPayments()
        {
            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var listPayments = context.PaymentTbl.ToList();

                dataGridView1.DataSource = listPayments;
            }
        }

        private void LoadMembers()
        {
            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var listMembers = context.MemberTbl.ToList();

                comboBox1.Items.Clear();
                memberIndexMap = new Dictionary<int, int>();

                for (int i = 0; i < listMembers.Count; i++)
                {
                    Member mem = listMembers[i];
                    comboBox1.Items.Add(mem.Id + " ФИО:" + mem.Name + " Оплата:" + mem.Amount);
                    memberIndexMap[mem.Id] = i;
                }
            }
        }

        private void SavePayment(Payment payment)
        {
            if (payment == null)
                throw new Exception("Нечего сохранять");

            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                context.PaymentTbl.Add(payment);
                context.SaveChanges();
            }
        }

        private void RemovePayment(Payment payment)
        {
            if (payment == null)
                throw new Exception("Нечего удалять");

            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                context.PaymentTbl.Remove(payment);
                context.SaveChanges();
            }
        }

        private void RemoveAllPayments()
        {
            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var listPay = context.PaymentTbl.ToList();

                foreach (Payment pay in listPay)
                {
                    context.PaymentTbl.Remove(pay);
                }

                context.SaveChanges();
            }
        }

        private int GetIndex(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                return e.RowIndex;

            return -1;
        }

        private Payment? GetPayment(int index)
        {
            if (index >= 0)
                return dataGridView1.Rows[index].DataBoundItem as Payment;

            throw new Exception("Не выбрана оплата");
        }

        private int IdM()
        {
            if (comboBox1.SelectedItem == null)
                return -1;

            try
            {
                string[]? partsStr = comboBox1.SelectedItem.ToString().Split(' ');

                int IDMember = int.Parse(partsStr[0]);

                partsStr = null;

                return IDMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1;
            }
        }

        private bool IsMemberFind(int idM)
        {
            if (idM < 0)
                throw new Exception("Запись не найдена");

            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var curMem = context.MemberTbl.Find(idM);

                if (curMem != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void DefaultValues()
        {
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = numericUpDown1.Minimum;
        }

        //End User Functions

        private void BttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int idM = IdM();

                if (IsMemberFind(idM))
                {
                    Payment pay = new Payment()
                    {
                        MemberId = idM,
                        DatePay = dateTimePicker1.Value.Date,
                        Amount = numericUpDown1.Value
                    };

                    SavePayment(pay);

                    MessageBox.Show("Успешно добавлено", "Результат");

                    LoadPayments();
                }
                else
                {
                    MessageBox.Show("Клиент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedPayment == null)
                    throw new Exception("Оплата не выбрана");

                RemovePayment(_selectedPayment);

                MessageBox.Show("Успешно удалено", "Результат");

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttnReset_Click(object sender, EventArgs e)
        {
            DefaultValues();
        }

        private void BttnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveAllPayments();

                MessageBox.Show("Успешно все удалено", "Результат");

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = GetIndex(e);

                _selectedPayment = GetPayment(selectedIndex);

                if (_selectedPayment != null)
                {
                    int MemberId = _selectedPayment.MemberId;

                    if (memberIndexMap.TryGetValue(MemberId, out int idItem))
                    {
                        comboBox1.SelectedIndex = idItem;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = -1;
                    }

                    dateTimePicker1.Value = _selectedPayment.DatePay;
                    numericUpDown1.Value = _selectedPayment.Amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
