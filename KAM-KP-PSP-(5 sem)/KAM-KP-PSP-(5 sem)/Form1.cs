﻿using KAM_KP_PSP__ClassLibrary_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAM_KP_PSP__5_sem_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            timer3.Start();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        /// <summary>
        /// Info about Storages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                bool success = false;
               
                List<string> list = new List<string>() { Bank.AccessInDB };
                string ANSWER = "";
                Client.SendMessage("StorageInfo", list, ref success, ref ANSWER);

                string[] Mass0 = ANSWER.Split(new char[] { '#' });
                MessageBox.Show(Mass0[0]);

                string S = Mass0[1];

                string[] Mass = S.Split(new char[] { '%' });


                string[][] MASS = new string[Mass.Length][];

                for (int i = 0; i < Mass.Length; i++)
                {
                    MASS[i] = Mass[i].Split(new char[] { '|' });
                }

                foreach (string[] s in MASS)
                {
                    dataGridView1.Rows.Add(s);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        /// <summary>
        /// Info About Accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                bool success = false;

                List<string> list = new List<string>() { Bank.AccessInDB, Bank.IdOfCurrentStorage.ToString() };
                string ANSWER = "";
                Client.SendMessage("AccountInfo", list, ref success, ref ANSWER);

                string[] Mass0 = ANSWER.Split(new char[] { '#' });
                MessageBox.Show(Mass0[0]);

                string S = Mass0[1];

                string[] Mass = S.Split(new char[] { '%' });


                string[][] MASS = new string[Mass.Length][];

                for (int i = 0; i < Mass.Length; i++)
                {
                    MASS[i] = Mass[i].Split(new char[] { '|' });
                }

                foreach (string[] s in MASS)
                {
                    dataGridView2.Rows.Add(s);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //// обновление данных таблиц
            //Account.Info(dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //// добавление суммы на счёт
            //Account.AddGetMoney(textBox2.Text, textBox4.Text, "+", Bank.IdOfCurrentStorage);

            //// обновление данных таблиц
            //Account.Info(dataGridView2);

            ////
            //// Внесение события в таблицу
            //Event ev1 = new Event(button3.Text, "Финансовое", $"Пополнение счёта \"{textBox2.Text}\" на {textBox4.Text} единиц");
            //ev1.AddEventInDB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //// изъятие суммы со счёта
            //Account.AddGetMoney(textBox2.Text, textBox4.Text, "-", Bank.IdOfCurrentStorage);

            //// обновление данных таблиц
            //Account.Info(dataGridView2);

            ////
            //// Внесение события в таблицу
            //Event ev1 = new Event(button3.Text, "Финансовое", $"Изъятие со счёта \"{textBox2.Text}\" на {textBox4.Text} единиц");
            //ev1.AddEventInDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //// Переместить сумму1 со счёта1 на счёт2
            //Account.ReplaceMoney(textBox2.Text, textBox3.Text, textBox4.Text);

            //// обновление данных таблиц
            //Account.Info(dataGridView2);

            ////
            //// Внесение события в таблицу
            //Event ev1 = new Event(button5.Text, "Финансовое", $"Перемещение со счёта \"{textBox2.Text}\" на счёт \"{textBox3.Text}\" {textBox4.Text} единиц");
            //ev1.AddEventInDB();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //// конвертирование денег счёта, если счет валютный
            //Account.ChangeCurrency(textBox2.Text, comboBox1.Text);

            //// обновление данных таблиц
            //Account.Info(dataGridView2);

            ////
            //// Внесение события в таблицу
            //Event ev1 = new Event(button9.Text, "Не финансовое", $"Конвертация счёта \"{textBox2.Text}\" в валюту {comboBox1.Text}");
            //ev1.AddEventInDB();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    label2.Text = $"Информация о счетах хранилища \"{Bank.NameOfStorage}\" : ";
            //    Storage.CalculateAmountOfAccount();
            //    Storage.CalculateTotalSumAndAmount();
            //    Account.CalcDaysLeftDeposit();
            //}
            //catch
            //{

            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Account.CheckDeposit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //// Показываются события, которые являются финансовыми
            //Event.FinancialInfo(dataGridView3, "=", "Финансовое");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //// Показываются события, которые не являются финансовыми
            //Event.FinancialInfo(dataGridView3, "!=", "Финансовое");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //// Показываются события всех типов 
            //Event.Info(dataGridView3);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
