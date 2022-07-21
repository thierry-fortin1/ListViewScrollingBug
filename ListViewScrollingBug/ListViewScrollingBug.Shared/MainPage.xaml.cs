using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Uno.Extensions.Reactive;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListViewScrollingBug
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = this;
        }
        public List<Item> Items { get; } = new List<Item>()
        {
            new Item("msg1"),
            new Item("msg2"),
            new Item("msg3"),
            new Item("msg4"),
            new Item("msg5"),
            new Item("msg10"),
            new Item("msg2"),
            new Item("msg3"),
            new Item("msg4"),
            new Item("msg5"),
            new Item("msg100"),
            new Item("msg2"),
            new Item("msg3"),
            new Item("msg4"),
            new Item("msg5"),
            new Item("msg1000"),
            new Item("msg2"),
            new Item("msg3"),
            new Item("msg4"),
            new Item("msg5"),
            new Item("msg10000"),
            new Item("msg2"),
            new Item("msg3"),
            new Item("msg4"),
            new Item("msg5"),
        };
    }
}
