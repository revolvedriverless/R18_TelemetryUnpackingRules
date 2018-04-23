# Telemetry Unpacking Rules
Rules for parsing of telemetry data

### JSON format

    {
        "<ID>": {
            "<NAME_1>": {
                "type": "<Datatype>",
                "startbyte": <Index of first byte in the data section of message>,
                "length": <Length of this entry>,
                "factor": <Factor this message is to be multiplied with>,
                "displayname": "<A more user-friendly name (used in LiveDash)",
                "unit": "<The SI unit or another fitting unit (could be %)>",
                "expectedmin": <The expected minimum value of the data sent>,
                "expectedmax": <The expected maximum value of the data sent>
            },
            ...
            "<NAME_N>": {
                "type": "<Datatype>",
                "startbyte": <Index of first byte in the data section of message>,
                "length": <Length of this entry>,
                "factor": <Factor this message is to be multiplied with>,
                "displayname": "<A more user-friendly name (used in LiveDash)",
                "unit": "<The SI unit or another fitting unit (could be %)>",
                "expectedmin": <The expected minimum value of the data sent>,
                "expectedmax": <The expected maximum value of the data sent>
            }
        },
        ...
    }

<s>
    
### C# Format
    
```cs
{
    <ID> , data => {
        { "<NAME>", <Data unpacing function> },
        { "<ANOTHER_NAME>", <Another data unpacing function> }
    }
},
```

</s>
The unpacking function takes argument string data, in the form of a hex string of the data value sent from the telemetry module.

<s>
    
### Available functions

>hexToUint(string message)

>hexToInt(string message)

>getByte(string data, int index)

>Int(string message, int radix)

>All of Math lib

</s>

