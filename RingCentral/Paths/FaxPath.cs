using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FaxPath : Model
    {
        internal FaxPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "fax";
            }
        }
        public partial class PostParameters
        {
            // Recipient information. Phone number property is mandatory. Optional for resend fax request
            public CallerInfo[] @to { get; set; }
            // Fax resolution
            public string @faxResolution { get; set; }
            // The datetime to send fax at, in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If time is not specified, the fax will be send immediately
            public string @sendTime { get; set; }
            // Optional. Cover page index. If not specified, the default cover page which is configured in "Outbound Fax Settings" is attached. See also 'Available Cover Pages' table below
            public long? @coverIndex { get; set; }
            // Optional. Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
            public string @coverPageText { get; set; }
            // Internal identifier of the original fax message which needs to be resent. Mandatory for resend fax request
            public string @originalMessageId { get; set; }
        }
    }
}
