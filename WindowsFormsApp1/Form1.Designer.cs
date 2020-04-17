namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_setting = new System.Windows.Forms.TabControl();
            this.tabPage_display = new System.Windows.Forms.TabPage();
            this.radioButton_transparent = new System.Windows.Forms.RadioButton();
            this.radioButton_opacity = new System.Windows.Forms.RadioButton();
            this.checkBox_preview = new System.Windows.Forms.CheckBox();
            this.groupBox_opacity = new System.Windows.Forms.GroupBox();
            this.textBox_opacity = new System.Windows.Forms.TextBox();
            this.trackBar_opacity = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_run = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_setting.SuspendLayout();
            this.tabPage_display.SuspendLayout();
            this.groupBox_opacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(453, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem_about});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem_about
            // 
            this.aboutToolStripMenuItem_about.Name = "aboutToolStripMenuItem_about";
            this.aboutToolStripMenuItem_about.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem_about.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl_setting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 366);
            this.panel1.TabIndex = 1;
            // 
            // tabControl_setting
            // 
            this.tabControl_setting.Controls.Add(this.tabPage_display);
            this.tabControl_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_setting.Location = new System.Drawing.Point(0, 0);
            this.tabControl_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_setting.Name = "tabControl_setting";
            this.tabControl_setting.SelectedIndex = 0;
            this.tabControl_setting.Size = new System.Drawing.Size(453, 366);
            this.tabControl_setting.TabIndex = 0;
            // 
            // tabPage_display
            // 
            this.tabPage_display.Controls.Add(this.radioButton_transparent);
            this.tabPage_display.Controls.Add(this.radioButton_opacity);
            this.tabPage_display.Controls.Add(this.checkBox_preview);
            this.tabPage_display.Controls.Add(this.groupBox_opacity);
            this.tabPage_display.Location = new System.Drawing.Point(4, 25);
            this.tabPage_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_display.Name = "tabPage_display";
            this.tabPage_display.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_display.Size = new System.Drawing.Size(445, 337);
            this.tabPage_display.TabIndex = 1;
            this.tabPage_display.Text = "Display";
            this.tabPage_display.UseVisualStyleBackColor = true;
            // 
            // radioButton_transparent
            // 
            this.radioButton_transparent.AutoSize = true;
            this.radioButton_transparent.Location = new System.Drawing.Point(25, 153);
            this.radioButton_transparent.Name = "radioButton_transparent";
            this.radioButton_transparent.Size = new System.Drawing.Size(107, 21);
            this.radioButton_transparent.TabIndex = 1;
            this.radioButton_transparent.Tag = "group1";
            this.radioButton_transparent.Text = "Transparent";
            this.radioButton_transparent.UseVisualStyleBackColor = true;
            this.radioButton_transparent.CheckedChanged += new System.EventHandler(this.radioButton_transparent_CheckedChanged);
            // 
            // radioButton_opacity
            // 
            this.radioButton_opacity.AutoSize = true;
            this.radioButton_opacity.Checked = true;
            this.radioButton_opacity.Location = new System.Drawing.Point(34, 28);
            this.radioButton_opacity.Name = "radioButton_opacity";
            this.radioButton_opacity.Size = new System.Drawing.Size(77, 21);
            this.radioButton_opacity.TabIndex = 1;
            this.radioButton_opacity.TabStop = true;
            this.radioButton_opacity.Tag = "group1";
            this.radioButton_opacity.Text = "Opacity";
            this.radioButton_opacity.UseVisualStyleBackColor = true;
            this.radioButton_opacity.CheckedChanged += new System.EventHandler(this.radioButton_opacity_CheckedChanged);
            // 
            // checkBox_preview
            // 
            this.checkBox_preview.AutoSize = true;
            this.checkBox_preview.Location = new System.Drawing.Point(25, 197);
            this.checkBox_preview.Name = "checkBox_preview";
            this.checkBox_preview.Size = new System.Drawing.Size(79, 21);
            this.checkBox_preview.TabIndex = 5;
            this.checkBox_preview.Text = "Preview";
            this.checkBox_preview.UseVisualStyleBackColor = true;
            this.checkBox_preview.CheckedChanged += new System.EventHandler(this.checkBox_preview_CheckedChanged);
            // 
            // groupBox_opacity
            // 
            this.groupBox_opacity.Controls.Add(this.textBox_opacity);
            this.groupBox_opacity.Controls.Add(this.trackBar_opacity);
            this.groupBox_opacity.Location = new System.Drawing.Point(25, 55);
            this.groupBox_opacity.Name = "groupBox_opacity";
            this.groupBox_opacity.Size = new System.Drawing.Size(388, 92);
            this.groupBox_opacity.TabIndex = 3;
            this.groupBox_opacity.TabStop = false;
            this.groupBox_opacity.Text = "Setting Opacity";
            // 
            // textBox_opacity
            // 
            this.textBox_opacity.Location = new System.Drawing.Point(290, 21);
            this.textBox_opacity.Name = "textBox_opacity";
            this.textBox_opacity.Size = new System.Drawing.Size(49, 22);
            this.textBox_opacity.TabIndex = 2;
            this.textBox_opacity.TextChanged += new System.EventHandler(this.textBox_opacity_TextChanged);
            // 
            // trackBar_opacity
            // 
            this.trackBar_opacity.BackColor = System.Drawing.Color.White;
            this.trackBar_opacity.Location = new System.Drawing.Point(23, 21);
            this.trackBar_opacity.Maximum = 100;
            this.trackBar_opacity.Name = "trackBar_opacity";
            this.trackBar_opacity.Size = new System.Drawing.Size(261, 56);
            this.trackBar_opacity.TabIndex = 2;
            this.trackBar_opacity.Scroll += new System.EventHandler(this.trackBar_opacity_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button_run);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 79);
            this.panel2.TabIndex = 2;
            // 
            // button_run
            // 
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Location = new System.Drawing.Point(298, 18);
            this.button_run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(119, 50);
            this.button_run.TabIndex = 0;
            this.button_run.Text = "RUN";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mouse And Keyboard Detect";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl_setting.ResumeLayout(false);
            this.tabPage_display.ResumeLayout(false);
            this.tabPage_display.PerformLayout();
            this.groupBox_opacity.ResumeLayout(false);
            this.groupBox_opacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem_about;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_setting;
        private System.Windows.Forms.TabPage tabPage_display;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.RadioButton radioButton_transparent;
        private System.Windows.Forms.RadioButton radioButton_opacity;
        private System.Windows.Forms.GroupBox groupBox_opacity;
        private System.Windows.Forms.TrackBar trackBar_opacity;
        private System.Windows.Forms.TextBox textBox_opacity;
        private System.Windows.Forms.CheckBox checkBox_preview;
    }
}

