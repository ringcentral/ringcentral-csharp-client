namespace RingCentral
{
    public partial class GlipUnreadMessageCount
    {
        // Total count of unread posts
        public long? @unreadPostsCount { get; set; }
        // 'True' if message quantity exceeds the threshold (100 by default)
        public bool? @tooManyUnreadPosts { get; set; }
    }
}
