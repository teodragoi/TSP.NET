//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFPhotos
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference=true)]
    public partial class Photo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public string PhotoUrl { get; set; }
        [DataMember]
        public string Date { get; set; }

        public List<Person> People { get; set; }
    }
}