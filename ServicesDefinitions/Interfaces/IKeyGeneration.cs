using ServicesDefinitions.Models;

namespace ServicesDefinitions.Interfaces
{
    public interface IKeyGeneration
    {
        KeyPair GenerateNewWallet(string password);

        KeyPair LoadFromPrivate(string privKey);
    }
}