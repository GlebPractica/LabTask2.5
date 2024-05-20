using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;

namespace Task1.Forms
{
    public partial class Clients : Form
    {
        private Member? _selectedMember;

        public Clients()
        {
            InitializeComponent();
            this.Load += Clients_Load;
        }

        private void Clients_Load(object? sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadMemberInfo();
        }

        //Start User Functions

        private async void LoadMemberInfo()
        {
            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var listMem = await context.MemberTbl.ToListAsync();

                dataGridView1.DataSource = listMem;
            }
        }

        private async void SaveMemberTbl(Member newMember)
        {
            try
            {
                using (ApplicationContextDB context = new ApplicationContextDB())
                {
                    context.MemberTbl.Add(newMember);

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                // Получите внутреннее исключение для более детальной информации
                var innerException = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(innerException, "Ошибка сохранения данных");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
            }
        }

        private Member? GetMember(int index)
        {
            if (index >= 0)
                return dataGridView1.Rows[index].DataBoundItem as Member;

            throw new Exception("Не выбран клиент");
        }

        private int GetIndex(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                return e.RowIndex;

            return -1;
        }

        private void RemoveAllMembers()
        {
            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                var members = context.MemberTbl.ToList();

                foreach (Member member in members)
                {
                    context.MemberTbl.Remove(member);
                }

                context.SaveChanges();
            }
        }

        private void RemoveMember(Member member)
        {
            if (member == null)
                throw new Exception("Некого удалять");

            using (ApplicationContextDB context = new ApplicationContextDB())
            {
                context.MemberTbl.Remove(member);

                context.SaveChanges();
            }
        }

        //End User Function

        private void BttnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Не написано ФИО", "Ошибка");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Не написан номер телефона", "Ошибка");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Не написан пол", "Ошибка");
                return;
            }

            if (dateTimePicker1.Value.Date.Year >= DateTime.Now.Year - 3)
            {
                MessageBox.Show("Неверно введена дата рождения", "Ошибка");
                return;
            }

            try
            {
                Member newMember = new Member()
                {
                    Name = textBox1.Text,
                    Phone = textBox2.Text,
                    DateBirthDay = dateTimePicker1.Value.Date,
                    Gen = textBox3.Text,
                    Amount = numericUpDown1.Value,
                    Timing = comboBox1.SelectedItem.ToString()
                };

                SaveMemberTbl(newMember);

                MessageBox.Show("Успешно добавлено", "Результат");

                LoadMemberInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now.Date;
            textBox3.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox1.SelectedIndex = 0;
        }

        private void BttnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedMember == null)
                    throw new Exception("Клиент не выбран");

                RemoveMember(_selectedMember);

                MessageBox.Show("Успешно удалено", "Результат");

                LoadMemberInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveAllMembers();

                MessageBox.Show("Все успешно удалено", "Результат");

                LoadMemberInfo();
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

                _selectedMember = GetMember(selectedIndex);

                if (_selectedMember != null)
                {
                    textBox1.Text = _selectedMember.Name;
                    textBox2.Text = _selectedMember.Phone;
                    dateTimePicker1.Value = _selectedMember.DateBirthDay;
                    textBox3.Text = _selectedMember.Gen;
                    numericUpDown1.Value = _selectedMember.Amount;
                    comboBox1.Text = _selectedMember.Timing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
