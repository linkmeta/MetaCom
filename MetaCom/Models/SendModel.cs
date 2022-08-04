using MetaCom.ViewModels;

namespace MetaCom.Models
{
    internal class SendModel : MainWindowBase
    {
        /// <summary>
        /// 发送区Header中的发送计数
        /// </summary>
        private int _SendDataCount;
        public int SendDataCount
        {
            get
            {
                return _SendDataCount;
            }
            set
            {
                if (_SendDataCount != value)
                {
                    _SendDataCount = value;
                    RaisePropertyChanged(nameof(SendDataCount));
                }
            }
        }

        private string _SendData;
        public string SendData
        {
            get
            {
                return _SendData;
            }
            set
            {
                if (_SendData != value)
                {
                    _SendData = value;
                    RaisePropertyChanged(nameof(SendData));
                }
            }
        }

        /// <summary>
        /// 辅助区 - 自送发送的时间间隔
        /// </summary>
        private string _AutoSendNum;
        public string AutoSendNum
        {
            get
            {
                return _AutoSendNum;
            }
            set
            {
                if (_AutoSendNum != value)
                {
                    _AutoSendNum = value;
                    RaisePropertyChanged(nameof(AutoSendNum));
                }
            }
        }

        #region 菜单栏 - 选项 - 发送换行
        private bool _NonesEnable;
        public bool NonesEnable
        {
            get
            {
                return _NonesEnable;
            }
            set
            {
                if (_NonesEnable != value)
                {
                    _NonesEnable = value;
                    RaisePropertyChanged(nameof(NonesEnable));
                }
            }
        }

        private bool _CrEnable;
        public bool CrEnable
        {
            get
            {
                return _CrEnable;
            }
            set
            {
                if (_CrEnable != value)
                {
                    _CrEnable = value;
                    RaisePropertyChanged(nameof(CrEnable));
                }
            }
        }

        private bool _LfEnable;
        public bool LfEnable
        {
            get
            {
                return _LfEnable;
            }
            set
            {
                if (_LfEnable != value)
                {
                    _LfEnable = value;
                    RaisePropertyChanged(nameof(LfEnable));
                }
            }
        }

        private bool _CrLfEnable;
        public bool CrLfEnable
        {
            get
            {
                return _CrLfEnable;
            }
            set
            {
                if (_CrLfEnable != value)
                {
                    _CrLfEnable = value;
                    RaisePropertyChanged(nameof(CrLfEnable));
                }
            }
        }
        #endregion
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
        public void SendDataContext()
        {
            SendData = string.Empty;
            SendDataCount = 0;

            AutoSendNum = "1000";

            NonesEnable = false;
            CrEnable = false;
            LfEnable = false;
            CrLfEnable = true;

            StatusBarProgressBarVisibility = "Collapsed";
            StatusBarProgressBarValue = 0;
            StatusBarProgressBarIsIndeterminate = false;
        }
    }
}
