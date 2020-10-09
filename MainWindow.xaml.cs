using System;
using System.Windows;
using System.Windows.Input;

namespace Gumming_XOR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Cryptography crypt = new Cryptography();
        Exception ex = new Exception();

        private void MsgBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            MsgBox.Text = null;
            MsgBox.Opacity = 1;
        }

        private void KeyBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            KeyBox.Text = null;
            KeyBox.Opacity = 1;
        }

        private void ExecButt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(KeyBox.Text, out int Key);

                ResultMsgBox.Text = crypt.Encode(MsgBox.Text, Key);
                ResultMsgBox.IsEnabled = true;
                ResultMsgBox.Opacity = 1;
            }
            catch
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
