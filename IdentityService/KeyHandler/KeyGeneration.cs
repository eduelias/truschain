using System.Security.Cryptography;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Signer;
using Nethereum.Web3.Accounts;
using ServicesDefinitions.Interfaces;
using ServicesDefinitions.Models;

namespace IdentityService.KeyHandler
{
    public class KeyGeneration : IKeyGeneration
    { 
        public KeyPair GenerateNewWallet(string password)
        {
            EthECKey ecKey = Nethereum.Signer.EthECKey.GenerateKey();
            string privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
            Account account = new Account(privateKey);

            return new KeyPair()
            {
                Private = account.PrivateKey,
                Address = account.Address
            };
        }

        public KeyPair LoadFromPrivate(string privKey)
        {
            var ethEcKey = new Nethereum.Signer.EthECKey(privKey);

            return new KeyPair()
            {
                Address = ethEcKey.GetPublicAddress(),
                Private = ethEcKey.GetPrivateKey()
            };
        }

        public byte[] SignFile(string privKey, string filePath, string outPath)
        {
            CSEncryptDecrypt.CSEncryptDecrypt.EncryptFile(filePath, outPath, privKey);
            enc.
        }
    }
}