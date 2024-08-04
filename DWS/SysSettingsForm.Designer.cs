namespace LoBridge
{
    partial class SysSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combutton5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.areacodetextBox1 = new System.Windows.Forms.TextBox();
            this.comtextBox2 = new System.Windows.Forms.TextBox();
            this.bridgetextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الميزان";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(503, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "حفظ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "كود كاميرا ميزان الدخول:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(503, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "كود كاميرا ميزان الخروج:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "اسم مخرج Com";
            // 
            // combutton5
            // 
            this.combutton5.BackColor = System.Drawing.SystemColors.Control;
            this.combutton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combutton5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combutton5.Location = new System.Drawing.Point(503, 185);
            this.combutton5.Name = "combutton5";
            this.combutton5.Size = new System.Drawing.Size(63, 28);
            this.combutton5.TabIndex = 2;
            this.combutton5.Text = "حفظ";
            this.combutton5.UseVisualStyleBackColor = false;
            this.combutton5.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "outwcam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(298, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = global::LoBridge.Properties.Settings.Default.outwcam;
            // 
            // areacodetextBox1
            // 
            this.areacodetextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "inwcam", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.areacodetextBox1.Location = new System.Drawing.Point(298, 84);
            this.areacodetextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.areacodetextBox1.Name = "areacodetextBox1";
            this.areacodetextBox1.Size = new System.Drawing.Size(197, 38);
            this.areacodetextBox1.TabIndex = 4;
            this.areacodetextBox1.Text = global::LoBridge.Properties.Settings.Default.inwcam;
            // 
            // comtextBox2
            // 
            this.comtextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "serialcom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comtextBox2.Location = new System.Drawing.Point(298, 178);
            this.comtextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comtextBox2.Name = "comtextBox2";
            this.comtextBox2.Size = new System.Drawing.Size(197, 38);
            this.comtextBox2.TabIndex = 0;
            this.comtextBox2.Text = global::LoBridge.Properties.Settings.Default.serialcom;
            // 
            // bridgetextBox1
            // 
            this.bridgetextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "WBridge", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bridgetextBox1.Location = new System.Drawing.Point(298, 37);
            this.bridgetextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bridgetextBox1.Name = "bridgetextBox1";
            this.bridgetextBox1.Size = new System.Drawing.Size(197, 38);
            this.bridgetextBox1.TabIndex = 0;
            this.bridgetextBox1.Text = global::LoBridge.Properties.Settings.Default.WBridge;
            // 
            // SysSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(781, 344);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areacodetextBox1);
            this.Controls.Add(this.combutton5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comtextBox2);
            this.Controls.Add(this.bridgetextBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "SysSettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اعدادات البرنامج";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bridgetextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areacodetextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox comtextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button combutton5;
    }
}