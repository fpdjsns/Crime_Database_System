using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class monitor_list : Form
    {


        private String strConn;
        private MySqlConnection conn;
        private String a = null;


        public monitor_list(String Si_Name)
        {

            InitializeComponent();
            a = Si_Name;
            MessageBox.Show(Si_Name);
            this.Text = "범죄 정보 시스템";

            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);

            print1_data();
            print2_data();
            print3_data();
        }

        private void monitor_list_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void print1_data()
        {

            //사건 ID, 해결 여부, 사건 내용, 도, 시, 구, 동, 발생 시간, 부서 ID, 범죄 종류, 담당자
            string query = "select Distinct h.h_id as '범죄자 번호', h.h_name as '이름', h.h_tel as '연락처', h.h_address as '거주지', h.h_birthdate as '생년월일', h.h_sex as '성별' FROM human h JOIN criminal cr ON(h.h_id = cr.h_id) WHERE h_address LIKE '" + a + "%';";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    for (int i = 1; i <= 5; i++)
                    {
                        if (reader.IsDBNull(i)) //내용이 NULL값이면
                            lv.SubItems.Add(""); //아무것도 출력안한 값 삽입
                        else //내용이 NULL이 아니면
                            lv.SubItems.Add(reader.GetString(i)); // 해당 값 넣음
                    }
                    listView1.Items.Add(lv); //아이템 리스트 뷰에 추가
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }



        private void print2_data()
        {

            string query = "SELECT count(Distinct h_name) FROM human h JOIN criminal cr ON(h.h_id = cr.h_id) WHERE h_address LIKE '" + a + "%';";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                label1.Text = reader.GetString(0);

                conn.Close();
                reader.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }

        }


        private void print3_data()
        {

            string query = "SELECT count(Distinct h_name) FROM human h JOIN criminal cr ON(h.h_id = cr.h_id) WHERE h_address LIKE '" + a + "%';";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                label2.Text = a + " 범죄자 수 : ";

                conn.Close();
                reader.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            Form1 form1 = new Form1();

            form1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
