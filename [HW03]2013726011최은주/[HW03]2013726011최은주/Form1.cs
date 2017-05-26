using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace _HW03_2013726011최은주
{
    public partial class Form1 : Form
    {
        int speedNum = 25;
        Random random = new Random();
        private Thread m_Thread, m_Thread2;
        int levelNum = 1;
        int scoreNum = 0;
        int lifeNum = 10;
        int starNum = 2;
        bool isEat = false;
        bool isMad = false;
        bool isgaming = false;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;

            rabbit.BackColor = Color.Transparent;
            rabbit.Parent = pictureBox2;

            cloud.BackColor = Color.Transparent;
            cloud.Parent = pictureBox2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(isgaming != false)
            {
                m_Thread.Abort();
                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isgaming != false)
            {
                m_Thread.Abort();
            }
        }

        private void slow_Click(object sender, EventArgs e)
        {
            if (speed.Text != "1")
            {
                speedNum -= 1;
                speed.Text = speedNum.ToString();
            }
        }

        private void fast_Click(object sender, EventArgs e)
        {
            speedNum += 1;
            speed.Text = speedNum.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void start_Click(object sender, EventArgs e)
        {
            isgaming = true;
            levelNum = 1;
            scoreNum = 0;
            lifeNum = 10;
            starNum = 2;
            level.Text = levelNum.ToString();
            score.Text = scoreNum.ToString();
            life.Text = lifeNum.ToString();
            star.Text = starNum.ToString();
            cloud.Visible = true;
            rabbit.Focus();
            start.Enabled = false;
            m_Thread = new Thread(new ThreadStart(moving_Cloud));
            m_Thread.Start();
        }

        private void fallen_Items()
        {
                int itemNum = random.Next(0, 12);

                PictureBox fallenItems = new PictureBox();
            this.Invoke(new MethodInvoker(() =>
                {
                    fallenItems.Parent = pictureBox2;

                    fallenItems.Width = 20;
                    fallenItems.Height = 20;

                    fallenItems.Image = imageList1.Images[itemNum];
                    fallenItems.BackColor = Color.Transparent;
                    fallenItems.Tag = itemNum;

                    fallenItems.Location = new Point(cloud.Location.X, cloud.Location.Y);
                }));
            int i = 1;
            while (fallenItems.Location.Y < 350)
            {
                Thread.Sleep(50);
                this.Invoke(new MethodInvoker(() =>
                {
                    fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + i);
                    i = i+1;
                    if(rabbit.Bounds.IntersectsWith (fallenItems.Bounds))
                    {
                        if(itemNum == 0)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y+100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 5;
                            score.Text = scoreNum.ToString();
                            rabbit.Focus();
                            isEat = true;
                        }
                        else if(itemNum == 1)   //폭탄
                        {
                            if(isMad == true)
                            {
                                fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                                fallenItems.Dispose();
                                life.Focus();
                                life.Text = lifeNum.ToString();
                                rabbit.Focus();
                                isEat = true;
                            }
                            else
                            {
                                fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                                fallenItems.Dispose();
                                life.Focus();
                                lifeNum -= 1;
                                life.Text = lifeNum.ToString();
                                rabbit.Focus();
                                isEat = true;
                            }
 
                        }
                        else if (itemNum == 2)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 10;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 3)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 15;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 4)      //하트
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            life.Focus();
                            lifeNum += 1;
                            life.Text = lifeNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 5)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 20;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 6)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 20;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 7)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 15;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 8)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 10;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 9)  //별
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            star.Focus();
                            starNum += 1;
                            star.Text = starNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 10)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 5;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                        else if (itemNum == 11)
                        {
                            fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                            fallenItems.Dispose();
                            score.Focus();
                            scoreNum += 1;
                            score.Text = scoreNum.ToString();

                            rabbit.Focus();
                            isEat = true;
                        }
                    }
                }));
            }
            this.Invoke(new MethodInvoker(() =>
            {
                if (isEat == false)
                {
                    if (itemNum == 1 || itemNum == 4 || itemNum ==9)
                    {
                        fallenItems.Dispose();
                    }
                    else
                    {
                        fallenItems.Location = new Point(fallenItems.Location.X, fallenItems.Location.Y + 100);
                        fallenItems.Dispose();
                        life.Focus();
                        lifeNum -= 1;
                        life.Text = lifeNum.ToString();
                        if (lifeNum <= 0)
                        {
                            life.Focus();
                            lifeNum = 0;
                            life.Text = lifeNum.ToString();
                        }
                        rabbit.Focus();
                      }
                }
                isEat = false;

            }));
            this.Invoke(new MethodInvoker(() =>
            {
                if (scoreNum>levelNum*100)
                {
                    levelNum++;
                    if(levelNum > 10)
                    {
                        levelNum = 10;
                    }
                    level.Focus();
                    level.Text = levelNum.ToString();
                    rabbit.Focus();
                }
            }));
        }

        private void moving_Cloud()
        {
            while(true)
            {
                Thread.Sleep(300-levelNum*20);
                int n = random.Next(1, 10);

                int moving = random.Next(10, 20);
                this.Invoke(new MethodInvoker(() =>
                {
                    if (n % 2 == 0)     //오른쪽
                    {
                        if(cloud.Location.X != 0 )
                        {
                            if(cloud.Location.X + moving + levelNum < pictureBox2.Size.Width - cloud.Size.Width)
                            {
                                cloud.Location = new Point(cloud.Location.X + moving + levelNum, cloud.Location.Y);
                            }
                            else
                            {
                                cloud.Location = new Point(pictureBox2.Size.Width-cloud.Size.Width, cloud.Location.Y);
                            }
                        }
                        else
                        {
                            cloud.Location = new Point(cloud.Location.X + moving + levelNum, cloud.Location.Y);
                        }

                    }
                    else    //왼쪽
                    {
                        if (cloud.Location.X != 0)
                        {
                        if (cloud.Location.X - moving - levelNum > 0)
                        {
                            cloud.Location = new Point(cloud.Location.X - moving - levelNum, cloud.Location.Y);
                        }
                        else if (rabbit.Location.X-moving-levelNum <0)
                            {
                                cloud.Location = new Point(0, cloud.Location.Y);
                            }
                        }
                        else
                        {
                            cloud.Location = new Point(cloud.Location.X + moving + levelNum, cloud.Location.Y);
                        }
                    }

                    if (levelNum == 10)
                    {
                        if (n > 3)
                        {
                            m_Thread2 = new Thread(new ThreadStart(fallen_Items));
                            m_Thread2.Start();
                        }

                    }
                    else
                    {
                        if (n > 5)
                        {
                            m_Thread2 = new Thread(new ThreadStart(fallen_Items));
                            m_Thread2.Start();
                        }
                    }

                }));
                this.Invoke(new MethodInvoker(() =>
                {
                    if (lifeNum <= 0)
                    {
                        m_Thread.Abort();
                        life.Focus();
                        lifeNum = 0;
                        life.Text = lifeNum.ToString();

                        if (starNum >= 10)
                        {
                            if (MessageBox.Show("별을 열개 사용하여 부활하시겠습니까?", "GAME OVER", MessageBoxButtons.YesNo)==DialogResult.Yes)
                            {
                                life.Focus();
                                lifeNum = 3;
                                life.Text = lifeNum.ToString();
                                star.Focus();
                                starNum -= 10;
                                star.Text = starNum.ToString();
                                rabbit.Focus();
                                m_Thread = new Thread(new ThreadStart(moving_Cloud));
                                m_Thread.Start();
                                
                            }
                            else
                            {
                                life.Focus();
                                lifeNum = 0;
                                life.Text = lifeNum.ToString();
                                MessageBox.Show("게임종료!!!");

                                start.Enabled = true;
                            }
                        }
                        else
                        {
                            life.Focus();
                            lifeNum = 0;
                            life.Text = lifeNum.ToString();
                            MessageBox.Show("게임종료!!");
                            start.Enabled = true;
                        }

                    }
                }));

            }

        }

        private void rabbit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MovePicBox(sender, e);
        }

        public void MovePicBox(object sender, EventArgs e)
        {
            if (e is KeyEventArgs)
            {
                KeyEventArgs ke = (KeyEventArgs)e;
                MovePicKey(ke.KeyCode);

            }
            else if (e is PreviewKeyDownEventArgs)
            {
                PreviewKeyDownEventArgs ke = (PreviewKeyDownEventArgs)e;
                MovePicKey(ke.KeyCode);
            }
        }

        private void MovePicKey(Keys ke)
        {
            this.Invoke(new MethodInvoker(() =>
            {

                if (ke == Keys.Left)
                {
                    if (rabbit.Location.X != 0)
                    {
                        if (rabbit.Location.X - speedNum >0)
                        {
                            rabbit.Location = new Point(rabbit.Location.X - speedNum, rabbit.Location.Y);
                        }
                        else if (rabbit.Location.X - speedNum < 0)
                        {
                            rabbit.Location = new Point(0, rabbit.Location.Y);
                        }
                        else
                        {
                            rabbit.Location = new Point(0, rabbit.Location.Y);
                        }
                    }
                }
                else if (ke == Keys.Right)
                {
                    if (rabbit.Location.X != 0)
                    {
                        if (rabbit.Location.X + speedNum < pictureBox2.Size.Width - rabbit.Size.Width)
                        {
                            rabbit.Location = new Point(rabbit.Location.X + speedNum, rabbit.Location.Y);
                        }
                        else
                        {
                            rabbit.Location = new Point(pictureBox2.Size.Width - rabbit.Size.Width, rabbit.Location.Y);
                        }
                    }
                    else
                    {
                        rabbit.Location = new Point(rabbit.Location.X + speedNum, rabbit.Location.Y);
                    }
                }

                    else if (ke == Keys.W)
                    {
                        speed.Focus();
                        speedNum += 1;
                        speed.Text = speedNum.ToString();
                        rabbit.Focus();
                    }
                    else if (ke == Keys.Q)
                    {
                        if (speed.Text != "1")
                        {
                            speed.Focus();
                            speedNum -= 1;
                            speed.Text = speedNum.ToString();
                            rabbit.Focus();
                        }
                    }
                    else if (ke == Keys.E)
                    {
                        if (starNum >= 1)
                        {
                            star.Focus();
                            starNum -= 1;
                            star.Text = starNum.ToString();
                            rabbit.Focus();
                            rabbit.Image = global::_HW03_2013726011최은주.Properties.Resources.화난토끼;
                            isMad = true;
                            timer1.Start();
                        }
                    }
                
            }));

        }



        private void manual_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                rabbit.Image = global::_HW03_2013726011최은주.Properties.Resources.토끼;
            }));
            isMad = false;
            timer1.Stop();
        }

    }
}
