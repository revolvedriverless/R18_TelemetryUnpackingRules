/*

Format:
{
    <ID> , data => List(
        Pair("<NAME>", <Data unpacing function>),
        Pair("<ANOTHER_NAME>", <Another data unpacing function>)
    )
},

Available functions:
hexToUint(string message)
hexToInt(string message)
getByte(string data, int index)
Int(string message, int radix)
All of Math lib

*/


{
    490 , data => List(
        Pair("IMD_SHUTDOWN", Math.Sqrt(9))
    )
},

{
    310 , data => List(
        Pair("TPS_right", hexToUint(getByte(data, 0) + getByte(data, 1)) / 10.0),
        Pair("TPS_left", hexToUint(getByte(data, 2) + getByte(data, 3)) / 10.0)
    )
},


