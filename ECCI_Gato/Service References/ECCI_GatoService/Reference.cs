﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECCI_Gato.ECCI_GatoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_Gato", ConfigurationName="ECCI_GatoService.ECCI_GatoPort")]
    public interface ECCI_GatoPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#terminado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string terminado();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#terminado", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> terminadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#juegoTerminado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        string juegoTerminado();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#juegoTerminado", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        System.Threading.Tasks.Task<string> juegoTerminadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#tableroActual", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string tableroActual();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#tableroActual", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> tableroActualAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#mover", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void mover(string @return);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#mover", ReplyAction="*")]
        System.Threading.Tasks.Task moverAsync(string @return);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#insertarJugadorBD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void insertarJugadorBD(string @return);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#insertarJugadorBD", ReplyAction="*")]
        System.Threading.Tasks.Task insertarJugadorBDAsync(string @return);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#diezMejores", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string diezMejores();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#diezMejores", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> diezMejoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#jugadorActual", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string jugadorActual();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Gato#Gato#jugadorActual", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> jugadorActualAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_GatoPortChannel : ECCI_Gato.ECCI_GatoService.ECCI_GatoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_GatoPortClient : System.ServiceModel.ClientBase<ECCI_Gato.ECCI_GatoService.ECCI_GatoPort>, ECCI_Gato.ECCI_GatoService.ECCI_GatoPort {
        
        public ECCI_GatoPortClient() {
        }
        
        public ECCI_GatoPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_GatoPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_GatoPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_GatoPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string terminado() {
            return base.Channel.terminado();
        }
        
        public System.Threading.Tasks.Task<string> terminadoAsync() {
            return base.Channel.terminadoAsync();
        }
        
        public string juegoTerminado() {
            return base.Channel.juegoTerminado();
        }
        
        public System.Threading.Tasks.Task<string> juegoTerminadoAsync() {
            return base.Channel.juegoTerminadoAsync();
        }
        
        public string tableroActual() {
            return base.Channel.tableroActual();
        }
        
        public System.Threading.Tasks.Task<string> tableroActualAsync() {
            return base.Channel.tableroActualAsync();
        }
        
        public void mover(string @return) {
            base.Channel.mover(@return);
        }
        
        public System.Threading.Tasks.Task moverAsync(string @return) {
            return base.Channel.moverAsync(@return);
        }
        
        public void insertarJugadorBD(string @return) {
            base.Channel.insertarJugadorBD(@return);
        }
        
        public System.Threading.Tasks.Task insertarJugadorBDAsync(string @return) {
            return base.Channel.insertarJugadorBDAsync(@return);
        }
        
        public string diezMejores() {
            return base.Channel.diezMejores();
        }
        
        public System.Threading.Tasks.Task<string> diezMejoresAsync() {
            return base.Channel.diezMejoresAsync();
        }
        
        public string jugadorActual() {
            return base.Channel.jugadorActual();
        }
        
        public System.Threading.Tasks.Task<string> jugadorActualAsync() {
            return base.Channel.jugadorActualAsync();
        }
    }
}
