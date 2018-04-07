using System.ServiceModel;

namespace TrusChain_v2
{
    [ServiceContract]
    interface IServiceContract
    {
        [OperationContract]
        int ShareFile(string path, string address, string walletAddress);
    }
}
