namespace RingCentral
{
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