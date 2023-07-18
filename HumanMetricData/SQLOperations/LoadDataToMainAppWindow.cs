using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using HumanMetricData.Windows;
using HumanMetricData.SQLOperations;

namespace HumanMetricData.SQLOperations
{
    public class LoadDataToMainAppWindow 
    {
        public bool openApp = false;
        string UserName { get; set; }
        string Password { get; set; }

        public LoadDataToMainAppWindow()
        {
            
        }

        /*    public void LoadDataApp(string userName, string userPassword)
            {
                UserName = userName;
                Password = Password;
                string query = @"select roles.*, users.* from roles, users where login = '" + UserName + "' and pasword = '" + Password + "' and users.id_role = roles.id";
                try
                {
                    OpenConnection();
                    SqlCommand cmd = new SqlCommand(query, _sqlConnection);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    int count = 0;
                    while (dr.Read()) { count += 1; }
                    if (count == 1)
                    {

                        MainAppWindow mdb = new MainAppWindow();
                        dr.Close();
                        openApp = true;
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                       /* mdb.textBox28.DataBindings.Add("Text", dt, "vnadd");
                        mdb.textBox29.DataBindings.Add("Text", dt, "vnupdt");
                        mdb.textBox30.DataBindings.Add("Text", dt, "vndel");
                        mdb.textBox31.DataBindings.Add("Text", dt, "vnrep");
                        mdb.textBox32.DataBindings.Add("Text", dt, "kradd");

                        mdb.textBox33.DataBindings.Add("Text", dt, "krupdt");
                        mdb.textBox34.DataBindings.Add("Text", dt, "krdel");
                        mdb.textBox35.DataBindings.Add("Text", dt, "krrep");
                        mdb.textBox36.DataBindings.Add("Text", dt, "otpadd");
                        mdb.textBox37.DataBindings.Add("Text", dt, "otpupdt");
                        mdb.textBox38.DataBindings.Add("Text", dt, "otpdel");
                        mdb.textBox39.DataBindings.Add("Text", dt, "otprep");
                    }

                    else if (count > 0) { MessageBox.Show("Dublicate login and password"); }
                    else { MessageBox.Show("Логин или пароль введены не правильно!"); }
                     textBox1.Clear();
                    textBox2.Clear();


                    else { MessageBox.Show("Подключение к базе данных не установленно. Причины, по которым нет установления с базой данных: \n - не указан путь к файлу базы дынных; \n - проблемы с подключением к серверу с базой данных, возмомжны неполадки с сетью; \n - файл базы данных был удален. \n Для устранения неполадки с подключением к базе данных войдите в администраторскую часть и укажите путь к файлу базы данных или обратитесь к Администратору.", "Внимание!!! Подключение к базе данных не установленно!!!"); }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/

    }
}
