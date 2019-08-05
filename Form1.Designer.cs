namespace Toss
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.addTeamsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectGroupContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.backContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamsMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Команди";
            // 
            // addTeamsMenuItem
            // 
            this.addTeamsMenuItem.Name = "addTeamsMenuItem";
            this.addTeamsMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addTeamsMenuItem.Text = "Завантажити ...";
            this.addTeamsMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Вихід";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupQuantityToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // groupQuantityToolStripMenuItem
            // 
            this.groupQuantityToolStripMenuItem.Name = "groupQuantityToolStripMenuItem";
            this.groupQuantityToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.groupQuantityToolStripMenuItem.Text = "Кількість груп";
            this.groupQuantityToolStripMenuItem.Click += new System.EventHandler(this.GroupQuantityToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupsLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.teamsListBox);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 663);
            this.splitContainer1.SplitterDistance = 835;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupsLayoutPanel
            // 
            this.groupsLayoutPanel.ColumnCount = 1;
            this.groupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.groupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.groupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.groupsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.groupsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.groupsLayoutPanel.Name = "groupsLayoutPanel";
            this.groupsLayoutPanel.RowCount = 1;
            this.groupsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupsLayoutPanel.Size = new System.Drawing.Size(835, 663);
            this.groupsLayoutPanel.TabIndex = 0;
            // 
            // teamsListBox
            // 
            this.teamsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsListBox.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamsListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 25;
            this.teamsListBox.Location = new System.Drawing.Point(0, 0);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(332, 663);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TeamsListBox_MouseUp);
            // 
            // addTeamsOpenFileDialog
            // 
            this.addTeamsOpenFileDialog.Filter = "Текстові файли|*.txt";
            this.addTeamsOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.AddTeamsOpenFileDialog_FileOk);
            // 
            // selectGroupContextMenu
            // 
            this.selectGroupContextMenu.Name = "selectGroupContextMenu";
            this.selectGroupContextMenu.Size = new System.Drawing.Size(61, 4);
            this.selectGroupContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SelectGroupContextMenu_ItemClicked);
            // 
            // backContextMenu
            // 
            this.backContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBack});
            this.backContextMenu.Name = "backContextMenu";
            this.backContextMenu.Size = new System.Drawing.Size(181, 48);
            this.backContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BackContextMenu_ItemClicked);
            // 
            // toolStripMenuItemBack
            // 
            this.toolStripMenuItemBack.Name = "toolStripMenuItemBack";
            this.toolStripMenuItemBack.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBack.Text = "Повернути";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 687);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Жеребкування";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.backContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTeamsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupQuantityToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.OpenFileDialog addTeamsOpenFileDialog;
        private System.Windows.Forms.TableLayoutPanel groupsLayoutPanel;
        private System.Windows.Forms.ContextMenuStrip selectGroupContextMenu;
        private System.Windows.Forms.ContextMenuStrip backContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBack;
    }
}

