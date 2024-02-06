using DotNetSample.Domain.Entities;
using DotNetSample.Domain.Interfaces;
using DotNetSample.Infrastructure.Data;

namespace DotNetSample.Infrastructure.Services;

public class UserService(AppDbContext context): IUserService {

    public async Task<User> Login(string emailAddress, string password){
        var foundUser =  await context.Users.FindAsync(emailAddress);
        return foundUser ?? new User() ;
    }
} 