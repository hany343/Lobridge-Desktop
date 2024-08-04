﻿using LoBridge.DLWSDataSetTableAdapters;
using LoBridge.OutdatasetTableAdapters;

namespace LoBridge
{
    partial class OUTPrint_Loadingcard
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lcacrd1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.lcacrd1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.LadidBox = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oUTDataset = new LoBridge.Outdataset();
            this.lcacrd1TableAdapter = new LoBridge.OutdatasetTableAdapters.Lcacrd1TableAdapter();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingNavigator)).BeginInit();
            this.lcacrd1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 42);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1095, 1002);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lcacrd1BindingNavigator
            // 
            this.lcacrd1BindingNavigator.AddNewItem = null;
            this.lcacrd1BindingNavigator.BindingSource = this.lcacrd1BindingSource;
            this.lcacrd1BindingNavigator.CountItem = null;
            this.lcacrd1BindingNavigator.DeleteItem = null;
            this.lcacrd1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LadidBox,
            this.bindingNavigatorSeparator,
            this.toolStripButton1});
            this.lcacrd1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lcacrd1BindingNavigator.MoveFirstItem = null;
            this.lcacrd1BindingNavigator.MoveLastItem = null;
            this.lcacrd1BindingNavigator.MoveNextItem = null;
            this.lcacrd1BindingNavigator.MovePreviousItem = null;
            this.lcacrd1BindingNavigator.Name = "lcacrd1BindingNavigator";
            this.lcacrd1BindingNavigator.PositionItem = null;
            this.lcacrd1BindingNavigator.Size = new System.Drawing.Size(1095, 42);
            this.lcacrd1BindingNavigator.TabIndex = 3;
            this.lcacrd1BindingNavigator.Text = "bindingNavigator1";
            // 
            // LadidBox
            // 
            this.LadidBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LadidBox.Name = "LadidBox";
            this.LadidBox.Size = new System.Drawing.Size(100, 42);
            this.LadidBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadidBox_KeyDown);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.refresh;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 39);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // oUTDataset
            // 
            this.oUTDataset.CaseSensitive = true;
            this.oUTDataset.DataSetName = "DLWSDataSet";
            this.oUTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lcacrd1TableAdapter
            // 
            this.lcacrd1TableAdapter.ClearBeforeFill = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(1056, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 36);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OUTPrint_Loadingcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1094, 1061);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lcacrd1BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OUTPrint_Loadingcard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Print_Lcard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Print_Lcard_FormClosing);
            this.Load += new System.EventHandler(this.Print_Lcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingNavigator)).EndInit();
            this.lcacrd1BindingNavigator.ResumeLayout(false);
            this.lcacrd1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.BindingSource lcacrd1BindingSource;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private System.Windows.Forms.BindingNavigator lcacrd1BindingNavigator;
        private System.Windows.Forms.ToolStripTextBox LadidBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Outdataset oUTDataset;
        private Lcacrd1TableAdapter lcacrd1TableAdapter;
        private System.Windows.Forms.Button ExitBtn;
    }
}