using System.Collections.Generic;

namespace DefaultNamespace
{
    public static class TagManager
    {
        private static readonly Dictionary<TagType, string> _tags = 
            new Dictionary<TagType, string>
            {
                {TagType.Player, "Player"},
                {TagType.Enemy, "Enemy"}
            };

        public static string GetTag(TagType tagType)
        {
            return _tags[tagType];
        }
    }
}
