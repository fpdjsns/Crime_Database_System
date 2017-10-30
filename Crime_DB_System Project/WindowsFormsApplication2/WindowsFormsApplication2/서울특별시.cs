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
    public partial class 서울특별시 : Form
    {
        public string D0_Name;
        public 서울특별시(string Do)
        {
            D0_Name = Do;
            InitializeComponent();
            comboBox1.Items.Add("도봉구");
            comboBox1.Items.Add("강북구");
            comboBox1.Items.Add("노원구");
            comboBox1.Items.Add("성북구");
            comboBox1.Items.Add("중랑구");
            comboBox1.Items.Add("은평구");
            comboBox1.Items.Add("종로구");
            comboBox1.Items.Add("동대문구");
            comboBox1.Items.Add("중구");
            comboBox1.Items.Add("서대문구");
            comboBox1.Items.Add("마포구");
            comboBox1.Items.Add("용산구");
            comboBox1.Items.Add("성동구");
            comboBox1.Items.Add("광진구");
            comboBox1.Items.Add("강동구");
            comboBox1.Items.Add("송파구");
            comboBox1.Items.Add("강남구");
            comboBox1.Items.Add("서초구");
            comboBox1.Items.Add("동작구");
            comboBox1.Items.Add("관악구");
            comboBox1.Items.Add("금천구");
            comboBox1.Items.Add("영등포구");
            comboBox1.Items.Add("구로구");
            comboBox1.Items.Add("양천구");
            comboBox1.Items.Add("강서구");
            comboBox1.Items.Add("삼척시");
            comboBox1.Items.Add("동해시");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
