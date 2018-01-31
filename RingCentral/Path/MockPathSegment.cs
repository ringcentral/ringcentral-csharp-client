namespace RingCentral
{
    public class MockPathSegment : PathSegment
    {
        public MockPathSegment(RestClient rc) : base(null)
        {
            this.rc = rc;
        }

        protected override string Segment
        {
            get
            {
                return "";
            }
        }

        public override string Endpoint(bool withId)
        {
            return Segment;
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