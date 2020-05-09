using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "";

            NotifyIcon notyfyIcon = new NotifyIcon();
            notyfyIcon.Visible = true;
            notyfyIcon.Icon = SystemIcons.Application;
            notyfyIcon.ShowBalloonTip(1000, "dsadas", "Daaaaaaaaaaaaaa", ToolTipIcon.Info);
            notyfyIcon.Dispose();

            Console.ReadKey();
        }
    }
}
