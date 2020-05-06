using System;
using System.Runtime.Serialization;

namespace SerializationClasses
{
    [DataContract]
    public class RaceResult
    {
        [DataMember]
        public string runnerName;

        [DataMember]
        public string country;

        [DataMember]
        public double raceTime;

        [DataMember]
        public string gender;

        [DataMember]
        public int marathonId;

        [DataMember]
        public string eventTypeId;

        [DataMember]
        public string dateOfBirth;

        public RaceResult(string firstName, string lastName, string country, 
            string raceTime, string gender, string marathonId, string eventTypeId, string dateOfBirth)
        {
            runnerName = $"{firstName} {lastName}";
            this.country = country;
            this.raceTime = Convert.ToDouble(raceTime);
            this.gender = gender;
            this.marathonId = Convert.ToInt32(marathonId);
            this.eventTypeId = eventTypeId;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
