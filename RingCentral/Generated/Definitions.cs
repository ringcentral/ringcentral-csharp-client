public partial class AccountInfo
{
    // Internal identifier of an account
    public string id { get; set; }
    // Canonical URI of an account
    public string uri { get; set; }
    // Main phone number of the current account
    public string mainNumber { get; set; }
    // Operator's extension information. This extension will receive all calls and messages intended for the operator
    public ExtensionInfo @operator { get; set; }
    // Additional account identifier, developed and applied by the client
    public string partnerId { get; set; }
    // Account service information, including brand, service plan and billing plan
    public ServiceInfo serviceInfo { get; set; }
    // Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
    public string setupWizardState { get; set; }
    // Status of the current account
    public string status { get; set; }
    // Status information (reason, comment, lifetime). Returned for 'Disabled' status only
    public StatusInfo statusInfo { get; set; }
}


public partial class AccountLimits
{
    // The maximum number of free softphone digital lines per user extension
    public int? freeSoftPhoneLinesPerExtension { get; set; }
    // The maximum number of participants in RingCentral Meeting hosted by this account's user
    public int? meetingSize { get; set; }
    // The maximum number of extensions which can be included in the list of users monitored for Presence
    public int? maxMonitoredExtensionsPerUser { get; set; }
}


public partial class AddonInfo
{
    // Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
    public string id { get; set; }
    // Number of addons. For HardPhones of certain types, which are compatible with such addon identifier
    public int? count { get; set; }
}


public partial class AnsweringRuleInfo
{
    // Canonical URI to the answering rule resource
    public string uri { get; set; }
    // Internal identifier of an asnwering rule
    public string id { get; set; }
    // Type of an answering rule
    public string type { get; set; }
    // Name of an answering rule specified by user
    public string name { get; set; }
    // Specifies if an answering rule is active or inactive
    public bool? enabled { get; set; }
    // Schedule when an answering rule should be applied
    public ScheduleInfo schedule { get; set; }
    // Answering rules are applied when calling to selected number(s)
    public AnsweringRuleInfo_CalleeInfo[] calledNumbers { get; set; }
    // Answering rules are applied when calls are received from specified caller(s)
    public AnsweringRuleInfo_CallerInfo[] callers { get; set; }
    // Specifies how incoming calls are forwarded
    public string callHandlingAction { get; set; }
    // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
    public ForwardingInfo forwarding { get; set; }
    // Unconditional forwarding parameters. Returned if 'UnconditionalForwarding' is specified in 'callHandlingAction'
    public UnconditionalForwardingInfo unconditionalForwarding { get; set; }
    // Specifies whether to take a voicemail and who should do it
    public VoicemailInfo voicemail { get; set; }
}


public partial class AnsweringRuleInfo_CalleeInfo
{
    // Called phone number
    public string phoneNumber { get; set; }
}


public partial class AnsweringRuleInfo_CallerInfo
{
    // Phone number of a caller
    public string callerId { get; set; }
    // Contact name of a caller
    public string name { get; set; }
}


public partial class AttachmentInfo
{
    // Link to custom data attachment
    public string uri { get; set; }
    // Type of custom data attachment, see also MIME Types
    public string contentType { get; set; }
}


public partial class BillingPlanInfo
{
    // Internal identifier of a billing plan
    public string id { get; set; }
    // Billing plan name
    public string name { get; set; }
    // Duration period
    public string durationUnit { get; set; }
    // Number of duration units
    public string duration { get; set; }
    // Billing plan type
    public string type { get; set; }
}


public partial class BlockedNumberInfo
{
    // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
    public string id { get; set; }
    // Canonical URI of a blocked number resource
    public string uri { get; set; }
    // Name assigned by a user to a blocked phone number
    public string name { get; set; }
    // Phone number to be blocked
    public string phoneNumber { get; set; }
}


public partial class BrandInfo
{
    // Internal identifier of a brand
    public string id { get; set; }
    // Brand name, for example "RingCentral UK", "ClearFax"
    public string name { get; set; }
    // Home country information
    public CountryInfo homeCountry { get; set; }
}


public partial class BusinessAddressInfo
{
    // Name of a country
    public string country { get; set; }
    // Name of a state/province
    public string state { get; set; }
    // Name of a city
    public string city { get; set; }
    // Street address
    public string street { get; set; }
    // Zip code
    public string zip { get; set; }
}


public partial class BusinessHour_ScheduleInfo
{
    // Weekly schedule
    public WeeklyScheduleInfo weeklyRanges { get; set; }
}


public partial class CallLogInfo
{
    // Internal identifier of a cal log record
    public string id { get; set; }
    // Canonical URI of a call log record
    public string uri { get; set; }
    // Internal identifier of a call session
    public string sessionId { get; set; }
    // Caller information
    public CallerInfo from { get; set; }
    // Callee information
    public CallerInfo to { get; set; }
    // Call type
    public string type { get; set; }
    // Call direction
    public string direction { get; set; }
    // Action description of the call operation
    public string action { get; set; }
    // Status description of the call operation
    public string result { get; set; }
    // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string startTime { get; set; }
    // Call duration in seconds
    public int? duration { get; set; }
    // Call recording data. Returned if the call is recorded
    public RecordingInfo recording { get; set; }
}


public partial class CallLogRecord
{
    // Internal identifier of a cal log record
    public string id { get; set; }
    // Canonical URI of a call log record
    public string uri { get; set; }
    // Internal identifier of a call session
    public string sessionId { get; set; }
    // Caller information
    public CallerInfo from { get; set; }
    // Callee information
    public CallerInfo to { get; set; }
    // Call type
    public string type { get; set; }
    // Call direction
    public string direction { get; set; }
    // Action description of the call operation
    public string action { get; set; }
    // Status description of the call operation
    public string result { get; set; }
    // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string startTime { get; set; }
    // Call duration in seconds
    public int? duration { get; set; }
    // Call recording data. Returned if the call is recorded, the withRecording parameter is set to 'True' in this case
    public RecordingInfo recording { get; set; }
    // For 'Detailed' view only. The datetime when the call log record was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string lastModifiedTime { get; set; }
    // For 'Detailed' view only. Call transport
    public string transport { get; set; }
    // For 'Detailed' view only. Leg description
    public LegInfo[] legs { get; set; }
}


public partial class CallerInfo
{
    // Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
    public string phoneNumber { get; set; }
    // Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
    public string extensionNumber { get; set; }
    // Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
    public string location { get; set; }
    // Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
    public string name { get; set; }
}


public partial class Conferencing_Request_PhoneNumber
{
    // Dial-in phone number to connect to a conference
    public string phoneNumber { get; set; }
    // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
    public bool? @default { get; set; }
}


public partial class ConferencingInfo
{
    // Canonical URI of a conferencing
    public string uri { get; set; }
    // Determines if host user allows conference participants to join before the host
    public bool? allowJoinBeforeHost { get; set; }
    // Access code for a host user
    public string hostCode { get; set; }
    // Internal parameter specifying conferencing engine
    public string mode { get; set; }
    // Access code for any participant
    public string participantCode { get; set; }
    // Primary conference phone number for user's home country returned in E.164 (11-digits) format
    public string phoneNumber { get; set; }
    // Short URL leading to the service web page Tap to Join for audio conference bridge
    public string tapToJoinUri { get; set; }
    // List of multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
    public ConferencingInfo_PhoneNumberInfo[] phoneNumbers { get; set; }
}


public partial class ConferencingInfo_PhoneNumberInfo
{
    // Information on a home country of a conference phone number
    public ConferencingInfo_PhoneNumberInfo_CountryInfo country { get; set; }
    // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
    public bool? @default { get; set; }
    // 'True' if the greeting message is played on this number
    public bool? hasGreeting { get; set; }
    // Location (city, region, state) of a conference phone number
    public string location { get; set; }
    // Dial-in phone number to connect to a conference
    public string phoneNumber { get; set; }
}


public partial class ConferencingInfo_PhoneNumberInfo_CountryInfo
{
    // Internal identifier of a country
    public string id { get; set; }
    // Canonical URI of a country
    public string uri { get; set; }
    // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
    public string callingCode { get; set; }
    // Emergency calling feature availability/emergency address requirement indicator
    public bool? emergencyCalling { get; set; }
    // Country code according to the ISO standard, see ISO 3166
    public string isoCode { get; set; }
    // Official name of a country
    public string name { get; set; }
}


public partial class ContactAddressInfo
{
    // Country name of extension user company. Not returned for Address Book
    public string country { get; set; }
    // State/province name of extension user company
    public string state { get; set; }
    // City name of extension user company
    public string city { get; set; }
    // Street address of extension user company
    public string street { get; set; }
    // Zip code of extension user company
    public string zip { get; set; }
}


public partial class ContactInfo
{
    // For User extension type only. Extension user first name
    public string firstName { get; set; }
    // For User extension type only. Extension user last name
    public string lastName { get; set; }
    // Extension user company name
    public string company { get; set; }
    // Email of extension user
    public string email { get; set; }
    // Extension user contact phone number
    public string businessPhone { get; set; }
    // Business address of extension user company
    public ContactAddressInfo businessAddress { get; set; }
}


public partial class CountryInfo
{
    // Internal identifier of a home country
    public string id { get; set; }
    // Canonical URI of a home country
    public string uri { get; set; }
    // Official name of a home country
    public string name { get; set; }
}


public partial class DeliveryMode
{
    // Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
    public string transportType { get; set; }
    // Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always "false"
    public bool? encryption { get; set; }
    // PubNub channel name. For APNS transport type - internal identifier of a device "device_token"
    public string address { get; set; }
    // PubNub subscriber credentials required to subscribe to the channel
    public string subscriberKey { get; set; }
    // PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
    public string secretKey { get; set; }
    // Encryption algorithm 'AES' (for PubNub transport type only)
    public string encryptionAlgorithm { get; set; }
    // Key for notification message decryption (for PubNub transport type only)
    public string encryptionKey { get; set; }
}


public partial class Department_Response_ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Number of department extension
    public string extensionNumber { get; set; }
    // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
    public string partnerId { get; set; }
}


public partial class DepartmentInfo
{
    // Internal identifier of a department extension
    public string id { get; set; }
    // Canonical URI of a department extension
    public string uri { get; set; }
    // Number of a department extension
    public string extensionNumber { get; set; }
}


public partial class DeviceInfo
{
    // Internal identifier of a device
    public string id { get; set; }
    // Canonical URI of a device
    public string uri { get; set; }
    // Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
    public string sku { get; set; }
    // Device type. The default value is 'HardPhone'
    public string type { get; set; }
    // Device name. Mandatory if ordering "SoftPhone" or "OtherPhone". Optional for "HardPhone". If not specified for HardPhone, then device "model" name is used as device "name"
    public string name { get; set; }
    // Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
    public string serial { get; set; }
    // PC name for softphone
    public string computerName { get; set; }
    // HardPhone model information
    public ModelInfo model { get; set; }
    // This attribute can be omitted for unassigned devices
    public DeviceInfo_ExtensionInfo extension { get; set; }
    // Address for emergency cases. The same emergency address is assigned to all the numbers of one device
    public EmergencyAddressInfo emergencyServiceAddress { get; set; }
    // Phone lines information
    public PhoneLinesInfo phoneLines { get; set; }
    // Shipping information, according to which devices (in case of "HardPhone") or e911 stickers (in case of "SoftPhone" and "OtherPhone") will be delivered to the customer
    public ShippingInfo shipping { get; set; }
    // Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either "model" structure, or "boxBillingId" must be specified for HardPhone
    public int? boxBillingId { get; set; }
}


public partial class DeviceInfo_ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Number of department extension
    public string extensionNumber { get; set; }
    // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
    public string partnerId { get; set; }
}


public partial class DialInNumbers
{
    // Phone number of the dial-in number for the meeting in e.164 format
    public string phoneNumber { get; set; }
    // Phone number of the dial-in number formatted according to the extension home country
    public string formattedNumber { get; set; }
    // Optional field in case the dial-in number is associated with a particular location
    public string location { get; set; }
    // Country resource corresponding to the dial-in number
    public DialInNumbers_CountryInfo country { get; set; }
}


public partial class DialInNumbers_CountryInfo
{
    // Internal identifier of a country
    public string id { get; set; }
    // Canonical URI of a country
    public string uri { get; set; }
    // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
    public string callingCode { get; set; }
    // Country code according to the ISO standard, see ISO 3166
    public string isoCode { get; set; }
    // Official name of a country
    public string name { get; set; }
}


public partial class DialingPlanCountryInfo
{
    // Internal identifier of a country
    public string id { get; set; }
    // Canonical URI of a country
    public string uri { get; set; }
    // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
    public string callingCode { get; set; }
    // Country code according to the ISO standard, see ISO 3166
    public string isoCode { get; set; }
    // Official name of a country
    public string name { get; set; }
}


public partial class EmergencyAddressInfo
{
    // Name of a customer
    public string customerName { get; set; }
    // Street address, line 1 - street address, P.O. box, company name, c/o
    public string street { get; set; }
    // Street address, line 2 - apartment, suite, unit, building, floor, etc.
    public string street2 { get; set; }
    // City name
    public string city { get; set; }
    // State/province name
    public string state { get; set; }
    // Zip code
    public string zip { get; set; }
    // Country name
    public string country { get; set; }
}


public partial class ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Contact detailed information
    public ContactInfo contact { get; set; }
    // Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
    public DepartmentInfo departments { get; set; }
    // Number of department extension
    public string extensionNumber { get; set; }
    // Extension user name
    public string name { get; set; }
    // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
    public string partnerId { get; set; }
    // Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
    public ExtensionPermissions permissions { get; set; }
    // Information on profile image
    public ProfileImageInfo profileImage { get; set; }
    // List of non-RC internal identifiers assigned to an extension
    public ReferenceInfo[] references { get; set; }
    // Extension region data (timezone, home country, language)
    public RegionalSettings regionalSettings { get; set; }
    // Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
    public ExtensionServiceFeatureInfo[] serviceFeatures { get; set; }
    // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
    public string setupWizardState { get; set; }
    // Extension current state. If the status is 'Unassigned'. Returned for all extensions
    public string status { get; set; }
    // Status information (reason, comment). Returned for 'Disabled' status only
    public StatusInfo statusInfo { get; set; }
    // Extension type
    public string type { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo
{
    // Contact information
    public ContactInfo contact { get; set; }
    // Region data (timezone, home country, language)
    public ExtensionInfo_Request_ContactInfo_RegionalSettings regionalSettings { get; set; }
    // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
    public string setupWizardState { get; set; }
    // Extension user department
    public string department { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings
{
    // Timezone data
    public ExtensionInfo_Request_ContactInfo_RegionalSettings_Timezone timezone { get; set; }
    // User interface language data
    public ExtensionInfo_Request_ContactInfo_RegionalSettings_Language language { get; set; }
    // Information on language used for telephony greetings
    public ExtensionInfo_Request_ContactInfo_RegionalSettings_GreetingLanguage greetingLanguage { get; set; }
    // Formatting language preferences for numbers, dates and currencies
    public ExtensionInfo_Request_ContactInfo_RegionalSettings_FormattingLocale formattingLocale { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings_FormattingLocale
{
    // Internal identifier of a formatting language
    public string id { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings_GreetingLanguage
{
    // Internal identifier of a greeting language
    public string id { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings_Language
{
    // Language identifier. The default value is "1033" (English US)
    public string id { get; set; }
}


public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings_Timezone
{
    // Timezone identifier. The default value is "58" (US&Canada)
    public string id { get; set; }
}


public partial class ExtensionInfo_Request_PartnerId
{
    // Extension partner identifier
    public string partnerId { get; set; }
}


public partial class ExtensionInfo_Request_PasswordPIN
{
    // Password for extension
    public string password { get; set; }
    // IVR PIN
    public string ivrPin { get; set; }
}


public partial class ExtensionInfo_Request_Provision
{
    // Mandatory. Resulting extension status
    public string status { get; set; }
    // Mandatory. Extension user contact information
    public ExtensionInfo_Request_Provision_ContactInfo contact { get; set; }
}


public partial class ExtensionInfo_Request_Provision_ContactInfo
{
    // Mandatory. Extension user first name
    public string firstName { get; set; }
    // Mandatory. Extension user last name
    public string lastName { get; set; }
    // Mandatory. Extension user contact email
    public string email { get; set; }
}


public partial class ExtensionInfo_Request_StatusInfo
{
    // Required extension status
    public string status { get; set; }
    // Extension status information, only for the 'Disabled' status
    public StatusInfo statusInfo { get; set; }
}


public partial class ExtensionPermissions
{
    // Admin permission
    public PermissionInfo admin { get; set; }
    // International Calling permission
    public PermissionInfo internationalCalling { get; set; }
}


public partial class ExtensionServiceFeatureInfo
{
    // Feature status; shows feature availability for an extension
    public bool? enabled { get; set; }
    // Feature name, see all available values in Service Feature List
    public string featureName { get; set; }
    // Reason of limitation for a particular service feature. Returned only if the enabled parameter value is 'False', see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
    public string reason { get; set; }
}


public partial class ExternalUserInfo
{
    // User type of a meeting account
    public string accountId { get; set; }
    // Meeting account user identifier
    public string userId { get; set; }
    // Meeting account user token
    public string userToken { get; set; }
    // Meeting account user type
    public int? userType { get; set; }
}


public partial class FormattingLocaleInfo
{
    // Internal identifier of a formatting language
    public string id { get; set; }
    // Localization code of a formatting language
    public string localeCode { get; set; }
    // Official name of a formatting language
    public string name { get; set; }
}


public partial class ForwardingInfo
{
    // Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
    public bool? notifyMySoftPhones { get; set; }
    // Specifies if the administrator's softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'False'
    public bool? notifyAdminSoftPhones { get; set; }
    // Number of rings before forwarding starts
    public int? softPhonesRingCount { get; set; }
    // Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
    public string ringingMode { get; set; }
    // Information on a call forwarding rule
    public RuleInfo[] rules { get; set; }
}


public partial class ForwardingNumberInfo
{
    // Internal identifier of a forwarding/call flip phone number
    public string id { get; set; }
    // Canonical URI of a forwarding/call flip phone number
    public string uri { get; set; }
    // Forwarding/Call flip phone number
    public string phoneNumber { get; set; }
    // Forwarding/Call flip number title
    public string label { get; set; }
    // Type of option this phone number is used for. Multiple values are accepted
    public string features { get; set; }
    // Number assigned to the call flip phone number, corresponds to the shortcut dial number
    public int? flipNumber { get; set; }
}


public partial class FullCountryInfo
{
    // Internal identifier of a country
    public string id { get; set; }
    // Canonical URI of a country
    public string uri { get; set; }
    // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
    public string callingCode { get; set; }
    // Emergency calling feature availability/emergency address requirement indicator
    public bool? emergencyCalling { get; set; }
    // Country code according to the ISO standard, see ISO 3166
    public string isoCode { get; set; }
    // Official name of a country
    public string name { get; set; }
    // Determines whether phone numbers are available for a country
    public bool? numberSelling { get; set; }
    // Specifies whether login with the phone numbers of this country is enabled or not
    public bool? loginAllowed { get; set; }
}


public partial class GrantInfo
{
    // Canonical URI of a grant
    public string uri { get; set; }
    // Extension information
    public GrantInfo_ExtensionInfo extension { get; set; }
    // Specifies if picking up of other extensions' calls is allowed for the extension. If 'Presence' feature is disabled for the given extension, the flag is not returned
    public bool? callPickup { get; set; }
    // Specifies if monitoring of other extensions' calls is allowed for the extension. If 'CallMonitoring' feature is disabled for the given extension, the flag is not returned
    public bool? callMonitoring { get; set; }
}


public partial class GrantInfo_ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Extension short number (usually 3 or 4 digits)
    public string extensionNumber { get; set; }
    // Extension type
    public string type { get; set; }
}


public partial class GreetingLanguageInfo
{
    // Internal identifier of a greeting language
    public string id { get; set; }
    // Localization code of a greeting language
    public string localeCode { get; set; }
    // Official name of a greeting language
    public string name { get; set; }
}


public partial class GroupInfo
{
    // Internal identifier of a group
    public string id { get; set; }
    // Canonical URI of a group
    public string uri { get; set; }
    // Amount of contacts in a group
    public int? contactsCount { get; set; }
    // Name of a group
    public string groupName { get; set; }
    // Notes for a group
    public string notes { get; set; }
}


public partial class LanguageInfo
{
    // Internal identifier of a language
    public string id { get; set; }
    // Canonical URI of a language
    public string uri { get; set; }
    // Indicates whether a language is available as greeting language
    public bool? greeting { get; set; }
    // Indicates whether a language is available as formatting locale
    public bool? formattingLocale { get; set; }
    // Localization code of a language
    public string localeCode { get; set; }
    // Official name of a language
    public string name { get; set; }
    // Indicates whether a language is available as UI language
    public bool? ui { get; set; }
}


public partial class LegInfo
{
    // Action description of the call operation
    public string action { get; set; }
    // Call direction
    public string direction { get; set; }
    // Call duration in seconds
    public int? duration { get; set; }
    // Information on extension
    public LegInfo_ExtensionInfo extension { get; set; }
    // Leg type
    public string legType { get; set; }
    // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string startTime { get; set; }
    // Call type
    public string type { get; set; }
    // Status description of the call operation
    public string result { get; set; }
    // Caller information
    public CallerInfo from { get; set; }
    // Callee information
    public CallerInfo to { get; set; }
    // Call transport
    public string transport { get; set; }
    // Call recording data. Returned if the call is recorded
    public RecordingInfo recording { get; set; }
}


public partial class LegInfo_ExtensionInfo
{
    // Internal identifier of an extension
    public int? id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
}


public partial class LinksInfo
{
    // Link to start a meeting
    public string startUri { get; set; }
    // Link to join a meeting
    public string joinUri { get; set; }
}


public partial class LocationInfo
{
    // Canonical URI of a location
    public string uri { get; set; }
    // Area code of the location
    public string areaCode { get; set; }
    // Official name of the city, belonging to the certain state
    public string city { get; set; }
    // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
    public string npa { get; set; }
    // Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
    public string nxx { get; set; }
    // ID and URI of the state this location belongs to, see State Info
    public string state { get; set; }
}


public partial class LookUpPhoneNumber_PhoneNumberInfo
{
    // Phone number in E.164 format without a '+'
    public string phoneNumber { get; set; }
    // Phone number formatted according to current brand's default country
    public string formattedNumber { get; set; }
    // Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
    public string vanityPattern { get; set; }
    // The value is returned if the extendedSearch parameter is true. '10' is the closest match
    public int? rank { get; set; }
}


public partial class MeetingInfo
{
    // Canonical URI of a meeting resource
    public string uri { get; set; }
    // Internal identifier of a meeting as retrieved from Zoom
    public string id { get; set; }
    // Topic of a meeting
    public string topic { get; set; }
    // Type of a meeting
    public string meetingType { get; set; }
    // Password required to join a meeting
    public string password { get; set; }
    // Current status of a meeting
    public string status { get; set; }
    // Links to start/join the meeting
    public LinksInfo links { get; set; }
    // Schedule of a meeting
    public MeetingScheduleInfo schedule { get; set; }
    // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
    public bool? allowJoinBeforeHost { get; set; }
    // Enables starting video when host joins the meeting
    public bool? startHostVideo { get; set; }
    // Enables starting video when participants join the meeting
    public bool? startParticipantsVideo { get; set; }
    // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
    public string[] audioOptions { get; set; }
}


public partial class MeetingScheduleInfo
{
    // Start time of a meeting in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string startTime { get; set; }
    // Duration of a meeting in minutes
    public int? durationInMinutes { get; set; }
    // Timezone of a meeting
    public MeetingScheduleInfo_TimezoneInfo timeZone { get; set; }
}


public partial class MeetingScheduleInfo_TimezoneInfo
{
    // Identifier of a timezone
    public string id { get; set; }
}


public partial class MessageAttachmentInfo
{
    // Internal identifier of a message attachment
    public string id { get; set; }
    // Canonical URI of a message attachment
    public string uri { get; set; }
    // Type of message attachment
    public string type { get; set; }
    // MIME type for a given attachment, for instance 'audio/wav'
    public string contentType { get; set; }
    // Voicemail only Duration of the voicemail in seconds
    public int? vmDuration { get; set; }
}


public partial class MessageInfo
{
    // Internal identifier of a message
    public string id { get; set; }
    // Canonical URI of a message
    public string uri { get; set; }
    // The list of message attachments
    public MessageAttachmentInfo[] attachments { get; set; }
    // Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
    public string availability { get; set; }
    // SMS and Pager only. Identifier of the conversation the message belongs to
    public int? conversationId { get; set; }
    // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string creationTime { get; set; }
    // SMS only. Delivery error code returned by gateway
    public string deliveryErrorCode { get; set; }
    // Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
    public string direction { get; set; }
    // Fax only. Page count in fax message
    public int? faxPageCount { get; set; }
    // Fax only. Resolution of fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
    public string faxResolution { get; set; }
    // Sender information
    public MessageInfo_CallerInfo from { get; set; }
    // The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string lastModifiedTime { get; set; }
    // Message status. Different message types may have different allowed status values.
    public string messageStatus { get; set; }
    // Pager only True if at least one of the message recipients is Department extension
    public bool? pgToDepartment { get; set; }
    // Message priority
    public string priority { get; set; }
    // Message read status
    public string readStatus { get; set; }
    // SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral
    public string smsDeliveryTime { get; set; }
    // SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)
    public int? smsSendingAttemptsCount { get; set; }
    // Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
    public string subject { get; set; }
    // Recipient information
    public MessageInfo_CallerInfo[] to { get; set; }
    // Message type
    public string type { get; set; }
    // Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
    public string vmTranscriptionStatus { get; set; }
}


public partial class MessageInfo_CallerInfo
{
    // Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
    public string extensionNumber { get; set; }
    // Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
    public string location { get; set; }
    // Status of a message. Returned for outbound fax messages only
    public string messageStatus { get; set; }
    // Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'
    public string faxErrorCode { get; set; }
    // Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
    public string name { get; set; }
    // Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
    public string phoneNumber { get; set; }
}


public partial class ModelInfo
{
    // Device model identifier. Mandatory when ordering a HardPhone if boxBillingId is not used for ordering
    public string id { get; set; }
    // Device name
    public string name { get; set; }
    // Addons description
    public AddonInfo[] addons { get; set; }
}


public partial class NavigationInfo
{
    // First page of the list
    public Page firstPage { get; set; }
    // Next page of the list
    public Page nextPage { get; set; }
    // Previous page of the list
    public Page previousPage { get; set; }
    // Last page of the list
    public Page lastPage { get; set; }
}


public partial class Page
{
    // Canonical URI for the page
    public string uri { get; set; }
}


public partial class PagingInfo
{
    // The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage=0 was requested)
    public int? page { get; set; }
    // Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied
    public int? perPage { get; set; }
    // The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty
    public int? pageStart { get; set; }
    // The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty
    public int? pageEnd { get; set; }
    // The total number of pages in a dataset. May be omitted for some resources due to performance reasons
    public int? totalPages { get; set; }
    // The total number of elements in a dataset. May be omitted for some resource due to performance reasons
    public int? totalElements { get; set; }
}


public partial class ParsePhoneNumber_CountryInfo
{
    // Internal identifier of a country
    public string id { get; set; }
    // Canonical URI of a country
    public string uri { get; set; }
    // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
    public string callingCode { get; set; }
    // Emergency calling feature availability/emergency address requirement indicator
    public bool? emergencyCalling { get; set; }
    // Country code according to the ISO standard, see ISO 3166
    public string isoCode { get; set; }
    // Official name of a country
    public string name { get; set; }
}


public partial class ParsePhoneNumber_PhoneNumberInfo
{
    // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
    public string areaCode { get; set; }
    // Information on a country the phone number belongs to
    public ParsePhoneNumber_CountryInfo[] country { get; set; }
    // Dialing format of a phone number
    public string dialable { get; set; }
    // E.164 (11-digits) format of a phone number
    public string e164 { get; set; }
    // International format of a phone number
    public string formattedInternational { get; set; }
    // Domestic format of a phone number
    public string formattedNational { get; set; }
    // One of the numbers to be parsed, passed as a string in response
    public string originalString { get; set; }
    // "True" if the number is in a special format (for example N11 code)
    public bool? special { get; set; }
    // E.164 (11-digits) format of a phone number without the plus sign ('+')
    public string normalized { get; set; }
}


public partial class PermissionInfo
{
    // Specifies if a permission is enabled or not
    public bool? enabled { get; set; }
}


public partial class PersonalContactInfo
{
    // Standard resource properties ID
    public int? id { get; set; }
    // Canonical URI
    public string url { get; set; }
    // This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
    public string availability { get; set; }
    // First name of a personal contact
    public string firstName { get; set; }
    // Last name of a personal contact
    public string lastName { get; set; }
    // Middle name of a personal contact
    public string middleName { get; set; }
    // Nick name of a personal contact
    public string nickName { get; set; }
    // Company name of a personal contact
    public string company { get; set; }
    // Job title of a personal contact
    public string jobTitle { get; set; }
    // Home phone of a personal contact
    public string homePhone { get; set; }
    // The 2-d home phone of a personal contact
    public string homePhone2 { get; set; }
    // Business phone of a personal contact
    public string businessPhone { get; set; }
    // The 2-d business phone of a personal contact
    public string businessPhone2 { get; set; }
    // Mobile phone of a personal contact
    public string mobilePhone { get; set; }
    // Business fax of a personal contact
    public string businessFax { get; set; }
    // Company phone of a personal contact
    public string companyPhone { get; set; }
    // Assistant phone of a personal contact
    public string assistantPhone { get; set; }
    // Car phone of a personal contact
    public string carPhone { get; set; }
    // Other phone of a personal contact
    public string otherPhone { get; set; }
    // Other fax of a personal contact
    public string otherFax { get; set; }
    // Callback phone of a personal contact
    public string callbackPhone { get; set; }
    // Email of a personal contact
    public string email { get; set; }
    // The 2-d email of a personal contact
    public string email2 { get; set; }
    // The 3-d email of a personal contact
    public string email3 { get; set; }
    // Home address of a personal contact
    public ContactAddressInfo homeAddress { get; set; }
    // Business address of a personal contact
    public ContactAddressInfo businessAddress { get; set; }
    // Other address of a personal contact
    public ContactAddressInfo otherAddress { get; set; }
    // Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string birthday { get; set; }
    // Web page of a personal contact
    public string webPage { get; set; }
    // Notes of a personal contact
    public string notes { get; set; }
}


public partial class PhoneLinesInfo
{
    // Type of phone line
    public string lineType { get; set; }
    // Phone number information
    public PhoneLinesInfo_PhoneNumberInfo phoneInfo { get; set; }
}


public partial class PhoneLinesInfo_PhoneNumberInfo
{
    // Internal identifier of a phone number
    public int? id { get; set; }
    // Brief information on a phone number country
    public CountryInfo country { get; set; }
    // Location (City, State). Filled for local US numbers
    public string location { get; set; }
    // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
    public string paymentType { get; set; }
    // Phone number
    public string phoneNumber { get; set; }
    // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
    public string status { get; set; }
    // Phone number type
    public string type { get; set; }
    // Usage type of the phone number
    public string usageType { get; set; }
}


public partial class PhoneNumberInfo
{
    // Internal identifier of a phone number
    public int? id { get; set; }
    // Brief information on a phone number country
    public CountryInfo country { get; set; }
    // Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
    public PhoneNumberInfo_ExtensionInfo extension { get; set; }
    // Indicates if this phone number is enabled to appear as CallerId and/or to send outbound SMS from it. Returned only for the request of Extension phone number list
    public string[] features { get; set; }
    // Location (City, State). Filled for local US numbers
    public string location { get; set; }
    // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
    public string paymentType { get; set; }
    // Phone number
    public string phoneNumber { get; set; }
    // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
    public string status { get; set; }
    // Phone number type
    public string type { get; set; }
    // Usage type of the phone number
    public string usageType { get; set; }
}


public partial class PhoneNumberInfo_ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Number of department extension
    public string extensionNumber { get; set; }
    // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
    public string partnerId { get; set; }
}


public partial class PresenceInfo
{
    // Canonical URI of a presence info resource
    public string uri { get; set; }
    // If 'True' enables other extensions to see the extension presence status
    public bool? allowSeeMyPresence { get; set; }
    // Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
    public string dndStatus { get; set; }
    // Information on extension, for which this presence data is returned
    public PresenceInfo_ExtensionInfo extension { get; set; }
    // Custom status message (as previously published by user)
    public string message { get; set; }
    // If 'True' enables the extension user to pick up a monitored line on hold
    public bool? pickUpCallsOnHold { get; set; }
    // Aggregated presence status, calculated from a number of sources
    public string presenceStatus { get; set; }
    // If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
    public bool? ringOnMonitoredCall { get; set; }
    // Telephony presence status
    public string telephonyStatus { get; set; }
    // User-defined presence status (as previously published by the user)
    public string userStatus { get; set; }
}


public partial class PresenceInfo_ExtensionInfo
{
    // Internal identifier of an extension
    public string id { get; set; }
    // Canonical URI of an extension
    public string uri { get; set; }
    // Extension number (usually 3 or 4 digits)
    public string extensionNumber { get; set; }
}


public partial class ProfileImageInfo
{
    // Link to a profile image. If an image is not uploaded for an extension, only uri is returned
    public string uri { get; set; }
    // Identifier of an image
    public string etag { get; set; }
    // The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
    public string lastModified { get; set; }
    // The type of an image
    public string contentType { get; set; }
    // List of URIs to profile images in different dimensions
    public string[] scales { get; set; }
}


public partial class RangesInfo
{
    // Date and time in format YYYY-MM-DD hh:mm
    public string from { get; set; }
    // Date and time in format YYYY-MM-DD hh:mm
    public string to { get; set; }
}


public partial class RecipientInfo
{
    // Link to a recipient extension resource
    public string uri { get; set; }
    // Internal identifier of a recipient extension
    public string id { get; set; }
}


public partial class RecordingInfo
{
    // Internal identifier of the call recording
    public int? id { get; set; }
    // Link to the call recording metadata resource
    public string uri { get; set; }
    // Indicates recording mode used
    public string type { get; set; }
    // Link to the call recording binary content
    public string contentUri { get; set; }
}


public partial class ReferenceInfo
{
    // Non-RC identifier of an extension
    public string @ref { get; set; }
    // Type of external identifier
    public string type { get; set; }
}


public partial class RegionalSettings
{
    // Extension country information
    public CountryInfo homeCountry { get; set; }
    // Extension timezone information
    public TimezoneInfo timezone { get; set; }
    // User interface language data
    public LanguageInfo language { get; set; }
    // Information on language used for telephony greetings
    public GreetingLanguageInfo greetingLanguage { get; set; }
    // Formatting language preferences for numbers, dates and currencies
    public FormattingLocaleInfo formattingLocale { get; set; }
}


public partial class ReservePhoneNumber_Request_ReserveRecord
{
    // Phone number in E.164 format without a '+'
    public string phoneNumber { get; set; }
    // The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to 'null', the number will be un-reserved if it was reserved previously by the same session. 'Min' value is 30 seconds; 'Max' value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session)
    public string reservedTill { get; set; }
}


public partial class ReservePhoneNumber_Response_ReserveRecord
{
    // Phone number in E.164 format without a '+'
    public string phoneNumber { get; set; }
    // Domestic format of a phone number
    public string formattedNumber { get; set; }
    // The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore
    public string reservedTill { get; set; }
    // Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
    public string reservationId { get; set; }
    // Phone number status
    public string status { get; set; }
    // The error code in case of reservation/un-reservation failure
    public string error { get; set; }
}


public partial class RingOut_Request_CountryInfo
{
    // Dialing plan country identifier
    public string id { get; set; }
}


public partial class RingOut_Request_From
{
    // Phone number in E.164 format
    public string phoneNumber { get; set; }
    // Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute
    public string forwardingNumberId { get; set; }
}


public partial class RingOut_Request_To
{
    // Phone number in E.164 format
    public string phoneNumber { get; set; }
}


public partial class RingOutInfo
{
    // Internal identifier of a RingOut call
    public string id { get; set; }
    // RingOut status information
    public RingOutStatusInfo status { get; set; }
}


public partial class RingOutStatusInfo
{
    // Status of a call
    public string callStatus { get; set; }
    // Status of a calling party
    public string callerStatus { get; set; }
    // Status of a called party
    public string calleeStatus { get; set; }
}


public partial class RuleInfo
{
    // Forwarding number (or group) ordinal
    public int? index { get; set; }
    // Number of rings for a forwarding number (or group)
    public int? ringCount { get; set; }
    // Forwarding number (or group) data
    public RuleInfo_ForwardingNumberInfo[] forwardingNumbers { get; set; }
}


public partial class RuleInfo_ForwardingNumberInfo
{
    // Link to a forwarding number resource
    public string uri { get; set; }
    // Internal identifier of a forwarding number
    public string id { get; set; }
    // Phone number to which the call is forwarded
    public string phoneNumber { get; set; }
    // Title of a forwarding number
    public string label { get; set; }
}


public partial class ScheduleInfo
{
    // Weekly schedule
    public WeeklyScheduleInfo weeklyRanges { get; set; }
    // Specific data ranges
    public RangesInfo ranges { get; set; }
    // The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
    public string @ref { get; set; }
}


public partial class ServerInfo
{
    // Canonical URI of the API version
    public string uri { get; set; }
    // Full API version information: uri, number, release date
    public VersionInfo[] apiVersions { get; set; }
    // Server version
    public string serverVersion { get; set; }
    // Server revision
    public string serverRevision { get; set; }
}


public partial class ServiceFeatureInfo
{
    // Feature name, see all available values in Service Feature List
    public string featureName { get; set; }
    // Feature status, shows feature availability for the extension
    public bool? enabled { get; set; }
}


public partial class ServiceInfo
{
    // Canonical URI of a service info resource
    public string uri { get; set; }
    // Information on account billing plan
    public BillingPlanInfo billingPlan { get; set; }
    // Information on account brand
    public BrandInfo brand { get; set; }
    // Information on account service plan
    public ServicePlanInfo servicePlan { get; set; }
    // Information on account target service plan
    public TargetServicePlanInfo targetServicePlan { get; set; }
}


public partial class ServicePlanInfo
{
    // Internal identifier of a service plan
    public string id { get; set; }
    // Name of a service plan
    public string name { get; set; }
    // Edition of a service plan
    public string edition { get; set; }
}


public partial class ShippingAddress
{
    // Name of a receiver
    public string customerName { get; set; }
    // Street address, line 1 - street address, P.O. box, company name, c/o
    public string street { get; set; }
    // Street address, line 2 - apartment, suite, unit, building, floor, etc.
    public string street2 { get; set; }
    // City name
    public string city { get; set; }
    // State/province name
    public string state { get; set; }
    // Zip code
    public string zip { get; set; }
    // Country name
    public string country { get; set; }
}


public partial class ShippingInfo
{
    // Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.
    public string status { get; set; }
    // Shipping carrier name. Appears only if the device status is "Shipped"
    public string carrier { get; set; }
    // Carrier-specific tracking number. Appears only if the device status is "Shipped"
    public string trackingNumber { get; set; }
    // Shipping method information
    public ShippingMethod[] method { get; set; }
    // Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses
    public ShippingAddress[] address { get; set; }
}


public partial class ShippingMethod
{
    // Method identifier. The default value is "1" (Ground)
    public string id { get; set; }
    // Method name, corresponding to the identifier
    public string name { get; set; }
}


public partial class StateInfo
{
    // Internal identifier of a state
    public string id { get; set; }
    // Canonical URI of a state
    public string uri { get; set; }
    // Information on a country the state belongs to
    public StateInfo_CountryInfo country { get; set; }
    // Short code for a state (2-letter usually)
    public string isoCode { get; set; }
    // Official name of a state
    public string name { get; set; }
}


public partial class StateInfo_CountryInfo
{
    // Internal identifier of a state
    public string id { get; set; }
    // Canonical URI of a state
    public string uri { get; set; }
}


public partial class StatusInfo
{
    // A free-form user comment, describing the status change reason
    public string comment { get; set; }
    // Type of suspension
    public string reason { get; set; }
}


public partial class Subscription_Request_DeliveryMode
{
    // Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
    public string transportType { get; set; }
    // Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'
    public bool? encryption { get; set; }
}


public partial class SubscriptionInfo
{
    // Internal identifier of a subscription
    public string id { get; set; }
    // Canonical URI of a subscription
    public string uri { get; set; }
    // Collection of URIs to API resources (message-store/presence/detailed presence)
    public string[] eventFilters { get; set; }
    // Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string expirationTime { get; set; }
    // Subscription lifetime in seconds. The default value is 900
    public int? expiresIn { get; set; }
    // Subscription status
    public string status { get; set; }
    // Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string creationTime { get; set; }
    // Delivery mode data
    public DeliveryMode deliveryMode { get; set; }
}


public partial class SyncInfo
{
    // Type of synchronization
    public string syncType { get; set; }
    // Synchronization token
    public string syncToken { get; set; }
    // Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
    public string syncTime { get; set; }
}


public partial class TargetServicePlanInfo
{
    // Internal identifier of a target service plan
    public string id { get; set; }
    // Name of a target service plan
    public string name { get; set; }
}


public partial class TimeInterval
{
    // Time in format hh:mm
    public string from { get; set; }
    // Time in format hh:mm
    public string to { get; set; }
}


public partial class TimezoneInfo
{
    // Internal identifier of a timezone
    public string id { get; set; }
    // Canonical URI of a timezone
    public string uri { get; set; }
    // Short name of a timezone
    public string name { get; set; }
    // Meaningful description of the timezone
    public string description { get; set; }
}


public partial class UnconditionalForwardingInfo
{
    // Phone number to which the call is forwarded
    public string phoneNumber { get; set; }
}


public partial class VersionInfo
{
    // Canonical URI of API versions
    public string uri { get; set; }
    // Version of the RingCentral REST API
    public string versionString { get; set; }
    // Release date of this version
    public string releaseDate { get; set; }
    // URI part determining the current version
    public string uriString { get; set; }
}


public partial class VoicemailInfo
{
    // If 'True' then voicemails are allowed to be received
    public bool? enabled { get; set; }
    // Recipient data
    public RecipientInfo recipient { get; set; }
}


public partial class WeeklyScheduleInfo
{
    // Time intervals for a particular day
    public TimeInterval[] monday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] tuesday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] wednesday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] thursday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] friday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] saturday { get; set; }
    // Time intervals for a particular day
    public TimeInterval[] sunday { get; set; }
}


