﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePhoto
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Photo", Namespace="http://schemas.datacontract.org/2004/07/WCFPhotos", IsReference=true)]
    public partial class Photo : object
    {
        
        private string DateField;
        
        private string EventField;
        
        private int IdField;
        
        private string LocationField;
        
        private string PhotoUrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoUrl
        {
            get
            {
                return this.PhotoUrlField;
            }
            set
            {
                this.PhotoUrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WCFPhotos", IsReference=true)]
    public partial class Person : object
    {
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePhoto.IPhotoService")]
    public interface IPhotoService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Add", ReplyAction="http://tempuri.org/IPhotoService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(ServiceReferencePhoto.Photo photo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Update", ReplyAction="http://tempuri.org/IPhotoService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(ServiceReferencePhoto.Photo updateModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Delete", ReplyAction="http://tempuri.org/IPhotoService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetById", ReplyAction="http://tempuri.org/IPhotoService/GetByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePhoto.Photo> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetAll", ReplyAction="http://tempuri.org/IPhotoService/GetAllResponse")]
        System.Threading.Tasks.Task<ServiceReferencePhoto.Photo[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/TagPerson", ReplyAction="http://tempuri.org/IPhotoService/TagPersonResponse")]
        System.Threading.Tasks.Task TagPersonAsync(int photoId, ServiceReferencePhoto.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public interface IPhotoServiceChannel : ServiceReferencePhoto.IPhotoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    public partial class PhotoServiceClient : System.ServiceModel.ClientBase<ServiceReferencePhoto.IPhotoService>, ServiceReferencePhoto.IPhotoService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PhotoServiceClient() : 
                base(PhotoServiceClient.GetDefaultBinding(), PhotoServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPhotoService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PhotoServiceClient.GetBindingForEndpoint(endpointConfiguration), PhotoServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PhotoServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PhotoServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PhotoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddAsync(ServiceReferencePhoto.Photo photo)
        {
            return base.Channel.AddAsync(photo);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(ServiceReferencePhoto.Photo updateModel)
        {
            return base.Channel.UpdateAsync(updateModel);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePhoto.Photo> GetByIdAsync(int id)
        {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePhoto.Photo[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task TagPersonAsync(int photoId, ServiceReferencePhoto.Person person)
        {
            return base.Channel.TagPersonAsync(photoId, person);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPhotoService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/Photos");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PhotoServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPhotoService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PhotoServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPhotoService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPhotoService,
        }
    }
}
