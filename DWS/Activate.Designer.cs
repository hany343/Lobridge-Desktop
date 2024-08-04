namespace LoBridge
{
    partial class Activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activation));
            this.notpanel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keys = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Codetextbox = new System.Windows.Forms.TextBox();
            this.notpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notpanel1
            // 
            this.notpanel1.AutoSize = true;
            this.notpanel1.Controls.Add(this.button3);
            this.notpanel1.Controls.Add(this.label3);
            this.notpanel1.Controls.Add(this.label2);
            this.notpanel1.Controls.Add(this.keys);
            this.notpanel1.Controls.Add(this.date);
            this.notpanel1.Controls.Add(this.label1);
            this.notpanel1.Controls.Add(this.button2);
            this.notpanel1.Controls.Add(this.button1);
            this.notpanel1.Controls.Add(this.Codetextbox);
            this.notpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notpanel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.notpanel1.Location = new System.Drawing.Point(0, 0);
            this.notpanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.notpanel1.Name = "notpanel1";
            this.notpanel1.Size = new System.Drawing.Size(620, 150);
            this.notpanel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 24);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "serial";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "date lic";
            this.label2.Visible = false;
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(455, 101);
            this.keys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(88, 21);
            this.keys.TabIndex = 6;
            this.keys.Visible = false;
            this.keys.TextChanged += new System.EventHandler(this.keys_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(363, 101);
            this.date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(88, 21);
            this.date.TabIndex = 5;
            this.date.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activation Code:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button2.Location = new System.Drawing.Point(188, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Activate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button1.Location = new System.Drawing.Point(277, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Codetextbox
            // 
            this.Codetextbox.Location = new System.Drawing.Point(188, 22);
            this.Codetextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Codetextbox.Multiline = true;
            this.Codetextbox.Name = "Codetextbox";
            this.Codetextbox.Size = new System.Drawing.Size(382, 59);
            this.Codetextbox.TabIndex = 0;
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(620, 150);
            this.Controls.Add(this.notpanel1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Activation";
            this.Text = "Activation required";
            this.Load += new System.EventHandler(this.Activate_Load);
            this.notpanel1.ResumeLayout(false);
            this.notpanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Panel notpanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Codetextbox;
        private System.Windows.Forms.TextBox keys;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}