// ***************************************************************************************
// File Name:   pre_done_button.cs
// Author:      Roger Campbell 
// Purpose:     Functions for reading and writing profile input data
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function profileInput1::onAdd( % this) { % this.setUseMouseEvents(true);
 $profile_downed = 0;
}

function profileInput1::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 //if untoggled, go to hover frame
 if ($profile_downed == 0 & % this.is_current_profile != 1) { % this.setFrame("2");
 }
}

function profileInput1::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 //if untoggled, go back to original frame
 if ($profile_downed == 0 & % this.is_current_profile != 1) { % this.setFrame("0");
 }
}

function profileInput1::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //read_from_unique_save_file();
  //edit 02-04-2014 detect if first profile ever pressed so you can find text amount later for a simple underscore
  if ( % this.first_press_ever == 2) {
   $first_profile_slot_ever_pressed = 1;
  }

  prof_name_input_field1.font = "cambo";
  prof_name_input_field2.font = "cambo";
  prof_name_input_field3.font = "cambo";
  prof_name_input_field4.font = "cambo";
  //toggled only once, erase initial underscore if first time clicking on profile_slot0
  if ( % this.slot_num == 0 & $toggle_slot_zero_clearer != 1) {
   prof_name_input_field1.text = "";
   _prof_name_input_field1.text = "";
   $toggle_slot_zero_clearer = 1;
   //note- it should never return to this if statement again because this function will only be available once ever
  }
  //edit 02-03-2014 special case first start of game ever
  if ($GAME_HAS_NEVER_BEEN_STARTED == 1) {
   prof_name_input_field0.text = "";
   prof_name_input_field1.text = "";
   _prof_name_input_field1.text = "";
   $toggle_slot_zero_clearer = 1;

  }

  echo( % this.slot_num);
 }
}

function profileInput1::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-10-2015 need to see if any profile has been clicked
  $any_profile_slot_has_been_clicked = 1;

  if ( % this.slot_num == 1) {
   $this_is_the_first_time_ever_played = 1;
  }
  if ( % this.slot_num != 1) {
   $this_is_the_first_time_ever_played = 2;
  }

  $profile_number_for_erasing = % this.slot_num;

  if ($last_profile_played == % this.slot_num) {
   $game_profile_has_not_yet_changed = 1;
  }
  if ($last_profile_played != % this.slot_num) {
   $game_profile_has_not_yet_changed = 0;
  }

  % get_this_slot_num = % this.slot_num;
  $temp_record_profile_slot_info = "profile_text_slot"
  @ % get_this_slot_num;
  $test_amount_of_played = profile_text_slot1.has_ever_actually_been_played + profile_text_slot2.has_ever_actually_been_played + profile_text_slot3.has_ever_actually_been_played + profile_text_slot4.has_ever_actually_been_played;

  //needs to be if this.purged == 0 and this.has_ever_actually_been_played == 1
  if ( % this.purged == 0 & % this.has_ever_actually_been_played == 1 & $test_amount_of_played >= 1) {
   $make_start_button_into_continue = 1;
  }
  //new profiles dont know if theyre purged or not, hence this.purged ==   ; 
  //but this is half of the problem.............. 
  if ( % this.purged == 1) {
   $make_start_button_into_continue = 0;
   //edit 02-22-2015 special circumstance disable
   $hearts_disable_from_coin_tip = 1;
   //edit 02-22-2015 special circumstance disable
   $hearts_disable_from_coin_tip = 1;
   sched_cancel_all(); % this.purged = 0; % this.track_purged = 1;
  }

  if ( % this.has_ever_actually_been_played != 1 & $test_amount_of_played >= 1) {
   //06-30-2014 this was the cause during shifting, need to investigate what it does
   erase_this_slot();
   $make_start_button_into_continue = 0;
   sched_cancel_all(); % this.purged = 0;

  }

  //edit 02-27-2014 reset all mouseUp states for profile buttons and declare this as only one up
  profile_text_slot0.setFrame(0);
  profile_text_slot1.setFrame(0);
  profile_text_slot2.setFrame(0);
  profile_text_slot3.setFrame(0);
  profile_text_slot4.setFrame(0); % this.setFrame(1);
  //edit 02-27-2014 added to check for profile slot mousedowns
  $clicked_down_on_a_profile = 1;
  //edit 02-27-2014 added to check for profile slot keydowns
  if ($key_down_on_a_profile != 0) {

  }
  //end edit 02-16-2014
  $deactivate_all_clear_profilers = 0;
  $profile_has_been_moused_down = 1;
  $profile_downed = 0;
  $input_to_profile_slot = % this.slot_num;
  //$bob_test = $current_profile_slot.text;
  $bob_test = % this.slot_num;
  //write_to_save_file();
  $current_profile_slot = "prof_name_input_field"
  @ $input_to_profile_slot; % this.is_current_profile = 1; % find_current_profile_image = "profile_text_slot" @ $profile_for_this_session;

  //edit 12-22-2013 activate new profile eraser, hide and disable old ones
  % find_previous_profile_eraser = "clear_profile"
  @ $profile_for_this_session; % find_new_profile_eraser = "clear_profile" @ $input_to_profile_slot; 
  % find_previous_profile_eraser.is_active = 0; 
  % find_new_profile_eraser.is_active = 1; 
  % find_previous_profile_eraser.setImageMap(empty_coinImageMap);

  % find_current_profile_image.is_current_profile = 0;
  $current_profile_number = $input_to_profile_slot;
  $bob_test = % this.slot_num;

  /* 	NEED A WRITE TO SAVE FILE SINCE LETTERS ACTIVATE IT, BUT ALSO NEED A READ FROM SAVE FILE, IF LETTERS ARE PRESENT, IF THE SLOT ALONE IS CLICKED *SIGH* */
  if ($current_profile_slot.exists == 0) {
   write_to_save_file();
   //edit 03-02-2014 editing ability to clear 'NEW PROFILE' immediately after clicking
   % erase_name = "prof_name_input_field" @ % this.slot_num; % erase_name.text = "";

  }
  if ($current_profile_slot.exists == 1) {
   read_from_save_file();
  }

  $profile_for_this_session = % this.slot_num;
  testerxx.text = "profile_text_slot" @ $profile_for_this_session;

  /* START COPY PASTED CODE FROM MOUSEDOWN STATE*/
  //if pressed down for the first time, excluding MouseLeave without MouseUp, set mouseDown frame
  if ($profile_downed == 0) {
   $input_to_profile_slot = % this.slot_num;
   $profile_for_this_session = % this.slot_num;
   $sfile = new FileObject();
   if ($sfile.openForWrite("./data/profile_finder.ccf")) {
    $sfile.writeLine($profile_for_this_session);
    $sfile.close();
   }
   //reusing this so you commit to a profile before quitting
   $disallow_leaving_profile_menu_until_choose_new_slot = 1;
   the_cancel_button.setFrame("3");
   prof_screen_done.setFrame("3");
   $toggle_this_slot_only = % this.slot_num;
  }
  //if pressed down, second time, after mouseUp has been toggled, trigger untoggle catalyst
  if ($profile_downed == 1 & $toggle_this_slot_only == % this.slot_num) {
   if ( % this.slot_num == 0) {
    prof_name_input_field1.text = prof_name_input_field0.text;
    _prof_name_input_field1.text = prof_name_input_field0.text;
    $profile_for_this_session = 1;
    $input_to_profile_slot = 1; % this.slot_num = 1;
   }
   $current_profile_number = $input_to_profile_slot;
   $profile_for_this_session = $input_to_profile_slot;

   //$bob_test = $current_profile_slot.text;
   if ($key_down_toggled == 1 & $key_down_on_a_profile != 0) {
    write_to_save_file();
   } 
   % find_profile_for_dynamic_slot = "prof_name_input_field" @ $profile_for_this_session; 
   % read_profile_for_dynamic_slot = % find_profile_for_dynamic_slot.text;
   dynamic_name_slot.text = % read_profile_for_dynamic_slot;
   _dynamic_name_slot.text = % read_profile_for_dynamic_slot;
   % activate_canceler = "clear_profile" @ $input_to_profile_slot; 
   % activate_canceler.setImageMap(empty_char_spaceImageMap);
   $key_down_toggled = 0;
   $disallow_leaving_profile_menu_until_choose_new_slot = 0;
   the_cancel_button.setFrame("0");
   prof_screen_done.setFrame("0");
  }
  /* END COPY PASTED CODE FROM MOUSEDOWN STATE*/

  $sfile = new FileObject();
  if ($sfile.openForRead("./data/profile_finder.ccf")) {
   //edit 08-12-2013 edit for improper syntax
   $profile_for_this_session = $sfile.readLine();
   echo("\c2 confirming profile readline as: " @ $profile_for_this_session);
   $sfile.close();
  }
  $sfile.close();
  //If mouse released on button for first time, excluding MouseLeave, toggle button via mouseUp, set mouseUp frame
  if ($profile_downed == 0) {
   $profile_downed = 1;
   echo("\c2 profile down at " @ $profile_downed);
   $input_to_profile_slot = % this.slot_num;
   % activate_canceler = "clear_profile"
   @ $input_to_profile_slot; 
   % activate_canceler.setImageMap(ui_icon_eraserImageMap);
   $disallow_leaving_profile_menu_until_choose_new_slot = 1;
   the_cancel_button.setFrame("3");
   prof_screen_done.setFrame("3");
  }

  //If mouse released on button for second time, signifying end of toggle via mouseUp, unrelease toggle, set back to original frame
  if ($profile_downed == 2) {
   echo("\c2 profile down at " @ $profile_downed);
   $disallow_leaving_profile_menu_until_choose_new_slot = 0;
   the_cancel_button.setFrame("0");
   prof_screen_done.setFrame("0");

  }
  $profile_for_this_session = % this.slot_num;
 }
 //edit 02-10-2015 if executable has never been played via startbutton, you should never be able to continue through ever!
 if ($startbutton_has_been_activated != 2) {
  $make_start_button_into_continue = 0;
 }
}

function hide_all_clear_profilers() {
 $deactivate_all_clear_profilers = 1;
 clear_profile1.setImageMap(empty_char_spaceImageMap);
 clear_profile2.setImageMap(empty_char_spaceImageMap);
 clear_profile3.setImageMap(empty_char_spaceImageMap);
 clear_profile4.setImageMap(empty_char_spaceImageMap);
}

function clear_profiler::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($deactivate_all_clear_profilers != 1 & % this.is_active == 1) { 
  % this.was_pressed = 1; 
  % profile_temp_ident_slot = "profile_text_slot" @ % this.num; 
  % profile_temp_ident_slot.purged = 1; 
  % profile_temp_ident_slot.has_ever_actually_been_played = 0;
   purge_display.text = 1;
   echo("clear_profiler activated"); % this_num = % this.num; % reciprocating_text_slot = "prof_name_input_field" @ % this_num; % reciprocating_text_slot.text = "";
   $current_profile_number = % this_num;
   clear_any_bad_legacy_data();
   purge_save_file();
   purge_app_display.text = $appetizer1_amount1;
   purge_app_display2.text = $appetizer2_amount1;
   % this.setImageMap(empty_char_spaceImageMap);
   $disallow_leaving_profile_menu_until_choose_new_slot = 1;
   the_cancel_button.setFrame("3");
   prof_screen_done.setFrame("3");
   $profile_downed = 0;
   % find_correct_slot = "profile_text_slot" @ % this_num; % find_correct_slot.setFrame("0");
   first_start_equalize_appetizers();
  }
 }
}

function erase_this_slot() {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { 
 % profile_temp_ident_slot = "profile_text_slot" @ $profile_number_for_erasing; 
 % profile_temp_ident_slot.purged = 1; 
 % profile_temp_ident_slot.has_ever_actually_been_played = 0;
  purge_display.text = 1;
  $current_profile_number = % this_num;
  clear_any_bad_legacy_data();
  //edit 06-30-2014 this needs to be moved
  purge_save_file();
  purge_app_display.text = $appetizer1_amount1;
  purge_app_display2.text = $appetizer2_amount1;
  $disallow_leaving_profile_menu_until_choose_new_slot = 1;
  the_cancel_button.setFrame("3");
  prof_screen_done.setFrame("3");
  $profile_downed = 0;
  echo("\c2 clear at " @ $profile_downed); 
  % find_correct_slot = "profile_text_slot" @ % this_num; % find_correct_slot.setFrame("0");
  first_start_equalize_appetizers();
 }
}

function clear_profiler::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 purge_display.text = 0;
 purge_display2.text = 0;
 purge_display3.text = 0;
}

function clear_any_bad_legacy_data() {
 $current_profile_number = % this_num;
 purge_save_file();
 $disallow_leaving_profile_menu_until_choose_new_slot = 1;
 the_cancel_button.setFrame("3");
 prof_screen_done.setFrame("3");
 $profile_downed = 0;
}