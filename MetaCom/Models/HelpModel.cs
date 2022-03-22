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

        #region 状态栏 - 发送文件进度条可见性
        private string _StatusBarProgressBarVisibility;
        public string StatusBarProgressBarVisibility
        {
            get
            {
                return _StatusBarProgressBarVisibility;
            }
            set
            {
                if (_StatusBarProgressBarVisibility != value)
                {
                    _StatusBarProgressBarVisibility = value;
                    RaisePropertyChanged(nameof(StatusBarProgressBarVisibility));
                }
            }
        }

        private double _StatusBarProgressBarValue;
        public double StatusBarProgressBarValue
        {
            get
            {
                return _StatusBarProgressBarValue;
            }
            set
            {
                if (_StatusBarProgressBarValue != value)
                {
                    _StatusBarProgressBarValue = value;
                    RaisePropertyChanged(nameof(StatusBarProgressBarValue));
                }
            }
        }

        private bool _StatusBarProgressBarIsIndeterminate;
        public bool StatusBarProgressBarIsIndeterminate
        {
            get
            {
                return _StatusBarProgressBarIsIndeterminate;
            }
            set
            {
                if (_StatusBarProgressBarIsIndeterminate != value)
                {
                    _StatusBarProgressBarIsIndeterminate = value;
                    RaisePropertyChanged(nameof(StatusBarProgressBarIsIndeterminate));
                }
            }
        }
        #endregion

        public void HelpDataContext()
        {
            VerInfoNumber = "1.2.0";
            VerInfo = "MetaCom V" + VerInfoNumber;

            StatusBarProgressBarVisibility = "Collapsed";
            StatusBarProgressBarValue = 0;
            StatusBarProgressBarIsIndeterminate = false;
        }
    }
}
