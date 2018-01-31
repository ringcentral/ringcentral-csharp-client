using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CustomDataPath : PathSegment
    {
        internal CustomDataPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "custom-data";
            }
        }
        public ContentPath Content(string _id)
        {
            return new ContentPath(this, _id);
        }
        public ContentPath Content()
        {
            return new ContentPath(this);
        }
    }
}
