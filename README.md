# Telemetry Unpacking Rules
Rules for parsing of telemetry data

# Format

```
{
    <ID> , data => {
        { "<NAME>", <Data unpacing function> },
        { "<ANOTHER_NAME>", <Another data unpacing function> }
    }
},
```

The unpacing function takes argument string data, its a hex string of the data value sendt from the telemetry module.

# Available functions

>hexToUint(string message)

>hexToInt(string message)

>getByte(string data, int index)

>Int(string message, int radix)

>All of Math lib

