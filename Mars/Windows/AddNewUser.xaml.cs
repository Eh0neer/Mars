using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Mars.Windows;

public partial class AddNewUser : Window
{
    private ObservableCollection<User> users;
    private ObservableCollection<Usertype> usertypes;
    private MarsDbContext _dbContext;
    public AddNewUser()
    {
        InitializeComponent();
        _dbContext = new MarsDbContext();
        users = new ObservableCollection<User>(_dbContext.Users.ToList());

        // Загрузка данных о типах пользователей
        usertypes = new ObservableCollection<Usertype>(_dbContext.Usertypes.ToList());

        cmbUserType.ItemsSource = usertypes;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            // Создание нового пользователя из введенных данных
            var newUser = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Fullname = txtFullname.Text,
                Usertype = cmbUserType.SelectedItem as Usertype,
                Status = "Активен"
            };

            // Добавление нового пользователя в DbSet и сохранение изменений
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            // Обновление данных в DataGrid
            users.Clear();
            _dbContext.Users.ToList().ForEach(users.Add);

            MessageBox.Show("Новый пользователь успешно добавлен.");

            // Очистка полей ввода после добавления
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}");
        }
    }

    private void ClearInputFields()
    {
        // Очистка полей ввода
        txtUsername.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtFullname.Text = string.Empty;
        cmbUserType.SelectedIndex = -1;
    }
    
}