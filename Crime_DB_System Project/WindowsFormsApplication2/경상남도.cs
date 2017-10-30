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
    public partial class 경상남도 : Form
    {
        private String strConn;
        private MySqlConnection conn;

        private String Do_Name = null;

        public 경상남도(string Do)
        {
          
            InitializeComponent();

            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();


            comboBox1.Items.Add("거창군");
            comboBox1.Items.Add("함양군");
            comboBox1.Items.Add("합천군");
            comboBox1.Items.Add("산청군");
            comboBox1.Items.Add("의령군");
            comboBox1.Items.Add("창녕군");
            comboBox1.Items.Add("밀양시");
            comboBox1.Items.Add("창원시");
            comboBox1.Items.Add("함안군");
            comboBox1.Items.Add("진주시");
            comboBox1.Items.Add("하동군");
            comboBox1.Items.Add("고성군");
            comboBox1.Items.Add("사천시");
            comboBox1.Items.Add("남해군");
            comboBox1.Items.Add("통영시");
            comboBox1.Items.Add("거제시");
            comboBox1.Items.Add("진해시");
            comboBox1.Items.Add("김해시");
            comboBox1.Items.Add("양산시");
            comboBox1.Items.Add("마산시");
        }
        private void print2_data()
        {

            string query1 = "SELECT count(Distinct h_name) FROM human h JOIN criminal cr ON(h.h_id = cr.h_id) WHERE h_address LIKE '" + Do_Name + "%';";

            MySqlCommand cmd1 = new MySqlCommand(query1);
            cmd1.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd1.ExecuteReader();

            try
            {
                reader.Read();
                label2.Text = reader.GetString(0);
                label3.Text = Do_Name + " 범죄자 수 :";
                conn.Close();
                reader.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

            String Si_Name = Do_Name + " " + selectedItem.ToString();

            MessageBox.Show(Si_Name);

            this.Visible = false; //현재 창 사라지게 하는 것


            monitor_list mlist = new monitor_list(Si_Name);

            mlist.ShowDialog();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            전국지도 jungak = new 전국지도();

            jungak.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            Form1 jungak = new Form1();

            jungak.ShowDialog();
        }

        private void 경상남도_Load(object sender, EventArgs e)
        {

        }
    }
}
