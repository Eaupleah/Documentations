### C# VCard Creation from Random User API

```This project is designed to fetch user data from the Random User API and generate VCard (.vcf) files for each user based on the specified count.```

### Requirements:

[Newtonsoft.Json NuGet package](https://www.nuget.org/packages/newtonsoft.json/)

### Features:

```RequestApi Class: Contains methods to fetch user data from the Random User API based on user input. It validates the user count and throws a custom UserLimitException if the count exceeds 5000.```

```ExceptionHandling Class: Defines a custom exception (UserLimitException) for handling user limit exceeded scenarios when fetching data from the API.```

```VCardCreation Class: Provides methods to create VCard (.vcf) files using StringBuilder. It formats user information into VCard format and saves it to the desktop directory.```