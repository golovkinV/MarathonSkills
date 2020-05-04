using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
    }

    [DataContract]
    public class User {
        [DataMember]
        public string email;

        [DataMember]
        public string password;

        [DataMember]
        public string firstName;

        [DataMember]
        public string lastName;

        [DataMember]
        public Role role;

        [DataMember]
        public RunnerData runnerData = null;


        public User(string email, string password, 
            string firstName, string lastName, Role role)
        {
            this.email = email;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
        }
    }

    [DataContract]
    public class RunnerData
    {
        [DataMember]
        public int id;

        [DataMember]
        public string gender;

        [DataMember]
        public string dateOfBirth;

        [DataMember]
        public string countryCode;

        [DataMember]
        public string country;

        public RunnerData(string id, string gender, string dateOfBirth, string countryCode, string country)
        {
            this.id = Convert.ToInt32(id);
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.countryCode = countryCode;
            this.country = country;
        }
    }

    [DataContract]
    public class Role
    {
        [DataMember]
        public string roleId;

        [DataMember]
        public string name;

        public Role(string id)
        {
            roleId = id;
            name = getRoleName(id);
        }

        private string getRoleName(string id)
        {
            switch (id)
            {
                case "A":
                    return "Administrator";
                case "C":
                    return "Coordinator";
                case "R":
                    return "Runner";
                default:
                    return "";
            }
        }
    }
}
