using System.ComponentModel;
using System.Windows;

namespace Mars.Windows;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void LoginButtonClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }


    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        LoginPlaceholder.Visibility = Visibility.Collapsed;
    }

    private void TextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            LoginPlaceholder.Visibility = Visibility.Visible;
        }
    }

    private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
    {
        PasswordPlaceholder.Visibility = Visibility.Collapsed;
    }

    private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPassword.Password))
        {
            PasswordPlaceholder.Visibility = Visibility.Visible;
        }
    }

}