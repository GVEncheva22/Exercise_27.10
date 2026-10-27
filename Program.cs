using exercise.Common;
using exercise.Interfaces;
using exercise.Repositories;
using exercise.Services;

Console.WriteLine($"--- Стартиране на {AppConstants.AppName} v{AppConstants.Version} ---");
IUserRepository userRepository = new UserRepository();
IUserService userService = new UserService(userRepository);
userService.PrintUserInfo(1);