namespace AnteaterStudios.Linelib
{
    public abstract class ContentLoader<T>
    {
        internal abstract T LoadContent(byte[] data);
    }
}