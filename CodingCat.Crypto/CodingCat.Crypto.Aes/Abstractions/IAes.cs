using CodingCat.Crypto.Abstractions;

namespace CodingCat.Crypto.Aes.Abstractions
{
    public interface IAes : IEncrypter, IDecrypter
    {
        IAesProperties AesProperties { get; }
    }
}