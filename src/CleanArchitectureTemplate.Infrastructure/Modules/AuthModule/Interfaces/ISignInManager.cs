using System;
using CleanArchitectureTemplate.Domain.Modules.AuthModule;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitectureTemplate.Infrastructure.Modules.AuthModule.Interfaces;

public interface ISignInManager
{
    public Task<SignInResult> CheckPasswordAsync(User user, string password, bool lockoutOnFailure);
}
