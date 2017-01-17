// ***************************************************************************************
// File Name:   FileIO.cs
// Author:      Roger Campbell 
// Purpose:     Saving and loading all game data for multiple profiles 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function writeFile()
{
	%file = new FileObject();


	if(%file.openForWrite("./data/test.txt"))
	{
		%file.writeLine("File System Test OK!");
		echo("File Written");
	}

	else
	{
		error("File is not open for writing");
	}

	%file.close();
	%file.delete();

}


function readFile()
{
	%file = new FileObject();
	echo("Readability Active");

	if(%file.openForRead("./data/test.txt"))
	{
		%x=1;
		%line = %file.readLine();
		%line2 = %file.readLine();
		%line3 = %file.readLine();
		echo("line" @ %x @ " = " @ %line);
	}

	else
	{
		error("CANNOT OPEN FOR READ");
	}
	%file.close();
	%file.delete();
}

function write_to_unique_save_file()
{
	echo("\c2 WRITE TO UNIQUE SAVE FILE " @ $current_profile_number);
	$sfile2 = new FileObject();
	if($sfile2.openForWrite("./data/prof_unique" @ ".ccf"))
	{
		$sfile2.writeLine(profile_text_slot1.has_ever_actually_been_played);
		echo("\c2 profile_text_slot1.has_ever_actually_been_played " @ profile_text_slot1.has_ever_actually_been_played);	
		$sfile2.writeLine(profile_text_slot2.has_ever_actually_been_played);
		echo("\c2 profile_text_slot2.has_ever_actually_been_played " @ profile_text_slot2.has_ever_actually_been_played);
		$sfile2.writeLine(profile_text_slot3.has_ever_actually_been_played);
		echo("\c2 profile_text_slot3.has_ever_actually_been_played " @ profile_text_slot3.has_ever_actually_been_played);
		$sfile2.writeLine(profile_text_slot4.has_ever_actually_been_played);
		echo("\c2 profile_text_slot4.has_ever_actually_been_played " @ profile_text_slot4.has_ever_actually_been_played);
		$sfile2.close();
	}
}

function write_to_save_file()
{
echo("\c2 WRITE TO SAVE FILE " @ $bob_test);
$sfile = new FileObject();
testerxx2.text = ("Write for file " @ $input_to_profile_slot @ " at saveFile version: " @ $current_profile_number);
if($sfile.openForWrite("./data/test" @ $current_profile_number @ ".ccf"))
{
echo("\c2 (1) Writing File...");
$sfile.writeLine($bob_test);
echo("\c2 (2) bob_test " @ $bob_test);
//edit 03-01-2014 check for file saving inconsistencies and repair
if($current_level != $round_numeral)
{
echo("Error in writing current_level, fixing to proper number");
$current_level = $round_numeral;
}
$sfile.writeLine($current_level);
echo("\c2 (3) current_level " @ $current_level);
$sfile.writeLine($round_numeral);
echo("\c2 (4) round_numeral " @ $round_numeral);
$sfile.writeLine($world_numeral);
echo("\c2 (5) world_numeral " @ $world_numeral);
$sfile.writeLine($coinage);
echo("\c2 (6) coinage " @ $current_level);
$sfile.writeLine($coinage_max);
echo("\c2 (7) coinage_max " @ $coinage_max);
/* trophies data */
$sfile.writeLine($_trophy_trophy1_activated);
echo("\c2 (8) _trophy_trophy1_activated " @ $_trophy_trophy1_activated);
$sfile.writeLine($_trophy_trophy2_activated);
echo("\c2 (9) _trophy_trophy2_activated " @ $_trophy_trophy2_activated);
$sfile.writeLine($_trophy_trophy3_activated);
echo("\c2 (10) _trophy_trophy3_activated " @ $_trophy_trophy3_activated);
$sfile.writeLine($_trophy_trophy4_activated);
echo("\c2 (11) _trophy_trophy4_activated " @ $_trophy_trophy4_activated);
$sfile.writeLine($_trophy_trophy5_activated);
echo("\c2 (12) _trophy_trophy5_activated " @ $_trophy_trophy5_activated);
$sfile.writeLine($_trophy_trophy6_activated);
echo("\c2 (13) _trophy_trophy6_activated " @ $_trophy_trophy6_activated);
$sfile.writeLine($_trophy_trophy7_activated);
echo("\c2 (14) _trophy_trophy7_activated " @ $_trophy_trophy7_activated);
$sfile.writeLine($_trophy_trophy8_activated);
echo("\c2 (15) _trophy_trophy8_activated " @ $_trophy_trophy8_activated);
$sfile.writeLine($_trophy_trophy9_activated);
echo("\c2 (16) _trophy_trophy9_activated " @ $_trophy_trophy9_activated);

$sfile.writeLine($_trophy_plaque1_activated);
echo("\c2 (17) _trophy_plaque1_activated " @ $_trophy_plaque1_activated);
$sfile.writeLine($_trophy_plaque2_activated);
echo("\c2 (18) _trophy_plaque2_activated " @ $_trophy_plaque2_activated);
$sfile.writeLine($_trophy_plaque3_activated);
echo("\c2 (19) _trophy_plaque3_activated " @ $_trophy_plaque3_activated);
$sfile.writeLine($_trophy_plaque4_activated);
echo("\c2 (20) _trophy_plaque4_activated " @ $_trophy_plaque4_activated);
$sfile.writeLine($_trophy_plaque5_activated);
echo("\c2 (21) _trophy_plaque5_activated " @ $_trophy_plaque5_activated);
$sfile.writeLine($_trophy_plaque6_activated);
echo("\c2 (22) _trophy_plaque6_activated " @ $_trophy_plaque6_activated);
$sfile.writeLine($_trophy_plaque7_activated);
echo("\c2 (23) _trophy_plaque7_activated " @ $_trophy_plaque7_activated);
$sfile.writeLine($_trophy_plaque8_activated);
echo("\c2 (24) _trophy_plaque8_activated " @ $_trophy_plaque8_activated);
$sfile.writeLine($_trophy_plaque9_activated);
echo("\c2 (25) _trophy_plaque9_activated " @ $_trophy_plaque9_activated);
$sfile.writeLine($_trophy_plaque10_activated);
echo("\c2 (26) _trophy_plaque10_activated " @ $_trophy_plaque10_activated);

$sfile.writeLine($_trophy_ribbon1_activated);
echo("\c2 (27) _trophy_ribbon1_activated " @ $_trophy_ribbon1_activated);
$sfile.writeLine($_trophy_ribbon2_activated);
echo("\c2 (28) _trophy_ribbon2_activated " @ $_trophy_ribbon2_activated);
$sfile.writeLine($_trophy_ribbon3_activated);
echo("\c2 (29) _trophy_ribbon3_activated " @ $_trophy_ribbon3_activated);
$sfile.writeLine($_trophy_ribbon4_activated);
echo("\c2 (30) _trophy_ribbon4_activated " @ $_trophy_ribbon4_activated);
$sfile.writeLine($_trophy_ribbon5_activated);
echo("\c2 (31) _trophy_ribbon5_activated " @ $_trophy_ribbon5_activated);
$sfile.writeLine($_trophy_ribbon6_activated);
echo("\c2 (32) _trophy_ribbon6_activated " @ $_trophy_ribbon6_activated);

$sfile.writeLine($_trophy_button1_activated);
echo("\c2 (33) _trophy_button1_activated " @ $_trophy_button1_activated);
$sfile.writeLine($_trophy_button2_activated);
echo("\c2 (34) _trophy_button2_activated " @ $_trophy_button2_activated);
$sfile.writeLine($_trophy_button3_activated);
echo("\c2 (35) _trophy_button3_activated " @ $_trophy_button3_activated);
$sfile.writeLine($_trophy_button4_activated);
echo("\c2 (36) _trophy_button4_activated " @ $_trophy_button4_activated);
$sfile.writeLine($_trophy_button5_activated);
echo("\c2 (37) _trophy_button5_activated " @ $_trophy_button5_activated);
$sfile.writeLine($_trophy_button6_activated);
echo("\c2 (38) _trophy_button6_activated " @ $_trophy_button6_activated);

$sfile.writeLine($_trophy_mount1_activated);
echo("\c2 (39) _trophy_mount1_activated " @ $_trophy_mount1_activated);
$sfile.writeLine($_trophy_mount2_activated);
echo("\c2 (40) _trophy_mount2_activated " @ $_trophy_mount2_activated);
$sfile.writeLine($_trophy_mount3_activated);
echo("\c2 (41) _trophy_mount3_activated " @ $_trophy_mount3_activated);
$sfile.writeLine($_trophy_mount4_activated);
echo("\c2 (42) _trophy_mount4_activated " @ $_trophy_mount4_activated);

$sfile.writeLine($_trophy_dollar_activated);
echo("\c2 (43) trophy_dollar " @ $_trophy_dollar_activated);
$sfile.writeLine($trophy_all_gold_in_round);
echo("\c2 (44) trophy_all_gold_in_round " @ $trophy_all_gold_in_round);
$sfile.writeLine($trophy_angered_a_customer);
echo("\c2 (45) trophy_angered_a_customer " @ $trophy_angered_a_customer);
$sfile.writeLine($trophy_no_angry_customers);
echo("\c2 (46) trophy_no_angry_customers " @ $trophy_no_angry_customers);

$sfile.writeLine($points_you_have);
echo("\c2 (47) points_you_have " @ $points_you_have);
$sfile.writeLine($points_you_need);
echo("\c2 (48) points_you_have " @ $points_you_need);

$sfile.writeLine($trophy_toggle_off_all_gold_in_round);
echo("\c2 (49) trophy_toggle_off_all_gold_in_round " @ $trophy_toggle_off_all_gold_in_round);

$sfile.writeLine($maximum_level_player_got_to);
echo("\c2 (50) maximum_level_player_got_to " @ $maximum_level_player_got_to);
$sfile.writeLine($maximum_world_player_got_to);
echo("\c2 (51) maximum_world_player_got_to " @ $maximum_world_player_got_to);

$sfile.writeLine(levsel_1.unlocked);
echo("\c2 (52) levsel_1.unlocked " @ levsel_1.unlocked);
$sfile.writeLine(levsel_2.unlocked);
echo("\c2 (53) levsel_2.unlocked " @ levsel_2.unlocked);
$sfile.writeLine(levsel_3.unlocked);
echo("\c2 (54) levsel_3.unlocked " @ levsel_3.unlocked);
$sfile.writeLine(levsel_4.unlocked);
echo("\c2 (55) levsel_4.unlocked " @ levsel_4.unlocked);
$sfile.writeLine(levsel_5.unlocked);
echo("\c2 (56) levsel_5.unlocked " @ levsel_5.unlocked);
$sfile.writeLine(levsel_6.unlocked);
echo("\c2 (57) levsel_6.unlocked " @ levsel_6.unlocked);
$sfile.writeLine(levsel_7.unlocked);
echo("\c2 (58) levsel_7.unlocked " @ levsel_7.unlocked);
$sfile.writeLine(levsel_8.unlocked);
echo("\c2 (59) levsel_8.unlocked " @ levsel_8.unlocked);
$sfile.writeLine(levsel_9.unlocked);
echo("\c2 (60) levsel_9.unlocked " @ levsel_9.unlocked);
$sfile.writeLine(levsel_10.unlocked);
echo("\c2 (61) levsel_10.unlocked " @ levsel_10.unlocked);

$sfile.writeLine($points_amount);
echo("\c2 (62) $points_amount " @ $points_amount);
$sfile.writeLine($flying_coins_collected);
echo("\c2 (63) $flying_coins_collected " @ $flying_coins_collected);
$sfile.writeLine($vortexes_collected);
echo("\c2 (64) $vortexes_collected " @ $vortexes_collected);

//toggle save states for mega manager trophy counter
$sfile.writeLine($trophy_toggle_off_plaque1);
echo("\c2 (65) $trophy_toggle_off_plaque1 " @ $trophy_toggle_off_plaque1);
$sfile.writeLine($trophy_toggle_off_plaque2);
echo("\c2 (66) $trophy_toggle_off_plaque2 " @ $trophy_toggle_off_plaque2);
$sfile.writeLine($trophy_toggle_off_plaque3);
echo("\c2 (67) $trophy_toggle_off_plaque3 " @ $trophy_toggle_off_plaque3);
$sfile.writeLine($trophy_toggle_off_plaque4);
echo("\c2 (68) $trophy_toggle_off_plaque4 " @ $trophy_toggle_off_plaque4);
$sfile.writeLine($trophy_toggle_off_plaque5);
echo("\c2 (69) $trophy_toggle_off_plaque5 " @ $trophy_toggle_off_plaque5);
$sfile.writeLine($trophy_toggle_off_plaque6);
echo("\c2 (70) $trophy_toggle_off_plaque6 " @ $trophy_toggle_off_plaque6);
$sfile.writeLine($trophy_toggle_off_plaque7);
echo("\c2 (71) $trophy_toggle_off_plaque7 " @ $trophy_toggle_off_plaque7);
$sfile.writeLine($trophy_toggle_off_plaque8);
echo("\c2 (72) $trophy_toggle_off_plaque8 " @ $trophy_toggle_off_plaque8);
$sfile.writeLine($trophy_toggle_off_plaque9);
echo("\c2 (73) $trophy_toggle_off_plaque9 " @ $trophy_toggle_off_plaque9);
$sfile.writeLine($trophy_toggle_off_plaque10);
echo("\c2 (74) $trophy_toggle_off_plaque10 " @ $trophy_toggle_off_plaque10);

$sfile.writeLine($mega_manager_counter);
echo("\c2 (75) $mega_manager_counter " @ $mega_manager_counter);

$sfile.writeLine($customers_served_counter);
echo("\c2 (76) $customers_served_counter " @ $customers_served_counter);

//APPETIZERS
$sfile.writeLine($appetizer1_purchased1);
echo("\c2 (77) $appetizer1_purchased1 " @ $appetizer1_purchased1);
$sfile.writeLine($appetizer1_amount1);
echo("\c2 (78) $appetizer1_amount1 " @ $appetizer1_amount1);
$sfile.writeLine($appetizer1_purchased2);
echo("\c2 (79) $appetizer1_purchased2 " @ $appetizer1_purchased2);
$sfile.writeLine($appetizer1_amount2);
echo("\c2 (80) $appetizer1_amount2 " @ $appetizer1_amount2);
$sfile.writeLine($appetizer1_purchased3);
echo("\c2 (81) $appetizer1_purchased3 " @ $appetizer1_purchased3);
$sfile.writeLine($appetizer1_amount3);
echo("\c2 (82) $appetizer1_amount3 " @ $appetizer1_amount3);
$sfile.writeLine($appetizer1_purchased4);
echo("\c2 (83) $appetizer1_purchased4 " @ $appetizer1_purchased4);
$sfile.writeLine($appetizer1_amount4);
echo("\c2 (84) $appetizer1_amount4 " @ $appetizer1_amount4);
$sfile.writeLine($appetizer1_purchased5);
echo("\c2 (85) $appetizer1_purchased5 " @ $appetizer1_purchased5);
$sfile.writeLine($appetizer1_amount5);
echo("\c2 (86) $appetizer1_amount5 " @ $appetizer1_amount5);
$sfile.writeLine($appetizer1_purchased6);
echo("\c2 (87) $appetizer1_purchased6 " @ $appetizer1_purchased6);
$sfile.writeLine($appetizer1_amount6);
echo("\c2 (88) $appetizer1_amount6 " @ $appetizer1_amount6);
$sfile.writeLine($appetizer1_purchased7);
echo("\c2 (89) $appetizer1_purchased7 " @ $appetizer1_purchased7);
$sfile.writeLine($appetizer1_amount7);
echo("\c2 (90) $appetizer1_amount7 " @ $appetizer1_amount7);
$sfile.writeLine($appetizer1_purchased8);
echo("\c2 (91) $appetizer1_purchased8 " @ $appetizer1_purchased8);
$sfile.writeLine($appetizer1_amount8);
echo("\c2 (92) $appetizer1_amount8 " @ $appetizer1_amount8);
$sfile.writeLine($appetizer1_purchased9);
echo("\c2 (93) $appetizer1_purchased9 " @ $appetizer1_purchased9);
$sfile.writeLine($appetizer1_amount9);
echo("\c2 (94) $appetizer1_amount9 " @ $appetizer1_amount9);
$sfile.writeLine($appetizer1_purchased10);
echo("\c2 (95) $appetizer1_purchased10 " @ $appetizer1_purchased10);
$sfile.writeLine($appetizer1_amount10);
echo("\c2 (96) $appetizer1_amount10 " @ $appetizer1_amount10);

$sfile.writeLine($appetizer2_purchased1);
echo("\c2 (97) $appetizer2_purchased1 " @ $appetizer2_purchased1);
$sfile.writeLine($appetizer2_amount1);
echo("\c2 (98) $appetizer2_amount1 " @ $appetizer2_amount1);
$sfile.writeLine($appetizer2_purchased2);
echo("\c2 (99) $appetizer2_purchased2 " @ $appetizer2_purchased2);
$sfile.writeLine($appetizer2_amount2);
echo("\c2 (100) $appetizer2_amount2 " @ $appetizer2_amount2);
$sfile.writeLine($appetizer2_purchased3);
echo("\c2 (101) $appetizer2_purchased3 " @ $appetizer2_purchased3);
$sfile.writeLine($appetizer2_amount3);
echo("\c2 (102) $appetizer2_amount3 " @ $appetizer2_amount3);
$sfile.writeLine($appetizer2_purchased4);
echo("\c2 (103) $appetizer2_purchased4 " @ $appetizer2_purchased4);
$sfile.writeLine($appetizer2_amount4);
echo("\c2 (104) $appetizer2_amount4 " @ $appetizer2_amount4);
$sfile.writeLine($appetizer2_purchased5);
echo("\c2 (105) $appetizer2_purchased5 " @ $appetizer2_purchased5);
$sfile.writeLine($appetizer2_amount5);
echo("\c2 (106) $appetizer2_amount5 " @ $appetizer2_amount5);
$sfile.writeLine($appetizer2_purchased6);
echo("\c2 (107) $appetizer2_purchased6 " @ $appetizer2_purchased6);
$sfile.writeLine($appetizer2_amount6);
echo("\c2 (108) $appetizer2_amount6 " @ $appetizer2_amount6);
$sfile.writeLine($appetizer2_purchased7);
echo("\c2 (109) $appetizer2_purchased7 " @ $appetizer2_purchased7);
$sfile.writeLine($appetizer2_amount7);
echo("\c2 (110) $appetizer2_amount7 " @ $appetizer2_amount7);
$sfile.writeLine($appetizer2_purchased8);
echo("\c2 (111) $appetizer2_purchased8 " @ $appetizer2_purchased8);
$sfile.writeLine($appetizer2_amount8);
echo("\c2 (112) $appetizer2_amount8 " @ $appetizer2_amount8);
$sfile.writeLine($appetizer2_purchased9);
echo("\c2 (113) $appetizer2_purchased9 " @ $appetizer2_purchased9);
$sfile.writeLine($appetizer2_amount9);
echo("\c2 (114) $appetizer2_amount9 " @ $appetizer2_amount9);
$sfile.writeLine($appetizer2_purchased10);
echo("\c2 (115) $appetizer2_purchased10 " @ $appetizer2_purchased10);
$sfile.writeLine($appetizer2_amount10);
echo("\c2 (116) $appetizer2_amount10 " @ $appetizer2_amount10);

$sfile.writeLine($star_system_array);
echo("\c2 (117) $star_system_array " @ $star_system_array);

$sfile.writeLine($sfx_level);
echo("\c2 (118) $sfx_level " @ $sfx_level);	
$sfile.writeLine($music_level);
echo("\c2 (119) $music_level " @ $music_level);
$sfile.writeLine($soundfx_loudness);
echo("\c2 (120) $soundfx_loudness " @ $soundfx_loudness);	
$sfile.writeLine($music_loudness);
echo("\c2 (121) $music_loudness " @ $music_loudness);

$sfile.writeLine($entertainer1_bought_world1);
echo("\c2 (122) $entertainer1_bought_world1 " @ $entertainer1_bought_world1);
$sfile.writeLine($entertainer2_bought_world1);
echo("\c2 (123) $entertainer2_bought_world1 " @ $entertainer2_bought_world1);
$sfile.writeLine($entertainer1_bought_world2);
echo("\c2 (124) $entertainer1_bought_world2 " @ $entertainer1_bought_world2);
$sfile.writeLine($entertainer2_bought_world2);
echo("\c2 (125) $entertainer2_bought_world2 " @ $entertainer2_bought_world2);
$sfile.writeLine($entertainer1_bought_world3);
echo("\c2 (126) $entertainer1_bought_world3 " @ $entertainer1_bought_world3);
$sfile.writeLine($entertainer2_bought_world3);
echo("\c2 (127) $entertainer2_bought_world3 " @ $entertainer2_bought_world3);
$sfile.writeLine($entertainer1_bought_world4);
echo("\c2 (128) $entertainer1_bought_world4 " @ $entertainer1_bought_world4);
$sfile.writeLine($entertainer2_bought_world4);
echo("\c2 (129) $entertainer2_bought_world4 " @ $entertainer2_bought_world4);
$sfile.writeLine($entertainer1_bought_world5);
echo("\c2 (130) $entertainer1_bought_world5 " @ $entertainer1_bought_world5);
$sfile.writeLine($entertainer2_bought_world5);
echo("\c2 (131) $entertainer2_bought_world5 " @ $entertainer2_bought_world5);
$sfile.writeLine($entertainer1_bought_world6);
echo("\c2 (132) $entertainer1_bought_world6 " @ $entertainer1_bought_world6);
$sfile.writeLine($entertainer2_bought_world6);
echo("\c2 (133) $entertainer2_bought_world6 " @ $entertainer2_bought_world6);
$sfile.writeLine($entertainer1_bought_world7);
echo("\c2 (134) $entertainer1_bought_world7 " @ $entertainer1_bought_world7);
$sfile.writeLine($entertainer2_bought_world7);
echo("\c2 (135) $entertainer2_bought_world7 " @ $entertainer2_bought_world7);
$sfile.writeLine($entertainer1_bought_world8);
echo("\c2 (136) $entertainer1_bought_world8 " @ $entertainer1_bought_world8);
$sfile.writeLine($entertainer2_bought_world8);
echo("\c2 (137) $entertainer2_bought_world8 " @ $entertainer2_bought_world8);
$sfile.writeLine($entertainer1_bought_world9);
echo("\c2 (138) $entertainer1_bought_world9 " @ $entertainer1_bought_world9);
$sfile.writeLine($entertainer2_bought_world9);
echo("\c2 (139) $entertainer2_bought_world9 " @ $entertainer2_bought_world9);
$sfile.writeLine($entertainer1_bought_world10);
echo("\c2 (140) $entertainer1_bought_world10 " @ $entertainer1_bought_world10);
$sfile.writeLine($entertainer2_bought_world10);
echo("\c2 (141) $entertainer2_bought_world10 " @ $entertainer2_bought_world10);

$sfile.writeLine($touchpad_activated);
echo("\c2 (141) $touchpad_activated " @ $touchpad_activated);

$sfile.writeLine($mute_music);
echo("\c2 (141) $mute_music " @ $mute_music);
$sfile.writeLine($mute_soundfx);
echo("\c2 (141) $mute_soundfx " @ $mute_soundfx);
$sfile.writeLine($toggle_mute_music);
echo("\c2 (141) $toggle_mute_music " @ $toggle_mute_music);


$sfile.close();

}

}

function read_from_unique_save_file()
{
echo("\c2 READ FROM UNIQUE SAVE FILE " @ $current_profile_number);
$sfile2 = new FileObject();
	if($sfile2.openForRead("./data/prof_unique" @ ".ccf"))
	{
		
		echo("\c2 Reading Unique File...");
		
		profile_text_slot1.has_ever_actually_been_played = $sfile2.readLine();
		echo("\c2 profile_text_slot1.has_ever_actually_been_played = " @ profile_text_slot1.has_ever_actually_been_played);
		profile_text_slot2.has_ever_actually_been_played = $sfile2.readLine();
		echo("\c2 profile_text_slot2.has_ever_actually_been_played = " @ profile_text_slot2.has_ever_actually_been_played);
		profile_text_slot3.has_ever_actually_been_played = $sfile2.readLine();
		echo("\c2 profile_text_slot3.has_ever_actually_been_played = " @ profile_text_slot3.has_ever_actually_been_played);
		profile_text_slot4.has_ever_actually_been_played = $sfile2.readLine();
		echo("\c2 profile_text_slot4.has_ever_actually_been_played = " @ profile_text_slot4.has_ever_actually_been_played);		
		
		$sfile2.close();
	}
}

//echo(profile_text_slot1.has_ever_actually_been_played);
function read_from_save_file()
{
echo("\c2 READ FROM SAVE FILE " @ $bob_test);
echo("\c2 CONFIRM FILE AT test" @ $current_profile_number @ ".ccf");
	$sfile = new FileObject();
	if($sfile.openForRead("./data/test" @ $current_profile_number @ ".ccf"))
	{
		echo("\c2 Reading File...");
		$bob_test = $sfile.readLine();
		echo("\c2 bob_test " @ $bob_test);
		$current_level = $sfile.readLine();
		echo("\c2 current_level " @ $current_level);
		$round_numeral = $sfile.readLine();
		echo("\c2 round_numeral " @ $round_numeral);
		$world_numeral = $sfile.readLine();
		echo("\c2 world_numeral " @ $world_numeral);
		$coinage = $sfile.readLine();
		echo("\c2 coinage " @ $coinage);
		$coinage_max = $sfile.readLine();
		echo("\c2 coinage " @ $coinage_max);
		/* trophies data */
		$_trophy_trophy1_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy1_activated " @ $_trophy_trophy1_activated);
		$_trophy_trophy2_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy2_activated " @ $_trophy_trophy2_activated);
		$_trophy_trophy3_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy3_activated " @ $_trophy_trophy3_activated);
		$_trophy_trophy4_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy4_activated " @ $_trophy_trophy4_activated);
		$_trophy_trophy5_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy5_activated " @ $_trophy_trophy5_activated);
		$_trophy_trophy6_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy6_activated " @ $_trophy_trophy6_activated);
		$_trophy_trophy7_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy7_activated " @ $_trophy_trophy7_activated);
		$_trophy_trophy8_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy8_activated " @ $_trophy_trophy8_activated);
		$_trophy_trophy9_activated = $sfile.readLine();
		echo("\c2 _trophy_trophy9_activated " @ $_trophy_trophy9_activated);

		$_trophy_plaque1_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque1_activated " @ $_trophy_plaque1_activated);
		$_trophy_plaque2_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque2_activated " @ $_trophy_plaque2_activated);
		$_trophy_plaque3_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque3_activated " @ $_trophy_plaque3_activated);
		$_trophy_plaque4_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque4_activated " @ $_trophy_plaque4_activated);
		$_trophy_plaque5_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque5_activated " @ $_trophy_plaque5_activated);
		$_trophy_plaque6_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque6_activated " @ $_trophy_plaque6_activated);
		$_trophy_plaque7_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque7_activated " @ $_trophy_plaque7_activated);
		$_trophy_plaque8_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque8_activated " @ $_trophy_plaque8_activated);
		$_trophy_plaque9_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque9_activated " @ $_trophy_plaque9_activated);
		$_trophy_plaque10_activated = $sfile.readLine();
		echo("\c2 _trophy_plaque10_activated " @ $_trophy_plaque10_activated);

		$_trophy_ribbon1_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon1_activated " @ $_trophy_ribbon1_activated);
		$_trophy_ribbon2_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon2_activated " @ $_trophy_ribbon2_activated);
		$_trophy_ribbon3_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon3_activated " @ $_trophy_ribbon3_activated);
		$_trophy_ribbon4_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon4_activated " @ $_trophy_ribbon4_activated);
		$_trophy_ribbon5_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon5_activated " @ $_trophy_ribbon5_activated);
		$_trophy_ribbon6_activated = $sfile.readLine();
		echo("\c2 _trophy_ribbon6_activated " @ $_trophy_ribbon6_activated);

		$_trophy_button1_activated = $sfile.readLine();
		echo("\c2 _trophy_button1_activated " @ $_trophy_button1_activated);
		$_trophy_button2_activated = $sfile.readLine();
		echo("\c2 _trophy_button2_activated " @ $_trophy_button2_activated);
		$_trophy_button3_activated = $sfile.readLine();
		echo("\c2 _trophy_button3_activated " @ $_trophy_button3_activated);
		$_trophy_button4_activated = $sfile.readLine();
		echo("\c2 _trophy_button4_activated " @ $_trophy_button4_activated);
		$_trophy_button5_activated = $sfile.readLine();
		echo("\c2 _trophy_button5_activated " @ $_trophy_button5_activated);
		$_trophy_button6_activated = $sfile.readLine();
		echo("\c2 _trophy_button6_activated " @ $_trophy_button6_activated);

		$_trophy_mount1_activated = $sfile.readLine();
		echo("\c2 _trophy_mount1_activated " @ $_trophy_mount1_activated);
		$_trophy_mount2_activated = $sfile.readLine();
		echo("\c2 _trophy_mount2_activated " @ $_trophy_mount2_activated);
		$_trophy_mount3_activated = $sfile.readLine();
		echo("\c2 _trophy_mount3_activated " @ $_trophy_mount3_activated);
		$_trophy_mount4_activated = $sfile.readLine();
		echo("\c2 _trophy_mount4_activated " @ $_trophy_mount4_activated);

		$_trophy_dollar_activated = $sfile.readLine();
		echo("\c2 trophy_dollar " @ $_trophy_dollar_activated);
		$trophy_all_gold_in_round = $sfile.readLine();
		echo("\c2 trophy_all_gold_in_round " @ $trophy_all_gold_in_round);	
		$trophy_angered_a_customer = $sfile.readLine();
		echo("\c2 trophy_angered_a_customer " @ $trophy_angered_a_customer);	
		$trophy_no_angry_customers = $sfile.readLine();
		echo("\c2 trophy_no_angry_customers " @ $trophy_no_angry_customers);		
				
		$points_you_have = $sfile.readLine();
		echo("\c2 points_you_have " @ $points_you_have);	
		$points_you_need = $sfile.readLine();
		echo("\c2 points_you_need " @ $points_you_need);	
		
		$trophy_toggle_off_all_gold_in_round = $sfile.readLine();
		echo("\c2 trophy_toggle_off_all_gold_in_round " @ $trophy_toggle_off_all_gold_in_round);		
		
		$maximum_level_player_got_to = $sfile.readLine();
		echo("\c2 points_you_have " @ $points_you_have);	
		$maximum_world_player_got_to = $sfile.readLine();
		echo("\c2 points_you_need " @ $points_you_need);
		
		levsel_1.unlocked = $sfile.readLine();
		echo("\c2 levsel_1.unlocked " @ levsel_1.unlocked);		
		levsel_2.unlocked = $sfile.readLine();
		echo("\c2 levsel_2.unlocked " @ levsel_2.unlocked);	
		levsel_3.unlocked = $sfile.readLine();
		echo("\c2 levsel_3.unlocked " @ levsel_3.unlocked);	
		levsel_4.unlocked = $sfile.readLine();
		echo("\c2 levsel_4.unlocked " @ levsel_4.unlocked);	
		levsel_5.unlocked = $sfile.readLine();
		echo("\c2 levsel_5.unlocked " @ levsel_5.unlocked);	
		levsel_6.unlocked = $sfile.readLine();
		echo("\c2 levsel_6.unlocked " @ levsel_6.unlocked);	
		levsel_7.unlocked = $sfile.readLine();
		echo("\c2 levsel_7.unlocked " @ levsel_7.unlocked);	
		levsel_8.unlocked = $sfile.readLine();
		echo("\c2 levsel_8.unlocked " @ levsel_8.unlocked);	
		levsel_9.unlocked = $sfile.readLine();
		echo("\c2 levsel_9.unlocked " @ levsel_9.unlocked);	
		levsel_10.unlocked = $sfile.readLine();
		echo("\c2 levsel_10.unlocked " @ levsel_10.unlocked);			
		
		//points accumulated
		$points_amount = $sfile.readLine();
		echo("\c2 $points_amount " @ $points_amount);
		
		//flying coins collected for trophy purposes
		$flying_coins_collected = $sfile.readLine();
		echo("\c2 $flying_coins_collected " @ $flying_coins_collected);

		$vortexes_collected = $sfile.readLine();
		echo("\c2 $vortexes_collected " @ $vortexes_collected);
		
		//toggle load states for mega manager trophy counter
		$trophy_toggle_off_plaque1 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque1 " @ $trophy_toggle_off_plaque1);
		$trophy_toggle_off_plaque2 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque2 " @ $trophy_toggle_off_plaque2);
		$trophy_toggle_off_plaque3 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque3 " @ $trophy_toggle_off_plaque3);
		$trophy_toggle_off_plaque4 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque4 " @ $trophy_toggle_off_plaque4);
		$trophy_toggle_off_plaque5 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque5 " @ $trophy_toggle_off_plaque5);
		$trophy_toggle_off_plaque6 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque6 " @ $trophy_toggle_off_plaque6);
		$trophy_toggle_off_plaque7 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque7 " @ $trophy_toggle_off_plaque7);
		$trophy_toggle_off_plaque8 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque8 " @ $trophy_toggle_off_plaque8);
		$trophy_toggle_off_plaque9 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque9 " @ $trophy_toggle_off_plaque9);
		$trophy_toggle_off_plaque10 = $sfile.readLine();
		echo("\c2 $trophy_toggle_off_plaque10 " @ $trophy_toggle_off_plaque10);

		$mega_manager_counter = $sfile.readLine();
		echo("\c2 $mega_manager_counter " @ $mega_manager_counter);

		$customers_served_counter = $sfile.readLine();
		echo("\c2 $customers_served_counter " @ $customers_served_counter);		

		//APPETIZERS
		$appetizer1_purchased1 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased1 " @ $appetizer1_purchased1);
		$appetizer1_amount1 = $sfile.readLine();
		echo("\c2 $appetizer1_amount1 " @ $appetizer1_amount1);
		$appetizer1_purchased2 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased2 " @ $appetizer1_purchased2);
		$appetizer1_amount2 = $sfile.readLine();
		echo("\c2 $appetizer1_amount2 " @ $appetizer1_amount2);	
		$appetizer1_purchased3 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased3 " @ $appetizer1_purchased3);
		$appetizer1_amount3 = $sfile.readLine();
		echo("\c2 $appetizer1_amount3 " @ $appetizer1_amount3);	
		$appetizer1_purchased4 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased4 " @ $appetizer1_purchased4);
		$appetizer1_amount4 = $sfile.readLine();
		echo("\c2 $appetizer1_amount4 " @ $appetizer1_amount4);		
		$appetizer1_purchased5 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased5 " @ $appetizer1_purchased5);
		$appetizer1_amount5 = $sfile.readLine();
		echo("\c2 $appetizer1_amount5 " @ $appetizer1_amount5);		
		$appetizer1_purchased6 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased6 " @ $appetizer1_purchased6);
		$appetizer1_amount6 = $sfile.readLine();
		echo("\c2 $appetizer1_amount6 " @ $appetizer1_amount6);		
		$appetizer1_purchased7 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased7 " @ $appetizer1_purchased7);
		$appetizer1_amount7 = $sfile.readLine();
		echo("\c2 $appetizer1_amount7 " @ $appetizer1_amount7);		
		$appetizer1_purchased8 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased8 " @ $appetizer1_purchased8);
		$appetizer1_amount8 = $sfile.readLine();
		echo("\c2 $appetizer1_amount8 " @ $appetizer1_amount8);	
		$appetizer1_purchased9 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased9 " @ $appetizer1_purchased9);
		$appetizer1_amount9 = $sfile.readLine();
		echo("\c2 $appetizer1_amount9 " @ $appetizer1_amount9);
		$appetizer1_purchased10 = $sfile.readLine();
		echo("\c2 $appetizer1_purchased10 " @ $appetizer1_purchased10);
		$appetizer1_amount10 = $sfile.readLine();
		echo("\c2 $appetizer1_amount10 " @ $appetizer1_amount10);	

		$appetizer2_purchased1 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased1 " @ $appetizer2_purchased1);
		$appetizer2_amount1 = $sfile.readLine();
		echo("\c2 $appetizer2_amount1 " @ $appetizer2_amount1);
		$appetizer2_purchased2 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased2 " @ $appetizer2_purchased2);
		$appetizer2_amount2 = $sfile.readLine();
		echo("\c2 $appetizer2_amount2 " @ $appetizer2_amount2);	
		$appetizer2_purchased3 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased3 " @ $appetizer2_purchased3);
		$appetizer2_amount3 = $sfile.readLine();
		echo("\c2 $appetizer2_amount3 " @ $appetizer2_amount3);	
		$appetizer2_purchased4 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased4 " @ $appetizer2_purchased4);
		$appetizer2_amount4 = $sfile.readLine();
		echo("\c2 $appetizer2_amount4 " @ $appetizer2_amount4);		
		$appetizer2_purchased5 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased5 " @ $appetizer2_purchased5);
		$appetizer2_amount5 = $sfile.readLine();
		echo("\c2 $appetizer2_amount5 " @ $appetizer2_amount5);		
		$appetizer2_purchased6 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased6 " @ $appetizer2_purchased6);
		$appetizer2_amount6 = $sfile.readLine();
		echo("\c2 $appetizer2_amount6 " @ $appetizer2_amount6);		
		$appetizer2_purchased7 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased7 " @ $appetizer2_purchased7);
		$appetizer2_amount7 = $sfile.readLine();
		echo("\c2 $appetizer2_amount7 " @ $appetizer2_amount7);		
		$appetizer2_purchased8 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased8 " @ $appetizer2_purchased8);
		$appetizer2_amount8 = $sfile.readLine();
		echo("\c2 $appetizer2_amount8 " @ $appetizer2_amount8);	
		$appetizer2_purchased9 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased9 " @ $appetizer2_purchased9);
		$appetizer2_amount9 = $sfile.readLine();
		echo("\c2 $appetizer2_amount9 " @ $appetizer2_amount9);
		$appetizer2_purchased10 = $sfile.readLine();
		echo("\c2 $appetizer2_purchased10 " @ $appetizer2_purchased10);
		$appetizer2_amount10 = $sfile.readLine();
		echo("\c2 $appetizer2_amount10 " @ $appetizer2_amount10);	

		$star_system_array = $sfile.readLine();
		echo("\c2 $star_system_array " @ $star_system_array);		
		
		$sfx_level = $sfile.readLine();
		echo("\c2 $sfx_level " @ $sfx_level);	
		$music_level = $sfile.readLine();
		echo("\c2 $music_level " @ $music_level);
		$soundfx_loudness = $sfile.readLine();
		echo("\c2 $soundfx_loudness " @ $soundfx_loudness);	
		$music_loudness = $sfile.readLine();
		echo("\c2 $music_loudness " @ $music_loudness);

		$entertainer1_bought_world1 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world1 " @ $entertainer1_bought_world1);
		$entertainer2_bought_world1 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world1 " @ $entertainer2_bought_world1);
		$entertainer1_bought_world2 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world2 " @ $entertainer1_bought_world2);
		$entertainer2_bought_world2 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world2 " @ $entertainer2_bought_world2);
		$entertainer1_bought_world3 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world3 " @ $entertainer1_bought_world3);
		$entertainer2_bought_world3 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world3 " @ $entertainer2_bought_world3);
		$entertainer1_bought_world4 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world4 " @ $entertainer1_bought_world4);
		$entertainer2_bought_world4 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world4 " @ $entertainer2_bought_world4);
		$entertainer1_bought_world5 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world5 " @ $entertainer1_bought_world5);
		$entertainer2_bought_world5 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world5 " @ $entertainer2_bought_world5);
		$entertainer1_bought_world6 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world6 " @ $entertainer1_bought_world6);
		$entertainer2_bought_world6 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world6 " @ $entertainer2_bought_world6);
		$entertainer1_bought_world7 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world7 " @ $entertainer1_bought_world7);
		$entertainer2_bought_world7 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world7 " @ $entertainer2_bought_world7);
		$entertainer1_bought_world8 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world8 " @ $entertainer1_bought_world8);
		$entertainer2_bought_world8 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world8 " @ $entertainer2_bought_world8);
		$entertainer1_bought_world9 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world9 " @ $entertainer1_bought_world9);
		$entertainer2_bought_world9 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world9 " @ $entertainer2_bought_world9);
		$entertainer1_bought_world10 = $sfile.readLine();
		echo("\c2 $entertainer1_bought_world10 " @ $entertainer1_bought_world10);
		$entertainer2_bought_world10 = $sfile.readLine();
		echo("\c2 $entertainer2_bought_world10 " @ $entertainer2_bought_world10);
		
		$touchpad_activated = $sfile.readLine();
		echo("\c2 $touchpad_activated " @ $touchpad_activated);	

		$mute_music = $sfile.readLine();
		echo("\c2 $mute_music " @ $mute_music);
		$mute_soundfx = $sfile.readLine();
		echo("\c2 $mute_soundfx " @ $mute_soundfx);
		$toggle_mute_music = $sfile.readLine();
		echo("\c2 $toggle_mute_music " @ $toggle_mute_music);		

		//edit 03-01-2014 check for file saving inconsistencies and repair
		if($current_level != $round_numeral)
		{
		echo("Error in reading current_level, fixing to proper number");
		$current_level = $round_numeral;
		}
		$sfile.close();
	}
	$sfile.close();
	
	/* CASES */
	$trophy_dollar_collected = $_trophy_dollar_activated;
	alxSetChannelVolume($GuiAudioType, $music_level);
	alxSetChannelVolume($GuiAudioType, $sfx_level);	
	
}


function purge_save_file()
{
echo("\c2 PURGING SAVE FILE " @ $bob_test);
purge_display2.text = "start purge @ " @ $current_profile_number;
$sfile = new FileObject();
$sfile.close();
if($sfile.openForWrite("./data/test" @ $current_profile_number @ ".ccf"))
{
purge_display3.text = "END purge";
%clear_line = "";
$clear_the_line = "";
echo("\c2 Purging File...");
$sfile.writeLine(%clear_line);
echo("\c2 purging bob_test " @ $bob_test);
$sfile.writeLine(%clear_line);
echo("\c2 purging current_level " @ $current_level);
$sfile.writeLine(%clear_line);
echo("\c2 purging round_numeral " @ $round_numeral);
$sfile.writeLine(%clear_line);
echo("\c2 purging world_numeral " @ $world_numeral);
$sfile.writeLine(%clear_line);
echo("\c2 purging coinage " @ $current_level);
$sfile.writeLine(%clear_line);
echo("\c2 purging coinage_max " @ $coinage_max);
/* trophies data */
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy1_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy2_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy3_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy4_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy5_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy6_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy7_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy8_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_trophy9_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque1_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque2_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque3_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque4_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque5_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque6_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque7_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque8_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque9_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_plaque10_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon1_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon2_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon3_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon4_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon5_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_ribbon6_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button1_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button2_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button3_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button4_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button5_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_button6_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_mount1_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_mount2_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_mount3_activated " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 _trophy_mount4_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 trophy_dollar " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 trophy_all_gold_in_round " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 trophy_angered_a_customer " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 trophy_no_angry_customers " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 points_you_have " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 points_you_need " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 trophy_toggle_off_all_gold_in_round " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 maximum_level_player_got_to " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 maximum_world_player_got_to " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 levsel_1.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_2.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_3.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_4.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_5.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_6.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_7.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_8.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_9.unlocked " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 levsel_10.unlocked " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $points_amount " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $flying_coins_collected " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $vortexes_collected " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque1 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque2 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque3 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque4 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque5 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque6 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque7 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque8 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque9 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $trophy_toggle_off_plaque10 " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $mega_manager_counter " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $customers_served_counter " @ $clear_the_line);

//APPETIZERS
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased1 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount1 " @ $clear_the_line);
purge_tester.text = $clear_the_line;
purge_tester2.text = $appetizer1_amount1;
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased2 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount2 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased3 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount3 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased4 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount4 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased5 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount5 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased6 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount6 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased7 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount7 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased8 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount8 " @ $clear_the_line);	
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased9 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount9 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer1_purchased10 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer1_amount10 " @ $clear_the_line);

$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased1 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount1 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased2 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount2 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased3 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount3 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased4 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount4 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased5 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount5 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased6 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount6 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased7 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount7 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased8 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount8 " @ $clear_the_line);	
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased9 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount9 " @ $clear_the_line);
$sfile.writeLine(1);
echo("\c2 $appetizer2_purchased10 " @ $clear_the_line);
$sfile.writeLine(10);
echo("\c2 $appetizer2_amount10 " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $star_system_array " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $sfx_level " @ $clear_the_line);	
$sfile.writeLine($clear_the_line);
echo("\c2 $music_level " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $soundfx_loudness " @ $clear_the_line);	
$sfile.writeLine($clear_the_line);
echo("\c2 $music_loudness " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world1 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world1 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world2 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world2 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world3 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world3 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world4 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world4 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world5 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world5 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world6 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world6 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world7 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world7 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world8 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world8 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world9 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world9 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer1_bought_world10 " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $entertainer2_bought_world10 " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $touchpad_activated " @ $clear_the_line);

$sfile.writeLine($clear_the_line);
echo("\c2 $mute_music " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $mute_soundfx " @ $clear_the_line);
$sfile.writeLine($clear_the_line);
echo("\c2 $toggle_mute_music " @ $clear_the_line);		
	
//edit 03-01-2014 defaults get erased if another file previously reset them, make them into inventory-based defaults
$sfile.close();
reload_factory_settings();
}

}

