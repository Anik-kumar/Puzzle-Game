using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class puzzleForm : Form
    {
        Random rnd = new Random();
        private string a;
        private string b;
        private string c;
        private string d;
        private string e;
        private string f;
        private bool isClick = false;
        private Button prevBtn = new Button();
        private int score = 500;
        private int clickCount = 0;
        private string displayScore = "500";
        

        public puzzleForm()
        {
            InitializeComponent();
            
            initializeButton();
            initializeColor();
            randomPosition();

            


        }

        private void randomPosition()
        {
            int x, y;

            

            x = rnd.Next(this.Size.Width - this.button1.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button1.Size.Height - 39);
            this.button1.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);

            x = rnd.Next(this.Size.Width - this.button2.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button2.Size.Height - 39);
            this.button2.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button3.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button3.Size.Height - 39);
            this.button3.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button4.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button4.Size.Height - 39);
            this.button4.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button5.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button5.Size.Height - 39);
            this.button5.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button6.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button6.Size.Height - 39);
            this.button6.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button7.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button7.Size.Height - 39);
            this.button7.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button8.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button8.Size.Height - 39);
            this.button8.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button9.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button9.Size.Height - 39);
            this.button9.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button10.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button10.Size.Height - 39);
            this.button10.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button11.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button11.Size.Height - 39);
            this.button11.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);


            x = rnd.Next(this.Size.Width - this.button12.Size.Width - 16);
            y = rnd.Next(35, this.Size.Height - this.button12.Size.Height - 39);
            this.button12.Location = new System.Drawing.Point(x, y);
            //Console.WriteLine(x + " " + y);
              
        }

        private void initializeColor()
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            button11.BackColor = Color.Black;
            button12.BackColor = Color.Black;
        }

        private void initializeButton()
        {
            a = rnd.Next(16).ToString();
            b = rnd.Next(16, 32).ToString();
            c = rnd.Next(32, 48).ToString();
            d = rnd.Next(48, 64).ToString();
            e = rnd.Next(64, 80).ToString();
            f = rnd.Next(80, 99).ToString();
            button1.Text = a;
            button2.Text = a;
            button3.Text = b;
            button4.Text = b;
            button5.Text = c;
            button6.Text = c;
            button7.Text = d;
            button8.Text = d;
            button9.Text = e;
            button10.Text = e;
            button11.Text = f;
            button12.Text = f;
                        
            prevBtn = null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ++clickCount;

            if (isClick == false && prevBtn == null)
            {
                button1.BackColor = Color.White;
                prevBtn = button1;
                isClick = true;

            }
            else if(isClick == true)
            {
                if(prevBtn.Text == button1.Text && prevBtn != button1)
                {
                    this.button1.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button1.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button2.BackColor = Color.White;
                prevBtn = button2;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button2.Text && prevBtn != button2)
                {
                    this.button2.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button2.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();

                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button3.BackColor = Color.White;
                prevBtn = button3;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button3.Text && prevBtn != button3)
                {
                    this.button3.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button3.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();

                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button4.BackColor = Color.White;
                prevBtn = button4;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button4.Text && prevBtn != button4)
                {
                    this.button4.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button4.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button5.BackColor = Color.White;
                prevBtn = button5;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button5.Text && prevBtn != button5)
                {
                    this.button5.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button5.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button6.BackColor = Color.White;
                prevBtn = button6;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button6.Text && prevBtn != button6)
                {
                    this.button6.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button6.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button7.BackColor = Color.White;
                prevBtn = button7;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button7.Text && prevBtn != button7)
                {
                    this.button7.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button7.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button8.BackColor = Color.White;
                prevBtn = button8;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button8.Text && prevBtn != button8)
                {
                    this.button8.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button8.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }
       
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button9.BackColor = Color.White;
                prevBtn = button9;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button9.Text && prevBtn != button9)
                {
                    this.button9.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button9.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button10.BackColor = Color.White;
                prevBtn = button10;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button10.Text && prevBtn != button10)
                {
                    this.button10.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button10.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {

                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button11.BackColor = Color.White;
                prevBtn = button11;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button11.Text && prevBtn != button11)
                {
                    this.button11.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button11.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {

                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {
                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (isClick == false && prevBtn == null)
            {
                button12.BackColor = Color.White;
                prevBtn = button12;
                isClick = true;
            }
            else if (isClick == true)
            {
                if (prevBtn.Text == button12.Text && prevBtn != button12)
                {
                    this.button12.Hide();
                    this.prevBtn.Hide();
                    isClick = false;
                    prevBtn = null;
                }
                else
                {
                    this.button12.BackColor = Color.Black;
                    this.prevBtn.BackColor = Color.Black;
                    isClick = false;
                    prevBtn = null;
                    if (clickCount < 24)
                    {
                        score -= 10;
                        scoreLabel3.Text = score.ToString();
                    }
                    else
                    {

                        score = score - 25;
                        scoreLabel3.Text = score.ToString();
                    }
                }
            }

        }

        private void puzzleForm_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*Form f = new puzzleForm();
            f.Show();
            this.Hide();*/
            

            this.Controls.Remove(this.button1);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button4);
            this.Controls.Remove(this.button5);
            this.Controls.Remove(this.button6);
            this.Controls.Remove(this.button7);
            this.Controls.Remove(this.button8);
            this.Controls.Remove(this.button9);
            this.Controls.Remove(this.button10);
            this.Controls.Remove(this.button11);
            this.Controls.Remove(this.button12);
            this.Controls.Remove(this.scoreLabel3);
            //this.Controls.Remove(this.scoreLabel3);

            InitializeComponent();
            initializeButton();
            initializeColor();
            randomPosition();
            score = 500;
            clickCount = 0;
            isClick = false;
            prevBtn = null;
            scoreLabel3.Text = score.ToString();
        }
    }
}
