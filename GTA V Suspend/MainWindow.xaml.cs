using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using static GTA_V_Suspend.KeyBoardHook;

namespace GTA_V_Suspend
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>

    public partial class MainWindow : Window
    {
        private KeyBoardHook dinleyici; // define listener

        private const int SW_MINIMIZE = 6;
        private const int SW_MAX = 10;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_SHOWNORMAL = 1;

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //  

        public MainWindow()
        {
            InitializeComponent();

            Properties.Settings.Default.PropertyChanged += SetLanguage;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
        }

      public void SetLanguage(object sender, PropertyChangedEventArgs e) // language switch
        {
            string dil = Properties.Settings.Default.Dil.ToString();

            //kültür
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(dil);
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(dil);

            Translate();
        }

        int sayac = 0; // suspend timer

        DispatcherTimer timer = new DispatcherTimer(); // define suspent timer

        void timer_Tick(object sender, EventArgs e) // start suspent timer
        {
            LabelTime.Content = sayac++ + Properties.Resources.time;


            if (sayac > Properties.Settings.Default.Sayac) // resume when timer reach limit
            {
                if (Properties.Settings.Default.OtoSurdur == true) // if back to game is enabled
                {
                    ResumeProcess(Convert.ToInt32(LabelPid.Content));

                    var p = Process.GetProcessesByName("GTA5").FirstOrDefault();
                    ShowWindow(p.MainWindowHandle, SW_SHOWNORMAL);
                }

                else
                {
                    ResumeProcess(Convert.ToInt32(LabelPid.Content));
                }                             
            }                    
        }

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        private void SuspendProcess()
        {
            try
            {
                var p1 = Process.GetProcessesByName("GTA5");
                int id = 0;

                foreach (var process in p1)
                {
                    id = process.Id;
                    LabelPid.Content = id.ToString();
                }

                if (LabelPid.Content.ToString() == id.ToString()) // start suspend
                {
                    ButtonSuspend.IsEnabled = false;
                    LabelStatus.Content = Properties.Resources.status_success;

                    timer.Start();

                    // back to desktop when suspend
                    var p = Process.GetProcessesByName("GTA5").FirstOrDefault();
                    ShowWindow(p.MainWindowHandle, SW_MINIMIZE);

                    var p2 = Process.GetProcessById(id);

                    foreach (ProcessThread pT in p2.Threads)
                    {
                        IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                        if (pOpenThread == IntPtr.Zero)
                        {
                            continue;
                        }

                        SuspendThread(pOpenThread);
                        //   CloseHandle(pOpenThread);
                    }                  
                }

                else
                {
                    LabelPid.Content = Properties.Resources.id_failed;
                    LabelStatus.Content = Properties.Resources.status_failed;
                }
            }
            catch
            {
                LabelStatus.Content = Properties.Resources.failed;
            }
        }

        public void ResumeProcess(int pid) // suspend finish
        {
            timer.Stop();

            ButtonSuspend.IsEnabled = true;

            LabelStatus.Content = Properties.Resources.status;
            sayac = 0;
            LabelTime.Content = "0" + Properties.Resources.time;

            Process process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                int suspendCount;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                   
                } while (suspendCount > 0);
             
             //   CloseHandle(pOpenThread);
            }
        }

        private void ButtonResume_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResumeProcess(Convert.ToInt32(LabelPid.Content));
            }
            catch
            {
            }
        }    

       public void Translate()
        {
            ButtonSuspend.Content = Properties.Resources.b_sus;
            ButtonResume.Content = Properties.Resources.b_res;
            LabelPidHeader.Content = Properties.Resources.desc_id;
            LabelPid.Content = Properties.Resources.id;
            LabelStatusHeader.Content = Properties.Resources.desc_status;
            LabelStatus.Content = Properties.Resources.status;
            LabelTimeHeader.Content = Properties.Resources.desc_time;
            LabelTime.Content = "0" + Properties.Resources.time;
        }

        private void MainW_Loaded(object sender, RoutedEventArgs e)
        {
            string dil = Properties.Settings.Default.Dil.ToString();

            // Culture
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(dil);
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(dil);

            // Language
            Translate();

            // Get PID if game is running

            var p1 = Process.GetProcessesByName("GTA5");
            int id = 0;

            foreach (var process in p1)
            {
                id = process.Id;
                LabelPid.Content = id.ToString();
            }

            if (LabelPid.Content.ToString() == id.ToString())
            {
                LabelPid.Content = id.ToString();
            }

            // Enable listener when key press

            dinleyici = new KeyBoardHook();
            dinleyici.OnKeyPressed += Dinleyici_Tusabasildi;
            dinleyici.HookKeyboard();          
        }

        void Dinleyici_Tusabasildi(object sender, KeyPressedArgs e)
        {
            if (Properties.Settings.Default.Kısayol == true)
            {
                if (e.KeyPressed == Key.L && Keyboard.Modifiers == (ModifierKeys.Control | ModifierKeys.Shift))
                {
                    SuspendProcess();
                }
            }          
        }

        private void ButtonSuspend_Click(object sender, RoutedEventArgs e)
        {
            SuspendProcess();
        }

        private void MainW_Closing(object sender, CancelEventArgs e)
        {
            dinleyici.UnHookKeyboard();
            Environment.Exit(0);
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {            
            Settings s = new Settings();
            s.Margin = new Thickness(0, 0, 0, 0);
            GridM.Children.Add(s);
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            About a = new About();
            a.Margin = new Thickness(0, 0, 0, 0);
            GridM.Children.Add(a);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Culture
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("tr-TR");

            Translate();
        }
    }
}
