namespace ClassMovie.Domain.Dtos
{
    public class RentalDto
    {
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }
    }
}
