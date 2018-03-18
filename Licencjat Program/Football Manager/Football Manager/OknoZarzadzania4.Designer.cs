namespace Football_Manager
{
    partial class OknoZarzadzania4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bRozpocznij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRAJ MECZ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bRozpocznij
            // 
            this.bRozpocznij.Location = new System.Drawing.Point(245, 93);
            this.bRozpocznij.Name = "bRozpocznij";
            this.bRozpocznij.Size = new System.Drawing.Size(75, 23);
            this.bRozpocznij.TabIndex = 3;
            this.bRozpocznij.Text = "Rozpocznij";
            this.bRozpocznij.UseVisualStyleBackColor = true;
            this.bRozpocznij.Click += new System.EventHandler(this.bRozpocznij_Click);
            // 
            // OknoZarzadzania4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bRozpocznij);
            this.Controls.Add(this.label1);
            this.Name = "OknoZarzadzania4";
            this.Size = new System.Drawing.Size(566, 546);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bRozpocznij;
    }
}
