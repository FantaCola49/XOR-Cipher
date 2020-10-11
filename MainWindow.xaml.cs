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
            if(MsgBox.Opacity != 1)
            {
                MsgBox.Text = null;
                MsgBox.Opacity = 1;
            }
        }
        private void ExecButt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long.TryParse(KeyBox.Text, out long Key);

                ResultMsgBox.Text = crypt.Encode(MsgBox.Text, Key);
                ResultMsgBox.IsEnabled = true;
                ResultMsgBox.Opacity = 1;
            }
            catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KeyGen_Click(object sender, RoutedEventArgs e)
        {
            KeyBox.Text = crypt.getRandom().ToString();
        }
    }
}
