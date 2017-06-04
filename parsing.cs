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
	0x185 , data => new Data {
		{ "AMK_FL_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_FL_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_FL_Setpoint_positive_torque_limit", Int(data[4], data[5]) },
		{ "AMK_FL_Setpoint_negative_torque_limit", Int(data[6], data[7]) },
	}
},

{
	0x186 , data => new Data {
		{ "AMK_FR_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_FR_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_FR_Setpoint_positive_torque_limit", Int(data[4], data[5]) },
		{ "AMK_FR_Setpoint_negative_torque_limit", Int(data[6], data[7]) },
	}
},

{
	0x189 , data => new Data {
		{ "AMK_RL_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_RL_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_RL_Setpoint_positive_torque_limit", Int(data[4], data[5]) },
		{ "AMK_RL_Setpoint_negative_torque_limit", Int(data[6], data[7]) },
	}
},

{
	0x18A , data => new Data {
		{ "AMK_RR_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_RR_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_RR_Setpoint_positive_torque_limit", Int(data[4], data[5]) },
		{ "AMK_RR_Setpoint_negative_torque_limit", Int(data[6], data[7]) },
	}
},

{
	0x284 , data => new Data {
		{ "AMK_FL_Status_", Uint(data[1]) },
		{ "AMK_FL_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_FL_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_FL_Magnetizing_current", Int(data[6], data[7]) },

	}
},

{
	0x285 , data => new Data {
		{ "AMK_FR_Status", Uint(data[1]) },
		{ "AMK_FR_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_FR_Torque_current", (Int(data[4], data[5]))*1072/16384*100 },
		{ "AMK_FR_Magnetizing_current", Int(data[6], data[7]) },

	}
},

{
	0x288 , data => new Data {
		{ "AMK_RL_Status", Uint(data[1]) },
		{ "AMK_RL_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_RL_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_RL_Magnetizing_current", Int(data[6], data[7]) },

	}
},

{
	0x289 , data => new Data {
		{ "AMK_RR_Status", Uint(data[1]) },
		{ "AMK_RR_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_RR_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_RR_Magnetizing_current", Int(data[6], data[7]) },

	}
},

{
	0x290, data => new Data {
		{ "R17_State_speed", Int(data[2],data[3])},
		{ "R17_State_encoder_data",Int(data[4],data[5],data[6],data[7])},
		{ "R17_State_torque_request", Int(data[0], data[1])/100}
	}
},

{
	0x292, data => new Data {
		{ "R17_State_current_q", Int(data[0],data[1])/100},
		{ "R17_State_current_d",Int(data[2],data[3])/100},
		{ "R17_State_current_a", Int(data[4], data[5])/100},
		{ "R17_State_current_b", Int(data[6], data[7])/100},
	}
},

{
	0x293, data => new Data {
		{ "R17_STATUS_BITS_0-7",Int(data[0])},
		{ "R17_STATUS_BITS_7-15",Int(data[1])},
		{ "R17_STATUS_BITS_15-23",Int(data[2])},
		{ "R17_STATUS_BITS_24-31",Int(data[3])},
	}
},

{
	0x310 , data => new Data {
		{ "Sensor_TPS_right", Uint(data[0], data[1]) / 10.0 },
		{ "Sensor_TPS_left", Uint(data[2], data[3]) / 10.0 }
	}
},

{
	0x350 , data => new Data {
		{ "Dash_RTDS_requested", Uint(data[0]) },
	}
},

{
	0x359 , data => new Data {
		{ "Parameter_ID", Uint(data[0])},
		{ "Parameter_value", Float(data[4],data[5],data[6],data[7])},
	}
},

{
	0x450 , data => new Data {
		{ "Status_ECU_system_state", Uint(data[0],data[1]) },
		{ "Status_Torque_allocation", Uint(data[2]) },
		{ "Status_Vehicle_state", Uint(data[3]) },
	}

},

{
	0x459 , data => new Data {
		{"Sensor_POS_AX_INS", Int(data[0], data[1]) },
		{"Sensor_POS_AY_INS", Int(data[2], data[3]) },
		{"Sensor_POS_VX_INS", Int(data[4], data[5]) },
		{"Sensor_POS_VY_INS", Int(data[6], data[7]) }
	}
},


{
	0x45E , data => new Data {
		{ "Soft_BSPD_status", Uint(data[0]) },
	}
},

{
	0x4C0 , data => new Data {
		{ "Alive_message", Uint(data[0]) },
	}
},
