using System.Collections.Generic;
using SerializationClasses;
using System.ServiceModel;

namespace UserService
{

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User Login(string email, string password);

        [OperationContract]
        void EditUser(User user);

        [OperationContract]
        void RegisterAsRunner(string email, string password, string firstName, string lastName,
            string gender, string dateOfBirth, string countryCode);

        [OperationContract]
        void RegisterForEvent(string email, List<string> eventIds,
            string kitOptionId, int charityId, double registrationCost);

        [OperationContract]
        List<Event> GetEvents();

        [OperationContract]
        List<KitOption> GetKitOptions();

        [OperationContract]
        List<Charity> GetCharities();

        [OperationContract]
        List<Country> GetCountries();
    }
}
