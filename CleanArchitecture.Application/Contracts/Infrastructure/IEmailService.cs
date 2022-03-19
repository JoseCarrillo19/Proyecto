using CleanArchitecture.Application.Models;

namespace CleanArchitecture.Application.Features
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
