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

        private void Form1_Load1(object sender, EventArgs e)
        { 
            Button button1 = new Button();

            button1.DialogResult = DialogResult.OK;
            button1.Text = "확인";
            button1.Size = new Size(100, 50);
            button1.Location = new Point(30, 30);

            Controls.Add(button1);
            button1.Click += button1_click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_click(object o, EventArgs a)
        {
            MessageBox.Show("클릭 확인!");
        }
        
    }
}
