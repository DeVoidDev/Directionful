namespace Directionful.SDL.Util;

public unsafe readonly partial record struct Point<T> where T : unmanaged
{
    internal static Point<T> FromData(nint data)
    {
        var uData = (T*) data;
        return new Point<T>(*uData, *(uData+1));
    }
}