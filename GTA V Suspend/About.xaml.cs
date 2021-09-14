using System.Windows;
using System.Windows.Controls;

namespace GTA_V_Suspend
{
    /// <summary>
    /// About.xaml etkileşim mantığı
    /// </summary>
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // back
        {
            ((Grid)this.Parent).Children.Remove(this);
        }

        public void Translate()
        {
            LabelAbout.Content = Properties.Resources.About_LabelAbout;
            LabelVersionHeader.Content = Properties.Resources.About_Label_VersionHeader;
            LabelProducerHeader.Content = Properties.Resources.About_Version_Producer;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Translate();
        }

        private void ButtonSite_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://bkaakco.blogspot.com");
        }

        private void ButtonGitHub_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bkaakco");
        }
    }
}
