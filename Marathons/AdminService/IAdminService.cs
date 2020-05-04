using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
    }


    [DataContract]
    public class Charity
    {

        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string desc;

        [DataMember]
        public string logo;

        public Charity(string id, string name, string desc, string logo)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.desc = desc;
            this.logo = logo;
        }
    }

    [DataContract]
    public class Volunteer
    {
        [DataMember]
        public string firstName;

        [DataMember]
        public string lastName;

        [DataMember]
        public string countryCode;

        [DataMember]
        public string gender;

        public Volunteer(string firstName, string lastName, string countryCode, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.countryCode = countryCode;
            this.gender = gender;
        }
    }


    [DataContract]
    public class User
    {
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
