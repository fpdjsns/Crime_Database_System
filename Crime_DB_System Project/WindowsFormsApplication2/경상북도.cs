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
    public partial class 경상북도 : Form
    {
        private String strConn;
        private MySqlConnection conn;

        private String Do_Name = null;

        public 경상북도(string Do)
        {
            InitializeComponent();
            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();

            comboBox1.Items.Add("문경시");
            comboBox1.Items.Add("예천군");
            comboBox1.Items.Add("상주시");
            comboBox1.Items.Add("영주시");
            comboBox1.Items.Add("봉화군");
            comboBox1.Items.Add("울진군");
            comboBox1.Items.Add("울릉군");
            comboBox1.Items.Add("영양군");
            comboBox1.Items.Add("안동시");
            comboBox1.Items.Add("의성군");
            comboBox1.Items.Add("칭송군");
            comboBox1.Items.Add("영덕군");
            comboBox1.Items.Add("포항시");
            comboBox1.Items.Add("영천군");
            comboBox1.Items.Add("군위군");
            comboBox1.Items.Add("구미시");
            comboBox1.Items.Add("김천군");
            comboBox1.Items.Add("성주군");
            comboBox1.Items.Add("고령군");
            comboBox1.Items.Add("청도군");
            comboBox1.Items.Add("경산시");
            comboBox1.Items.Add("경주시");
            comboBox1.Items.Add("포항시");
            comboBox1.Items.Add("영천시");
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
        private void 경상북도_Load(object sender, EventArgs e)
        {

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
    }
}
