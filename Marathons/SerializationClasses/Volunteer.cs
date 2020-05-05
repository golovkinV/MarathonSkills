using System.Runtime.Serialization;

namespace SerializationClasses
{
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
