﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrangeiroApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ServiceTest")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateOrderRequest", Namespace="http://schemas.datacontract.org/2004/07/ServiceTest")]
    [System.SerializableAttribute()]
    public partial class CreateOrderRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountInCentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HolderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid MerchantKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrderNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SecurityCodeField;
        
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
        public int AmountInCents {
            get {
                return this.AmountInCentsField;
            }
            set {
                if ((this.AmountInCentsField.Equals(value) != true)) {
                    this.AmountInCentsField = value;
                    this.RaisePropertyChanged("AmountInCents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreditCardNumber {
            get {
                return this.CreditCardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardNumberField, value) != true)) {
                    this.CreditCardNumberField = value;
                    this.RaisePropertyChanged("CreditCardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HolderName {
            get {
                return this.HolderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HolderNameField, value) != true)) {
                    this.HolderNameField = value;
                    this.RaisePropertyChanged("HolderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid MerchantKey {
            get {
                return this.MerchantKeyField;
            }
            set {
                if ((this.MerchantKeyField.Equals(value) != true)) {
                    this.MerchantKeyField = value;
                    this.RaisePropertyChanged("MerchantKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrderNumber {
            get {
                return this.OrderNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderNumberField, value) != true)) {
                    this.OrderNumberField = value;
                    this.RaisePropertyChanged("OrderNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SecurityCode {
            get {
                return this.SecurityCodeField;
            }
            set {
                if ((this.SecurityCodeField.Equals(value) != true)) {
                    this.SecurityCodeField = value;
                    this.RaisePropertyChanged("SecurityCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateOrderResponse", Namespace="http://schemas.datacontract.org/2004/07/ServiceTest")]
    [System.SerializableAttribute()]
    public partial class CreateOrderResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountInCentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HolderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid MerchantKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid OrderKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public int AmountInCents {
            get {
                return this.AmountInCentsField;
            }
            set {
                if ((this.AmountInCentsField.Equals(value) != true)) {
                    this.AmountInCentsField = value;
                    this.RaisePropertyChanged("AmountInCents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreditCardNumber {
            get {
                return this.CreditCardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardNumberField, value) != true)) {
                    this.CreditCardNumberField = value;
                    this.RaisePropertyChanged("CreditCardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDescription {
            get {
                return this.ErrorDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDescriptionField, value) != true)) {
                    this.ErrorDescriptionField = value;
                    this.RaisePropertyChanged("ErrorDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HolderName {
            get {
                return this.HolderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HolderNameField, value) != true)) {
                    this.HolderNameField = value;
                    this.RaisePropertyChanged("HolderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid MerchantKey {
            get {
                return this.MerchantKeyField;
            }
            set {
                if ((this.MerchantKeyField.Equals(value) != true)) {
                    this.MerchantKeyField = value;
                    this.RaisePropertyChanged("MerchantKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OrderKey {
            get {
                return this.OrderKeyField;
            }
            set {
                if ((this.OrderKeyField.Equals(value) != true)) {
                    this.OrderKeyField = value;
                    this.RaisePropertyChanged("OrderKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        GrangeiroApp.ServiceReference1.CompositeType GetDataUsingDataContract(GrangeiroApp.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<GrangeiroApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(GrangeiroApp.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetName", ReplyAction="http://tempuri.org/IService1/GetNameResponse")]
        string GetName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetName", ReplyAction="http://tempuri.org/IService1/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSobrenome", ReplyAction="http://tempuri.org/IService1/GetSobrenomeResponse")]
        string GetSobrenome();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSobrenome", ReplyAction="http://tempuri.org/IService1/GetSobrenomeResponse")]
        System.Threading.Tasks.Task<string> GetSobrenomeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateOrder", ReplyAction="http://tempuri.org/IService1/CreateOrderResponse")]
        GrangeiroApp.ServiceReference1.CreateOrderResponse CreateOrder(GrangeiroApp.ServiceReference1.CreateOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateOrder", ReplyAction="http://tempuri.org/IService1/CreateOrderResponse")]
        System.Threading.Tasks.Task<GrangeiroApp.ServiceReference1.CreateOrderResponse> CreateOrderAsync(GrangeiroApp.ServiceReference1.CreateOrderRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GrangeiroApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GrangeiroApp.ServiceReference1.IService1>, GrangeiroApp.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public GrangeiroApp.ServiceReference1.CompositeType GetDataUsingDataContract(GrangeiroApp.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<GrangeiroApp.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(GrangeiroApp.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetName() {
            return base.Channel.GetName();
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync() {
            return base.Channel.GetNameAsync();
        }
        
        public string GetSobrenome() {
            return base.Channel.GetSobrenome();
        }
        
        public System.Threading.Tasks.Task<string> GetSobrenomeAsync() {
            return base.Channel.GetSobrenomeAsync();
        }
        
        public GrangeiroApp.ServiceReference1.CreateOrderResponse CreateOrder(GrangeiroApp.ServiceReference1.CreateOrderRequest request) {
            return base.Channel.CreateOrder(request);
        }
        
        public System.Threading.Tasks.Task<GrangeiroApp.ServiceReference1.CreateOrderResponse> CreateOrderAsync(GrangeiroApp.ServiceReference1.CreateOrderRequest request) {
            return base.Channel.CreateOrderAsync(request);
        }
    }
}
