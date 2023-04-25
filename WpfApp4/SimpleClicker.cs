using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp4
{
    internal class SimpleClicker
    {
        private Label _label;
        private int _count;
        public StackPanel Panel { get; }

        public SimpleClicker()
        {
            var button = new Button()
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label()
            {
                Content = "0"
            };
            Panel = new StackPanel();
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
