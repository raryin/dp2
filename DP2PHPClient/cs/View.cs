using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2PHPClient
{
    static class View
    {
        /// <summary>
        /// Shows a message box for error messages. Expects no return value.
        /// </summary>
        /// <param name="text">Text for the main message.</param>
        /// <param name="caption">Caption for the error.</param>
        static public void ErrorNotify(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Shows a message box for success messages. Expects no return value.
        /// </summary>
        /// <param name="text">Text for the main message.</param>
        /// <param name="caption">Caption for the message.</param>
        static public void SuccessNotify(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }

    }
}
