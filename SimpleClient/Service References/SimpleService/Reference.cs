﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleClient.SimpleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleService.ISimpleService")]
    public interface ISimpleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/IncrementNumber", ReplyAction="http://tempuri.org/ISimpleService/IncrementNumberResponse")]
        int IncrementNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/IncrementNumber", ReplyAction="http://tempuri.org/ISimpleService/IncrementNumberResponse")]
        System.Threading.Tasks.Task<int> IncrementNumberAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleServiceChannel : SimpleClient.SimpleService.ISimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleServiceClient : System.ServiceModel.ClientBase<SimpleClient.SimpleService.ISimpleService>, SimpleClient.SimpleService.ISimpleService {
        
        public SimpleServiceClient() {
        }
        
        public SimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int IncrementNumber() {
            return base.Channel.IncrementNumber();
        }
        
        public System.Threading.Tasks.Task<int> IncrementNumberAsync() {
            return base.Channel.IncrementNumberAsync();
        }
    }
}
