## Release a new package

Run all the tests and make sure there are no issues.

Update version number in `ringcentral.nuspec`.

Change to release mode and build it.

Go to root folder of this project, run:

```
nuget pack ringcentral.nuspec
```

Login nuget.org and upload.
