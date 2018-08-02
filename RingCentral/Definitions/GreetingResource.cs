namespace RingCentral
{
    public partial class GreetingResource
    {
        //
        public string @type { get; set; }
        // 'Default' value specifies that all greetings of that type (in all languages) are default, if at least one greeting (in any language) of the specified type is custom, then 'Custom' value is returned.
        public string @mode { get; set; }
    }
}
