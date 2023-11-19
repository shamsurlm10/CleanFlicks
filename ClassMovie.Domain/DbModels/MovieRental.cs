using System.Text.Json.Serialization;

namespace ClassMovie.Domain.DbModels
{
    public class MovieRental
    {
        public int MovieRentalId { get; set; }
        public int RentalId { get; set; }
        [JsonIgnore]
        public Rental Rental { get; set; }
        public int MovieId { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}