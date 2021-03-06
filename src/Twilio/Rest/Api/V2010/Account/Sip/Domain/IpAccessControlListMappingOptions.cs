/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain 
{

    /// <summary>
    /// Fetch an IpAccessControlListMapping resource.
    /// </summary>
    public class FetchIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that uniquely identifies the SIP Domain
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies the resource to fetch.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> A string that uniquely identifies the SIP Domain </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to fetch. </param>
        public FetchIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Create a new IpAccessControlListMapping resource.
    /// </summary>
    public class CreateIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that uniquely identifies the SIP Domain
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The unique id of the IP access control list to map to the SIP domain
        /// </summary>
        public string IpAccessControlListSid { get; }

        /// <summary>
        /// Construct a new CreateIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> A string that uniquely identifies the SIP Domain </param>
        /// <param name="ipAccessControlListSid"> The unique id of the IP access control list to map to the SIP domain </param>
        public CreateIpAccessControlListMappingOptions(string pathDomainSid, string ipAccessControlListSid)
        {
            PathDomainSid = pathDomainSid;
            IpAccessControlListSid = ipAccessControlListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IpAccessControlListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAccessControlListSid", IpAccessControlListSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of IpAccessControlListMapping resources.
    /// </summary>
    public class ReadIpAccessControlListMappingOptions : ReadOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that uniquely identifies the SIP Domain
        /// </summary>
        public string PathDomainSid { get; }

        /// <summary>
        /// Construct a new ReadIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> A string that uniquely identifies the SIP Domain </param>
        public ReadIpAccessControlListMappingOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete an IpAccessControlListMapping resource.
    /// </summary>
    public class DeleteIpAccessControlListMappingOptions : IOptions<IpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that uniquely identifies the SIP Domain
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies the resource to delete.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> A string that uniquely identifies the SIP Domain </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        public DeleteIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}