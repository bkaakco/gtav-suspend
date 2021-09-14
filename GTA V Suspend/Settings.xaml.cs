using System.Windows;
using System.Windows.Controls;

namespace GTA_V_Suspend
{
    /// <summary>
    /// Settings.xaml etkileşim mantığı
    /// </summary>
    
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        public void Translate()
        {
            LabelGame.Content = Properties.Resources.Settings_Label_Game;
            LabelSettings.Content = Properties.Resources.Settings_LabelSettings;
            CboxShortcut.Content = Properties.Resources.Settings_Cbox_EnableKey;
            LabelShortcut.Content = Properties.Resources.Settings_Label_Shortcut;
            LabelApp.Content = Properties.Resources.Settings_Label_App;
            CboxBackToGame.Content = Properties.Resources.Settings_Cbox_BackToGame;
            LabelSuspendTime.Content = Properties.Resources.Settings_Label_SuspendTime;
            LabelLanguage.Content = Properties.Resources.Settings_Label_Language;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Back
        {
            MainWindow mainw = new MainWindow();
            mainw.Translate();
            ((Grid)this.Parent).Children.Remove(this);  
        }

        private void ComboboxTime_SelectionChanged(object sender, SelectionChangedEventArgs e) // Combobox selections for suspend time
        {
            switch (ComboboxTime.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.Sayac = 8;
                    break;
                case 1:
                    Properties.Settings.Default.Sayac = 9;
                    break;
                case 2:
                    Properties.Settings.Default.Sayac = 10;
                    break;
                case 3:
                    Properties.Settings.Default.Sayac = 11;
                    break;
            }

            Properties.Settings.Default.Save();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) // Settings user control (this) load event 
        {
            switch (Properties.Settings.Default.Dil)
            {
                case "tr-TR":
                    ComboboxLanguage.SelectedIndex = 0;
                    break;
                case "en-US":
                    ComboboxLanguage.SelectedIndex = 1;
                    break;
            }

            switch (Properties.Settings.Default.Sayac)
            {
                case 8:
                    ComboboxTime.SelectedIndex = 0;
                    break;
                case 9:
                    ComboboxTime.SelectedIndex = 1;
                    break;
                case 10:
                    ComboboxTime.SelectedIndex = 2;
                    break;
                case 11:
                    ComboboxTime.SelectedIndex = 3;
                    break;
            }

            CboxShortcut.IsChecked = Properties.Settings.Default.Kısayol;
            CboxBackToGame.IsChecked = Properties.Settings.Default.OtoSurdur;
        }

        private void ComboboxLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e) // Combobox selection for language setting
        {
            switch (ComboboxLanguage.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.Dil = "tr-TR";
                    break;

                case 1:
                    Properties.Settings.Default.Dil = "en-US";
                    break;            
            }
            Translate();
            Properties.Settings.Default.Save();
        }

        private void CboxShortcut_Click(object sender, RoutedEventArgs e)
        {
            if (CboxShortcut.IsChecked == false)
            {
                Properties.Settings.Default.Kısayol = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Kısayol = true;
                Properties.Settings.Default.Save();
            }
        }

        private void CboxBackToGame_Click(object sender, RoutedEventArgs e)
        {
            if (CboxBackToGame.IsChecked == false)
            {
                Properties.Settings.Default.OtoSurdur = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.OtoSurdur = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
