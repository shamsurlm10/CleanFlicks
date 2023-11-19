using System.Text.Json.Serialization;

namespace ClassMovie.Domain.Dtos
{
    public class MovieRentalListDto
    {
        public int MovieRentalId { get; set; }
        public int RentalId { get; set; }
        public int MovieId { get; set; }
    }
}
