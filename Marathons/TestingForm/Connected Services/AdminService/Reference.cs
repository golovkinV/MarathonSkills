﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestingForm.AdminService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Charity", Namespace="http://schemas.datacontract.org/2004/07/AdminService")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Volunteer", Namespace="http://schemas.datacontract.org/2004/07/AdminService")]
    [System.SerializableAttribute()]
    public partial class Volunteer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;

        public Volunteer(string firstName, string lastName, string countryCode, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.countryCode = countryCode;
            this.gender = gender;
        }

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
        public string countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.countryCodeField, value) != true)) {
                    this.countryCodeField = value;
                    this.RaisePropertyChanged("countryCode");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCharity", ReplyAction="http://tempuri.org/IService1/GetAllCharityResponse")]
        TestingForm.AdminService.Charity[] GetAllCharity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCharity", ReplyAction="http://tempuri.org/IService1/GetAllCharityResponse")]
        System.Threading.Tasks.Task<TestingForm.AdminService.Charity[]> GetAllCharityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditCharity", ReplyAction="http://tempuri.org/IService1/EditCharityResponse")]
        void EditCharity(TestingForm.AdminService.Charity charity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditCharity", ReplyAction="http://tempuri.org/IService1/EditCharityResponse")]
        System.Threading.Tasks.Task EditCharityAsync(TestingForm.AdminService.Charity charity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCharity", ReplyAction="http://tempuri.org/IService1/AddCharityResponse")]
        void AddCharity(string name, string desc, string logo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCharity", ReplyAction="http://tempuri.org/IService1/AddCharityResponse")]
        System.Threading.Tasks.Task AddCharityAsync(string name, string desc, string logo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVolunteers", ReplyAction="http://tempuri.org/IService1/AddVolunteersResponse")]
        void AddVolunteers(TestingForm.AdminService.Volunteer[] volunteers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVolunteers", ReplyAction="http://tempuri.org/IService1/AddVolunteersResponse")]
        System.Threading.Tasks.Task AddVolunteersAsync(TestingForm.AdminService.Volunteer[] volunteers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestingForm.AdminService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestingForm.AdminService.IService1>, TestingForm.AdminService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestingForm.AdminService.Charity[] GetAllCharity() {
            return base.Channel.GetAllCharity();
        }
        
        public System.Threading.Tasks.Task<TestingForm.AdminService.Charity[]> GetAllCharityAsync() {
            return base.Channel.GetAllCharityAsync();
        }
        
        public void EditCharity(TestingForm.AdminService.Charity charity) {
            base.Channel.EditCharity(charity);
        }
        
        public System.Threading.Tasks.Task EditCharityAsync(TestingForm.AdminService.Charity charity) {
            return base.Channel.EditCharityAsync(charity);
        }
        
        public void AddCharity(string name, string desc, string logo) {
            base.Channel.AddCharity(name, desc, logo);
        }
        
        public System.Threading.Tasks.Task AddCharityAsync(string name, string desc, string logo) {
            return base.Channel.AddCharityAsync(name, desc, logo);
        }
        
        public void AddVolunteers(TestingForm.AdminService.Volunteer[] volunteers) {
            base.Channel.AddVolunteers(volunteers);
        }
        
        public System.Threading.Tasks.Task AddVolunteersAsync(TestingForm.AdminService.Volunteer[] volunteers) {
            return base.Channel.AddVolunteersAsync(volunteers);
        }
    }
}
