using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TemplatesPath : PathSegment
    {
        internal TemplatesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "templates";
            }
        }
        //
        public Task<UserTemplates> List()
        {
            return RC.Get<UserTemplates>(Endpoint(false), null);
        }
        //
        public Task<UserTemplates> List(object parameters)
        {
            return RC.Get<UserTemplates>(Endpoint(false), parameters);
        }
        //
        public Task<UserTemplates> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            //
            public string @type { get; set; }
            //
            public string @page { get; set; }
            //
            public string @perPage { get; set; }
        }
        //
        public Task<TemplateInfo> Get()
        {
            return RC.Get<TemplateInfo>(Endpoint(true), null);
        }
    }
}
