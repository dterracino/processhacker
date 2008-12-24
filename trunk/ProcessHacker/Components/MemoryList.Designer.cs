﻿namespace ProcessHacker
{
    partial class MemoryList
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
            this.listMemory = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnAddress = new System.Windows.Forms.ColumnHeader();
            this.columnSize = new System.Windows.Forms.ColumnHeader();
            this.columnProtection = new System.Windows.Forms.ColumnHeader();
            this.vistaMenu = new wyDay.Controls.VistaMenu(this.components);
            this.changeMemoryProtectionMemoryMenuItem = new System.Windows.Forms.MenuItem();
            this.readWriteMemoryMemoryMenuItem = new System.Windows.Forms.MenuItem();
            this.readWriteAddressMemoryMenuItem = new System.Windows.Forms.MenuItem();
            this.copyMemoryMenuItem = new System.Windows.Forms.MenuItem();
            this.menuMemory = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.selectAllMemoryMenuItem = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // listMemory
            // 
            this.listMemory.AllowColumnReorder = true;
            this.listMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAddress,
            this.columnSize,
            this.columnProtection});
            this.listMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMemory.FullRowSelect = true;
            this.listMemory.HideSelection = false;
            this.listMemory.Location = new System.Drawing.Point(0, 0);
            this.listMemory.Name = "listMemory";
            this.listMemory.ShowItemToolTips = true;
            this.listMemory.Size = new System.Drawing.Size(450, 472);
            this.listMemory.TabIndex = 3;
            this.listMemory.UseCompatibleStateImageBehavior = false;
            this.listMemory.View = System.Windows.Forms.View.Details;
            this.listMemory.DoubleClick += new System.EventHandler(this.listMemory_DoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 160;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 80;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            // 
            // columnProtection
            // 
            this.columnProtection.Text = "Protection";
            this.columnProtection.Width = 120;
            // 
            // vistaMenu
            // 
            this.vistaMenu.ContainerControl = this;
            // 
            // changeMemoryProtectionMemoryMenuItem
            // 
            this.vistaMenu.SetImage(this.changeMemoryProtectionMemoryMenuItem, global::ProcessHacker.Properties.Resources.lock_edit);
            this.changeMemoryProtectionMemoryMenuItem.Index = 0;
            this.changeMemoryProtectionMemoryMenuItem.Text = "Change &Memory Protection...";
            this.changeMemoryProtectionMemoryMenuItem.Click += new System.EventHandler(this.changeMemoryProtectionMemoryMenuItem_Click);
            // 
            // readWriteMemoryMemoryMenuItem
            // 
            this.readWriteMemoryMemoryMenuItem.DefaultItem = true;
            this.vistaMenu.SetImage(this.readWriteMemoryMemoryMenuItem, global::ProcessHacker.Properties.Resources.page_edit);
            this.readWriteMemoryMemoryMenuItem.Index = 1;
            this.readWriteMemoryMemoryMenuItem.Text = "Read/Write Memory...";
            this.readWriteMemoryMemoryMenuItem.Click += new System.EventHandler(this.readWriteMemoryMemoryMenuItem_Click);
            // 
            // readWriteAddressMemoryMenuItem
            // 
            this.vistaMenu.SetImage(this.readWriteAddressMemoryMenuItem, global::ProcessHacker.Properties.Resources.pencil_go);
            this.readWriteAddressMemoryMenuItem.Index = 2;
            this.readWriteAddressMemoryMenuItem.Text = "Read/Write Address...";
            this.readWriteAddressMemoryMenuItem.Click += new System.EventHandler(this.readWriteAddressMemoryMenuItem_Click);
            // 
            // copyMemoryMenuItem
            // 
            this.vistaMenu.SetImage(this.copyMemoryMenuItem, global::ProcessHacker.Properties.Resources.page_copy);
            this.copyMemoryMenuItem.Index = 4;
            this.copyMemoryMenuItem.Text = "C&opy";
            // 
            // menuMemory
            // 
            this.menuMemory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.changeMemoryProtectionMemoryMenuItem,
            this.readWriteMemoryMemoryMenuItem,
            this.readWriteAddressMemoryMenuItem,
            this.menuItem2,
            this.copyMemoryMenuItem,
            this.selectAllMemoryMenuItem});
            this.menuMemory.Popup += new System.EventHandler(this.menuMemory_Popup);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // selectAllMemoryMenuItem
            // 
            this.selectAllMemoryMenuItem.Index = 5;
            this.selectAllMemoryMenuItem.Text = "Select &All";
            this.selectAllMemoryMenuItem.Click += new System.EventHandler(this.selectAllMemoryMenuItem_Click);
            // 
            // MemoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMemory);
            this.DoubleBuffered = true;
            this.Name = "MemoryList";
            this.Size = new System.Drawing.Size(450, 472);
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMemory;
        private System.Windows.Forms.ColumnHeader columnName;
        private wyDay.Controls.VistaMenu vistaMenu;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnProtection;
        private System.Windows.Forms.ContextMenu menuMemory;
        private System.Windows.Forms.MenuItem changeMemoryProtectionMemoryMenuItem;
        private System.Windows.Forms.MenuItem readWriteMemoryMemoryMenuItem;
        private System.Windows.Forms.MenuItem readWriteAddressMemoryMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem copyMemoryMenuItem;
        private System.Windows.Forms.MenuItem selectAllMemoryMenuItem;
    }
}
