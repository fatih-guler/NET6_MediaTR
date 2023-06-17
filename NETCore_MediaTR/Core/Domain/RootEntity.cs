namespace NETCore_MediaTR.Core.Domain
{
    public class RootEntity : IRootEntity
    {
        public string Id { get; init; } // Id will be set inside constructor only
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
