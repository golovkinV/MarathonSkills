using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using SerializationClasses;
using System.Text;

namespace InfoService
{

    [ServiceContract]
    public interface IInfoService
    {
        [OperationContract]
        List<RaceResult> GetRaces();
    }
}
