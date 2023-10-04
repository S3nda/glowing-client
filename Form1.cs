using System.Diagnostics;
using System.Runtime.InteropServices;


namespace glowing_client
{
    public partial class Form1 : Form
    {
        Point pos;
        bool mDown = false;
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9ClDwBTgDmAeXjmhqtRTPw");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CpsCount.Text = $"{trackbar.Value} CPS";

        }

        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            LeftClicker.Interval = 1000 / jittercps;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (autoBtn.Checked)
                        if (MouseButtons == MouseButtons.Left)
                        {
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                            Task.Delay(15).Wait();
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                        }
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int jittercps = 1;

        public bool ji { get; private set; }
        private void jitter_Tick(object sender, EventArgs e)
        {
            jittercps = new Random().Next(trackbar.Value - trackbar.Value * 40 / 100, trackbar.Value + trackbar.Value * 40 / 100);
            jittercps = new Random().Next(jittercps - jittercps * 40 / 100, jittercps + jittercps * 40 / 100);
        }

        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            pos.X = e.X;
            pos.Y = e.Y;
            mDown = true;
        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - pos.X, currentPos.Y - pos.Y);
            }
        }

        private void siticonePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        private void autoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (autoBtn.Checked)
            {
                trackbar.ThumbColor = Color.MediumPurple;
            }
            else
            {
                trackbar.ThumbColor = Color.DarkGray;
            }
            trackbar.Refresh();
        }

        private void BindBtn_KeyUp(object sender, KeyEventArgs e)
        {
            if (BindBtn.Text == "")
            {
                if (e.KeyCode == Keys.Escape)
                {
                    BindBtn.Text = "Bind";
                }
                else
                {
                    BindBtn.Text = e.KeyCode.ToString();
                }
            }
        }

        private void BindBtn_Click(object sender, EventArgs e)
        {
            BindBtn.Text = "";
        }
        public static KeysConverter Key = new KeysConverter();

        private void Bind_Tick(object sender, EventArgs e)
        {
            if (BindBtn.Text != "Bind")
            {
                if (BindBtn.Text != "")
                {
                    Keys key = (Keys)Key.ConvertFromString(BindBtn.Text);
                    if (GetAsyncKeyState(key) < 0)
                    {
                        autoBtn.Checked = !autoBtn.Checked;
                    }

                }
            }
        }
    }
}
