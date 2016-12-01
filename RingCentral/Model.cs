using Flurl;

namespace RingCentral
{
    public abstract class Model
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

    public class MockModel : Model
    {
        public MockModel(RestClient rc) : base(null)
        {
            this.rc = rc;
        }

        protected override string PathSegment
        {
            get
            {
                return "";
            }
        }

        public override string Endpoint(bool withId)
        {
            return "";
        }

        private RestClient rc;
        protected override RestClient RC
        {
            get
            {
                return rc;
            }
        }
    }
}