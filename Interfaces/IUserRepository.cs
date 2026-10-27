using exercise.Models;

namespace exercise.Interfaces;

public interface IUserRepository
{
    User GetById(int id);
}