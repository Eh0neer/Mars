using System.Collections.Generic;

namespace Mars.Interfaces;

// Интерфейс для сервиса управления пользователями
public interface IUserManagementService
{
    List<User> ViewAllUsers();
    User GetUserById(int userId);
    void UpdateUser(User updatedUser);
}