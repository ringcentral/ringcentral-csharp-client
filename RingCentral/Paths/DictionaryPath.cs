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
        public UserRolePath UserRole(string _id)
        {
            return new UserRolePath(this, _id);
        }
        public UserRolePath UserRole()
        {
            return new UserRolePath(this);
        }
        public PermissionPath Permission(string _id)
        {
            return new PermissionPath(this, _id);
        }
        public PermissionPath Permission()
        {
            return new PermissionPath(this);
        }
        public PermissionCategoryPath PermissionCategory(string _id)
        {
            return new PermissionCategoryPath(this, _id);
        }
        public PermissionCategoryPath PermissionCategory()
        {
            return new PermissionCategoryPath(this);
        }
        public GreetingPath Greeting(string _id)
        {
            return new GreetingPath(this, _id);
        }
        public GreetingPath Greeting()
        {
            return new GreetingPath(this);
        }
        public SecretQuestionPath SecretQuestion(string _id)
        {
            return new SecretQuestionPath(this, _id);
        }
        public SecretQuestionPath SecretQuestion()
        {
            return new SecretQuestionPath(this);
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
        public BrandPath Brand(string _id)
        {
            return new BrandPath(this, _id);
        }
        public ServicePlanPath ServicePlan(string _id)
        {
            return new ServicePlanPath(this, _id);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public ShippingOptionsPath ShippingOptions()
        {
            return new ShippingOptionsPath(this);
        }
        public LicenseTypesPath LicenseTypes()
        {
            return new LicenseTypesPath(this);
        }
    }
}
