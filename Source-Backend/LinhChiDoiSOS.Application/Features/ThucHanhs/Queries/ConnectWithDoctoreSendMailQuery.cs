using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Payments.PaymentWithSendMail;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LinhChiDoiSOS.Application.Features.ThucHanhs.Queries
{
    public class ConnectWithDoctoreSendMailQuery : IRequest<string>
    {
        public string Email { get; set; }
    }

    public class ConnectWithDoctoreSendMailQueryHandler : IRequestHandler<ConnectWithDoctoreSendMailQuery, string>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ILinhChiDoiSOSDbContext _dbContext;

        public ConnectWithDoctoreSendMailQueryHandler(UserManager<ApplicationUser> userManager, ILinhChiDoiSOSDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<string> Handle(ConnectWithDoctoreSendMailQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(request.Email);
                if (user == null)
                    throw new NotFoundException(nameof(ApplicationUser), request.Email);


                //  await SendEmailAsync(user.Email, "PaymentSuccessfully", $"Please wait for me a minute");
                var bodyOfUser = @"
                                    <!DOCTYPE html>
                                    <html lang=""en"">
                                    <head>
                                        <meta charset=""UTF-8"">
                                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                        <title>Premium Application Payment Confirmation</title>
                                        <style>
                                            body { 
                                                font-family: 'Segoe UI', Tahoma, Arial, sans-serif; 
                                                margin: 0; 
                                                padding: 0; 
                                                background-color: #f0f0f0;
                                            }
                                            .container { 
                                                max-width: 600px; 
                                                margin: 40px auto; 
                                                border: 1px solid #ddd; 
                                                padding: 40px; 
                                                background-color: #fff;
                                                text-align: center;
                                                box-shadow: 0 2px 5px rgba(0,0,0,0.1); 
                                            }
                                            h1 { 
                                                color: #28a745; /* Success Green */
                                                margin-bottom: 20px;
                                            }
                                            .message { 
                                                font-size: 18px;
                                                line-height: 1.5;
                                            }
                                            .note { 
                                                color: #555; 
                                                margin-top: 20px;
                                            }
                                            /* Optional Animation */
                                            h1 {
                                                animation: fadeIn 1s ease-in;
                                            }
                                            @keyframes fadeIn {
                                                from { opacity: 0; }
                                                to { opacity: 1; }
                                            }
                                        </style>
                                    </head>
                                    <body>
                                        <div class=""container"">
                                            <h1>Thank You for Register With Doctor!</h1>
                                            <div class=""message"">
                                                Dear [Customer Name], <br><br>
                                                Thank you for connecting with expert Le Trung Nghia.  <br><br>
                                                Please keep in touch closely to be connected with the doctor for support on skills.
                                            </div>
                                            <div class=""note"">
                                                If you have any questions, feel free to contact us. 
                                            </div>
                                            <br>
                                            Sincerely,<br>
                                            Lính Chì Đội SOS 
                                        </div>
                                    </body>
                                    </html>";
                bodyOfUser = bodyOfUser.Replace("[Customer Name]", user.Fullname);
                await SendEmailAsync(request.Email, "Kết nối với Chuyên Gia", bodyOfUser);
                var bodyOfAdmin = @"<!DOCTYPE html>
                                    <html lang=""en"">
                                    <head>
                                        <meta charset=""UTF-8"">
                                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                        <title>New Premium Registration</title>
                                        <style>
                                            /* CSS Styles (Place this inside the <style> tag) */
                                            body { 
                                                font-family: Arial, Helvetica, sans-serif; 
                                                margin: 0; 
                                                padding: 0; 
                                                background-color: #f8f8f8;
                                            }
                                            .container { 
                                                max-width: 600px; 
                                                margin: 40px auto; 
                                                padding: 30px; 
                                                background-color: #fff;
                                                text-align: center;
                                                border: 1px solid #ddd;
                                                box-shadow: 0 2px 5px rgba(0,0,0,0.1); 
                                            }
                                            h1 { 
                                                color: #3498db; /* Informational Blue */
                                                font-weight: bold;
                                            }
                                            .message { 
                                                font-size: 16px;
                                                line-height: 1.5;
                                                margin-bottom: 20px;
                                            }
                                            .action-required {
                                                color: #dc3545; /* Attention Red */
                                                font-weight: bold;
                                            }
                                            .details-table {
                                                width: 100%;
                                                margin-top: 20px;
                                                border-collapse: collapse;
                                            }
                                            .details-table th, .details-table td {
                                                padding: 12px; /* More spacing */
                                            }
                                            .details-table tr:nth-child(even) {
                                                background-color: #f9f9f9; /* Alternating row color */
                                            }
                                            .container {
                                                border-top: 1px solid #ddd; /* Separator above action line */
                                            }
                                            .activate-button { /* Optional - if you add a button */
                                                background-color: #3498db; 
                                                color: white;
                                                padding:  10px 20px;
                                                border: none;
                                                border-radius: 5px;
                                                text-decoration: none;
                                                display: block;
                                                margin: 20px auto; 
                                            } 
                                        </style>
                                    </head>
                                    <body>
                                        <div class=""container"">
                                            <h1>Kết nối với chuyên gia</h1>
                                            <div class=""message"">
                                                The user <span class=""action-required"">abc</span> Bác sĩ Lê Trung Nghĩa. 
                                            </div>
                                            <table class=""details-table"">
                                                <tr>
                                                    <th>Email:</th>
                                                    <td>[emailOfUser]</td> 
                                                </tr>
                                                <tr>
                                                    <th>Registration Date:</th>
                                                    <td>[DayRegis]</td> 
                                                </tr>
                                            </table>
                                            <div>
                                                Please check the notifications and register this user for a schedule to connect with the expert.
                                            </div>
                                        </div>
                                    </body>
                                    </html>";
                bodyOfAdmin = bodyOfAdmin.Replace("[emailOfUser]", user.Email);
                bodyOfAdmin = bodyOfAdmin.Replace("[DayRegis]", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                await SendEmailAsync("khancapsos.webapp@gmail.com", $"Customer email: {request.Email}", bodyOfAdmin);

                /*var customer = await _dbContext.Customer.Where(x => x.ApplicationUserId == user.Id).SingleOrDefaultAsync();
                if (customer == null)
                {
                    throw new BadRequestException($"Error at Send Mail");
                }*/
                return "Connect immediately with the expert. Please wait for me a minute";
            }
            catch (Exception ex) { throw new BadRequestException($"Error at ResetPasswordQueryHandler : {ex}"); }
        }

        private async Task SendEmailAsync(string email, string subject, string body)
        {
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("no-reply@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = subject;

                message.Body = body;
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
}
