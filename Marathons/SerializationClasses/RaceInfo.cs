using System;
using System.Runtime.Serialization;

namespace SerializationClasses
{
    [DataContract]
    public class RaceInfo
    {
        [DataMember]
        public string country;

        [DataMember]
        public string eventName;

        [DataMember]
        public int year;

        [DataMember]
        public long time;

        [DataMember]
        public string gender;

        [DataMember]
        public DateTime userDateOfBirth;

        public RaceInfo(string gender, string userDateOfBirth,
            string time, string country, string eventName, string year)
        {
            this.gender = gender;
            this.userDateOfBirth = Convert.ToDateTime(userDateOfBirth);
            this.time = !string.IsNullOrEmpty(time) ? Convert.ToInt64(time) : 0;
            this.country = country;
            this.eventName = eventName;
            this.year = Convert.ToInt32(year);
        }
    }
}
