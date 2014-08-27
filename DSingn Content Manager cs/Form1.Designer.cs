namespace DSingn_Content_Manager_cs
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTT = new System.Windows.Forms.Panel();
            this.newTtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listTT = new System.Windows.Forms.ComboBox();
            this.menuButtonStat = new System.Windows.Forms.Button();
            this.menuButtonTimetable = new System.Windows.Forms.Button();
            this.menuButtonPlayers = new System.Windows.Forms.Button();
            this.panelContentContainer = new System.Windows.Forms.Panel();
            this.panelPlayersContent = new System.Windows.Forms.Panel();
            this.groupBoxPlayersGroups = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewPlayerGroups = new System.Windows.Forms.TreeView();
            this.savegroups_button = new System.Windows.Forms.Button();
            this.panelTimetable = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filesTabControll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_v = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_i = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_a = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelStat = new System.Windows.Forms.Panel();
            this.pGroupsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переместитьВГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.userFilesListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTT.SuspendLayout();
            this.panelContentContainer.SuspendLayout();
            this.panelPlayersContent.SuspendLayout();
            this.groupBoxPlayersGroups.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelTimetable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.filesTabControll.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.pGroupsContextMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelContentContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 655F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1086, 655);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panelTT);
            this.panel1.Controls.Add(this.menuButtonStat);
            this.panel1.Controls.Add(this.menuButtonTimetable);
            this.panel1.Controls.Add(this.menuButtonPlayers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 655);
            this.panel1.TabIndex = 0;
            // 
            // panelTT
            // 
            this.panelTT.Controls.Add(this.newTtButton);
            this.panelTT.Controls.Add(this.label1);
            this.panelTT.Controls.Add(this.listTT);
            this.panelTT.Location = new System.Drawing.Point(12, 181);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(152, 84);
            this.panelTT.TabIndex = 3;
            this.panelTT.Visible = false;
            // 
            // newTtButton
            // 
            this.newTtButton.Location = new System.Drawing.Point(3, 43);
            this.newTtButton.Name = "newTtButton";
            this.newTtButton.Size = new System.Drawing.Size(146, 23);
            this.newTtButton.TabIndex = 2;
            this.newTtButton.Text = "Новое расписание";
            this.newTtButton.UseVisualStyleBackColor = true;
            this.newTtButton.Click += new System.EventHandler(this.newTtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать расписание:";
            // 
            // listTT
            // 
            this.listTT.FormattingEnabled = true;
            this.listTT.Location = new System.Drawing.Point(3, 16);
            this.listTT.Name = "listTT";
            this.listTT.Size = new System.Drawing.Size(146, 21);
            this.listTT.TabIndex = 0;
            this.listTT.Visible = false;
            this.listTT.SelectedValueChanged += new System.EventHandler(this.ttNameSelected);
            // 
            // menuButtonStat
            // 
            this.menuButtonStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonStat.FlatAppearance.BorderSize = 0;
            this.menuButtonStat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.menuButtonStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonStat.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonStat.ForeColor = System.Drawing.Color.White;
            this.menuButtonStat.Location = new System.Drawing.Point(0, 116);
            this.menuButtonStat.Margin = new System.Windows.Forms.Padding(0);
            this.menuButtonStat.Name = "menuButtonStat";
            this.menuButtonStat.Size = new System.Drawing.Size(170, 58);
            this.menuButtonStat.TabIndex = 2;
            this.menuButtonStat.Text = "Статистика";
            this.menuButtonStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonStat.UseVisualStyleBackColor = true;
            this.menuButtonStat.Click += new System.EventHandler(this.menuButtonStat_Click);
            // 
            // menuButtonTimetable
            // 
            this.menuButtonTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonTimetable.FlatAppearance.BorderSize = 0;
            this.menuButtonTimetable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.menuButtonTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonTimetable.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonTimetable.ForeColor = System.Drawing.Color.White;
            this.menuButtonTimetable.Location = new System.Drawing.Point(0, 58);
            this.menuButtonTimetable.Margin = new System.Windows.Forms.Padding(0);
            this.menuButtonTimetable.Name = "menuButtonTimetable";
            this.menuButtonTimetable.Size = new System.Drawing.Size(170, 58);
            this.menuButtonTimetable.TabIndex = 1;
            this.menuButtonTimetable.Text = "Расписание";
            this.menuButtonTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonTimetable.UseVisualStyleBackColor = true;
            this.menuButtonTimetable.Click += new System.EventHandler(this.menuButtonTimetable_Click);
            // 
            // menuButtonPlayers
            // 
            this.menuButtonPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonPlayers.FlatAppearance.BorderSize = 0;
            this.menuButtonPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.menuButtonPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonPlayers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButtonPlayers.ForeColor = System.Drawing.Color.White;
            this.menuButtonPlayers.Location = new System.Drawing.Point(0, 0);
            this.menuButtonPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.menuButtonPlayers.Name = "menuButtonPlayers";
            this.menuButtonPlayers.Size = new System.Drawing.Size(170, 58);
            this.menuButtonPlayers.TabIndex = 0;
            this.menuButtonPlayers.Text = "Плееры";
            this.menuButtonPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButtonPlayers.UseVisualStyleBackColor = true;
            this.menuButtonPlayers.Click += new System.EventHandler(this.menuButtonPlayers_Click);
            // 
            // panelContentContainer
            // 
            this.panelContentContainer.Controls.Add(this.panelStat);
            this.panelContentContainer.Controls.Add(this.panelPlayersContent);
            this.panelContentContainer.Controls.Add(this.panelTimetable);
            this.panelContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentContainer.Location = new System.Drawing.Point(170, 0);
            this.panelContentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentContainer.Name = "panelContentContainer";
            this.panelContentContainer.Size = new System.Drawing.Size(916, 655);
            this.panelContentContainer.TabIndex = 1;
            // 
            // panelPlayersContent
            // 
            this.panelPlayersContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlayersContent.Controls.Add(this.groupBoxPlayersGroups);
            this.panelPlayersContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayersContent.Location = new System.Drawing.Point(0, 0);
            this.panelPlayersContent.Name = "panelPlayersContent";
            this.panelPlayersContent.Size = new System.Drawing.Size(916, 655);
            this.panelPlayersContent.TabIndex = 0;
            this.panelPlayersContent.Visible = false;
            // 
            // groupBoxPlayersGroups
            // 
            this.groupBoxPlayersGroups.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxPlayersGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPlayersGroups.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPlayersGroups.Name = "groupBoxPlayersGroups";
            this.groupBoxPlayersGroups.Size = new System.Drawing.Size(916, 655);
            this.groupBoxPlayersGroups.TabIndex = 0;
            this.groupBoxPlayersGroups.TabStop = false;
            this.groupBoxPlayersGroups.Text = "Группы Плееров";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.treeViewPlayerGroups, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.savegroups_button, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.59748F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.402516F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(910, 636);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // treeViewPlayerGroups
            // 
            this.treeViewPlayerGroups.AllowDrop = true;
            this.treeViewPlayerGroups.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewPlayerGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewPlayerGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPlayerGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewPlayerGroups.ItemHeight = 16;
            this.treeViewPlayerGroups.Location = new System.Drawing.Point(3, 3);
            this.treeViewPlayerGroups.Name = "treeViewPlayerGroups";
            this.treeViewPlayerGroups.Size = new System.Drawing.Size(904, 601);
            this.treeViewPlayerGroups.TabIndex = 0;
            this.treeViewPlayerGroups.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.pGroups_BeforeLabelEdit);
            this.treeViewPlayerGroups.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.pGroups_AfterLabelEdit);
            this.treeViewPlayerGroups.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPlayerGroups_ItemDrag);
            this.treeViewPlayerGroups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.pGroupsMouseClick);
            this.treeViewPlayerGroups.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewPlayerGroups_DragDrop);
            this.treeViewPlayerGroups.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewPlayerGroups_DragEnter);
            this.treeViewPlayerGroups.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewPlayerGroups_DragOver);
            // 
            // savegroups_button
            // 
            this.savegroups_button.Location = new System.Drawing.Point(3, 610);
            this.savegroups_button.Name = "savegroups_button";
            this.savegroups_button.Size = new System.Drawing.Size(146, 23);
            this.savegroups_button.TabIndex = 0;
            this.savegroups_button.Text = "Сохранить";
            this.savegroups_button.UseVisualStyleBackColor = true;
            this.savegroups_button.Click += new System.EventHandler(this.savegroups_button_Click);
            // 
            // panelTimetable
            // 
            this.panelTimetable.BackColor = System.Drawing.SystemColors.Control;
            this.panelTimetable.Controls.Add(this.tableLayoutPanel2);
            this.panelTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimetable.Location = new System.Drawing.Point(0, 0);
            this.panelTimetable.Name = "panelTimetable";
            this.panelTimetable.Size = new System.Drawing.Size(916, 655);
            this.panelTimetable.TabIndex = 0;
            this.panelTimetable.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.filesTabControll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(916, 655);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // filesTabControll
            // 
            this.filesTabControll.Controls.Add(this.tabPage1);
            this.filesTabControll.Controls.Add(this.tabPage2);
            this.filesTabControll.Controls.Add(this.tabPage3);
            this.filesTabControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTabControll.Location = new System.Drawing.Point(0, 288);
            this.filesTabControll.Margin = new System.Windows.Forms.Padding(0);
            this.filesTabControll.Name = "filesTabControll";
            this.filesTabControll.SelectedIndex = 0;
            this.filesTabControll.Size = new System.Drawing.Size(916, 367);
            this.filesTabControll.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_v);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(908, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видео";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_v
            // 
            this.panel_v.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_v.Location = new System.Drawing.Point(0, 0);
            this.panel_v.Margin = new System.Windows.Forms.Padding(0);
            this.panel_v.Name = "panel_v";
            this.panel_v.Size = new System.Drawing.Size(908, 341);
            this.panel_v.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_i);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(908, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фото";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_i
            // 
            this.panel_i.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_i.Location = new System.Drawing.Point(0, 0);
            this.panel_i.Margin = new System.Windows.Forms.Padding(0);
            this.panel_i.Name = "panel_i";
            this.panel_i.Size = new System.Drawing.Size(908, 341);
            this.panel_i.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel_a);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(908, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аудио";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_a
            // 
            this.panel_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_a.Location = new System.Drawing.Point(0, 0);
            this.panel_a.Margin = new System.Windows.Forms.Padding(0);
            this.panel_a.Name = "panel_a";
            this.panel_a.Size = new System.Drawing.Size(908, 341);
            this.panel_a.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(916, 288);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 288);
            this.tabControl1.TabIndex = 7;
            // 
            // panelStat
            // 
            this.panelStat.BackColor = System.Drawing.Color.White;
            this.panelStat.Controls.Add(this.userFilesListView);
            this.panelStat.Controls.Add(this.flowLayoutPanel1);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStat.Location = new System.Drawing.Point(0, 0);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(916, 655);
            this.panelStat.TabIndex = 0;
            this.panelStat.Visible = false;
            // 
            // pGroupsContextMenu
            // 
            this.pGroupsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переместитьВГруппуToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.pGroupsContextMenu.Name = "pGroupsContextMenu";
            this.pGroupsContextMenu.Size = new System.Drawing.Size(197, 48);
            // 
            // переместитьВГруппуToolStripMenuItem
            // 
            this.переместитьВГруппуToolStripMenuItem.Name = "переместитьВГруппуToolStripMenuItem";
            this.переместитьВГруппуToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.переместитьВГруппуToolStripMenuItem.Text = "Переместить в группу";
            this.переместитьВГруппуToolStripMenuItem.Click += new System.EventHandler(this.переместитьВГруппуToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 626);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(916, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(787, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userFilesListView
            // 
            this.userFilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userFilesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFilesListView.Location = new System.Drawing.Point(0, 0);
            this.userFilesListView.Margin = new System.Windows.Forms.Padding(0);
            this.userFilesListView.Name = "userFilesListView";
            this.userFilesListView.Size = new System.Drawing.Size(916, 626);
            this.userFilesListView.TabIndex = 1;
            this.userFilesListView.UseCompatibleStateImageBehavior = false;
            this.userFilesListView.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTT.ResumeLayout(false);
            this.panelTT.PerformLayout();
            this.panelContentContainer.ResumeLayout(false);
            this.panelPlayersContent.ResumeLayout(false);
            this.groupBoxPlayersGroups.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panelTimetable.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.filesTabControll.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.panelStat.PerformLayout();
            this.pGroupsContextMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButtonPlayers;
        private System.Windows.Forms.Button menuButtonStat;
        private System.Windows.Forms.Button menuButtonTimetable;
        private System.Windows.Forms.Panel panelContentContainer;
        private System.Windows.Forms.Panel panelPlayersContent;
        private System.Windows.Forms.Panel panelTimetable;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.GroupBox groupBoxPlayersGroups;
        private System.Windows.Forms.TreeView treeViewPlayerGroups;
        private System.Windows.Forms.ContextMenuStrip pGroupsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem переместитьВГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl filesTabControll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel_i;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button savegroups_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel_v;
        private System.Windows.Forms.Panel panel_a;
        private System.Windows.Forms.Panel panelTT;
        private System.Windows.Forms.ComboBox listTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newTtButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView userFilesListView;
        //private DSUI.TimeLineControl timeLineControl1;
    }
}

