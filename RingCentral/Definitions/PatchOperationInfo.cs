namespace RingCentral
{
    public partial class PatchOperationInfo
    {
        //
        public string @op { get; set; }
        //
        public string @path { get; set; }
        // corresponding 'value' of that field specified by 'path'
        public object @value { get; set; }
    }
}
