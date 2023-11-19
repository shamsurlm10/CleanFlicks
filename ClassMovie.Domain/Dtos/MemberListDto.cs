namespace ClassMovie.Domain.Dtos
{
    public class MovieListsDto
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;


        public List<MovieDto> Movies { get; set; }
    }
}
