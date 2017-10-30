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

    public partial class 전국지도 : Form
    {
        
        public 전국지도()
        {
            InitializeComponent();
            comboBox1.Items.Add("경기도");
            comboBox1.Items.Add("서울특별시");
            comboBox1.Items.Add("인천광역시");
            comboBox1.Items.Add("충청북도");
            comboBox1.Items.Add("대전광역시");
            comboBox1.Items.Add("전라북도");
            comboBox1.Items.Add("충청남도");
            comboBox1.Items.Add("광주광역시");
            comboBox1.Items.Add("전라남도");
            comboBox1.Items.Add("경상남도");
            comboBox1.Items.Add("대구광역시");
            comboBox1.Items.Add("울산광역시");
            comboBox1.Items.Add("부산광역시");
            comboBox1.Items.Add("경상북도");
            comboBox1.Items.Add("제주도");
            comboBox1.Items.Add("강원도");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (comboBox1.SelectedIndex)
            {
                case 0: //경기도
                    {

                       

                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        경기도 경기도 = new 경기도(Do_Name); // 새로운 폼 선언
                        경기도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 1: //서울특별시
                    {

                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        서울특별시 서울 = new 서울특별시(Do_Name);
                        서울.ShowDialog();
                        break;
                    }

                case 2: //인천광역시 
                    {

                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것

                        인천광역시 인천광역시 = new 인천광역시(Do_Name);
                        인천광역시.ShowDialog();
                        break;
                    }

                case 3:
                    {

                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();


                        this.Visible = false; //현재 창 사라지게 하는 것
                        충청북도 충청북도 = new 충청북도(Do_Name); // 새로운 폼 선언
                        충청북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 4:
                    {

                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        대전광역시 대전광역시 = new 대전광역시(Do_Name); // 새로운 폼 선언
                        대전광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 5:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        전라북도 전라북도 = new 전라북도(Do_Name); // 새로운 폼 선언
                        전라북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 6:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        충청남도 충청남도 = new 충청남도(Do_Name); // 새로운 폼 선언
                        충청남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 7:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        광주광역시 광주광역시 = new 광주광역시(Do_Name); // 새로운 폼 선언
                        광주광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 8:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        전라남도 전라남도 = new 전라남도(Do_Name); // 새로운 폼 선언
                        전라남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 9:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        경상남도 경상남도 = new 경상남도(Do_Name); // 새로운 폼 선언
                        경상남도.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 10:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());


                        String Do_Name = selectedItem.ToString();
                        this.Visible = false; //현재 창 사라지게 하는 것
                        대구광역시 대구광역시 = new 대구광역시(Do_Name); // 새로운 폼 선언
                        대구광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 11:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        울산광역시 울산광역시 = new 울산광역시(Do_Name); // 새로운 폼 선언
                        울산광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }

                case 12:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        부산광역시 부산광역시 = new 부산광역시(Do_Name); // 새로운 폼 선언
                        부산광역시.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 13:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        경상북도 경상북도 = new 경상북도(Do_Name); // 새로운 폼 선언
                        경상북도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 14:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        제주도 제주도 = new 제주도(Do_Name); // 새로운 폼 선언
                        제주도.ShowDialog(); //선언한 폼 실행

                        break;
                    }
                case 15:
                    {
                        int selectedIndex = comboBox1.SelectedIndex;
                        Object selectedItem = comboBox1.SelectedItem;

                        // MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

                        String Do_Name = selectedItem.ToString();

                        this.Visible = false; //현재 창 사라지게 하는 것
                        강원도 강원도 = new 강원도(Do_Name); // 새로운 폼 선언
                        강원도.ShowDialog(); //선언한 폼 실행

                        break;
                    }




            }
        }

        private void showSelectedButton_Click()
        {
            throw new NotImplementedException();
        }

        private void 전국지도_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
