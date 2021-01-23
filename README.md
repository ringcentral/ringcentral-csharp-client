# ringcentral-csharp-client

[![Build status](https://travis-ci.org/ringcentral/ringcentral-csharp-client.svg?branch=master)](https://travis-ci.org/ringcentral/ringcentral-csharp-client)
[![Coverage Status](https://coveralls.io/repos/github/ringcentral/ringcentral-csharp-client/badge.svg?branch=master&t=20160812)](https://coveralls.io/github/ringcentral/ringcentral-csharp-client?branch=master)
[![NuGet Version](https://img.shields.io/nuget/v/RingCentral.Client.svg)](https://www.nuget.org/packages/RingCentral.Client/)
[![Chat](https://img.shields.io/badge/chat-on%20glip-orange.svg)](https://glipped.herokuapp.com/)
[![Twitter](https://img.shields.io/twitter/follow/ringcentraldevs.svg?style=social&label=follow)](https://twitter.com/RingCentralDevs)


---

# RingCentral.Net

[RingCentral.Net](https://github.com/ringcentral/ringcentral.net) is the successor of this project.
All users are recommended to use [RingCentral.Net](https://github.com/ringcentral/ringcentral.net) instead.

## Reference

- [RingCentral.Net on NuGet](https://www.nuget.org/packages/RingCentral.Net/)
- Article: [Announcing the New RingCentral SDK for .NET](https://medium.com/ringcentral-developers/new-ringcentral-sdk-for-net-a43417b2538c)
- Article: [RingCentral SDK for .NET Upgrade Guide](https://medium.com/ringcentral-developers/ringcentral-sdk-for-net-upgrade-guide-8ead6bcdaf99)

---


__[RingCentral Developers](https://developer.ringcentral.com/api-products)__ is a cloud communications platform which can be accessed via more than 70 APIs. The platform's main capabilities include technologies that enable:
__[Voice](https://developer.ringcentral.com/api-products/voice), [SMS/MMS](https://developer.ringcentral.com/api-products/sms), [Fax](https://developer.ringcentral.com/api-products/fax), [Glip Team Messaging](https://developer.ringcentral.com/api-products/team-messaging), [Data and Configurations](https://developer.ringcentral.com/api-products/configuration)__.

[API Reference](https://developer.ringcentral.com/api-docs/latest/index.html) and [APIs Explorer](https://developer.ringcentral.com/api-explorer/latest/index.html).

RingCentral C# client.

**Notice:** any issues or questions, please do let me know by [creating an issue](https://github.com/ringcentral/ringcentral-csharp-client/issues/new).

Feel free to :star: and :fork_and_knife: this repository.


## Video tutorial

[Setup project, authorization and sending fax](https://www.youtube.com/watch?v=lECKMrX_Dgw)

Deprecated: [Work with .NET 4.5 & WebForm](https://www.youtube.com/watch?v=0RjYTCDpn3A) You should not use legacy .NET versions. But if you have to, please watch the video.


## Installation

```powershell
Install-Package RingCentral.Client
```


## API Reference

[RingCentral API Reference](https://developer.ringcentral.com/api-docs/latest/index.html#!#APIReference.html) is where you can find all the endpoints, requests, parameters and all kinds of necessary details.

Please note: as a guest reader, you can only read the basic version of API Reference. Please do login if you want to get information about Advanced API endpoints.


## Initialization

```cs
using RingCentral;

rc = new RestClient("clientId", "clientSecret");
```

By default the clients talk to sandbox server. If you want production server:

```cs
rc = new RestClient("clientId", "clientSecret", true);
```

Or you can specify the server url explicitly:

```cs
rc = new RestClient("clientId", "clientSecret", "https://platform.devtest.ringcentral.com");
```


## Authorization

```cs
await rc.Authorize("username", "extension", "password");
```

If you use direct number as username, leave extension empty.


### Auto refresh

By default, there is a background timer calling `rc.Refresh()` periodically, so the authorization never expires.

But if you would like to call `Refresh` manually:

```cs
rc.AutoRefreshToken = false;
```


### Token Revoke

When you no longer need a token, don't forget to revoke it: `rc.Revoke()`.


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
var response = await extension.Fax().Post(requestBody, attachments);
```

To create the `requestBody` object, you can define it as following:

```cs
var requestBody = new FaxPath.PostParameters
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
var callLogs = await extension.CallLog().List(new CallLog.ListParameters { direction = "Inbound" });
```

All the HTTP calls are by default async, so you should use the `await` keyword of C#.


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
var response = await rc.Get(endpoint); // make http request
var statusCode = response.StatusCode; // check status code
var str = await response.Content.ReadAsStringAsync(); // get response string
```


## Subscription

[Sample code](./RingCentral.Test/SubscripotionTest.cs)

The subscription will renew itself automatically before it expires. In rare cases you might need to renew it manually:

```cs
await subscription.Renew();
```


## Send Fax

[Sample code](./RingCentral.Test/FaxTest.cs)


## Send MMS

MMS and SMS share the same API endpoint. You can deem MMS as SMS with attachments

[Sample code](./RingCentral.Test/MMSTest.cs)


## Binary data

#### Create/Update profile image

#### Get message content

#### Download call recording

[Sample code](./RingCentral.Test/BinaryTest.cs)


## Exception handling

```cs
try
{
    await ...
}
catch (FlurlHttpException fhe)
{
    string errorMessage = fhe.GetResponseString();
    Console.WriteLine(errorMessage);
    if (fhe.Call.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
        Console.WriteLine("The resource doesn't exist");
    }
}
```


## Events

- `RestClient` class has EventHandler `TokenRefreshed`, so that every time token refreshed you can get a notification
    - [Sample code](https://github.com/ringcentral/ringcentral-csharp-client/blob/master/RingCentral.Test/EventsTest.cs)
- `RestClient` class has EventHandler `AfterHttpCall`, so that after every HTTP call you can a notification
    - [Sample code](https://github.com/ringcentral/ringcentral-csharp-client/blob/master/RingCentral.Test/AfterCallTest.cs)


## Sample code

The [unit test project](https://github.com/ringcentral/ringcentral-csharp-client/tree/master/RingCentral.Test) contains lots of useful code snippets.
Such as this [test class](https://github.com/ringcentral/ringcentral-csharp-client/blob/master/RingCentral.Test/ContactTest.cs).


## License

MIT


## Common issues

### You must add a reference to assembly netstandard

Ref: https://github.com/dotnet/standard/issues/542
