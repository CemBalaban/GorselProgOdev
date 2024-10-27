namespace GorselProgOdev.Helpers;

public static class HotReloadServices
{
    public static event Action<Type[]?>? UpdateApplicationEvent;
    internal static void ClearCache(Type[]? types) { }
    internal static void UpdateApplication(Type[]? types)
    {
        UpdateApplicationEvent?.Invoke(types);
    }
}