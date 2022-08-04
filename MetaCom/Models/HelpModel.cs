using MetaCom.ViewModels;
using System;
using System.Runtime.Serialization;

namespace MetaCom.Models
{
    [DataContract]

    internal class HelpModel : MainWindowBase
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public string VerInfoNumber { get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        private string _VerInfo;
        public string VerInfo
        {
            get
            {
                return _VerInfo;
            }
            set
            {
                if (_VerInfo != value)
                {
                    _VerInfo = value;
                    RaisePropertyChanged(nameof(VerInfo));
                }
            }
        }
        public void HelpDataContext()
        {
            VerInfoNumber = "1.3.0";
            VerInfo = "MetaCom V" + VerInfoNumber;
        }
    }
}
