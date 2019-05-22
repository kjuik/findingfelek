public static class GenericExtensions
{
    public static T OrThrow<T>(this T obj)
    {
#if UNITY_EDITOR
        if (obj != null)
            return obj;
        else
            throw new System.Exception($"No component {typeof(T)} found!");
#else
       return obj;
#endif
    }
}
