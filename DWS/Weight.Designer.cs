namespace DWS
{
    partial class Weight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weight));
            this.btnInWeight = new System.Windows.Forms.Button();
            this.btnOutWeight = new System.Windows.Forms.Button();
            this.btnGWeight = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInWeight
            // 
            resources.ApplyResources(this.btnInWeight, "btnInWeight");
            this.btnInWeight.Name = "btnInWeight";
            this.btnInWeight.UseVisualStyleBackColor = true;
            this.btnInWeight.Click += new System.EventHandler(this.btnInWeight_Click);
            // 
            // btnOutWeight
            // 
            resources.ApplyResources(this.btnOutWeight, "btnOutWeight");
            this.btnOutWeight.Name = "btnOutWeight";
            this.btnOutWeight.UseVisualStyleBackColor = true;
            this.btnOutWeight.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGWeight
            // 
            resources.ApplyResources(this.btnGWeight, "btnGWeight");
            this.btnGWeight.Name = "btnGWeight";
            this.btnGWeight.UseVisualStyleBackColor = true;
            this.btnGWeight.Click += new System.EventHandler(this.btnGWeight_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Name = "panel1";
            // 
            // Weight
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGWeight);
            this.Controls.Add(this.btnOutWeight);
            this.Controls.Add(this.btnInWeight);
            this.Name = "Weight";
            this.Load += new System.EventHandler(this.Weight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInWeight;
        private System.Windows.Forms.Button btnOutWeight;
        private System.Windows.Forms.Button btnGWeight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}