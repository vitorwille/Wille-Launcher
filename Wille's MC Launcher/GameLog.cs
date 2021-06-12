using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wille_s_MC_Launcher
{
    public partial class GameLog : Form
    {
        public GameLog()
        {
            InitializeComponent();
        }

        static ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();

        internal static void AddLog(string msg)
        {
            logQueue.Enqueue(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string msg;
            while (logQueue.TryDequeue(out msg))
            {
                txtLog.AppendText(msg + "\n");
            }
        }
    }
}
