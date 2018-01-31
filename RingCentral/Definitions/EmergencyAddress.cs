namespace RingCentral
{
    public partial class EmergencyAddress
    {
        //  'True' if specifying of emergency address is required
        public bool? @required { get; set; }
        //  'True' if only local emergency address can be specified
        public bool? @localOnly { get; set; }
    }
}
