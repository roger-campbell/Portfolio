// ***************************************************************************************
// File Name:   pre_done_button.cs
// Author:      Roger Campbell 
// Purpose:     Functions for "done" buttons that initialize game and profile data
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function pre_done_button::onAdd( % this) {

 //enable button
 % this.setUseMouseEvents(true);
 % this.timer1 += 1;
 $textobject1 = 2;
}

function pre_done_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 //temp hack fix for jen
 $disallow_leaving_profile_menu_until_choose_new_slot = 0;

 if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("1");
 }
 if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
 }
}

function pre_done_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 //temp hack fix for jen
 $disallow_leaving_profile_menu_until_choose_new_slot = 0;

 if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("0");
 }
 if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
 }
}

function pre_done_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 02-26-2014 check current profile length to prevent user from leaving if empty
  check_current_profile_text_length();

  if ($check_profile_slot_text_length != 0) {
   //temp hack fix for jen
   $disallow_leaving_profile_menu_until_choose_new_slot = 0;

   if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) {
    $default_audio = "mainmenu_theme";
   }
   if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
   }
  }
 }
}

function pre_done_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 //edit 06-30-2014 if first game ever for this slot confirmed, purge any remaining data
  if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 02-26-2014 check current profile length to prevent user from leaving if empty
  check_current_profile_text_length();
  if ($check_profile_slot_text_length == 0) {
   profile_name_warning.setBlendAlpha(1);
   profile_name_warning2.setBlendAlpha(1);
   if ( % this.first_done_ever == 1) {
    comptroller.blinky_profile_box_first_profile();
   }
   if ( % this.first_done_ever != 1) {
    comptroller.blinky_profile_box();
   }

  }

  if ($check_profile_slot_text_length != 0) {

   profile_name_warning.setBlendAlpha(0);
   profile_name_warning2.setBlendAlpha(0);
   //check done button to see if it is the first profile done button ever
   if ( % this.first_done_ever == 1) {
    $this_is_the_first_time_ever_played = 1;
    //if you clicked the slot number, determine dynamic name text length based on -1, because the first profile starts with an underscore character which counts as 1
    if ($first_profile_slot_ever_pressed == 1) { % find_text_length = strlen(prof_name_input_field0.text);
     $stop_pre_done_button_from_continuing = 0;
    }
    //if you didn't click the first slot number, the lenght would be 99 as to not reset anything current by accident, thus start and end count as 0 as underscore is erased
    if ($first_profile_slot_ever_pressed == 99) {
     $first_ever_text_length = 0;
     $stop_pre_done_button_from_continuing = 1;
    }
    if ($first_ever_text_length >= 0) {
     $pre_done_button_toggle = 0;
     $stop_pre_done_button_from_continuing = 0;
     //double check to make sure this is the first profile entered (via game.cs exception), ever, and then copy early profile0 data to profile1 so the computer can utilize later in this file
     if ($first_game_ever_played_predetected == 1) {
      prof_name_input_field1.text = prof_name_input_field0.text;
      _prof_name_input_field1.text = prof_name_input_field0.text;
      //edit 03-01-2014 declaring current profile at FIRST start
      $current_profile_slot = "prof_name_input_field1";
     }
    }
    //edit 03-22-2014 this info makes it so if first time ever, record a profile test1.ccf with data instead of unknown profile test.ccf, so if you switch profiles at this point,
    //that it won't break
    $current_profile_number = 1;
    $bob_test = $current_profile_slot.text;
    prof_name_input_field1.text = $bob_test;
    _prof_name_input_field1.text = $bob_test;
    $current_profile_slot.exists = 1;
    write_to_save_file();
   }

   //temp hack fix for jen
   $disallow_leaving_profile_menu_until_choose_new_slot = 0;

   //12-22-2013 added this to make sure the player doesnt leave with an empty profile name
   $check_current_string_length = strlen(prof_name_input_field0.text);
   if ($check_current_string_length == 0) {
    //edit 02-04-2014 retrofitting first profile checker to check if mouseDown is truly zero
    echo("prof_name_input_fieldX.text = "
     @ prof_name_input_field0.text);
    $disallow_leaving_profile_menu_until_choose_new_slot = 1;
   }
   //edit 02-04-2014 nothing to check after string length had increased from zero to reset it back to true... which would be bad.
   if ($check_current_string_length > 0) {
    $disallow_leaving_profile_menu_until_choose_new_slot = 0;
    $pre_done_button_toggle = 0;
   }

   if ($stop_pre_done_button_from_continuing != 1) {
    //if allowed to leave menu and no toggles are on, go forth
    if ($disallow_leaving_profile_menu_until_choose_new_slot != 1 & $pre_done_button_toggle != 1) {
     if ($profile_has_been_moused_down == 1) {
      $bob_test = $current_profile_slot.text;
     }
     if ($profile_has_been_moused_down == 0) {
      $bob_test = dynamic_name_slot.text;
     }
     //02-06-2014 adding exception for profile name and number to be recorded differently if first time ever playing game
     if ($first_game_ever_played_predetected == 1) {
      $bob_test = $current_profile_slot.text;
     }
     //02-27-2014 ERROR: this is where it rewrites the profile if you go to profile menu and click done immediately
     if ($clicked_down_on_a_profile != 0 & $key_down_on_a_profile != 0) {
      write_to_save_file();
     }
     //edit detect if pre_done_button is from profile menu via personal dynamic field
     if ( % this.from_prof_menu != 1) {
      main_menu_bkgd.start_animations();
      mm_logo.schedule(1000, "delay_in", 0);
      mm_callie.schedule(1100, "delay_in", 0);
      mm_start_button.schedule(1200, "delay_in", 0);
      button_options.schedule(1300, "delay_in", 0);
      mm_exit_button.schedule(1350, "delay_in", 0);
      mm_profile_button.schedule(1375, "delay_in", 0);
      mm_music_starter.schedule(1600, "delay_in", 0);
     }

     //08-05-2013 Ignite profiles via temp done button	
     $sfile = new FileObject();

     //edit 08-12-2013 Apparently I copied a "done" buttons code, which has awful legacy things, so this is the adaption via dynamic_field to prevent it from futzing
     if ( % this.no_purging != 1) {
      if ($sfile.openForWrite("./data/profile_finder.ccf")) {
       $profile_for_this_session = 1;
       $sfile.writeLine($profile_for_this_session);
       $sfile.close();
      }
      $sfile.close();
     }
     //edit 08-12-2013 this is only for profile name data that doesn't transfer due to legacy "done" button class BS. 
     if ( % this.no_purging == 1) {
      dynamic_name_slot.text = % read_profile_for_dynamic_slot;
      _dynamic_name_slot.text = % read_profile_for_dynamic_slot;
     }
     //end of clearing any bad legacy data

     //edit 02-03-2014 if never started, copy all initial data over to profile1 since it's the same
     if ($GAME_HAS_NEVER_BEEN_STARTED == 1) {
      dynamic_name_slot.font = "cambo";
      game_fail_text.setBlendAlpha(0);
      game_fail_number.setBlendAlpha(0);
      $sfile = new FileObject();
      if ($sfile.openForRead("./data/test1.ccf")) {
       prof_name_input_field1.text = % declare_profile;
       _prof_name_input_field1.text = % declare_profile;
       $sfile.close();
      }
     }

     hide_all_clear_profilers();
      dynamic_name_slot.text = % read_profile_for_dynamic_slot;
     _dynamic_name_slot.text = % read_profile_for_dynamic_slot;
     % this.setFrame("0");
     $screen_position_x = 0;
     $screen_position_y = 0;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     //edit 08-13-2013 IF is for legacy data in copy-paste last-minute to profile
     if ( % this.no_purging != 1) {
      $pre_done_button_toggle = 1;
     }

     //edit 02-28-2014 reversing decision to make start button into continue if another profile has been clicked, so it can properly reset
     if ($clicked_down_on_a_profile == 1 & $old_profile_state != $current_profile_slot.id_number) {
      $make_start_button_into_continue = 0;
      $allow_level_adjustment_due_to_switch_profile = 1;
      $old_profile_state = $current_profile_slot.id_number;
     }
     if ($clicked_down_on_a_profile != 1 & $old_profile_state == $current_profile_slot.id_number) {
     $clicked_down_on_a_profile = 0;
     $key_down_on_a_profile = 0;
     % capture_history_of_current_profile = $current_profile_slot.id_number; % old_current_profile = % capture_history_of_current_profile;
     $old_profile_state = % old_current_profile;
    }

    if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
     //edit 08-13-2013 IF is for legacy data in copy-paste last-minute BS to profile
     if ( % this.no_purging != 1) {
      $pre_done_button_toggle = 1;
     }
    }

   }
  }
  //exception for when map echo clips into profile menu
  pointer_world_map.setBlendAlpha(1);
  world_map_echo.setBlendAlpha(1);
 }
 //if there is text in the profile slot, when you mouse down on done button, count it as good and exit profile_downed toggle
 if ($check_profile_slot_text_length != 0) {
  $profile_downed = 0;
 }

 //if purging the same profile, now matter how you switch...
 % current_clear_profiler = "clear_profile" @ $temp_record_profile_slot_info.slot_num;

 if ( % this.from_prof_menu == 1 & $last_profile_played == $temp_record_profile_slot_info.slot_num & % current_clear_profiler.was_pressed == 1) {
  $game_profile_has_not_yet_changed = 0;
 }

 clear_profile1.was_pressed = 0;
 clear_profile2.was_pressed = 0;
 clear_profile3.was_pressed = 0;
 clear_profile4.was_pressed = 0;

 char1_thing_display.text = empty_char_space1.despawned;
 char2_thing_display.text = empty_char_space2.despawned;
 char3_thing_display.text = empty_char_space3.despawned;
 char4_thing_display.text = empty_char_space4.despawned;
}

//function for initial press play to continue button
function initialize_game_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame("1");
}

function initialize_game_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame("0");
}

function initialize_game_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame("2");
 }
}

function initialize_game_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $GAME_HAS_NEVER_BEEN_STARTED = 0;
  game_fail_text.setBlendAlpha(0);
  game_fail_number.setBlendAlpha(0);
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  }
  dynamic_name_slot.font = "cambo";
  prof_name_input_field1.font = "cambo";
  prof_name_input_field2.font = "cambo";
  prof_name_input_field3.font = "cambo";
  prof_name_input_field4.font = "cambo";
  vector_test_text.font = "cambo";
  vector_test_text2.font = "cambo";
  vector_test_text3.font = "cambo";
  bitmap_font_test.font = "cambo";
  storyboard_text.font = "cambo";
  appetizer1_amt_ingame.font = "cambo";
  appetizer2_amt_ingame.font = "cambo";
  profile_name_warning.font = "cambo";
  profile_name_warning2.font = "cambo";
  profile_name_warning.setBlendAlpha(0);
  profile_name_warning2.setBlendAlpha(0);

  /* THIS DOESNT REGISTER AS A REAL FONT THOUGH */
  tester_font_cacher.font = "txtNew1";
  /* -------- THIS WORKS, BUT IT NEEDS TO BE LOADED BEFORE CANVAS, IT SHOWED UP IN APPDATA AFTER WRITING THIS! -------- */
  ui_label_points_text.font = "cambo";
  ui_label_coins_text.font = "cambo";
  ui_label_level_text.font = "cambo";

  main_menu_bkgd.start_animations();
  mm_logo.schedule(1000, "delay_in", 0);
  mm_callie.schedule(1100, "delay_in", 0);
  mm_start_button.schedule(1200, "delay_in", 0);
  button_options.schedule(1300, "delay_in", 0);
  mm_exit_button.schedule(1350, "delay_in", 0);
  mm_profile_button.schedule(1375, "delay_in", 0);
  mm_music_starter.schedule(1750, "delay_in", 0);

  /* -------------- 	NEED TO COPY THESE NEW ATTRIBUTES OVER TO FIRST PREDONE BUTTON -------------------- */
  //08-05-2013 Ignite profiles via temp done button	
  $sfile = new FileObject();
  if ($sfile.openForRead("./data/profile_finder.ccf")) {
   $profile_for_this_session = $sfile.readLine();
   //edit 08-13-2013 specifically forgets which profile unless told here
   $current_profile_number = $profile_for_this_session;

  }
  if ($sfile.openForRead("./data/test1.ccf")) { % declare_profile = $sfile.readLine(); % check_string_length = strlen( % declare_profile);
   if ( % check_string_length != 0) {
    prof_name_input_field1.text = % declare_profile;
    _prof_name_input_field1.text = % declare_profile;
    prof_name_input_field1.exists = 1;
   }
   if ( % check_string_length == 0) {
    prof_name_input_field1.text = $new_profile_text;
    _prof_name_input_field1.text = $new_profile_text;
    prof_name_input_field1.exists = 0;
   }

   }
  if ($sfile.openForRead("./data/test2.ccf")) { % declare_profile = $sfile.readLine(); % check_string_length = strlen( % declare_profile);
   if ( % check_string_length != 0) {
    prof_name_input_field2.text = % declare_profile;
    prof_name_input_field2.exists = 1;
   }
   if ( % check_string_length == 0) {
    prof_name_input_field2.text = $new_profile_text;
    prof_name_input_field2.exists = 0;
   }

  }
  if ($sfile.openForRead("./data/test3.ccf")) { % declare_profile = $sfile.readLine(); % check_string_length = strlen( % declare_profile);
   if ( % check_string_length != 0) {
    prof_name_input_field3.text = % declare_profile;
    prof_name_input_field3.exists = 1;
   }
   if ( % check_string_length == 0) {
    prof_name_input_field3.text = $new_profile_text;
    prof_name_input_field3.exists = 0;
   }
  }
  if ($sfile.openForRead("./data/test4.ccf")) { % declare_profile = $sfile.readLine(); % check_string_length = strlen( % declare_profile);
   if ( % check_string_length != 0) {
    prof_name_input_field4.text = % declare_profile;
    prof_name_input_field4.exists = 1;
   }
   if ( % check_string_length == 0) {
    prof_name_input_field4.text = $new_profile_text;
    prof_name_input_field4.exists = 0;
   }
  }
  hide_all_clear_profilers(); % find_profile_for_dynamic_slot = "prof_name_input_field"
  @ $profile_for_this_session; % find_current_profile_image = "profile_text_slot"
  @ $profile_for_this_session; % read_profile_for_dynamic_slot = % find_profile_for_dynamic_slot.text;
  //set current profile slot image to hilighted
  % find_current_profile_image.setFrame(1);
  //identify this profile as current one for mouse interaction states
  % find_current_profile_image.is_current_profile = 1;
  //make the main menu current profile name this one at start
  dynamic_name_slot.text = % read_profile_for_dynamic_slot;
  _dynamic_name_slot.text = % read_profile_for_dynamic_slot;

  % this.setFrame("0");
  prestart_fader.alpha_up();
  //edit 03-01-2014 declaring current profile at start
  $current_profile_slot = % find_profile_for_dynamic_slot;
  $old_profile_state = $current_profile_slot.id_number;
  $current_profile_slot.exists = 1;
 }
}

function pre_done_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

 }
}