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

        private void btn_StartSynch_Click(object sender, EventArgs e)
        { 
        }

        private void txb_Path_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txb_Path_2_TextChanged(object sender, EventArgs e)
        {
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_OneWay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_TwoWay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioBtn_OneTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_OneTime.Checked)
            {
                textBox_min.Enabled = false;
                textBox_hours.Enabled = false;
                textBox_days.Enabled = false;
            }
        }

        private void radioBtn_10min_CheckedChanged(object sender, EventArgs e)
        {
            //textBox_min.Enabled = radioBtn_min.Checked;
            if (radioBtn_min.Checked)
            {
                textBox_min.Enabled = true;
                textBox_hours.Enabled = false;
                textBox_days.Enabled = false;
            }
            else
            {
                textBox_min.Enabled = false;
            }
        }

        private void radioBtn_1hour_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_hour.Checked)
            {
                textBox_min.Enabled = false;
                textBox_hours.Enabled = true;
                textBox_days.Enabled = false;
            }
            else
            {
                textBox_hours.Enabled = false;
            }
        }

        private void radioBtn_24hours_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_days.Checked)
            {
                textBox_min.Enabled = false;
                textBox_hours.Enabled = false;
                textBox_days.Enabled = true;
            }
            else
            {
                textBox_days.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_min.Focused)
            //{
            //    radioBtn_min.Checked = true;
            //}
        }

        private void textBox_hours_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_days_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Schedule_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_hours_Click(object sender, EventArgs e)
        {

        }



        private void radioBtn_OneWay_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
