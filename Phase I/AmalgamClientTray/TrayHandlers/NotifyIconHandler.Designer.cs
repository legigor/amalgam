﻿namespace AmalgamClientTray.TrayHandlers
{
   partial class NotifyIconHandler
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconHandler));
         this.rightClickContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.managementApp = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
         this.rightClickContextMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // rightClickContextMenu
         // 
         this.rightClickContextMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rightClickContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.rightClickContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementApp,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
         this.rightClickContextMenu.Name = "rightClickContextMenu";
         this.rightClickContextMenu.Size = new System.Drawing.Size(200, 92);
         // 
         // managementApp
         // 
         this.managementApp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.managementApp.Image = ((System.Drawing.Image)(resources.GetObject("managementApp.Image")));
         this.managementApp.Name = "managementApp";
         this.managementApp.Size = new System.Drawing.Size(199, 30);
         this.managementApp.Text = "&Management App..";
         this.managementApp.Click += new System.EventHandler(this.managementApp_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
         this.exitToolStripMenuItem.Text = "&Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // notifyIcon1
         // 
         this.notifyIcon1.ContextMenuStrip = this.rightClickContextMenu;
         this.notifyIcon1.Text = "Liquesce Starting up";
         this.notifyIcon1.Visible = true;
         this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
         // 
         // NotifyIconHandler
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "NotifyIconHandler";
         this.Size = new System.Drawing.Size(175, 162);
         this.rightClickContextMenu.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ContextMenuStrip rightClickContextMenu;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      internal System.Windows.Forms.NotifyIcon notifyIcon1;
      private System.Windows.Forms.ToolStripMenuItem managementApp;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
   }
}
