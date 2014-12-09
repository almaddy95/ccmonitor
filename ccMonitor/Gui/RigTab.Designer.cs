﻿namespace ccMonitor.Gui
{
    partial class RigTab
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
            this.tbcRig = new System.Windows.Forms.TabControl();
            this.tabRigOverview = new System.Windows.Forms.TabPage();
            this.tabRigDebug = new System.Windows.Forms.TabPage();
            this.txtDebugConsole = new System.Windows.Forms.TextBox();
            this.tbcRig.SuspendLayout();
            this.tabRigDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRig
            // 
            this.tbcRig.Controls.Add(this.tabRigOverview);
            this.tbcRig.Controls.Add(this.tabRigDebug);
            this.tbcRig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRig.Location = new System.Drawing.Point(0, 0);
            this.tbcRig.Name = "tbcRig";
            this.tbcRig.SelectedIndex = 0;
            this.tbcRig.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.TabIndex = 0;
            // 
            // tabRigOverview
            // 
            this.tabRigOverview.Location = new System.Drawing.Point(4, 22);
            this.tabRigOverview.Name = "tabRigOverview";
            this.tabRigOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigOverview.Size = new System.Drawing.Size(1168, 560);
            this.tabRigOverview.TabIndex = 0;
            this.tabRigOverview.Text = "Rig overview";
            // 
            // tabRigDebug
            // 
            this.tabRigDebug.Controls.Add(this.txtDebugConsole);
            this.tabRigDebug.Location = new System.Drawing.Point(4, 22);
            this.tabRigDebug.Name = "tabRigDebug";
            this.tabRigDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabRigDebug.Size = new System.Drawing.Size(1168, 560);
            this.tabRigDebug.TabIndex = 1;
            this.tabRigDebug.Text = "Debug console";
            // 
            // txtDebugConsole
            // 
            this.txtDebugConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtDebugConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDebugConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDebugConsole.Location = new System.Drawing.Point(3, 3);
            this.txtDebugConsole.Multiline = true;
            this.txtDebugConsole.Name = "txtDebugConsole";
            this.txtDebugConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugConsole.Size = new System.Drawing.Size(1162, 554);
            this.txtDebugConsole.TabIndex = 0;
            // 
            // RigTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcRig);
            this.Name = "RigTab";
            this.Size = new System.Drawing.Size(1176, 586);
            this.tbcRig.ResumeLayout(false);
            this.tabRigDebug.ResumeLayout(false);
            this.tabRigDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRig;
        private System.Windows.Forms.TabPage tabRigOverview;
        private System.Windows.Forms.TabPage tabRigDebug;
        private System.Windows.Forms.TextBox txtDebugConsole;
    }
}