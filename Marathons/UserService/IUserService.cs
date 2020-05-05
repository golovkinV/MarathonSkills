﻿using System;
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
        public Country country;

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

    [DataContract]
    public class Event
    {
        [DataMember]
        public string id;

        [DataMember]
        public string name;

        [DataMember]
        public double cost;

        public Event(string id, string name, string cost)
        {
            this.id = id;
            this.name = name;
            this.cost = Convert.ToDouble(cost);
        }
    }

    [DataContract]
    public class KitOption
    {
        [DataMember]
        public string id;

        [DataMember]
        public string name;

        [DataMember]
        public double cost;

        public KitOption(string id, string name, string cost)
        {
            this.id = id;
            this.name = name;
            this.cost = Convert.ToDouble(cost);
        }
    }

    [DataContract]
    public class Charity
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        public Charity(string id, string name)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
        }
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public string code;

        [DataMember]
        public string name;
        
        public Country(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
