/*

Format:
{
    <ID> , data => new Data {
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
     490 , data => new Data {
        { "IMD_SHUTDOWN", Math.Sqrt(9) },
     }                       
},

{
     123 , data => new Data {
        { "SINUS", hexToFloat(data) },
     }                       
},

{
     137 , data => new Data {
        { "SINUS", hexToFloat(data) },
     }                       
},

{
    310 , data => new Data {
        { "TPS_right", hexToUint(getByte(data, 0) + getByte(data, 1)) / 10.0 },
        { "TPS_left", hexToUint(getByte(data, 2) + getByte(data, 3)) / 10.0 }
     }        
},


