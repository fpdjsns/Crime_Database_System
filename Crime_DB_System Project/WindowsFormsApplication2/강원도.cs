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
    public partial class 강원도 : Form
    {
        //====================================================
        private String strConn;
        private MySqlConnection conn;
        private String Do_Name = null;
     

        public 강원도(string Do)
        {



            InitializeComponent();
            Do_Name = Do;
            MessageBox.Show(Do_Name);
            strConn = "Data Source=127.0.0.1;Database=crimedata;User Id=root;Password=admin;";
            conn = new MySqlConnection(strConn);
            print2_data();
            //=====================================================


            comboBox1.Items.Add("철원군");
            comboBox1.Items.Add("화천군");
            comboBox1.Items.Add("양구군");
            comboBox1.Items.Add("인제군");
            comboBox1.Items.Add("고성군");
            comboBox1.Items.Add("속초시");
            comboBox1.Items.Add("양양군");
            comboBox1.Items.Add("홍천군");
            comboBox1.Items.Add("평창군");
            comboBox1.Items.Add("강릉시");
            comboBox1.Items.Add("정선군");
            comboBox1.Items.Add("영월군");
            comboBox1.Items.Add("황성군");
            comboBox1.Items.Add("원주시");
            comboBox1.Items.Add("태백시");
            comboBox1.Items.Add("삼척시");
            comboBox1.Items.Add("동해시");


        }

        //=======================================

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
        //=======================================

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

            String Si_Name = Do_Name+" "+selectedItem.ToString();

            MessageBox.Show(Si_Name);

            this.Visible = false; //현재 창 사라지게 하는 것


            monitor_list mlist = new monitor_list(Si_Name);

            mlist.ShowDialog();

        }

      
  
        private void 강원도_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            Form1 jungak = new Form1();

            jungak.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
