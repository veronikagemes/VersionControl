
namespace Fejlesztesimintak
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel1 = new System.Windows.Forms.Panel();
            this.car = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.mainPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick_1);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick_1);
            // 
            // mainPanel1
            // 
            this.mainPanel1.Controls.Add(this.lblNext);
            this.mainPanel1.Controls.Add(this.ball);
            this.mainPanel1.Controls.Add(this.car);
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(811, 422);
            this.mainPanel1.TabIndex = 0;
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(68, 126);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(75, 23);
            this.car.TabIndex = 0;
            this.car.Text = "CAR";
            this.car.UseVisualStyleBackColor = true;
            this.car.Click += new System.EventHandler(this.car_Click);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(68, 155);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 23);
            this.ball.TabIndex = 1;
            this.ball.Text = "BALL";
            this.ball.UseVisualStyleBackColor = true;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(54, 191);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(811, 422);
            this.Controls.Add(this.mainPanel1);
            this.Name = "Form1";
            this.mainPanel1.ResumeLayout(false);
            this.mainPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Timer createTimer;
        public System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Panel mainPanel1;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button car;
    }
}

