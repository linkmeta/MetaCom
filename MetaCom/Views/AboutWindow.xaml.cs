using MetaCom.ViewModels;
using System.Diagnostics;
using System.Windows;

namespace MetaCom.Views
{
    /// <summary>
    /// AboutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AboutWindow : Window
    {
        internal AboutViewModel aboutViewModel = null;

        public AboutWindow()
        {
            InitializeComponent();

            Height = 300;
            Width = Height / 0.725;

            aboutViewModel = new AboutViewModel();
            DataContext = aboutViewModel;
        }
        private void GithubButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/linkmeta/MetaCom");

            Close();
        }
        private void GiteeButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://gitee.com/linkmeta/MetaCom");

            Close();
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://gitee.com/linkmeta/MetaCom/releases");

            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
