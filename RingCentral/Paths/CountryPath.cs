using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CountryPath : PathSegment
    {
        internal CountryPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "country";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the countries available for calling.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetCountryListResponse> List()
        {
            return RC.Get<GetCountryListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the countries available for calling.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetCountryListResponse> List(object parameters)
        {
            return RC.Get<GetCountryListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the countries available for calling.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetCountryListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Specifies whether login with the phone numbers of this country is enabled or not
            public bool? @loginAllowed { get; set; }
            // Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any)
            public bool? @signupAllowed { get; set; }
            // Specifies if RingCentral sells phone numbers of this country
            public bool? @numberSelling { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
            // Specifies if free phone line for softphone is available for a country or not
            public bool? @freeSoftphoneLine { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns the information on the required country.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetCountryInfoDictionaryResponse> Get()
        {
            return RC.Get<GetCountryInfoDictionaryResponse>(Endpoint(true), null);
        }
    }
}
