using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class guestForm : Form
    {
        string strCon = "";
        Thread thread;
        private string tableName;
        DataSet ds;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;

        public guestForm()
        {
            InitializeComponent();
        }

        private void btn_guest_Click(object sender, EventArgs e)
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
                string query = rtb_guest.Text;
                string tableName = getTableName(query);
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(ds, tableName);
                dgv_guest.DataSource = ds;
                dgv_guest.DataMember = tableName;
                lbl_hint_guest.Text = "Запрос выполнен успешно ^`>*<`^";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                if(tableName == null)
                {
                    lbl_hint_guest.Text = "Данная операция недоступна!";
                } else
                {
                    Console.WriteLine(ex.Message);
                    lbl_hint_guest.Text = "Кажется вы неправильно ввели данные...\n" +
                        "Будьте внимательнее :)";
                }
                
            }


        }

        private string getTableName(string query)
        {
            string[] tmpArray = query.Split(' ');
            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (tmpArray[i].Contains("insert") | tmpArray[i].Contains("INSERT")
                    | tmpArray[i].Contains("update") | tmpArray[i].Contains("UPDATE")
                    | tmpArray[i].Contains("create") | tmpArray[i].Contains("CREATE"))
                {
                    tableName = null;
                    return tableName;
                }
                
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
                lbl_hint_guest.Text = "Введите:\n1) название таблицы";
                rtb_guest.Text = "select * from _1_";
            }
            else
            {
                lbl_hint_guest.Text = "";
                rtb_guest.Text = "";
            }
        }

        private void chb_2_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_2.Checked == true)
            {
                lbl_hint_guest.Text = "Введите:\n1) название столбцов через запятую\n2) название таблицы\n3) условие(я)";
                rtb_guest.Text = "select _1_ from _2_ where _3_";
            }
            else
            {
                lbl_hint_guest.Text = "";
                rtb_guest.Text = "";
            }
        }

        private void chb_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_3.Checked == true)
            {
                lbl_hint_guest.Text = "Введите:\n1) группирующее поле\n2) групповую операцию\n3) название нового столбца\n" +
                        "4) название таблицы";
                rtb_guest.Text = "select _1_, _2_ as _3_ from _4_ group by _1_";
            }
            else
            {
                lbl_hint_guest.Text = "";
                rtb_guest.Text = "";
            }
        }

        private void btn_reSignIn_Click(object sender, EventArgs e)
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
                string str = tb_guest_database.Text;
                strCon = @"Server=localhost;Database=" + str + ";Trusted_Connection=True;";
                return strCon;
            } catch
            {
                return null;
            }
        }

        private void guestForm_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }
    }
}
