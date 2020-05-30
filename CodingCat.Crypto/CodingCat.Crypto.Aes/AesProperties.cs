using CodingCat.Crypto.Aes.Abstractions;
using System.Security.Cryptography;

namespace CodingCat.Crypto.Aes
{
    public class AesProperties : IAesProperties
    {
        public byte[] Key { get; }
        public byte[] IV { get; }

        #region Constructor(s)
        public AesProperties(byte[] key, byte[] iv)
        {
            this.Key = key;
            this.IV = iv;
        }
        #endregion

        public static IAesProperties Create()
        {
            using (var provider = new TripleDESCryptoServiceProvider())
            {
                return new AesProperties(
                    provider.Key,
                    provider.IV
                );
            }
        }
    }
}