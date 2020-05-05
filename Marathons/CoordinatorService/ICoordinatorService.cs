using System;
using System.Collections.Generic;
using System.ServiceModel;
using SerializationClasses;

namespace CoordinatorService
{

    [ServiceContract]
    public interface ICoordinatorService
    {
        [OperationContract]
        List<User> GetAllRunners();
    }
}
