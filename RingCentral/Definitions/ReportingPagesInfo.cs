namespace RingCentral
{
    public partial class ReportingPagesInfo
    {
        // Name of a page. CFA application UI predefines a set of possible names and treats them as enum constants to distinguish pages by type. This is not user-visible value, as it might need localization. The maximum value is 255
        public string @name { get; set; }
        // CFA-defined filter values/page parameters
        public string @attrX { get; set; }
    }
}
