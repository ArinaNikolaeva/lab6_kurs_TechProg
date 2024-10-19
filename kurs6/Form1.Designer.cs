namespace kurs6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            ldlDirection = new Label();
            ldlSpreading = new Label();
            tbSpreading = new TrackBar();
            ldlSpeed = new Label();
            tbSpeed = new TrackBar();
            ldlParticlesPerTick = new Label();
            tbParticlesPerTick = new TrackBar();
            ldlLife = new Label();
            tbLife = new TrackBar();
            ldlParticlesCount = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(1099, 704);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(841, 30);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(270, 45);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += tbDirection_Scroll;
            // 
            // ldlDirection
            // 
            ldlDirection.AutoSize = true;
            ldlDirection.Location = new Point(841, 12);
            ldlDirection.Name = "ldlDirection";
            ldlDirection.Size = new Size(81, 15);
            ldlDirection.TabIndex = 2;
            ldlDirection.Text = "Направление";
            // 
            // ldlSpreading
            // 
            ldlSpreading.AutoSize = true;
            ldlSpreading.Location = new Point(841, 78);
            ldlSpreading.Name = "ldlSpreading";
            ldlSpreading.Size = new Size(52, 15);
            ldlSpreading.TabIndex = 3;
            ldlSpreading.Text = "Разброс";
            // 
            // tbSpreading
            // 
            tbSpreading.Location = new Point(841, 96);
            tbSpreading.Maximum = 359;
            tbSpreading.Name = "tbSpreading";
            tbSpreading.Size = new Size(270, 45);
            tbSpreading.TabIndex = 4;
            tbSpreading.Scroll += tbSpreading_Scroll;
            // 
            // ldlSpeed
            // 
            ldlSpeed.AutoSize = true;
            ldlSpeed.Location = new Point(841, 144);
            ldlSpeed.Name = "ldlSpeed";
            ldlSpeed.Size = new Size(59, 15);
            ldlSpeed.TabIndex = 5;
            ldlSpeed.Text = "Скорость";
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(841, 162);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(270, 45);
            tbSpeed.TabIndex = 6;
            tbSpeed.Value = 1;
            tbSpeed.Scroll += tdSpeed_Scroll;
            // 
            // ldlParticlesPerTick
            // 
            ldlParticlesPerTick.AutoSize = true;
            ldlParticlesPerTick.Location = new Point(841, 210);
            ldlParticlesPerTick.Name = "ldlParticlesPerTick";
            ldlParticlesPerTick.Size = new Size(117, 15);
            ldlParticlesPerTick.TabIndex = 7;
            ldlParticlesPerTick.Text = "Кол-во частиц в тик";
            // 
            // tbParticlesPerTick
            // 
            tbParticlesPerTick.Location = new Point(841, 228);
            tbParticlesPerTick.Minimum = 1;
            tbParticlesPerTick.Name = "tbParticlesPerTick";
            tbParticlesPerTick.Size = new Size(270, 45);
            tbParticlesPerTick.TabIndex = 8;
            tbParticlesPerTick.Value = 1;
            tbParticlesPerTick.Scroll += tbParticlesPerTick_Scroll;
            // 
            // ldlLife
            // 
            ldlLife.AutoSize = true;
            ldlLife.Location = new Point(841, 276);
            ldlLife.Name = "ldlLife";
            ldlLife.Size = new Size(159, 15);
            ldlLife.TabIndex = 9;
            ldlLife.Text = "Продолжительность жизни";
            // 
            // tbLife
            // 
            tbLife.Location = new Point(841, 294);
            tbLife.Maximum = 100;
            tbLife.Minimum = 20;
            tbLife.Name = "tbLife";
            tbLife.Size = new Size(270, 45);
            tbLife.TabIndex = 10;
            tbLife.Value = 20;
            tbLife.Scroll += tbLife_Scroll;
            // 
            // ldlParticlesCount
            // 
            ldlParticlesCount.AutoSize = true;
            ldlParticlesCount.Location = new Point(841, 342);
            ldlParticlesCount.Name = "ldlParticlesCount";
            ldlParticlesCount.Size = new Size(113, 15);
            ldlParticlesCount.TabIndex = 11;
            ldlParticlesCount.Text = "Количество частиц";
            ldlParticlesCount.Click += ldlParticlesCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1123, 728);
            Controls.Add(ldlParticlesCount);
            Controls.Add(tbLife);
            Controls.Add(ldlLife);
            Controls.Add(tbParticlesPerTick);
            Controls.Add(ldlParticlesPerTick);
            Controls.Add(tbSpeed);
            Controls.Add(ldlSpeed);
            Controls.Add(tbSpreading);
            Controls.Add(ldlSpreading);
            Controls.Add(ldlDirection);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1_Tick;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picDisplay;
        private TrackBar tbDirection;
        private Label ldlDirection;
        private Label ldlSpreading;
        private TrackBar tbSpreading;
        private Label ldlSpeed;
        private TrackBar tbSpeed;
        private Label ldlParticlesPerTick;
        private TrackBar tbParticlesPerTick;
        private Label ldlLife;
        private TrackBar tbLife;
        private Label ldlParticlesCount;
    }
}
