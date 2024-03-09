using LinhChiDoiSOS.Application.Common.Interfaces;

namespace LinhChiDoiSOS.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
