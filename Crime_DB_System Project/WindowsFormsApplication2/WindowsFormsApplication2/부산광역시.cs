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
    public partial class 부산광역시 : Form
    {
        public string D0_Name;
        public 부산광역시(string Do)
        {
            D0_Name = Do;
            InitializeComponent();
            comboBox1.Items.Add("기장군");
            comboBox1.Items.Add("금정구");
            comboBox1.Items.Add("북구");
            comboBox1.Items.Add("동래구");
            comboBox1.Items.Add("해운대구");
            comboBox1.Items.Add("연제구");
            comboBox1.Items.Add("수영구");
            comboBox1.Items.Add("부산진군");
            comboBox1.Items.Add("사상구");
            comboBox1.Items.Add("서구");
            comboBox1.Items.Add("동구");
            comboBox1.Items.Add("중구");
            comboBox1.Items.Add("남구");
            comboBox1.Items.Add("영도구");
            comboBox1.Items.Add("사하구");
            comboBox1.Items.Add("상서구");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 부산광역시_Load(object sender, EventArgs e)
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
