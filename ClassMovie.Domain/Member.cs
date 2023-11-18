namespace ClassMovie.Domain
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        //One to Many Relationship
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}
