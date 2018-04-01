/*

Format:
{
	<ID> , data => {
		{ "<NAME>", <Data unpacking function> },
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
	0x010 , data => new Data {
		{ "Simian_dataLogger_playback_Ia", Int(data[0], data[1]) / 100 },
		{ "Simian_dataLogger_playback_Ib", Int(data[2], data[3]) / 100 }
	}
},

{   
	0x011 , data => new Data {
		{ "Simian_dataLogger_playback_Id", Int(data[0], data[1]) / 100 },
		{ "Simian_dataLogger_playback_Iq", Int(data[2], data[3]) / 100 },
		{ "Simian_dataLogger_playback_rpm", Int(data[4], data[5]) }
	}
},

{   
	0x012 , data => new Data {
		{ "Simian_dataLogger_playback_encoder_pos", Uint(data[0], data[1], data[2], data[3]) }
	}
},

{   
	0x013 , data => new Data {
		{ "Simian_dataLogger_playback_encoder_raw", Uint(data[0], data[1], data[2], data[3]) }
	}
},

{
	0x185 , data => new Data {
		{ "AMK_FL_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_FL_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_FL_Setpoint_positive_torque_limit", Int(data[4], data[5])*0.0098 },//convert from 0.1% of nominal motor torque (9.8) to Nm
		{ "AMK_FL_Setpoint_negative_torque_limit", Int(data[6], data[7])*0.0098 }
	}
},

{
	0x186 , data => new Data {
		{ "AMK_FR_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_FR_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_FR_Setpoint_positive_torque_limit", Int(data[4], data[5])*0.0098 },
		{ "AMK_FR_Setpoint_negative_torque_limit", Int(data[6], data[7])*0.0098 }
	}
},

{
	0x189 , data => new Data {
		{ "AMK_RL_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_RL_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_RL_Setpoint_positive_torque_limit", Int(data[4], data[5])*0.0098 },
		{ "AMK_RL_Setpoint_negative_torque_limit", Int(data[6], data[7])*0.0098 }
	}
},

{
	0x18A , data => new Data {
		{ "AMK_RR_Setpoint_control_word", Uint(data[1]) },
		{ "AMK_RR_Setpoint_RPM_request", Int(data[2], data[3]) },
		{ "AMK_RR_Setpoint_positive_torque_limit", Int(data[4], data[5])*0.0098 },
		{ "AMK_RR_Setpoint_negative_torque_limit", Int(data[6], data[7])*0.0098 }
	}
},

{   
	0x200 , data => new Data {
		{ "Simian_current_a",         Int(data[0], data[1]) / 10 },
		{ "Simian_current_b",         Int(data[2], data[3]) / 10 },
		{ "Simian_current_c",     -(Int(data[0], data[1]) + Int(data[2], data[3])) / 10},
		{ "Simian_current_d",         Int(data[4], data[5]) / 10 },
		{ "Simian_current_q",         Int(data[6], data[7]) / 10 }
	}
},

{   
	0x201 , data => new Data {
		{ "Simian_current_dc",        Int(data[0], data[1]) / 10 },
		{ "Simian_voltage_dc",        Int(data[2], data[3]) / 10 }
	}
},

{   
	0x202 , data => new Data {
		{ "Simian_speed_rpm",         Int(data[0], data[1]) },
		{ "Simian_speed_max_rpm",     Int(data[2], data[3]) },
		{ "Simian_speed_min_rpm",     Int(data[4], data[5]) }
	}
},

{   
	0x203 , data => new Data {
		{ "Simian_current_a_rms",     Int(data[0], data[1]) / 10 },
		{ "Simian_current_b_rms",     Int(data[2], data[3]) / 10 }
	}
},

{
	0x284 , data => new Data {
		{ "AMK_FL_Status_", Uint(data[1]) },
		{ "AMK_FL_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_FL_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_FL_Magnetizing_current", Int(data[6], data[7])*1072/16384*100 }
	}
},

{
	0x285 , data => new Data {
		{ "AMK_FR_Status", Uint(data[1]) },
		{ "AMK_FR_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_FR_Torque_current", (Int(data[4], data[5]))*1072/16384*100 },
		{ "AMK_FR_Magnetizing_current", Int(data[6], data[7])*1072/16384*100 }
	}
},

{
	0x286 , data => new Data {
		{ "AMK_FL_Temp_Motor", Uint(data[0],data[1])/10 },
		{ "AMK_FL_Temp_Inverter", Int(data[2], data[3])/10 },
		{ "AMK_FL_Error_Info", (Int(data[4],data[5])) },
		{ "AMK_FL_Temp_IGBT", Int(data[6], data[7])/10}
	}
},

{
	0x287 , data => new Data {
		{ "AMK_FR_Temp_Motor", Uint(data[0],data[1])/10 },
		{ "AMK_FR_Temp_Inverter", Int(data[2], data[3])/10 },
		{ "AMK_FR_Error_Info", (Int(data[4],data[5])) },
		{ "AMK_FR_Temp_IGBT", Int(data[6], data[7])/10 }
	}
},

{
	0x288 , data => new Data {
		{ "AMK_RL_Status", Uint(data[1]) },
		{ "AMK_RL_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_RL_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_RL_Magnetizing_current", Int(data[6], data[7])*1072/16384*100 }
	}
},

{
	0x289 , data => new Data {
		{ "AMK_RR_Status", Uint(data[1]) },
		{ "AMK_RR_Actual_velocity", Int(data[2], data[3]) },
		{ "AMK_RR_Torque_current", Int(data[4], data[5])*1072/16384*100 },
		{ "AMK_RR_Magnetizing_current", Int(data[6], data[7])*1072/16384*100 }
	}
},

{
	0x28A , data => new Data {
		{ "AMK_RL_Temp_Motor", Uint(data[0],data[1])/10 },
		{ "AMK_RL_Temp_Inverter", Int(data[2], data[3])/10 },
		{ "AMK_RL_Error_Info", (Int(data[4],data[5])) },
		{ "AMK_RL_Temp_IGBT", Int(data[6], data[7])/10 }
	}
},

{
	0x28B , data => new Data {
		{ "AMK_RR_Temp_Motor", Uint(data[0],data[1])/10 },
		{ "AMK_RR_Temp_Inverter", Int(data[2], data[3])/10 },
		{ "AMK_RR_Error_Info", (Int(data[4],data[5])) },
		{ "AMK_RR_Temp_IGBT", Int(data[6], data[7])/10 }
	}
},

{   
	0x290 , data => new Data {
		{ "Simian_encoder_pos",   Uint(data[0], data[1], data[2], data[3]) }
	}
},

{   
	0x294 , data => new Data {
		{ "Simian_voltage_d",         Int(data[0], data[1]) / 10 },
		{ "Simian_voltage_q",         Int(data[2], data[3]) / 10 },
		{ "Simian_voltage_a",         Int(data[4], data[5]) / 10 },
		{ "Simian_voltage_b",         Int(data[6], data[7]) / 10 }
	}
},

{
	0x295 , data => new Data {
		{ "Simian_torque_request",    Int(data[0], data[1]) / 100 }
	}
},

{	0x350 , data => new Data {{"VCU_PLAY_RTDS", Uint(data[0])}}},
{	0x351 , data => new Data {{"VCU_DRIVE_ENABLE", Uint(data[0])}}},
{	0x352 , data => new Data {{"VCU_DRIVE_DISABLE", Uint(data[0])}}},
{	0x353 , data => new Data {{"VCU_RESET_AMK_INVERTER_ERROR", Uint(data[0])}}},

{
	0x358 , data => new Data {
		{ "INS_GPStime_year", 	Uint(data[0]) },
		{ "INS_GPStime_month", 	Uint(data[1]) },
		{ "INS_GPStime_day", 	Uint(data[2]) },
		{ "INS_GPStime_hour",	Uint(data[3]) },
		{ "INS_GPStime_min", 	Uint(data[4]) },
		{ "INS_GPStime_sec", 	Uint(data[5]) }
	}
},

{
	0x35C , data => new Data {
		{ "VCU_System_Status", Uint(data[0])},
		{ "VCU_Torque_Allocation",Uint(data[2])},
		{ "VCU_Vehicle_State", Uint(data[3])}
	}
},

{
	0x359 , data => new Data {
		{ "VCU_Parameter_ID", Uint(data[0])},
		{ "VCU_Parameter_value", Float(data[4], data[5], data[6], data[7])},
	}
},

{
	0x401 , data => new Data {
		{ "SBS_F1_TPS_1", Uint(data[0], data[1])*0.01},
		{ "SBS_F1_TPS_2", Uint(data[2], data[3])*0.01},
		{ "SBS_F1_Brake_pressure_1", Uint(data[4], data[5])*0.01},
		{ "SBS_F1_Brake_pressure_2", Uint(data[4], data[5])*0.01}
	}
},

{
	0x402 , data => new Data {
		{ "SBS_F1_KERS_pos", Uint(data[0], data[1])*0.01},
		{ "SBS_F1_Steering_angle", Uint(data[2], data[3])*0.01},
		{ "SBS_F1_Steering_speed", Uint(data[4], data[5])*0.01}
	}
},

{
	0x411 , data => new Data {
		{ "SBS_F2_Damper_pos_FL", Uint(data[0], data[1])*0.01},
		{ "SBS_F2_Damper_rate_FL", Int(data[2], data[3])*0.1},
		{ "SBS_F2_Damper_pos_FR", Uint(data[4], data[5])*0.01},
		{ "SBS_F2_Damper_rate_FR", Int(data[6], data[7])*0.1}
	}
},

{
	0x412 , data => new Data {
		{ "SBS_F2_acc_upright_FL", Int(data[0], data[1])*0.01},
		{ "SBS_F2_acc_upright_FR", Int(data[2], data[3])*0.01},
		{ "SBS_F2_temp_gear_FL", Int(data[4], data[5])*0.01},
		{ "SBS_F2_temp_gear_FR", Int(data[6], data[7])*0.01}
	}
},

{
	0x421 , data => new Data {
		{ "SBS_R1_Damper_pos_RL", Int(data[0], data[1])*0.01},
		{ "SBS_R1_Damper_rate_RL", Int(data[2], data[3])*0.1},
		{ "SBS_R1_Damper_pos_RR", Int(data[4], data[5])*0.01},
		{ "SBS_R1_Damper_rate_RR", Int(data[6], data[7])*0.1}
	}
},

{
	0x422 , data => new Data {
		{ "SBS_R1_acc_upright_RL", Int(data[0], data[1])*0.01},
		{ "SBS_R1_acc_upright_RR", Int(data[2], data[3])*0.01},
		{ "SBS_R1_temp_gear_RL", Int(data[4], data[5])*0.01},
		{ "SBS_R1_temp_gear_RR", Int(data[6], data[7])*0.01}
	}
},

{
	0x422 , data => new Data {
		{ "SBS_R2_temp_cooling_high_L", Int(data[0], data[1])*0.01},
		{ "SBS_R2_temp_cooling_low_L", Int(data[2], data[3])*0.01},
		{ "SBS_R2_temp_cooling_high_R", Int(data[4], data[5])*0.01},
		{ "SBS_R2_temp_cooling_low_R", Int(data[6], data[7])*0.01}
	}
},

{	0x428 , data => new Data {{"Charger_Data", Uint(data[0])}}},
{	0x429 , data => new Data {{"Charger_Acknowledge", Uint(data[0])}}},
{	0x317 , data => new Data {{"Charger_Error", Uint(data[0], data[1], data[2], data[3])}}},
{
	0x430 , data => new Data {
		{"INS_status_attitude"   , Uint(data[0], data[1])},
		{"INS_status" 	, Uint(data[2])}
	}
},

{
	0x431 , data => new Data {
		{"INS_GPS_fix_1"   , Uint(data[0])},
		{"ISN_GPS_tracked_satellites" 	, Uint(data[1])}
	}
},

{
	0x432 , data => new Data {
		{"INS_Vx"   , Int(data[0], data[1])/100},
		{"INS_Vy" 	, Int(data[2], data[3])/100},
		{"INS_Vz"   , Int(data[4], data[5])/100}
	}
},

{
	0x433 , data => new Data {
		{"INS_Ax"   , Int(data[0], data[1])/100},
		{"INS_Ay" 	, Int(data[2], data[3])/100},
		{"INS_Az"   , Int(data[4], data[5])/100}
	}
},

{
	0x434 , data => new Data {
		{"INS_Roll_rate"   , Int(data[0], data[1])/100},
		{"INS_Pitch_rate" 	, Int(data[2], data[3])/100},
		{"INS_Yaw_rate"    , Int(data[4], data[5])/100}
	}
},

{
	0x435 , data => new Data {
		{"INS_Roll_angle"   , Int(data[0], data[1])/100},
		{"INS_Pitch_angle" 	, Int(data[2], data[3])/100},
		{"INS_Yaw_angle"    , Int(data[4], data[5])/100}
	}
},

{
	0x436 , data => new Data {
		{"INS_Longitude",	Float(data[0], data[1],data[2], data[3]) },
		{"INS_Latitude", 	Float(data[4], data[5],data[6], data[7]) }
	}
},

{
	0x437 , data => new Data {
		{"INS_Altitude",	Float(data[0], data[1],data[2], data[3]) },
	}
},

{
	0x438 , data => new Data {
		{"INS_Roll_acc"     , Int(data[0], data[1])*0.01},
		{"INS_Pitch_acc" 	, Int(data[2], data[3])*0.01},
		{"INS_Yaw_acc"      , Int(data[4], data[5])*0.01}
	}
},

{
	0x440 , data => new Data {
		{"BMS_Max_Cell_Voltage"     , Uint(data[0], data[1])/10000},
		{"BMS_Average_Cell_Voltage" , Uint(data[2], data[3])/10000},
		{"BMS_Min_Cell_Voltage"     , Uint(data[4], data[5])/10000},
		{"BMS_Max_Voltage_ID"       , Uint(data[6])},
		{"BMS_Min_Voltage_ID"       , Uint(data[7])}
	}
},

{
	0x441 , data => new Data {
		{"BMS_Max_Cell_Temperature"     , Uint(data[0], data[1])/10},
		{"BMS_Average_Cell_Temperature" , Uint(data[2], data[3])/10},
		{"BMS_Min_Cell_Temperature"     , Uint(data[4], data[5])/10},
		{"BMS_Max_Temperature_ID"       , Uint(data[6])},
		{"BMS_Min_Temperature_ID"       , Uint(data[7])}
	}
},

{
	0x442 , data => new Data {
		{"BMS_Tractive_System_Voltage"              , Uint(data[0], data[1])/10},
		{"BMS_Tractive_System_Current"              , Int(data[2], data[3])/10},
		{"BMS_Tractive_System_Current_Transient"    , Int(data[4], data[5])/10},
		{"BMS_State_of_Charge"                      , Uint(data[6], data[7])/100}
	}
},

{	0x443 , data => new Data {{"BMS_Error_Flags", Uint(data[0], data[1])}}},
{	0x444 , data => new Data {{"BMS_State", Uint(data[0])}}},

{
	0x445 , data => new Data {
		{"BMS_Tractive_System_Power"                , Int(data[0], data[1])*10},
		{"BMS_Voltage_Sum_of_Cells"                 , Int(data[2], data[3])/10}
	}
},

{
		0x44A , data => new Data {
		{ "BMS_max_isoSPI_fails", Uint(data[0]) },
		{ "BMS_max_isoSPI_fails_Slave_ID", Uint(data[1]) },
		{ "BMS_max_isoSPI_fails_Register_ID", Uint(data[2]) }
	}
},

{
	0x451 , data => new Data {
		{ "VCU_Fz_est_FL", Uint(data[0], data[1])*0.1 },
		{ "VCU_Fz_est_FR", Uint(data[2], data[3])*0.1 },
		{ "VCU_Fz_est_RL", Uint(data[4], data[5])*0.1 },
		{ "VCU_Fz_est_RR", Uint(data[6], data[7])*0.1 },
	}
},

{
	0x452 , data => new Data {
		{"VCU_Fz_damper_est_FL", Uint(data[0], data[1])*0.1 },
		{"VCU_Fz_damper_est_FR", Uint(data[2], data[3])*0.1 },
		{"VCU_Fz_damper_est_RL", Uint(data[4], data[5])*0.1 },
		{"VCU_Fz_damper_est_RR", Uint(data[6], data[7])*0.1 }
	}
},

{
	0x453 , data => new Data {
		{"VCU_Fz_ekf_est_FL", Uint(data[0], data[1])*0.1 },
		{"VCU_Fz_ekf_est_FR", Uint(data[2], data[3])*0.1 },
		{"VCU_Fz_ekf_est_RL", Uint(data[4], data[5])*0.1 },
		{"VCU_Fz_ekf_est_RR", Uint(data[6], data[7])*0.1 }
	}
},

{
	0x454 , data => new Data {
		{"VCU_Fz_ekf_est_FL", Uint(data[0], data[1])*0.1 },
		{"VCU_Fz_ekf_est_FR", Uint(data[2], data[3])*0.1 },
		{"VCU_Fz_ekf_est_RL", Uint(data[4], data[5])*0.1 },
		{"VCU_Fz_ekf_est_RR", Uint(data[6], data[7])*0.1 }
	}
},

{
	0x455 , data => new Data {
		{"VCU_R_eff_FL", Uint(data[0], data[1])*0.00001 },
		{"VCU_R_eff_FR", Uint(data[2], data[3])*0.00001 },
		{"VCU_R_eff_RL", Uint(data[4], data[5])*0.00001 },
		{"VCU_R_eff_RR", Uint(data[6], data[7])*0.00001 }
	}
},

{
	0x456 , data => new Data {
		{"VCU_Fx_est_FL", Int(data[0], data[1])*0.1 },
		{"VCU_Fx_est_FR", Int(data[2], data[3])*0.1 },
		{"VCU_Fx_est_RL", Int(data[4], data[5])*0.1 },
		{"VCU_Fx_est_RR", Int(data[6], data[7])*0.1 }
	}
},

{
	0x457 , data => new Data {
		{"VCU_Slip_Ratio_FL", Int(data[0], data[1])*0.001 },
		{"VCU_Slip_Ratio_FR", Int(data[2], data[3])*0.001 },
		{"VCU_Slip_Ratio_RL", Int(data[4], data[5])*0.001 },
		{"VCU_Slip_Ratio_RR", Int(data[6], data[7])*0.001 }
	}
},

{
	0x458 , data => new Data {
		{"VCU_Slip_Angle_FL", Int(data[0], data[1])*0.001 },
		{"VCU_Slip_Angle_FR", Int(data[2], data[3])*0.001 },
		{"VCU_Slip_Angle_RL", Int(data[4], data[5])*0.001 },
		{"VCU_Slip_Angle_RR", Int(data[6], data[7])*0.001 }
	}
},

{
	0x459 , data => new Data {
		{"VCU_RPM_der_FL", Int(data[0], data[1])*10 },
		{"VCU_RPM_der_FR", Int(data[2], data[3])*10 },
		{"VCU_RPM_der_RL", Int(data[4], data[5])*10 },
		{"VCU_RPM_der_RR", Int(data[6], data[7])*10 }
	}
},

{
	0x45A , data => new Data {
		{"VCU_steering_angle", Int(data[0], data[1])*0.001 },
		{"VCU_steering_speed", Int(data[2], data[3])*0.01 }
	}
},

{
	0x45B , data => new Data {
		{"VCU_alfa_r", Int(data[0], data[1])*0.001 }
	}
},

{
	0x460 , data => new Data {
		{"GLV_Cell_Voltage_0", Uint(data[0], data[1])*0.0001},
		{"GLV_Cell_Voltage_1", Uint(data[2], data[3])*0.0001},
		{"GLV_Cell_Voltage_2", Uint(data[4], data[5])*0.0001},
		{"GLV_Cell_Voltage_3", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x461 , data => new Data {
		{"GLV_Cell_Voltage_4", Uint(data[0], data[1])*0.0001},
		{"GLV_Cell_Voltage_5", Uint(data[2], data[3])*0.0001}
	}
},

{
	0x462 , data => new Data {
		{"GLV_Cell_Temperature_0", Uint(data[0], data[1])*0.01},
		{"GLV_Cell_Temperature_1", Uint(data[2], data[3])*0.01},
		{"GLV_Cell_Temperature_2", Uint(data[4], data[5])*0.01},
		{"GLV_Cell_Temperature_3", Uint(data[6], data[7])*0.01}
	}
},

{	0x463 , data => new Data {{"GLV_Cell_Temperature_4", Uint(data[0], data[1])*0.01}}},

{
	0x465 , data => new Data {
		{"GLV_Min_Cell_Voltage", Uint(data[0], data[1])*0.0001},
		{"GLV_Max_Cell_Voltage", Uint(data[2], data[3])*0.0001},
		{"GLV_Tot_Cell_Voltage", Uint(data[4], data[5], data[6], data[7])*0.0001}
	}
},

{
	0x466 , data => new Data {
		{"GLV_Min_Cell_Temperature", Uint(data[0], data[1])*0.01},
		{"GLV_Max_Cell_Temperature", Uint(data[2], data[3])*0.01},
		//{"Reserved: GLV_Cell_Balancing", Uint(data[4], data[5])*0.01},
		//{"Reserved: GLV_Current", Uint(data[6], data[7])*0.001}
	}
},

{
	0x467 , data => new Data {
		{"GLV_State_of_Charge", Uint(data[0])},
		{"GLV_Battery_Charge_Capacity", Uint(data[1], data[2], data[3], data[4])*0.001}
	}
},

//{   0x468 , data => new Data {{"Reserved: GLV_State", Uint(data[0], data[1])}}},

{	0x470 , data => new Data {{ "DASH_REQUEST_DRIVE_ENABLE", 	Uint(data[0])}}},
{	0x472 , data => new Data {{ "DASH_RTDS_FINISHED",        	Uint(data[0])}}},
{	0x475 , data => new Data {{ "DASH_REQUEST_KERS_ACTIVATION", Uint(data[0])}}},
{	0x47F , data => new Data {{ "DASH_ALIVE_STATUS_BITS", 	Uint(data[0], data[1])}}},

{	0x490 , data => new Data {{ "BMS_IMD_Shutdown_open", 	Uint(data[0])}}},
{	0x491 , data => new Data {{ "BMS_IMD_State", 		Uint(data[0])}}},

{	0x4C0 , data => new Data {{ "Alive_message", 		Uint(data[0])}}},

{
	0x500 , data => new Data {
		{"BMS_Cell_Voltage_0", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_1", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_2", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_3", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x501 , data => new Data {
		{"BMS_Cell_Voltage_4", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_5", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_6", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_7", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x502 , data => new Data {
		{"BMS_Cell_Voltage_8" , Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_9" , Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_10", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_11", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x503 , data => new Data {
		{"BMS_Cell_Voltage_12", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_13", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_14", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_15", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x504 , data => new Data {
		{"BMS_Cell_Voltage_16", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_17", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_18", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_19", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x505 , data => new Data {
		{"BMS_Cell_Voltage_20", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_21", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_22", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_23", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x506 , data => new Data {
		{"BMS_Cell_Voltage_24", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_25", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_26", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_27", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x507 , data => new Data {
		{"BMS_Cell_Voltage_28", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_29", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_30", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_31", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x508 , data => new Data {
		{"BMS_Cell_Voltage_32", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_33", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_34", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_35", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x509 , data => new Data {
		{"BMS_Cell_Voltage_36", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_37", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_38", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_39", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50A , data => new Data {
		{"BMS_Cell_Voltage_40", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_41", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_42", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_43", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50B , data => new Data {
		{"BMS_Cell_Voltage_44", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_45", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_46", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_47", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50C , data => new Data {
		{"BMS_Cell_Voltage_48", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_49", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_50", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_51", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50D , data => new Data {
		{"BMS_Cell_Voltage_52", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_53", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_54", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_55", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50E , data => new Data {
		{"BMS_Cell_Voltage_56", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_57", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_58", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_59", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x50F , data => new Data {
		{"BMS_Cell_Voltage_60", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_61", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_62", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_63", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x510 , data => new Data {
		{"BMS_Cell_Voltage_64", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_65", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_66", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_67", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x511 , data => new Data {
		{"BMS_Cell_Voltage_68", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_69", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_70", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_71", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x512 , data => new Data {
		{"BMS_Cell_Voltage_72", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_73", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_74", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_75", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x513 , data => new Data {
		{"BMS_Cell_Voltage_76", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_77", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_78", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_79", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x514 , data => new Data {
		{"BMS_Cell_Voltage_80", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_81", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_82", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_83", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x515 , data => new Data {
		{"BMS_Cell_Voltage_84", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_85", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_86", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_87", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x516 , data => new Data {
		{"BMS_Cell_Voltage_88", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_89", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_90", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_91", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x517 , data => new Data {
		{"BMS_Cell_Voltage_92", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_93", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_94", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_95", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x518 , data => new Data {
		{"BMS_Cell_Voltage_96", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_97", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_98", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_99", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x519 , data => new Data {
		{"BMS_Cell_Voltage_100", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_101", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_102", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_103", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51A , data => new Data {
		{"BMS_Cell_Voltage_104", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_105", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_106", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_107", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51B , data => new Data {
		{"BMS_Cell_Voltage_108", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_109", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_110", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_111", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51C , data => new Data {
		{"BMS_Cell_Voltage_112", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_113", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_114", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_115", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51D , data => new Data {
		{"BMS_Cell_Voltage_116", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_117", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_118", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_119", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51E , data => new Data {
		{"BMS_Cell_Voltage_120", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_121", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_122", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_123", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x51F , data => new Data {
		{"BMS_Cell_Voltage_124", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_125", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_126", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_127", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x520 , data => new Data {
		{"BMS_Cell_Voltage_128", Uint(data[0], data[1])*0.0001},
		{"BMS_Cell_Voltage_129", Uint(data[2], data[3])*0.0001},
		{"BMS_Cell_Voltage_130", Uint(data[4], data[5])*0.0001},
		{"BMS_Cell_Voltage_131", Uint(data[6], data[7])*0.0001}
	}
},

{
	0x540 , data => new Data {
		{"BMS_Cell_Temperature_0", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_1", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_2", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_3", Uint(data[6], data[7])*0.1}
	}
},

{
	0x541 , data => new Data {
		{"BMS_Cell_Temperature_4", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_5", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_6", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_7", Uint(data[6], data[7])*0.1}
	}
},

{
	0x542 , data => new Data {
		{"BMS_Cell_Temperature_8" , Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_9" , Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_10", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_11", Uint(data[6], data[7])*0.1}
	}
},

{
	0x543 , data => new Data {
		{"BMS_Cell_Temperature_12", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_13", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_14", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_15", Uint(data[6], data[7])*0.1}
	}
},

{
	0x544 , data => new Data {
		{"BMS_Cell_Temperature_16", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_17", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_18", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_19", Uint(data[6], data[7])*0.1}
	}
},

{
	0x545 , data => new Data {
		{"BMS_Cell_Temperature_20", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_21", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_22", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_23", Uint(data[6], data[7])*0.1}
	}
},

{
	0x546 , data => new Data {
		{"BMS_Cell_Temperature_24", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_25", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_26", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_27", Uint(data[6], data[7])*0.1}
	}
},

{
	0x547 , data => new Data {
		{"BMS_Cell_Temperature_28", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_29", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_30", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_31", Uint(data[6], data[7])*0.1}
	}
},

{
	0x548 , data => new Data {
		{"BMS_Cell_Temperature_32", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_33", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_34", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_35", Uint(data[6], data[7])*0.1}
	}
},

{
	0x549 , data => new Data {
		{"BMS_Cell_Temperature_36", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_37", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_38", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_39", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54A , data => new Data {
		{"BMS_Cell_Temperature_40", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_41", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_42", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_43", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54B , data => new Data {
		{"BMS_Cell_Temperature_44", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_45", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_46", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_47", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54C , data => new Data {
		{"BMS_Cell_Temperature_48", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_49", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_50", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_51", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54D , data => new Data {
		{"BMS_Cell_Temperature_52", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_53", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_54", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_55", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54E , data => new Data {
		{"BMS_Cell_Temperature_56", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_57", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_58", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_59", Uint(data[6], data[7])*0.1}
	}
},

{
	0x54F , data => new Data {
		{"BMS_Cell_Temperature_60", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_61", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_62", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_63", Uint(data[6], data[7])*0.1}
	}
},

{
	0x550 , data => new Data {
		{"BMS_Cell_Temperature_64", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_65", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_66", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_67", Uint(data[6], data[7])*0.1}
	}
},

{
	0x551 , data => new Data {
		{"BMS_Cell_Temperature_68", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_69", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_70", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_71", Uint(data[6], data[7])*0.1}
	}
},

{
	0x552 , data => new Data {
		{"BMS_Cell_Temperature_72", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_73", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_74", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_75", Uint(data[6], data[7])*0.1}
	}
},

{
	0x553 , data => new Data {
		{"BMS_Cell_Temperature_76", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_77", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_78", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_79", Uint(data[6], data[7])*0.1}
	}
},

{
	0x554 , data => new Data {
		{"BMS_Cell_Temperature_80", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_81", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_82", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_83", Uint(data[6], data[7])*0.1}
	}
},

{
	0x555 , data => new Data {
		{"BMS_Cell_Temperature_84", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_85", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_86", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_87", Uint(data[6], data[7])*0.1}
	}
},

{
	0x556 , data => new Data {
		{"BMS_Cell_Temperature_88", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_89", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_90", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_91", Uint(data[6], data[7])*0.1}
	}
},

{
	0x557 , data => new Data {
		{"BMS_Cell_Temperature_92", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_93", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_94", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_95", Uint(data[6], data[7])*0.1}
	}
},

{
	0x558 , data => new Data {
		{"BMS_Cell_Temperature_96", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_97", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_98", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_99", Uint(data[6], data[7])*0.1}
	}
},

{
	0x559 , data => new Data {
		{"BMS_Cell_Temperature_100", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_101", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_102", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_103", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55A , data => new Data {
		{"BMS_Cell_Temperature_104", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_105", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_106", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_107", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55B , data => new Data {
		{"BMS_Cell_Temperature_108", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_109", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_110", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_111", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55C , data => new Data {
		{"BMS_Cell_Temperature_112", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_113", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_114", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_115", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55D , data => new Data {
		{"BMS_Cell_Temperature_116", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_117", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_118", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_119", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55E , data => new Data {
		{"BMS_Cell_Temperature_120", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_121", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_122", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_123", Uint(data[6], data[7])*0.1}
	}
},

{
	0x55F , data => new Data {
		{"BMS_Cell_Temperature_124", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_125", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_126", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_127", Uint(data[6], data[7])*0.1}
	}
},

{
	0x560 , data => new Data {
		{"BMS_Cell_Temperature_128", Uint(data[0], data[1])*0.1},
		{"BMS_Cell_Temperature_129", Uint(data[2], data[3])*0.1},
		{"BMS_Cell_Temperature_130", Uint(data[4], data[5])*0.1},
		{"BMS_Cell_Temperature_131", Uint(data[6], data[7])*0.1}
	}
},
// new can ids 0x630 - 0x63F start-------------------------------------------------------
{
	0x630 , data => new Data {
		{"VCU_LC_torque_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_torque_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_torque_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_torque_RR", Int(data[6], data[7])*0.01}
	}
},
{
	0x631 , data => new Data {
		{"VCU_LC_SR_error_FL", Int(data[0], data[1])*0.001},
		{"VCU_LC_SR_error_FR", Int(data[2], data[3])*0.001},
		{"VCU_LC_SR_error_RL", Int(data[4], data[5])*0.001},
		{"VCU_LC_SR_error_RR", Int(data[6], data[7])*0.001}
	}
},
{
	0x632 , data => new Data {
		{"VCU_LC_SR_der_error_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_SR_der_error_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_SR_der_error_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_SR_der_error_RR", Int(data[6], data[7])*0.01}
	}
},
{
	0x633 , data => new Data {
		{"VCU_LC_SR_ref_FL", Int(data[0], data[1])*0.001},
		{"VCU_LC_SR_ref_FR", Int(data[2], data[3])*0.001},
		{"VCU_LC_SR_ref_RL", Int(data[4], data[5])*0.001},
		{"VCU_LC_SR_ref_RR", Int(data[6], data[7])*0.001}
	}
},
{
	0x634 , data => new Data {
		{"VCU_LC_SR_FL", Int(data[0], data[1])*0.001},
		{"VCU_LC_SR_FR", Int(data[2], data[3])*0.001},
		{"VCU_LC_SR_RL", Int(data[4], data[5])*0.001},
		{"VCU_LC_SR_RR", Int(data[6], data[7])*0.001}
	}
},
{
	0x635 , data => new Data {
		{"VCU_LC_P_term_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_P_term_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_P_term_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_P_term_RR", Int(data[6], data[7])*0.01}
	}
},
{
	0x636 , data => new Data {
		{"VCU_LC_I_term_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_I_term_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_I_term_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_I_term_RR", Int(data[6], data[7])*0.01}
	}
},
{
	0x637 , data => new Data {
		{"VCU_LC_D_term_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_D_term_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_D_term_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_D_term_RR", Int(data[6], data[7])*0.01}
	}
},
{
	0x638 , data => new Data {
		{"VCU_LC_Kp", Int(data[0], data[1])*0.01},
		{"VCU_LC_Ki", Int(data[2], data[3])*0.01},
		{"VCU_LC_Kd", Int(data[4], data[5])*0.01},
		{"VCU_LC_T_req", Int(data[6], data[7])*0.01}
	}
},
{
	0x639 , data => new Data {
		{"VCU_LC_Launch_Mode", Int(data[0])},
		{"VCU_LC_Launching", Int(data[1])}
	}
},
{
	0x63A , data => new Data {
		{"VCU_LC_Power_Limit_FL", Int(data[0], data[1])*0.01},
		{"VCU_LC_Power_Limit_FR", Int(data[2], data[3])*0.01},
		{"VCU_LC_Power_Limit_RL", Int(data[4], data[5])*0.01},
		{"VCU_LC_Power_Limit_RR", Int(data[6], data[7])*0.01}
	}
},

// new can ids 0x630 - 0x63F start-------------------------------------------------------

{
	0x650 , data => new Data {
		{"VCU_TV_Max_motor_torque_FL", Int(data[0], data[1])/100},
		{"VCU_TV_Max_motor_torque_FR", Int(data[2], data[3])/100},
		{"VCU_TV_Max_motor_torque_RL", Int(data[4], data[5])/100},
		{"VCU_TV_Max_motor_torque_RR", Int(data[6], data[7])/100}
	}
},
{
	0x651 , data => new Data {
		{"VCU_TV_T_req", Int(data[0], data[1])/100},
		{"VCU_TV_Mz_error", Int(data[2], data[3])/100},
		{"VCU_TV_percentage_delivered_torque", Int(data[4], data[5])/100}
	}
},

{
	0x653 , data => new Data {
		{"VCU_TV_Mz_ref_controller", Int(data[0], data[1])*0.1},
		{"VCU_TV_Mz_ref_generator", Int(data[2], data[3])*0.1},
		{"VCU_TV_Mz_ref_controller_unsat", Int(data[4], data[5])*0.1},
		{"VCU_TV_Mz_ref_generator_unsat", Int(data[5], data[6])*0.1}
 	}
},

{	
	0x654 , data => new Data {
		{"VCU_TV_Active_constraints", Uint(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7])}
	}
},

{
	0x655 , data => new Data {
		{"VCU_TV_Yaw_rate_ref", Int(data[0], data[1])*0.1},
		{"VCU_TV_Yaw_rate_lim", Int(data[2], data[3])*0.1},
		{"VCU_TV_Mz_ref_controller_unsat", Int(data[4], data[5])*0.1},
		{"VCU_TV_Mz_ref_generator_unsat", Int(data[5], data[6])*0.1}
 	}
},

{
	0x656 , data => new Data {
		{"VCU_TV_P_term_generator", Int(data[0], data[1])*0.01},
		{"VCU_TV_D_term_generator", Int(data[2], data[3])*0.01},
		{"VCU_TV_Kp_generator", Int(data[4], data[5])*0.01},
		{"VCU_TV_Kd_generator", Int(data[5], data[6])*0.01}
 	}
},

{
	0x657 , data => new Data {
		{"VCU_TV_P_term_regulator", Int(data[0], data[1])*0.01},
		{"VCU_TV_I_term_regulator", Int(data[2], data[3])*0.01},
		{"VCU_TV_D_term_retulagot", Int(data[4], data[5])*0.01},
		{"VCU_TV_Backstepping_regulator", Int(data[5], data[6])*0.01}
 	}
},

{
	0x658 , data => new Data {
		{"VCU_TV_MMT_tire_force_FL", Int(data[0], data[1])*0.01},
		{"VCU_TV_MMT_tire_force_FR", Int(data[2], data[3])*0.01},
		{"VCU_TV_MMT_tire_force_RL", Int(data[4], data[5])*0.01},
		{"VCU_TV_MMT_tire_force_RR", Int(data[5], data[6])*0.01}
 	}
},

{
	0x659 , data => new Data {
		{"VCU_TV_MMT_tire_force_slip_FL", Int(data[0], data[1])*0.01},
		{"VCU_TV_MMT_tire_force_slip_FR", Int(data[2], data[3])*0.01},
		{"VCU_TV_MMT_tire_force_slip_RL", Int(data[4], data[5])*0.01},
		{"VCU_TV_MMT_tire_force_slip_RR", Int(data[5], data[6])*0.01}
 	}
},

{
	0x65A , data => new Data {
		{"VCU_TV_slip_scaling_factors_FL", Int(data[0], data[1])*0.001},
		{"VCU_TV_slip_scaling_factors_FR", Int(data[2], data[3])*0.001},
		{"VCU_TV_slip_scaling_factors_RL", Int(data[4], data[5])*0.001},
		{"VCU_TV_slip_scaling_factors_RR", Int(data[5], data[6])*0.001}
 	}
},

//----HIL testing IDs------------------------------------------------------------
{
	0x720 , data => new Data {
		{"HIL_Yaw_rate", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x721 , data => new Data {
		{"HIL_Pitch_rate", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x722 , data => new Data {
		{"HIL_Roll_rate", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x723 , data => new Data {
		{"HIL_Ax", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x724 , data => new Data {
		{"HIL_Ay", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x725 , data => new Data {
		{"HIL_Az", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x726 , data => new Data {
		{"HIL_Vx", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x727 , data => new Data {
		{"HIL_Vy", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x728 , data => new Data {
		{"HIL_Vz", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x729 , data => new Data {
		{"HIL_Yaw_angle", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x72A , data => new Data {
		{"HIL_Pitch_angle", Float(data[0],data[1],data[2],data[3])}
 	}
},
{
	0x72B , data => new Data {
		{"HIL_Roll_angle", Float(data[0],data[1],data[2],data[3])}
 	}
},
