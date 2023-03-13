# M365 Health Check

Simple console application that provides the health report of all subscribed services for a tenant, using Microsoft Graph [ServiceHealth](https://learn.microsoft.com/en-us/graph/api/serviceannouncement-list-healthoverviews?view=graph-rest-1.0&tabs=http) APIs

## Minimal path to awesome

- Clone this repository
- Register your application on Azure Active Directory and grant the _ServiceHealth.Read.All_ permission
- Create _appsettings.json_ file in the root of your project like this:

      {
        "AppSettings": {
        "applicationId": <YOUR_APP_ID>
        }
      }

## Screenshot

![M365HealthCheck](screenshot.png)

![](M365HealthCheck.mp4)


https://user-images.githubusercontent.com/11175503/224684593-ecebaede-9f62-4f1a-a6e6-399241b21238.mp4

[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)
