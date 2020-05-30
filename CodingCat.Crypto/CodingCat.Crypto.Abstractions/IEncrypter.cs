namespace CodingCat.Crypto.Abstractions
{
    public interface IEncrypter
    {
        byte[] Encrypt(string plainText);
    }
}