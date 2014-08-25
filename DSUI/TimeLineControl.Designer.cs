namespace DSUI
{
    partial class TimeLineControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timelineContent = new System.Windows.Forms.Panel();
            this.timeline_panel = new System.Windows.Forms.Panel();
            this.flLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.durationLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.assignPlayerBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.timelineContent.SuspendLayout();
            this.timeline_panel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1079, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начало показа:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // timelineContent
            // 
            this.timelineContent.AutoScroll = true;
            this.timelineContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelineContent.Controls.Add(this.timeline_panel);
            this.timelineContent.Controls.Add(this.tableLayoutPanel4);
            this.timelineContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineContent.Location = new System.Drawing.Point(0, 26);
            this.timelineContent.Name = "timelineContent";
            this.timelineContent.Size = new System.Drawing.Size(1079, 280);
            this.timelineContent.TabIndex = 1;
            // 
            // timeline_panel
            // 
            this.timeline_panel.AllowDrop = true;
            this.timeline_panel.AutoScroll = true;
            this.timeline_panel.AutoSize = true;
            this.timeline_panel.Controls.Add(this.flLayout);
            this.timeline_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline_panel.Location = new System.Drawing.Point(0, 0);
            this.timeline_panel.Margin = new System.Windows.Forms.Padding(0);
            this.timeline_panel.Name = "timeline_panel";
            this.timeline_panel.Size = new System.Drawing.Size(1077, 249);
            this.timeline_panel.TabIndex = 8;
            this.timeline_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.timelineContent_DragDrop);
            this.timeline_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.timelineContent_DragEnter);
            this.timeline_panel.DragOver += new System.Windows.Forms.DragEventHandler(this.timelineContent_DragOver);
            // 
            // flLayout
            // 
            this.flLayout.AutoSize = true;
            this.flLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flLayout.Location = new System.Drawing.Point(0, 0);
            this.flLayout.Margin = new System.Windows.Forms.Padding(0);
            this.flLayout.Name = "flLayout";
            this.flLayout.Size = new System.Drawing.Size(0, 0);
            this.flLayout.TabIndex = 0;
            this.flLayout.WrapContents = false;
            this.flLayout.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.controllAdded);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel4.Controls.Add(this.durationLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.assignPlayerBtn, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 249);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1077, 29);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.durationLabel.Location = new System.Drawing.Point(3, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(34, 29);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "0 сек";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(607, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(707, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // assignPlayerBtn
            // 
            this.assignPlayerBtn.AutoSize = true;
            this.assignPlayerBtn.Location = new System.Drawing.Point(783, 3);
            this.assignPlayerBtn.Name = "assignPlayerBtn";
            this.assignPlayerBtn.Size = new System.Drawing.Size(104, 23);
            this.assignPlayerBtn.TabIndex = 3;
            this.assignPlayerBtn.Text = "Назначить плеер";
            this.assignPlayerBtn.UseVisualStyleBackColor = true;
            this.assignPlayerBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(893, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Копировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(976, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Копировать всё";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TimeLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timelineContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TimeLineControl";
            this.Size = new System.Drawing.Size(1079, 306);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.timelineContent.ResumeLayout(false);
            this.timelineContent.PerformLayout();
            this.timeline_panel.ResumeLayout(false);
            this.timeline_panel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel timelineContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button assignPlayerBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel timeline_panel;
        private System.Windows.Forms.FlowLayoutPanel flLayout;

    }
}
