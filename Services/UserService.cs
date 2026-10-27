using exercise.Interfaces;

namespace exercise.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void PrintUserInfo(int userId)
    {
        var user = _userRepository.GetById(userId);
        Console.WriteLine($"[Услуга] Информация за потребител: {user.Name} с ID: {user.Id}");
    }
}