/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// AuthRegistrationsCredentialListMappingResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeRegistrations 
{

    public class AuthRegistrationsCredentialListMappingResource : Resource 
    {
        private static Request BuildCreateRequest(CreateAuthRegistrationsCredentialListMappingOptions options, 
                                                  ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Registrations/CredentialListMappings.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="options"> Create AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static AuthRegistrationsCredentialListMappingResource Create(CreateAuthRegistrationsCredentialListMappingOptions options, 
                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="options"> Create AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> CreateAsync(CreateAuthRegistrationsCredentialListMappingOptions options, 
                                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="credentialListSid"> A string that uniquely identifies credential list resource </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static AuthRegistrationsCredentialListMappingResource Create(string pathDomainSid, 
                                                                            string credentialListSid, 
                                                                            string pathAccountSid = null, 
                                                                            ITwilioRestClient client = null)
        {
            var options = new CreateAuthRegistrationsCredentialListMappingOptions(pathDomainSid, credentialListSid){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="credentialListSid"> A string that uniquely identifies credential list resource </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> CreateAsync(string pathDomainSid, 
                                                                                                                    string credentialListSid, 
                                                                                                                    string pathAccountSid = null, 
                                                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateAuthRegistrationsCredentialListMappingOptions(pathDomainSid, credentialListSid){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAuthRegistrationsCredentialListMappingOptions options, 
                                                ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Registrations/CredentialListMappings.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="options"> Read AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static ResourceSet<AuthRegistrationsCredentialListMappingResource> Read(ReadAuthRegistrationsCredentialListMappingOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthRegistrationsCredentialListMappingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="options"> Read AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AuthRegistrationsCredentialListMappingResource>> ReadAsync(ReadAuthRegistrationsCredentialListMappingOptions options, 
                                                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthRegistrationsCredentialListMappingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static ResourceSet<AuthRegistrationsCredentialListMappingResource> Read(string pathDomainSid, 
                                                                                       string pathAccountSid = null, 
                                                                                       int? pageSize = null, 
                                                                                       long? limit = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadAuthRegistrationsCredentialListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AuthRegistrationsCredentialListMappingResource>> ReadAsync(string pathDomainSid, 
                                                                                                                               string pathAccountSid = null, 
                                                                                                                               int? pageSize = null, 
                                                                                                                               long? limit = null, 
                                                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadAuthRegistrationsCredentialListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AuthRegistrationsCredentialListMappingResource> GetPage(string targetUrl, 
                                                                                   ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AuthRegistrationsCredentialListMappingResource> NextPage(Page<AuthRegistrationsCredentialListMappingResource> page, 
                                                                                    ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AuthRegistrationsCredentialListMappingResource> PreviousPage(Page<AuthRegistrationsCredentialListMappingResource> page, 
                                                                                        ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AuthRegistrationsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        private static Request BuildFetchRequest(FetchAuthRegistrationsCredentialListMappingOptions options, 
                                                 ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Registrations/CredentialListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="options"> Fetch AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static AuthRegistrationsCredentialListMappingResource Fetch(FetchAuthRegistrationsCredentialListMappingOptions options, 
                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="options"> Fetch AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> FetchAsync(FetchAuthRegistrationsCredentialListMappingOptions options, 
                                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Fetch by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static AuthRegistrationsCredentialListMappingResource Fetch(string pathDomainSid, 
                                                                           string pathSid, 
                                                                           string pathAccountSid = null, 
                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Fetch by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthRegistrationsCredentialListMappingResource> FetchAsync(string pathDomainSid, 
                                                                                                                   string pathSid, 
                                                                                                                   string pathAccountSid = null, 
                                                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAuthRegistrationsCredentialListMappingOptions options, 
                                                  ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Registrations/CredentialListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="options"> Delete AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static bool Delete(DeleteAuthRegistrationsCredentialListMappingOptions options, 
                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="options"> Delete AuthRegistrationsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAuthRegistrationsCredentialListMappingOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Delete by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static bool Delete(string pathDomainSid, 
                                  string pathSid, 
                                  string pathAccountSid = null, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Delete by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthRegistrationsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, 
                                                                          string pathSid, 
                                                                          string pathAccountSid = null, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteAuthRegistrationsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AuthRegistrationsCredentialListMappingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthRegistrationsCredentialListMappingResource object represented by the provided JSON </returns> 
        public static AuthRegistrationsCredentialListMappingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AuthRegistrationsCredentialListMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        private AuthRegistrationsCredentialListMappingResource()
        {

        }
    }

}