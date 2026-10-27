using exercise.Interfaces;
using exercise.Models;

namespace exercise.Repositories;

public class UserRepository : IUserRepository
{
    public User GetById(int id)
    {
        return new User { Id = id, Name = "Габриела" };
    }
}