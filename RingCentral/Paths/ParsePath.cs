using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ParsePath : PathSegment
    {
        internal ParsePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "parse";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns one or more parsed and/or formatted phone numbers that are passed as a string.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<ParsePhoneNumberResponse> Post()
        {
            return RC.Post<ParsePhoneNumberResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns one or more parsed and/or formatted phone numbers that are passed as a string.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<ParsePhoneNumberResponse> Post(object parameters)
        {
            return RC.Post<ParsePhoneNumberResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns one or more parsed and/or formatted phone numbers that are passed as a string.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<ParsePhoneNumberResponse> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user's home country or brand country, if the user is undefined
            public string @homeCountry { get; set; }
            // The default value is 'False'. If 'True', the numbers that are closer to the home country are given higher priority
            public bool? @nationalAsPriority { get; set; }
        }
    }
}
