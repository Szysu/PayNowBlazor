using NetTopologySuite.Geometries;

namespace PayNowBlazor.Infrastructure.Entities;

public class Rental
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ScooterId { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public Point FromLocation { get; set; }
    public Point ToLocation { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual Scooter Scooter { get; set; }
}