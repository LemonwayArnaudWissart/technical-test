﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        ConsoleApp.ServiceReference.XmlToJsonResponse XmlToJson(ConsoleApp.ServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp.ServiceReference.XmlToJsonResponse> XmlToJsonAsync(ConsoleApp.ServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.ServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(ConsoleApp.ServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp.ServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(ConsoleApp.ServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ConsoleApp.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApp.ServiceReference.WebServiceSoap>, ConsoleApp.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp.ServiceReference.XmlToJsonResponse ConsoleApp.ServiceReference.WebServiceSoap.XmlToJson(ConsoleApp.ServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            ConsoleApp.ServiceReference.XmlToJsonRequest inValue = new ConsoleApp.ServiceReference.XmlToJsonRequest();
            inValue.Body = new ConsoleApp.ServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            ConsoleApp.ServiceReference.XmlToJsonResponse retVal = ((ConsoleApp.ServiceReference.WebServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp.ServiceReference.XmlToJsonResponse> ConsoleApp.ServiceReference.WebServiceSoap.XmlToJsonAsync(ConsoleApp.ServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp.ServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            ConsoleApp.ServiceReference.XmlToJsonRequest inValue = new ConsoleApp.ServiceReference.XmlToJsonRequest();
            inValue.Body = new ConsoleApp.ServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((ConsoleApp.ServiceReference.WebServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
