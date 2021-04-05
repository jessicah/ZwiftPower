Zwift Power Service
===================

Provides an API for querying the ZwiftPower APIs.

The following secrets are required for interacting with endpoints
that require authentication:

- zwiftpowerUsername
- zwiftpowerPassword

When using dependency injection, the `AddHttpClient` extension
method should be used to configure the `HttpClient`:

```
services.AddHttpClient<ZwiftPowerService>(client =>
{
	client.BaseAddress = new Uri("https://www.zwiftpower.com/");
}).ConfigurePrimaryHttpMessageHandler(() =>
{
	return new HttpClientHandler()
	{
		CookieContainer = new System.Net.CookieContainer(),
		UseCookies = true
	};
});
```
