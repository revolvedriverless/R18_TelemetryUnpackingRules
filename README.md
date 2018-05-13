# Telemetry Unpacking Rules
This repository contains three files for parsing:
- Parserules.json: Rules for the parsing of telemetry data in Analyze
- Error_rules_parsing.json: Rules for channels that send errorflags to be parsed in the ErrorLogger plugin in Analyze
- Canstructure.txt: Grouping of channels for CanReader

### JSON format for parserules

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
