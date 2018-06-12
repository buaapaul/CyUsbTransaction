using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CyUsbTransaction
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            byte[] src = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            byte[] dst = new byte[100];
            Buffer.BlockCopy(dst, 0, src, 0, 20);
        }
    }
}
