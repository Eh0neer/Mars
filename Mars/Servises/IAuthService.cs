namespace Mars.Interfaces;

// Интерфейс для сервиса авторизации
public interface IAuthService
{
    bool AuthenticateUser(string username, string password);
    User GetUserByUsername(string username);
}