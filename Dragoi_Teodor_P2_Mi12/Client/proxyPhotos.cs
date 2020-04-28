﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Photo", Namespace="http://schemas.datacontract.org/2004/07/WCFPhotos", IsReference=true)]
    public partial class Photo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DateField;
        
        private string EventField;
        
        private int IdField;
        
        private string LocationField;
        
        private string PhotoUrlField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
    
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField1;
        
        private string FirstNameField1;
        
        private int IdField1;
        
        private string LastNameField1;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData1
        {
            get
            {
                return this.extensionDataField1;
            }
            set
            {
                this.extensionDataField1 = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName1
        {
            get
            {
                return this.FirstNameField1;
            }
            set
            {
                this.FirstNameField1 = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id1
        {
            get
            {
                return this.IdField1;
            }
            set
            {
                this.IdField1 = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName1
        {
            get
            {
                return this.LastNameField1;
            }
            set
            {
                this.LastNameField1 = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPhotoService")]
public interface IPhotoService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Add", ReplyAction="http://tempuri.org/IPhotoService/AddResponse")]
    void Add(WCFPhotos.Photo photo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Add", ReplyAction="http://tempuri.org/IPhotoService/AddResponse")]
    System.Threading.Tasks.Task AddAsync(WCFPhotos.Photo photo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Update", ReplyAction="http://tempuri.org/IPhotoService/UpdateResponse")]
    void Update(WCFPhotos.Photo updateModel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Update", ReplyAction="http://tempuri.org/IPhotoService/UpdateResponse")]
    System.Threading.Tasks.Task UpdateAsync(WCFPhotos.Photo updateModel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Delete", ReplyAction="http://tempuri.org/IPhotoService/DeleteResponse")]
    void Delete(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/Delete", ReplyAction="http://tempuri.org/IPhotoService/DeleteResponse")]
    System.Threading.Tasks.Task DeleteAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetById", ReplyAction="http://tempuri.org/IPhotoService/GetByIdResponse")]
    WCFPhotos.Photo GetById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetById", ReplyAction="http://tempuri.org/IPhotoService/GetByIdResponse")]
    System.Threading.Tasks.Task<WCFPhotos.Photo> GetByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetAll", ReplyAction="http://tempuri.org/IPhotoService/GetAllResponse")]
    WCFPhotos.Photo[] GetAll();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/GetAll", ReplyAction="http://tempuri.org/IPhotoService/GetAllResponse")]
    System.Threading.Tasks.Task<WCFPhotos.Photo[]> GetAllAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/TagPerson", ReplyAction="http://tempuri.org/IPhotoService/TagPersonResponse")]
    void TagPerson(int photoId, WCFPhotos.Person person);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhotoService/TagPerson", ReplyAction="http://tempuri.org/IPhotoService/TagPersonResponse")]
    System.Threading.Tasks.Task TagPersonAsync(int photoId, WCFPhotos.Person person);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPhotoServiceChannel : IPhotoService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PhotoServiceClient : System.ServiceModel.ClientBase<IPhotoService>, IPhotoService
{
    
    public PhotoServiceClient()
    {
    }
    
    public PhotoServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PhotoServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PhotoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PhotoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void Add(WCFPhotos.Photo photo)
    {
        base.Channel.Add(photo);
    }
    
    public System.Threading.Tasks.Task AddAsync(WCFPhotos.Photo photo)
    {
        return base.Channel.AddAsync(photo);
    }
    
    public void Update(WCFPhotos.Photo updateModel)
    {
        base.Channel.Update(updateModel);
    }
    
    public System.Threading.Tasks.Task UpdateAsync(WCFPhotos.Photo updateModel)
    {
        return base.Channel.UpdateAsync(updateModel);
    }
    
    public void Delete(int id)
    {
        base.Channel.Delete(id);
    }
    
    public System.Threading.Tasks.Task DeleteAsync(int id)
    {
        return base.Channel.DeleteAsync(id);
    }
    
    public WCFPhotos.Photo GetById(int id)
    {
        return base.Channel.GetById(id);
    }
    
    public System.Threading.Tasks.Task<WCFPhotos.Photo> GetByIdAsync(int id)
    {
        return base.Channel.GetByIdAsync(id);
    }
    
    public WCFPhotos.Photo[] GetAll()
    {
        return base.Channel.GetAll();
    }
    
    public System.Threading.Tasks.Task<WCFPhotos.Photo[]> GetAllAsync()
    {
        return base.Channel.GetAllAsync();
    }
    
    public void TagPerson(int photoId, WCFPhotos.Person person)
    {
        base.Channel.TagPerson(photoId, person);
    }
    
    public System.Threading.Tasks.Task TagPersonAsync(int photoId, WCFPhotos.Person person)
    {
        return base.Channel.TagPersonAsync(photoId, person);
    }
}
