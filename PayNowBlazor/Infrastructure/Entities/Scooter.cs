namespace PayNowWeb.Infrastructure.Entities;

public class Scooter
{
    public int Id { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public DateOnly ProductionDate { get; set; }
    public virtual ICollection<Maintenance> Maintenances { get; set; }
    public virtual ICollection<Rental> Rentals { get; set; }
}