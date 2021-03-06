﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CalculatorServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceClient.IServiceCalculate", CallbackContract=typeof(Client.CalculatorServiceClient.IServiceCalculateCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IServiceCalculate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculate/SumByInputValue", ReplyAction="http://tempuri.org/IServiceCalculate/SumByInputValueResponse")]
        void SumByInputValue(double dbeOneParameter, double dbeTwoParameter, string strSymbol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculate/SumByInputValue", ReplyAction="http://tempuri.org/IServiceCalculate/SumByInputValueResponse")]
        System.Threading.Tasks.Task SumByInputValueAsync(double dbeOneParameter, double dbeTwoParameter, string strSymbol);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCalculate/SumByInputValueOneway")]
        void SumByInputValueOneway(double dbeOneParameter, double dbeTwoParameter, string strSymbol);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCalculate/SumByInputValueOneway")]
        System.Threading.Tasks.Task SumByInputValueOnewayAsync(double dbeOneParameter, double dbeTwoParameter, string strSymbol);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCalculateCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCalculate/DisplayResultByOption", ReplyAction="http://tempuri.org/IServiceCalculate/DisplayResultByOptionResponse")]
        void DisplayResultByOption(string strSymbol, double dbeSumValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceCalculate/DisPlayResultByOptionOneWay")]
        void DisPlayResultByOptionOneWay(string strSymbol, double dbeSumValue);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCalculateChannel : Client.CalculatorServiceClient.IServiceCalculate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCalculateClient : System.ServiceModel.DuplexClientBase<Client.CalculatorServiceClient.IServiceCalculate>, Client.CalculatorServiceClient.IServiceCalculate {
        
        public ServiceCalculateClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceCalculateClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceCalculateClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculateClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCalculateClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SumByInputValue(double dbeOneParameter, double dbeTwoParameter, string strSymbol) {
            base.Channel.SumByInputValue(dbeOneParameter, dbeTwoParameter, strSymbol);
        }
        
        public System.Threading.Tasks.Task SumByInputValueAsync(double dbeOneParameter, double dbeTwoParameter, string strSymbol) {
            return base.Channel.SumByInputValueAsync(dbeOneParameter, dbeTwoParameter, strSymbol);
        }
        
        public void SumByInputValueOneway(double dbeOneParameter, double dbeTwoParameter, string strSymbol) {
            base.Channel.SumByInputValueOneway(dbeOneParameter, dbeTwoParameter, strSymbol);
        }
        
        public System.Threading.Tasks.Task SumByInputValueOnewayAsync(double dbeOneParameter, double dbeTwoParameter, string strSymbol) {
            return base.Channel.SumByInputValueOnewayAsync(dbeOneParameter, dbeTwoParameter, strSymbol);
        }
    }
}
