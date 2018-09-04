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
            this.hmC703LP4EControl1 = new HMC704ControlLib.HMC703LP4EControl();
            this.SuspendLayout();
            // 
            // hmC703LP4EControl1
            // 
            this.hmC703LP4EControl1.BackColor = System.Drawing.Color.White;
            this.hmC703LP4EControl1.Location = new System.Drawing.Point(-12, -8);
            this.hmC703LP4EControl1.Name = "hmC703LP4EControl1";
            this.hmC703LP4EControl1.Size = new System.Drawing.Size(793, 572);
            this.hmC703LP4EControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.hmC703LP4EControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HMC704ControlLib.HMC703LP4EControl hmC703LP4EControl1;
    }
}

