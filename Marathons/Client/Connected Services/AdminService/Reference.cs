﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.AdminService {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/AdminService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.AdminService.Role roleField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
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
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.AdminService.Role role {
            get {
                return this.roleField;
            }
            set {
                if ((object.ReferenceEquals(this.roleField, value) != true)) {
                    this.roleField = value;
                    this.RaisePropertyChanged("role");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/AdminService")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string roleIdField;
        
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
        public string roleId {
            get {
                return this.roleIdField;
            }
            set {
                if ((object.ReferenceEquals(this.roleIdField, value) != true)) {
                    this.roleIdField = value;
                    this.RaisePropertyChanged("roleId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllCharity", ReplyAction="http://tempuri.org/IAdminService/GetAllCharityResponse")]
        Client.AdminService.Charity[] GetAllCharity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllCharity", ReplyAction="http://tempuri.org/IAdminService/GetAllCharityResponse")]
        System.Threading.Tasks.Task<Client.AdminService.Charity[]> GetAllCharityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/EditCharity", ReplyAction="http://tempuri.org/IAdminService/EditCharityResponse")]
        void EditCharity(Client.AdminService.Charity charity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/EditCharity", ReplyAction="http://tempuri.org/IAdminService/EditCharityResponse")]
        System.Threading.Tasks.Task EditCharityAsync(Client.AdminService.Charity charity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddCharity", ReplyAction="http://tempuri.org/IAdminService/AddCharityResponse")]
        void AddCharity(string name, string desc, string logo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddCharity", ReplyAction="http://tempuri.org/IAdminService/AddCharityResponse")]
        System.Threading.Tasks.Task AddCharityAsync(string name, string desc, string logo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddVolunteers", ReplyAction="http://tempuri.org/IAdminService/AddVolunteersResponse")]
        void AddVolunteers(Client.AdminService.Volunteer[] volunteers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddVolunteers", ReplyAction="http://tempuri.org/IAdminService/AddVolunteersResponse")]
        System.Threading.Tasks.Task AddVolunteersAsync(Client.AdminService.Volunteer[] volunteers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllUser", ReplyAction="http://tempuri.org/IAdminService/GetAllUserResponse")]
        Client.AdminService.User[] GetAllUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllUser", ReplyAction="http://tempuri.org/IAdminService/GetAllUserResponse")]
        System.Threading.Tasks.Task<Client.AdminService.User[]> GetAllUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/EditUser", ReplyAction="http://tempuri.org/IAdminService/EditUserResponse")]
        void EditUser(Client.AdminService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/EditUser", ReplyAction="http://tempuri.org/IAdminService/EditUserResponse")]
        System.Threading.Tasks.Task EditUserAsync(Client.AdminService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddUser", ReplyAction="http://tempuri.org/IAdminService/AddUserResponse")]
        void AddUser(string email, string password, string firstName, string lastName, string roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddUser", ReplyAction="http://tempuri.org/IAdminService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string email, string password, string firstName, string lastName, string roleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : Client.AdminService.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<Client.AdminService.IAdminService>, Client.AdminService.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.AdminService.Charity[] GetAllCharity() {
            return base.Channel.GetAllCharity();
        }
        
        public System.Threading.Tasks.Task<Client.AdminService.Charity[]> GetAllCharityAsync() {
            return base.Channel.GetAllCharityAsync();
        }
        
        public void EditCharity(Client.AdminService.Charity charity) {
            base.Channel.EditCharity(charity);
        }
        
        public System.Threading.Tasks.Task EditCharityAsync(Client.AdminService.Charity charity) {
            return base.Channel.EditCharityAsync(charity);
        }
        
        public void AddCharity(string name, string desc, string logo) {
            base.Channel.AddCharity(name, desc, logo);
        }
        
        public System.Threading.Tasks.Task AddCharityAsync(string name, string desc, string logo) {
            return base.Channel.AddCharityAsync(name, desc, logo);
        }
        
        public void AddVolunteers(Client.AdminService.Volunteer[] volunteers) {
            base.Channel.AddVolunteers(volunteers);
        }
        
        public System.Threading.Tasks.Task AddVolunteersAsync(Client.AdminService.Volunteer[] volunteers) {
            return base.Channel.AddVolunteersAsync(volunteers);
        }
        
        public Client.AdminService.User[] GetAllUser() {
            return base.Channel.GetAllUser();
        }
        
        public System.Threading.Tasks.Task<Client.AdminService.User[]> GetAllUserAsync() {
            return base.Channel.GetAllUserAsync();
        }
        
        public void EditUser(Client.AdminService.User user) {
            base.Channel.EditUser(user);
        }
        
        public System.Threading.Tasks.Task EditUserAsync(Client.AdminService.User user) {
            return base.Channel.EditUserAsync(user);
        }
        
        public void AddUser(string email, string password, string firstName, string lastName, string roleId) {
            base.Channel.AddUser(email, password, firstName, lastName, roleId);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string email, string password, string firstName, string lastName, string roleId) {
            return base.Channel.AddUserAsync(email, password, firstName, lastName, roleId);
        }
    }
}