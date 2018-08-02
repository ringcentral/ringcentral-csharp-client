using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LanguagePath : PathSegment
    {
        internal LanguagePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "language";
            }
        }
        // Returns the information about supported languages.
        public Task<LanguageList> List()
        {
            return RC.Get<LanguageList>(Endpoint(false), null);
        }
        // Returns language by ID.
        public Task<LanguageInfo> Get()
        {
            return RC.Get<LanguageInfo>(Endpoint(true), null);
        }
    }
}
