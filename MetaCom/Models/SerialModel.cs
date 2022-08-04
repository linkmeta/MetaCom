using MetaCom.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Management;
using System.Windows;
using System.Windows.Media;

namespace MetaCom.Models
{
    internal class SerialPortModel : MainWindowBase
    {
        public string[] PortItemsSource { get; set; }
        public Collection<int> BaudRateItemsSource { get; set; }
        public Collection<int> DataBitsItemsSource { get; set; }
        public Collection<StopBits> StopBitsItemsSource { get; set; }
        public Collection<Parity> ParityItemsSource { get; set; }

        #region 串口配置区 - 缓冲区
        private int _RecvBuf;
        public int RecvBufSize
        {
            get
            {
                return _RecvBuf;
            }
            set
            {
                if (_RecvBuf != value)
                {
                    _RecvBuf = value;
                    RaisePropertyChanged(nameof(RecvBufSize));
                }
            }
        }
        private bool _RecvBuf1M;
        public bool RecvBuf1M
        {
            get
            {
                return _RecvBuf1M;
            }
            set
            {
                if (_RecvBuf1M != value)
                {
                    _RecvBuf1M = value;
                    RaisePropertyChanged(nameof(RecvBuf1M));
                }
            }
        }
        private bool _RecvBuf2M;
        public bool RecvBuf2M
        {
            get
            {
                return _RecvBuf2M;
            }
            set
            {
                if (_RecvBuf2M != value)
                {
                    _RecvBuf2M = value;
                    RaisePropertyChanged(nameof(RecvBuf2M));
                }
            }
        }
        private bool _RecvBuf4M;
        public bool RecvBuf4M
        {
            get
            {
                return _RecvBuf4M;
            }
            set
            {
                if (_RecvBuf4M != value)
                {
                    _RecvBuf4M = value;
                    RaisePropertyChanged(nameof(RecvBuf4M));
                }
            }
        }
        private bool _RecvBuf8M;
        public bool RecvBuf8M
        {
            get
            {
                return _RecvBuf8M;
            }
            set
            {
                if (_RecvBuf8M != value)
                {
                    _RecvBuf8M = value;
                    RaisePropertyChanged(nameof(RecvBuf8M));
                }
            }
        }
        private int _SendBuf;
        public int SendBufSize
        {
            get
            {
                return _SendBuf;
            }
            set
            {
                if (_SendBuf != value)
                {
                    _SendBuf = value;
                    RaisePropertyChanged(nameof(SendBufSize));
                }
            }
        }
        private bool _SendBuf1M;
        public bool SendBuf1M
        {
            get
            {
                return _SendBuf1M;
            }
            set
            {
                if (_SendBuf1M != value)
                {
                    _SendBuf1M = value;
                    RaisePropertyChanged(nameof(SendBuf1M));
                }
            }
        }
        private bool _SendBuf4M;
        public bool SendBuf4M
        {
            get
            {
                return _SendBuf4M;
            }
            set
            {
                if (_SendBuf4M != value)
                {
                    _SendBuf4M = value;
                    RaisePropertyChanged(nameof(SendBuf4M));
                }
            }
        }
        #endregion

        #region 串口配置区 - 串口属性
        private string _Port;
        public string Port
        {
            get
            {
                return _Port;
            }
            set
            {
                if (_Port != value)
                {
                    _Port = value;
                    RaisePropertyChanged(nameof(Port));
                }
            }
        }

        private int _BaudRate;
        public int BaudRate
        {
            get
            {
                return _BaudRate;
            }
            set
            {
                if (_BaudRate != value)
                {
                    _BaudRate = value;
                    RaisePropertyChanged(nameof(BaudRate));
                }
            }
        }

        private int _DataBits;
        public int DataBits
        {
            get
            {
                return _DataBits;
            }
            set
            {
                if (_DataBits != value)
                {
                    _DataBits = value;
                    RaisePropertyChanged(nameof(DataBits));
                }
            }
        }

        private StopBits _StopBits;
        public StopBits StopBits
        {
            get
            {
                return _StopBits;
            }
            set
            {
                if (_StopBits != value)
                {
                    _StopBits = value;
                    RaisePropertyChanged(nameof(StopBits));
                }
            }
        }

        private Parity _Parity;
        public Parity Parity
        {
            get
            {
                return _Parity;
            }
            set
            {
                if (_Parity != value)
                {
                    _Parity = value;
                    RaisePropertyChanged(nameof(Parity));
                }
            }
        }
        #endregion

        #region 串口配置区 - 打开/关闭
        private Brush _Brush;
        public Brush Brush
        {
            get
            {
                return _Brush;
            }
            set
            {
                if (_Brush != value)
                {
                    _Brush = value;
                    RaisePropertyChanged(nameof(Brush));
                }
            }
        }

        private string _OpenClose;
        public string OpenClose
        {
            get
            {
                return _OpenClose;
            }
            set
            {
                if (_OpenClose != value)
                {
                    _OpenClose = value;
                    RaisePropertyChanged(nameof(OpenClose));
                }
            }
        }
        #endregion

        #region 串口属性控件 - 启用/不启用
        private bool _PortEnable;
        public bool PortEnable
        {
            get
            {
                return _PortEnable;
            }
            set
            {
                if (_PortEnable != value)
                {
                    _PortEnable = value;
                    RaisePropertyChanged(nameof(PortEnable));
                }
            }
        }

        private bool _BaudRateEnable;
        public bool BaudRateEnable
        {
            get
            {
                return _BaudRateEnable;
            }
            set
            {
                if (_BaudRateEnable != value)
                {
                    _BaudRateEnable = value;
                    RaisePropertyChanged(nameof(BaudRateEnable));
                }
            }
        }

        private bool _DataBitsEnable;
        public bool DataBitsEnable
        {
            get
            {
                return _DataBitsEnable;
            }
            set
            {
                if (_DataBitsEnable != value)
                {
                    _DataBitsEnable = value;
                    RaisePropertyChanged(nameof(DataBitsEnable));
                }
            }
        }

        private bool _StopBitsEnable;
        public bool StopBitsEnable
        {
            get
            {
                return _StopBitsEnable;
            }
            set
            {
                if (_StopBitsEnable != value)
                {
                    _StopBitsEnable = value;
                    RaisePropertyChanged(nameof(StopBitsEnable));
                }
            }
        }

        private bool _ParityEnable;
        public bool ParityEnable
        {
            get
            {
                return _ParityEnable;
            }
            set
            {
                if (_ParityEnable != value)
                {
                    _ParityEnable = value;
                    RaisePropertyChanged(nameof(ParityEnable));
                }
            }
        }
        #endregion

        #region 菜单栏 - 选项 - 字节编码
        private bool _ASCIIEnable;
        public bool ASCIIEnable
        {
            get
            {
                return _ASCIIEnable;
            }
            set
            {
                if (_ASCIIEnable != value)
                {
                    _ASCIIEnable = value;
                    RaisePropertyChanged(nameof(ASCIIEnable));
                }
            }
        }

        private bool _UTF8Enable;
        public bool UTF8Enable
        {
            get
            {
                return _UTF8Enable;
            }
            set
            {
                if (_UTF8Enable != value)
                {
                    _UTF8Enable = value;
                    RaisePropertyChanged(nameof(UTF8Enable));
                }
            }
        }

        private bool _UTF16Enable;
        public bool UTF16Enable
        {
            get
            {
                return _UTF16Enable;
            }
            set
            {
                if (_UTF16Enable != value)
                {
                    _UTF16Enable = value;
                    RaisePropertyChanged(nameof(UTF16Enable));
                }
            }
        }

        private bool _UTF32Enable;
        public bool UTF32Enable
        {
            get
            {
                return _UTF32Enable;
            }
            set
            {
                if (_UTF32Enable != value)
                {
                    _UTF32Enable = value;
                    RaisePropertyChanged(nameof(UTF32Enable));
                }
            }
        }
        #endregion

        #region 菜单栏 - 选项 - DTR/RTS
        private bool _DtrEnable;
        public bool DtrEnable
        {
            get
            {
                return _DtrEnable;
            }
            set
            {
                if (_DtrEnable != value)
                {
                    _DtrEnable = value;
                    RaisePropertyChanged(nameof(DtrEnable));
                }
            }
        }

        private bool _RtsEnable;
        public bool RtsEnable
        {
            get
            {
                return _RtsEnable;
            }
            set
            {
                if (_RtsEnable != value)
                {
                    _RtsEnable = value;
                    RaisePropertyChanged(nameof(RtsEnable));
                }
            }
        }
        #endregion

        #region 菜单栏 - 选项 - 流控制
        private bool _NoneEnable;
        public bool NoneEnable
        {
            get
            {
                return _NoneEnable;
            }
            set
            {
                if (_NoneEnable != value)
                {
                    _NoneEnable = value;
                    RaisePropertyChanged(nameof(NoneEnable));
                }
            }
        }

        private bool _RequestToSendEnable;
        public bool RequestToSendEnable
        {
            get
            {
                return _RequestToSendEnable;
            }
            set
            {
                if (_RequestToSendEnable != value)
                {
                    _RequestToSendEnable = value;
                    RaisePropertyChanged(nameof(RequestToSendEnable));
                }
            }
        }

        private bool _XOnXOffEnable;
        public bool XOnXOffEnable
        {
            get
            {
                return _XOnXOffEnable;
            }
            set
            {
                if (_XOnXOffEnable != value)
                {
                    _XOnXOffEnable = value;
                    RaisePropertyChanged(nameof(XOnXOffEnable));
                }
            }
        }

        private bool _RequestToSendXOnXOffEnable;
        public bool RequestToSendXOnXOffEnable
        {
            get
            {
                return _RequestToSendXOnXOffEnable;
            }
            set
            {
                if (_RequestToSendXOnXOffEnable != value)
                {
                    _RequestToSendXOnXOffEnable = value;
                    RaisePropertyChanged(nameof(RequestToSendXOnXOffEnable));
                }
            }
        }
        #endregion

        #region 信号状态区 - 信号指示灯
        private Brush _DcdBrush;
        public Brush DcdBrush
        {
            get
            {
                return _DcdBrush;
            }
            set
            {
                if (_DcdBrush != value)
                {
                    _DcdBrush = value;
                    RaisePropertyChanged(nameof(DcdBrush));
                }
            }
        }

        private Brush _CtsBrush;
        public Brush CtsBrush
        {
            get
            {
                return _CtsBrush;
            }
            set
            {
                if (_CtsBrush != value)
                {
                    _CtsBrush = value;
                    RaisePropertyChanged(nameof(CtsBrush));
                }
            }
        }

        private Brush _DsrBrush;
        public Brush DsrBrush
        {
            get
            {
                return _DsrBrush;
            }
            set
            {
                if (_DsrBrush != value)
                {
                    _DsrBrush = value;
                    RaisePropertyChanged(nameof(DsrBrush));
                }
            }
        }
        #endregion

        public string GetPortInformation( String PortName )
        {
            ManagementClass processClass = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection Ports = processClass.GetInstances();
            foreach (ManagementObject property in Ports)
            {
                var name = property.GetPropertyValue("Name");
                if (name != null && name.ToString().Contains(PortName))
                {
                   // var portInfo = new SerialPortInfo(property);
                    Console.WriteLine("Port Name:    " + name);
                    Console.WriteLine("Port description:    " + property.GetPropertyValue("Description"));
                    return property.GetPropertyValue("Description").ToString();
                    //Thats all information i got from port.
                    //Do whatever you want with this information
                }
            }
            return string.Empty;
        }

        public void SerialPortDataContext()
        {
            PortItemsSource = SerialPort.GetPortNames();
            int i = 0;
            foreach (var port in PortItemsSource)
            {
                String PortDesc = GetPortInformation(port.ToString());
                PortItemsSource[i] = PortItemsSource[i] + " " + PortDesc;
                i++;
            }
            
            BaudRateItemsSource = new Collection<int>
            {
                1200, 2400, 4800, 7200, 9600, 14400, 19200, 28800, 38400, 57600, 115200, 128000, 153600, 230400, 256000
            };
            DataBitsItemsSource = new Collection<int>
            {
                5, 6, 7, 8
            };
            StopBitsItemsSource = new Collection<StopBits>
            {
                StopBits.One, StopBits.Two, StopBits.OnePointFive
            };
            ParityItemsSource = new Collection<Parity>
            {
                Parity.None, Parity.Odd, Parity.Even, Parity.Mark, Parity.Space
            };

            //RecvBufSize = 2;
            Port = string.Format(CultureInfos, "COM1 通信端口");
            BaudRate = 115200;
            DataBits = 8;
            StopBits = StopBits.One;
            Parity = Parity.None;

            Brush = Brushes.DarkBlue;
            OpenClose = string.Format(CultureInfos, "打开串口");

            /* 串口属性控件 */
            PortEnable = true;
            BaudRateEnable = true;
            DataBitsEnable = true;
            StopBitsEnable = true;
            ParityEnable = true;

            /* 字节编码 */
            ASCIIEnable = false;
            UTF8Enable = true;
            UTF16Enable = false;
            UTF32Enable = false;

            /* 缓冲区设置*/
            RecvBuf1M = false;
            RecvBuf2M = false;
            RecvBuf4M = false;
            RecvBuf8M = true;
            SendBuf1M = true;
            SendBuf4M = false;

            DtrEnable = false;
            RtsEnable = false;

            /* 流控制 */
            NoneEnable = true;
            RequestToSendEnable = false;
            XOnXOffEnable = false;
            RequestToSendXOnXOffEnable = false;

            /* 信号状态 */
            DcdBrush = Brushes.Black;
            CtsBrush = Brushes.Black;
            DsrBrush = Brushes.Black;
        }
    }
}
