﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comparer.ComparerWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ComparerWebService.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Comparer.ComparerWebService.HelloWorldResponse HelloWorld(Comparer.ComparerWebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Comparer.ComparerWebService.HelloWorldResponse> HelloWorldAsync(Comparer.ComparerWebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/test", ReplyAction="*")]
        void test();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/test", ReplyAction="*")]
        System.Threading.Tasks.Task testAsync();
        
        // CODEGEN: Generating message contract since element name ProductListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductList", ReplyAction="*")]
        Comparer.ComparerWebService.ProductListResponse ProductList(Comparer.ComparerWebService.ProductListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductList", ReplyAction="*")]
        System.Threading.Tasks.Task<Comparer.ComparerWebService.ProductListResponse> ProductListAsync(Comparer.ComparerWebService.ProductListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Comparer.ComparerWebService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Comparer.ComparerWebService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Comparer.ComparerWebService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Comparer.ComparerWebService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProductListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProductList", Namespace="http://tempuri.org/", Order=0)]
        public Comparer.ComparerWebService.ProductListRequestBody Body;
        
        public ProductListRequest() {
        }
        
        public ProductListRequest(Comparer.ComparerWebService.ProductListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ProductListRequestBody {
        
        public ProductListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProductListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProductListResponse", Namespace="http://tempuri.org/", Order=0)]
        public Comparer.ComparerWebService.ProductListResponseBody Body;
        
        public ProductListResponse() {
        }
        
        public ProductListResponse(Comparer.ComparerWebService.ProductListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ProductListResult;
        
        public ProductListResponseBody() {
        }
        
        public ProductListResponseBody(string ProductListResult) {
            this.ProductListResult = ProductListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : Comparer.ComparerWebService.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<Comparer.ComparerWebService.WebServiceSoap>, Comparer.ComparerWebService.WebServiceSoap {
        
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Comparer.ComparerWebService.HelloWorldResponse Comparer.ComparerWebService.WebServiceSoap.HelloWorld(Comparer.ComparerWebService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Comparer.ComparerWebService.HelloWorldRequest inValue = new Comparer.ComparerWebService.HelloWorldRequest();
            inValue.Body = new Comparer.ComparerWebService.HelloWorldRequestBody();
            Comparer.ComparerWebService.HelloWorldResponse retVal = ((Comparer.ComparerWebService.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Comparer.ComparerWebService.HelloWorldResponse> Comparer.ComparerWebService.WebServiceSoap.HelloWorldAsync(Comparer.ComparerWebService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Comparer.ComparerWebService.HelloWorldResponse> HelloWorldAsync() {
            Comparer.ComparerWebService.HelloWorldRequest inValue = new Comparer.ComparerWebService.HelloWorldRequest();
            inValue.Body = new Comparer.ComparerWebService.HelloWorldRequestBody();
            return ((Comparer.ComparerWebService.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public void test() {
            base.Channel.test();
        }
        
        public System.Threading.Tasks.Task testAsync() {
            return base.Channel.testAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Comparer.ComparerWebService.ProductListResponse Comparer.ComparerWebService.WebServiceSoap.ProductList(Comparer.ComparerWebService.ProductListRequest request) {
            return base.Channel.ProductList(request);
        }
        
        public string ProductList() {
            Comparer.ComparerWebService.ProductListRequest inValue = new Comparer.ComparerWebService.ProductListRequest();
            inValue.Body = new Comparer.ComparerWebService.ProductListRequestBody();
            Comparer.ComparerWebService.ProductListResponse retVal = ((Comparer.ComparerWebService.WebServiceSoap)(this)).ProductList(inValue);
            return retVal.Body.ProductListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Comparer.ComparerWebService.ProductListResponse> Comparer.ComparerWebService.WebServiceSoap.ProductListAsync(Comparer.ComparerWebService.ProductListRequest request) {
            return base.Channel.ProductListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Comparer.ComparerWebService.ProductListResponse> ProductListAsync() {
            Comparer.ComparerWebService.ProductListRequest inValue = new Comparer.ComparerWebService.ProductListRequest();
            inValue.Body = new Comparer.ComparerWebService.ProductListRequestBody();
            return ((Comparer.ComparerWebService.WebServiceSoap)(this)).ProductListAsync(inValue);
        }
    }
}
