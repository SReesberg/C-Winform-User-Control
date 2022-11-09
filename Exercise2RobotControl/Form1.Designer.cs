
namespace Exercise2RobotControl
{
    partial class MainForm
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
            this.robot1 = new Exercise2RobotControl.Robot();
            this.robot2 = new Exercise2RobotControl.Robot();
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbWait = new System.Windows.Forms.RadioButton();
            this.rbGo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // robot1
            // 
            this.robot1.Location = new System.Drawing.Point(0, 0);
            this.robot1.Name = "robot1";
            this.robot1.Size = new System.Drawing.Size(299, 750);
            this.robot1.TabIndex = 0;
            // 
            // robot2
            // 
            this.robot2.Location = new System.Drawing.Point(29, 42);
            this.robot2.Name = "robot2";
            this.robot2.Size = new System.Drawing.Size(299, 750);
            this.robot2.TabIndex = 1;
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(435, 154);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(87, 29);
            this.rbStop.TabIndex = 2;
            this.rbStop.TabStop = true;
            this.rbStop.Text = "Stop";
            this.rbStop.UseVisualStyleBackColor = true;
            this.rbStop.CheckedChanged += new System.EventHandler(this.rbStop_CheckedChanged);
            // 
            // rbWait
            // 
            this.rbWait.AutoSize = true;
            this.rbWait.Location = new System.Drawing.Point(435, 189);
            this.rbWait.Name = "rbWait";
            this.rbWait.Size = new System.Drawing.Size(149, 29);
            this.rbWait.TabIndex = 3;
            this.rbWait.TabStop = true;
            this.rbWait.Text = "Slow Down";
            this.rbWait.UseVisualStyleBackColor = true;
            this.rbWait.CheckedChanged += new System.EventHandler(this.rbWait_CheckedChanged);
            // 
            // rbGo
            // 
            this.rbGo.AutoSize = true;
            this.rbGo.Location = new System.Drawing.Point(435, 224);
            this.rbGo.Name = "rbGo";
            this.rbGo.Size = new System.Drawing.Size(71, 29);
            this.rbGo.TabIndex = 4;
            this.rbGo.TabStop = true;
            this.rbGo.Text = "Go";
            this.rbGo.UseVisualStyleBackColor = true;
            this.rbGo.CheckedChanged += new System.EventHandler(this.rbGo_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 986);
            this.Controls.Add(this.rbGo);
            this.Controls.Add(this.rbWait);
            this.Controls.Add(this.rbStop);
            this.Controls.Add(this.robot2);
            this.Controls.Add(this.robot1);
            this.Name = "MainForm";
            this.Text = "My Traffic Robot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Robot robot1;
        private Robot robot2;
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbWait;
        private System.Windows.Forms.RadioButton rbGo;
    }
}

