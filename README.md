# restConsumptionMagic
A repo to go along with the code along

Tutorial that inspired much of the Java solution: https://www.baeldung.com/java-http-request

You'll need to add your own DevSettings file or the tests will not work:

DevSettings.cs
```
public static class DevSettings
{
    public static string ApiKey = "{yourMapBoxKey}";
}
```

DevSettings.java
```
public final class DevSettings {
    public static final String ApiKey = "{yourMapBoxKey}";
}
```