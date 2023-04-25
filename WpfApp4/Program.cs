using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //var clicker = new SimpleClicker();
            var clicker = new NiceClicker();
            var app = new Application();
            var window = new Window();
            window.Content = clicker;
            app.Run(window);
        }


        //private static Label _label;
        //private static int _count;

        //[STAThread]
        //public static void Main(string[] args)
        //{
        //    var app = new Application();
        //    var window = new Window();
        //    var button = new Button()
        //    {
        //        Content = "Trykk her!"
        //    };
        //    button.Click += ButtonClick;
        //    _label = new Label()
        //    {
        //        Content = "0"
        //    };
        //    var stackPanel = new StackPanel();
        //    stackPanel.Children.Add(button);
        //    stackPanel.Children.Add(_label);
        //    window.Content = stackPanel;

        //    app.Run(window);
        //}

        //private static void ButtonClick(object sender, RoutedEventArgs e)
        //{
        //    _count++;
        //    _label.Content = _count;
        //}
    }
}
