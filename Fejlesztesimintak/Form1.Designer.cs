
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
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(811, 422);
            this.mainPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(811, 422);
            this.Controls.Add(this.mainPanel1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Timer createTimer;
        public System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Panel mainPanel1;
    }
}

