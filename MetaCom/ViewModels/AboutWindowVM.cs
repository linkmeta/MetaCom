using MetaCom.Models;

namespace MetaCom.ViewModels
{
    internal class AboutViewModel : MainWindowBase
    {
        public HelpModel HelpModel { get; set; }

        public AboutViewModel()
        {
            HelpModel = new HelpModel();
            HelpModel.HelpDataContext();
        }
    }
}
