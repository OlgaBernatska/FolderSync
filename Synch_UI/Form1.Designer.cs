namespace Synch_UI
{
    partial class Main_Form
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
            this.txb_Path_1 = new System.Windows.Forms.TextBox();
            this.txb_Path_2 = new System.Windows.Forms.TextBox();
            this.lbl_Folder1 = new System.Windows.Forms.Label();
            this.lbl2_Folder2 = new System.Windows.Forms.Label();
            this.btn_StartSync = new System.Windows.Forms.Button();
            this.btn_Browse1 = new System.Windows.Forms.Button();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.lbl_Folders_for_sync = new System.Windows.Forms.Label();
            this.lbl_Source = new System.Windows.Forms.Label();
            this.checkBoxPath1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPath2 = new System.Windows.Forms.CheckBox();
            this.groupbox_SyncTask = new System.Windows.Forms.GroupBox();
            this.radioBtn_TwoWay = new System.Windows.Forms.RadioButton();
            this.radioBtn_OneWay = new System.Windows.Forms.RadioButton();
            this.groupBox_Schedule = new System.Windows.Forms.GroupBox();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.textBox_days = new System.Windows.Forms.TextBox();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.radioBtn_days = new System.Windows.Forms.RadioButton();
            this.radioBtn_hour = new System.Windows.Forms.RadioButton();
            this.radioBtn_min = new System.Windows.Forms.RadioButton();
            this.radioBtn_OneTime = new System.Windows.Forms.RadioButton();
            this.groupbox_SyncTask.SuspendLayout();
            this.groupBox_Schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Path_1
            // 
            this.txb_Path_1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txb_Path_1.Location = new System.Drawing.Point(254, 90);
            this.txb_Path_1.Name = "txb_Path_1";
            this.txb_Path_1.Size = new System.Drawing.Size(283, 20);
            this.txb_Path_1.TabIndex = 0;
            this.txb_Path_1.Text = "Enter Path to Folder 1";
            this.txb_Path_1.TextChanged += new System.EventHandler(this.txb_Path_1_TextChanged);
            // 
            // txb_Path_2
            // 
            this.txb_Path_2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txb_Path_2.Location = new System.Drawing.Point(254, 129);
            this.txb_Path_2.Name = "txb_Path_2";
            this.txb_Path_2.Size = new System.Drawing.Size(283, 20);
            this.txb_Path_2.TabIndex = 1;
            this.txb_Path_2.Text = "Enter Path to Folder 2";
            this.txb_Path_2.TextChanged += new System.EventHandler(this.txb_Path_2_TextChanged);
            // 
            // lbl_Folder1
            // 
            this.lbl_Folder1.AutoSize = true;
            this.lbl_Folder1.Location = new System.Drawing.Point(203, 93);
            this.lbl_Folder1.Name = "lbl_Folder1";
            this.lbl_Folder1.Size = new System.Drawing.Size(45, 13);
            this.lbl_Folder1.TabIndex = 2;
            this.lbl_Folder1.Text = "Folder 1";
            // 
            // lbl2_Folder2
            // 
            this.lbl2_Folder2.AutoSize = true;
            this.lbl2_Folder2.Location = new System.Drawing.Point(203, 132);
            this.lbl2_Folder2.Name = "lbl2_Folder2";
            this.lbl2_Folder2.Size = new System.Drawing.Size(45, 13);
            this.lbl2_Folder2.TabIndex = 3;
            this.lbl2_Folder2.Text = "Folder 2";
            // 
            // btn_StartSync
            // 
            this.btn_StartSync.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StartSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_StartSync.Location = new System.Drawing.Point(341, 207);
            this.btn_StartSync.Name = "btn_StartSync";
            this.btn_StartSync.Size = new System.Drawing.Size(125, 55);
            this.btn_StartSync.TabIndex = 4;
            this.btn_StartSync.Text = "Start Sync";
            this.btn_StartSync.UseVisualStyleBackColor = false;
            this.btn_StartSync.Click += new System.EventHandler(this.btn_StartSynch_Click);
            // 
            // btn_Browse1
            // 
            this.btn_Browse1.Location = new System.Drawing.Point(556, 90);
            this.btn_Browse1.Name = "btn_Browse1";
            this.btn_Browse1.Size = new System.Drawing.Size(75, 20);
            this.btn_Browse1.TabIndex = 5;
            this.btn_Browse1.Text = "Browse";
            this.btn_Browse1.UseVisualStyleBackColor = true;
            this.btn_Browse1.Click += new System.EventHandler(this.btn_Browse1_Click);
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Location = new System.Drawing.Point(556, 128);
            this.btn_Browse2.Name = "btn_Browse2";
            this.btn_Browse2.Size = new System.Drawing.Size(75, 20);
            this.btn_Browse2.TabIndex = 6;
            this.btn_Browse2.Text = "Browse";
            this.btn_Browse2.UseVisualStyleBackColor = true;
            this.btn_Browse2.Click += new System.EventHandler(this.btn_Browse2_Click);
            // 
            // lbl_Folders_for_sync
            // 
            this.lbl_Folders_for_sync.AutoSize = true;
            this.lbl_Folders_for_sync.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Folders_for_sync.Location = new System.Drawing.Point(254, 50);
            this.lbl_Folders_for_sync.Name = "lbl_Folders_for_sync";
            this.lbl_Folders_for_sync.Size = new System.Drawing.Size(243, 26);
            this.lbl_Folders_for_sync.TabIndex = 7;
            this.lbl_Folders_for_sync.Text = "Folders for synchronize:";
            // 
            // lbl_Source
            // 
            this.lbl_Source.AutoSize = true;
            this.lbl_Source.Location = new System.Drawing.Point(638, 60);
            this.lbl_Source.Name = "lbl_Source";
            this.lbl_Source.Size = new System.Drawing.Size(41, 26);
            this.lbl_Source.TabIndex = 8;
            this.lbl_Source.Text = "Source\r\nFolder\r\n";
            // 
            // checkBoxPath1
            // 
            this.checkBoxPath1.AutoSize = true;
            this.checkBoxPath1.Location = new System.Drawing.Point(651, 94);
            this.checkBoxPath1.Name = "checkBoxPath1";
            this.checkBoxPath1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPath1.TabIndex = 9;
            this.checkBoxPath1.UseVisualStyleBackColor = true;
            this.checkBoxPath1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxPath2
            // 
            this.checkBoxPath2.AutoSize = true;
            this.checkBoxPath2.Location = new System.Drawing.Point(651, 132);
            this.checkBoxPath2.Name = "checkBoxPath2";
            this.checkBoxPath2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPath2.TabIndex = 10;
            this.checkBoxPath2.UseVisualStyleBackColor = true;
            this.checkBoxPath2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupbox_SyncTask
            // 
            this.groupbox_SyncTask.Controls.Add(this.radioBtn_TwoWay);
            this.groupbox_SyncTask.Controls.Add(this.radioBtn_OneWay);
            this.groupbox_SyncTask.Location = new System.Drawing.Point(12, 60);
            this.groupbox_SyncTask.Name = "groupbox_SyncTask";
            this.groupbox_SyncTask.Size = new System.Drawing.Size(182, 100);
            this.groupbox_SyncTask.TabIndex = 12;
            this.groupbox_SyncTask.TabStop = false;
            this.groupbox_SyncTask.Text = "Synchronization Task";
            this.groupbox_SyncTask.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtn_TwoWay
            // 
            this.radioBtn_TwoWay.AutoSize = true;
            this.radioBtn_TwoWay.Location = new System.Drawing.Point(5, 64);
            this.radioBtn_TwoWay.Name = "radioBtn_TwoWay";
            this.radioBtn_TwoWay.Size = new System.Drawing.Size(98, 17);
            this.radioBtn_TwoWay.TabIndex = 3;
            this.radioBtn_TwoWay.TabStop = true;
            this.radioBtn_TwoWay.Text = "Two-Way Sync";
            this.radioBtn_TwoWay.UseVisualStyleBackColor = true;
            // 
            // radioBtn_OneWay
            // 
            this.radioBtn_OneWay.AutoSize = true;
            this.radioBtn_OneWay.Location = new System.Drawing.Point(6, 30);
            this.radioBtn_OneWay.Name = "radioBtn_OneWay";
            this.radioBtn_OneWay.Size = new System.Drawing.Size(97, 17);
            this.radioBtn_OneWay.TabIndex = 2;
            this.radioBtn_OneWay.TabStop = true;
            this.radioBtn_OneWay.Text = "One-Way Sync";
            this.radioBtn_OneWay.UseVisualStyleBackColor = true;
            // 
            // groupBox_Schedule
            // 
            this.groupBox_Schedule.Controls.Add(this.radioBtn_OneTime);
            this.groupBox_Schedule.Controls.Add(this.lbl_days);
            this.groupBox_Schedule.Controls.Add(this.lbl_hours);
            this.groupBox_Schedule.Controls.Add(this.lbl_min);
            this.groupBox_Schedule.Controls.Add(this.textBox_days);
            this.groupBox_Schedule.Controls.Add(this.textBox_hours);
            this.groupBox_Schedule.Controls.Add(this.textBox_min);
            this.groupBox_Schedule.Controls.Add(this.radioBtn_days);
            this.groupBox_Schedule.Controls.Add(this.radioBtn_hour);
            this.groupBox_Schedule.Controls.Add(this.radioBtn_min);
            this.groupBox_Schedule.Location = new System.Drawing.Point(17, 204);
            this.groupBox_Schedule.Name = "groupBox_Schedule";
            this.groupBox_Schedule.Size = new System.Drawing.Size(178, 149);
            this.groupBox_Schedule.TabIndex = 13;
            this.groupBox_Schedule.TabStop = false;
            this.groupBox_Schedule.Text = "Synchronization Schedule";
            this.groupBox_Schedule.Enter += new System.EventHandler(this.groupBox_Schedule_Enter);
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(134, 128);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(29, 13);
            this.lbl_days.TabIndex = 8;
            this.lbl_days.Text = "days";
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.Location = new System.Drawing.Point(134, 100);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(33, 13);
            this.lbl_hours.TabIndex = 7;
            this.lbl_hours.Text = "hours";
            this.lbl_hours.Click += new System.EventHandler(this.lbl_hours_Click);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(134, 66);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(43, 13);
            this.lbl_min.TabIndex = 6;
            this.lbl_min.Text = "minutes";
            // 
            // textBox_days
            // 
            this.textBox_days.Location = new System.Drawing.Point(82, 125);
            this.textBox_days.Name = "textBox_days";
            this.textBox_days.Size = new System.Drawing.Size(46, 20);
            this.textBox_days.TabIndex = 5;
            this.textBox_days.TextChanged += new System.EventHandler(this.textBox_days_TextChanged);
            // 
            // textBox_hours
            // 
            this.textBox_hours.Location = new System.Drawing.Point(82, 97);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(46, 20);
            this.textBox_hours.TabIndex = 4;
            this.textBox_hours.TextChanged += new System.EventHandler(this.textBox_hours_TextChanged);
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(82, 64);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(46, 20);
            this.textBox_min.TabIndex = 3;
            this.textBox_min.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioBtn_days
            // 
            this.radioBtn_days.AutoSize = true;
            this.radioBtn_days.Location = new System.Drawing.Point(6, 126);
            this.radioBtn_days.Name = "radioBtn_days";
            this.radioBtn_days.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_days.TabIndex = 2;
            this.radioBtn_days.TabStop = true;
            this.radioBtn_days.Text = "Sync every";
            this.radioBtn_days.UseVisualStyleBackColor = true;
            this.radioBtn_days.CheckedChanged += new System.EventHandler(this.radioBtn_24hours_CheckedChanged);
            // 
            // radioBtn_hour
            // 
            this.radioBtn_hour.AutoSize = true;
            this.radioBtn_hour.Location = new System.Drawing.Point(6, 96);
            this.radioBtn_hour.Name = "radioBtn_hour";
            this.radioBtn_hour.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_hour.TabIndex = 1;
            this.radioBtn_hour.TabStop = true;
            this.radioBtn_hour.Text = "Sync every";
            this.radioBtn_hour.UseVisualStyleBackColor = true;
            this.radioBtn_hour.CheckedChanged += new System.EventHandler(this.radioBtn_1hour_CheckedChanged);
            // 
            // radioBtn_min
            // 
            this.radioBtn_min.AutoSize = true;
            this.radioBtn_min.Location = new System.Drawing.Point(6, 62);
            this.radioBtn_min.Name = "radioBtn_min";
            this.radioBtn_min.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_min.TabIndex = 0;
            this.radioBtn_min.TabStop = true;
            this.radioBtn_min.Text = "Sync every";
            this.radioBtn_min.UseVisualStyleBackColor = true;
            this.radioBtn_min.CheckedChanged += new System.EventHandler(this.radioBtn_10min_CheckedChanged);
            // 
            // radioBtn_OneTime
            // 
            this.radioBtn_OneTime.AutoSize = true;
            this.radioBtn_OneTime.Location = new System.Drawing.Point(6, 25);
            this.radioBtn_OneTime.Name = "radioBtn_OneTime";
            this.radioBtn_OneTime.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_OneTime.TabIndex = 9;
            this.radioBtn_OneTime.TabStop = true;
            this.radioBtn_OneTime.Text = "One time";
            this.radioBtn_OneTime.UseVisualStyleBackColor = true;
            this.radioBtn_OneTime.CheckedChanged += new System.EventHandler(this.radioBtn_OneTime_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 387);
            this.Controls.Add(this.groupBox_Schedule);
            this.Controls.Add(this.groupbox_SyncTask);
            this.Controls.Add(this.checkBoxPath2);
            this.Controls.Add(this.checkBoxPath1);
            this.Controls.Add(this.lbl_Source);
            this.Controls.Add(this.lbl_Folders_for_sync);
            this.Controls.Add(this.btn_Browse2);
            this.Controls.Add(this.btn_Browse1);
            this.Controls.Add(this.btn_StartSync);
            this.Controls.Add(this.lbl2_Folder2);
            this.Controls.Add(this.lbl_Folder1);
            this.Controls.Add(this.txb_Path_2);
            this.Controls.Add(this.txb_Path_1);
            this.Name = "Main_Form";
            this.Text = "Folders Synchronizer";
            this.groupbox_SyncTask.ResumeLayout(false);
            this.groupbox_SyncTask.PerformLayout();
            this.groupBox_Schedule.ResumeLayout(false);
            this.groupBox_Schedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Path_1;
        private System.Windows.Forms.TextBox txb_Path_2;
        private System.Windows.Forms.Label lbl_Folder1;
        private System.Windows.Forms.Label lbl2_Folder2;
        private System.Windows.Forms.Button btn_StartSync;
        private System.Windows.Forms.Button btn_Browse1;
        private System.Windows.Forms.Button btn_Browse2;
        private System.Windows.Forms.Label lbl_Folders_for_sync;
        private System.Windows.Forms.Label lbl_Source;
        private System.Windows.Forms.CheckBox checkBoxPath1;
        private System.Windows.Forms.CheckBox checkBoxPath2;
        private System.Windows.Forms.GroupBox groupbox_SyncTask;
        private System.Windows.Forms.RadioButton radioBtn_TwoWay;
        private System.Windows.Forms.RadioButton radioBtn_OneWay;
        private System.Windows.Forms.GroupBox groupBox_Schedule;
        private System.Windows.Forms.RadioButton radioBtn_days;
        private System.Windows.Forms.RadioButton radioBtn_hour;
        private System.Windows.Forms.RadioButton radioBtn_min;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.TextBox textBox_days;
        private System.Windows.Forms.RadioButton radioBtn_OneTime;
    }
}

