﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JAVACsharpPROJECT.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DAOservice/", ConfigurationName="ServiceReference1.service")]
    public interface service {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/AjouteSalarieRequest", ReplyAction="http://DAOservice/service/AjouteSalarieResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse AjouteSalarie(JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/AjouteSalarieRequest", ReplyAction="http://DAOservice/service/AjouteSalarieResponse")]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse> AjouteSalarieAsync(JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/RecupereListeSalarieRequest", ReplyAction="http://DAOservice/service/RecupereListeSalarieResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse RecupereListeSalarie(JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/RecupereListeSalarieRequest", ReplyAction="http://DAOservice/service/RecupereListeSalarieResponse")]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse> RecupereListeSalarieAsync(JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/ModifieSalarieRequest", ReplyAction="http://DAOservice/service/ModifieSalarieResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse ModifieSalarie(JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/ModifieSalarieRequest", ReplyAction="http://DAOservice/service/ModifieSalarieResponse")]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse> ModifieSalarieAsync(JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/SupprimeSalarieRequest", ReplyAction="http://DAOservice/service/SupprimeSalarieResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse SupprimeSalarie(JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DAOservice/service/SupprimeSalarieRequest", ReplyAction="http://DAOservice/service/SupprimeSalarieResponse")]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse> SupprimeSalarieAsync(JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://DAOservice/")]
    public partial class salarie : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string adrsField;
        
        private int codeField;
        
        private string deptsField;
        
        private string emailField;
        
        private string fonctField;
        
        private string nomField;
        
        private string prenomField;
        
        private int telField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string adrs {
            get {
                return this.adrsField;
            }
            set {
                this.adrsField = value;
                this.RaisePropertyChanged("adrs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string depts {
            get {
                return this.deptsField;
            }
            set {
                this.deptsField = value;
                this.RaisePropertyChanged("depts");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string fonct {
            get {
                return this.fonctField;
            }
            set {
                this.fonctField = value;
                this.RaisePropertyChanged("fonct");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string prenom {
            get {
                return this.prenomField;
            }
            set {
                this.prenomField = value;
                this.RaisePropertyChanged("prenom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int tel {
            get {
                return this.telField;
            }
            set {
                this.telField = value;
                this.RaisePropertyChanged("tel");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AjouteSalarie", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class AjouteSalarieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JAVACsharpPROJECT.ServiceReference1.salarie arg0;
        
        public AjouteSalarieRequest() {
        }
        
        public AjouteSalarieRequest(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AjouteSalarieResponse", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class AjouteSalarieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public AjouteSalarieResponse() {
        }
        
        public AjouteSalarieResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecupereListeSalarie", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class RecupereListeSalarieRequest {
        
        public RecupereListeSalarieRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecupereListeSalarieResponse", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class RecupereListeSalarieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JAVACsharpPROJECT.ServiceReference1.salarie[] @return;
        
        public RecupereListeSalarieResponse() {
        }
        
        public RecupereListeSalarieResponse(JAVACsharpPROJECT.ServiceReference1.salarie[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ModifieSalarie", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class ModifieSalarieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JAVACsharpPROJECT.ServiceReference1.salarie arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JAVACsharpPROJECT.ServiceReference1.salarie arg1;
        
        public ModifieSalarieRequest() {
        }
        
        public ModifieSalarieRequest(JAVACsharpPROJECT.ServiceReference1.salarie arg0, JAVACsharpPROJECT.ServiceReference1.salarie arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ModifieSalarieResponse", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class ModifieSalarieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public ModifieSalarieResponse() {
        }
        
        public ModifieSalarieResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SupprimeSalarie", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class SupprimeSalarieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public JAVACsharpPROJECT.ServiceReference1.salarie arg0;
        
        public SupprimeSalarieRequest() {
        }
        
        public SupprimeSalarieRequest(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SupprimeSalarieResponse", WrapperNamespace="http://DAOservice/", IsWrapped=true)]
    public partial class SupprimeSalarieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://DAOservice/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public SupprimeSalarieResponse() {
        }
        
        public SupprimeSalarieResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface serviceChannel : JAVACsharpPROJECT.ServiceReference1.service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class serviceClient : System.ServiceModel.ClientBase<JAVACsharpPROJECT.ServiceReference1.service>, JAVACsharpPROJECT.ServiceReference1.service {
        
        public serviceClient() {
        }
        
        public serviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public serviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse JAVACsharpPROJECT.ServiceReference1.service.AjouteSalarie(JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest request) {
            return base.Channel.AjouteSalarie(request);
        }
        
        public string AjouteSalarie(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest();
            inValue.arg0 = arg0;
            JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse retVal = ((JAVACsharpPROJECT.ServiceReference1.service)(this)).AjouteSalarie(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse> JAVACsharpPROJECT.ServiceReference1.service.AjouteSalarieAsync(JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest request) {
            return base.Channel.AjouteSalarieAsync(request);
        }
        
        public System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.AjouteSalarieResponse> AjouteSalarieAsync(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.AjouteSalarieRequest();
            inValue.arg0 = arg0;
            return ((JAVACsharpPROJECT.ServiceReference1.service)(this)).AjouteSalarieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse JAVACsharpPROJECT.ServiceReference1.service.RecupereListeSalarie(JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest request) {
            return base.Channel.RecupereListeSalarie(request);
        }
        
        public JAVACsharpPROJECT.ServiceReference1.salarie[] RecupereListeSalarie() {
            JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest();
            JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse retVal = ((JAVACsharpPROJECT.ServiceReference1.service)(this)).RecupereListeSalarie(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse> JAVACsharpPROJECT.ServiceReference1.service.RecupereListeSalarieAsync(JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest request) {
            return base.Channel.RecupereListeSalarieAsync(request);
        }
        
        public System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieResponse> RecupereListeSalarieAsync() {
            JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.RecupereListeSalarieRequest();
            return ((JAVACsharpPROJECT.ServiceReference1.service)(this)).RecupereListeSalarieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse JAVACsharpPROJECT.ServiceReference1.service.ModifieSalarie(JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest request) {
            return base.Channel.ModifieSalarie(request);
        }
        
        public string ModifieSalarie(JAVACsharpPROJECT.ServiceReference1.salarie arg0, JAVACsharpPROJECT.ServiceReference1.salarie arg1) {
            JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse retVal = ((JAVACsharpPROJECT.ServiceReference1.service)(this)).ModifieSalarie(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse> JAVACsharpPROJECT.ServiceReference1.service.ModifieSalarieAsync(JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest request) {
            return base.Channel.ModifieSalarieAsync(request);
        }
        
        public System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.ModifieSalarieResponse> ModifieSalarieAsync(JAVACsharpPROJECT.ServiceReference1.salarie arg0, JAVACsharpPROJECT.ServiceReference1.salarie arg1) {
            JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.ModifieSalarieRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((JAVACsharpPROJECT.ServiceReference1.service)(this)).ModifieSalarieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse JAVACsharpPROJECT.ServiceReference1.service.SupprimeSalarie(JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest request) {
            return base.Channel.SupprimeSalarie(request);
        }
        
        public bool SupprimeSalarie(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest();
            inValue.arg0 = arg0;
            JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse retVal = ((JAVACsharpPROJECT.ServiceReference1.service)(this)).SupprimeSalarie(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse> JAVACsharpPROJECT.ServiceReference1.service.SupprimeSalarieAsync(JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest request) {
            return base.Channel.SupprimeSalarieAsync(request);
        }
        
        public System.Threading.Tasks.Task<JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieResponse> SupprimeSalarieAsync(JAVACsharpPROJECT.ServiceReference1.salarie arg0) {
            JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest inValue = new JAVACsharpPROJECT.ServiceReference1.SupprimeSalarieRequest();
            inValue.arg0 = arg0;
            return ((JAVACsharpPROJECT.ServiceReference1.service)(this)).SupprimeSalarieAsync(inValue);
        }
    }
}
