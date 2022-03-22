﻿using MetaCom.Interfaces;
using MetaCom.ViewModels;

namespace MetaCom.Models
{
    internal class RecvModel : MainWindowBase
    {
        #region 接收区 - Header
        /// <summary>
        /// 接收区Header中的接收计数
        /// </summary>
        private int _RecvDataCount;
        public int RecvDataCount
        {
            get
            {
                return _RecvDataCount;
            }
            set
            {
                if (_RecvDataCount != value)
                {
                    _RecvDataCount = value;
                    RaisePropertyChanged(nameof(RecvDataCount));
                }
            }
        }

        /// <summary>
        /// 接收区Header中的 [保存中/已停止] 字符串
        /// </summary>
        private string _RecvAutoSave;
        public string RecvAutoSave
        {
            get
            {
                return _RecvAutoSave;
            }
            set
            {
                if (_RecvAutoSave != value)
                {
                    _RecvAutoSave = value;
                    RaisePropertyChanged(nameof(RecvAutoSave));
                }
            }
        }

        /// <summary>
        /// 接收区Header中的 [允许/暂停] 字符串
        /// </summary>
        private string _RecvEnable;
        public string RecvEnable
        {
            get
            {
                return _RecvEnable;
            }
            set
            {
                if (_RecvEnable != value)
                {
                    _RecvEnable = value;
                    RaisePropertyChanged(nameof(RecvEnable));
                }
            }
        }
        #endregion

        /// <summary>
        /// 接收区 - 允许/暂停 接收数据
        /// </summary>
        private bool _EnableRecv;
        public bool EnableRecv
        {
            get
            {
                return _EnableRecv;
            }
            set
            {
                if (_EnableRecv != value)
                {
                    _EnableRecv = value;
                    RaisePropertyChanged(nameof(EnableRecv));
                }
            }
        }

        private TextBoxAppend _RecvData;
        public TextBoxAppend RecvData
        {
            get
            {
                return _RecvData;
            }
            set
            {
                if (_RecvData != value)
                {
                    _RecvData = value;
                    RaisePropertyChanged(nameof(RecvData));
                }
            }
        }

        /// <summary>
        /// 辅助区 - 十六进制接收
        /// </summary>
        private bool _HexRecv;
        public bool HexRecv
        {
            get
            {
                return _HexRecv;
            }
            set
            {
                if (_HexRecv != value)
                {
                    _HexRecv = value;
                    RaisePropertyChanged(nameof(HexRecv));
                }
            }
        }

        public void RecvDataContext()
        {
            RecvData = new IClassTextBoxAppend();

            RecvDataCount = 0;
            RecvAutoSave = string.Format(CultureInfos, "已停止");
            RecvEnable = string.Format(CultureInfos, "允许");

            EnableRecv = true;
            HexRecv = false;
        }
    }
}
