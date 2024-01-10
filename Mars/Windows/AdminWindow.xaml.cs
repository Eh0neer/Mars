using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using Mars.Windows;

namespace Mars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AdminWindow
    {
        private MarsDbContext _dbContext;
        private ObservableCollection<User> _users;

        public AdminWindow()
        {
            InitializeComponent();
            
            _dbContext = new MarsDbContext();
            _users = new ObservableCollection<User>(_dbContext.Users.ToList());
            EmployeesGrid.ItemsSource = _users;
            
        }

        private void ShowEmployees(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowOrders(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowShifts(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowReports(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowMenu(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteEmployee(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = EmployeesGrid.SelectedItems.Cast<User>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {usersForRemoving.Count()} элементов?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    foreach (var user in usersForRemoving)
                    {
                        _users.Remove(user);
                        _dbContext.Users.Remove(user);
                    }
            
                    _dbContext.SaveChanges();
            
                    MessageBox.Show("Пользователь успешно удален.");
                }
                catch (Exception ex)
                {
                    LogError(ex.Message);
                    MessageBox.Show($"Ошибка при удалении пользователя. Подробности см. в консоли вывода.");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
        }
        
        static void LogError(string errorMessage)
        {
            string logFilePath = "error.log";

            // Используем StreamWriter для записи в файл
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - Error: {errorMessage}");
                // Вы также можете записывать другие данные, например, стек вызовов
                // writer.WriteLine($"{DateTime.Now} - Stack Trace: {ex.StackTrace}");
            }

            Console.WriteLine($"Ошибка записана в файл: {logFilePath}");
        }

        private void CreateEmployee(object sender, RoutedEventArgs e)
        {
            new AddNewUser().Show();
        }

        private void RefreshList(object sender, RoutedEventArgs e)
        {
            try
            {
                // Обновление данных в базе данных
                _dbContext.SaveChanges();

                // Обновление данных в DataGrid
                _users.Clear();
                _dbContext.Users.ToList().ForEach(_users.Add);

                MessageBox.Show("Данные успешно обновлены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            new AuthWindow().Show();
            this.Close();
        }
    }
}
