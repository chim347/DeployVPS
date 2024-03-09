using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<SOSResponse>
    {
        // theo nguyên tắc bussiness t đề ra, trả tiền xong rồi mới tạo booking
        // bước này admin sẽ tạo cho khách hàng
        public double? Price { get; set; }
        public string CustomerId { get; set; }

        // comboCourse => premium
        public string ComboCourseId { get; set; }
    }

    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, SOSResponse>
    {
        public readonly ILinhChiDoiSOSDbContext _dbContext;
        public CreateBookingCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SOSResponse> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = new Booking
            {
                Price = request.Price,
                CustomerId = Guid.Parse(request.CustomerId)
            };
            _dbContext.Booking.Add(booking);

            var comboCourseExist = await _dbContext.ComboCourse.Where(c => c.Id == Guid.Parse(request.ComboCourseId)).SingleOrDefaultAsync();
            if (comboCourseExist == null) {
                throw new NotFoundException("Does not exist ComboCourse");
            }
            var bookingDetail = new BookingDetail
            {
                BookingId = booking.Id,
                ComboCourseId = comboCourseExist.Id
            };
            _dbContext.BookingDetail.Add(bookingDetail);
            var customer = _dbContext.Customer.Where(x => x.Id == Guid.Parse(request.CustomerId)).SingleOrDefault();
            if(customer != null)
            {
                customer.IsPremium = 2;
                _dbContext.Customer.Update(customer);
            }
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}
