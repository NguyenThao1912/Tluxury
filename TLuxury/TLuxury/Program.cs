using StoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLuxury.Forms;

namespace TLuxury
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Khởi Tạo Kết nối
            GlobalConfig.InitializeConnections();
            Application.Run(new MainForm());
        }
    }
}
