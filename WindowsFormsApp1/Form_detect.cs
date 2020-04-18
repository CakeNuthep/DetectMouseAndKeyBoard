using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_detect : Form
    {
        Image image_mouse_right_click;
        Image image_mouse_left_click;
        Image image_mouse;
        int timeClear;
        DateTime lastTimePress;
        List<HotKeyModel> listGroupKey;

        #region move winform
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion end move winform

        private void KeyDown2(KeyboardHookEventArgs e)
        {
            // handle keydown event here
            // Such as by checking if e (KeyboardHookEventArgs) matches the key you're interested in
            lastTimePress = DateTime.Now;
            int count = 0;
            string message = "";
            if (e.isCtrlPressed)
            {
                if (count == 0)
                {
                    message += "Ctrl";
                }
                else
                {
                    message += " + Ctrl";
                }
                count++;
            }
            if (e.isShiftPressed)
            {
                if (count == 0)
                {
                    message += "Shift";
                }
                else
                {
                    message += " + Shift";
                }
                count++;
            }
            if (e.isAltPressed)
            {
                if (count == 0)
                {
                    message += "alt";
                }
                else
                {
                    message += " + alt";
                }
                count++;
            }
            if (e.isWinPressed)
            {
                if (count == 0)
                {
                    message += "win";
                }
                else
                {
                    message += " + win";
                }
                count++;
            }
            if(e.Key != Keys.None)
            {
                KeysConverter kc = new KeysConverter();

                string letter = kc.ConvertToString(e.Key);
                if(e.Key == Keys.Add || e.Key == Keys.Oemplus)
                {
                    letter = "Plus";
                }
                else if(e.Key == Keys.Subtract || e.Key == Keys.OemMinus)
                {
                    letter = "Suntract";
                }
                else if(e.Key == Keys.OemQuestion)
                {
                    letter = "Question";
                }
                else if(e.Key == Keys.OemSemicolon)
                {
                    letter = "Semicolon";
                }
                else if(e.Key == Keys.OemQuotes)
                {
                    letter = "Quotes";
                }
                else if(e.Key == Keys.OemPeriod)
                {
                    letter = "Dot";
                }
                else if(e.Key == Keys.Oemcomma)
                {
                    letter = "Comma";
                }
                else if(e.Key == Keys.Oem5)
                {
                    letter = "Backslash";
                }

                if (count == 0)
                {
                    message += $"{letter}";
                }
                else
                {
                    message += $" + {letter}";
                }


                count++;
            }
            showKeyboard(message);
        }

        public void setShowTextKeyboardDefault()
        {
            string textSample = ConfigurationManager.AppSettings["TEXT_EXAMPLE"];
            label_keyboard.Text = textSample;
        }

    

        public Form_detect(bool isRun)
        {
            InitializeComponent();
            lastTimePress = DateTime.Now;
            listGroupKey = new List<HotKeyModel>();
            if (isRun)
            {
                run();
            }

            string pathImageMouseLeftClick = ConfigurationManager.AppSettings["IMAGE_MOUSE_LEFT_CLICK"];
            string pathImageMouseRightClick = ConfigurationManager.AppSettings["IMAGE_MOUSE_RIGHT_CLICK"];
            string pathImageMouse = ConfigurationManager.AppSettings["IMAGE_MOUSE"];
            timeClear = int.Parse(ConfigurationManager.AppSettings["TIME_CLEAR"]);
            image_mouse_right_click = Image.FromFile(pathImageMouseRightClick);
            image_mouse_left_click = Image.FromFile(pathImageMouseLeftClick);
            image_mouse = Image.FromFile(pathImageMouse);

        }

        public void setFont(Font font,Color color)
        {
            label_keyboard.Font = font;
            label_keyboard.ForeColor = color;
        }

        public void run()
        {
            timer_clear.Start();
            listGroupKey.Sort(delegate (HotKeyModel x, HotKeyModel y)
            {
                
                return y.groupKey.Count.CompareTo(x.groupKey.Count);
            });
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.MouseDown += new MouseEventHandler(move_window); // binding the method to the event
            
            Hook KeyboardHook = new Hook("Global Action Hook");
            KeyboardHook.KeyDownEvent += KeyDown2;
            setDetectMouse();
        }

       public void insertHotKey(List<Keys> groupKey,string displayMessage)
       {
            if(listGroupKey != null)
            {
                listGroupKey.Add(new HotKeyModel { groupKey = groupKey,display=displayMessage });
            }
       }

        public void clearHotKey()
        {
            if(listGroupKey != null)
            {
                listGroupKey.Clear();
            }
        }

        private void showKeyboard(string msg)
        {
            if (label_keyboard.Text != msg)
            {
                label_keyboard.Text = msg;
            }
        }

        private void showMouse(Image image)
        {
            pictureBox_mouse.Image = image;
        }


        void setDetectMouse()
        {
            Gma.System.MouseKeyHook.Hook.GlobalEvents().MouseDown += async (sender, e) =>
            {
                //Console.WriteLine($"Mouse {e.Button} Down");
                if (e.Button == MouseButtons.Left)
                {
                    showMouse(image_mouse_left_click);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    showMouse(image_mouse_right_click);
                }
            };

            Gma.System.MouseKeyHook.Hook.GlobalEvents().MouseUp += (sender, e) =>
            {
                //Console.WriteLine($"Mouse {e.Button} button double clicked.");
                showMouse(image_mouse);
            };
        }

        #region set disable clos Button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion end set disable clos Button

        private void Form_detect_Load(object sender, EventArgs e)
        {
            
        }

        public void setDraggable(bool enable)
        {
            ControlExtension.Draggable(label_keyboard, enable);
            ControlExtension.Draggable(pictureBox_mouse, enable);
        }

        private void timer_clear_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            if((currentDateTime - lastTimePress).TotalMilliseconds > timeClear)
            {
                showKeyboard("");
            }
        }
    }
}
