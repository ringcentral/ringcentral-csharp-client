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

    public class ID
    {
        private int? i = null;
        private string s = null;

        public ID(int i)
        {
            this.i = i;
        }

        public ID(string s)
        {
            this.s = s;
        }

        public static implicit operator ID(int i)
        {
            return new ID(i);
        }

        public static implicit operator ID(string s)
        {
            return new ID(s);
        }

        public static implicit operator string(ID id)
        {
            return id.ToString();
        }

        public override string ToString()
        {
            return i.HasValue ? i.ToString() : s;
        }
    }
}