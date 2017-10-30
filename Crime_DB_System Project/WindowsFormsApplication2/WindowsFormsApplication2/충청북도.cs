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
    public partial class 충청북도 : Form
    {
        public string D0_Name;
        public 충청북도(string Do)
        {
            D0_Name = Do;
            InitializeComponent();
            comboBox1.Items.Add("제천시");
            comboBox1.Items.Add("단양군");
            comboBox1.Items.Add("충주시");
            comboBox1.Items.Add("음성군");
            comboBox1.Items.Add("진천군");
            comboBox1.Items.Add("괴산군");
            comboBox1.Items.Add("청원군");
            comboBox1.Items.Add("청주시");
            comboBox1.Items.Add("보은군");
            comboBox1.Items.Add("옥천군");
            comboBox1.Items.Add("영동군");
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

        private void 충청북도_Load(object sender, EventArgs e)
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
