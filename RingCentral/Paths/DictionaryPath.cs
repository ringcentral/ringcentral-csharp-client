using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DictionaryPath : Model
    {
        internal DictionaryPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }
        public CountryPath Country(ID _id)
        {
            return new CountryPath(this, _id);
        }
        public CountryPath Country()
        {
            return new CountryPath(this);
        }
        public LanguagePath Language(ID _id)
        {
            return new LanguagePath(this, _id);
        }
        public LanguagePath Language()
        {
            return new LanguagePath(this);
        }
        public LocationPath Location()
        {
            return new LocationPath(this);
        }
        public StatePath State(ID _id)
        {
            return new StatePath(this, _id);
        }
        public StatePath State()
        {
            return new StatePath(this);
        }
        public TimezonePath Timezone(ID _id)
        {
            return new TimezonePath(this, _id);
        }
        public TimezonePath Timezone()
        {
            return new TimezonePath(this);
        }
    }
}
