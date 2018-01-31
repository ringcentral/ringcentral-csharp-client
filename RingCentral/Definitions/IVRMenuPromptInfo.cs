namespace RingCentral
{
    public partial class IVRMenuPromptInfo
    {
        // Prompt mode: custom media or text = ['Audio', 'TextToSpeech']
        public string @mode { get; set; }
        // For 'Audio' mode only. Prompt media reference
        public PromptLanguageInfo @audio { get; set; }
        // For 'TextToSpeech' mode only. Prompt text
        public string @text { get; set; }
        // For 'TextToSpeech' mode only. Prompt language metadata
        public AudioPromptInfo @language { get; set; }
    }
}
