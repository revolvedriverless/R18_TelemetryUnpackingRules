/*

Format:
{
    <ID> , data => {
        { "<NAME>", <Data unpacing function> },
        { "<ANOTHER_NAME>", <Another data unpacing function> }
    }
},

Available functions:
    hexToUint(string message)
    hexToInt(string message)
    getByte(string data, int index)
    Int(string message, int radix)
    All of Math lib

*/


{
     490 , data => {
        { "IMD_SHUTDOWN", Math.Sqrt(9) },
     }                       
},

{
     123 , data => {
        { "SINUS", 40*hexToFloat(data)+50 },
     }                       
},

{
     100 , data => {
        { "DISTANCE", Int(data) },
     }                       
},

{
     137 , data => {
        { "COSINUS", 40*hexToFloat(data) + 50 },
     }                       
},

{
    310 , data => {
        { "TPS_right", hexToUint(getByte(data, 0) + getByte(data, 1)) / 10.0 },
        { "TPS_left", hexToUint(getByte(data, 2) + getByte(data, 3)) / 10.0 }
     }        
},


