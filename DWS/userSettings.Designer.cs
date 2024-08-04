namespace LoBridge
{
    partial class userSettings
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
            System.Windows.Forms.Label uNameLabel;
            System.Windows.Forms.Label uLoginLabel;
            System.Windows.Forms.Label uPassLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobileLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSettings));
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uNameTextBox = new System.Windows.Forms.TextBox();
            this.uLoginTextBox = new System.Windows.Forms.TextBox();
            this.uPassTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new LoBridge.DLWSDataSetTableAdapters.UsersTableAdapter();
            this.ExitBtn = new System.Windows.Forms.Button();
            uNameLabel = new System.Windows.Forms.Label();
            uLoginLabel = new System.Windows.Forms.Label();
            uPassLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uNameLabel
            // 
            uNameLabel.AutoSize = true;
            uNameLabel.Location = new System.Drawing.Point(92, 58);
            uNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uNameLabel.Name = "uNameLabel";
            uNameLabel.Size = new System.Drawing.Size(56, 19);
            uNameLabel.TabIndex = 1;
            uNameLabel.Text = "الاسم:";
            // 
            // uLoginLabel
            // 
            uLoginLabel.AutoSize = true;
            uLoginLabel.Location = new System.Drawing.Point(51, 96);
            uLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uLoginLabel.Name = "uLoginLabel";
            uLoginLabel.Size = new System.Drawing.Size(97, 19);
            uLoginLabel.TabIndex = 3;
            uLoginLabel.Text = "اسم الدخول:";
            // 
            // uPassLabel
            // 
            uPassLabel.AutoSize = true;
            uPassLabel.Location = new System.Drawing.Point(62, 139);
            uPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uPassLabel.Name = "uPassLabel";
            uPassLabel.Size = new System.Drawing.Size(86, 19);
            uPassLabel.TabIndex = 5;
            uPassLabel.Text = "كلمة المرور";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(19, 172);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(129, 19);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "البريد الاليكتروني:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(85, 207);
            mobileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(63, 19);
            mobileLabel.TabIndex = 17;
            mobileLabel.Text = "الموبيل:";
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = null;
            this.usersBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = null;
            this.usersBindingNavigator.DeleteItem = null;
            this.usersBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = null;
            this.usersBindingNavigator.MoveLastItem = null;
            this.usersBindingNavigator.MoveNextItem = null;
            this.usersBindingNavigator.MovePreviousItem = null;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.usersBindingNavigator.PositionItem = null;
            this.usersBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dLWSDataSet;
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // uNameTextBox
            // 
            this.uNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UName", true));
            this.uNameTextBox.Location = new System.Drawing.Point(156, 58);
            this.uNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uNameTextBox.Name = "uNameTextBox";
            this.uNameTextBox.Size = new System.Drawing.Size(298, 27);
            this.uNameTextBox.TabIndex = 2;
            // 
            // uLoginTextBox
            // 
            this.uLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ULogin", true));
            this.uLoginTextBox.Location = new System.Drawing.Point(156, 96);
            this.uLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uLoginTextBox.Name = "uLoginTextBox";
            this.uLoginTextBox.Size = new System.Drawing.Size(298, 27);
            this.uLoginTextBox.TabIndex = 4;
            // 
            // uPassTextBox
            // 
            this.uPassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UPass", true));
            this.uPassTextBox.Location = new System.Drawing.Point(156, 134);
            this.uPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uPassTextBox.Name = "uPassTextBox";
            this.uPassTextBox.Size = new System.Drawing.Size(298, 27);
            this.uPassTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(156, 169);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(298, 27);
            this.emailTextBox.TabIndex = 16;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(156, 207);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(298, 27);
            this.mobileTextBox.TabIndex = 18;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(598, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(46, 41);
            this.ExitBtn.TabIndex = 114;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 314);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(uNameLabel);
            this.Controls.Add(this.uNameTextBox);
            this.Controls.Add(uLoginLabel);
            this.Controls.Add(this.uLoginTextBox);
            this.Controls.Add(uPassLabel);
            this.Controls.Add(this.uPassTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.usersBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "userSettings";
            this.Load += new System.EventHandler(this.userSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DLWSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox uNameTextBox;
        private System.Windows.Forms.TextBox uLoginTextBox;
        private System.Windows.Forms.TextBox uPassTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Button ExitBtn;
    }
}