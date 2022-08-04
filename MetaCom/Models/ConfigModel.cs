using MetaCom.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MetaCom.Models
{
    [XmlRoot(ElementName = "Config")]
    public class ConfigModel : MainWindowBase
    {
        private string _port;
        [XmlAttribute(AttributeName = "port", Namespace = "")]
        public string Port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
                RaisePropertyChanged(nameof(Port));
            }
        }


        [XmlRoot(ElementName = "commoncmd")]
        public class CommonCmd : MainWindowBase
        {
            private string _item;
            [XmlElement(ElementName = "item", Namespace = "")]
            public string Item
            {
                get
                {
                    return _item;
                }
                set
                {
                    _item = value;
                    RaisePropertyChanged(nameof(Item));
                }
            }
        }
        private ObservableCollection<CommonCmd> _commoncmds;
        [XmlElement(ElementName = "commoncmds", Namespace = "")]
        public ObservableCollection<CommonCmd> CommonCmds
        {
            get
            {
                return _commoncmds;
            }
            set
            {
                _commoncmds = value;
                RaisePropertyChanged(nameof(CommonCmds));
            }
        }
        [XmlRoot(ElementName = "rescentcmd")]
        public class RescentCmd : MainWindowBase
        {
            private string _item;
            [XmlElement(ElementName = "item", Namespace = "")]
            public string Item
            {
                get
                {
                    return _item;
                }
                set
                {
                    _item = value;
                    RaisePropertyChanged(nameof(Item));
                }
            }

        }
        private ObservableCollection<RescentCmd> _rescentcmds;
        [XmlElement(ElementName = "rescentcmds", Namespace = "")]
        public ObservableCollection<RescentCmd> RescentCmds
        {
            get
            {
                return _rescentcmds;
            }
            set
            {
                _rescentcmds = value;
                //NotifyPropertyChange("RescentCmds");
                RaisePropertyChanged(nameof(RescentCmds));
            }
        }

    }
}
