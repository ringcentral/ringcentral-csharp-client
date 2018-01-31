namespace RingCentral
{
    public partial class UpdateAnsweringRuleRequest
    {
        // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
        public ForwardingInfoCreateRuleRequest @forwarding { get; set; }
        //
        public string @name { get; set; }
    }
}
