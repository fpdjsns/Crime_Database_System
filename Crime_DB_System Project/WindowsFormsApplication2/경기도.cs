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
    public partial class 경기도 : Form
    {
        private String strConn;
        private MySqlConnection conn;

        private String Do_Name = null;

        public 경기도(string Do)
        {

            InitializeComponent();
            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();

            comboBox1.Items.Add("연천군");
            comboBox1.Items.Add("포천시");
            comboBox1.Items.Add("동두천시");
            comboBox1.Items.Add("가평군");
            comboBox1.Items.Add("양주시");
            comboBox1.Items.Add("파주시");
            comboBox1.Items.Add("의정부");
            comboBox1.Items.Add("남양주시");
            comboBox1.Items.Add("구리시");
            comboBox1.Items.Add("하남시");
            comboBox1.Items.Add("서울");
            comboBox1.Items.Add("고양시");
            comboBox1.Items.Add("김포시");
            comboBox1.Items.Add("인천");
            comboBox1.Items.Add("부천시");
            comboBox1.Items.Add("광명시");
            comboBox1.Items.Add("안양시");
            comboBox1.Items.Add("과찬시");
            comboBox1.Items.Add("성남시");
            comboBox1.Items.Add("광주시");
            comboBox1.Items.Add("평택시");
            comboBox1.Items.Add("화성시");
            comboBox1.Items.Add("수원시");
            comboBox1.Items.Add("오산시");
            comboBox1.Items.Add("용인시");
            comboBox1.Items.Add("안성시");
            comboBox1.Items.Add("이천시");
            comboBox1.Items.Add("여주군");
            comboBox1.Items.Add("양평군");
            comboBox1.Items.Add("의왕군");
            comboBox1.Items.Add("시흥시");
            comboBox1.Items.Add("안산시");
            comboBox1.Items.Add("군포시");

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

        private void showSelectedButton_Click()
        {
            throw new NotImplementedException();
        }


        private void 경기도_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            Form1 jungak = new Form1();

            jungak.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
