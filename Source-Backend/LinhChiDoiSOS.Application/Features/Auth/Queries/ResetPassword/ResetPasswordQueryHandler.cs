using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Auth.Queries.ResetPassword;
using LinhChiDoiSOS.Domain.IdentityModels;
using MailKit.Security;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MimeKit.Text;
using MimeKit;
using System.Text;
using System.Net.Mail;
using System.Net;

public class ResetPasswordQueryHandler : IRequestHandler<ResetPasswordQuery, string>
{

    private readonly UserManager<ApplicationUser> _userManager;
    public ResetPasswordQueryHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<string> Handle(ResetPasswordQuery request, CancellationToken cancellationToken)
    {
        try {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new NotFoundException(nameof(ApplicationUser), request.Email);

            var newPassword = GenerateRandomPassword();

            var resetPasswordResult = await _userManager.ResetPasswordAsync(user, await _userManager.GeneratePasswordResetTokenAsync(user), newPassword);
            if (!resetPasswordResult.Succeeded)
            {
                throw new BadRequestException("Password reset failed.");
            }

            // await SendEmailAsync(user.Email, "Reset password", $"Your new password is: {newPassword}");
            await SendEmailAsync(user.Email, "Change your password", newPassword);

            return "Password reset successful. Please check your email for the new password.";
        }
        catch (Exception ex) { throw new BadRequestException($"Error at ResetPasswordQueryHandler : {ex}"); }
    }

    private string GenerateRandomPassword()
    {
        try {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string specialChars = "!@#$%^&*";
            var random = new Random();
            var password = new StringBuilder();


            for (int i = 0; i < 10; i++) {
                password.Append(validChars[random.Next(validChars.Length)]);
            }


            password.Append(specialChars[random.Next(specialChars.Length)]);


            for (int i = password.Length - 1; i > 0; i--) {
                int j = random.Next(i + 1);
                char temp = password[i];
                password[i] = password[j];
                password[j] = temp;
            }

            return password.ToString();
        }
        catch (Exception ex) { throw new BadRequestException($"Error at GenerateRandomPassword: {ex}"); }
    }

    private async Task SendEmailAsync(string email, string subject, string body)
    {
        try {
            var body1 = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Password Reset Notification</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f0f0f0; 
        }
        .container {
            max-width: 600px;
            margin: 40px auto;
            background-color: #fff;
            padding: 40px;
            text-align: center;
            border: 1px solid #ddd;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1); 
        }
        h1 {
            color: #28a745; /* Success Green */
        }
        .new-password {
            font-size: 20px;
            font-weight: bold;
            margin: 20px 0;
            word-break: break-all; /* Allows new password to break lines */
        }
        .action-link {
            background-color: #007bff; /* Default Bootstrap blue */
            color: white;
            padding: 10px 20px;
            text-decoration: none;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Password Reset Notification</h1>
        <p>A password reset has been requested for an account on your system. Here's the new temporary password:</p>
        <div class=""new-password"">
            [NewPassword] 
        </div>
        <p>
            Please advise the user to log in and change this password immediately.
        </p>
        <a href=""https://yourwebsite.com/change-password"" class=""action-link"">Change Password</a>
    </div>
</body>
</html>";
            body1 = body1.Replace("[NewPassword]", body);
            var message = new MailMessage();
            message.From = new MailAddress("no-reply@gmail.com");
            message.To.Add(new MailAddress(email));
            message.Subject = subject;

            message.Body = body1;
            message.IsBodyHtml = true;
            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("khancapsos.webapp@gmail.com", "fruehxrmqgywhxnv"),
                EnableSsl = true
            };
            await smtp.SendMailAsync(message);
        }
        catch (Exception ex) { throw new BadRequestException($"Error at SendEmailAsync: {ex}"); }
    }
}


