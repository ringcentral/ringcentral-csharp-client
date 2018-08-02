namespace RingCentral
{
    public partial class PatchOperation
    {
        //
        public string @op { get; set; }
        //
        public string @path { get; set; }
        // corresponding 'value' of that field specified by 'path'
        public object @value { get; set; }
    }
}
