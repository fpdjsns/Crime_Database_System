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
    public partial class 대전광역시 : Form
    {
        public string D0_Name;
        public 대전광역시(string Do)
        {
            D0_Name = Do;
            InitializeComponent();

            comboBox1.Items.Add("유성구");
            comboBox1.Items.Add("대덕구");
            comboBox1.Items.Add("동구");
            comboBox1.Items.Add("중구");
            comboBox1.Items.Add("서구");
          
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
