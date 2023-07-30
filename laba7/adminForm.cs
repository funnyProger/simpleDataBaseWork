using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace laba7
{
    public partial class adminForm : Form
    {
        string strCon = "";
        Thread thread;
        private string tableName;
        DataSet ds;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;

        public adminForm()
        {
            InitializeComponent();
        }

        

        private void btn_main_Click(object sender, EventArgs e)
        {

            ds.Clear();
            try
            {
                sqlConnection = new SqlConnection(getConnectionString());
            }
            catch
            {
                MessageBox.Show("Введите имя базы данных");
            }
            sqlConnection.Open();

            

            try
            { 
                string query = rtb_admin.Text;
                string tableName = getTableName(query);
                adapter = new SqlDataAdapter(query, sqlConnection); 
                adapter.Fill(ds, tableName);
                dgv_admin.DataSource = ds;
                dgv_admin.DataMember = tableName;
                lbl_hint.Text = "Запрос выполнен успешно ^`>*<`^";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lbl_hint.Text = "Кажется вы неправильно ввели данные...\n" +
                    "Будьте внимательнее :)";
            }
            

        }

        private string getTableName(string query)
        {
            string[] tmpArray = query.Split(' ');
            for(int i  = 0; i < tmpArray.Length; i++)
            {
                if (tmpArray[i].Contains("parks") | tmpArray[i].Contains("church"))
                {
                    tableName = tmpArray[i];
                }

            }
            return tableName;
        }


        private void chb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_1.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) название таблицы";
                rtb_admin.Text = "select * from _1_";
            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void chb_2_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_2.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) название столбцов через запятую\n2) название таблицы\n3) условие(я)";
                rtb_admin.Text = "select _1_ from _2_ where _3_";
            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void chb_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_3.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) группирующее поле\n2) групповую операцию\n3) название нового столбца\n" +
                        "4) название таблицы";
                rtb_admin.Text = "select _1_, _2_ as _3_ from _4_ group by _1_";
            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void chb_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_4.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) название таблицы и ее характеристики";
                rtb_admin.Text = "create table _1_";
                lbl_hint.Text = "Запрос выполнен успешно ^`>*<`^";
            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void chb_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_5.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) название таблицы\n2) название(я) столбца(ов)\n3) уловие(я)";
                rtb_admin.Text = "update _1_ set _2_ where _3_";
                lbl_hint.Text = "Запрос выполнен успешно ^`>*<`^";

            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void chb_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_6.Checked == true)
            {
                lbl_hint.Text = "Введите:\n1) название таблицы (столбец_1, столбец_2, столбец 3...)\n" +
                    "2) значения для каждого столбца через запятую";
                rtb_admin.Text = "insert into _1_ values (_2_)";
                lbl_hint.Text = "Запрос выполнен успешно ^`>*<`^";

            }
            else
            {
                lbl_hint.Text = "";
                rtb_admin.Text = "";
            }
        }

        private void btn_resignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(appRunSignInWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void appRunSignInWindow(object sender)
        {
            Application.Run(new signInWindow());
        }

        

        private string getConnectionString()
        {
            try
            {
                string str = tb_admin_database.Text;
                strCon = @"Server=localhost;Database=" + str + ";Trusted_Connection=True;";
                return strCon;
            }
            catch
            {
                return null;
            }
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }
    }
}
