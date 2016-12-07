using Flurl;

namespace RingCentral
{
    public abstract class PathSegment
    {
        public string _id;
        protected abstract string Segment { get; }
        protected PathSegment parent;

        protected PathSegment(PathSegment parent, string _id = null)
        {
            this.parent = parent;
            this._id = _id;
        }

        public virtual string Endpoint(bool withId = true)
        {
            var url = parent.Endpoint().AppendPathSegment(Segment);
            if (withId && _id != null)
            {
                url = url.AppendPathSegment(_id);
            }
            return (url.Path.StartsWith("/") ? "" : "/") + url.Path;
        }

        public string Url(bool withId = true)
        {
            return RC.server.AppendPathSegment(Endpoint(withId));
        }

        protected virtual RestClient RC
        {
            get
            {
                return parent.RC;
            }
        }
    }
}