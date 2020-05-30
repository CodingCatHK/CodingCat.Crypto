namespace CodingCat.Crypto.Abstractions
{
    public interface IAesKey
    {
        byte[] Key { get; }
        byte[] IV { get; }
    }
}