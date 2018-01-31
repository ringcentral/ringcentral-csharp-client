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
        // <p style='font-style:italic;'>Since 1.0.14 (Release 6.6)</p><p>Returns the information about supported languages.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<LanguageList> List()
        {
            return RC.Get<LanguageList>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.14 (Release 6.6)</p><p>Returns language by its respective ID.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<LanguageInfo> Get()
        {
            return RC.Get<LanguageInfo>(Endpoint(true), null);
        }
    }
}
