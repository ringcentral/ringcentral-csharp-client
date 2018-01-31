namespace RingCentral
{
    public partial class DictionaryGreetingList
    {
        // Canonical URI of greetings list resource
        public string @uri { get; set; }
        // List of greetings
        public DictionaryGreetingInfo[] @records { get; set; }
    }
}
