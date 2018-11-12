using System;
using System.Collections;
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
        private Label lb;
        private void Form1_Load1(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(new Item("button",30,30,"btn_1"));
            arrList.Add(new Item("label",30,110,"lb_1"));
            arrList.Add(new Item("button",30,190,"btn_2"));

            for(int i = 0; i < arrList.Count; i++)
            {
                Control ctr=Control_create((Item)arrList[i]);
                Controls.Add(ctr);
            }

            /*
            string[] ctrList = {"button","label","button"};

            for (int i = 0; i < ctrList.Length; i++)
            {
                if(ctrList[i]=="button") Controls.Add(btn_create(i));
                else if(ctrList[i]=="label") Controls.Add(label_click(i));
            }*/ // 배열을 통해서 패널들 제어
        }

        private Control Control_create(Item item)
        {
            Control ctr = new Control();
            
            switch (item.getType())
            {
                case "button":
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += button1_click;
                    ctr = btn;
                    break;

                case "label":
                    Label lb = new Label();
                    ctr = lb;
                    break;

                default:
                    break;
            }
            ctr.Name = item.getTxt();
            ctr.Text = item.getTxt();
            ctr.Size = new Size(100, 50);
            ctr.Location = new Point(item.getX(), item.getY());
            return ctr;
        }
        
        private Button btn_create(int i)
        { 
            button1 = new Button();
            button1.DialogResult = DialogResult.OK;
            button1.Name = string.Format("button_{0}", i + 1);
            button1.Text = string.Format("확인:{0}", i + 1);
            button1.Size = new Size(100, 50);
            button1.Location = new Point((100 * i) + 30, 30);
            button1.Cursor = Cursors.Hand;

           // Controls.Add(button1); // controls == 배열이라는 뜻
            button1.Click += button1_click;
            return button1;
        }
        
        private Label label_click(int i)
        {
            lb = new Label();
            lb.Name = string.Format("lb_{0}", i + 1);
            lb.Text = string.Format("확인:{0}", i + 1);
            lb.Size = new Size(100, 50);
            lb.Location = new Point((100 * i) + 30, 30);
            return lb;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_click(object o, EventArgs a)// object o 버튼에 대한 정보를 받아올 수 있다.
        {
          //  string names = "";
            foreach(Control ct in Controls)
            {
                // names += ct.Name + " ";
                if(ct.Name!="button_3") ct.BackColor = Color.Silver;
            }
            //MessageBox.Show(names);
            button1 = (Button)o; // 오브젝트를 버튼 클래스로 형변환시켜서 color 같은 속성을 사용하여 연결
            button1.BackColor=(button1.BackColor == Color.Green)? button1.BackColor = Color.Silver : button1.BackColor = Color.Green;
        }
    }

    public class Item
    {
        private string type;
        private int x;
        private int y;
        private string txt;

        public Item(string type, int x,int y ,string txt)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.txt = txt;
        }
        public string getType()
        {
            return type;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getTxt()
        {
            return txt;
        }
    }
}
