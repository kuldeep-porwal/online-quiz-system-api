namespace OnlineQuizApi.Framework.ExtensionMethods
{
    public static class ListExtensionMethods
    {
        public static bool IsEmpty<T>(this List<T> list) => list?.Count == 0;
        public static bool IsNotEmpty<T>(this List<T> list) => list?.Count != 0;
    }
}
