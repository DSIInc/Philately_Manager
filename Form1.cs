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

namespace Philately_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!","Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string country = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string year = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string circularity = dataGridView1.Rows[index].Cells[4].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "INSERT INTO Marks VALUES (" + id + ", '" + country + "', " + cost + ", " + year + ", " + circularity + ")"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані добавлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            if(dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не всі дані були введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string m_code = dataGridView1.Rows[index].Cells[0].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "DELETE FROM Marks WHERE m_code = " + m_code; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
                return;
            }
            else
            {
                MessageBox.Show("Дані видалені!", "Успіх!");
                //Видаляємо дані з таблиці в формі
                dataGridView1.Rows.RemoveAt(index);
            }

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string country = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string year = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string circulation = dataGridView1.Rows[index].Cells[4].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "UPDATE Marks SET m_country = '" + country + "', m_cost = " + cost + ", m_year = " + year + ", m_circulation = " + circulation + " WHERE m_code = " + id; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані добавлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсова робота студента групи КБ-20-1\nКовпака Дениса", "Philately Manager");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "SELECT * FROM Marks";//Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //Перевіримо дані
            if(dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдено!", "Помилка!");
                return;
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["m_code"], dbReader["m_country"], dbReader["m_cost"], dbReader["m_year"], dbReader["m_circulation"]);
                }
            }

            //Закриваємо з'єднання
            dbReader.Close();
            dbConnection.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string country = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string year = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string circularity = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string features = dataGridView1.Rows[index].Cells[5].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "INSERT INTO Marks VALUES (" + id + ", '" + country + "', " + cost + ", " + year + ", " + circularity + ", '" + features + "')"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані добавлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "DELETE FROM Marks WHERE id = " + id + ""; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 0)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
            {
                MessageBox.Show("Дані видалені!", "Успіх!");
                //Видаляємо дані з таблиці в формі
                dataGridView1.Rows.RemoveAt(index);
            }

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string country = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string year = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string circularity = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string features = dataGridView1.Rows[index].Cells[5].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "UPDATE Marks SET Id = " + id + ", Country = '" + country + "', Cost = " + cost + ", Year = " + year + ", Circularity = " + circularity + ", Features ='" + features + "'"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані обновлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Marks_Click(object sender, EventArgs e)
        {

        }

        private void actionsBlock_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "SELECT * FROM Owners";//Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //Перевіримо дані
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдено!", "Помилка!");
                return;
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView2.Rows.Add(dbReader["id_code"], dbReader["Surname"], dbReader["Namee"], dbReader["Country"], dbReader["Mark_Code"], dbReader["Mark_count"]);
                }
            }

            //Закриваємо з'єднання
            dbReader.Close();
            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView2.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id_code = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string Surname = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string Namee = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string Country_Owner = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string Mark_Code = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string Mark_Count = dataGridView2.Rows[index].Cells[5].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "INSERT INTO Owners VALUES (" + id_code + ", '" + Surname + "', '" + Namee + "', '" + Country_Owner + "', " + Mark_Code + ", '" + Mark_Count + "')"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані добавлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void deleteDataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView2.SelectedRows[0].Index;

            //Зчитаємо дані
            string id_code = dataGridView2.Rows[index].Cells[0].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "DELETE FROM Owners WHERE id_code =  " + id_code; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
                return;
            }
            else
            {
                MessageBox.Show("Дані видалені!", "Успіх!");
                //Видаляємо дані з таблиці в формі
                dataGridView2.Rows.RemoveAt(index);
            }

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void updateDataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
                return;
            }
            //Запам'ятаємо вибрану строку
            int index = dataGridView2.SelectedRows[0].Index;

            //Перевіримо дані з таблиці
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не всі дані введені!", "Увага!");
                return;
            }

            //Зчитаємо дані
            string id_code = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string Surname = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string Namee = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string Country_Owner = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string Mark_Code = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string Mark_Count = dataGridView2.Rows[index].Cells[5].Value.ToString();

            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "UPDATE Owners SET Surname = '" + Surname + "', Namee = '" + Namee + "', Country = '" + Country_Owner + "', Mark_Code = " + Mark_Code + ", Mark_count = " + Mark_Count + " WHERE id_code = " + id_code; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані добавлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void действиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void clearbtn2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
