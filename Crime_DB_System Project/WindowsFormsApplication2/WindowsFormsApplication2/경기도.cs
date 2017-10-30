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
    public partial class 경기도 : Form
    {
        public string D0_Name;
        public 경기도(string Do)
        {
            D0_Name = Do;

            InitializeComponent();

            comboBox1.Items.Add("연천군");
            comboBox1.Items.Add("포천시");
            comboBox1.Items.Add("동두천시");
            comboBox1.Items.Add("가평군");
            comboBox1.Items.Add("양주시");
            comboBox1.Items.Add("파주시");
            comboBox1.Items.Add("의정부");
            comboBox1.Items.Add("남양주시");
            comboBox1.Items.Add("구리시");
            comboBox1.Items.Add("하남시");
            comboBox1.Items.Add("서울");
            comboBox1.Items.Add("고양시");
            comboBox1.Items.Add("김포시");
            comboBox1.Items.Add("인천");
            comboBox1.Items.Add("부천시");
            comboBox1.Items.Add("광명시");
            comboBox1.Items.Add("안양시");
            comboBox1.Items.Add("과찬시");
            comboBox1.Items.Add("성남시");
            comboBox1.Items.Add("광주시");
            comboBox1.Items.Add("평택시");
            comboBox1.Items.Add("화성시");
            comboBox1.Items.Add("수원시");
            comboBox1.Items.Add("오산시");
            comboBox1.Items.Add("용인시");
            comboBox1.Items.Add("안성시");
            comboBox1.Items.Add("이천시");
            comboBox1.Items.Add("여주군");
            comboBox1.Items.Add("양평군");
            comboBox1.Items.Add("의왕군");
            comboBox1.Items.Add("시흥시");
            comboBox1.Items.Add("안산시");
            comboBox1.Items.Add("군포시");

        }
        private void showSelectedButton_Click()
        {
            throw new NotImplementedException();
        }
        private void 경기도_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재 창 사라지게 하는 것
            전국지도 jungak = new 전국지도();

            jungak.ShowDialog();
        }
    }
}
