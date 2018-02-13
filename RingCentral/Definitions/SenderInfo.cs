namespace RingCentral
{
    public partial class SenderInfo
    {
        // Phone number in E.164 (with '+' sign) format
        public string @phoneNumber { get; set; }
        // Extension number
        public string @extensionNumber { get; set; }
        // Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        public string @location { get; set; }
        // Symbolic name associated with a caller/callee. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
        public string @name { get; set; }
    }
}
