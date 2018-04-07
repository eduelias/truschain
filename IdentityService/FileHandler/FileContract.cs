using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Web3;

namespace IdentityService.FileHandler
{
    public class FileContract
    {
        private string Abi = @"[{""constant"":false,""inputs"":[{""name"":""newFileName"",""type"":""string""},{""name"":""newFileHash"",""type"":""string""}],""name"":""updateFile"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""anonymous"":false,""inputs"":[{""indexed"":false,""name"":""eventId"",""type"":""string""},{""indexed"":false,""name"":""eventDescriptor"",""type"":""string""}],""name"":""OnChange"",""type"":""event""}]";

        private Web3 web3 { get; set; }

        public FileContract()
        {
            this.web3 = new Web3("http://104.40.190.151:8545");
        }

        public static bool SHOULDRUN = true;

        public async void AttachToEvent(string address, string eventName, Action<string, dynamic> callback)
        {
            var contract = this.web3.Eth.GetContract(this.Abi, address);

            var multiplyEvent = contract.GetEvent(eventName);

            var filterAll = multiplyEvent.CreateFilterAsync().Result;

            var log = await multiplyEvent.GetFilterChanges<dynamic>(filterAll);

            while (SHOULDRUN)
            {
                log = await multiplyEvent.GetFilterChanges<dynamic>(filterAll);

                if (log.Count == 0)
                    continue;
                callback(eventName, log);

                log.Clear();
            }
        }
    }
}
