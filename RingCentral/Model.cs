using Flurl;

namespace RingCentral
{
    public abstract partial class Model
    {
        public string _id;
        protected abstract string PathSegment { get; }
        protected Model parent;

        protected Model(Model parent, string _id = null)
        {
            this.parent = parent;
            this._id = _id;
        }

        public virtual string Endpoint(bool withId = true)
        {
            var url = parent.Endpoint().AppendPathSegment(PathSegment);
            if (withId && _id != null)
            {
                url = url.AppendPathSegment(_id);
            }
            return url.Path;
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