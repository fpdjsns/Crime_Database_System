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
    public partial class Form2 : Form
    {
        private string sel_id = null;

        private String strConn;
        private MySqlConnection conn;

        public Form2(string sel_id)
        {
            InitializeComponent();
            this.Text = "사건 상세 정보";
            this.sel_id = sel_id;
            this.webBrowser1.Navigate("map.html"); // google map javascript 파일 불러들이기

            //default = 충북대학교
            string latitude = "36";//위도
            string longitude = "127";//경도
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);

            show_map();
            //데이터 출력
            print_data();

        }
        private void print_data()
        {

            //사건 ID, 해결 여부, 사건 내용, 도, 시, 구, 동, 발생 시간, 부서 ID, 범죄 종류, 담당자
            string query = "SELECT c.c_id, c_isend, c_time, c_arrivaltime, c_do, c_si, c_gu, c_dong, crl_type, c_dept, d_captain, c_content, v_id, s_id, a_id, d_name, p_name "
            + "FROM crime c JOIN department d on c.c_dept=d.d_id LEFT JOIN classify cf on c.c_id=cf.c_id LEFT JOIN crimelist crl on cf.crl_id = crl.crl_id JOIN occur o on c.c_id=o.c_id JOIN pofficer p on p_id=d_captain "
            + "WHERE c.c_id=" + sel_id + ";";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                lc_id.Text = sel_id; //사건 ID
                //해결 여부
                if (reader.GetString(1) == "Y")
                    lc_isend.Text = "해결";
                else
                    lc_isend.Text = "미해결";
                lc_time.Text = reader.GetString(2); //발생 시간
                lc_arrivaltime.Text = reader.GetString(3); //도착 시간

                //도
                if (reader.IsDBNull(4))
                    lc_dosigudong.Text = "";
                else
                    lc_dosigudong.Text = reader.GetString(4) + " ";
                //시
                if (!reader.IsDBNull(5))
                    lc_dosigudong.Text += reader.GetString(5) + "시 ";
                //구
                if (!reader.IsDBNull(6))
                    lc_dosigudong.Text += reader.GetString(6) + "구 ";
                //동
                if (!reader.IsDBNull(7))
                    lc_dosigudong.Text += reader.GetString(7) + "동";

                if (reader.IsDBNull(8))//널 값이면
                {
                    lcrl_type.Text = "없음";
                }
                else
                {
                    lcrl_type.Text = reader.GetString(8);
                }
                if (!reader.IsDBNull(9))
                {
                    ld_name.Text = reader.GetString(15) + " (" + reader.GetString(9) + ")";
                }
                if (!reader.IsDBNull(10))
                {
                    ld_captain.Text = reader.GetString(16) + " (" + reader.GetString(10) + ")";
                }
                if (!reader.IsDBNull(11))
                {
                    lc_content.Text = reader.GetString(11);
                }
                string v_id = null;
                string s_id = null;
                string a_id = null;
                if (!reader.IsDBNull(12))
                    v_id = reader.GetString(12);
                if (!reader.IsDBNull(13))
                    s_id = reader.GetString(13);
                if (!reader.IsDBNull(14))
                    a_id = reader.GetString(14);

                conn.Close();
                reader.Close();

                //피해자
                if (v_id != null)
                {
                    try
                    {
                        string query1 = "SELECT h.h_name "
                        + "FROM victim v JOIN human h on h.h_id=v.h_id "
                        + "WHERE v.v_id=" + v_id + ";";

                        MySqlCommand cmd1 = new MySqlCommand(query1);
                        cmd1.Connection = conn;

                        conn.Open();
                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            while (reader1.Read()) // == this is the Read() method was called
                            {
                                lv_id.Text = reader1.GetString(0) + " (" + v_id + ")";
                            }
                        }
                        conn.Close();
                        reader1.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace);
                    }
                }

                //피의자
                if (s_id != null)
                {
                    try
                    {
                        string query1 = "SELECT h.h_name "
                        + "FROM suspect s JOIN human h on h.h_id=s.h_id "
                        + "WHERE s.s_id =" + s_id + ";";

                        MySqlCommand cmd1 = new MySqlCommand(query1);
                        cmd1.Connection = conn;

                        conn.Open();
                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            while (reader1.Read()) // == this is the Read() method was called
                            {
                                ls_id.Text = reader1.GetString(0) + " (" + s_id + ")";
                            }
                        }
                        conn.Close();
                        reader1.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace);
                    }
                }

                //신고자
                if (a_id != null)
                {
                    try
                    {
                        string query1 = "SELECT h.h_name "
                                + "FROM applicant a JOIN human h on h.h_id=a.h_id "
                                + "WHERE a.a_id =" + a_id + ";";

                        MySqlCommand cmd1 = new MySqlCommand(query1);
                        cmd1.Connection = conn;

                        conn.Open();
                        MySqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.HasRows)
                        {
                            while (reader1.Read()) // == this is the Read() method was called
                            {
                                la_id.Text = reader1.GetString(0) + " (" + a_id + ")";
                            }
                        }
                        conn.Close();
                        reader1.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }

            conn.Close();
        }
        // 지도 보여주기
        private void show_map()
        {
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://maps.google.com/maps?q=");      // 구글 맵 주소
            String query_showMap = "SELECT c.c_lg, c.c_la from crime c WHERE c.c_id = " + sel_id;  
            String lg = null;         // 경도
            String la = null;         // 위도

            MySqlCommand cmd = new MySqlCommand(query_showMap, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    lg = reader["c_lg"].ToString();     // 경도 값 읽어오기
                    la = reader["c_la"].ToString();     // 위도 값 읽어오기
                }
                if (lg != null && la != null)
                {
                    queryaddress.Append(lg + "," + la);     // 경도랑 위도랑 원래 반대임. la,lg로 검색해야하는데 우린 데이터를 잘못넣었다.
                    webBrowser1.Navigate(queryaddress.ToString());      //웹에 쿼리 날린다.
                }
                else
                {
                    throw new Exception("위치를 찾을 수 없습니다.");      //에러 표시
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

            conn.Close();
            reader.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
