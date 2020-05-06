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

        [OperationContract]
        void EditUser(User user);

        [OperationContract]
        List<Country> GetCountries();

        [OperationContract]
        List<RegistrationStatus> GetRegistrationStatuses();

        [OperationContract]
        List<Charity> GetCharities();

        //[OperationContract]
        //void SetRunnersEvent(List<User> users);
    }
}
