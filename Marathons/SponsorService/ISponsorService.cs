using System.Collections.Generic;
using System.ServiceModel;
using SerializationClasses;

namespace SponsorService
{

    [ServiceContract]
    public interface ISponsorService
    {
        [OperationContract]
        List<Runner> GetRunners();

        [OperationContract]
        void SponsorRunner(string name, Runner runner, double amount);
    }
}
