﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.SponsorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Runner", Namespace="http://schemas.datacontract.org/2004/07/SerializationClasses")]
    [System.SerializableAttribute()]
    public partial class Runner : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.SponsorService.Charity charityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int registrationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sponsorshipTargetField;
        
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
        public Client.SponsorService.Charity charity {
            get {
                return this.charityField;
            }
            set {
                if ((object.ReferenceEquals(this.charityField, value) != true)) {
                    this.charityField = value;
                    this.RaisePropertyChanged("charity");
                }
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
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
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
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sponsorshipTarget {
            get {
                return this.sponsorshipTargetField;
            }
            set {
                if ((this.sponsorshipTargetField.Equals(value) != true)) {
                    this.sponsorshipTargetField = value;
                    this.RaisePropertyChanged("sponsorshipTarget");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Charity", Namespace="http://schemas.datacontract.org/2004/07/SerializationClasses")]
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
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double totalAmountField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double totalAmount {
            get {
                return this.totalAmountField;
            }
            set {
                if ((this.totalAmountField.Equals(value) != true)) {
                    this.totalAmountField = value;
                    this.RaisePropertyChanged("totalAmount");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SponsorService.ISponsorService")]
    public interface ISponsorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISponsorService/GetRunners", ReplyAction="http://tempuri.org/ISponsorService/GetRunnersResponse")]
        Client.SponsorService.Runner[] GetRunners();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISponsorService/GetRunners", ReplyAction="http://tempuri.org/ISponsorService/GetRunnersResponse")]
        System.Threading.Tasks.Task<Client.SponsorService.Runner[]> GetRunnersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISponsorService/SponsorRunner", ReplyAction="http://tempuri.org/ISponsorService/SponsorRunnerResponse")]
        void SponsorRunner(string name, Client.SponsorService.Runner runner, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISponsorService/SponsorRunner", ReplyAction="http://tempuri.org/ISponsorService/SponsorRunnerResponse")]
        System.Threading.Tasks.Task SponsorRunnerAsync(string name, Client.SponsorService.Runner runner, double amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISponsorServiceChannel : Client.SponsorService.ISponsorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SponsorServiceClient : System.ServiceModel.ClientBase<Client.SponsorService.ISponsorService>, Client.SponsorService.ISponsorService {
        
        public SponsorServiceClient() {
        }
        
        public SponsorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SponsorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SponsorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SponsorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.SponsorService.Runner[] GetRunners() {
            return base.Channel.GetRunners();
        }
        
        public System.Threading.Tasks.Task<Client.SponsorService.Runner[]> GetRunnersAsync() {
            return base.Channel.GetRunnersAsync();
        }
        
        public void SponsorRunner(string name, Client.SponsorService.Runner runner, double amount) {
            base.Channel.SponsorRunner(name, runner, amount);
        }
        
        public System.Threading.Tasks.Task SponsorRunnerAsync(string name, Client.SponsorService.Runner runner, double amount) {
            return base.Channel.SponsorRunnerAsync(name, runner, amount);
        }
    }
}