// ***************************************************************************************
// File Name:   startButton.cs
// Author:      Roger Campbell 
// Purpose:     Button that starts actual gameplay based off current profile data
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function startButton::onAdd( % this) {
 $storyboard_frame = 0;
 // enable mouse events for the mole so we can easily determine when it is clicked on
 % this.setUseMouseEvents(true);
 % this.timer1 += 1;
 $textobject1 = 2; 
 % timer_bit = 0;
}

function startButton::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_mm_buttons_off != 1) {
  % this.setFrame("1");
 }
 set_cursor_to_hili();
}

function startButton::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_mm_buttons_off != 1) {
  % this.setFrame("0");
 }
 set_cursor_to_default();
}

function tutbox::setSpeed( % this) { % this.speed = 200;
}

function startButton::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 02-10-2015 detect whether start button has ever been pressed for scenarios in which you just start the executable
  $startbutton_has_been_activated = 1;
  echo("startButton Mouse Down, $toggle_mm_buttons_off = " @ $toggle_mm_buttons_off);
  test_scheduler.outside_event();
 }
}



function test_scheduler::outside_event( % this) {
 //this actually calls the event too
 $test_the_scheduler = test_scheduler.schedule(5000, "test");
 echo(getEventTimeLeft($test_the_scheduler));
 if ($cancel_event_test_the_scheduler != 1) {
  cancel($test_the_scheduler);
 }
 echo(getEventTimeLeft($test_the_scheduler));
}

function test_scheduler::test( % this) {
 test_scheduler.setBlendAlpha(1);
}

function test_scheduler::onMouseUp( % this) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  echo(getEventTimeLeft($test_the_scheduler));
  $cancel_event_test_the_scheduler = 1;
  test_scheduler.outside_event();
 }
}

function startButton::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {

 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

  //edit 03-03-2015 options adjust
  $options_done_button_accessed = 0;
  //edit 03-01-2015 test of data non passing
  $has_left_the_game_version += 1;
  //edit 02-22-2015 fixes error but also kills all hearts
  $no_hearts_at_all = 0;
  //edit 02-11-2015 Need to reset storyboard frame upon start for best logic
  $storyboard_frame = 0;
  //edit 02-10-2015 detect whether start button has ever been pressed for scenarios in which you just start the executable
  if ($startbutton_has_been_activated == 1) {
   $startbutton_has_been_activated = 2;
  }
  echo("-----------GOING INTO THE GAME FROM MAIN MENU VIA START------------------------------------------------------------------------------------------");
  echo("START BUTTON: PART 1");
  //sched_cancel_cooks();
  //read_from_unique_save_file();
  //edit 06-30-2014 if first game ever for this slot confirmed, purge any remaining data
  //edit 09-29-2014 problem with "continue" stems from here, continue data gets erased
  if ($temp_record_profile_slot_info.has_ever_actually_been_played == 0 & $game_profile_has_not_yet_changed != 1) {
   echo("START BUTTON: PART 1b");
   purge_any_current_ingame_stuff();
  }
  if ($temp_record_profile_slot_info.track_purged == 1) {
   echo("START BUTTON: PART 1c");
  }

  if ($mm_start_completed == 1 & $game_profile_has_not_yet_changed == 1) {

   echo("START BUTTON: PART 2");
   echo("-------HARD UNPAUSE VIA #1-----------------------------------------------------------------------------------------------");
   hard_unpause();
   soft_unpause();

   $screen_position_x = 100;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   //edit 09-30-2014 adding music reset code here since the MM music will carry over if you dont
   alxStopAll();
   $default_audio = $world_audio;
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
    alxSetChannelVolume($GuiAudioType, $music_level);
   }
  }
  if ($mm_start_completed == 1 & $game_profile_has_not_yet_changed != 1) {
   echo("START BUTTON: PART 3");
   $disable_special_char = 0;
   //edit 12-20-2014 needed for identifying tutorial mode is active via here
   $game_text_block_identifier = 0;
   $storyboard_custom_intro_castle_switch = 0;
   //edit 06-29-2014 reactivate coin tip for char1 on
   green_light_chars();
   display_char_thingy.text = "-S-";
   display_char_thingy2.text = "xSx";
   empty_char_space1.hard_paused = 0;
   empty_char_space2.hard_paused = 0;
   empty_char_space3.hard_paused = 0;
   empty_char_space4.hard_paused = 0;
   //edit 06-12-2014 final removal functions
   sched_cancel_chars_and_waiters();
   clear_out_dirty_cups_for_good();
   sched_cancel_all();
   reset_trophy_iterators();
   hide_any_coin_flyers();
   //disable new tester text data
   spawn_time_checker.setBlendAlpha(0);
   schedule_checker.setBlendAlpha(0);
   schedule_checker2.setBlendAlpha(0);
   schedule_checker3.setBlendAlpha(0);
   //testing schedule canceling ability
   test_scheduler.outside_event();

   echo("#-------------------------- START BUTTON MOUSEUPED -------------------------------------------------------------------#");
   echo("AT THE SUPER START, $world_numeral = "
    @ $world_numeral);
   $THE_GAME_IS_PAUSED = 0;
   $start_button_was_pressed = 1;

   % this.setFrame("2");

   pre_calculate_round_max_times();
   //edit 01-18-2014 new function to monitor flying_coin position and change opacity depending
   flying_coin.schedule(200, "constantly_check_position", 0);

   echo("stats: $make_start_button_into_continue = " @ $make_start_button_into_continue);
   echo("stats: $world_numeral = " @ $world_numeral);
   echo("stats: $toggle_mm_buttons_off = " @ $toggle_mm_buttons_off);
   echo("$bob_test = " @ $bob_test);

   /* REDUNDANCY 03-25-2014 */
   /* STOP GAP MEASURE INCASE OF ANY CONCEIVABLE FAILURE, CLEAR EVERYTHING BEFORE STARTING, THEN RELOAD FROM MOST CURRENT SAVE FILE VIA PROFILE MENU */
   reset_all_worlds();
   reload_factory_settings_no_save();
   purge_any_current_ingame_stuff();
   read_from_save_file();
   find_all_entertainers_bought();
   set_entertainer_costs_at_start();

   if ($touchpad_activated == 1) {
    echo("START BUTTON: PART 4");
    $game_clock_limit = 50000;
    $game_clock_limit_01 = 50000;
    $game_clock_limit_02 = 48000;
    $game_clock_limit_03 = 46000;
    $game_clock_limit_04 = 44000;
    $game_clock_limit_05 = 43000;
    $game_clock_limit_06 = 42000;
    $game_clock_limit_07 = 41000;
    $game_clock_limit_08 = 40000;
    $game_clock_limit_09 = 38800;
    $game_clock_limit_10 = 37500;
   }

   echo("Incoming checks------------ : $appetizer1_amount1 = " @ $appetizer1_amount1);
   if ($world_numeral == 1 & $round_numeral == 1) {
    echo("START BUTTON: PART 5");
    $appetizer1_amount[$world_numeral] = 8;
    $appetizer2_amount[$world_numeral] = 8;
   } % check_if_appetizer1_saved_less_than_ten = $appetizer1_amount[$world_numeral]; % check_if_appetizer2_saved_less_than_ten = $appetizer2_amount[$world_numeral];

   equalize_appetizers();
   first_start_equalize_appetizers();

   appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
   appetizer2_amt_ingame.text = $appetizer2_amount[$world_numeral];


   echo("Incoming checks------------ : appetizer1_amt_ingame.text = " @ appetizer1_amt_ingame.text);
   echo("Cleared, then reloaded everything just incase via startButton");

   //fruit buttons 04-10-2014
   ui_button_triangle.trigger_up = 1;
   ui_button_triangle.setFrame(1);
   ui_button_triangle.setBlendAlpha(1);
   ui_button_square.trigger_up = 0;
   ui_button_square.setFrame(0);
   ui_button_square.setBlendAlpha(1);
   ui_button_circle.trigger_up = 0;
   ui_button_circle.setFrame(0);
   ui_button_circle.setBlendAlpha(1);

   if ($make_start_button_into_continue == 1) {
    echo("START BUTTON: PART 6");
    //edit 03-24-2014 rarely does this exception happen, but it should still have check-backs since outer code is correct while this can be incorrect
    reset_all_worlds();
    reload_factory_settings_no_save();
    purge_any_current_ingame_stuff();
    echo("______________________in start button, reading from save file part A at $current_profile_slot " @ $current_profile_slot);
    read_from_save_file();

    if ( % check_if_appetizer1_saved_less_than_ten < $appetizer_default_amount) {
     echo("START BUTTON: PART 6a");
     $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
    }
    if ( % check_if_appetizer2_saved_less_than_ten < $appetizer_default_amount) {
     echo("START BUTTON: PART 6b");
     $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
    }

    if ($world_numeral == 1 & $round_numeral == 1) {
     echo("START BUTTON: PART 6c");
     $appetizer1_amount[$world_numeral] = 8;
     $appetizer2_amount[$world_numeral] = 8;
    }
    comptroller.schedule(0, "unlock_all_previous_worlds_at_start", 0);
    //end edit 03-24-2014 check-backs

    //edit 12-31-2013 game finish-replay clauses
    if ($world_numeral != 11 & $world_numeral != 99) {
     echo("START BUTTON: PART 7");
     echo("STARTING FROM CONTINUE OF SAVED");
     $screen_position_x = 100;
     $screen_position_y = 0;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     button_options_ingame.setFrame(0);
     $THE_GAME_IS_PAUSED = 0;
     quickly_identify_world_audio();
     alxStopAll();
     if ($toggle_mute_music != 1) {
      echo("START BUTTON: PART 7a");
      alxPlay($default_audio);
      alxSetChannelVolume($GuiAudioType, $music_level);
      mute_game_music2.setPositionX(168.108);
      mute_game_music2.setPositionY(-31.931);
      mute_game_music.setPositionX(133.173);
      mute_game_music.setPositionY(-30.975);
     }
     if ($toggle_mute_music == 1) {
      echo("START BUTTON: PART 7b");
      mute_game_music.setPositionX(168.108);
      mute_game_music.setPositionY(-31.931);
      mute_game_music2.setPositionX(133.173);
      mute_game_music2.setPositionY(-30.975);
     }
     if ($mute_soundfx != 1) {
      echo("START BUTTON: PART 7c");
      mute_game_soundfx2.setPositionX(165.356);
      mute_game_soundfx2.setPositionY(-32.006);
      mute_game_soundfx.setPositionX(130.421);
      mute_game_soundfx.setPositionY(-31.050);
     }
     if ($mute_soundfx == 1) {
      echo("START BUTTON: PART 7d");
      mute_game_soundfx.setPositionX(165.356);
      mute_game_soundfx.setPositionY(-32.006);
      mute_game_soundfx2.setPositionX(130.421);
      mute_game_soundfx2.setPositionY(-31.050);
     }
     $pooooo = monster_shake.getSceneTime();
     monster_shake.setScenePause(false);
     $timescale = 1;
     soft_unpause();
     if ($game_is_hard_paused == 1) {
      echo("START BUTTON: PART 7e");
      echo("-------HARD UNPAUSE VIA #2-----------------------------------------------------------------------------------------------");
      hard_unpause();

     }
    }

    echo("AT THE VERY VERY START, $world_numeral = "
     @ $world_numeral);
    if ($world_numeral == 11) {
     echo("START BUTTON: PART 8");
     $world_numeral = 99;
     $toggle_off_transitioning_screens = 1;
     $screen_position_x = 0;
     $screen_position_y = 150;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     $toggle_from_map_button = 1;
    }

    if ($world_numeral == 99) {
     echo("START BUTTON: PART 9");
     $toggle_off_transitioning_screens = 1;
     $screen_position_x = 0;
     $screen_position_y = 150;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     $toggle_from_map_button = 1;
    }
    $iterate_through_world_icons = $maximum_world_player_got_to;
   }

   //edit 02-10-2015 if when starting, you switch between a profile with world1-level1, then to another profile with world> - level1, then back to original profile 
   //and hit done, start- First play profile (world1, level1) will absorb the $make_start_button_into_continue from other profile and kill the game, making it show
   //what is in editor mode
   //this would potentially fix it
   //NEED FOR EVERY LEVEL, NOT JUST WORLD 1 LEVEL 1

   if ($make_start_button_into_continue != 1) {
    echo("START BUTTON: PART 10");
    bonus_portal1.setAnimation(empty_char_spaceAnimation);
    bonus_portal2.setAnimation(empty_char_spaceAnimation);
    bonus_portal3.setAnimation(empty_char_spaceAnimation);
    bonus_portal4.setAnimation(empty_char_spaceAnimation);

    if ($toggle_mm_buttons_off != 1) {
     echo("START BUTTON: PART 11");
     levsel_day_text.font = "cambo";
     levsel_world_text.font = "cambo";
     levsel_map_text.font = "cambo";
     levsel_menu_text.font = "cambo";


     game_pause_text.setBlendAlpha(0);
     combo_alert.setAnimation(empty_char_spaceAnimation);
     //edit 08-15-2013 Plugging in viewing of data from save file
     reset_all_worlds();
     reload_factory_settings_no_save();
     purge_any_current_ingame_stuff();
     echo("______________________in start button, reading from save file part A at $current_profile_slot "
      @ $current_profile_slot);
     read_from_save_file();
     if ( % check_if_appetizer1_saved_less_than_ten < $appetizer_default_amount) {
      echo("START BUTTON: PART 11b");
      $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
     }
     if ( % check_if_appetizer2_saved_less_than_ten < $appetizer_default_amount) {
      echo("START BUTTON: PART 11c");
      $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
     }
     if ($world_numeral == 1 & $round_numeral == 1) {
      echo("START BUTTON: PART 11d");
      $appetizer1_amount[$world_numeral] = 8;
      $appetizer2_amount[$world_numeral] = 8;
     }
     comptroller.schedule(0, "unlock_all_previous_worlds_at_start", 0);
     echo("stats (pre): $world_numeral = " @ $world_numeral);

     //edit 12-31-2013 level 11 (eg beat the game) conditions, make it not repeat credits or go to level 1
     if ($world_numeral == 11) {
      echo("START BUTTON: PART 11e");
      $world_numeral = 99;
      $toggle_off_transitioning_screens = 1;
      $screen_position_x = 0;
      $screen_position_y = 150;
      activate_side_borders();
      sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
      $toggle_from_map_button = 1;
      echo("at start button, choice was numeral 11 part one");

     }

     if ($world_numeral == 99) {
      echo("START BUTTON: PART 12");
      $toggle_off_transitioning_screens = 1;
      $screen_position_x = 0;
      $screen_position_y = 150;
      activate_side_borders();
      sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
      $toggle_from_map_button = 1;
     }

     /* LEVEL SELECTION LOAD UP DATA */
     $world_numeral = $maximum_world_player_got_to;
     $round_numeral = $maximum_level_player_got_to;
     $current_level = $maximum_level_player_got_to;
     $the_current_world = $maximum_world_player_got_to;
     //edit 02-17-2014 editing level locking because of out-of-order saves
     if ($current_level < 10) {
      echo("START BUTTON: PART 12b");
      $relocking_start_number = $current_level + 1;
      comptroller.relock_levels_that_were_falsely_unlocked();
     }
     echo("stats (cont): $world_numeral = "
      @ $world_numeral);

     check_if_need_to_hide_appetizers();
     //edit 02-11-2014 New round digit identifying and animating system
     if ($round_numeral < 10) {
      echo("START BUTTON: PART 13");
      $find_first_digit_of_round_display = 0;
      $find_second_digit_of_round_display = $round_numeral;
      round_digit1.setFrame($find_first_digit_of_round_display);
      round_digit2.setFrame($find_second_digit_of_round_display);
     }
     if ($round_numeral == 10) {
      echo("START BUTTON: PART 14");
      $find_first_digit_of_round_display = 1;
      $find_second_digit_of_round_display = 0;
      round_digit1.setFrame($find_first_digit_of_round_display);
      round_digit2.setFrame($find_second_digit_of_round_display);
     }
     //edit 02-11-2014 adding continued round number animaion via startButton
     path_round_num.setSpeed(round_num, 30);


     //edit 01-26-2014 Set waiter node position based on world
     set_waiter_node_position();

     //special characters activator just incase you use startButton as continue
     $toggle_off_special_char_for_round = 0;
     release_all_special_char_toggles();


     % level_button_bitmap = "levsel_world" @ $world_numeral @ "_buttonImageMap";
	 % level_bkgd_bitmap = "levsel_bkgd_" @ $world_numeral @ "ImageMap";
     levsel_day_text.text = "-";

     % levsel_root_text = "level_world_text" @ $world_numeral;
     $find_levsel_text = $_[ % levsel_root_text];
     levsel_world_text.text = $find_levsel_text;
     _levsel_world_text.text = $find_levsel_text;

     levsel_1.setImageMap( % level_button_bitmap);
     levsel_2.setImageMap( % level_button_bitmap);
     levsel_3.setImageMap( % level_button_bitmap);
     levsel_4.setImageMap( % level_button_bitmap);
     levsel_5.setImageMap( % level_button_bitmap);
     levsel_6.setImageMap( % level_button_bitmap);
     levsel_7.setImageMap( % level_button_bitmap);
     levsel_8.setImageMap( % level_button_bitmap);
     levsel_9.setImageMap( % level_button_bitmap);
     levsel_10.setImageMap( % level_button_bitmap);

     /* if unlocked set frame 0 */
     echo("START BUTTON: PART 15");
     if (levsel_1.unlocked == 1) {
      echo("START BUTTON: PART 15b");
      levsel_1.setFrame(0);
     }
     if (levsel_2.unlocked == 1) {
      echo("START BUTTON: PART 15c");
      levsel_2.setFrame(0);
     }
     if (levsel_3.unlocked == 1) {
      echo("START BUTTON: PART 15d");
      levsel_3.setFrame(0);
     }
     if (levsel_4.unlocked == 1) {
      echo("START BUTTON: PART 15e");
      levsel_4.setFrame(0);
     }
     if (levsel_5.unlocked == 1) {
      echo("START BUTTON: PART 15f");
      levsel_5.setFrame(0);
     }
     if (levsel_6.unlocked == 1) {
      echo("START BUTTON: PART 15g");
      levsel_6.setFrame(0);
     }
     if (levsel_7.unlocked == 1) {
      echo("START BUTTON: PART 15h");
      levsel_7.setFrame(0);
     }
     if (levsel_8.unlocked == 1) {
      echo("START BUTTON: PART 15i");
      levsel_8.setFrame(0);
     }
     if (levsel_9.unlocked == 1) {
      echo("START BUTTON: PART 15j");
      levsel_9.setFrame(0);
     }
     if (levsel_10.unlocked == 1) {
      echo("START BUTTON: PART 15k");
      levsel_10.setFrame(0);
     }

     /* if locked set frame 3 */

     if (levsel_1.unlocked == 0) {
      echo("START BUTTON: PART 15l");
      levsel_1.setFrame(3);
     }
     if (levsel_2.unlocked == 0) {
      echo("START BUTTON: PART 15m");
      levsel_2.setFrame(3);
     }
     if (levsel_3.unlocked == 0) {
      echo("START BUTTON: PART 15n");
      levsel_3.setFrame(3);
     }
     if (levsel_4.unlocked == 0) {
      echo("START BUTTON: PART 15o");
      levsel_4.setFrame(3);
     }
     if (levsel_5.unlocked == 0) {
      echo("START BUTTON: PART 15p");
      levsel_5.setFrame(3);
     }
     if (levsel_6.unlocked == 0) {
      echo("START BUTTON: PART 15q");
      levsel_6.setFrame(3);
     }
     if (levsel_7.unlocked == 0) {
      echo("START BUTTON: PART 15r");
      levsel_7.setFrame(3);
     }
     if (levsel_8.unlocked == 0) {
      echo("START BUTTON: PART 15s");
      levsel_8.setFrame(3);
     }
     if (levsel_9.unlocked == 0) {
      echo("START BUTTON: PART 15t");
      levsel_9.setFrame(3);
     }
     if (levsel_10.unlocked == 0) {
      echo("START BUTTON: PART 15u");
      levsel_10.setFrame(3);
     }

     //echo animation and pointer for WORLD MAP selection
     if ($world_numeral <= 10) {
      echo("START BUTTON: PART 16"); % find_current_world_locale = "mapsel_" @ $world_numeral; 
	  % world_locale_x = % find_current_world_locale.getPositionX(); 
	  % world_locale_y = % find_current_world_locale.getPositionY();
      world_map_echo.setPositionX( % world_locale_x);
      world_map_echo.setPositionY( % world_locale_y);
      pointer_world_map.setPositionX( % world_locale_x); 
	  % upper_world_locale_y = % world_locale_y - 10;
      pointer_world_map.setPositionY( % upper_world_locale_y);

      if ($world_numeral == $maximum_world_player_got_to) {
       echo("START BUTTON: PART 16b"); % find_current_world_locale.unlocked = 1; % find_current_world_locale.setFrame(0);
      }
     }
     //if you beat the game, declare the echo selector and pointer to be world 10
     if ($world_numeral >= 11) {
      echo("START BUTTON: PART 17"); % find_current_world_locale = "mapsel_10"; % world_locale_x = % find_current_world_locale.getPositionX(); % world_locale_y = % find_current_world_locale.getPositionY();
      world_map_echo.setPositionX( % world_locale_x);
      world_map_echo.setPositionY( % world_locale_y);
      pointer_world_map.setPositionX( % world_locale_x); % upper_world_locale_y = % world_locale_y - 10;
      pointer_world_map.setPositionY( % upper_world_locale_y); % find_current_world_locale.unlocked = 1; % find_current_world_locale.setFrame(0);
     }

     bkgd_levsel_main.setImageMap( % level_bkgd_bitmap);

     $iterate_through_world_icons = $maximum_world_player_got_to;
     /* END LEVEL SELECT DATA */

     level_number.text = $round_numeral;
     if ($current_level > 10) {
      echo("START BUTTON: PART 18");
      level_number.text = 10;
     }
     score_number.text = $coinage;
     points_number.text = $points_amount;

     //01-04-2014 special character circumstances
     $special_record_points_at_round_start = $points_amount;
     $special_record_coins_at_round_start = $coinage;

     clear_options_menu();
     //play blip
     if ($mute_soundfx != 1) {
      echo("START BUTTON: PART 19");
      alxPlay(blipAudio);
     }
     //reset achievements unlocked
     $au_box_alpha_level = 0;
     achievement_unlocked_text.text = "";
     au_box.setBlendAlpha($au_box_alpha_level);
     trophy_gold_bar.setBlendAlpha($au_box_alpha_level);
     //click animation
     click_sonar.BlendColor = "1 1 1 0.4";
     click_sonar.setPositionX( % char_x);
     click_sonar.setPositionY( % char_y);
     click_sonar.setAnimation(click_faderAnimation);
     mount_point1.setImageMap(empty_char_spaceImageMap);
     mount_point2.setImageMap(empty_char_spaceImageMap);
     mount_point3.setImageMap(empty_char_spaceImageMap);
     mount_point4.setImageMap(empty_char_spaceImageMap);
     way_point1.setImageMap(empty_char_spaceImageMap);
     way_point2.setImageMap(empty_char_spaceImageMap);
     way_point3.setImageMap(empty_char_spaceImageMap);
     way_point4.setImageMap(empty_char_spaceImageMap);
     cue_tab1.setAnimation(cue_tab_downAnimation);
     cue_tab2.setAnimation(cue_tab_downAnimation);

     menu_text_bites.text = $menu_bites;
     shadow_text_bites.text = $menu_bites;
     menu_text_beverages.text = $menu_beverages;
     menu_text_baristas.text = $menu_baristas;
     menu_text_awards.text = $menu_awards;
     menu_text_map.text = $menu_map;
     menu_text_options.text = $menu_options;
     menu_text_done.text = $menu_done;

     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     $temp_trophy_opacity = $_trophy_plaque1_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque1.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque2_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque2.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque3_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque3.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque4_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque4.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque5_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque5.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque6_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque6.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque7_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque7.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque8_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque8.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque9_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque9.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_plaque10_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque10.BlendColor = $trophy_opacity;

     $temp_trophy_opacity = $_trophy_trophy1_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy1.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy2_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy2.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy3_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy3.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy4_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy4.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy5_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy5.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy6_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy6.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy7_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy7.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy8_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy8.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy9_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_trophy9.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_trophy10_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_plaque10.BlendColor = $trophy_opacity;


     $temp_trophy_opacity = $_trophy_button1_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button1.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_button2_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button2.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_button3_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button3.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_button4_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button4.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_button5_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button5.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_button6_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_button6.BlendColor = $trophy_opacity;

     $temp_trophy_opacity = $_trophy_ribbon1_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon1.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_ribbon2_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon2.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_ribbon3_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon3.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_ribbon4_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon4.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_ribbon5_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon5.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_ribbon6_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_ribbon6.BlendColor = $trophy_opacity;

     $temp_trophy_opacity = $_trophy_mount1_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_mount1.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_mount2_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_mount2.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_mount3_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_mount3.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_mount4_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_mount4.BlendColor = $trophy_opacity;
     $temp_trophy_opacity = $_trophy_dollar_activated;
     $trophy_opacity = ""
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ " "
     @ $temp_trophy_opacity @ ".5";
     trophy_dollar.BlendColor = $trophy_opacity;

     tutorial_text_block.setPositionX(9999);
     tutorial_text_block.setPositionY(9999);

     //drink_out mana_glow fx
     mana_glow1.setAnimation(empty_char_spaceAnimation);
     mana_glow2.setAnimation(empty_char_spaceAnimation);
     mana_glow3.setAnimation(empty_char_spaceAnimation);
     mana_glow4.setAnimation(empty_char_spaceAnimation);

     //drink_out mana_glow fx
     dirty_glow1.setAnimation(empty_char_spaceAnimation);
     dirty_glow2.setAnimation(empty_char_spaceAnimation);
     dirty_glow3.setAnimation(empty_char_spaceAnimation);
     dirty_glow4.setAnimation(empty_char_spaceAnimation);

     $appetizer2_purchased1 = 1;

     char_time_checker1.text = "";
     char_time_checkerb1.text = "";
     char_time_checker2.text = "";
     char_time_checkerb2.text = "";
     char_time_checker3.text = "";
     char_time_checkerb3.text = "";
     char_time_checker4.text = "";
     char_time_checkerb4.text = "";

     levsel_stars1.setBlendAlpha(0);
     levsel_stars2.setBlendAlpha(0);
     levsel_stars3.setBlendAlpha(0);
     levsel_stars4.setBlendAlpha(0);
     levsel_stars5.setBlendAlpha(0);
     levsel_stars6.setBlendAlpha(0);
     levsel_stars7.setBlendAlpha(0);
     levsel_stars8.setBlendAlpha(0);
     levsel_stars9.setBlendAlpha(0);
     levsel_stars10.setBlendAlpha(0);

     //if we are starting from a save file and the level is beyond World 1, Level 1, it's skipping tutorial so start clock from here	
     if ($world_numeral >= 1 & $current_level != 1) {
      echo("START BUTTON: PART 20");
      $toggle_initial_spawner_via_clock = 0;
      $game_has_started_for_clock = 1;
      $transitioning_from_skip_button = 1;
      soft_unpause();
      if ($game_is_hard_paused == 1) {
       echo("START BUTTON: PART 20a");
       erase_usage_of_cooks();
       echo("-------HARD UNPAUSE VIA #3-----------------------------------------------------------------------------------------------");
       hard_unpause();
      }
      $tutorial_popup_officially_ended_via_yes_or_no = 1;
     }

     //edit 12-31-2013 Need extra clause for if world > 1 but level does = 1, or else if you save upon quitting out of level 1 of another world, tutorial will pop down
     if ($world_numeral > 1 & $current_level == 1) {
      echo("START BUTTON: PART 21");
      path_tut.setSpeed(tutorial_box1, -60);
      $tutorial_options_finished = 1;
      score_number.text = $coinage;
      //level_number.text = $current_level;
      level_number.text = $round_numeral;
      if ($current_level > 10) {
       echo("START BUTTON: PART 21a");
       level_number.text = 10;
      }
      /* 07-15-2013 Adding further adjustments due to bugs */
      $p1_present = 0;
      $tutorial_popup_officially_ended_via_yes_or_no = 1;
     }
     //edit 06-28-2014 for extremely special circumstances of play profile1 through end of tutorial, quit, come back, switch profile to 2, play, and need hearts for char1 to schedule
     if ($world_numeral >= 1 & $current_level == 1) {
      echo("START BUTTON: PART 22");
      //if this is disabled ingame first char1 will spawn without hearts 
      //if this is enabled, char1 will spawn in during tutorial ands start counting down hearts. boo
      $tutorial_popup_officially_ended_via_yes_or_no = 1;
     }

    }


    echo("startButton Mouse Up, $toggle_mm_buttons_off = " @ $toggle_mm_buttons_off);
    if ($toggle_mm_buttons_off != 1) {
     echo("START BUTTON: PART 23");
     //edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
     erase_usage_of_cooks(); % this.setFrame("1"); % this.setFrame("0");
     $screen_position_x = -100;
     $screen_position_y = 150;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     storyboard.setImageMap(storyboard_castle_finalImageMap);
     print_game_text();
     reset_all_worlds();
     reload_factory_settings_no_save();
     purge_any_current_ingame_stuff();
     echo("______________________in start button, reading from save file part B at $current_profile_slot " @ $current_profile_slot);
     read_from_save_file();
     if ( % check_if_appetizer1_saved_less_than_ten < $appetizer_default_amount) {
      echo("START BUTTON: PART 23b");
      $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
     }
     if ( % check_if_appetizer2_saved_less_than_ten < $appetizer_default_amount) {
      echo("START BUTTON: PART 23c");
      $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
     }
     if ($world_numeral == 1 & $round_numeral == 1) {
      echo("START BUTTON: PART 23d");
      $appetizer1_amount[$world_numeral] = 8;
      $appetizer2_amount[$world_numeral] = 8;
     }
     comptroller.schedule(0, "unlock_all_previous_worlds_at_start", 0);
     echo("stats (cont2): $world_numeral = " @ $world_numeral);
     //edit 02-17-2014 for some reason I have a second read file? So this resets starting bits to proper world if out-of-order
     $world_numeral = $maximum_world_player_got_to;
     $round_numeral = $maximum_level_player_got_to;
     $current_level = $maximum_level_player_got_to;
     //redundant appetizer data because it occasionally screws up

     $the_current_world = $maximum_world_player_got_to;
     //edit 02-17-2014 editing level locking because of out-of-order saves
     if ($current_level < 10) {
      echo("START BUTTON: PART 23e");
      $relocking_start_number = $current_level + 1;
      comptroller.relock_levels_that_were_falsely_unlocked();
     }

     //edit 12-31-2013 level 11 (eg beat the game) conditions, make it not repeat credits or go to level 1
     if ($world_numeral == 11) {
      echo("START BUTTON: PART 23f");
      $world_numeral = 99;
      $toggle_off_transitioning_screens = 1;
      $screen_position_x = 0;
      $screen_position_y = 150;
      activate_side_borders();
      sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
      $toggle_from_map_button = 1;
      echo("at start button, choice was numeral 11 part two");
     }
     if ($world_numeral == 99) {
      echo("START BUTTON: PART 23g");
      $toggle_off_transitioning_screens = 1;
      $screen_position_x = 0;
      $screen_position_y = 150;
      activate_side_borders();
      sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
      $toggle_from_map_button = 1;
     }
     echo("At start reading at $world_numeral = "
      @ $world_numeral @ " and $current_level = "
      @ $current_level);

     if ($world_numeral == 1 & $current_level == 1) {
      echo("START BUTTON: PART 23h");
      path_tut.setSpeed(tutorial_box1, 60);
      isolater_mask.turn_off_fruit_dial();
      $temporarily_disable_ingame_options_before_tutorial = 1;
      button_options_ingame.BlendColor = "0.5 0.5 0.5 1";
      //edit 09-18-2014 If you start out for the first time, employees should never be there.
      clear_employee_alphas();

     }

     if ($world_numeral >= 1 & $current_level != 1) {
      echo("START BUTTON: PART 23i");
      path_tut.setSpeed(tutorial_box1, -60);
      $tutorial_options_finished = 1;
      score_number.text = $coinage;
      level_number.text = $round_numeral;
      if ($current_level > 10) {
       echo("START BUTTON: PART 23i2");
       level_number.text = 10;
      }
      /* 07-15-2013 Adding further adjustments due to bugs */
      $p1_present = 0;
     }
     //edit 12-31-2013 Need extra clause for if world > 1 but level does = 1, or else if you save upon quitting out of level 1 of another world, tutorial will pop down
     if ($world_numeral > 1 & $current_level == 1) {
      echo("START BUTTON: PART 23j");
      path_tut.setSpeed(tutorial_box1, -60);
      $tutorial_options_finished = 1;
      score_number.text = $coinage;
      level_number.text = $round_numeral;
      if ($current_level > 10) {
       echo("START BUTTON: PART 23j2");
       level_number.text = 10;
      }
      /* 07-15-2013 Adding further adjustments due to bugs */
      $p1_present = 0;

     }

     $toggle_custom_char1_spawn = 1;
     //edit 02-17-2015 this seems to only be necessary inter-game and not when starting new games, otherwise it causes progblock, so adding this statement before
     //writing world data that includes clean-up commands via go_to_next_world in inventory
     $clean_up_in_progress_so_skip_the_map = 0;
     //SPAWN ALL THE ART AND DATA FOR THIS WORLD
     go_to_next_world();
     if ($start_game_time_only_once != 1) {
      echo("START BUTTON: PART 23k");
      empty_char_space1.start_game_clock();
      $start_game_time_only_once = 1;
     }
     confetti_storm.stopEffect();
     $options_location = 0;

     //if first level of world upon start, play generic storyboard music
     if ($round_numeral == 1) {
      echo("START BUTTON: PART 24");
      $default_audio = "map_theme";
      alxStopAll();
      if ($toggle_mute_music != 1) {
       echo("START BUTTON: PART 24b");
       alxPlay($default_audio);
       alxSetChannelVolume($GuiAudioType, $music_level);
       mute_game_music2.setPositionX(168.108);
       mute_game_music2.setPositionY(-31.931);
       mute_game_music.setPositionX(133.173);
       mute_game_music.setPositionY(-30.975);
      }
      if ($toggle_mute_music == 1) {
       echo("START BUTTON: PART 24c");
       mute_game_music.setPositionX(168.108);
       mute_game_music.setPositionY(-31.931);
       mute_game_music2.setPositionX(133.173);
       mute_game_music2.setPositionY(-30.975);
      }
      if ($mute_soundfx != 1) {
       echo("START BUTTON: PART 24d");
       mute_game_soundfx2.setPositionX(165.356);
       mute_game_soundfx2.setPositionY(-32.006);
       mute_game_soundfx.setPositionX(130.421);
       mute_game_soundfx.setPositionY(-31.050);
      }
      if ($mute_soundfx == 1) {
       echo("START BUTTON: PART 24e");
       mute_game_soundfx.setPositionX(165.356);
       mute_game_soundfx.setPositionY(-32.006);
       mute_game_soundfx2.setPositionX(130.421);
       mute_game_soundfx2.setPositionY(-31.050);
      }
     }
     //if not first level of world upon start, play world music
     if ($round_numeral != 1) {
      echo("START BUTTON: PART 25");
      quickly_identify_world_audio();
      alxStopAll();
      if ($toggle_mute_music != 1) {
       echo("START BUTTON: PART 25b");
       alxPlay($default_audio);
       alxSetChannelVolume($GuiAudioType, $music_level);
       mute_game_music2.setPositionX(168.108);
       mute_game_music2.setPositionY(-31.931);
       mute_game_music.setPositionX(133.173);
       mute_game_music.setPositionY(-30.975);
      }
      if ($toggle_mute_music == 1) {
       echo("START BUTTON: PART 25c");
       mute_game_music.setPositionX(168.108);
       mute_game_music.setPositionY(-31.931);
       mute_game_music2.setPositionX(133.173);
       mute_game_music2.setPositionY(-30.975);
      }
      if ($mute_soundfx != 1) {
       echo("START BUTTON: PART 25d");
       mute_game_soundfx2.setPositionX(165.356);
       mute_game_soundfx2.setPositionY(-32.006);
       mute_game_soundfx.setPositionX(130.421);
       mute_game_soundfx.setPositionY(-31.050);
      }
      if ($mute_soundfx == 1) {
       echo("START BUTTON: PART 25e");
       mute_game_soundfx.setPositionX(165.356);
       mute_game_soundfx.setPositionY(-32.006);
       mute_game_soundfx2.setPositionX(130.421);
       mute_game_soundfx2.setPositionY(-31.050);
      }
     }

     if ($world_numeral == 1 & $current_level == 1) {
      echo("START BUTTON: PART 25f");
      $end_the_clock = 1;
     }
    }

    $make_start_button_into_continue = 1;

   }

   $test_amount_of_played = profile_text_slot1.has_ever_actually_been_played + profile_text_slot2.has_ever_actually_been_played + profile_text_slot3.has_ever_actually_been_played + profile_text_slot4.has_ever_actually_been_played;
   //edit 06-25-2014 source of a lot of problems
   //special case of first time ever, switch profile, switch profile play forth, switch profile, switch profile
   if ($test_amount_of_played >= 1) {
    echo("START BUTTON: PART 26");
    $first_game_ever_ever = 0;

   }

   if ($first_game_ever_ever == 1) {
    echo("START BUTTON: PART 27");
    //edit 12-28-2014 first play ever does not detect tutorial status events, this fixes it
    $tut_yes_is_active = 1;
   }

   //If you got through for the first time ever, you never click profile slot, and so if profile1 by default, you have already played this	
   if ($current_profile_number == 0) {
    echo("START BUTTON: PART 28");
    profile_text_slot1.has_ever_actually_been_played = 1;
   }
   if ($current_profile_number == 1) {
    echo("START BUTTON: PART 29");
    profile_text_slot1.has_ever_actually_been_played = 1;
   }
   //if you skip any profile input because its your first time, or if this and you go to profile, go to profile 1, then make profile 1 used
   if ($this_is_the_first_time_ever_played == 1) {
    echo("START BUTTON: PART 30");
    profile_text_slot1.has_ever_actually_been_played = 1;
   }
   //If profile has already been played, undetect it as first game ever for that profile
   if ($temp_record_profile_slot_info.has_ever_actually_been_played == 1 & $first_game_ever_ever != 0) {
    echo("START BUTTON: PART 31");
    $first_game_ever_ever = 0;
   }

   //this profile slot is now recorded as initially played via end of start button
   $temp_record_profile_slot_info.has_ever_actually_been_played = 1;
   //If you switch profiles and then leave before starting, then come back, $temp_record_profile_slot_info wont register so use %double_check_profile instead
   % double_check_profile = "profile_text_slot" @ $current_profile_number; % double_check_profile.has_ever_actually_been_played = 1;
   //write to a unique profile that doesnt have to save at end of level, but rather at start of any game
   write_to_unique_save_file();
   //if this game has been played before, in most circumstances, use a 'continue' image for startButton instead of start
   mm_start_button.setImageMap(mm_continue_buttonImageMap);
   echo("#-------------------------- START BUTTON END -------------------------------------------------------------------#");
  }
 }

 //edit 10-01-2014 added fix for playing tut, going to level 2, switching to new profile, playing and ordering drinks and no drinks come out
 $world_ended = 0;
 echo("$world_numeral = " @ $world_numeral @ "$round_numeral = " @ $round_numeral @ "$current_level = " @ $current_level);
 if ($world_numeral == 1 & $current_level == 1) {
  $end_the_clock = 1;
 }
 echo("$end_the_clock = "  @ $end_the_clock);
 echo("----------------FINALLY ENDING ALL FOR STARTBUTTON-----------------------------------------------------------------------------------------------------");
 echo("$via_ingame = " @ $via_ingame);
 echo("$via_main_menu = " @ $via_main_menu);
 echo("$changed_mouse_or_touchpad = " @ $changed_mouse_or_touchpad);
 //edit 03-09-2015 last of flush fixes
 if ($via_ingame == 1 & $changed_mouse_or_touchpad == 1) {
  flush_level_entirely();
  $changed_mouse_or_touchpad = 0;
 }
 //edit 03-09-2015 make it go back to normal
 $allow_options_first_restart_bs = 0;
 //edit 03-09-2015 detect constant mouseup
 $startButton_has_been_mousedup_at_least_once = 1;
 $any_profile_slot_has_been_clicked = 0;
 $mm_profile_button_has_been_clicked = 0;
 $disable_the_last_game_profile_error = 0;

}