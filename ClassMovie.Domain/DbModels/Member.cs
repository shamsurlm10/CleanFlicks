using System.Text.Json.Serialization;

namespace ClassMovie.Domain.DbModels
    {
        public class Member
        {
            public int MemberId { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public int RentalId { get; set; }
            [JsonIgnore]
            public Rental Rental { get; set; }
        }
    }
