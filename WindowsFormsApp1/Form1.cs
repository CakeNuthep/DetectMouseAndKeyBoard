using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form_detect detectForm;
        bool isRun;
        public Form1()
        {
            InitializeComponent();
            isRun = false;
            detectForm = new Form_detect(isRun);
            
            detectForm.Show();
            detectForm.Visible = false;
        }

        private void button_run_Click(object sender, EventArgs e)
        {

            if (!isRun)
            {
                isRun = true;

                //detectForm.insertHotKey(new List<Keys> { Keys.F12 }, "F12");
                //detectForm.insertHotKey(new List<Keys> { Keys.ControlKey, Keys.ShiftKey, Keys.F12 }, "Ctrl+Shift+F12");
                //detectForm.insertHotKey(new List<Keys> { Keys.ControlKey, Keys.ShiftKey }, "Ctrl+Shift");
                //detectForm.insertHotKey(new List<Keys> { Keys.ControlKey }, "Ctrl");
                detectForm.run();
                
                button_run.Text = "STOP";
            }
            else
            {
                isRun = false;
                if(detectForm != null)
                {
                    detectForm.FormBorderStyle = FormBorderStyle.Sizable;
                    detectForm.Visible = false;
                }
                checkBox_preview.Checked = false;
                button_run.Text = "RUN";
            }
        }

        private void radioButton_opacity_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_opacity.Checked)
            {
                groupBox_opacity.Enabled = true;
                detectForm.TransparencyKey = Color.LimeGreen;
            }
            else
            {
                groupBox_opacity.Enabled = false;
            }
        }

        private void checkBox_preview_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_preview.Checked)
            {
                detectForm.Visible = true;
            }
            else
            {
                if(!detectForm.IsDisposed)
                {
                    detectForm.Visible = false;
                }
            }
        }

        private void radioButton_transparent_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_transparent.Checked)
            {
                detectForm.TransparencyKey = Color.White;
            }
        }

        private void trackBar_opacity_Scroll(object sender, EventArgs e)
        {
            textBox_opacity.Text = "" + trackBar_opacity.Value;
        }

        private void textBox_opacity_TextChanged(object sender, EventArgs e)
        {
            double opacity;
            if(double.TryParse(textBox_opacity.Text,out opacity))
            {
                detectForm.Opacity = opacity/(trackBar_opacity.Maximum)*1.0;
            }
        }

        private void button_fontSetting_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            label_fontSample.Font = fontDialog1.Font;
            label_fontSample.ForeColor = fontDialog1.Color;

            detectForm.setFont(fontDialog1.Font, fontDialog1.Color);


        }
    }
}
