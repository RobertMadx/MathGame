using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LearningMathmatics
{
    //Please reference link below for origin of this class
    //It would appear it is not easy to change the color of the progress bar and this is what this class enable us to do.
    //https://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
