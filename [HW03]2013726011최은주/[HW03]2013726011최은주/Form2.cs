using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW03_2013726011최은주
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "폭탄을 피하면서 열심히 과일을 먹는 게임입니다.\r\n";
            textBox1.AppendText ("토끼 귀 사이로 아이템이 떨어져야 점수 인정됩니다.\n");
            textBox1.AppendText("게임 종료 조건 :Life = 0.\r\n");
            textBox1.AppendText("Life가 늘어나는 조건 : 하트를 먹을 때\n");
            textBox1.AppendText("Life가 1씩 줄어드는 조건 :과일을 놓칠 때, 폭탄을 먹을 때.\r\n");
            textBox1.AppendText("KEY입력안내\n");
            textBox1.AppendText("키보드 왼쪽 방향키 : 왼쪽이동\n");
            textBox1.AppendText("키보드 오른쪽 방향키 : 오른쪽쪽이동\n");
            textBox1.AppendText("Q : 토끼 속도(skip frame) 1증가\n");
            textBox1.AppendText("W : 토끼 속도(skip frame) 1감소\n");
            textBox1.AppendText("E : 무적스킬(별 하나 사용).\r\n");

            textBox1.AppendText("특이사항\n");
            textBox1.AppendText("-점수가 올라갈수록 레벨이 높아지고 어려워집니다.\n");
            textBox1.AppendText("-별을 먹을 시 Star Point가 올라갑니다\n");
            textBox1.AppendText("무적 스킬(E)를 사용할 경우 폭탄에 3초간 면역이 됩니다.\n");
            textBox1.AppendText("놓치는 과일에 대해서는 점수 차감이 정상적으로 이루어 집니다.\n");
            textBox1.AppendText("-두 키를 동시에 누를 경우 키가 무시될 수 있습니다.\n");
            textBox1.AppendText("-----------------------------------------------------\n");
            textBox1.AppendText("죽었을 때 별 10개를 사용하여 부활할 수 있습니다.(life:3)");
        }
    }
}
