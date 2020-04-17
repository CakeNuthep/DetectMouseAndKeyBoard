namespace WindowsFormsApp1
{
    partial class Form_detect
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
            this.label_keyboard = new System.Windows.Forms.Label();
            this.pictureBox_mouse = new System.Windows.Forms.PictureBox();
            this.timer_clear = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label_keyboard
            // 
            this.label_keyboard.AutoSize = true;
            this.label_keyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_keyboard.Location = new System.Drawing.Point(35, 60);
            this.label_keyboard.Name = "label_keyboard";
            this.label_keyboard.Size = new System.Drawing.Size(226, 32);
            this.label_keyboard.TabIndex = 0;
            this.label_keyboard.Text = "Ctrl + Shift + F12";
            // 
            // pictureBox_mouse
            // 
            this.pictureBox_mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_mouse.Image = global::WindowsFormsApp1.Properties.Resources.mouse_left_click;
            this.pictureBox_mouse.Location = new System.Drawing.Point(282, 12);
            this.pictureBox_mouse.Name = "pictureBox_mouse";
            this.pictureBox_mouse.Size = new System.Drawing.Size(104, 99);
            this.pictureBox_mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_mouse.TabIndex = 1;
            this.pictureBox_mouse.TabStop = false;
            // 
            // timer_clear
            // 
            this.timer_clear.Interval = 300;
            this.timer_clear.Tick += new System.EventHandler(this.timer_clear_Tick);
            // 
            // Form_detect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 137);
            this.Controls.Add(this.pictureBox_mouse);
            this.Controls.Add(this.label_keyboard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_detect";
            this.Text = "Form_detect";
            this.Load += new System.EventHandler(this.Form_detect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_keyboard;
        private System.Windows.Forms.PictureBox pictureBox_mouse;
        private System.Windows.Forms.Timer timer_clear;
    }
}