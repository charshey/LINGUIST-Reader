using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    // Note: this class was designed by StackOverflow user ng5000 as a solution to the problem of suspending painting of a graphical object 
    // while a large number of controls are being added to it. It's such a simple and straightforward solution to this problem, I used it 
    // in my application in Browse.cs. 
    // Source: https://stackoverflow.com/a/487757

    /// <summary>
    /// Class DrawingControl provides functions to suspend and resume drawing of a control.
    /// </summary>
    class DrawingControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        /// <summary>
        /// Suspends the drawing of a control.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        /// <summary>
        /// Resumes the drawing of a control.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
}
