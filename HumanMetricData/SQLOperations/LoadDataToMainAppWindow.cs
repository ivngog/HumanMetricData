using System;
using System.Collections.Generic;
using System.Text;

namespace HumanMetricData.SQLOperations
{
    public class LoadDataToMainAppWindow
    {
        public void LoadDataApp()
        {
           /* string constr = Properties.Settings.Default.Podkliuchenie;
            try
            {
                if (Properties.Settings.Default.Podkliuchenie != string.Empty && Properties.Settings.Default.Stroka_podcliuchenia != string.Empty)
                {
                    SqlConnection con = new SqlConnection(@"" + Properties.Settings.Default.Stroka_podcliuchenia + Properties.Settings.Default.Podkliuchenie + "");

                    con.Open();
                    if (con.State == ConnectionState.Closed) { MessageBox.Show("Подключение отсутствует!", "Ошибка"); }
                    else if (con.State == ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("select roles.*, users.* from roles, users where login = '" + textBox1.Text + "' and pasword = '" + textBox2.Text + "' and users.id_role = roles.id", con);
                        SqlDataReader dr;
                        if (textBox1.Text != string.Empty & textBox2.Text != string.Empty)
                        {
                            dr = cmd.ExecuteReader();
                            {
                                {
                                    int count = 0;
                                    while (dr.Read()) { count += 1; }
                                    if (count == 1)
                                    {
                                        MyDB mdb = new MyDB();
                                        dr.Close();
                                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                        DataTable dt = new DataTable();
                                        sda.Fill(dt);
                                        mdb.textBox28.DataBindings.Add("Text", dt, "vnadd");
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

                                        mdb.Show();
                                        this.Hide();
                                    }

                                    else if (count > 0) { MessageBox.Show("Dublicate login and password"); }
                                    else { MessageBox.Show("Логин или пароль введены не правильно!"); }
                                    // textBox1.Clear();
                                    textBox2.Clear();
                                }
                            }
                        }
                        else { MessageBox.Show("Не все поля заполнены"); }

                    }
                }
                else { MessageBox.Show("Подключение к базе данных не установленно. Причины, по которым нет установления с базой данных: \n - не указан путь к файлу базы дынных; \n - проблемы с подключением к серверу с базой данных, возмомжны неполадки с сетью; \n - файл базы данных был удален. \n Для устранения неполадки с подключением к базе данных войдите в администраторскую часть и укажите путь к файлу базы данных или обратитесь к Администратору.", "Внимание!!! Подключение к базе данных не установленно!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }*/
        }

    }
}
