namespace CodingCat.Crypto.Abstractions
{
    public interface IDecrypter
    {
        string Decrypt(byte[] encrypted);
    }
}