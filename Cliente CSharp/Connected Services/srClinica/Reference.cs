﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_CSharp.srClinica {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srClinica.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarHo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarHo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarHo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarHoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarHo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarHo(string idHo, string descricion, string director, string direccion, string contacto, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarHo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarHoAsync(string idHo, string descricion, string director, string direccion, string contacto, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarHi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarHi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarHi", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarHiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarHi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarHi(string idH, string detalle, string nroExpediente, string Antecedente, string peso, string talla, string motivoConsulta, string sintomas, string adicciones, string procedimiento, string idP, string idD, string idU, string idHo, string fechaRegistro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarHi", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarHiAsync(string idH, string detalle, string nroExpediente, string Antecedente, string peso, string talla, string motivoConsulta, string sintomas, string adicciones, string procedimiento, string idP, string idD, string idU, string idHo, string fechaRegistro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Cliente_CSharp.srClinica.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Cliente_CSharp.srClinica.WebService1Soap>, Cliente_CSharp.srClinica.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono) {
            return base.Channel.Agregar(idP, nombre, apellidos, fechaNacimiento, sexo, estadoCivil, ocupacion, direccion, telefono);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string idP, string nombre, string apellidos, string fechaNacimiento, string sexo, string estadoCivil, string ocupacion, string direccion, string telefono) {
            return base.Channel.AgregarAsync(idP, nombre, apellidos, fechaNacimiento, sexo, estadoCivil, ocupacion, direccion, telefono);
        }
        
        public System.Data.DataSet ListarHo() {
            return base.Channel.ListarHo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarHoAsync() {
            return base.Channel.ListarHoAsync();
        }
        
        public string[] AgregarHo(string idHo, string descricion, string director, string direccion, string contacto, string correo) {
            return base.Channel.AgregarHo(idHo, descricion, director, direccion, contacto, correo);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarHoAsync(string idHo, string descricion, string director, string direccion, string contacto, string correo) {
            return base.Channel.AgregarHoAsync(idHo, descricion, director, direccion, contacto, correo);
        }
        
        public System.Data.DataSet ListarHi() {
            return base.Channel.ListarHi();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarHiAsync() {
            return base.Channel.ListarHiAsync();
        }
        
        public string[] AgregarHi(string idH, string detalle, string nroExpediente, string Antecedente, string peso, string talla, string motivoConsulta, string sintomas, string adicciones, string procedimiento, string idP, string idD, string idU, string idHo, string fechaRegistro) {
            return base.Channel.AgregarHi(idH, detalle, nroExpediente, Antecedente, peso, talla, motivoConsulta, sintomas, adicciones, procedimiento, idP, idD, idU, idHo, fechaRegistro);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarHiAsync(string idH, string detalle, string nroExpediente, string Antecedente, string peso, string talla, string motivoConsulta, string sintomas, string adicciones, string procedimiento, string idP, string idD, string idU, string idHo, string fechaRegistro) {
            return base.Channel.AgregarHiAsync(idH, detalle, nroExpediente, Antecedente, peso, talla, motivoConsulta, sintomas, adicciones, procedimiento, idP, idD, idU, idHo, fechaRegistro);
        }
    }
}
