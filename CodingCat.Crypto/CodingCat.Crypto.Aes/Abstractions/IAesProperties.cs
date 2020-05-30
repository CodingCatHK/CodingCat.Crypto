namespace CodingCat.Crypto.Aes.Abstractions
{
    public interface IAesProperties
    {
        byte[] Key { get; }
        byte[] IV { get; }
    }
}