
namespace Exercise2RobotControl
{
    partial class Robot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMeaning = new System.Windows.Forms.Label();
            this.panelStop = new System.Windows.Forms.Panel();
            this.panelWait = new System.Windows.Forms.Panel();
            this.panelGo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Location = new System.Drawing.Point(106, 38);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(0, 25);
            this.lblMeaning.TabIndex = 0;
            // 
            // panelStop
            // 
            this.panelStop.Location = new System.Drawing.Point(30, 103);
            this.panelStop.Name = "panelStop";
            this.panelStop.Size = new System.Drawing.Size(233, 176);
            this.panelStop.TabIndex = 1;
            // 
            // panelWait
            // 
            this.panelWait.Location = new System.Drawing.Point(30, 315);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(233, 176);
            this.panelWait.TabIndex = 2;
            // 
            // panelGo
            // 
            this.panelGo.Location = new System.Drawing.Point(30, 533);
            this.panelGo.Name = "panelGo";
            this.panelGo.Size = new System.Drawing.Size(233, 176);
            this.panelGo.TabIndex = 3;
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGo);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.panelStop);
            this.Controls.Add(this.lblMeaning);
            this.Name = "Robot";
            this.Size = new System.Drawing.Size(299, 750);
            this.Load += new System.EventHandler(this.Robot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Panel panelStop;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.Panel panelGo;
    }
}
