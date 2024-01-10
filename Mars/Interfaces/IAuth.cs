namespace Mars.Interfaces;

// Интерфейс для сервиса авторизации
public interface IAuth
{
    bool AuthenticateUser(string username, string password);
    User GetUserByUsername(string username);
}