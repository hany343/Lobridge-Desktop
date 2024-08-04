namespace LoBridge
{
    partial class ShipAddress
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveAddressBtn = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 84);
            this.textBox1.TabIndex = 0;
            // 
            // SaveAddressBtn
            // 
            this.SaveAddressBtn.Location = new System.Drawing.Point(403, 90);
            this.SaveAddressBtn.Name = "SaveAddressBtn";
            this.SaveAddressBtn.Size = new System.Drawing.Size(142, 23);
            this.SaveAddressBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaveAddressBtn.TabIndex = 1;
            this.SaveAddressBtn.Text = "حفظ العنوان";
            this.SaveAddressBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SaveAddressBtn.Click += new System.EventHandler(this.SaveAddressBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "الإسكندرية",
            "الإسماعيلية",
            "أسوان",
            "أسيوط",
            "الأقصر",
            "البحر الأحمر",
            "البحيرة",
            "بني سويف",
            "بورسعيد",
            "جنوب سيناء",
            "الجيزة",
            "الدقهلية",
            "دمياط",
            "سوهاج",
            "السويس",
            "الشرقية",
            "شمال سيناء",
            "الغربية",
            "الفيوم",
            "القاهرة",
            "القليوبية",
            "قنا",
            "كفر الشيخ",
            "مطروح",
            "المنوفية",
            "المنيا",
            "الوادي الجديد"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "الإسكندرية",
            "الإسماعيلية",
            "أسوان",
            "أسيوط",
            "الأقصر",
            "البحر الأحمر",
            "البحيرة",
            "بني سويف",
            "بورسعيد",
            "جنوب سيناء",
            "الجيزة",
            "الدقهلية",
            "دمياط",
            "سوهاج",
            "السويس",
            "الشرقية",
            "شمال سيناء",
            "الغربية",
            "الفيوم",
            "القاهرة",
            "القليوبية",
            "قنا",
            "كفر الشيخ",
            "مطروح",
            "المنوفية",
            "المنيا",
            "الوادي الجديد"});
            this.comboBox1.Location = new System.Drawing.Point(67, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "المحافظة:";
            // 
            // ShipAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveAddressBtn);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipAddress";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عنوان جهة الوصول";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShipAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton SaveAddressBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}