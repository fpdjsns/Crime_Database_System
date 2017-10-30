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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private String strConn;
        private String connStr = "Server=localhost;Database=crimedata;Uid=root;Pwd=admin;";//서버: localhost, DB 이름: crimedata, ID = root, PW = admin

        private MySqlConnection conn;
        String[] yearitem = { "","2010", "2011", "2012", "2013", "2014", "2015", "2016" };
        String[] monthitem = { "","1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        String[] dayitem = { "","월","화","수","목","금","토","일" };
        CheckBox[] search_check = null;
        TextBox[] search_text = null;
        ComboBox[] search_combo = null;
        String[] itemname = null;
       
        //string[] tsearch = { "tc_id", "cc_isend", "tc_content", "tc_do", "tc_si", "tc_gu", "tc_dong", "tc_time", "cd_name", "td_name", "tcrl_type", "td_captain" };
        public Form1()
        {
            InitializeComponent();
            this.Text = "범죄 정보 시스템";
       
            search_check = new CheckBox[] { rc_id, rc_isend, rc_content, rc_dosigudong, rc_time, rd_name, rcrl_type, rd_captain };//라디오박스 순서
            search_text = new TextBox[] { tc_id, null, tc_content, tc_do, null, td_name, tcrl_type, td_captain };//라디오박스 순서
            search_combo = new ComboBox[] { null, cc_isend, null, null, null, cd_name, null, cd_captain };//라디오박스 순서
            itemname = new String[] { "c.c_id", "c_isend", "c_content", null, "c_time", "c_dept", "crl_type", "d_captain"};

            year_comboBox.Items.AddRange(yearitem);
            month_comboBox.Items.AddRange(monthitem);
            day_comboBox.Items.AddRange(dayitem);
            cc_isend.SelectedIndex = 0; //해결여부 인덱스 초기화
            cd_name.SelectedIndex = 0; //부서 인덱스 초기화
            cd_captain.SelectedIndex = 0; //담당자 인덱스 초기화
            comboBox2.SelectedIndex = 0; //범죄종류 검색 콤보박스 인덱스 초기화

            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);

            //ListView 출력 함수 호출
            print1_data();
            print2_data();

            crime_initailize();
        
             
            comboBox3.Items.Add("경기도");
            comboBox3.Items.Add("서울특별시");
            comboBox3.Items.Add("인천광역시");
            comboBox3.Items.Add("충청북도");
            comboBox3.Items.Add("대전광역시");
            comboBox3.Items.Add("전라북도");
            comboBox3.Items.Add("충청남도");
            comboBox3.Items.Add("광주광역시");
            comboBox3.Items.Add("전라남도");
            comboBox3.Items.Add("경상남도");
            comboBox3.Items.Add("대구광역시");
            comboBox3.Items.Add("울산광역시");
            comboBox3.Items.Add("부산광역시");
            comboBox3.Items.Add("경상북도");
            comboBox3.Items.Add("제주도");
            comboBox3.Items.Add("강원도");
           
          
        }

        private void crime_initailize()
        {

            //검색 조건 모두 false
            tc_id.Enabled = false;
            cc_isend.Enabled = false;
            tc_content.Enabled = false;
            tc_do.Enabled = false;
            tc_si.Enabled = false;
            tc_gu.Enabled = false;
            tc_dong.Enabled = false;
            cd_name.Enabled = false;
            td_name.Enabled = false;
            tcrl_type.Enabled = false;
            td_captain.Enabled = false;
            cd_captain.Enabled = false;

            dc_time1.Enabled = false;
            dc_time2.Enabled = false;
        }

        //===== 콤보 박스 이벤트 등록 ======

        //사건 ID 콤보 박스
        private void rc_id_CheckedChanged(object sender, EventArgs e)
        {
            if (rc_id.Checked)//체크 되었으면
                tc_id.Enabled = true;//사용 가능하게 변경
            else//체크 안되었으면
                tc_id.Enabled = false;
        }

        //해결 여부 콤보 박스
        private void rc_isend_CheckedChanged(object sender, EventArgs e)
        {
            if (rc_isend.Checked)//체크 되었으면
                cc_isend.Enabled = true;//사용 가능하게 변경
            else//체크 안되었으면
                cc_isend.Enabled = false;
        }

        //사건 내용 콤보 박스
        private void rc_content_CheckedChanged(object sender, EventArgs e)
        {
            if (rc_content.Checked)//체크 되었으면
                tc_content.Enabled = true;//사용 가능하게 변경
            else//체크 안되었으면
                tc_content.Enabled = false;
        }

        //장소 콤보 박스
        private void rc_dosigudong_CheckedChanged(object sender, EventArgs e)
        {
            if (rc_dosigudong.Checked)//체크 되었으면
            {
                //사용 가능하게 변경
                tc_do.Enabled = true;
                tc_si.Enabled = true;
                tc_gu.Enabled = true;
                tc_dong.Enabled = true;
            }
            else//체크 안되었으면
            {
                tc_do.Enabled = false;
                tc_si.Enabled = false;
                tc_gu.Enabled = false;
                tc_dong.Enabled = false;
            }
        }

        //발생 날짜 콤보 박스
        private void rc_time_CheckedChanged(object sender, EventArgs e)
        {
            if (rc_time.Checked)//체크 되었으면
            {
                dc_time1.Enabled = true;//사용 가능하게 변경
                dc_time2.Enabled = true;//사용 가능하게 변경
            }
            else//체크 안되었으면
            {
                dc_time1.Enabled = false;
                dc_time2.Enabled = false;
            }
        }

        //부서 콤보 박스
        private void rd_name_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_name.Checked)//체크 되었으면
            {
                //사용 가능하게 변경
                cd_name.Enabled = true;
                td_name.Enabled = true;
            }
            else//체크 안되었으면
            {
                cd_name.Enabled = false;
                td_name.Enabled = false;
            }
        }

        //범죄 종류 콤보 박스
        private void rcrl_type_CheckedChanged(object sender, EventArgs e)
        {
            if (rcrl_type.Checked)//체크 되었으면
                tcrl_type.Enabled = true;//사용 가능하게 변경
            else//체크 안되었으면
                tcrl_type.Enabled = false;
        }

        //담당자 콤보 박스
        private void rd_captain_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_captain.Checked)//체크 되었으면
            {
                cd_captain.Enabled = true;
                td_captain.Enabled = true;//사용 가능하게 변경
            }
            else//체크 안되었으면
            {
                cd_captain.Enabled = false;
                td_captain.Enabled = false;
            }
        }

        //===============================

        private void CheckEnter1(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //엔터 눌렀을 때
            if (e.KeyChar == (char)13)
            {
                button1_click();
            }
        }

        private void CheckEnter2(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //엔터 눌렀을 때
            if (e.KeyChar == (char)13)
            {
                button2_click();
            }
        }

        //사건 ListView 출력
        private void print1_data()
        {

            //사건 ID, 해결 여부, 사건 내용, 도, 시, 구, 동, 발생 시간, 부서 ID, 범죄 종류, 담당자
            string query = "SELECT c.c_id, c_isend, c_content, c_do, c_si, c_gu, c_dong, c_time, c_dept, d_name, crl_type, d_captain, p_name "
            + "FROM crime c JOIN department d on c.c_dept=d.d_id LEFT JOIN classify cf on c.c_id=cf.c_id LEFT JOIN crimelist crl on cf.crl_id = crl.crl_id JOIN pofficer p on d_captain = p.p_id "
            + "ORDER BY c.c_id;";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                listView1.Items.Clear();//아이템 클리어

                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == 8 || i == 11)
                        {
                            if (reader.IsDBNull(i)) //내용이 NULL값이면
                                lv.SubItems.Add(""); //아무것도 출력안한 값 삽입
                            else //내용이 NULL이 아니면
                            {
                                lv.SubItems.Add(reader.GetString(i + 1) + "(" + reader.GetString(i) + ")"); // 해당 값 넣음
                            }
                            i++;
                        }
                        else
                        {
                            if (reader.IsDBNull(i)) //내용이 NULL값이면
                                lv.SubItems.Add(""); //아무것도 출력안한 값 삽입
                            else //내용이 NULL이 아니면
                                lv.SubItems.Add(reader.GetString(i)); // 해당 값 넣음
                        }
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

        //범죄 종류 listView 출력
        private void print2_data()
        {

            //사건 ID, 해결 여부, 사건 내용, 도, 시, 구, 동, 발생 시간, 부서 ID, 범죄 종류, 담당자
            string query = "SELECT * FROM crimelist;";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                listView2.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0)); //범죄 종류 ID
                    lv.SubItems.Add(reader.GetString(1)); // 범죄 이름
                    lv.SubItems.Add(reader.GetString(4)); // 설명 넣음
                    lv.SubItems.Add(reader.GetString(2)); // 징역 넣음
                    lv.SubItems.Add(reader.GetString(3)); // 벌금 넣음

                    listView2.Items.Add(lv); //아이템 리스트 뷰에 추가
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            conn.Close();
        }

        //상세보기 클릭
        private void button2_Click(object sender, EventArgs e)
        {
            button2_click();
        }

        //상세보기 클릭시 호출하는 함수
        private void button2_click()
        {
            //if(데이터가 선택되었을 때
            if (listView1.SelectedItems.Count != 0)
            {
                Form2 f2 = new Form2(listView1.SelectedItems[0].SubItems[0].Text);//사건 ID를 넘겨줌
                f2.Show();
            }
        }

        //전체보기 클릭 시
        private void button4_Click(object sender, EventArgs e)
        {
            print1_data();
        }

        //검색 클릭시
        private void button5_Click(object sender, EventArgs e)
        {
            button1_click();
        }
        //사건 검색 클릭시 호출하는 함수
        private void button1_click()
        {

            bool Isprint = true;
            string query = "SELECT c.c_id, c_isend, c_content, c_do, c_si, c_gu, c_dong, c_time, c_dept, d_name, crl_type, d_captain, p_name "
                    + "FROM crime c JOIN department d on c.c_dept=d.d_id LEFT JOIN classify cf on c.c_id=cf.c_id LEFT JOIN crimelist crl on cf.crl_id = crl.crl_id JOIN pofficer p on d_captain = p.p_id "
                    + "WHERE";
            string plus_query = ""; //쿼리 뒤에 추가될 쿼리


            for (int i = 0; i < search_check.Length; i++)
            {
                bool s_Isprint = true;//조건 추가되는 경우 false

                //체크 박스가 선택되어있다면 -> 검색 조건이면 
                if (search_check[i].Checked)
                {
                    plus_query = "";//추가될 쿼리 초기화
                    //텍스트 박스가 존재할 때
                    if (search_text[i] != null)
                    {
                        //만약 장소를 의미한다면 -> 예외 처리(텍스트 박스 4개이므로)
                        if (search_text[i] == tc_do)
                        {
                            if (tc_do.Text != "")
                            {
                                plus_query += " c.c_do like '%" + tc_do.Text + "도%'";
                                s_Isprint = false;
                            }
                            if (tc_si.Text != "")
                            {
                                if (!s_Isprint)
                                    plus_query += " and";
                                plus_query += " c.c_si like '%" + tc_si.Text + "%'";
                                s_Isprint = false;
                            }
                            if (tc_gu.Text != "")
                            {
                                if (!s_Isprint)
                                    plus_query += " and";
                                plus_query += " c.c_gu like '%" + tc_gu.Text + "%'";
                                s_Isprint = false;
                            }
                            if (tc_dong.Text != "")
                            {
                                if (!s_Isprint)
                                    plus_query += " and";
                                plus_query += " c.c_dong like '%" + tc_dong.Text + "%'";
                                s_Isprint = false;
                            }
                        }
                        else if (search_text[i].Text != null)//텍스트 박스에 내용이 있다면
                        {
                            if (search_text[i].Text != "")
                            {
                                if (itemname[i].Equals("c.c_id"))//사건 ID
                                    plus_query += " " + itemname[i].ToString() + " = " + search_text[i].Text;
                                else if (itemname[i].Equals("c_content"))//사건 내용
                                    plus_query += " " + itemname[i].ToString() + " like '%" + search_text[i].Text + "%'";
                                //else if (itemname[i].Equals("c_time"))//발생 시간
                                //    plus_query += " " + itemname[i].ToString() + " like '%" + search_text[i].Text + "%'";
                                else if (itemname[i].Equals("c_dept"))//범죄 종류
                                {
                                    if (search_combo[i].SelectedIndex == 0)//부서 ID로 검색 시
                                        plus_query += " c_dept = " + search_text[i].Text;
                                    else if (search_combo[i].SelectedIndex == 1)//부서 이름으로 검색 시
                                        plus_query += " d_name like '" + search_text[i].Text + "'";
                                }
                                else if (itemname[i].Equals("crl_type"))//범죄 종류
                                    plus_query += " " + itemname[i].ToString() + " like '" + search_text[i].Text + "'";
                                else if (itemname[i].Equals("d_captain"))//담당자
                                {
                                    if (search_combo[i].SelectedIndex == 0)//ID로 검색 시
                                        plus_query += " d_captain = " + search_text[i].Text;
                                    else if (search_combo[i].SelectedIndex == 1)//이름으로 검색 시
                                        plus_query += " p_name like '" + search_text[i].Text + "'";
                                }
                                s_Isprint = false;
                            }
                        }
                    }
                    else
                    {
                        if (itemname[i].Equals("c_isend"))//해결 여부
                        {
                            if (search_combo[i].SelectedIndex == 0)//해결
                                plus_query += " c_isend = 'Y'";
                            else//미해결
                                plus_query += " c_isend = 'N'";
                        }
                        else if (itemname[i].Equals("c_time"))//발생 날짜
                        {
                            plus_query += " DATE_FORMAT(c_time,'%Y-%m-%d') between '" + dc_time1.Value.ToShortDateString() + "' and '" + dc_time2.Value.ToShortDateString() + "'";
                            //plus_query += " c_captain BETWEEN " + dc_time1.;
                        }
                        s_Isprint = false;
                    }
                }

                //조건 추가되는 경우
                if (!s_Isprint)
                {
                    //조건 추가 시 처음 나오는 경우 -> and 필요 없음
                    if (Isprint)
                    {
                        Isprint = false;//조건 추가가 처음이 아니라고 바꿔줌
                        query += plus_query;
                    }
                    else//and 필요
                    {
                        query += " and";
                        query += plus_query;
                    }
                }
            }

            try
            {
                if (!Isprint)
                {
                    query += " ORDER BY c.c_id;";

                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = conn;

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader.GetString(0));
                        for (int i = 1; i <= 12; i++)
                        {
                            if (i == 8 || i == 11)
                            {
                                if (reader.IsDBNull(i)) //내용이 NULL값이면
                                    lv.SubItems.Add(""); //아무것도 출력안한 값 삽입
                                else //내용이 NULL이 아니면
                                {
                                    lv.SubItems.Add(reader.GetString(i + 1) + "(" + reader.GetString(i) + ")"); // 해당 값 넣음
                                }
                                i++;
                            }
                            else
                            {
                                if (reader.IsDBNull(i)) //내용이 NULL값이면
                                    lv.SubItems.Add(""); //아무것도 출력안한 값 삽입
                                else //내용이 NULL이 아니면
                                    lv.SubItems.Add(reader.GetString(i)); // 해당 값 넣음
                            }
                        }
                        listView1.Items.Add(lv); //아이템 리스트 뷰에 추가
                    }
                    conn.Close();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
            conn.Close();

        }

        //범죄종류 검색 클릭 시
        private void button3_Click(object sender, EventArgs e)
        {
            bool Isprint = true;
            string query = null;

            switch (comboBox2.SelectedIndex)
            {
                //범죄 ID
                case 0: query = "SELECT * FROM crimelist "
                    + "WHERE crl_id = " + textBox2.Text;
                    break;
                //범죄 이름
                case 1: query = "SELECT * FROM crimelist "
                    + "WHERE crl_type like '%" + textBox2.Text + "%'";
                    break;
                //설명
                case 2: query = "SELECT * FROM crimelist "
                    + "WHERE crl_content like '%" + textBox2.Text + "%'";
                    break;
                //징역
                case 3: query = "SELECT * FROM crimelist "
                    + "WHERE crl_penalty = " + textBox2.Text;
                    break;
                //벌금
                case 4: query = "SELECT * FROM crimelist "
                    + "WHERE crl_fine = " + textBox2.Text;
                    break;
                default: Isprint = false; break;
            }
            try
            {
                if (Isprint)
                {
                    query += " ORDER BY crl_id;";

                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = conn;

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView2.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader.GetString(0)); //범죄 종류 ID
                        lv.SubItems.Add(reader.GetString(1)); // 범죄 이름
                        lv.SubItems.Add(reader.GetString(4)); // 설명 넣음
                        lv.SubItems.Add(reader.GetString(2)); // 징역 넣음
                        lv.SubItems.Add(reader.GetString(3)); // 벌금 넣음

                        listView2.Items.Add(lv); //아이템 리스트 뷰에 추가
                    }
                    conn.Close();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
            conn.Close();

        }

        //범죄 종류 전체보기 클릭시
        private void button1_Click_1(object sender, EventArgs e)
        {
            print2_data();
        }
        //=============================================================================


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox3.SelectedIndex)
            {
                case 0: //경기도
                    {

                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        경기도 경기도 = new 경기도(Do_Name); // 새로운 폼 선언
                        경기도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 1: //서울특별시
                    {

                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        서울특별시 서울 = new 서울특별시(Do_Name);
                        서울.ShowDialog();
                        break;
                    }

                case 2: //인천광역시 
                    {

                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        인천광역시 인천광역시 = new 인천광역시(Do_Name);
                        인천광역시.ShowDialog();
                        break;
                    }

                case 3:
                    {

                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();


                        this.Visible = false; //현재 창 사라지게 하는 것
                        충청북도 충청북도 = new 충청북도(Do_Name); // 새로운 폼 선언
                        충청북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 4:
                    {

                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        대전광역시 대전광역시 = new 대전광역시(Do_Name); // 새로운 폼 선언
                        대전광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 5:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        전라북도 전라북도 = new 전라북도(Do_Name); // 새로운 폼 선언
                        전라북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 6:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        충청남도 충청남도 = new 충청남도(Do_Name); // 새로운 폼 선언
                        충청남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 7:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        광주광역시 광주광역시 = new 광주광역시(Do_Name); // 새로운 폼 선언
                        광주광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 8:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        전라남도 전라남도 = new 전라남도(Do_Name); // 새로운 폼 선언
                        전라남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 9:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        경상남도 경상남도 = new 경상남도(Do_Name); // 새로운 폼 선언
                        경상남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 10:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());


                        String Do_Name = selectedItem.ToString();
                        this.Visible = false; //현재 창 사라지게 하는 것
                        대구광역시 대구광역시 = new 대구광역시(Do_Name); // 새로운 폼 선언
                        대구광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 11:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        울산광역시 울산광역시 = new 울산광역시(Do_Name); // 새로운 폼 선언
                        울산광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 12:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        부산광역시 부산광역시 = new 부산광역시(Do_Name); // 새로운 폼 선언
                        부산광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 13:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        경상북도 경상북도 = new 경상북도(Do_Name); // 새로운 폼 선언
                        경상북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 14:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        제주도 제주도 = new 제주도(Do_Name); // 새로운 폼 선언
                        제주도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 15:
                    {
                        int selectedIndex = comboBox3.SelectedIndex;
                        Object selectedItem = comboBox3.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        강원도 강원도 = new 강원도(Do_Name); // 새로운 폼 선언
                        강원도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        // 기간별 범죄자 수 출력
        void setChart_time()
        {

            chart1.Series.Clear();              // 차트 초기화
            Series time;                        
            int[] yValues = new int[24];        // Y값
            string[] xValues = new string[24];  // X값
            int xValues_size = 0;               // X항목 갯수
            string unitOftime = null;           // 기간 단위

            for (int i = 0; i < 24; i++)        // Y값 초기화
                yValues[i] = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = null;
                string condition = "where ";        // 조건 절 생성


                // 연별
                if (year_comboBox.SelectedIndex <= 0 && month_comboBox.SelectedIndex <= 0 && day_comboBox.SelectedIndex <= 0)
                {
                    sql = "SELECT YEAR(c_time) as year, count(*) as crimenum from crime group by YEAR(c_time)";
                    condition = "";
                    unitOftime = "YEAR";        
                    for (int i = 1; i < yearitem.Length; i++)   // X축 :2010 ~ 2016
                        xValues[i-1] = yearitem[i];
                    xValues_size = 7;
                }

                if (year_comboBox.SelectedIndex > 0)    // 월별
                {
                    condition += "YEAR(c_time) = " + year_comboBox.SelectedItem.ToString() + " and ";
                    unitOftime = "MONTH";
                    for (int i = 1; i < monthitem.Length; i++)  // X축 :1 ~ 12
                        xValues[i - 1] = monthitem[i];
                    xValues_size = 12;
                }
                if (month_comboBox.SelectedIndex > 0)    // 요일별
                {
                    condition += "MONTH(c_time) = " + month_comboBox.SelectedItem.ToString() + " and ";
                    unitOftime = "DAYOFWEEK";
                    for (int i = 1; i < dayitem.Length; i++)    // X축 :월 - 금
                        xValues[i - 1] = dayitem[i];
                    xValues_size = 7;                           
                }
                if (day_comboBox.SelectedIndex > 0)     // 시간대별
                {
                    condition += "DAYOFWEEK(c_time) = " + day_comboBox.SelectedIndex + " and ";
                    unitOftime = "HOUR";
                    for (int i = 0; i < 24; i++)        // X축 :1 ~ 24
                        xValues[i] = (i + 1).ToString();
                    xValues_size = 24;
                }

                if (condition != "" && condition.Substring(condition.Length - 4).Equals("and "))        // where 조건 문자열에 'and'가 뒤에 남아있다면 제거
                    condition = condition.Substring(0, condition.Length - 5);

                // 기간 검색할 쿼리 생성 (연도, 월, 요일, 시간별)
                sql = "SELECT "+ unitOftime+"(c_time) as "+unitOftime+", count(*) as crimenum from crime "+condition+" group by "+unitOftime+"(c_time)";
                
                time = chart1.Series.Add(unitOftime);

                //ExecuteReader를 이용하여 연결 모드로 데이터 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //쿼리 결과값 읽어오기
                while (rdr.Read())
                {
                    if(unitOftime == "YEAR")
                    {
                        yValues[Int32.Parse(rdr[unitOftime].ToString())-2010] = Int32.Parse(rdr["crimenum"].ToString());   // 해당 시간의 사건 수 저장

                    }else
                    {
                        yValues[Int32.Parse(rdr[unitOftime].ToString())-1] = Int32.Parse(rdr["crimenum"].ToString());   // 해당 시간의 사건 수 저장
                    }
                }
                rdr.Close();
            }

            // X축, Y축 제목 설정
            chart1.ChartAreas["ChartArea1"].AxisX.Title = unitOftime;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "The number of crime ";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;             // X축은 1개 항목별로 출력
            for (int i = 0; i < xValues_size; i++)                          // 차트에 X, Y축에 값 세팅
                time.Points.AddXY(xValues[i], yValues[i]);
        }
        // 연령대별 범죄자 수 출력
        void setChart_age()
        {
            chart1.Series.Clear();
            Series age = chart1.Series.Add("age");
            int[] yValues = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] xValues = { "10대", "20대", "30대", "40대", "50대", "60대", "70대", "80대" };

            // X축, Y축 제목 설정
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Age";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "The number of criminal ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT round((DATE_FORMAT(NOW()," + "'%Y'" + ")-DATE_FORMAT(h.h_birthdate," + "'%Y'" + "))+5,-1) AS age, COUNT(*) AS criminalnum FROM criminal c, human h WHERE c.h_id = h.h_id GROUP BY round((DATE_FORMAT(NOW(), " + "'%Y'" + ") - DATE_FORMAT(h.h_birthdate, '%Y')) + 5, -1)";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int temp_age = Int32.Parse(rdr["age"].ToString());          // 연령 ex) time_age = 10, 20, 30...
                    yValues[temp_age / 10 - 1] = Int32.Parse(rdr["criminalnum"].ToString());  // 해당 연령대의 범죄자 수 저장
                }
                rdr.Close();
            }

            for (int i = 0; i < xValues.Length - 1; i++)
                age.Points.AddXY(xValues[i], yValues[i]);                       // 차트에 X, Y축에 값 세팅
        }
        // 범죄종류별 범죄자 수 출력
        void setChart_crime()
        {
 
            chart1.Series.Clear();
            Series crime = chart1.Series.Add("kind of crime");
            int[] yValues = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] xValues = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

            // X축, Y축 제목 설정
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Kind of crime";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "The number of criminal ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT crl_type ,count(*) AS criminalnum from classify c JOIN crimelist crl ON c.crl_id = crl.crl_id GROUP BY c.crl_id ORDER BY count(*) ASC";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int temp_index = 0;
                while (rdr.Read())
                {
                    xValues[temp_index] = rdr["crl_type"].ToString();                // 범죄 종류 
                    yValues[temp_index] = Int32.Parse(rdr["criminalnum"].ToString()); // 범죄 종류 별 범죄자 수
                    temp_index++;
                }
                rdr.Close();
            }
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < xValues.Length - 1; i++)
                crime.Points.AddXY(xValues[i], yValues[i]);                         // 차트에 X, Y축에 값 세팅
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
                setChart_time();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }
        private void time_comboBox_isEnabled(Boolean isEnabled)
        {
            year_comboBox.Enabled = isEnabled;
            month_comboBox.Enabled = isEnabled;
            day_comboBox.Enabled = isEnabled;
        }
        // 범죄종류를 선택했을 때
        private void crimelist_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if(crimelist_checkBox.CheckState == CheckState.Unchecked)
            {
                return;
            }
            //crimelist_checkBox.Checked = true;
            // 기간, 연령 체크박스 해제
            if (time_checkBox.Checked)
                time_checkBox.Checked = false;
            if (age_checkBox.Checked)
                age_checkBox.Checked = false;
            time_comboBox_isEnabled(false);             // 기간 년, 월, 일 콤보박스 Disabled
            setChart_crime();

        }
        // 연령을 선택했을 때
        private void age_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (age_checkBox.CheckState == CheckState.Unchecked)
            {
                return;
            }
            //age_checkBox.Checked = true;
            // 기간, 범죄종류 체크박스 해제
            if (time_checkBox.Checked)
                time_checkBox.Checked = false;
            if (crimelist_checkBox.Checked)
                crimelist_checkBox.Checked = false;
            time_comboBox_isEnabled(false);             // 기간 년, 월, 일 콤보박스 Disabled
            setChart_age();
        }
        // 기간을 선택했을 때
        private void time_checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (time_checkBox.CheckState == CheckState.Unchecked)
            {
                return;
            }
            // 범죄종류, 연령 체크박스 해제
            if (age_checkBox.Checked)
                age_checkBox.Checked = false;
            if (crimelist_checkBox.Checked)
                crimelist_checkBox.Checked = false;
            time_comboBox_isEnabled(true);              // 기간 년, 월, 일 콤보박스 Enabled
            setChart_time();
        }

        private void day_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setChart_time();
        }

        private void year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setChart_time();
        }
    }
}
