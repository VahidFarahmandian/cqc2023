using System.Security.Cryptography;

public class Duplication2
{
    public string GetString(int length, IEnumerable<char> characterSet)
    {
        if (length < 0)
            throw new ArgumentException("length must not be negative", nameof(length));
        if (length > int.MaxValue / 8) 
            throw new ArgumentException("length is too big", nameof(length));
        if (characterSet == null)
            throw new ArgumentNullException(nameof(characterSet));
        var characterArray = characterSet.Distinct().ToArray();
        if (characterArray.Length == 0)
            throw new ArgumentException("characterSet must not be empty", nameof(characterSet));
        var bytes = new byte[length * 8];
        var result = new char[length];
        using (RandomNumberGenerator cryptoProvider = RandomNumberGenerator.Create())
        {
            cryptoProvider.GetBytes(bytes);
        }
        for (int i = 0; i < length; i++)
        {
            ulong value = BitConverter.ToUInt64(bytes, i * 8);
            result[i] = characterArray[value % (uint)characterArray.Length];
        }
        return new string(result);
    }
}