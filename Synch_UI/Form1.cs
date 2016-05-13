using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Synch_UI
{
    public partial class Main_Form : Form
    {


        public Main_Form()
        {
            InitializeComponent();
        }

        Synchronizator synch = new Synchronizator();

        private void btn_StartSynch_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioBtn_OneTime.Checked)
                {
                    synch.OnceSynch();
                }
                else
                {
                    if (radioBtn_min.Checked)
                    {
                        int min = 0;
                        if (int.TryParse(numericUpDown_minutes.Text, out min))
                        {
                            synch.ScheduledMinSynchronize(min);
                        }
                    }
                    else
                    {
                        if (radioBtn_hour.Checked)
                        {
                            int hour = 0;
                            if (int.TryParse(numericUpDown_hours.Text, out hour))
                            {
                                synch.ScheduledHourSynchronize(hour);
                            }
                        }
                        else
                        {
                            if (radioBtn_days.Checked)
                            {
                                int day = 0;
                                if (int.TryParse(numericUpDown_days.Text, out day))
                                {
                                    synch.ScheduledDaySynchronize(day);
                                }
                            }
                        }
                    }
                }
            }

            catch (System.ArgumentException)
            {
                MessageBox.Show("Please enter path to folders that are going to be synchronized");
            }
        }

        private void radioBtn_OneWay_CheckedChanged_1(object sender, EventArgs e)
        {
            synch.SyncDirection = SyncDirectionEnum.LocalToRemote;
        }

        private void radioBtn_TwoWay_CheckedChanged_1(object sender, EventArgs e)
        {
            synch.SyncDirection = SyncDirectionEnum.BothDirection;
        }

        private void txb_Path_1_TextChanged(object sender, EventArgs e)
        {
            synch.LocalPath = txb_Path_1.Text;
        }

        private void txb_Path_1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txb_Path_1.Text == "Enter Path to Folder 1")
            {
                txb_Path_1.Text = string.Empty;
            }
        }

        private void txb_Path_2_TextChanged(object sender, EventArgs e)
        {
            synch.RemotePath = txb_Path_2.Text;
        }

        private void txb_Path_2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txb_Path_2.Text == "Enter Path to Folder 2")
            {
                txb_Path_2.Clear();
            }
        }        

        private void btn_Browse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldBrwDialog_Browse1 = new FolderBrowserDialog();
            fldBrwDialog_Browse1.RootFolder = Environment.SpecialFolder.Desktop;
            fldBrwDialog_Browse1.Description = "Select path to folder 1";
            fldBrwDialog_Browse1.ShowNewFolderButton = false;

            if (fldBrwDialog_Browse1.ShowDialog() == DialogResult.OK) 
            {
                txb_Path_1.Text = fldBrwDialog_Browse1.SelectedPath;
            }
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldBrwDialog_Browse2 = new FolderBrowserDialog();
            fldBrwDialog_Browse2.RootFolder = Environment.SpecialFolder.Desktop;
            fldBrwDialog_Browse2.Description = "Select path to folder 2";
            fldBrwDialog_Browse2.ShowNewFolderButton = true ;

            if (fldBrwDialog_Browse2.ShowDialog() == DialogResult.OK) 
            {
                txb_Path_2.Text = fldBrwDialog_Browse2.SelectedPath;
            }
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioBtn_OneWay_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioBtn_TwoWay_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}

        private void radioBtn_OneTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_OneTime.Checked)
            {
                numericUpDown_minutes.Enabled = false;
                numericUpDown_hours.Enabled = false;
                numericUpDown_days.Enabled = false;
            }
        }

        private void radioBtn_min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_min.Checked)
            {
                numericUpDown_minutes.Enabled = true;
                numericUpDown_hours.Enabled = false;
                numericUpDown_days.Enabled = false;
            }
            else
            {
                numericUpDown_minutes.Enabled = false;
            }
        }

        private void radioBtn_hour_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_hour.Checked)
            {
                numericUpDown_minutes.Enabled = false;
                numericUpDown_hours.Enabled = true;
                numericUpDown_days.Enabled = false;
            }
            else
            {
                numericUpDown_hours.Enabled = false;
            }
        }

        private void radioBtn_day_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_days.Checked)
            {
                numericUpDown_minutes.Enabled = false;
                numericUpDown_hours.Enabled = false;
                numericUpDown_days.Enabled = true;
            }
            else
            {
                numericUpDown_days.Enabled = false;
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox_hours_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox_days_TextChanged(object sender, EventArgs e)
        //{

        //}
        //group with radiobuttons and numericUpDown to select schedule
        private void groupBox_Schedule_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown_minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_hours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_days_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void lbl_hours_Click(object sender, EventArgs e)
        //{

        //}



        //private void radioBtn_Folder1_CheckedChanged(object sender, EventArgs e)
        //{


        //}

        //private void radioBtn_Folder2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void checkBox_ExcludeFolders1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFolders1.Checked)
            {
                textBox_ExcludeFolders1.Enabled = true;
            }
            else
            {
                textBox_ExcludeFolders1.Enabled = false;
            }
        }

        private void textBox_ExcludeFolders1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFolders1.Checked)
            {
                synch.ExcludeFoldersLocalPath = textBox_ExcludeFolders1.Text;
            }
            else
            {
                synch.ClearExcludeFoldersLocalPath();
            }
        }

        private void checkBox_ExcludeFiles1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFiles1.Checked)
            {
                textBox_ExcludeFiles1.Enabled = true;
            }
            else
            {
                textBox_ExcludeFiles1.Enabled = false;
            }
        }

        private void textBox_ExcludeFiles1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFiles1.Checked)
            {
                synch.ExcludeFilesLocalPath = textBox_ExcludeFiles1.Text;
            }
            else
            {
                synch.ClearExcludeFilesLocalPath();
            }
        }

        private void checkBox_IncludeFiles1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludeFiles1.Checked)
            {
                textBox_IncludeFiles1.Enabled = true;
            }
            else
            {
                textBox_IncludeFiles1.Enabled = false;
            }
        }

        private void textBox_IncludeFiles1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludeFiles1.Checked)
            {
                synch.IncludeFilesLocalPath = textBox_IncludeFiles1.Text;
            }
            else
            {
                synch.ClearIncludeFilesLocalPath();
            }
        }

        private void checkBox_ExcludeFolders2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFolders2.Checked)
            {
                textBox_ExcludeFolders2.Enabled = true;
            }
            else
            {
                textBox_ExcludeFolders2.Enabled = false;
            }
        }

        private void textBox_ExcludeFolders2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFolders2.Checked)
            {
                synch.ExcludeFoldersRemotePath = textBox_ExcludeFolders2.Text;
            }
            else
            {
                synch.ClearExcludeFoldersRemotePath();
            }
        }

        private void checkBox_ExcludeFiles2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFiles2.Checked)
            {
                textBox_ExcludeFiles2.Enabled = true;
            }
            else
            {
                textBox_ExcludeFiles2.Enabled = false;
            }
        }

        private void textBox_ExcludeFiles2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_ExcludeFiles2.Checked)
            {
                synch.ExcludeFilesRemotePath = textBox_ExcludeFiles2.Text;
            }
            else
            {
                synch.ClearExcludeFilesRemotePath();
            }
        }

        private void checkBox_IncludeFiles2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludeFiles2.Checked)
            {
                textBox_IncludeFiles2.Enabled = true;
            }
            else
            {
                textBox_IncludeFiles2.Enabled = false;
            }
        }

        private void textBox_IncludeFiles2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludeFiles2.Checked)
            {
                synch.IncludeFilesRemotePath = textBox_IncludeFiles2.Text;
            }
            else
            {
                synch.ClearIncludeFilesRemotePath();
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
