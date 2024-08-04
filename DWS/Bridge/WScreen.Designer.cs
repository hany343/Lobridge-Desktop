namespace LoBridge
{
    partial class WScreen
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
            this.Screen1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Screen1
            // 
            this.Screen1.BackColor = System.Drawing.Color.Black;
            this.Screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen1.Font = new System.Drawing.Font("DigifaceWide", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen1.ForeColor = System.Drawing.Color.Green;
            this.Screen1.Location = new System.Drawing.Point(0, 0);
            this.Screen1.MaximumSize = new System.Drawing.Size(449, 125);
            this.Screen1.MaxLength = 6;
            this.Screen1.Name = "Screen1";
            this.Screen1.ReadOnly = true;
            this.Screen1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Screen1.Size = new System.Drawing.Size(449, 125);
            this.Screen1.TabIndex = 11;
            this.Screen1.Text = "000000";
            this.Screen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Screen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Screen1_KeyPress);
            this.Screen1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Screen1_MouseDoubleClick);
            // 
            // WScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(449, 124);
            this.Controls.Add(this.Screen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(449, 124);
            this.Name = "WScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "WScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WScreen_FormClosed);
            this.Load += new System.EventHandler(this.WScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Screen1;
        private System.Windows.Forms.Timer timer1;
    }
}