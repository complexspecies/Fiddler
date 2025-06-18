﻿namespace Fiddler.Like_System
{
    public class LikesCounter
    {
        public string Likes(List<string> names)
        {
            switch (names.Count)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{names[0]} likes this";
                case 2:
                    return $"{names[0]} and {names[1]} like this";
                case 3:
                    return $"{names[0]}, {names[1]} and {names[2]} like this";
                default:
                    return $"{names[0]}, {names[1]} and {names.Count - 2} others like this";
            }
        }
    }
}
