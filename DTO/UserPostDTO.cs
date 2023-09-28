namespace FluentValidationsSample.DTO
{
    public class UserPostDTO
    {        
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public int ProfileId { get; set; }
    }
}