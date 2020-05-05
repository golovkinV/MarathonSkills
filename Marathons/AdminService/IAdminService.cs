using System.Collections.Generic;
using System.ServiceModel;
using SerializationClasses;

namespace AdminService
{

    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        List<Charity> GetAllCharity();

        [OperationContract]
        void EditCharity(Charity charity);

        [OperationContract]
        void AddCharity(string name, string desc, string logo);

        [OperationContract]
        void AddVolunteers(List<Volunteer> volunteers);

        [OperationContract]
        List<User> GetAllUser();

        [OperationContract]
        void EditUser(User user);

        [OperationContract]
        void AddUser(string email, string password, string firstName, string lastName, string roleId);
    }
}
