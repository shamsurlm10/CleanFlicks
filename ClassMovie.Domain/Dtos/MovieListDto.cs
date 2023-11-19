using ClassMovie.Domain.DbModels;

namespace ClassMovie.Domain.Dtos
{
    public class MovieListDto
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
    }
}
