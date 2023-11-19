namespace ClassMovie.Domain.Dtos
{
    public class MovieDto
    {
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
    }
}
