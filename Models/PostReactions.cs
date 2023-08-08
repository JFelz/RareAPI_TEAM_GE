namespace TEAMGE_API.Models
{
    public class PostReactions
    {
        public int Id { get; set; }
        public int ReactionId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
