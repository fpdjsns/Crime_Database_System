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
    public partial class 전라남도 : Form
    {
        private String strConn;
        private MySqlConnection conn;

        private String Do_Name = null;

        public string D0_Name;
        public 전라남도(string Do)
        {

            InitializeComponent();
            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();
            InitializeComponent();
            comboBox1.Items.Add("영광군");
            comboBox1.Items.Add("장성군");
            comboBox1.Items.Add("담양군");
            comboBox1.Items.Add("곡성군");
            comboBox1.Items.Add("구례군");
            comboBox1.Items.Add("광양시");
            comboBox1.Items.Add("순천시");
            comboBox1.Items.Add("화순군");
            comboBox1.Items.Add("나주시");
            comboBox1.Items.Add("함평군");
            comboBox1.Items.Add("무인군");
            comboBox1.Items.Add("영암군");
            comboBox1.Items.Add("장흥군");
            comboBox1.Items.Add("보성군");
            comboBox1.Items.Add("여수시");
            comboBox1.Items.Add("고흥군");
            comboBox1.Items.Add("강진군");
            comboBox1.Items.Add("해남군");
            comboBox1.Items.Add("진도군");
            comboBox1.Items.Add("완도군");
            comboBox1.Items.Add("목포시");
            comboBox1.Items.Add("신안군");

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

        private void 전라남도_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            Form1 jungak = new Form1();

            jungak.ShowDialog();
        }
    }
}
