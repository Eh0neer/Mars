using System.ComponentModel;
using System.Linq;
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
        var currentUser = AppData._DbContext.Users.FirstOrDefault(u => 
            u.Username == txtUsername.Text && 
            u.Password == txtPassword.Password);
        
        if (currentUser != null)
        {
            // Пользователь найден
            if (currentUser.Usertypeid.HasValue)
            {
                // Проверка типа пользователя (здесь 1 - это тип администратора, 2 Waiter, 3 cook
                if (currentUser.Usertypeid == 1)
                {
                    // Пользователь - администратор
                    new AdminWindow().Show();
                    this.Close();
                }
                else if (currentUser.Usertypeid == 2)
                {
                    // Пользователь - Waiter
                    new WaiterWindow().Show();
                    this.Close();
                }
                else
                {
                    // User - Cook
                    new CookWindow().Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error your UserType is not found!", "Error");
            }
        }
        else
        {
            MessageBox.Show("Incorrect login or password", "Authorization error ");
        }
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