// ***************************************************************************************
// File Name:   profileInputIO.cs
// Author:      Roger Campbell 
// Purpose:     Define key inputs for profiles
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function comptroller::onLevelLoaded( % this, % scenegraph) {

 % temporary_field = $input_field_01;

 echo("Profile KeyMap IO Start Loaded");

 moveMap.bindCmd(keyboard, "a", "a_down();", "a_up();");
 moveMap.bindCmd(keyboard, "b", "b_down();", "b_up();");
 moveMap.bindCmd(keyboard, "c", "c_down();", "c_up();");
 moveMap.bindCmd(keyboard, "d", "d_down();", "d_up();");
 moveMap.bindCmd(keyboard, "e", "e_down();", "e_up();");
 moveMap.bindCmd(keyboard, "f", "f_down();", "f_up();");
 moveMap.bindCmd(keyboard, "g", "g_down();", "g_up();");
 moveMap.bindCmd(keyboard, "h", "h_down();", "h_up();");
 moveMap.bindCmd(keyboard, "i", "i_down();", "i_up();");
 moveMap.bindCmd(keyboard, "j", "j_down();", "j_up();");
 moveMap.bindCmd(keyboard, "k", "k_down();", "k_up();");
 moveMap.bindCmd(keyboard, "l", "l_down();", "l_up();");
 moveMap.bindCmd(keyboard, "m", "m_down();", "m_up();");
 moveMap.bindCmd(keyboard, "n", "n_down();", "n_up();");
 moveMap.bindCmd(keyboard, "o", "o_down();", "o_up();");
 moveMap.bindCmd(keyboard, "p", "p_down();", "p_up();");
 moveMap.bindCmd(keyboard, "q", "q_down();", "q_up();");
 moveMap.bindCmd(keyboard, "r", "r_down();", "r_up();");
 moveMap.bindCmd(keyboard, "s", "s_down();", "s_up();");
 moveMap.bindCmd(keyboard, "t", "t_down();", "t_up();");
 moveMap.bindCmd(keyboard, "u", "u_down();", "u_up();");
 moveMap.bindCmd(keyboard, "v", "v_down();", "v_up();");
 moveMap.bindCmd(keyboard, "w", "w_down();", "w_up();");
 moveMap.bindCmd(keyboard, "x", "x_down();", "x_up();");
 moveMap.bindCmd(keyboard, "y", "y_down();", "y_up();");
 moveMap.bindCmd(keyboard, "z", "z_down();", "z_up();");
 moveMap.bindCmd(keyboard, "backspace", "bs_down();", "bs_up();");
 moveMap.bindCmd(keyboard, "enter", "en_down();", "en_up();");
 moveMap.bindCmd(keyboard, "space", "sp_down();", "sp_up();");
 //moveMap.bindCmd(keyboard, "alt enter", "alt_down();", "alt_up();");
 moveMap.bindCmd(keyboard, "anykey", "any_down();", "any_up();");
 //moveMap.bindCmd(keyboard, "anykey", "ak_down();", "ak_up();"); 
 moveMap.bindCmd(keyboard, "1", "one_down();", "one_up();");
 moveMap.bindCmd(keyboard, "2", "two_down();", "two_up();");
 moveMap.bindCmd(keyboard, "3", "three_down();", "three_up();");
 moveMap.bindCmd(keyboard, "4", "four_down();", "four_up();");
 moveMap.bindCmd(keyboard, "5", "five_down();", "five_up();");
 moveMap.bindCmd(keyboard, "6", "six_down();", "six_up();");
 moveMap.bindCmd(keyboard, "7", "seven_down();", "seven_up();");
 moveMap.bindCmd(keyboard, "8", "eight_down();", "eight_up();");
 moveMap.bindCmd(keyboard, "9", "nine_down();", "nine_up();");
 moveMap.bindCmd(keyboard, "0", "zero_down();", "zero_up();");

 $prof_slot = 1;
 $donewriting = 0;
}

function cheat1_down() {
 echo("CHEAT ENTERED");
}

function read_string_first() {
 echo("read string first activated");
 end_blinky_underscore();
 $current_profile_slot = "prof_name_input_field"
 @ $input_to_profile_slot;
 $check_string_length = strLen($current_profile_slot.text);

 //edit 02-03-2014 exception for characters entered for the first time in zero slot
 if ($GAME_HAS_NEVER_BEEN_STARTED == 1) {
  $input_to_profile_slot = 0;
 }
 //edit 02-27-2014 adding check for profile slot key downs
 if ($clicked_down_on_a_profile == 1) {
  $key_down_on_a_profile = 1;
  $current_profile_slot.exists = 1;
  //edit 03-22-2014 this does not work because profile slot and text has to be declared first
 }

}

function write_additional_data() {
 $bob_test = $current_profile_slot.text;
 write_to_save_file();
}

function end_blinky_underscore() {
 blinky_underscore.setBlendAlpha(0);
 $no_blinky_underscore = 1;
}

function blinky_underscore::animate_blinky_underscore1( % this) {
 if ($no_blinky_underscore != 1) {
  blinky_underscore.setBlendAlpha(0);
  blinky_underscore.schedule(700, "animate_blinky_underscore2", 0);
 }
}

function blinky_underscore::animate_blinky_underscore2( % this) {
  if ($no_blinky_underscore != 1) {
   blinky_underscore.setBlendAlpha(1);
   blinky_underscore.schedule(700, "animate_blinky_underscore1", 0);
  }
 }
 //-------------------------------------------------------------------BACKSPACE
function bs_down() {
 if ($profile_downed == 1) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot;
  $key_down_toggled = 1;
  rewrite_word();
  write_additional_data();
 }
}

function rewrite_word() {
 $current_string_length = strLen($current_profile_slot.text);
 //note, it's negative one because counting is 1-10 and listing is 0-9, so you have to go back a space
 if ($current_string_length >= -1) { % add_letter = getSubStr($current_profile_slot.text, $backspace_number, 1);

  //note this is minus 2 because strLen counts literal number, getSubStr counts starting at 0
  $new_string_length = $current_string_length - 2;
  //18 letters max
  % pre_letter = $new_string @ % add_letter;
  $new_string = % pre_letter;
  echo("\c2 $backspace_number " @ $backspace_number @ " vs $new_string_length " @ $new_string_length);
  //count up the number of letters sans a letter, because it has been backspaced
  if ($backspace_number < $new_string_length) {
   $backspace_number += 1;
   rewrite_word();
  }
  //respell the entire word sans a letter based on counting above
  if ($backspace_number >= $new_string_length) {
   echo($new_string);
   $back_spaced_toggled = 1;
   $current_string_length = $new_string_length; 
   % change_name = $new_string;
   $current_profile_slot.text = % change_name;
   $backspace_number = 0;
   $toggle_refresh_of_new_string = 1;
  }

  //refresh the string based on keyDown so it doesn't double up the entire word from the last word in memory cache
  if ($toggle_refresh_of_new_string == 1) {
   $new_string = "";
   $toggle_refresh_of_new_string = 0;

   //backspacing exception for counting starting at 1 and listing starting at 0
   //eg if backspacing, and on the last letter, erase it by just making it blank
   if ($new_string_length == -1) {
    $current_profile_slot.text = "";
   }
  }
 }

}

function any_down() {
 //note! not ANY key just alternatives, like shift, ctrl, and alt. torque stuff
 echo("ANY EXTRA KEY ENTERED");
}

function any_up() {
 //note! not ANY key just alternatives, like shift, ctrl, and alt. torque stuff
 echo("ANY EXTRA KEY UN-ENTERED");
}

function bs_up() {
 //do nothing
}
//-------------------------------------------------------------------Enter
function en_down() {
 //do nothing
}

function en_up() {
 //do nothing
}
//-------------------------------------------------------------------Space
function sp_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ " ";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function sp_up() {
 //do nothing
}
//-------------------------------------------------------------------A
function a_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  echo("AAAAAAAA = "
   @ $input_to_profile_slot);
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot;
  echo("AAAAAAAA2 = "
   @ $current_profile_slot); % prev_string = $current_profile_slot.text;
  echo("AAAAAAAA3 = "
   @ % prev_string);
  $current_profile_slot.text = % prev_string @ "A";
  echo("AAAAAAAA4 = "
   @ $current_profile_slot.text);
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 1) {
  $cheat_letters = 2;
 }
}

function a_up() {
 //do nothing
}
//-------------------------------------------------------------------B
function b_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "B";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 4) {
  $cheat_letters = 5;
 }
}

function b_up() {
 //do nothing
}
//-------------------------------------------------------------------C
function c_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "C";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 5) {
  $cheat_letters = 9;
  echo("CHEAT ENTERED: BOOST COINS");
  $coinage += 2000;
  score_number.text = $coinage;
 }
}

function c_up() {
 //do nothing
}
//-------------------------------------------------------------------D
function d_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "D";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 5) {
  $cheat_letters = 10;
  echo("CHEAT ENTERED: BRING DEBUG");
  debug_mode_button.onMouseDown();
  debug_mode_button.onMouseUp();
 }

}

function d_up() {
 //do nothing
}
//-------------------------------------------------------------------E
function e_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "E";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function e_up() {
 //do nothing
}
//-------------------------------------------------------------------F
function f_down() {
 echo("f key pressed");
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  echo("f key passed");
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "F";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function f_up() {
 //do nothing
}
//-------------------------------------------------------------------G
function g_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "G";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 5) {
  $cheat_letters = 8;
  echo("CHEAT ENTERED: BEAT GAME");
 }
}

function g_up() {
 //do nothing
}
//-------------------------------------------------------------------H
function h_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "H";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function h_up() {
 //do nothing
}
//-------------------------------------------------------------------I
function i_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "I";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function i_up() {
 //do nothing
}
//-------------------------------------------------------------------J
function j_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "J";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function j_up() {
 //do nothing
}
//-------------------------------------------------------------------K
function k_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "K";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function k_up() {
 //do nothing
}
//-------------------------------------------------------------------L
function l_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "L";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 5 & $screen_locator == 4) {
  $cheat_letters = 6;
  echo("CHEAT ENTERED: BEAT LEVEL");
  coin_me_up.record_me = 1;
  $points_you_have = 250000;
  $star_sys_medal_won = 3;
  if ($world_numeral == 1 & $current_level == 1) {
   tut_no_button.onMouseUp( % this, % modifier, % worldPosition, % mouseClicks);
   $stopgap_for_cheat_through = 1;
  }
  empty_coin1.onMouseDown();
 }
}

function l_up() {
 //do nothing
}
//-------------------------------------------------------------------M
function m_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "M";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function m_up() {
 //do nothing
}
//-------------------------------------------------------------------N
function n_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "N";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function n_up() {
 //do nothing
}
//-------------------------------------------------------------------O
function o_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "O";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 2) {
  $cheat_letters = 3;
 }
}

function o_up() {
 //do nothing
}
//-------------------------------------------------------------------P
function p_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "P";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function p_up() {
 //do nothing
}
//-------------------------------------------------------------------Q
function q_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "Q";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function q_up() {
 //do nothing
}
//-------------------------------------------------------------------R
function r_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "R";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function r_up() {
 //do nothing
}
//-------------------------------------------------------------------S
function s_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "S";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 3) {
  $cheat_letters = 4;
 }
}

function s_up() {
 //do nothing
}
//-------------------------------------------------------------------T
function t_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "T";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function t_up() {
 //do nothing
}
//-------------------------------------------------------------------U
function u_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "U";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function u_up() {
 //do nothing
}
//-------------------------------------------------------------------V
function v_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "V";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function v_up() {
 //do nothing
}
//-------------------------------------------------------------------W
function w_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "W";
  $key_down_toggled = 1;
  write_additional_data();
 }
 if ($cheat_letters == 5 & $screen_locator == 12 & $current_level >= 2) {
  $cheat_letters = 7;
  echo("CHEAT ENTERED: BEAT WORLD");
  cheatsies.cheat_button = 999;
  cheatsies.unlocked = 1;
  cheatsies.switch_to_round = 10;
  cheatsies.onMouseDown( % this);
  cheatsies.onMouseUp( % this);
  comptroller.schedule(500, "delaylevelbeat", 0);
  $stopgap_for_cheat_through = 1;
 }
 if ($cheat_letters == 5 & $screen_locator == 11 & $current_level >= 2) {
  $cheat_letters = 7;
  echo("CHEAT ENTERED: BEAT WORLD");
  cheatsies.cheat_button = 999;
  cheatsies.unlocked = 1;
  cheatsies.switch_to_round = 10;
  cheatsies.onMouseDown( % this);
  cheatsies.onMouseUp( % this);
  comptroller.schedule(500, "delaylevelbeat", 0);
  $stopgap_for_cheat_through = 1;
 }
 if ($cheat_letters == 5 & $screen_locator == 1 & $current_level >= 2) {
  $cheat_letters = 7;
  echo("CHEAT ENTERED: BEAT WORLD");
  cheatsies.cheat_button = 999;
  cheatsies.unlocked = 1;
  cheatsies.switch_to_round = 10;
  cheatsies.onMouseDown( % this);
  cheatsies.onMouseUp( % this);
  comptroller.schedule(500, "delaylevelbeat", 0);
  $stopgap_for_cheat_through = 1;
 }
}

function comptroller::delaylevelbeat() {
 coin_me_up.record_me = 1;
 $points_you_have = 250000;
 $star_sys_medal_won = 3;
 empty_coin1.onMouseDown();
}

function w_up() {
 //do nothing
}
//-------------------------------------------------------------------x
function x_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "X";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function x_up() {
 //do nothing
}
//-------------------------------------------------------------------Y
function y_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "Y";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function y_up() {
 //do nothing
}
//-------------------------------------------------------------------Z
function z_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "Z";
  $key_down_toggled = 1;
  write_additional_data();
 }
 $cheat_letters = 1;
}

function z_up() {
 //do nothing
}

//NUMBERS---------------------------------------------
//NUMBERS---------------------------------------------
//NUMBERS---------------------------------------------

function one_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "1";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function one_up() {
 //do nothing
}

function two_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "2";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function two_up() {
 //do nothing
}

function three_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "3";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function three_up() {
 //do nothing
}

function four_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "4";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function four_up() {
 //do nothing
}

function five_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "5";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function five_up() {
 //do nothing
}

function six_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "6";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function six_up() {
 //do nothing
}

function seven_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "7";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function seven_up() {
 //do nothing
}

function eight_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "8";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function eight_up() {
 //do nothing
}

function nine_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "9";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function nine_up() {
 //do nothing
}

function zero_down() {
 read_string_first();
 if ($profile_downed == 1 & $check_string_length <= $profile_char_limit) {
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % prev_string = $current_profile_slot.text;
  $current_profile_slot.text = % prev_string @ "0";
  $key_down_toggled = 1;
  write_additional_data();
 }
}

function zero_up() {
 //do nothing
}

// LEGACY ------------------------------------------
//---------------------------------------------------write everything to file
function writeProfile1()
{
 % file = new FileObject();

 if ( % file.openForWrite("./data/profileData.txt"))
 {
  echo("Profile Writeline Operational"); % file.writeLine(text_input1.text @ text_input2.text @ text_input3.text @ text_input4.text @ text_input5.text @ text_input6.text @ text_input7.text @ text_input8.text @ text_input9.text @ text_input10.text @ text_input11.text @ text_input12.text @ text_input13.text @ text_input14.text @ text_input15.text); % file.writeLine("testing writing");
 } 
 else
 {
  error("File is not open for writing");
 }

 % file.close();
 % file.delete();

}
//----------------------------------FIX ME LATER FOR SAVE IMPORTING

function readProfile1()

{
 echo("legacy readProfile1 activated but I made it do nothing now");
}
