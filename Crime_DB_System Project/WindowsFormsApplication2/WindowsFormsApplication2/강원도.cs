using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class 강원도 : Form
    {
        public string D0_Name;
        public 강원도(string Do)
        {
            D0_Name = Do;
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

            String Si_Name = D0_Name + selectedItem.ToString();

            MessageBox.Show(D0_Name);

            this.Visible = false; //현재 창 사라지게 하는 것


            monitor_list mlist = new monitor_list(Si_Name);

            mlist.ShowDialog();

        }

        private void 강원도_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false; //현재 창 사라지게 하는 것
            전국지도 jungak = new 전국지도();

            jungak.ShowDialog();
        }
    }
}
