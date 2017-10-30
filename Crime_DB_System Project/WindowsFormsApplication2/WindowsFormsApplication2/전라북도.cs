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
    public partial class 전라북도 : Form
    {
        public string D0_Name;
        public 전라북도(string Do)
        {
            D0_Name = Do;
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

        private void 전라북도_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
