namespace OnlineQuizApi.Framework.ExtensionMethods
{
    public static class ObjectExtensionMethods
    {
        public static bool IsNull<T>(this object obj) => obj is null;
        public static bool IsNotNull<T>(this object obj) => obj is not null;
    }


}
