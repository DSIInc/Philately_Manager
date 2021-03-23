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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
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
            string query = "DELETE FROM Marks WHERE id = "+ id +""; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть 1 строку!", "Увага!");
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
            string query = "UPDATE Marks SET Id = " + id + ", Country = '" + country + "', Cost = " + cost + ", Year = " + year + ", Circularity = " + circularity + ", Features ='" + features +"'"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Помилка виконання запросу!", "Помилка!");
            else
                MessageBox.Show("Дані обновлені!", "Успіх!");

            //Закриваємо з'єднання
            dbConnection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсова робота студента групи КБ-20-1\n Ковпака Дениса", "Philately Manager");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            //Створюємо з'єднанання
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb"; //строка з'єднання
            OleDbConnection dbConnection = new OleDbConnection(connectionString); //створюємо з'єднання

            //Виконуємо запрос до БД
            dbConnection.Open(); //Відкриваємо з'єднання
            string query = "SELECT * FROM Marks"; //Строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //Перевіримо дані
            if(dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдено!", "Помилка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["m_code"], dbReader["m_country"], dbReader["m_cost"], dbReader["m_year"], dbReader["m_circulation"], dbReader["m_features"]);
                }
            }

            //Закриваємо з'єднання
            dbReader.Close();
            dbConnection.Close();
        }
    }
}
