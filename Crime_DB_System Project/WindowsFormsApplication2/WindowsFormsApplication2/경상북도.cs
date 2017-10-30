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
    public partial class 경상북도 : Form
    {
        public string D0_Name;
        public 경상북도(string Do)
        {
            D0_Name = Do;
        
            InitializeComponent();
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

        private void 경상북도_Load(object sender, EventArgs e)
        {

        }
    }
}
