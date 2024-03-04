namespace Art_Gallery_WebAPI.Models
{
    public class ArtWork
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Author { get; set; }
        public string? Size { get; set; }
        public string? Location { get; set; }
        public string? Img { get; set; }
        public string? Plot { get; set; }
    }
}
