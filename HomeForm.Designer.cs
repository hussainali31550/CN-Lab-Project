namespace File_Transfer
{
    partial class mainForm
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
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeSaveLocButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileNotificationLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(324, 214);
            this.onlinePCList.Margin = new System.Windows.Forms.Padding(4);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(1036, 410);
            this.onlinePCList.TabIndex = 0;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            this.onlinePCList.SelectedIndexChanged += new System.EventHandler(this.onlinePCList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 271;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Computer Name";
            this.columnHeader2.Width = 263;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Navy;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(18, 172);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(185, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Find/Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            this.startButton.MouseHover += new System.EventHandler(this.startButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LogoLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.changeSaveLocButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.notificationLabel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 661);
            this.panel1.TabIndex = 2;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Black;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(33, 10);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Padding = new System.Windows.Forms.Padding(15);
            this.LogoLabel.Size = new System.Drawing.Size(144, 59);
            this.LogoLabel.TabIndex = 12;
            this.LogoLabel.Text = "DataDrift";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Navy;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(18, 495);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 44);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeSaveLocButton
            // 
            this.changeSaveLocButton.BackColor = System.Drawing.Color.Navy;
            this.changeSaveLocButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeSaveLocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSaveLocButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSaveLocButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSaveLocButton.Location = new System.Drawing.Point(15, 389);
            this.changeSaveLocButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeSaveLocButton.Name = "changeSaveLocButton";
            this.changeSaveLocButton.Size = new System.Drawing.Size(185, 44);
            this.changeSaveLocButton.TabIndex = 10;
            this.changeSaveLocButton.Text = "Change Save Location";
            this.changeSaveLocButton.UseVisualStyleBackColor = false;
            this.changeSaveLocButton.Click += new System.EventHandler(this.changeSaveLocButton_Click);
            this.changeSaveLocButton.MouseLeave += new System.EventHandler(this.changeSaveLocButton_MouseLeave);
            this.changeSaveLocButton.MouseHover += new System.EventHandler(this.changeSaveLocButton_MouseHover);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Navy;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(18, 278);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(185, 44);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Application";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseLeave += new System.EventHandler(this.stopButton_MouseLeave);
            this.stopButton.MouseHover += new System.EventHandler(this.stopButton_MouseHover);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(15, 89);
            this.notificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(10, 16);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.Text = ".";
            this.notificationLabel.Click += new System.EventHandler(this.notificationLabel_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Navy;
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Location = new System.Drawing.Point(10, 19);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(145, 42);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.fileNameLabel.Location = new System.Drawing.Point(654, 160);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(10, 16);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = ".";
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileButton.BackColor = System.Drawing.Color.Navy;
            this.sendFileButton.FlatAppearance.BorderSize = 0;
            this.sendFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFileButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendFileButton.Location = new System.Drawing.Point(237, 19);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(653, 42);
            this.sendFileButton.TabIndex = 5;
            this.sendFileButton.Text = "Send File to Selected Computer";
            this.sendFileButton.UseVisualStyleBackColor = false;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(819, 157);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(10, 16);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = ".";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.Navy;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(943, 19);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 42);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileNotificationLabel
            // 
            this.fileNotificationLabel.AutoSize = true;
            this.fileNotificationLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.fileNotificationLabel.Location = new System.Drawing.Point(598, 160);
            this.fileNotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNotificationLabel.Name = "fileNotificationLabel";
            this.fileNotificationLabel.Size = new System.Drawing.Size(10, 16);
            this.fileNotificationLabel.TabIndex = 9;
            this.fileNotificationLabel.Text = ".";
            this.fileNotificationLabel.Click += new System.EventHandler(this.fileNotificationLabel_Click);
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(330, 194);
            this.savePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(172, 16);
            this.savePathLabel.TabIndex = 10;
            this.savePathLabel.Text = "C:\\Users\\Public\\Downloads";
            this.savePathLabel.Click += new System.EventHandler(this.savePathLabel_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(324, 154);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(132, 22);
            this.ipBox.TabIndex = 11;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(321, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insert receiver\'s IP";
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.Navy;
            this.notificationPanel.Controls.Add(this.notificationTempLabel);
            this.notificationPanel.Location = new System.Drawing.Point(506, 358);
            this.notificationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(598, 65);
            this.notificationPanel.TabIndex = 13;
            this.notificationPanel.UseWaitCursor = true;
            this.notificationPanel.Visible = false;
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notificationTempLabel.Location = new System.Drawing.Point(14, 21);
            this.notificationTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(234, 24);
            this.notificationTempLabel.TabIndex = 2;
            this.notificationTempLabel.Text = "Please wait. File Sending to ";
            this.notificationTempLabel.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.browseButton);
            this.panel2.Controls.Add(this.sendFileButton);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Location = new System.Drawing.Point(267, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 84);
            this.panel2.TabIndex = 14;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1373, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNotificationLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.onlinePCList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "File Transfer Application - Computer Networks Laboratory Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseHover += new System.EventHandler(this.mainForm_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView onlinePCList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fileNotificationLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeSaveLocButton;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LogoLabel;
    }
}

