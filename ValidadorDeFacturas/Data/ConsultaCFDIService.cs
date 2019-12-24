﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sat.Cfdi.Negocio.ConsultaCfdi.Servicio
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Acuse", Namespace = "http://schemas.datacontract.org/2004/07/Sat.Cfdi.Negocio.ConsultaCfdi.Servicio")]
    public partial class Acuse : object
    {

        private string CodigoEstatusField;

        private string EsCancelableField;

        private string EstadoField;

        private string EstatusCancelacionField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoEstatus
        {
            get
            {
                return this.CodigoEstatusField;
            }
            set
            {
                this.CodigoEstatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EsCancelable
        {
            get
            {
                return this.EsCancelableField;
            }
            set
            {
                this.EsCancelableField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstatusCancelacion
        {
            get
            {
                return this.EstatusCancelacionField;
            }
            set
            {
                this.EstatusCancelacionField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IConsultaCFDIService")]
public interface IConsultaCFDIService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction = "http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
    System.Threading.Tasks.Task<Sat.Cfdi.Negocio.ConsultaCfdi.Servicio.Acuse> ConsultaAsync(string expresionImpresa);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
public interface IConsultaCFDIServiceChannel : IConsultaCFDIService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
public partial class ConsultaCFDIServiceClient : System.ServiceModel.ClientBase<IConsultaCFDIService>, IConsultaCFDIService
{

    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

    public ConsultaCFDIServiceClient() :
            base(ConsultaCFDIServiceClient.GetDefaultBinding(), ConsultaCFDIServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration) :
            base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), ConsultaCFDIServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
            base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public ConsultaCFDIServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
            base(ConsultaCFDIServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }

    public ConsultaCFDIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public System.Threading.Tasks.Task<Sat.Cfdi.Negocio.ConsultaCfdi.Servicio.Acuse> ConsultaAsync(string expresionImpresa)
    {
        return base.Channel.ConsultaAsync(expresionImpresa);
    }

    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }

    public virtual System.Threading.Tasks.Task CloseAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
    }

    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }

    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService))
        {
            return new System.ServiceModel.EndpointAddress("https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }

    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return ConsultaCFDIServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService);
    }

    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return ConsultaCFDIServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IConsultaCFDIService);
    }

    public enum EndpointConfiguration
    {

        BasicHttpBinding_IConsultaCFDIService,
    }
}
