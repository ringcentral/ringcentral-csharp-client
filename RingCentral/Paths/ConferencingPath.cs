using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ConferencingPath : PathSegment
    {
        internal ConferencingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "conferencing";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Returns the information on the Free Conference Calling (FCC) feature for a given extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetConferencingInfoResponse> Get()
        {
            return RC.Get<GetConferencingInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Returns the information on the Free Conference Calling (FCC) feature for a given extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetConferencingInfoResponse> Get(object parameters)
        {
            return RC.Get<GetConferencingInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Returns the information on the Free Conference Calling (FCC) feature for a given extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetConferencingInfoResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Internal identifier of a country. If not specified, the response is returned for the brand country
            public string @countryId { get; set; }
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetConferencingInfoResponse> Put()
        {
            return RC.Put<GetConferencingInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetConferencingInfoResponse> Put(object parameters)
        {
            return RC.Put<GetConferencingInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetConferencingInfoResponse> Put(UpdateConferencingInfoRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
