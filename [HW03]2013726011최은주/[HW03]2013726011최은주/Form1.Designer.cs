namespace _HW03_2013726011최은주
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fast = new System.Windows.Forms.Button();
            this.slow = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.redRabbit = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.rabbit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redRabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.fast);
            this.groupBox1.Controls.Add(this.slow);
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Controls.Add(this.score);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.star);
            this.groupBox1.Controls.Add(this.life);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State Box";
            // 
            // fast
            // 
            this.fast.Location = new System.Drawing.Point(249, 133);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(37, 42);
            this.fast.TabIndex = 13;
            this.fast.Text = ">";
            this.fast.UseVisualStyleBackColor = true;
            this.fast.Click += new System.EventHandler(this.fast_Click);
            // 
            // slow
            // 
            this.slow.Location = new System.Drawing.Point(195, 133);
            this.slow.Name = "slow";
            this.slow.Size = new System.Drawing.Size(37, 42);
            this.slow.TabIndex = 3;
            this.slow.Text = "<";
            this.slow.UseVisualStyleBackColor = true;
            this.slow.Click += new System.EventHandler(this.slow_Click);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(118, 238);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(30, 30);
            this.level.TabIndex = 12;
            this.level.Text = "1";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(135, 193);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(30, 30);
            this.score.TabIndex = 11;
            this.score.Text = "0";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(135, 145);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(47, 30);
            this.speed.TabIndex = 10;
            this.speed.Text = "25";
            // 
            // star
            // 
            this.star.AutoSize = true;
            this.star.Location = new System.Drawing.Point(111, 102);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(30, 30);
            this.star.TabIndex = 9;
            this.star.Text = "0";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Location = new System.Drawing.Point(106, 56);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(47, 30);
            this.life.TabIndex = 8;
            this.life.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Star :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Life :";
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(34, 788);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(279, 55);
            this.manual.TabIndex = 14;
            this.manual.Text = "Manual";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(34, 868);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(279, 56);
            this.start.TabIndex = 15;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(34, 942);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(279, 58);
            this.exit.TabIndex = 16;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "f_apple.png");
            this.imageList1.Images.SetKeyName(1, "f_bomb.png");
            this.imageList1.Images.SetKeyName(2, "f_cherry.png");
            this.imageList1.Images.SetKeyName(3, "f_grapes.png");
            this.imageList1.Images.SetKeyName(4, "f_heart.png");
            this.imageList1.Images.SetKeyName(5, "f_kiwi.png");
            this.imageList1.Images.SetKeyName(6, "f_orange.png");
            this.imageList1.Images.SetKeyName(7, "f_pear.png");
            this.imageList1.Images.SetKeyName(8, "f_pineapple.png");
            this.imageList1.Images.SetKeyName(9, "f_star.png");
            this.imageList1.Images.SetKeyName(10, "f_strawberry.png");
            this.imageList1.Images.SetKeyName(11, "f_watermelon.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // redRabbit
            // 
            this.redRabbit.Image = global::_HW03_2013726011최은주.Properties.Resources.화난토끼;
            this.redRabbit.Location = new System.Drawing.Point(417, 811);
            this.redRabbit.Name = "redRabbit";
            this.redRabbit.Size = new System.Drawing.Size(108, 174);
            this.redRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redRabbit.TabIndex = 19;
            this.redRabbit.TabStop = false;
            this.redRabbit.Visible = false;
            // 
            // cloud
            // 
            this.cloud.Image = global::_HW03_2013726011최은주.Properties.Resources.구름;
            this.cloud.Location = new System.Drawing.Point(681, 48);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(154, 131);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud.TabIndex = 18;
            this.cloud.TabStop = false;
            this.cloud.Visible = false;
            // 
            // rabbit
            // 
            this.rabbit.Image = global::_HW03_2013726011최은주.Properties.Resources.토끼;
            this.rabbit.Location = new System.Drawing.Point(417, 812);
            this.rabbit.Name = "rabbit";
            this.rabbit.Size = new System.Drawing.Size(108, 174);
            this.rabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rabbit.TabIndex = 17;
            this.rabbit.TabStop = false;
            this.rabbit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rabbit_PreviewKeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::_HW03_2013726011최은주.Properties.Resources.초원;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(349, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1141, 1218);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_HW03_2013726011최은주.Properties.Resources.왼쪽;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 1218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1490, 1218);
            this.Controls.Add(this.redRabbit);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.rabbit);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redRabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fast;
        private System.Windows.Forms.Button slow;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label star;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox rabbit;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox redRabbit;
    }
}

