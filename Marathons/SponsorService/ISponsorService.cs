using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SponsorService
{

    [ServiceContract]
    public interface ISponsorService
    {
        [OperationContract]
        List<Runner> GetRunners();

    }

    [DataContract]
    public class Runner
    {
        [DataMember]
        public int id;

        [DataMember]
        public int registrationId;

        [DataMember]
        public string firstName;

        [DataMember]
        public string lastName;

        [DataMember]
        public string country;

        [DataMember]
        public double sponsorshipTarget;

        public Runner(string id, string registrationId, 
            string firstName, string lastName, string country, string sponsorshipTarget)
        {
            this.id = Convert.ToInt32(id);
            this.registrationId = Convert.ToInt32(registrationId);
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
            this.sponsorshipTarget = Convert.ToDouble(sponsorshipTarget);
        }
    }
}
