using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MyButton()
        {
            Random Ran = new Random();
            Button button3 = new Button();
            button3.Location = new System.Drawing.Point(Ran.Next(0, 500), Ran.Next(0, 200));
            button3.Size = new Size(60, 30);
            button3.TabIndex = 3;
            button3.Text = "Кнопка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new EventHandler(button3_click);
            button3.Name = "button4";
            Controls.Add(button3); 
        }
        public void button3_click(object sender, EventArgs e)
        {
            MessageBox.Show("ДАНА Тюлемисова");
        }
        public void MyText()
        {
            Random Ran = new Random();
            TextBox textbox1 = new TextBox();
            textbox1.Location = new System.Drawing.Point( Ran.Next(500, 1000), Ran.Next(0, 200)); //(this.ClientRectangle.Width / Ran.Next(0, 100), this.ClientRectangle.Height / Ran.Next(0, 100))
            textbox1.Size = new Size(65, 0);
            textbox1.TabIndex = 3;
            textbox1.Text = "Поле ввода";
            textbox1.Click += new EventHandler(text_visble);
            textbox1.Name = "textbox1";
            Controls.Add(textbox1);  
        }
        public void text_visble(object sender, EventArgs e)
        {
           this.Controls["textbox1"].Text = "Тюлемисова Дана";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random Ran = new Random();
            int q =  Ran.Next(0, 2);
            if (q == 0)
            {
                MyButton();
                InitializeComponent();
            }
            else
            {
                MyText();
                InitializeComponent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls["button4"].Size = new Size(60, 40);
            
        }
    }
}

        
