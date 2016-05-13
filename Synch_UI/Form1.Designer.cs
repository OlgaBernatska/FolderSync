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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.txb_Path_1 = new System.Windows.Forms.TextBox();
            this.txb_Path_2 = new System.Windows.Forms.TextBox();
            this.lbl_Folder1 = new System.Windows.Forms.Label();
            this.lbl2_Folder2 = new System.Windows.Forms.Label();
            this.btn_StartSync = new System.Windows.Forms.Button();
            this.btn_Browse1 = new System.Windows.Forms.Button();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.lbl_Folders_for_sync = new System.Windows.Forms.Label();
            this.groupbox_SyncTask = new System.Windows.Forms.GroupBox();
            this.radioBtn_TwoWay = new System.Windows.Forms.RadioButton();
            this.radioBtn_OneWay = new System.Windows.Forms.RadioButton();
            this.groupBox_Schedule = new System.Windows.Forms.GroupBox();
            this.numericUpDown_days = new System.Windows.Forms.NumericUpDown();
            this.radioBtn_OneTime = new System.Windows.Forms.RadioButton();
            this.numericUpDown_hours = new System.Windows.Forms.NumericUpDown();
            this.lbl_days = new System.Windows.Forms.Label();
            this.numericUpDown_minutes = new System.Windows.Forms.NumericUpDown();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.radioBtn_days = new System.Windows.Forms.RadioButton();
            this.radioBtn_hour = new System.Windows.Forms.RadioButton();
            this.radioBtn_min = new System.Windows.Forms.RadioButton();
            this.groupBox_SyncFilters = new System.Windows.Forms.GroupBox();
            this.textBox_IncludeFiles2 = new System.Windows.Forms.TextBox();
            this.textBox_ExcludeFiles2 = new System.Windows.Forms.TextBox();
            this.textBox_ExcludeFolders2 = new System.Windows.Forms.TextBox();
            this.textBox_IncludeFiles1 = new System.Windows.Forms.TextBox();
            this.textBox_ExcludeFiles1 = new System.Windows.Forms.TextBox();
            this.textBox_ExcludeFolders1 = new System.Windows.Forms.TextBox();
            this.checkBox_IncludeFiles2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeFiles2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeFolders2 = new System.Windows.Forms.CheckBox();
            this.checkBox_IncludeFiles1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeFiles1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ExcludeFolders1 = new System.Windows.Forms.CheckBox();
            this.lbl_Folder2Filter = new System.Windows.Forms.Label();
            this.lbl_Folder1Filter = new System.Windows.Forms.Label();
            this.groupbox_SyncTask.SuspendLayout();
            this.groupBox_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minutes)).BeginInit();
            this.groupBox_SyncFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Path_1
            // 
            this.txb_Path_1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txb_Path_1.Location = new System.Drawing.Point(311, 89);
            this.txb_Path_1.Name = "txb_Path_1";
            this.txb_Path_1.Size = new System.Drawing.Size(283, 20);
            this.txb_Path_1.TabIndex = 0;
            this.txb_Path_1.Text = "Enter Path to Folder 1";
            this.txb_Path_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_Path_1_MouseClick);
            this.txb_Path_1.TextChanged += new System.EventHandler(this.txb_Path_1_TextChanged);
            // 
            // txb_Path_2
            // 
            this.txb_Path_2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txb_Path_2.Location = new System.Drawing.Point(311, 123);
            this.txb_Path_2.Name = "txb_Path_2";
            this.txb_Path_2.Size = new System.Drawing.Size(283, 20);
            this.txb_Path_2.TabIndex = 1;
            this.txb_Path_2.Text = "Enter Path to Folder 2";
            this.txb_Path_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txb_Path_2_MouseClick);
            this.txb_Path_2.TextChanged += new System.EventHandler(this.txb_Path_2_TextChanged);
            // 
            // lbl_Folder1
            // 
            this.lbl_Folder1.AutoSize = true;
            this.lbl_Folder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Folder1.Location = new System.Drawing.Point(256, 89);
            this.lbl_Folder1.Name = "lbl_Folder1";
            this.lbl_Folder1.Size = new System.Drawing.Size(49, 17);
            this.lbl_Folder1.TabIndex = 2;
            this.lbl_Folder1.Text = "From:";
            // 
            // lbl2_Folder2
            // 
            this.lbl2_Folder2.AutoSize = true;
            this.lbl2_Folder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Folder2.Location = new System.Drawing.Point(273, 123);
            this.lbl2_Folder2.Name = "lbl2_Folder2";
            this.lbl2_Folder2.Size = new System.Drawing.Size(32, 17);
            this.lbl2_Folder2.TabIndex = 3;
            this.lbl2_Folder2.Text = "To:";
            // 
            // btn_StartSync
            // 
            this.btn_StartSync.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StartSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_StartSync.Location = new System.Drawing.Point(401, 386);
            this.btn_StartSync.Name = "btn_StartSync";
            this.btn_StartSync.Size = new System.Drawing.Size(125, 55);
            this.btn_StartSync.TabIndex = 4;
            this.btn_StartSync.Text = "Start Sync";
            this.btn_StartSync.UseVisualStyleBackColor = false;
            this.btn_StartSync.Click += new System.EventHandler(this.btn_StartSynch_Click);
            // 
            // btn_Browse1
            // 
            this.btn_Browse1.Location = new System.Drawing.Point(612, 88);
            this.btn_Browse1.Name = "btn_Browse1";
            this.btn_Browse1.Size = new System.Drawing.Size(75, 20);
            this.btn_Browse1.TabIndex = 5;
            this.btn_Browse1.Text = "Browse";
            this.btn_Browse1.UseVisualStyleBackColor = true;
            this.btn_Browse1.Click += new System.EventHandler(this.btn_Browse1_Click);
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Location = new System.Drawing.Point(612, 123);
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
            this.lbl_Folders_for_sync.Location = new System.Drawing.Point(297, 41);
            this.lbl_Folders_for_sync.Name = "lbl_Folders_for_sync";
            this.lbl_Folders_for_sync.Size = new System.Drawing.Size(243, 26);
            this.lbl_Folders_for_sync.TabIndex = 7;
            this.lbl_Folders_for_sync.Text = "Folders for synchronize:";
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
            // 
            // radioBtn_TwoWay
            // 
            this.radioBtn_TwoWay.AutoSize = true;
            this.radioBtn_TwoWay.Location = new System.Drawing.Point(5, 64);
            this.radioBtn_TwoWay.Name = "radioBtn_TwoWay";
            this.radioBtn_TwoWay.Size = new System.Drawing.Size(98, 17);
            this.radioBtn_TwoWay.TabIndex = 3;
            this.radioBtn_TwoWay.Text = "Two-Way Sync";
            this.radioBtn_TwoWay.UseVisualStyleBackColor = true;
            this.radioBtn_TwoWay.CheckedChanged += new System.EventHandler(this.radioBtn_TwoWay_CheckedChanged_1);
            // 
            // radioBtn_OneWay
            // 
            this.radioBtn_OneWay.AutoSize = true;
            this.radioBtn_OneWay.Checked = true;
            this.radioBtn_OneWay.Location = new System.Drawing.Point(6, 30);
            this.radioBtn_OneWay.Name = "radioBtn_OneWay";
            this.radioBtn_OneWay.Size = new System.Drawing.Size(97, 17);
            this.radioBtn_OneWay.TabIndex = 2;
            this.radioBtn_OneWay.TabStop = true;
            this.radioBtn_OneWay.Text = "One-Way Sync";
            this.radioBtn_OneWay.UseVisualStyleBackColor = true;
            this.radioBtn_OneWay.CheckedChanged += new System.EventHandler(this.radioBtn_OneWay_CheckedChanged_1);
            // 
            // groupBox_Schedule
            // 
            this.groupBox_Schedule.Controls.Add(this.numericUpDown_days);
            this.groupBox_Schedule.Controls.Add(this.radioBtn_OneTime);
            this.groupBox_Schedule.Controls.Add(this.numericUpDown_hours);
            this.groupBox_Schedule.Controls.Add(this.lbl_days);
            this.groupBox_Schedule.Controls.Add(this.numericUpDown_minutes);
            this.groupBox_Schedule.Controls.Add(this.lbl_hours);
            this.groupBox_Schedule.Controls.Add(this.lbl_min);
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
            // numericUpDown_days
            // 
            this.numericUpDown_days.Enabled = false;
            this.numericUpDown_days.Location = new System.Drawing.Point(85, 125);
            this.numericUpDown_days.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_days.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_days.Name = "numericUpDown_days";
            this.numericUpDown_days.ReadOnly = true;
            this.numericUpDown_days.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_days.TabIndex = 19;
            this.numericUpDown_days.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_days.ValueChanged += new System.EventHandler(this.numericUpDown_days_ValueChanged);
            // 
            // radioBtn_OneTime
            // 
            this.radioBtn_OneTime.AutoSize = true;
            this.radioBtn_OneTime.Checked = true;
            this.radioBtn_OneTime.Location = new System.Drawing.Point(6, 25);
            this.radioBtn_OneTime.Name = "radioBtn_OneTime";
            this.radioBtn_OneTime.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_OneTime.TabIndex = 9;
            this.radioBtn_OneTime.TabStop = true;
            this.radioBtn_OneTime.Text = "One time";
            this.radioBtn_OneTime.UseVisualStyleBackColor = true;
            this.radioBtn_OneTime.CheckedChanged += new System.EventHandler(this.radioBtn_OneTime_CheckedChanged);
            // 
            // numericUpDown_hours
            // 
            this.numericUpDown_hours.Enabled = false;
            this.numericUpDown_hours.Location = new System.Drawing.Point(85, 96);
            this.numericUpDown_hours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_hours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_hours.Name = "numericUpDown_hours";
            this.numericUpDown_hours.ReadOnly = true;
            this.numericUpDown_hours.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_hours.TabIndex = 18;
            this.numericUpDown_hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_hours.ValueChanged += new System.EventHandler(this.numericUpDown_hours_ValueChanged);
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
            // numericUpDown_minutes
            // 
            this.numericUpDown_minutes.Enabled = false;
            this.numericUpDown_minutes.Location = new System.Drawing.Point(85, 66);
            this.numericUpDown_minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_minutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minutes.Name = "numericUpDown_minutes";
            this.numericUpDown_minutes.ReadOnly = true;
            this.numericUpDown_minutes.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_minutes.TabIndex = 17;
            this.numericUpDown_minutes.TabStop = false;
            this.numericUpDown_minutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minutes.ValueChanged += new System.EventHandler(this.numericUpDown_minutes_ValueChanged);
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.Location = new System.Drawing.Point(134, 100);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(33, 13);
            this.lbl_hours.TabIndex = 7;
            this.lbl_hours.Text = "hours";
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
            // radioBtn_days
            // 
            this.radioBtn_days.AutoSize = true;
            this.radioBtn_days.Location = new System.Drawing.Point(6, 126);
            this.radioBtn_days.Name = "radioBtn_days";
            this.radioBtn_days.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_days.TabIndex = 2;
            this.radioBtn_days.Text = "Sync every";
            this.radioBtn_days.UseVisualStyleBackColor = true;
            this.radioBtn_days.CheckedChanged += new System.EventHandler(this.radioBtn_day_CheckedChanged);
            // 
            // radioBtn_hour
            // 
            this.radioBtn_hour.AutoSize = true;
            this.radioBtn_hour.Location = new System.Drawing.Point(6, 96);
            this.radioBtn_hour.Name = "radioBtn_hour";
            this.radioBtn_hour.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_hour.TabIndex = 1;
            this.radioBtn_hour.Text = "Sync every";
            this.radioBtn_hour.UseVisualStyleBackColor = true;
            this.radioBtn_hour.CheckedChanged += new System.EventHandler(this.radioBtn_hour_CheckedChanged);
            // 
            // radioBtn_min
            // 
            this.radioBtn_min.AutoSize = true;
            this.radioBtn_min.Location = new System.Drawing.Point(6, 62);
            this.radioBtn_min.Name = "radioBtn_min";
            this.radioBtn_min.Size = new System.Drawing.Size(78, 17);
            this.radioBtn_min.TabIndex = 0;
            this.radioBtn_min.Text = "Sync every";
            this.radioBtn_min.UseVisualStyleBackColor = true;
            this.radioBtn_min.CheckedChanged += new System.EventHandler(this.radioBtn_min_CheckedChanged);
            // 
            // groupBox_SyncFilters
            // 
            this.groupBox_SyncFilters.Controls.Add(this.textBox_IncludeFiles2);
            this.groupBox_SyncFilters.Controls.Add(this.textBox_ExcludeFiles2);
            this.groupBox_SyncFilters.Controls.Add(this.textBox_ExcludeFolders2);
            this.groupBox_SyncFilters.Controls.Add(this.textBox_IncludeFiles1);
            this.groupBox_SyncFilters.Controls.Add(this.textBox_ExcludeFiles1);
            this.groupBox_SyncFilters.Controls.Add(this.textBox_ExcludeFolders1);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_IncludeFiles2);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_ExcludeFiles2);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_ExcludeFolders2);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_IncludeFiles1);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_ExcludeFiles1);
            this.groupBox_SyncFilters.Controls.Add(this.checkBox_ExcludeFolders1);
            this.groupBox_SyncFilters.Controls.Add(this.lbl_Folder2Filter);
            this.groupBox_SyncFilters.Controls.Add(this.lbl_Folder1Filter);
            this.groupBox_SyncFilters.Location = new System.Drawing.Point(219, 204);
            this.groupBox_SyncFilters.Name = "groupBox_SyncFilters";
            this.groupBox_SyncFilters.Size = new System.Drawing.Size(477, 149);
            this.groupBox_SyncFilters.TabIndex = 16;
            this.groupBox_SyncFilters.TabStop = false;
            this.groupBox_SyncFilters.Text = "Synchronization Filters";
            // 
            // textBox_IncludeFiles2
            // 
            this.textBox_IncludeFiles2.Enabled = false;
            this.textBox_IncludeFiles2.Location = new System.Drawing.Point(371, 126);
            this.textBox_IncludeFiles2.Name = "textBox_IncludeFiles2";
            this.textBox_IncludeFiles2.Size = new System.Drawing.Size(100, 20);
            this.textBox_IncludeFiles2.TabIndex = 13;
            this.textBox_IncludeFiles2.TextChanged += new System.EventHandler(this.textBox_IncludeFiles2_TextChanged);
            // 
            // textBox_ExcludeFiles2
            // 
            this.textBox_ExcludeFiles2.Enabled = false;
            this.textBox_ExcludeFiles2.Location = new System.Drawing.Point(371, 93);
            this.textBox_ExcludeFiles2.Name = "textBox_ExcludeFiles2";
            this.textBox_ExcludeFiles2.Size = new System.Drawing.Size(100, 20);
            this.textBox_ExcludeFiles2.TabIndex = 12;
            this.textBox_ExcludeFiles2.TextChanged += new System.EventHandler(this.textBox_ExcludeFiles2_TextChanged);
            // 
            // textBox_ExcludeFolders2
            // 
            this.textBox_ExcludeFolders2.Enabled = false;
            this.textBox_ExcludeFolders2.Location = new System.Drawing.Point(371, 59);
            this.textBox_ExcludeFolders2.Name = "textBox_ExcludeFolders2";
            this.textBox_ExcludeFolders2.Size = new System.Drawing.Size(100, 20);
            this.textBox_ExcludeFolders2.TabIndex = 11;
            this.textBox_ExcludeFolders2.TextChanged += new System.EventHandler(this.textBox_ExcludeFolders2_TextChanged);
            // 
            // textBox_IncludeFiles1
            // 
            this.textBox_IncludeFiles1.Enabled = false;
            this.textBox_IncludeFiles1.Location = new System.Drawing.Point(114, 125);
            this.textBox_IncludeFiles1.Name = "textBox_IncludeFiles1";
            this.textBox_IncludeFiles1.Size = new System.Drawing.Size(100, 20);
            this.textBox_IncludeFiles1.TabIndex = 10;
            this.textBox_IncludeFiles1.TextChanged += new System.EventHandler(this.textBox_IncludeFiles1_TextChanged);
            // 
            // textBox_ExcludeFiles1
            // 
            this.textBox_ExcludeFiles1.Enabled = false;
            this.textBox_ExcludeFiles1.Location = new System.Drawing.Point(114, 93);
            this.textBox_ExcludeFiles1.Name = "textBox_ExcludeFiles1";
            this.textBox_ExcludeFiles1.Size = new System.Drawing.Size(100, 20);
            this.textBox_ExcludeFiles1.TabIndex = 9;
            this.textBox_ExcludeFiles1.TextChanged += new System.EventHandler(this.textBox_ExcludeFiles1_TextChanged);
            // 
            // textBox_ExcludeFolders1
            // 
            this.textBox_ExcludeFolders1.Enabled = false;
            this.textBox_ExcludeFolders1.Location = new System.Drawing.Point(114, 59);
            this.textBox_ExcludeFolders1.Name = "textBox_ExcludeFolders1";
            this.textBox_ExcludeFolders1.Size = new System.Drawing.Size(100, 20);
            this.textBox_ExcludeFolders1.TabIndex = 8;
            this.textBox_ExcludeFolders1.TabStop = false;
            this.textBox_ExcludeFolders1.TextChanged += new System.EventHandler(this.textBox_ExcludeFolders1_TextChanged);
            // 
            // checkBox_IncludeFiles2
            // 
            this.checkBox_IncludeFiles2.AutoSize = true;
            this.checkBox_IncludeFiles2.Location = new System.Drawing.Point(264, 128);
            this.checkBox_IncludeFiles2.Name = "checkBox_IncludeFiles2";
            this.checkBox_IncludeFiles2.Size = new System.Drawing.Size(85, 17);
            this.checkBox_IncludeFiles2.TabIndex = 7;
            this.checkBox_IncludeFiles2.Text = "Include Files";
            this.checkBox_IncludeFiles2.UseVisualStyleBackColor = true;
            this.checkBox_IncludeFiles2.CheckedChanged += new System.EventHandler(this.checkBox_IncludeFiles2_CheckedChanged);
            // 
            // checkBox_ExcludeFiles2
            // 
            this.checkBox_ExcludeFiles2.AutoSize = true;
            this.checkBox_ExcludeFiles2.Location = new System.Drawing.Point(264, 96);
            this.checkBox_ExcludeFiles2.Name = "checkBox_ExcludeFiles2";
            this.checkBox_ExcludeFiles2.Size = new System.Drawing.Size(88, 17);
            this.checkBox_ExcludeFiles2.TabIndex = 6;
            this.checkBox_ExcludeFiles2.Text = "Exclude Files";
            this.checkBox_ExcludeFiles2.UseVisualStyleBackColor = true;
            this.checkBox_ExcludeFiles2.CheckedChanged += new System.EventHandler(this.checkBox_ExcludeFiles2_CheckedChanged);
            // 
            // checkBox_ExcludeFolders2
            // 
            this.checkBox_ExcludeFolders2.AutoSize = true;
            this.checkBox_ExcludeFolders2.Location = new System.Drawing.Point(264, 62);
            this.checkBox_ExcludeFolders2.Name = "checkBox_ExcludeFolders2";
            this.checkBox_ExcludeFolders2.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ExcludeFolders2.TabIndex = 5;
            this.checkBox_ExcludeFolders2.Text = "Exclude Folders";
            this.checkBox_ExcludeFolders2.UseVisualStyleBackColor = true;
            this.checkBox_ExcludeFolders2.CheckedChanged += new System.EventHandler(this.checkBox_ExcludeFolders2_CheckedChanged);
            // 
            // checkBox_IncludeFiles1
            // 
            this.checkBox_IncludeFiles1.AutoSize = true;
            this.checkBox_IncludeFiles1.Location = new System.Drawing.Point(9, 128);
            this.checkBox_IncludeFiles1.Name = "checkBox_IncludeFiles1";
            this.checkBox_IncludeFiles1.Size = new System.Drawing.Size(85, 17);
            this.checkBox_IncludeFiles1.TabIndex = 4;
            this.checkBox_IncludeFiles1.Text = "Include Files";
            this.checkBox_IncludeFiles1.UseVisualStyleBackColor = true;
            this.checkBox_IncludeFiles1.CheckedChanged += new System.EventHandler(this.checkBox_IncludeFiles1_CheckedChanged);
            // 
            // checkBox_ExcludeFiles1
            // 
            this.checkBox_ExcludeFiles1.AutoSize = true;
            this.checkBox_ExcludeFiles1.Location = new System.Drawing.Point(9, 96);
            this.checkBox_ExcludeFiles1.Name = "checkBox_ExcludeFiles1";
            this.checkBox_ExcludeFiles1.Size = new System.Drawing.Size(88, 17);
            this.checkBox_ExcludeFiles1.TabIndex = 3;
            this.checkBox_ExcludeFiles1.Text = "Exclude Files";
            this.checkBox_ExcludeFiles1.UseVisualStyleBackColor = true;
            this.checkBox_ExcludeFiles1.CheckedChanged += new System.EventHandler(this.checkBox_ExcludeFiles1_CheckedChanged);
            // 
            // checkBox_ExcludeFolders1
            // 
            this.checkBox_ExcludeFolders1.AutoSize = true;
            this.checkBox_ExcludeFolders1.Location = new System.Drawing.Point(9, 64);
            this.checkBox_ExcludeFolders1.Name = "checkBox_ExcludeFolders1";
            this.checkBox_ExcludeFolders1.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ExcludeFolders1.TabIndex = 2;
            this.checkBox_ExcludeFolders1.Text = "Exclude Folders";
            this.checkBox_ExcludeFolders1.UseVisualStyleBackColor = true;
            this.checkBox_ExcludeFolders1.CheckedChanged += new System.EventHandler(this.checkBox_ExcludeFolders1_CheckedChanged);
            // 
            // lbl_Folder2Filter
            // 
            this.lbl_Folder2Filter.AutoSize = true;
            this.lbl_Folder2Filter.Location = new System.Drawing.Point(343, 29);
            this.lbl_Folder2Filter.Name = "lbl_Folder2Filter";
            this.lbl_Folder2Filter.Size = new System.Drawing.Size(45, 13);
            this.lbl_Folder2Filter.TabIndex = 1;
            this.lbl_Folder2Filter.Text = "Folder 2";
            // 
            // lbl_Folder1Filter
            // 
            this.lbl_Folder1Filter.AutoSize = true;
            this.lbl_Folder1Filter.Location = new System.Drawing.Point(80, 29);
            this.lbl_Folder1Filter.Name = "lbl_Folder1Filter";
            this.lbl_Folder1Filter.Size = new System.Drawing.Size(45, 13);
            this.lbl_Folder1Filter.TabIndex = 0;
            this.lbl_Folder1Filter.Text = "Folder 1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 465);
            this.Controls.Add(this.groupBox_SyncFilters);
            this.Controls.Add(this.groupBox_Schedule);
            this.Controls.Add(this.groupbox_SyncTask);
            this.Controls.Add(this.lbl_Folders_for_sync);
            this.Controls.Add(this.btn_Browse2);
            this.Controls.Add(this.btn_Browse1);
            this.Controls.Add(this.btn_StartSync);
            this.Controls.Add(this.lbl2_Folder2);
            this.Controls.Add(this.lbl_Folder1);
            this.Controls.Add(this.txb_Path_2);
            this.Controls.Add(this.txb_Path_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Files Synchronizer";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupbox_SyncTask.ResumeLayout(false);
            this.groupbox_SyncTask.PerformLayout();
            this.groupBox_Schedule.ResumeLayout(false);
            this.groupBox_Schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minutes)).EndInit();
            this.groupBox_SyncFilters.ResumeLayout(false);
            this.groupBox_SyncFilters.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupbox_SyncTask;
        private System.Windows.Forms.RadioButton radioBtn_TwoWay;
        private System.Windows.Forms.RadioButton radioBtn_OneWay;
        private System.Windows.Forms.GroupBox groupBox_Schedule;
        private System.Windows.Forms.RadioButton radioBtn_days;
        private System.Windows.Forms.RadioButton radioBtn_hour;
        private System.Windows.Forms.RadioButton radioBtn_min;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.RadioButton radioBtn_OneTime;
        private System.Windows.Forms.GroupBox groupBox_SyncFilters;
        private System.Windows.Forms.TextBox textBox_IncludeFiles2;
        private System.Windows.Forms.TextBox textBox_ExcludeFiles2;
        private System.Windows.Forms.TextBox textBox_ExcludeFolders2;
        private System.Windows.Forms.TextBox textBox_IncludeFiles1;
        private System.Windows.Forms.TextBox textBox_ExcludeFiles1;
        private System.Windows.Forms.TextBox textBox_ExcludeFolders1;
        private System.Windows.Forms.CheckBox checkBox_IncludeFiles2;
        private System.Windows.Forms.CheckBox checkBox_ExcludeFiles2;
        private System.Windows.Forms.CheckBox checkBox_ExcludeFolders2;
        private System.Windows.Forms.CheckBox checkBox_IncludeFiles1;
        private System.Windows.Forms.CheckBox checkBox_ExcludeFiles1;
        private System.Windows.Forms.CheckBox checkBox_ExcludeFolders1;
        private System.Windows.Forms.Label lbl_Folder2Filter;
        private System.Windows.Forms.Label lbl_Folder1Filter;
        private System.Windows.Forms.NumericUpDown numericUpDown_days;
        private System.Windows.Forms.NumericUpDown numericUpDown_hours;
        private System.Windows.Forms.NumericUpDown numericUpDown_minutes;
    }
}

