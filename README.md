
# MetaCom
![Test result](https://img.shields.io/badge/Windows-passing-green)
![GitHub License](https://img.shields.io/github/license/linkmeta/MetaCom?color=blue&style=flat-square)
![Issues](https://img.shields.io/github/issues/linkmeta/MetaCom?color=blue&style=flat-square)
![release](https://img.shields.io/github/release/linkmeta/MetaCom.svg)

![logo](/MetaCom/Images/favicon.ico)

MetaCom 串口调试工具，基于WPF框架，MVVM模型开发，专注于串口常用功能，接收发送稳定性。


## 功能列表

- [x] 界面基本功能（打开、关闭、接收、发送、清空接收、清空发送和清空计数）
- [x] 支持常用波特率选择（不支持自定义波特率）
- [x] 支持流控制（握手协议、控制协议）
- [x] 支持接收与发送字节数统计
- [x] 支持自动发送，可设置发送时间间隔，默认1000ms
- [x] 支持切换为HEX发送、接收
- [x] 支持自动保存串口接收数据为文件，支持文件路径设置
- [x] 编码方式（ASCII，UTF-8，UTF-16，UTF-32）
- [x] 支持接收缓冲区与发送缓冲区设置，最大支持8M
- [x] 支持文件发送
- [x] 支持github或者gitee 问题反馈
- [ ] 在线更新
- [x] 增加常用命令功能，支持删除
- [x] 增加最近命令功能，支持添加到常用命令，删除等
- [x] 增加保存为xml配置文件

####  默认设置
* 编码方式为 UTF-8 
* 接收缓冲区大小配置为 8MB
* 发送缓冲区大小配置为 1MB
* 流控为 None（无控制流）
* 串行端口信号控制 Rts 和 Dtr 默认均未启用
<img src="https://github.com/linkmeta/MetaCom/blob/main/docs/MetaCom.png" width="700">


## 构建

- [x] VisualStudio 2022（基于 .NET WPF框架验证）

```bash
$ git clone https://github.com/linkmeta/MetaCom.git
$ cd MetaCom
```
*双击 `MetaCom.sln`

## 特别感谢

本项目参考了leven99的OSDA项目，特此感谢！

## License

软件采用 MIT License 授权（[License MIT](./LICENSE)）。

