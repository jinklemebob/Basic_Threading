using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace _04LabExercise1
{
    public partial class FrmBasicThread : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        Thread Thread1;
        Thread Thread2;
        MyThreadClass threadStart;

        public FrmBasicThread()
        {
            InitializeComponent();
            threadStart = new MyThreadClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();

            Console.WriteLine("-Before starting thread-");

            Thread1 = new Thread(MyThreadClass.Thread1);
            Thread1.Name = "Thread A";

            Thread2 = new Thread(MyThreadClass.Thread1);
            Thread2.Name = "Thread B";

            Thread1.Start();
            Thread2.Start();

            Thread1.Join();
            Thread2.Join();

            label1.Text = "-- End Of Thread --";
        }
    }
}