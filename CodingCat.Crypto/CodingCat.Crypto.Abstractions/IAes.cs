namespace CodingCat.Crypto.Abstractions
{
    public interface IAes : IEncrypter, IDecrypter
    {
        IAesKey AesKey { get; }
    }
}