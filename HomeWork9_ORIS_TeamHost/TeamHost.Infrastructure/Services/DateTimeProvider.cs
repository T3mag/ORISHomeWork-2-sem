using TeamHost.Application.Interfaces;
namespace TeamHost.Infrastructure.Services;
public class DateTimeProvider : IDateTimeProvider{
    public DateTime CurrentDate => DateTime.UtcNow;
}