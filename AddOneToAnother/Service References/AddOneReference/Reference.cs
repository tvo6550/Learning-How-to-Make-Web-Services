﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddOneToAnother.AddOneReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AddOneReference.AddOneService")]
    public interface AddOneService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddOneService/addOne", ReplyAction="http://tempuri.org/AddOneService/addOneResponse")]
        int addOne(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddOneService/addOne", ReplyAction="http://tempuri.org/AddOneService/addOneResponse")]
        System.Threading.Tasks.Task<int> addOneAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AddOneServiceChannel : AddOneToAnother.AddOneReference.AddOneService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddOneServiceClient : System.ServiceModel.ClientBase<AddOneToAnother.AddOneReference.AddOneService>, AddOneToAnother.AddOneReference.AddOneService {
        
        public AddOneServiceClient() {
        }
        
        public AddOneServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddOneServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddOneServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddOneServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int addOne(int value) {
            return base.Channel.addOne(value);
        }
        
        public System.Threading.Tasks.Task<int> addOneAsync(int value) {
            return base.Channel.addOneAsync(value);
        }
    }
}
