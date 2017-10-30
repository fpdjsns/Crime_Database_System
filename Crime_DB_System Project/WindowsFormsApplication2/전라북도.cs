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
    public partial class 전라북도 : Form
    {
        private String strConn;
        private MySqlConnection conn;

        private String Do_Name = null;

        public 전라북도(string Do)
        {
            InitializeComponent();
            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();
            InitializeComponent();
            comboBox1.Items.Add("군산시");
            comboBox1.Items.Add("익산시");
            comboBox1.Items.Add("완주군");
            comboBox1.Items.Add("진안군");
            comboBox1.Items.Add("무주군");
            comboBox1.Items.Add("전주시");
            comboBox1.Items.Add("김제시");
            comboBox1.Items.Add("부안군");
            comboBox1.Items.Add("정읍시");
            comboBox1.Items.Add("임실군");
            comboBox1.Items.Add("장수군");
            comboBox1.Items.Add("남원시");
            comboBox1.Items.Add("순창군");
            comboBox1.Items.Add("고창군");
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

        private void 전라북도_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
