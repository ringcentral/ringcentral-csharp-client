# ringcentral-csharp-client

[![Build status](https://ci.appveyor.com/api/projects/status/lqsl5lx1y570k063?svg=true)](https://ci.appveyor.com/project/tylerlong/ringcentral-csharp-client)
[![Coverage Status](https://coveralls.io/repos/github/ringcentral/ringcentral-csharp-client/badge.svg?branch=master&t=20160812)](https://coveralls.io/github/ringcentral/ringcentral-csharp-client?branch=master)

RingCentral C# client.

**Notice:** any issues or questions, please do let me know by [creating an issue](https://github.com/tylerlong/ringcentral-csharp-client/issues/new).

Feel free to :star: and :fork_and_knife: this repository.


## Installation

```powershell
Install-Package RingCentral.Client -Pre
```


## API Reference

[RingCentral API Reference](https://developer.ringcentral.com/api-docs/latest/index.html#!#APIReference.html) is where you can find all the endpoints, requests, parameters and all kinds of necessary details.

Please note: as a guest reader, you can only read the basic version of API Reference. Please do login if you want to get information about Advanced API endpoints.


## Initialization

```cs
using RingCentral;

rc = new RestClient("appKey", "appSecret");
```

By default the clients talk to sandbox server. If you want production server:

```cs
rc = new RestClient("appKey", "appSecret", true);
```

Or you can specify the server url explicitly:

```cs
rc = new RestClient("appKey", "appSecret", "https://platform.devtest.ringcentral.com");
```


## Authorization

```cs
rc.Authorize("username", "extension", "password");
```

If you use direct number as username, leave extension empty.


### Auto refresh

By default, there is a background timer calling `rc.Refresh()` periodically, so the authorization never expires.

But if you would like to call `Refresh` manually, please use the following code to authorize:

```cs
rc.Authorize("username", "extension", "password", false);
```

You can also disable auto refresh like following:


```cs
rc.autoRefresh = false;
```


## Map URI to code

This client library is built around URIs.
Please read this part carefully and make sure you get it before continuing.

Let's go to the [RingCentral API Reference](https://developer.ringcentral.com/api-docs/latest/index.html#!#APIReference.html) to find
[an example](https://developer.ringcentral.com/api-docs/latest/index.html#!#RefExtensionCallLogRecord.html).

We can see that the URI pattern is:

```
/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}
```

An real example of the URI could be:

```none
/restapi/v1.0/account/~/extension/130829004/call-log/ASsQ3xLOZfrLBwM
```

Let's map the URI above to code:

```cs
rc.Restapi("v1.0").Account("~").Extension("130829004").CallLog("ASsQ3xLOZfrLBwM");
```

It's just a one-to-one mapping:

![mapping](mapping.png)


##### Default ID

The default ID for `Restapi` is `v1.0`, the default ID for `Account` and `Extension` is `~`.

We can omit arguments to use default value:

```cs
rc.Restapi().Account().Extension("130829004").CallLog("ASsQ3xLOZfrLBwM");
```

You can also break it into multiple lines if you don't like long-chained method calls:

```cs
var account = rc.Restapi().Account();
var extension = account.Extension("130829004");
var callLog = extension.CallLog("ASsQ3xLOZfrLBwM");
```


## Anonymous types vs Pre-defined types

For example, the following line is for sending fax:

```cs
var response = extension.Fax().Post(requestBody, attachments).Result;
```

To create the `requestBody` object, you can define it as following:

```cs
var requestBody = new Fax.PostRequest
{
    to = new CallerInfo[] { new CallerInfo { phoneNumber = "123456789" } }
}
```

Or, you can define it using anonymous types:

```cs
var requestBody = new
{
    to = new object[] { new { phoneNumber = "123456789" } }
}
```

Both are OK. The anonymous types approach is shorter while you can take advantages of IDE intellisense with pre-defined types approach.
You can choose based on your preferences.


## Talk to API Server

```cs
var extension = rc.Restapi().Account().Extension();
```


### GET

##### List all of the inbound call Logs

```cs
var callLogs = await extension.CallLog().List(new { direction = "Inbound" });
```

Or if you prefer the query parameters as a typed model:

```cs
var callLogs = await extension.CallLog().List(new CallLog.ListQueryParams { direction = "Inbound" });
```

All the HTTP calls are by default async, so you can use the `await` keyword of C#.

Or you can append `.Result` to the end to turn it into sync:

```cs
var callLogs = extension.CallLog().List(new { direction = "Inbound" }).Result;
```


##### Get a call log by ID

```cs
var callLog = await extension.CallLog("ASsQ3xLOZfrLBwM").Get();
```

You can inspect the attributes of the returned `callLog` object because it is a model instead of a string:

```cs
Console.WriteLine(callLog.id);
Console.WriteLine(callLog.direction);
Console.WriteLine(callLog.startTime);
```


### POST

##### Send an SMS

```cs
var requestBody = new {
    text = "hello world",
    from = new { phoneNumber = phoneNumber },
    to = new object[] { new { phoneNumber = phoneNumber } }
};
var response = await extension.Sms().Post(requestBody);
```


### PUT

##### Update message status

```cs
var requestBody = new { readStatus = "Read" };
var response = await extension.MessageStore(messageId).Put(requestBody);
```


### DELETE

##### Delete message by ID

```cs
var response = await extension.MessageStore(messageId).Delete();
```


## What if I want plain HTTP without those fancy models?

```cs
var endpoint = rc.Restapi().Dictionary().Timezone("6").Endpoint(); // "/restapi/v1.0/dictionary/timezone/6"
var response = rc.Get(endpoint).Result; // make http request
var statusCode = response.StatusCode; // check status code
var str = response.Content.ReadAsStringAsync().Result; // get response string
```


## Subscription

```cs
var subscription = rc.Restapi().Subscription().New();
subscription.EventFilters.Add("/restapi/v1.0/account/~/extension/~/message-store");
subscription.EventFilters.Add("/restapi/v1.0/account/~/extension/~/presence");
subscription.ConnectEvent += (sender, args) => {
    Console.WriteLine("Connected:");
    Console.WriteLine(args.Message);
};
subscription.NotificationEvent += (sender, args) => {
    Console.WriteLine("Notification:");
    Console.WriteLine(args.Message);
};
subscription.ErrorEvent += (sender, args) => {
    Console.WriteLine("Error:");
    Console.WriteLine(args.Message);
};
subscription.Register();
```


## Send Fax

```cs
var attachment1 = new Attachment { fileName = "test.txt", contentType = "text/plain", bytes = Encoding.UTF8.GetBytes("hello world") };
var attachment2 = new Attachment { fileName = "test.pdf", contentType = "application/pdf", bytes = File.ReadAllBytes("test.pdf") };
var attachments = new Attachment[] { attachment1, attachment2 };
var response = extension.Fax().Post(new Fax.PostRequest
{
    to = new CallerInfo[] { new CallerInfo { phoneNumber = Config.Instance.receiver } }
}, attachments).Result;
```


## Binary data

#### Create/Update profile image

```cs
// create
var bytes = File.ReadAllBytes("test.png");
var response = extension.ProfileImage().Post(bytes, "test.png").Result;

// update
var bytes = File.ReadAllBytes("test.png");
var response = extension.ProfileImage().Put(bytes, "test.png").Result;
```

#### Get message content

```cs
var messages = extension.MessageStore().List().Result.records;

// sms
var message = messages.Where(m => m.type == "SMS" && m.attachments != null && m.attachments.Length > 0).First();
var bytes = extension.MessageStore(message.id).Content(message.attachments[0].id).Get().Result;
var content = System.Text.Encoding.UTF8.GetString(bytes);

// fax
message = messages.Where(m => m.type == "Fax" && m.attachments != null && m.attachments.Length > 0).First();
bytes = extension.MessageStore(message.id).Content(message.attachments[0].id).Get().Result;
File.WriteAllBytes("test.pdf", bytes);
```


#### Download call recording

```cs
var account = rc.Restapi().Account();

// List call Logs
var queryParams = new CallLog.ListQueryParams
{
    type = "Voice",
    view = "Detailed",
    dateFrom = DateTime.UtcNow.AddDays(-100).ToString("o"),
    withRecording = true,
    perPage = 10,
};
var callLogs = account.CallLog().List(queryParams).Result;

// download a call recording
var callLog = callLogs.records[0];
var bytes = account.Recording(callLog.recording.id).Content().Get().Result;
File.WriteAllBytes("test.wav", bytes);
```


## Exception handling

```cs
try
{
    ...
}
catch (AggregateException ae)
{
    ae.Handle((x) =>
    {
        if (x is FlurlHttpException) // This we know how to handle.
        {
			var fhe = x as FlurlHttpException;
            if (fhe.Call.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
			{
				Console.WriteLine("The resource doesn't exist");
				return true; // exception handled
			}
        }
        return false; // exception unhandled
    });
}
```


## ServiceInfo

There are two types of ServiceInfo: `.../account/~/service-info` and `.../meeting/service-info`.

```cs
// account service info
var account = rc.Restapi().Account();
var accountServiceInfo = account.ServiceInfo().Get<ServiceInfo.AccountServiceInfo>().Result;

// meeting service info
var meetingServiceInfo = extension.Meeting().ServiceInfo().Get<ServiceInfo.MeetingServiceInfo>().Result;
```


## Sample code

The [unit test project](https://github.com/tylerlong/ringcentral-csharp-client/tree/master/RingCentral.Test) contains lots of useful code snippets.
Such as this [test class](https://github.com/tylerlong/ringcentral-csharp-client/blob/master/RingCentral.Test/ContactTest.cs).


## Lisence

MIT
