using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load1;
        }
        private Button button1;

        private void Form1_Load1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                button1 = new Button();

                button1.DialogResult = DialogResult.OK;
                button1.Text = string.Format("확인:{0}",i+1);
                button1.Size = new Size(100, 50);
                button1.Location = new Point((100*i)+30, 30);
                button1.Cursor = Cursors.Hand;

                Controls.Add(button1);
                button1.Click += button1_click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_click(object o, EventArgs a)// object 버튼에 대한 정보를 받아올 수 있다.
        {
            button1 = (Button)o;
            button1.BackColor=(button1.BackColor == Color.Green)? button1.BackColor = Color.Silver : button1.BackColor = Color.Green;
        }
        
    }
}
