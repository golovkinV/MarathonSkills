using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SerializationClasses
{
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

        [DataMember]
        public RunnerData runnerData = null;

        [DataMember]
        public RegistrationStatus registrationStatus = null;

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
        public Country country;

        [DataMember]
        public Charity charity = null;

        [DataMember]
        public KitOption kitOption = null;

        [DataMember]
        public List<Event> events = null;

        [DataMember]
        public double target;

        public RunnerData(string id, string gender, string dateOfBirth, Country country)
        {
            this.id = Convert.ToInt32(id);
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
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
