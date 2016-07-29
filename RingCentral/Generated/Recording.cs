
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Recording : Model
    {
        internal Recording(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "recording";
            }
        }
        public Content Content(ID _id)
        {
            return new Content(this, _id);
        }
        public Content Content()
        {
            return new Content(this, null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public int? id { get; set; }
            public string contentUri { get; set; }
            public string contentType { get; set; }
            public int? duration { get; set; }
        }
    }
}
