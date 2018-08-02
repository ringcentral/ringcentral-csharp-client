using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DictionaryPath : PathSegment
    {
        internal DictionaryPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "dictionary";
            }
        }
        public FaxCoverPagePath FaxCoverPage()
        {
            return new FaxCoverPagePath(this);
        }
        public GreetingPath Greeting(string _id)
        {
            return new GreetingPath(this, _id);
        }
        public GreetingPath Greeting()
        {
            return new GreetingPath(this);
        }
        public LanguagePath Language(string _id)
        {
            return new LanguagePath(this, _id);
        }
        public LanguagePath Language()
        {
            return new LanguagePath(this);
        }
        public CountryPath Country(string _id)
        {
            return new CountryPath(this, _id);
        }
        public CountryPath Country()
        {
            return new CountryPath(this);
        }
        public LocationPath Location()
        {
            return new LocationPath(this);
        }
        public StatePath State(string _id)
        {
            return new StatePath(this, _id);
        }
        public StatePath State()
        {
            return new StatePath(this);
        }
        public TimezonePath Timezone(string _id)
        {
            return new TimezonePath(this, _id);
        }
        public TimezonePath Timezone()
        {
            return new TimezonePath(this);
        }
        public LicenseTypesPath LicenseTypes()
        {
            return new LicenseTypesPath(this);
        }
    }
}
