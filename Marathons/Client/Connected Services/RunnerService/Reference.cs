﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.RunnerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sponsor", Namespace="http://schemas.datacontract.org/2004/07/RunnerService")]
    [System.SerializableAttribute()]
    public partial class Sponsor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int charityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int registrationIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int charityId {
            get {
                return this.charityIdField;
            }
            set {
                if ((this.charityIdField.Equals(value) != true)) {
                    this.charityIdField = value;
                    this.RaisePropertyChanged("charityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int registrationId {
            get {
                return this.registrationIdField;
            }
            set {
                if ((this.registrationIdField.Equals(value) != true)) {
                    this.registrationIdField = value;
                    this.RaisePropertyChanged("registrationId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Charity", Namespace="http://schemas.datacontract.org/2004/07/RunnerService")]
    [System.SerializableAttribute()]
    public partial class Charity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string logoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string desc {
            get {
                return this.descField;
            }
            set {
                if ((object.ReferenceEquals(this.descField, value) != true)) {
                    this.descField = value;
                    this.RaisePropertyChanged("desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string logo {
            get {
                return this.logoField;
            }
            set {
                if ((object.ReferenceEquals(this.logoField, value) != true)) {
                    this.logoField = value;
                    this.RaisePropertyChanged("logo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RaceInfo", Namespace="http://schemas.datacontract.org/2004/07/RunnerService")]
    [System.SerializableAttribute()]
    public partial class RaceInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string eventNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime userDateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string eventName {
            get {
                return this.eventNameField;
            }
            set {
                if ((object.ReferenceEquals(this.eventNameField, value) != true)) {
                    this.eventNameField = value;
                    this.RaisePropertyChanged("eventName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long time {
            get {
                return this.timeField;
            }
            set {
                if ((this.timeField.Equals(value) != true)) {
                    this.timeField = value;
                    this.RaisePropertyChanged("time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime userDateOfBirth {
            get {
                return this.userDateOfBirthField;
            }
            set {
                if ((this.userDateOfBirthField.Equals(value) != true)) {
                    this.userDateOfBirthField = value;
                    this.RaisePropertyChanged("userDateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int year {
            get {
                return this.yearField;
            }
            set {
                if ((this.yearField.Equals(value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RunnerService.IRunnerService")]
    public interface IRunnerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetSponsorship", ReplyAction="http://tempuri.org/IRunnerService/GetSponsorshipResponse")]
        Client.RunnerService.Sponsor[] GetSponsorship(int runnerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetSponsorship", ReplyAction="http://tempuri.org/IRunnerService/GetSponsorshipResponse")]
        System.Threading.Tasks.Task<Client.RunnerService.Sponsor[]> GetSponsorshipAsync(int runnerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetCharity", ReplyAction="http://tempuri.org/IRunnerService/GetCharityResponse")]
        Client.RunnerService.Charity GetCharity(int charityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetCharity", ReplyAction="http://tempuri.org/IRunnerService/GetCharityResponse")]
        System.Threading.Tasks.Task<Client.RunnerService.Charity> GetCharityAsync(int charityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetRaces", ReplyAction="http://tempuri.org/IRunnerService/GetRacesResponse")]
        Client.RunnerService.RaceInfo[] GetRaces(int runnerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRunnerService/GetRaces", ReplyAction="http://tempuri.org/IRunnerService/GetRacesResponse")]
        System.Threading.Tasks.Task<Client.RunnerService.RaceInfo[]> GetRacesAsync(int runnerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRunnerServiceChannel : Client.RunnerService.IRunnerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RunnerServiceClient : System.ServiceModel.ClientBase<Client.RunnerService.IRunnerService>, Client.RunnerService.IRunnerService {
        
        public RunnerServiceClient() {
        }
        
        public RunnerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RunnerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RunnerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RunnerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.RunnerService.Sponsor[] GetSponsorship(int runnerId) {
            return base.Channel.GetSponsorship(runnerId);
        }
        
        public System.Threading.Tasks.Task<Client.RunnerService.Sponsor[]> GetSponsorshipAsync(int runnerId) {
            return base.Channel.GetSponsorshipAsync(runnerId);
        }
        
        public Client.RunnerService.Charity GetCharity(int charityId) {
            return base.Channel.GetCharity(charityId);
        }
        
        public System.Threading.Tasks.Task<Client.RunnerService.Charity> GetCharityAsync(int charityId) {
            return base.Channel.GetCharityAsync(charityId);
        }
        
        public Client.RunnerService.RaceInfo[] GetRaces(int runnerId) {
            return base.Channel.GetRaces(runnerId);
        }
        
        public System.Threading.Tasks.Task<Client.RunnerService.RaceInfo[]> GetRacesAsync(int runnerId) {
            return base.Channel.GetRacesAsync(runnerId);
        }
    }
}