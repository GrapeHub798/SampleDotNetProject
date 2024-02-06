
using DotNetSample.Domain.Entities;

namespace DotNetSample.Domain.Interfaces;
public interface IUserService 
{
    Task<User> Login(string emailAddress, string password);
}