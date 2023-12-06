using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace Streaming_API.Helpers;

public class PasswordManager
    {
    // Size (in bytes) of both password hash and salt
    const int keySize = 64;
    // Number of time PBKDF2 is applied to password
    const int iterations = 300000;
    //
    HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

    public (string hashString, string saltString) HashPassword(string password)
    {
        var salt = RandomNumberGenerator.GetBytes(keySize);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            iterations,
            hashAlgorithm,
            keySize);

        return (Convert.ToHexString(hash), Convert.ToHexString(salt));
    }

    public bool VerifyPassword(string password,string hashString, string salt)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, Convert.FromHexString(salt), iterations, hashAlgorithm, keySize);
        return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hashString));
    }


}