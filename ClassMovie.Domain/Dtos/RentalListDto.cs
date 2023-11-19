namespace ClassMovie.Domain.Dtos
{
    public class RentalListDto
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }
    }
}
