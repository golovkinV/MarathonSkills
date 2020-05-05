using System.Collections.Generic;
using System.ServiceModel;
using SerializationClasses;


namespace RunnerService
{

    [ServiceContract]
    public interface IRunnerService
    {
        [OperationContract]
        List<Sponsor> GetSponsorship(int runnerId);

        [OperationContract]
        Charity GetCharity(int charityId);

        [OperationContract]
        List<RaceInfo> GetRaces(int runnerId);
    }
}
