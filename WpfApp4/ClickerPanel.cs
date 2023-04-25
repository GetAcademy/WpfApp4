using System.Windows.Controls;
using System.Windows;

namespace WpfApp4
{
    internal class ClickerPanel : StackPanel
    {
        private Label _label;
        private int _count;

        public ClickerPanel()
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
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
