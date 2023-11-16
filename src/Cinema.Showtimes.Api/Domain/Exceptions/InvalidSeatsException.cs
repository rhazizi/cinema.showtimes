using Cinema.Showtimes.Api.Domain.Exceptions.BaseExceptions;

namespace Cinema.Showtimes.Api.Domain.Exceptions;

public class InvalidSeatsException : UnprocessableEntityException
{
    public InvalidSeatsException() : base("The selected seats are not valid.")
    {
    }
}