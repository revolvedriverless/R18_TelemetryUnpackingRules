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
     185 , data => {
        { "SETPOINT_STATE_FL", Uint(data[1] },
     }
},

{
     490 , data => {
        { "IMD_SHUTDOWN", Math.Sqrt(9) },
     }
},

{
     123 , data => {
        { "NUM", Int(data[3], data[2]) },
     }
},

{
     100 , data => {
        { "DISTANCE", Int(data) },
     }
},

{
     122 , data => {
        { "POT", Uint(data, true) / 12.0 },
     }
},

{
     137 , data => {
        { "COSINUS", 40*Float(data) + 50 },
     }
},

{
    310 , data => {
        { "TPS_right", Uint(data[0], data[1]) / 10.0 },
        { "TPS_left", Uint(data[2], data[3]) / 10.0 }
     }
},

