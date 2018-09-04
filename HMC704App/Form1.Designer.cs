using HMC704ControlLib;

namespace HMC704App
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
            this.hmC704LP4EControl1 = new HMC704ControlLib.HMC704LP4EControl();
            this.SuspendLayout();
            // 
            // hmC704LP4EControl1
            // 
            this.hmC704LP4EControl1.BackColor = System.Drawing.Color.White;
            this.hmC704LP4EControl1.Location = new System.Drawing.Point(0, 12);
            this.hmC704LP4EControl1.Name = "hmC704LP4EControl1";
            this.hmC704LP4EControl1.Size = new System.Drawing.Size(910, 572);
            this.hmC704LP4EControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 587);
            this.Controls.Add(this.hmC704LP4EControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HMC704LP4EControl hmC704LP4EControl1;
    }
}

