using FileSocketClientDemo.Views;

namespace FileSocketClientDemo
{
    public static class Log
    {
        public static void Show(string mes)
        {
            MainWindow.Window.Dispatcher.Invoke(() =>
            {
                MessageWindow messageWindow = new MessageWindow(mes);
                messageWindow.Owner = MainWindow.Window;
                messageWindow.Show();
            });
        }
    }
}