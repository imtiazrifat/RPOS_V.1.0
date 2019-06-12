using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RPOS.DLL;

namespace RPOS_V._1._0.Forms
{
    public partial class Login : MetroForm
    {
        private RposEntities _entities;
        public Login()
        {
            _entities = new RposEntities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateUser();
        }

        private void AuthenticateUser()
        {
            var userName = textBoxUserName.Text.Trim();
            var passWord = textBoxPassword.Text.Trim();


            if (userName.Length > 0 && passWord.Length > 0)
            {
                if (CheckUserNameAndPassword(userName, passWord))
                {

                    AutoClosingMessageBox.Show("Login Success", "Caption", 5000);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please! Enter User Name & Password", @"RPOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please! Enter User Name & Password", @"RPOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
        private bool CheckUserNameAndPassword(string userName, string passWord)
        {
            try
            {
                var aa = _entities.Users;
                return _entities.Users.Any(p => p.UserName == userName && p.Password == passWord);

            }
            catch (Exception)
            {
                MessageBox.Show("Please! User Name & Password Is Not Correct", @"RPOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
