
namespace RingCentral
{
    public partial class Dictionary : Model
    {
        internal Dictionary(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }
        public Country Country(ID _id)
        {
            return new Country(this, _id);
        }
        public Country Country()
        {
            return new Country(this, null);
        }
        public Language Language(ID _id)
        {
            return new Language(this, _id);
        }
        public Language Language()
        {
            return new Language(this, null);
        }
        public Location Location()
        {
            return new Location(this);
        }
        public State State(ID _id)
        {
            return new State(this, _id);
        }
        public State State()
        {
            return new State(this, null);
        }
        public Timezone Timezone(ID _id)
        {
            return new Timezone(this, _id);
        }
        public Timezone Timezone()
        {
            return new Timezone(this, null);
        }
    }
}
