using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdminService
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Charity> GetAllCharity();

        [OperationContract]
        void EditCharity(Charity charity);

        [OperationContract]
        void AddCharity(string name, string desc, string logo);

        [OperationContract]
        void AddVolunteers(List<Volunteer> volunteers);
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
}
