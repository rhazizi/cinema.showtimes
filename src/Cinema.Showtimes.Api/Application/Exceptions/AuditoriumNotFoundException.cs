using Cinema.Showtimes.Api.Common.BaseExceptions;

namespace Cinema.Showtimes.Api.Application.Exceptions;

public class AuditoriumNotFoundException : NotFoundException
{
    public AuditoriumNotFoundException(int id) : base($"Auditorium with id '{id}' does not exist.")
    {
    }
}