# Telemetry Unpacking Rules
Rules for parsing of telemetry data

### JSON format

    {
        "<ID>": {
            "<NAME_1>": {
                "type": "<Datatype>",
                "startbyte": "<Index of first byte in the data section of message>",
                "length": "<Length of this entry>",
                "factor": "<Factor this message is to be multiplied with>"
            },
            ...
            "<NAME_N>": {
                "type": "<Datatype>",
                "startbyte": "<Index of first byte in the data section of message>",
                "length": "<Length of this entry>",
                "factor": "<Factor this message is to be multiplied with>"
            }
        },
        ...
    }


### C# Format

```cs
{
    <ID> , data => {
        { "<NAME>", <Data unpacing function> },
        { "<ANOTHER_NAME>", <Another data unpacing function> }
    }
},
```

The unpacking function takes argument string data, in the form of a hex string of the data value sent from the telemetry module.

### Available functions

>hexToUint(string message)

>hexToInt(string message)

>getByte(string data, int index)

>Int(string message, int radix)

>All of Math lib

