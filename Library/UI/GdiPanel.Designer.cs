﻿namespace XLibrary
{
    partial class GdiPanel
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
            this.SuspendLayout();
            // 
            // TreePanelGdiPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TreePanelGdiPlus";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TreePanel_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreePanel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TreePanel_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreePanelGdiPlus_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreePanelGdiPlus_MouseDown);
            this.MouseLeave += new System.EventHandler(this.TreePanel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreePanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreePanelGdiPlus_MouseUp);
            this.Resize += new System.EventHandler(this.TreePanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
