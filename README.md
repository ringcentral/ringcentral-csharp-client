# ringcentral-cs-client

RingCentral C# client.

This is just a proof of concept release, please don't use it in production (yet)!


## Authorization management

Token is refreshed automatically by background timer, the same as how we keep PubNub subscription alive.

I made this change because I don't think we should refresh RingCentral token and PubNub subscription differently.


## URL Builder

```cs
var rc = new RestClient("appKey", "appSecret"); // you can use fake key and secret if you don't talk to api server.
var account = rc.Restapi().Account();
var extension = account.Extension();
account.CallLog().Endpoint(); // "/restapi/v1.0/account/~/call-log"
extension.CallLog("123456").Endpoint(); // "/restapi/v1.0/account/~/extension/~/call-log/123456"
extension.CallLog("123456").Url(); // "https://platform.devtest.ringcentral.com/restapi/v1.0/account/~/extension/~/call-log/123456"
```

Or you can specify all of the IDs explicitly:

```cs
rc.Restapi("v1.0").Account("~").Extension("12345678").CallLog("87654321").Endpoint(); // "/restapi/v1.0/account/~/extension/12345678/call-log/87654321"
```

Let's compare it with the traditional solution:

```cs
var apiVersion = "v1.0";
var accountId = "~";
var extensionId = "12345678";
var callLogId = "87654321";
var endpoint = "/restapi" + apiVersion + "/account" + accountId + "/extension" + extensionId + "/call-log" + callLogId;
```

Too many hard-coded strings, too much string concatenation. It is prone to make typos and hard to read/maintain.


## Async by default

Http requests are async by default:

```cs
var response = await rc.Get(endpoint);
var country = await rc.Restapi().Dictionary().Country("46").Get();
```

And you can change them to sync easily:

```cs
var response = rc.Get(endpoint).Result;
var country = rc.Restapi().Dictionary().Country("46").Get().Result;
```


## Http Request sample

Get extension list:

```cs
var rc = new RestClient("appKey", "appSecret");
var endpoint = rc.Restapi().Account().Extension().Endpoint(); // /restapi/v1.0/account/~/extension/~
var response = rc.Get(endpoint).Result;
var json = response.Content.ReadAsStringAsync().Result;
```

## Models

This is **almost** ready. Some rare cases are not working yet.

Following code snippets are equivalent:

##### Traditional solution:

```cs
var endpoint = "/restapi/v1.0/dictionary/timezone/6"; // hard code string
var response = rc.Get(endpoint).Result; // make http request
var json = response.Content.ReadAsStringAsync().Result; // get response json
var timezone = JsonConvert.DeserializeObject<Timezone.GetResponse>(json); // convert json to model
```

##### URL Builder + generics programming:

```cs
var endpoint = rc.Restapi().Dictionary().Timezone("6").Endpoint();
var timezone = rc.Get<Timezone.GetResponse>(endpoint).Result;
```

##### Most intuitive:

```cs
var timezone = rc.Restapi().Dictionary().Timezone("6").Get().Result; // This is the shortest solution.
```


## To be done

- sending fax