using Flurl.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RingCentral
{
    // Extension put requestBody is an enum
    public interface ExtensionParameters { }
    public partial class ExtensionInfo_Request_StatusInfo : ExtensionParameters { }
    public partial class ExtensionInfo_Request_ContactInfo : ExtensionParameters { }
    public partial class ExtensionInfo_Request_PasswordPIN : ExtensionParameters { }
    public partial class ExtensionInfo_Request_PartnerId : ExtensionParameters { }
    public partial class ExtensionInfo_Request_Provision : ExtensionParameters { }


    // fax
    public partial class FaxPath
    {
        public Task<MessageInfo> Post(object requestBody, IEnumerable<Attachment> attachments)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.CharSet = "UTF-8";
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/mixed";
            var jsonBody = JsonConvert.SerializeObject(requestBody, RestClient.jsonSerializerSettings);
            multipartFormDataContent.Add(new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            foreach (var attachment in attachments)
            {
                var fileContent = new ByteArrayContent(attachment.bytes);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = attachment.fileName
                };
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(attachment.contentType);
                multipartFormDataContent.Add(fileContent);
            }
            return RC.PostContent(Endpoint(false), multipartFormDataContent).ReceiveJson<MessageInfo>();
        }
        //public Task<MessageInfo> Post(PostParameters requestBody, IEnumerable<Attachment> attachments)
        //{
        //    return Post(requestBody as object, attachments);
        //}
    }
    public class Attachment
    {
        public string fileName { get; set; }
        public string contentType { get; set; }
        public byte[] bytes { get; set; }
    }


    // Upload profile image
    public partial class ProfileImagePath
    {
        private MultipartFormDataContent GetContent(byte[] bytes, string imageFileName)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/form-data";
            var byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "image",
                FileName = imageFileName,
            };
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue("image/" + Path.GetExtension(imageFileName).Substring(1));
            multipartFormDataContent.Add(byteArrayContent);
            return multipartFormDataContent;
        }

        public async Task<bool> Post(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PostContent(Endpoint(false), content);
            return true;
        }

        public async Task<bool> Put(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PutContent(Endpoint(false), content);
            return true;
        }
    }


    // notification models
    public interface INotification { }
    public enum NotificationType
    {
        DetailedPresence, DetailedPresenceWithSIP, ExtensionInfo, ExtensionList, IncomingCall, InstantMessage, Message, PresenceLine, Presence
    }
    public partial class DetailedPresenceNotification : INotification
    {
    }
    public partial class DetailedPresenceWithSIPNotification : INotification
    {
    }
    public partial class ExtensionInfoNotification : INotification
    {
    }
    public partial class ExtensionListNotification : INotification
    {
    }
    public partial class IncomingCallNotification : INotification
    {
    }
    public partial class InstantMessageNotification : INotification
    {
    }
    public partial class MessageNotification : INotification
    {
    }
    public partial class PresenceLineNotification : INotification
    {
    }
    public partial class PresenceNotification : INotification
    {
    }
    public class Notification
    {
        public string json { get; set; }
        public string @event { get; set; }

        public Notification() { }
        public Notification(string json)
        {
            this.@event = JsonConvert.DeserializeObject<Notification>(json).@event;
            this.json = json;
        }

        private NotificationType? PresenceType()
        {
            if (@event == null)
            {
                return null;
            }
            var result = NotificationType.Presence;
            if (@event.Contains("detailedTelephonyState="))
            {
                result = NotificationType.DetailedPresence;
            }
            if (@event.Contains("sipData="))
            {
                result = NotificationType.DetailedPresenceWithSIP;
            }
            return result;
        }

        public NotificationType? type
        {
            get
            {
                if (@event == null)
                {
                    return null;
                }
                if (new Regex("/account/\\d+/extension/\\d+/message-store/instant").Match(@event).Success)
                {
                    return NotificationType.InstantMessage;
                }
                else if (new Regex("/account/\\d+/extension/\\d+/message-store").Match(@event).Success)
                {
                    return NotificationType.Message;
                }
                else if (new Regex("/account/\\d+/extension/\\d+/presence/line/presence").Match(@event).Success)
                {
                    return PresenceType();
                }
                else if (new Regex("/account/\\d+/extension/\\d+/presence/line").Match(@event).Success)
                {
                    return NotificationType.PresenceLine;
                }
                else if (new Regex("/account/\\d+/extension/\\d+/presence").Match(@event).Success)
                {
                    return PresenceType();
                }
                else if (new Regex("/account/\\d+/extension/\\d+/incoming-call-pickup").Match(@event).Success)
                {
                    return NotificationType.IncomingCall;
                }
                else if (new Regex("/account/\\d+/extension/\\d+").Match(@event).Success)
                {
                    return NotificationType.ExtensionInfo;
                }
                else if (new Regex("account/\\d+/extension").Match(@event).Success)
                {
                    return NotificationType.ExtensionList;
                }
                return null;
            }
        }

        public T Downcast<T>() where T: INotification
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

}
