// ***************************************************************************************
// File Name:   ui_generic_buttons.cs
// Author:      Roger Campbell 
// Purpose:     All generic buttons and their functions 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************


function soft_pause() {
 unpause_display.text = "soft_pause";
 unpause_display2.text = "soft_pause";
 $end_the_clock = 1;
 $game_has_started_for_clock = 0;
 // check to see if the event is pending
 if (isEventPending($waiter_spawn_event)) {
  // delete the event
  cancel($waiter_spawn_event);
 }
}

function soft_unpause() {
 unpause_display.text = "soft_unpause";
 unpause_display2.text = "soft_unpause";
 monster_shake.setScenePause(false);
 echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ A");
 $end_the_clock = 0;
 $game_has_started_for_clock = 1;
}

function ui_generic_buttons::onAdd( % this) { % this.setUseMouseEvents(true);
 }
 //UI temp spot/////////////////////////////////////////////////////////////////////
 //////////////////////////////////////////////////////////////////////////////////
function cheater_world::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  alxStop(castle_theme);
  $world_numeral = $cheat_to_world;
  go_to_next_world();
 }
}

function button_pause::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  } % this.setFrame(2);
 }
}

function button_pause::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
}

function button_pause::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 //if($MASTER_ALL_BUTTONS_DISABLED != 1 & $disable_pause_for_black_out != 1)
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $THE_GAME_IS_PAUSED = 1;
  alxStopAll();
  $pooooo = monster_shake.getSceneTime();
  monster_shake.setScenePause(true);
  $timescale = 0;
  button_pause2.setPositionX(139.603);
  button_pause2.setPositionY(-35.730);
  button_pause.setPositionX(999);
  button_pause.setPositionY(999); % this.setFrame(0);

  black_stretch2.setPositionX(100);
  black_stretch2.setPositionY(0);
  black_stretch2.setSize(100, 100);
  black_stretch2.setBlendAlpha(0.75);
  game_pause_text.setBlendAlpha(1);
 }
}

function button_pause::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}


function button_pause2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function button_pause2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
}

function button_pause2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $THE_GAME_IS_PAUSED = 0;
  alxStopAll();
  if ($toggle_mute_music != 1) {
   alxPlay($default_audio);
  }
  $pooooo = monster_shake.getSceneTime();
  monster_shake.setScenePause(false);
  $timescale = 1;
  button_pause.setPositionX(139.603);
  button_pause.setPositionY(-35.730);
  button_pause2.setPositionX(999);
  button_pause2.setPositionY(999); % this.setFrame(0);

  black_stretch2.setPositionX(100);
  black_stretch2.setPositionY(0);
  black_stretch2.setSize(100, 100);
  black_stretch2.setBlendAlpha(0);
  game_pause_text.setBlendAlpha(0);
 }
}

function button_pause2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}


function button_options_ingame::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 echo("button_options_ingame moused up ------------- :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :)");
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1 & $tut_yes_is_active != 1 & $temporarily_disable_ingame_options_before_tutorial != 1) { 
  % this.setFrame(2);
  }
 }
}

function button_options_ingame::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1 & $tut_yes_is_active != 1 & $temporarily_disable_ingame_options_before_tutorial != 1) { 
 % this.setFrame(1);
 }
}

function button_options_ingame::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1 & $tut_yes_is_active != 1 & $temporarily_disable_ingame_options_before_tutorial != 1) { 
 % this.setFrame(0);
 }
}


function box_points::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(1);
 }
}

function box_points::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(0);
 }
}

function box_score::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(1);
 }
}

function box_score::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(0);
 }
}

function box_level::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(1);
 }
}

function box_level::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.setFrame(0);
 }
}

/* function broc2::onMouseDown(%this, %modifier, %worldPosition, %mouseClicks) */
function go_to_specific_level( % this) {

 if ($toggle_off_go_to_specific_level != 1) {
  $disable_special_char = 0;
  $star_sys_medal_won = 3;
  gold_clock_limit_says.text = "1_gotospeclevl";
  silver_clock_limit_says.text = 0;
  bronze_clock_limit_says.text = 0;
  //01-04-2014 special character circumstances
  $special_record_points_at_round_start = $points_amount;
  $special_record_coins_at_round_start = $coinage;
  special_character_hili.setPositionX(9999);
  special_character_hili.setPositionY(9999);
  release_all_special_char_toggles();

  $game_clock_number = 0;
  $toggle_initial_spawner_via_clock = 0;
  write_to_save_file();

  //For sodajerks and others to stop schedules
  $world_ended = 1;

  go_to_next_world();
  $coinage_max += 90;
  $current_level += 1;
  echo("NEXT LEVEL VIA go_to_specific_level = "
   @ $current_level);
  echo("NEXT LEVEL VIA go_to_specific_level = "
   @ $current_level);
  echo("NEXT LEVEL VIA go_to_specific_level = "
   @ $current_level);
  level_number.text = $round_numeral;
  if ($current_level > 10) {
   level_number.text = 10;
  }

  //edit 12-27-2013 exception for beat 10 worlds, instead of moving to next world go back and play level, go forward to next world, play level, next level gets out of sync here because of $current_level
  if ($world_numeral == $maximum_world_player_got_to & $cheating_to_level_10 != 1) {
   //note this was disabling cheating to level 10 so it had to be adjusted for that accordingly
   //edit 02-13-2014 this exception made it so going back to old levels would accelerate progress levsel-wise to a new level, as well as add a new level text number
   //this checks whether it's appropriate
   if ($last_levsel_click_was == $maximum_level_player_got_to) {
    $round_numeral = $maximum_level_player_got_to;
    level_number.text = ""
    @ $round_numeral;
    if ($round_numeral > 10) {
     level_number.text = 10;
    }
    $current_level = $round_numeral;
    echo("At go_to_specific_level, level_number.text = " @ $round_numeral);
   }

  }
  //note the above was disabling cheating to level 10 so it had to be adjusted for that accordingly
  if ($cheating_to_level_10 == 1) {
   $cheating_to_level_10 = 0;
  }
  //sceneWindow2D.setCurrentCameraPosition( "100 0 100 75" ); 
  black_stretch.BlendColor = "0 0 0 0";
  black_stretch.setPositionX(9999);
  //Kill all char_attributes to release deteleport locks, and then deteleport them all
  $p1_present = 0;
  $cease_infinite_spawning_issues = 0;
  $char1_tutorial_over_with = 1;

  /* WRITE FILE */
  //$bob_test = 51;
  write_to_save_file();
  $in_between_levels_trophy_protect = 0;
  //Deteleport everyone and qualify them for anger and despawnability as to not hold up deteleport
  //edit 06-07-2013 found typo for is_despawned in that it was char1 for everyone. Assuming since char1 is the error, make var for everyone and set to 1 instead of 0
  empty_char_space1.accidental_deteleport_preventer = 0;
  empty_char_space2.accidental_deteleport_preventer = 0;
  empty_char_space3.accidental_deteleport_preventer = 0;
  empty_char_space4.accidental_deteleport_preventer = 0;
  empty_char_space1.detected_incoming_drink = 0;
  empty_char_space1.lock_incoming_drink = 0;
  empty_char_space1.is_despawned = 0;
  empty_char_space1.is_angry = 1;
  $do_not_animate_teleport = 1;
  empty_char_space1.deteleport();
  empty_char_space2.detected_incoming_drink = 0;
  empty_char_space2.lock_incoming_drink = 0;
  empty_char_space2.is_angry = 1;
  empty_char_space2.is_despawned = 0;
  empty_char_space2.deteleport();
  empty_char_space3.detected_incoming_drink = 0;
  empty_char_space3.lock_incoming_drink = 0;
  empty_char_space3.is_angry = 1;
  empty_char_space3.is_despawned = 0;
  empty_char_space3.deteleport();
  empty_char_space4.detected_incoming_drink = 0;
  empty_char_space4.lock_incoming_drink = 0;
  empty_char_space4.is_angry = 1;
  empty_char_space4.is_despawned = 0;
  empty_char_space4.deteleport();
  $do_not_animate_teleport = 0;
  //remove drink_in and drink_out attributes and set cooks to idle
  sodajerk1.abrupt_wash_dish();
  sodajerk2.abrupt_wash_dish();
  sodajerk3.abrupt_wash_dish();
  sodajerk4.abrupt_wash_dish();
  sodajerk1.is_washing = 0;
  sodajerk2.is_washing = 0;
  sodajerk3.is_washing = 0;
  sodajerk4.is_washing = 0;
  $everyone_washing = sodajerk1.is_washing + sodajerk2.is_washing + sodajerk3.is_washing + sodajerk4.is_washing;
  $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
  display_occupied2.text = $everyone_washing;

  //uncancel drink_out from above functions so bad things dont happen
  drink_out1.cancelled = 0;
  drink_out2.cancelled = 0;
  drink_out3.cancelled = 0;
  drink_out4.cancelled = 0;

  //re-force sodajerk idle just incase bad things happen
  sodajerk1.drink_out_blocking = 0;
  sodajerk2.drink_out_blocking = 0;
  sodajerk3.drink_out_blocking = 0;
  sodajerk4.drink_out_blocking = 0;

  //remove coin tips
  empty_coin1.reset_coin_tips();
  empty_coin2.reset_coin_tips();
  empty_coin3.reset_coin_tips();
  empty_coin4.reset_coin_tips();

  //remove mana glows
  mana_glow1.setAnimation(empty_char_spaceAnimation);
  mana_glow2.setAnimation(empty_char_spaceAnimation);
  mana_glow3.setAnimation(empty_char_spaceAnimation);
  mana_glow4.setAnimation(empty_char_spaceAnimation);
  dirty_glow1.setAnimation(empty_char_spaceAnimation);
  dirty_glow2.setAnimation(empty_char_spaceAnimation);
  dirty_glow3.setAnimation(empty_char_spaceAnimation);
  dirty_glow4.setAnimation(empty_char_spaceAnimation);

  //remove closing sign and set round animation
  closing_sign.setPositionX(9999);

  //Kill all waiter leftover tasks
  $waiter_waiting_for_old_world_data_to_die = 1;
  $stop_mass_clicking_last_tip_case_scenario = 0;
  //resetting this to zero just incase your going directly from broc2 to levels 2-10, instead of hitting a storyboard. Resets to 1 if hitting storyboard.
  if ($round_numeral != 1) {
   $currently_between_levels = 0;
  }
  if ($round_numeral == 1) {
   $currently_between_levels = 1;
  }
  $toggle_off_go_to_specific_level = 1;
 }


}

function skip_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 //edit 03-02-2015 if just skip theres no celeb yet, but as it goes check for celb warning bs
 $currently_on_celeb_warning = 0;
 $disable_special_char = 0;
 //edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
 erase_usage_of_cooks(); % this.setFrame(2);
 //edit 01-04-2015 check if fx should be skipped based on if level 1 of new world quitted and restarted and spit out $ignore_skip_ending_fx = 0 or 1
 should_we_skip_ending_fx();
 if ($skip_ending_fx == 1) {
  //edit 02-22-2015 special circumstance disable
  $hearts_disable_from_coin_tip = 1;
  sched_cancel_all();
 }
 //edit 06-29-2014 reactivate coin tip for char1 on
 green_light_chars();
 if ($world_numeral == 3 & $temp_lock_skip_numeral3 != 1) {
  //edit 03-02-2015 celeb warning data
  $currently_on_celeb_warning = 1;
  storyboard.setImageMap(board_spec_press2ImageMap);
  storyboard.setFrame(1);
  $temp_lock_skip_button = 1;
  $temp_lock_skip_numeral3 = 1;
  storyboard_text.text = $storyboard_airship4;
  $make_storyboard_into_skip_because_locks = 1;
  //edit 02-15-2015 making skip unlocks ONLY for inter profile
  $inter_profile_unlocks = 1;
 }
 if ($world_numeral == 4 & $temp_lock_skip_numeral4 != 1) {
  //edit 03-02-2015 celeb warning data
  $currently_on_celeb_warning = 1;
  storyboard.setImageMap(board_spec_elvisImageMap);
  storyboard.setFrame(1);
  $temp_lock_skip_button = 1;
  $temp_lock_skip_numeral4 = 1;
  storyboard_text.text = $storyboard_hawaii4;
  $make_storyboard_into_skip_because_locks = 1;
  //edit 02-15-2015 making skip unlocks ONLY for inter profile
  $inter_profile_unlocks = 1;
 }
 if ($world_numeral == 8 & $temp_lock_skip_numeral8 != 1) {
  //edit 03-02-2015 celeb warning data
  $currently_on_celeb_warning = 1;
  storyboard.setImageMap(board_spec_criticImageMap);
  storyboard.setFrame(1);
  $temp_lock_skip_button = 1;
  $temp_lock_skip_numeral8 = 1;
  storyboard_text.text = $storyboard_france4;
  $make_storyboard_into_skip_because_locks = 1;
  //edit 02-15-2015 making skip unlocks ONLY for inter profile
  $inter_profile_unlocks = 1;

 }
 if ($world_numeral == 9 & $temp_lock_skip_numeral9 != 1) {
  //edit 03-02-2015 celeb warning data
  $currently_on_celeb_warning = 1;
  storyboard.setImageMap(board_spec_foodinspectorImageMap);
  storyboard.setFrame(1);
  $temp_lock_skip_button = 1;
  $temp_lock_skip_numeral9 = 1;
  storyboard_text.text = $storyboard_metro4;
  $make_storyboard_into_skip_because_locks = 1;
  //edit 02-15-2015 making skip unlocks ONLY for inter profile
  $inter_profile_unlocks = 1;
 }
 if ($world_numeral == 10 & $temp_lock_skip_numeral10 != 1) {
  //edit 03-02-2015 celeb warning data
  $currently_on_celeb_warning = 1;
  storyboard.setImageMap(board_spec_mayorImageMap);
  storyboard.setFrame(1);
  $temp_lock_skip_button = 1;
  $temp_lock_skip_numeral10 = 1;
  $make_storyboard_into_skip_because_locks = 1;
  //edit 02-15-2015 making skip unlocks ONLY for inter profile
  $inter_profile_unlocks = 1;
 }
 if ($world_numeral == 11 & $temp_lock_skip_numeral11 != 1)
 //if($world_numeral == 11 & $storyboard_frame >= 0);
 {

  $activate_storyboard = 1;
  $make_storyboard_into_skip_because_locks = 0;
  alxStopAll();
  $default_audio = "mainmenu_theme";
  if ($mute_music != 1) {
   alxPlay($default_audio);
  }
  $screen_position_x = 200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  the_end.setBlendAlpha(1);
  comptroller.schedule(500, "roll_credits", 0);
 }

 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $temp_lock_skip_button != 1) {
  //edit 01-28-2014 make drink_out reset via map_sel as well
  drink_out1.active = 0;
  drink_out2.active = 0;
  drink_out3.active = 0;
  drink_out4.active = 0;
  pre_calculate_round_max_times();
  $initialize_bonus_portals_to_appear_random = 1;
  $toggle_initial_spawner_via_clock = 0;
  $game_has_started_for_clock = 1;
  $transitioning_from_skip_button = 1;
  skip_button.schedule(200, "cease_buttons_until_in", 0);
  $left_the_level_space = 0;
  $screen_position_x = 100;
  $screen_position_y = 0;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  $world_ended = 0;
  //edit 02-18-2015 trying a fix
  $open_for_storyboard_exception = 0;
  //edit 05-14-2013 Adding forced spawn char via end of storyboards and skip button instead of broc to clear up spawn delay errors
  //with exception of intro round 1 which different controls for tutorial purposes
  $halt_post_storyboard_adjustments = 0;

  //edit 12-27-2013 Adding exception for beat level 10, go back via map to original world instead of next, beat level, go to destination world via map, locked on black shop screen
  clean_up_level_transitions();

  if ($world_numeral == 1 & $round_numeral == 1) {
   $toggle_delay_the_tutorial = 1;
   comptroller.schedule(100, "quick_delay_the_tutorial", 0);
   prestarter_black.setPositionX(100);
   prestarter_black.setPositionY(0);
   $halt_post_storyboard_adjustments = 1;
   alxStopAll();
   $default_audio = $world_audio;
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }

   if ($world_numeral == 1 & $round_numeral == 1 & $first_game_ever_ever == 1) {
    $toggle_delay_the_tutorial = 2;
    tut_yes_button.onMouseDown( % this);
    tut_yes_button.onMouseUp( % this);
   }
  }

  if ($halt_post_storyboard_adjustments != 1) {

   empty_coin1.reset_coin_tips();
   empty_coin2.reset_coin_tips();
   empty_coin3.reset_coin_tips();
   empty_coin4.reset_coin_tips();
   path_round_num.setSpeed(round_num, 30);
  }
  alxStopAll();
  $default_audio = $world_audio;
  if ($mute_music != 1) {
   alxPlay($default_audio);
  }
  $currently_between_levels = 0;
  //empty_char_space1.new_pre_alpha_spawner();
  //THIS WILL BREAK EVERYTHING BUT KEEP JUST IN CASE
  /*
  	$round_numeral = %this.switch_to_round;
  	$toggle_off_go_to_specific_level = 0;
  	$game_has_started_for_clock = 1;
  	$toggle_initial_spawner_via_clock = 0;
  	$default_audio = $world_audio;
  	alxStopAll();
  	alxPlay($default_audio);
  	levsel_day_text.text = "Round " @ %this.switch_to_round;
  	*/
  write_to_save_file();
 }
 $temp_lock_skip_button = 0;

 //edit 01-04-2015 PROG BLOCK IF YOU EXIT ON LEVEL 1 OF WORLD 1 DUE TO END_THE_CLOCK NOT DISABLING, THIS CHECKS AND FIXES IT
 should_we_hard_start_the_clock();
 //edit 02-13-2015 unlocking storyboard skip locks if you 
 //lack of skip_button.onMouseDown() still fucks up game when switching to profile that starts on storyboard (with no celebs?)
 //edit 02-15-2015 making skip unlocks ONLY for inter profile
 if ($inter_profile_unlocks == 1 & $disable_new_edits != 1) {
  $make_storyboard_into_skip_because_locks = 0;
  $open_for_storyboard_exception = 1;
 }
}

function skip_button::cease_buttons_until_in() {
 $transitioning_from_skip_button = 0;
}

//TEMP CHEAT BUTTONS
function cheat_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $screen_position_x = 100;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function award_back_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_om_awards_button_because_tut_ext != 3 & $tut_ext_segment != 6 & $tut_ext_segment != 5 & $tut_ext_segment != 4) {
   $screen_position_x = 100;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  }
  if ($toggle_off_om_awards_button_because_tut_ext == 3) {
   $screen_position_x = 100;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   start_tut_ext_segment6();
  }
 }
}

//OPTIONS MENU RELATED
function button_options_ingame::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {

 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $disable_pause_for_black_out != 1) {
  if ($touchpad_activated != 1) {
   button_options_mouse.setFrame(3);
   button_options_touchpad.setFrame(0);
  }
  if ($touchpad_activated == 0) {
   button_options_mouse.setFrame(3);
   button_options_touchpad.setFrame(0);
  }
  if ($touchpad_activated == 1) {
   button_options_mouse.setFrame(0);
   button_options_touchpad.setFrame(3);
  }
  if ($tut_yes_is_active != 1 & $temporarily_disable_ingame_options_before_tutorial != 1) {
   if ($THE_GAME_IS_PAUSED != 1) {

    button_options_ingame.setFrame(0);
    $pooooo = monster_shake.getSceneTime();
    soft_pause();
    hard_pause();
    $via_ingame = 1;
    $screen_position_x = -200;
    $screen_position_y = 150;
    activate_side_borders();
    sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
    text_soundfx_level.text = $soundfx_loudness;
    text_music_level.text = $music_loudness;
    $default_audio = "map_theme";
    alxStopAll();
    if ($toggle_mute_music != 1) {
     alxPlay($default_audio);
    }
    $via_main_menu = 0;

   }
  }

 }
}

//OPTIONS VIA MAIN MENU
function button_options::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $mm_profile_button_has_been_clicked = 1;

  if ($touchpad_activated != 1) {
   button_options_mouse.setFrame(3);
   button_options_touchpad.setFrame(0);
  }
  if ($touchpad_activated == 0) {
   button_options_mouse.setFrame(3);
   button_options_touchpad.setFrame(0);
  }
  if ($touchpad_activated == 1) {
   button_options_mouse.setFrame(0);
   button_options_touchpad.setFrame(3);
  }
  if ($mm_options_completed == 1) {
   $THE_GAME_IS_PAUSED = 1;
   $pooooo = monster_shake.getSceneTime();
   monster_shake.setScenePause(true);
   $via_main_menu = 1;
   $screen_position_x = -200;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   button_options.setFrame("0");
   $toggle_mm_buttons_off = 1;
   read_from_save_file();
   text_soundfx_level.text = $soundfx_loudness;
   text_music_level.text = $music_loudness;
   $default_audio = "map_theme";
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   $via_main_menu = 1;
  }
 }
}

//options-clear
function clear_options_menu() {

}

//options-cancel
function options_cancel_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function options_cancel_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(0);
  $toggle_mm_buttons_off = 0;
 }
}

function options_cancel_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function options_cancel_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
 }
 //options-done
function options_done_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function options_done_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 //echo 03-03-2015 options adjust
 $options_done_button_accessed += 1;
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($via_ingame == 1 & $via_main_menu == 0 & $changed_mouse_or_touchpad == 1) {
   flush_level_entirely();
   $changed_mouse_or_touchpad = 0;
  } % this.setFrame(0);
  $toggle_mm_buttons_off = 0;
  if ($window_mode == 1) { % res = getDesktopResolution();
   $desktopWidth = getWord( % res, 0);
   $desktopHeight = getWord( % res, 1);
   $bpp = getWord( % res, 2);

   setScreenMode(1024, 768, $bpp, $fullScreen);
   $horizontal_scaling = 100;
   $screen_position_x = -200;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  }
  if ($via_main_menu == 1) {
   $screen_position_x = 0;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   button_options_ingame.setFrame(0);
   $THE_GAME_IS_PAUSED = 0;
   $pooooo = monster_shake.getSceneTime();
   monster_shake.setScenePause(false);
   $timescale = 1;
   if ($options_done_button_accessed < 1) {
    echo("\c2 HARD PAUSE ACCESS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! VIA UI GENERIC BUTTONS");
    hard_unpause();
   }
   text_soundfx_level.text = $soundfx_loudness;
   text_music_level.text = $music_loudness;
   $default_audio = "mainmenu_theme";
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   write_to_save_file();
  }

  if ($via_ingame == 1 & $via_main_menu == 0) {

   $screen_position_x = 100;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   button_options_ingame.setFrame(0);
   $THE_GAME_IS_PAUSED = 0;
   $pooooo = monster_shake.getSceneTime();
   monster_shake.setScenePause(false);
   $timescale = 1;
   soft_unpause();
   echo("-------HARD UNPAUSE VIA #5-----------------------------------------------------------------------------------------------");
   if ($ass_steak != 1) {
    echo("\c2 HARD PAUSE ACCESS 2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! VIA UI GENERIC BUTTONS");
    hard_unpause();
   }
   text_soundfx_level.text = $soundfx_loudness;
   text_music_level.text = $music_loudness;
   quickly_identify_world_audio();
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   write_to_save_file();
  }

  if ($startButton_has_been_mousedup_at_least_once == 1) {
   $allow_options_first_restart_bs = 1;
  }

 }
}

function options_done_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function options_done_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
 }
 //full screen check box
function options_check_box::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function options_check_box::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(0);
  ToggleFullScreen();
  $toggled_screen = 1;
 }
}

//full screen un-check box
function options_check_box2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

 }
}

function options_check_box2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  ToggleFullScreen();
  $toggled_screen = 0;
 }
}

function options_check_box2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {

}

function options_check_box2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {

}

function scroll_widget_soundfx::onMouseDown( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $widget1_ignitioned = 1;
  $activate_scrolling = 1;
  $widget_start1 = widget_beginner1.getPositionX();
  $widget_end1 = widget_ender1.getPositionX();
 }
}

function scroll_widget_soundfx::onMouseUp( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $activate_scrolling = 0;
 }
}

function scroll_widget_soundfx::onMouseLeave( % this, % worldPosition, % mouseClicks, % modifier) { % this_x = sceneWindow2D.getMousePosition();

 if ($activate_scrolling == 1 & % this_x > $widget_start1 & % this_x < $widget_end1) { % targetX = sceneWindow2D.getMousePosition(); % targetX2 = getWord( % targetX, 0);
  scroll_widget_soundfx.setPositionX( % targetX2);
  $widget1_x = % targetX2;
 }
}

//music
function scroll_widget_music::onMouseDown( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $widget2_ignitioned = 1;
  $activate_scrolling2 = 1;
  $widget_start2 = widget_beginner2.getPositionX();
  $widget_end2 = widget_ender2.getPositionX();
 }
}

function scroll_widget_music::onMouseUp( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $activate_scrolling2 = 0;
 }
}

function scroll_widget_music::onMouseLeave( % this, % worldPosition, % mouseClicks, % modifier) { % this_x = sceneWindow2D.getMousePosition();

 if ($activate_scrolling2 == 1 & % this_x > $widget_start2 & % this_x < $widget_end2) { % targetX = sceneWindow2D.getMousePosition(); % targetX2 = getWord( % targetX, 0);
  scroll_widget_music.setPositionX( % targetX2);
  $widget2_x = % targetX2;
 }

}

//difficulty
function scroll_widget_difficulty::onMouseDown( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $widget3_ignitioned = 1;
  $activate_scrolling3 = 1;
  $widget_start3 = widget_beginner3.getPositionX();
  $widget_end3 = widget_ender3.getPositionX();
 }
}

function scroll_widget_difficulty::onMouseUp( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $activate_scrolling3 = 0;
 }
}

function scroll_widget_difficulty::onMouseLeave( % this, % worldPosition, % mouseClicks, % modifier) { % this_x = sceneWindow2D.getMousePosition();

 if ($activate_scrolling3 == 1 & % this_x > $widget_start3 & % this_x < $widget_end3) { % targetX = sceneWindow2D.getMousePosition(); % targetX2 = getWord( % targetX, 0);
  scroll_widget_difficulty.setPositionX( % targetX2);
  $widget3_x = % targetX2;
 }

}

function scroll_widget_difficulty::onMouseMove( % this, % worldPosition, % mouseClicks, % modifier) {
 if ($activate_scrolling3 == 1) {
  $activate_scrolling3 = 0;
 }
}

/* BOUNCE ANIMATION TEST */

function moving_bouncer::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $abounce = 1;
  $athis_x = % this.getPositionX();
  $athis_y = % this.getPositionY();
  $athis_x2 = $athis_x + 10; % this.moveTo($athis_x2, $athis_y, 20, true, false, true, 0.1);
  moving_bouncer.schedule(500, "bounce1", 0);
 }
}

function moving_bouncer::bounce1( % this) {
 $athis_x2 = $athis_x + 9; % this.moveTo($athis_x2, $athis_y, 20, true, false, true, 0.1);
 moving_bouncer.schedule(70, "bounce2", 0);
}

function moving_bouncer::bounce2( % this) {
 $athis_x2 = $athis_x + 10; % this.moveTo($athis_x2, $athis_y, 20, true, false, true, 0.1);
 moving_bouncer.schedule(70, "bounce3", 0);
}

function moving_bouncer::bounce3( % this) {
 $athis_x2 = $athis_x + 9; % this.moveTo($athis_x2, $athis_y, 10, true, false, true, 0.1);
 moving_bouncer.schedule(50, "bounce4", 0);
}

function moving_bouncer::bounce4( % this) {
 $athis_x2 = $athis_x + 10; % this.moveTo($athis_x2, $athis_y, 10, true, false, true, 0.1);
}


/* -------------------------------------------------------------------- */
/* STORYBOARDS */
/* -------------------------------------------------------------------- */

function go_back_to_game_from_storyboard() {
 //edit 02-11-2015 locks are never relocked after skipping so I'm relocking it post-storyboard
 //$make_storyboard_into_skip_because_locks = 0;
 //edit 01-04-2015 PROG BLOCK IF YOU EXIT ON LEVEL 1 OF WORLD 1 DUE TO END_THE_CLOCK NOT DISABLING, THIS CHECKS AND FIXES IT
 should_we_hard_start_the_clock();
 $disable_special_char = 0;
 //edit 01-04-2015 check if fx should be skipped based on if level 1 of new world quitted and restarted and spit out $ignore_skip_ending_fx = 0 or 1
 should_we_skip_ending_fx();
 if ($skip_ending_fx == 1) {
  //edit 02-22-2015 special circumstance disable
  $hearts_disable_from_coin_tip = 1;
  sched_cancel_all();
 }
 //edit 01-28-2014 make drink_out reset via map_sel as well
 drink_out1.active = 0;
 drink_out2.active = 0;
 drink_out3.active = 0;
 drink_out4.active = 0;
 pre_calculate_round_max_times();
 $initialize_bonus_portals_to_appear_random = 1;
 $toggle_initial_spawner_via_clock = 0;
 $game_has_started_for_clock = 1;

 $end_the_clock = 0;
 //edit 10/01/2014 if you start off new world from new profile via profile menu, and go thru storyboards, do not allow clock to go on as tut_yes_no will instead
 if ($world_numeral == 1 & $current_level == 1) {
  $end_the_clock = 1;
 }
 echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ C");
 $left_the_level_space = 0;
 $screen_position_x = 100;
 $screen_position_y = 0;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 clean_up_level_transitions();

 $world_ended = 0;
 //edit 05-14-2013 Adding forced spawn char via end of storyboards and skip button instead of broc to clear up spawn delay errors
 $halt_post_storyboard_adjustments = 0;
 //this is for absolute first first round so it doesn't spawn two tut_char1's
 if ($world_numeral == 1 & $round_numeral == 1) {
  $halt_post_storyboard_adjustments = 1;
  $currently_between_levels = 0;
  write_to_save_file();
 }

 //this is for normally spawning and starting in another level
 if ($halt_post_storyboard_adjustments != 1) {
  empty_coin1.reset_coin_tips();
  empty_coin2.reset_coin_tips();
  empty_coin3.reset_coin_tips();
  empty_coin4.reset_coin_tips();
  path_round_num.setSpeed(round_num, 30);
  $currently_between_levels = 0;
  //08-14-2013 this doesn't exist anymore
  //empty_char_space1.new_pre_alpha_spawner();
  write_to_save_file();
 }
 if ($world_numeral == 1 & $round_numeral == 1 & $first_game_ever_ever == 1) {
  $toggle_delay_the_tutorial = 2;
  tut_yes_button.onMouseDown( % this);
  tut_yes_button.onMouseUp( % this);
 }

}

function storyboard::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $activate_storyboard = 1;
  //edit 02-10-2015 Need to tell whether storyboard was accessed or just carried over with mouseUp
  $storyboard_was_clicked = 1;
  //$make_storyboard_into_skip_because_locks = 0;
 }
}

function storyboard::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($world_numeral == 11) {
  $temp_lock_skip_numeral11 = 1;
 }
}

function storyboard::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 echo("STORYBOARD START -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
 //edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
 erase_usage_of_cooks();
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $activate_storyboard == 1 & $make_storyboard_into_skip_because_locks == 1) {
  echo("STORYBOARD PART 1 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
  //edit 06-29-2014 reactivate coin tip for char1 on
  green_light_chars();
  //edit 02-11-2015 this causes auto-skip error

  skip_button.onMouseDown( % this, % modifier, % worldPosition, % mouseClicks);
  $make_storyboard_into_skip_because_locks = 0;
 }
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $activate_storyboard == 1 & $make_storyboard_into_skip_because_locks != 1) {

  echo("STORYBOARD PART 2 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
  //edit 06-29-2014 reactivate coin tip for char1 on
  green_light_chars();
  $currently_between_levels = 1;
  //edit 06-22-2014 added round_numeral == 1 to confirm right world 
  if ($world_numeral == 1 & $round_numeral == 1 & $storyboard_frame > 2 & $storyboard_custom_intro_castle_switch == 0) {
   echo("STORYBOARD PART 3 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   //edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
   erase_usage_of_cooks();
   prestarter_black.setPositionX(100);
   prestarter_black.setPositionY(0);
   $toggle_delay_the_tutorial = 1;
   comptroller.schedule(100, "quick_delay_the_tutorial", 0);
   $storyboard_frame = -1;
   storyboard.setImageMap(storyboard_castle_finalImageMap);
   storyboard.setFrame(0);
   $storyboard_custom_intro_castle_switch = 1;
   alxStopAll();
   $default_audio = "castle_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
   //all_text.print_text();
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "castle_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
   if ($world_numeral == 1 & $round_numeral == 1 & $first_game_ever_ever == 1) {
    echo("STORYBOARD PART 4 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
    //tut_yes_button.onMouseDown();
    tut_yes_button.onMouseUp( % this);
   }
  }



  if ($world_numeral == 1 & $storyboard_frame >= 0 & $storyboard_custom_intro_castle_switch == 1) {

  }

  if ($world_numeral == 2 & $storyboard_frame >= 1) {
   echo("STORYBOARD PART 5 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   echo("Going to Swamppppppppppppppppppppppppppppppppppppppp");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "swamp_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  //Note: this has special press corps char
  if ($world_numeral == 3 & $storyboard_frame >= 3) {
   echo("STORYBOARD PART 6 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");

   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "airship_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  if ($world_numeral == 4 & $storyboard_frame >= 3) {
   echo("STORYBOARD PART 7 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "hawaii_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  if ($world_numeral == 5 & $storyboard_frame >= 2) {
   echo("STORYBOARD PART 8 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "viking_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  if ($world_numeral == 6 & $storyboard_frame >= 2) {
   echo("STORYBOARD PART 9 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "forest_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  if ($world_numeral == 7 & $storyboard_frame >= 2) {
   echo("STORYBOARD PART 10 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "train_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }


  //Note: this has special critic char
  if ($world_numeral == 8 & $storyboard_frame >= 3) {
   echo("STORYBOARD PART 11 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "france_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  //Note: this has special food inspector char
  if ($world_numeral == 9 & $storyboard_frame >= 3) {
   echo("STORYBOARD PART 12 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "newyork_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }

  //Note: this has special mayor char
  if ($world_numeral == 10 & $storyboard_frame >= 3) {
   echo("STORYBOARD PART 13 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   go_back_to_game_from_storyboard();
   alxStopAll();
   $default_audio = "hometown_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
  }
  if ($world_numeral == 11 & $storyboard_frame == 1) {
   echo("STORYBOARD PART 14 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   alxStopAll();
   $default_audio = "mainmenu_theme";
   if ($mute_music != 1) {
    alxPlay($default_audio);
   }
   $screen_position_x = 200;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   //this resets the game to main menu
   //%this.schedule(5000, "reset_game", 0);
   the_end.setBlendAlpha(1);
   //storyboard.schedule(44000, "reset_game", 0);
   comptroller.schedule(5000, "roll_credits", 0);
   //roll_credits();
  }
  echo("STORYBOARD CONTINUING -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
  //edit 03-02-2015 celeb warning data
  if ($currently_on_celeb_warning == 1 & $world_numeral == 3) {
   skip_button.onMouseDown();
   $currently_on_celeb_warning = 0;
  }
  //edit 02-18-2015 trying a fix
  if ($currently_on_celeb_warning == 1 & $world_numeral == 4) {
   skip_button.onMouseDown();
   $currently_on_celeb_warning = 0;
  }
  //edit 02-18-2015 trying a fix
  if ($currently_on_celeb_warning == 1 & $world_numeral == 8) {
   skip_button.onMouseDown();
   $currently_on_celeb_warning = 0;
  }
  //edit 02-18-2015 trying a fix
  if ($currently_on_celeb_warning == 1 & $world_numeral == 9) {
   skip_button.onMouseDown();
   $currently_on_celeb_warning = 0;
  }
  if ($currently_on_celeb_warning == 1 & $world_numeral == 10) {
   skip_button.onMouseDown();
   $currently_on_celeb_warning = 0;
  }

  % text_length_transfer = $this_text_length;
  $old_text_length = % text_length_transfer;
  $toggle_int_conv1 = 0;
  $toggle_int_conv2 = 0;
  $toggle_int_conv3 = 0;
  $redefine_y = 175.072;
  $game_text_block_identifier += 1;
  $storyboard_identifier = ($game_text_block_identifier + 1);
  $storyboard_frame += 1;
  storyboard.setFrame($storyboard_frame);

  print_game_text();

  //special character storyboard warning image
  if ($world_numeral == 3 & $storyboard_frame == 3) {
   echo("STORYBOARD PART 15 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   storyboard.setImageMap(board_spec_press2ImageMap);
   storyboard.setFrame(1);
  }
  if ($world_numeral == 4 & $storyboard_frame == 3) {
   echo("STORYBOARD PART 16 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   storyboard.setImageMap(board_spec_elvisImageMap);
   storyboard.setFrame(1);
  }
  if ($world_numeral == 8 & $storyboard_frame == 3) {
   echo("STORYBOARD PART 17 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   storyboard.setImageMap(board_spec_criticImageMap);
   storyboard.setFrame(1);
  }
  if ($world_numeral == 9 & $storyboard_frame == 3) {
   echo("STORYBOARD PART 18 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   storyboard.setImageMap(board_spec_foodinspectorImageMap);
   storyboard.setFrame(1);
  }
  if ($world_numeral == 10 & $storyboard_frame == 3) {
   echo("STORYBOARD PART 19 -----X---------X------X-XXXX--------------X---------X----------X--------X--------------XXXXX-XXX-X--XXX");
   storyboard.setImageMap(board_spec_mayorImageMap);
   storyboard.setFrame(1);
  }
  $activate_storyboard = 0;
 }
 //edit 02-10-2015 Need to tell whether storyboard was accessed or just carried over with mouseUp
 //Also need to end it so it doesnt carry on data to other profiles/levels
 $storyboard_was_clicked = 0;
}

function comptroller::quick_delay_the_tutorial() {
 $toggle_delay_the_tutorial = 2;
}

function storyboard::reset_game( % this) {
 reset_credits_position();
 $default_audio = "mainmenu_theme";
 alxStopAll();
 if ($toggle_mute_music != 1) {
  alxPlay($default_audio);
 }
 $screen_position_x = 0;
 $screen_position_y = 0;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
}

function int_test() { % poopp = 1.999; % integer_convert = mCeil( % poopp);
 echo( % integer_convert); % integer_convert2 = mFloor( % poopp);
 echo( % integer_convert2); % integer_convert3 = mAbs( % poopp);
 echo( % integer_convert3);
}

/* Note: Only set up for 6 lines max */
/* NOTE: Set restrictors in storyboard function above as well */

function all_text::print_text( % this) {

 /* special case 06-03-2013 If char Y is reset to 0 via overflow of printing because of conflict with text_length and variable_text_length
 	then set it back to base 175.072 */

 if ($redefine_y == 0) {
  $redefine_y = 175.072;
 }
 echo("redefine_y START : " @ $redefine_y);
 //Manual Find of addtl text lines
 //$_text_object_a = ($storyboard_base_identifier @ "a");
 $text_object_0 = % this.text;
 $_text_object_b = ($storyboard_base_identifier @ "b");
 $text_object_1 = $_[$_text_object_b];
 $_text_object_c = ($storyboard_base_identifier @ "c");
 $text_object_2 = $_[$_text_object_c];
 $_text_object_d = ($storyboard_base_identifier @ "d");
 $text_object_3 = $_[$_text_object_d];
 $_text_object_e = ($storyboard_base_identifier @ "e");
 $text_object_4 = $_[$_text_object_e];
 $_text_object_f = ($storyboard_base_identifier @ "f");
 $text_object_5 = $_[$_text_object_f];


 //Find longest possible length of all text strings combined
 % full_text_length = (":" @ $text_object_0 @ ":" @ $text_object_1 @ $text_object_2 @ $text_object_3 @ $text_object_4 @ $text_object_5);
 echo("FULL TEXT LENGTH " @ % full_text_length);
 //identify vector text position, compare dynamic text with char map, compare caps-sensitive letters to position of same letter in char map, setFrame to that position 
 % text_object = $text_object_[$char_line_on]; % text_length = strlen( % full_text_length);
 $this_text_length = % text_length;
 $variable_text_length = strlen( % text_object); % text_line_limit = $variable_text_length; % text_line_weight = ( % text_length / $on_current_character); % multi_line_checker = mFloor( % text_line_weight);

 echo("tEXT OBJECT : "
  @ % text_object @ "text_line_limit : ");

 //character map reflected of bitmap_font image frames
 $character_map = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ !\"#$%&``()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ [\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
 //get simple-string character from text_object incoming via iterated numeric @ 1 char per iteration
 % _compare_char_from_text_field = getSubStr( % text_object, $on_current_character, 1);
 //Convert simple-string character to caps-sensitive tagged string
 % compare_char_from_text_field = AddTaggedString( % _compare_char_from_text_field);
 //Get caps-sensitive character from text_object incoming	
 % convert_to_caps_sensitive = getTaggedString( % compare_char_from_text_field);
 //Find which char_map frame via caps_sensitive letter comparison, and use this to set as bitmap_font frame for individual letter
 % set_tag_to_frame = strstr($character_map, % convert_to_caps_sensitive);
 //echo("SET TAG TO FRAME : " @ %set_tag_to_frame @ " on_txtobj " @ %text_object);
 echo("FULL ECHO : set_frame :"
  @ % set_tag_to_frame @ " on_txtobj :"
  @ % text_object @ " char_line_on :"
  @ $char_line_on @ " _comp:"
  @ % _compare_char_from_text_field @ " comp:"
  @ % compare_char_from_text_field @ " caps:"
  @ % convert_to_caps_sensitive);


 % get_width = % this.getWidth(); % get_x = % this.getPositionX(); % redefine_x = (( % get_x) - ( % get_width / 2)) + 3.5; % get_height = % this.getHeight();
 if ($integer_conversion < 1) { % get_y = % this.getPositionY();
  $redefine_y = ( % get_y) - ( % get_height / 2);
 }
 echo("redefine_y START2 : "
  @ $redefine_y);
 echo("proper schedule of print character "
  @ $on_current_character @ " of "
  @ % text_length);

 //print characters if character enumerator is less than length of string
 if ($on_current_character <= % text_length) {
  echo("\c2 <<<<< iterating through at "
   @ $uninterrupted_iterator);
  //echo("parameter accepted");
  $on_current_character += 1;
  $uninterrupted_iterator += 1;
  $position_enumerator += 1.75; % clone_a_text_space = text_field_test.cloneWithBehaviors();
  $clone_char_name_iterator = $on_current_character - 1;
  $cloned_char_name[$uninterrupted_iterator] = % clone_a_text_space.getId(); % clone_a_text_space.name = "text_field_test"
  @ $on_current_character; % text_to_clone_getposX = % redefine_x; % text_to_clone_getposY = $redefine_y;
  echo("redefine_y END: "
   @ % text_to_clone_setnewposY @ "getId"
   @ % clone_a_text_space.getId()); % text_to_clone_setnewposX = % text_to_clone_getposX + $position_enumerator; % clone_a_text_space.setFrame( % set_tag_to_frame);
  echo("SET TAG TO FRAME "
   @ % set_tag_to_frame); % text_to_clone_setnewposY = $redefine_y + 0;
  % clone_a_text_space.setPosition( % text_to_clone_setnewposX, % text_to_clone_setnewposY);
  $iterate_through_char_map = 0; % this.schedule(0.1, "print_text", 0);
  echo("redefine_y END2 : "
   @ % text_to_clone_setnewposY @ "getId"
   @ % clone_a_text_space.getId());
 }
 //NOTE! this makes it so when it stops printing text at the end of single storyboard panel, that it can do something
 //if you add things here, it'll make it do things at the end of that panel, possibly cutting up the storyboard
 if ($on_current_character > % text_length) {
  echo("all_text scheduling wait_for_text_to_end()");
  echo("at $on_current_character > %text_length, $world_numeral = "
   @ $world_numeral); % this.schedule(0.4, "wait_for_text_to_end", 0);

  //if last level ever, switch to main menu after 4 seconds to simulate credit roll going back to mm
  if ($world_numeral == 11 & $storyboard_frame >= 3) { % this.schedule(4000, "switch_to_main_menu", 0);
  }
 }

}

//note this may call too many times
function all_text::wait_for_text_to_end( % this) {
 $all_characters_printed = 1;
 $on_current_character = 0; % this.text = "";
 $position_enumerator = 0;
 //$uninterrupted_iterator = 0;
 echo("$world_numeral = "
  @ $world_numeral);
 if ($world_numeral == 11 & $storyboard_frame >= 3) {
  //echo("ABSOLUTE_END");
  //echo("ABSOLUTE_END");
  echo("ABSOLUTE_END");
  $screen_position_x = 200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function all_text::switch_to_main_menu( % this) {
 //go back to main menu
 $screen_position_x = 0;
 $screen_position_y = 0;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
}

function all_text::delete_old_text( % this) {
 /* NOTE 06-03-2013 : DOES NOt DELETE BECAUSE FUNCTION DOESNT HAVE TIME TO RUN THROUGH UNTIL NEXT FUNCTION (EG NEXT STORYBOARD RUNS THRU) 
 FOR CHECKING: DISABLE NEW $all_characters_printed = 0; AT STORYBOARD LEVEL FUNCTION TO SEE DIFFERENCE */

 echo("\c2 delete_old_text called");

 if ($all_characters_printed == 1 & $delete_enumerator < $recast_deletion_number) {
  echo("\c2  >>>TEXT LENGTH AT "
   @ $uninterrupted_iterator @ " <<< vs "
   @ $recast_deletion_number);



  $name_this_clone = $cloned_char_name[$delete_enumerator];
  $cloned_char_name[$delete_enumerator].delete();
  $delete_enumerator += 1; % this.schedule(0.0001, "delete_old_text", 0);
  echo("\c2 DELETION @ " @ $delete_enumerator @ "  " @ $name_this_clone);
  echo("\c2 DELETION @ " @ $delete_enumerator @ "  " @ $name_this_clone);
  echo("\c2 DELETION @ " @ $delete_enumerator @ "  " @ $name_this_clone);
 }
 if ($all_characters_printed == 1 & $delete_enumerator >= $recast_deletion_number) {
  echo("REACHED END OF DELETE FUNC");
  $all_characters_printed = 0;
 }

}

/* APPETIZER 1 */
function appetizer1::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($appetizer1_amount[$world_numeral] <= 0) { % this_x = % this.getPositionX(); % this_y = % this.getPositionY();
  display_all_out.setPositionX( % this_x);
  display_all_out.setPositionY( % this_y);
 }
}

function appetizer1::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this_x = 105.892; % this_y = 52.708;
 display_all_out.setPositionX( % this_x);
 display_all_out.setPositionY( % this_y);
}

function appetizer1::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $worthy_of_drink_is_appetizer1 == 1) {
  if ($tut_yes_is_active == 1 & $tut_appetizer1_active == 1 & $tut_very_last_char_clicked != 1 & $current_level == 1 & $world_numeral == 1) {

   tutorial_text_block.text = $tut_13b;
   tutorial_clicker.setPositionX(112);
   tutorial_clicker.setPositionY(1);
   tutorial_clicker.setBlendAlpha(1);
   tutorial_text_block.setPositionX(125);
   tutorial_text_block.setPositionY(4);
   tutorial_bar.setPositionX(160);
   tutorial_bar.setPositionY(4);
   $tut_appetizer1_active = 1;
   $tut_appetizer1_clicked = 1;
  }

  if ($tut_yes_is_active == 1 & $tut_appetizers_part_b == 1 & $tut_very_last_char_clicked != 1) {
   $allow_appetizers_in_all_conditions = 1;
  }
  if ($tut_yes_is_active != 1) {
   $allow_appetizers_in_all_conditions = 1;
  }

  if ($THE_GAME_IS_PAUSED != 1 & $toggle_cursor_is_serving == 1 & $appetizer1_amount[$world_numeral] > 0 & $allow_appetizers_in_all_conditions == 1) {
   if ($world_numeral == 10) {
    $appetizer1_counted_for_trophy = 1;
   }
   $appetizer1_used = 1;
   set_cursor_to_appetizer1();
   $appetizer1_amount[$world_numeral] -= 1;
   appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
   //predict this is because at level 10, it turns into world numeral 2
   appetizer1_amt.text = $appetizer1_amount[$world_numeral];
   $worthy_of_drink_is_appetizer1 = 0;
   $worthy_of_drink_is_appetizer2 = 0;
   //Trophy: Speedster Appetizer
   if ($individualized_char_timer <= 100 & $trophy_toggle_off_button6 != 1) {
    $root_trophy_identfier = "button6";
    win_this_trophy();
    $trophy_toggle_off_button6 = 1;
   }
  }

 }
}

function appetizer2::tut_lock_char1_in_alone_again( % this) {
 $game_has_started_for_clock = 0;
 $toggle_initial_spawner_via_clock = 1;
 $game_clock_number = 0;
 appetizer2_amt_ingame.text = 0;
 appetizer2.setFrame(0);
}

/* APPETIZER 2 */
function appetizer2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($appetizer2_amount[$world_numeral] <= 0) { % this_x = % this.getPositionX(); % this_y = % this.getPositionY();
  display_all_out.setPositionX( % this_x);
  display_all_out.setPositionY( % this_y);
 }
}

function appetizer2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this_x = 105.892; % this_y = 52.708;
 display_all_out.setPositionX( % this_x);
 display_all_out.setPositionY( % this_y);
}

function appetizer2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $worthy_of_drink_is_appetizer2 == 1) {

  if ($tut_yes_is_active != 1) {
   $allow_appetizers_in_all_conditions = 1;
  }

  if ($THE_GAME_IS_PAUSED != 1 & $toggle_cursor_is_serving == 1 & $appetizer2_amount[$world_numeral] > 0 & $allow_appetizers_in_all_conditions == 1) {
   if ($world_numeral == 10) {
    $appetizer2_counted_for_trophy = 1;
   }
   $appetizer2_used = 1;
   set_cursor_to_appetizer2();
   $appetizer2_amount[$world_numeral] -= 1;
   appetizer2_amt_ingame.text = $appetizer2_amount[$world_numeral];
   appetizer2_amt.text = $appetizer2_amount[$world_numeral];
   $worthy_of_drink_is_appetizer2 = 0;
   $worthy_of_drink_is_appetizer1 = 0;
   //Trophy: Speedster Appetizer
   if ($individualized_char_timer <= 100 & $trophy_toggle_off_button6 != 1) {
    $root_trophy_identfier = "button6";
    win_this_trophy();
    $trophy_toggle_off_button6 = 1;
   }
  }

 }
}

//edit 02-13-2014 Seeing if appetizers need to be hid if amount threshold reaches 0
function check_if_need_to_hide_appetizers() {
 //find each appetizer's recorded amount per world
 % appetizer1_show_amount = $appetizer1_amount[$world_numeral]; % appetizer2_show_amount = $appetizer2_amount[$world_numeral];
 //rewrite appetizer numeral just incase it was missed (like in startButton) so it's not falsely represented as zero
 appetizer1_amt_ingame.text = % appetizer1_show_amount;
 appetizer2_amt_ingame.text = % appetizer2_show_amount;
 //rewrite appetizer order stock numeral just incase it was missed (like in startButton) so it's not falsely represented as zero
 appetizer1_amt.text = % appetizer1_show_amount;
 appetizer2_amt.text = % appetizer2_show_amount;
 //switch frames of order menu images because blah blah above
 menu_icon_bites.setFrame($world_numeral);
 menu_icon_beverages.setFrame($world_numeral);
 //names and base costs 04-30-2014
 appetizer1_tag.text = $appetizer1_tag_text[$world_numeral];
 appetizer2_tag.text = $appetizer2_tag_text[$world_numeral];
 entertainer1_tag.text = $entertainer1_tag_text[$world_numeral];
 entertainer2_tag.text = $entertainer2_tag_text[$world_numeral];
 appetizer1_cost.text = $current_bite_rate_for_world[$world_numeral];
 appetizer2_cost.text = $current_bev_rate_for_world[$world_numeral];

 if ($tut_yes_is_active != 1 & % appetizer1_show_amount <= 0) {
  //appetizer1.setBlendAlpha(0);
 }
 if ($tut_yes_is_active != 1 & % appetizer1_show_amount > 0) {
  appetizer1.setBlendAlpha(1);
 }
 if ($tut_yes_is_active != 1 & % appetizer2_show_amount <= 0) {
  //appetizer2.setBlendAlpha(0);
 }
 if ($tut_yes_is_active != 1 & % appetizer2_show_amount > 0) {
  appetizer2.setBlendAlpha(1);
 }
}


/* PERMA MUTE DEBUG BUTTON */
function perma_mute::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  alxStopAll();
 }
}

/* 6-25-2013 NEW SOUNDFX-MUSIC-DIFFICULTY BUTTONS */

/* SOUND FX -------------------------------------------------- */

/* Minus */
function minus_soundfx::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_soundfx_stopped = 0;

  if ($soundfx_loudness > 0) {
   $sfx_level -= 0.01;
   $soundfx_loudness -= 1;
   alxSetChannelVolume($SFXType, $sfx_level);
   if ($mute_soundfx != 1) {
    alxPlay(blipAudio);
   }
   text_soundfx_level.text = $soundfx_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function minus_soundfx::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_soundfx_stopped = 1;
  $minus_soundfx_deca_accelerate = 0;
 }
}

function minus_soundfx::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $minus_soundfx_stopped = 1;
 $minus_soundfx_deca_accelerate = 0;
}

function minus_soundfx::auto_decrement( % this) {
 if ($minus_soundfx_stopped != 1 & $minus_soundfx_deca_accelerate != 1 & $soundfx_loudness > 0) {
  $sfx_level -= 0.01;
  $soundfx_loudness -= 1;
  alxSetChannelVolume($SFXType, $sfx_level);
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  }
  text_soundfx_level.text = $soundfx_loudness; % this.schedule(100, "auto_decrement", 0);
 }
}

function minus_soundfx::deca_question( % this) {
 if ($minus_soundfx_stopped != 1) {
  $minus_soundfx_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function minus_soundfx::deca_accelerate( % this) {
 if ($minus_soundfx_stopped != 1 & $soundfx_loudness > 0 & $minus_soundfx_deca_accelerate != 0) {
  $sfx_level -= 0.01;
  $soundfx_loudness -= 1;
  text_soundfx_level.text = $soundfx_loudness;
  alxSetChannelVolume($SFXType, $sfx_level);
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  } % this.schedule(50, "deca_accelerate", 0);
 }
}

/* Plus */
function plus_soundfx::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_soundfx_stopped = 0;

  if ($soundfx_loudness < 100) {
   $soundfx_loudness += 1;
   $sfx_level += 0.01;
   alxSetChannelVolume($SFXType, $sfx_level);
   if ($mute_soundfx != 1) {
    alxPlay(blipAudio);
   }
   text_soundfx_level.text = $soundfx_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function plus_soundfx::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_soundfx_stopped = 1;
  $plus_soundfx_deca_accelerate = 0;
 }
}

function plus_soundfx::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $plus_soundfx_stopped = 1;
 $plus_soundfx_deca_accelerate = 0;
}

function plus_soundfx::auto_decrement( % this) {
 if ($plus_soundfx_stopped != 1 & $plus_soundfx_deca_accelerate != 1 & $soundfx_loudness < 100) {
  $soundfx_loudness += 1;
  $sfx_level += 0.01;
  alxSetChannelVolume($SFXType, $sfx_level);
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  }
  text_soundfx_level.text = $soundfx_loudness; % this.schedule(100, "auto_decrement", 0);
 }
}

function plus_soundfx::deca_question( % this) {
 if ($plus_soundfx_stopped != 1) {
  $plus_soundfx_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function plus_soundfx::deca_accelerate( % this) {
 if ($plus_soundfx_stopped != 1 & $soundfx_loudness < 100 & $plus_soundfx_deca_accelerate != 0) {
  $soundfx_loudness += 1;
  $sfx_level += 0.01;
  alxSetChannelVolume($SFXType, $sfx_level);
  if ($mute_soundfx != 1) {
   alxPlay(blipAudio);
  }
  text_soundfx_level.text = $soundfx_loudness; % this.schedule(50, "deca_accelerate", 0);
 }
}

/* MUSIC ------------------------------------------------- */

/* Minus */
function minus_music::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_music_stopped = 0;

  if ($music_loudness > 0) {
   $music_loudness -= 1;
   $music_level -= 0.01;
   alxSetChannelVolume($GuiAudioType, $music_level);
   text_music_level.text = $music_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function minus_music::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_music_stopped = 1;
  $minus_music_deca_accelerate = 0;
 }
}

function minus_music::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $minus_music_stopped = 1;
 $minus_music_deca_accelerate = 0;
}

function minus_music::auto_decrement( % this) {
 if ($minus_music_stopped != 1 & $minus_music_deca_accelerate != 1 & $music_loudness > 0) {
  $music_loudness -= 1;
  $music_level -= 0.01;
  alxSetChannelVolume($GuiAudioType, $music_level);
 }

}

function minus_music::deca_question( % this) {
 if ($minus_music_stopped != 1) {
  $minus_music_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function minus_music::deca_accelerate( % this) {
 if ($minus_music_stopped != 1 & $music_loudness > 0 & $minus_music_deca_accelerate != 0) {
  $music_loudness -= 1;
  $music_level -= 0.01;
  alxSetChannelVolume($GuiAudioType, $music_level);
  text_music_level.text = $music_loudness; % this.schedule(50, "deca_accelerate", 0);
 }
}

/* Plus */
function plus_music::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_music_stopped = 0;

  if ($music_loudness < 100) {
   $music_loudness += 1;
   $music_level += 0.01;
   alxSetChannelVolume($GuiAudioType, $music_level);
   text_music_level.text = $music_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function plus_music::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_music_stopped = 1;
  $plus_music_deca_accelerate = 0;
 }
}

function plus_music::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $plus_music_stopped = 1;
 $plus_music_deca_accelerate = 0;
}

function plus_music::auto_decrement( % this) {
 if ($plus_music_stopped != 1 & $plus_music_deca_accelerate != 1 & $music_loudness < 100) {
  $music_loudness += 1;
  $music_level += 0.01;
  alxSetChannelVolume($GuiAudioType, $music_level);
  text_music_level.text = $music_loudness; % this.schedule(100, "auto_decrement", 0);
 }
}

function plus_music::deca_question( % this) {
 if ($plus_music_stopped != 1) {
  $plus_music_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function plus_music::deca_accelerate( % this) {
 if ($plus_music_stopped != 1 & $music_loudness < 100 & $plus_music_deca_accelerate != 0) {
  $music_loudness += 1;
  $music_level += 0.01;
  alxSetChannelVolume($GuiAudioType, $music_level);
  text_music_level.text = $music_loudness; % this.schedule(50, "deca_accelerate", 0);
 }
}

/* DIFFICULTY ------------------------------------------------- */

/* Minus */
function minus_difficulty::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_difficulty_stopped = 0;

  if ($difficulty_loudness > 0) {
   $difficulty_loudness -= 1;
   text_difficulty_level.text = $difficulty_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function minus_difficulty::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $minus_difficulty_stopped = 1;
  $minus_difficulty_deca_accelerate = 0;
 }
}

function minus_difficulty::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $minus_difficulty_stopped = 1;
 $minus_difficulty_deca_accelerate = 0;
}

function minus_difficulty::auto_decrement( % this) {
 if ($minus_difficulty_stopped != 1 & $minus_difficulty_deca_accelerate != 1 & $difficulty_loudness > 0) {
  $difficulty_loudness -= 1;
  text_difficulty_level.text = $difficulty_loudness; % this.schedule(100, "auto_decrement", 0);
 }
}

function minus_difficulty::deca_question( % this) {
 if ($minus_difficulty_stopped != 1) {
  $minus_difficulty_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function minus_difficulty::deca_accelerate( % this) {
 if ($minus_difficulty_stopped != 1 & $difficulty_loudness > 0 & $minus_difficulty_deca_accelerate != 0) {
  $difficulty_loudness -= 1;
  text_difficulty_level.text = $difficulty_loudness; % this.schedule(50, "deca_accelerate", 0);
 }
}

/* Plus */
function plus_difficulty::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_difficulty_stopped = 0;

  if ($difficulty_loudness < 3) {
   $difficulty_loudness += 1;
   text_difficulty_level.text = $difficulty_loudness; % this.schedule(100, "auto_decrement", 0); % this.schedule(500, "deca_question", 0);
  }
 }
}

function plus_difficulty::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $plus_difficulty_stopped = 1;
  $plus_difficulty_deca_accelerate = 0;
 }
}

function plus_difficulty::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $plus_difficulty_stopped = 1;
 $plus_difficulty_deca_accelerate = 0;
}

function plus_difficulty::auto_decrement( % this) {
 if ($plus_difficulty_stopped != 1 & $plus_difficulty_deca_accelerate != 1 & $difficulty_loudness < 3) {
  $difficulty_loudness += 1;
  text_difficulty_level.text = $difficulty_loudness; % this.schedule(100, "auto_decrement", 0);
 }
}

function plus_difficulty::deca_question( % this) {
 if ($plus_difficulty_stopped != 1) {
  $plus_difficulty_deca_accelerate = 1; % this.schedule(10, "deca_accelerate", 0);
 }
}

function plus_difficulty::deca_accelerate( % this) {
 if ($plus_difficulty_stopped != 1 & $difficulty_loudness < 3 & $plus_difficulty_deca_accelerate != 0) {
  $difficulty_loudness += 1;
  text_difficulty_level.text = $difficulty_loudness; % this.schedule(50, "deca_accelerate", 0);
 }
}

function menu_icon_bites::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  menu_icon_bites.BlendColor = "1 1 1 1";
 }
}

function menu_icon_bites::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 menu_icon_bites.BlendColor = "1 1 1 1";
 appetizer1_cost.BlendColor = "1 1 1 1";
}

function menu_icon_bites::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 menu_icon_bites.BlendColor = "1 1 0 1";
}

function menu_icon_bites::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_om_appetizer_buttons_because_tut_ext != 1) {
   menu_icon_bites.BlendColor = "0.5 0.5 0 1"; % current_world_bite_rate = $current_bite_rate_for_world[$world_numeral];
   //appetizer1_cost.text = $current_bite_rate_for_world[$world_numeral];
   if ($coinage > % current_world_bite_rate) {
    $coinage -= 20;
    score_number.text = $coinage;
    menu_coinage_left.text = $coinage;
    _menu_coinage_left.text = $coinage;
    $appetizer1_purchased[$world_numeral] = 1;
    $appetizer1_amount[$world_numeral] += 1;
    appetizer1_amt.text = $appetizer1_amount[$world_numeral];
    appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
   }

   if ($coinage < % current_world_bite_rate) {
    menu_icon_bites.BlendColor = "1 0 0 1";
    appetizer1_cost.BlendColor = "1 0 0 1";
   }
   //Trophy 20 Best Bites
   calculate_appetizer_amounts();
   /*
   echo("At trophy ribbon6 collection, $total_appetizers_collected = " @ $total_appetizers_collected);
   if($total_appetizers_collected == 20 & $trophy_toggle_off_ribbon6 != 1)
   {
   	$root_trophy_identfier = "ribbon6";
   	win_this_trophy();
   	$trophy_toggle_off_ribbon6 = 1;
   }
   */
  }
 }
}

function menu_icon_beverages::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  menu_icon_beverages.BlendColor = "1 1 1 1";
 }
}

function menu_icon_beverages::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 menu_icon_beverages.BlendColor = "1 1 1 1";
 appetizer2_cost.BlendColor = "1 1 1 1";
}

function menu_icon_beverages::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 menu_icon_beverages.BlendColor = "1 1 0 1";
}

function menu_icon_beverages::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_om_appetizer_buttons_because_tut_ext != 1) {
   menu_icon_beverages.BlendColor = "0.5 0.5 0 1"; % current_world_beverage_rate = $current_bev_rate_for_world[$world_numeral];
   if ($coinage > % current_world_beverage_rate) {
    $coinage -= 35;
    score_number.text = $coinage;
    menu_coinage_left.text = $coinage;
    _menu_coinage_left.text = $coinage;
    $appetizer2_purchased[$world_numeral] = 1;
    $appetizer2_amount[$world_numeral] += 1;
    appetizer2_amt.text = $appetizer2_amount[$world_numeral];
    appetizer2_amt_ingame.text = $appetizer2_amount[$world_numeral];
   }

   if ($coinage < % current_world_beverage_rate) {
    menu_icon_beverages.BlendColor = "1 0 0 1";
    appetizer2_cost.BlendColor = "1 0 0 1";
   }
   //Trophy 20 Best Bites
   calculate_appetizer_amounts();
  }
 }
}

/* LEVEL SELECTION --------------------------------------------------------------------------------------------------------- */
function coin_me_up::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
  if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
   coin_me_up.record_me = 1;
   $points_you_have = 250000;
   $star_sys_medal_won = 3;
   gold_clock_limit_says.text = "coin me up";
   silver_clock_limit_says.text = 0;
   bronze_clock_limit_says.text = 0;
  }
 }
 //edit 02-28-2014 Added function to instantly correct indescrepencies in star_sys when switching between profiles, modes, options, etc.
 //goto_levsel.auto_correct_star_sys_errors();
function goto_levsel::auto_correct_errors( % this) {
 //fixes problem with current upcoming level being given star sys numbers
 echo("-------auto_correct_star_sys_errors------------------------------------------------");
 echo("$maximum_level_player_got_to = "
  @ $maximum_level_player_got_to);
 echo("$current_level = "
  @ $current_level);
 echo("$round_numeral = "
  @ $round_numeral);
 echo("-----------------------------------------------------------------------------------"); % find_previous_level = $current_level - 1; % find_current_level_icon = "levsel_"
 @ $current_level; % find_previous_level_icon = "levsel_"
 @ % find_previous_level;
 //edit 02-28-2014 If level isn't 1 so it won't subtract to zero and break the game and the upcoming level to select is now unlocked, the level before has to be unlocked so set the icon accordingly
 if ($current_level > 1 & % find_current_level_icon.unlocked == 1) { % find_previous_level_icon.setFrame(0);
 }

 //gives last_level the current_level's star sys number IF NEXT AHEAD

}

//NOTE: this is the new broc2 -------------
function goto_levsel::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($world_numeral == 10 & $current_level == 0) {

 }

 if ($world_numeral == 11 & $current_level == 1) {
  $toggle_to_credits = 0;
  //$temp_lock_skip_numeral11 = 0;
  //comptroller.schedule(500, "special_storyboard_lock_for_world11_credits", 0);
 }
 if ($world_numeral == 10 & $current_level != 0) {
  $toggle_to_credits = 0;
 }
 if ($world_numeral == 11 & $current_level != 1) {
  $toggle_to_credits = 0;
 }
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $toggle_to_credits != 1) {
  if ($toggle_off_om_continue_button_because_tut_ext != 1) {
   echo("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
   echo("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
   echo("\c2 at goto_levsel, current world is "
    @ $world_numeral @ ", Max world is "
    @ $maximum_world_player_got_to);
   echo("\c2 at goto_levsel, current level is "
    @ $current_level @ ", vs $round_numeral "
    @ $round_numeral @ ", Max level is "
    @ $maximum_level_player_got_to);
   echo("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
   echo("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
   //this is a temp checker, delete it later
   text_current_level.text = $current_level;

   //edit 03-17-2014 Attempting a more accurate bypass for straight through playing
   if ($current_level == 1) {
    $allow_clicking_on_map = 1;
   }
   if ($current_level != 1) {
    $allow_clicking_on_map = 0;
    which_allow.text = 2;
   }

   if ($stopgap_for_cheat_through == 1) {
    //$alert_levsel_bypass = 0;
    //$allow_clicking_on_map = 1;
    $clean_up_in_progress_so_skip_the_map = 0;
   }

   //This bypass below is to prevent storyboards from suddenly showing up if you click goto_levsel, red map button, world click
   if ($alert_levsel_bypass == 0) {
    //edit 03-15-2014 this makes it so storyboards show upon mapsel click of each new world for first time
    //note 03-17-2014 it also breaks the game if you go goto_levsel, red map button, world click

    echo("\c2 at goto_levsel, current level is "
     @ $current_level);

    //I don't know why it wants level 2 but it works
    //This makes storyboard transition via map possible
    if ($world_numeral != 1 & $current_level == 2) {
     $allow_clicking_on_map = 1;
    }
    //this makes it skip storyboards via map when they're not necessary
    if ($current_level != 2) {
     $allow_clicking_on_map = 0;
     which_allow.text = 3;
    }

    if ($stopgap_for_cheat_through == 1) {
     //$alert_levsel_bypass = 0;
     //$allow_clicking_on_map = 1;
     $clean_up_in_progress_so_skip_the_map = 0;
    }
    //$default_audio = "map_theme";
    //alxStopAll();
    //alxPlay($default_audio);

    reset_alpha_of_star_system_levels();
    $toggle_off_transitioning_screens = 0;

    $game_has_started_for_clock = 0;
    $toggle_initial_spawner_via_clock = 1;

    /* schedule in star system animation events */
    goto_levsel.schedule(10, "auto_correct_errors", 0);
    goto_levsel.schedule(250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(750, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1000, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1750, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2000, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2550, "reset_list_of_star_system_levels", 0);

    if ($maximum_world_player_got_to == $world_numeral) {
     $iterate_through_level_select_buttons = 1;
     $iterate_through_locked_select_buttons = $maximum_level_player_got_to + 1; % identify_button_to_untoggle = "levsel_"
     @ $maximum_level_player_got_to; % identify_button_to_untoggle.setFrame(0); % identify_button_to_untoggle.unlocked = 1; % this_buttons_x = % identify_button_to_untoggle.getPositionX(); % this_buttons_y = % identify_button_to_untoggle.getPositionY();
     levsel_pulse_glow_echo.setPositionX( % this_buttons_x);
     levsel_pulse_glow_echo.setPositionY( % this_buttons_y);
     //edit 12-29-2013 extra functionality to accurately tell which past-present-future world youre on
     if ($timeless_world_numeral >= $maximum_world_player_got_to) {
      comptroller.schedule(1, "unlock_all_previous_level_select_buttons_just_incase", 0);
      comptroller.schedule(1, "lock_all_future_level_select_buttons_just_incase", 0);
     }
     if ($timeless_world_numeral < $maximum_world_player_got_to) {
      //$world_numeral = $timeless_world_numeral;
     }
    }
    $screen_position_x = -200;
    $screen_position_y = 0;
    activate_side_borders();
    fix_any_levsel_errors();
    sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   }

   if ($alert_levsel_bypass == 1) {
    $toggle_off_go_to_specific_level = 0;
    go_to_specific_level();
    $alert_levsel_bypass = 0;
   }
   //edit 06-10-2014 if player goes to previous world, plays level 10, at order menu, the data will shift to the next world but the levsel imagery will not
   repair_damaged_levsels(); % levsel_root_text = "level_world_text"
   @ $world_numeral;
   $find_levsel_text = $_[ % levsel_root_text];
   levsel_world_text.text = $find_levsel_text;
   _levsel_world_text.text = $find_levsel_text;
   repair_outdated_levsel_buttons();
  }
 }
}

function comptroller::unlock_all_previous_level_select_buttons_just_incase( % this) {
 echo("\c2 comptroller::unlock_all_previous_level_select_buttons_just_incase "
  @ $iterate_through_level_select_buttons @ " vs "
  @ $maximum_level_player_got_to);
 echo("comptroller $timeless_world_numeral = "
  @ $timeless_world_numeral);
 if ($maximum_level_player_got_to > 1 & $iterate_through_level_select_buttons < $maximum_level_player_got_to) { % identify_button_to_untoggle = "levsel_"
  @ $iterate_through_level_select_buttons; % identify_button_to_untoggle.setFrame(0); % identify_button_to_untoggle.unlocked = 1;
  $iterate_through_level_select_buttons += 1;
  comptroller.schedule(1, "unlock_all_previous_level_select_buttons_just_incase", 0);
 }
}

function comptroller::lock_all_future_level_select_buttons_just_incase( % this) {
 echo("\c2 comptroller::lock_all_future_level_select_buttons_just_incase "
  @ $iterate_through_level_select_buttons @ " vs "
  @ $maximum_level_player_got_to);
 echo("comptroller $timeless_world_numeral = "
  @ $timeless_world_numeral);
 if ($maximum_level_player_got_to >= 1 & $iterate_through_locked_select_buttons > $maximum_level_player_got_to & $iterate_through_locked_select_buttons <= 10) { % identify_button_to_untoggle = "levsel_"
  @ $iterate_through_locked_select_buttons; % identify_button_to_untoggle.setFrame(3); % identify_button_to_untoggle.unlocked = 0;
  $iterate_through_locked_select_buttons += 1;
  comptroller.schedule(1, "lock_all_future_level_select_buttons_just_incase", 0);
 }
}

function reset_all_worlds() {
 $iterate_through_world_icons = 0;
 //reset the map just in case switching profiles and not starting from scratch
 //reload_factory_settings();
 if ($world_numeral != 11) {
  mapsel_2.setFrame(1);
  mapsel_3.setFrame(1);
  mapsel_4.setFrame(1);
  mapsel_5.setFrame(1);
  mapsel_6.setFrame(1);
  mapsel_7.setFrame(1);
  mapsel_8.setFrame(1);
  mapsel_9.setFrame(1);
  mapsel_10.setFrame(1);
  mapsel_2.unlocked = 0;
  mapsel_3.unlocked = 0;
  mapsel_4.unlocked = 0;
  mapsel_5.unlocked = 0;
  mapsel_6.unlocked = 0;
  mapsel_7.unlocked = 0;
  mapsel_8.unlocked = 0;
  mapsel_9.unlocked = 0;
  mapsel_10.unlocked = 0;
 }
 if ($world_numeral >= 11) {
  hide_map_locks();
 }
 $map_dot_iterater = 0;
 map_dot01.setFrame(0);
 map_dot02.setFrame(0);
 map_dot03.setFrame(0);
 map_dot04.setFrame(0);
 map_dot05.setFrame(0);
 map_dot06.setFrame(0);
 map_dot07.setFrame(0);
 map_dot08.setFrame(0);
 map_dot09.setFrame(0);
 map_dot10.setFrame(0);
 map_dot11.setFrame(0);
 map_dot12.setFrame(0);
 map_dot13.setFrame(0);
 map_dot14.setFrame(0);
 map_dot15.setFrame(0);
 map_dot16.setFrame(0);
 map_dot17.setFrame(0);
 map_dot18.setFrame(0);
 map_dot19.setFrame(0);
 map_dot20.setFrame(0);
 map_dot21.setFrame(0);
 map_dot22.setFrame(0);
 map_dot23.setFrame(0);
 map_dot24.setFrame(0);
 map_dot25.setFrame(0);
 map_dot26.setFrame(0);
 map_dot27.setFrame(0);
 map_dot28.setFrame(0);
 map_dot29.setFrame(0);
 map_dot30.setFrame(0);
 map_dot31.setFrame(0);
 map_dot32.setFrame(0);
 map_dot33.setFrame(0);
 map_dot34.setFrame(0);
 map_dot35.setFrame(0);
 map_dot36.setFrame(0);
 map_dot37.setFrame(0);
 map_dot38.setFrame(0);
 map_dot39.setFrame(0);
 map_dot40.setFrame(0);
 map_dot41.setFrame(0);
 map_dot42.setFrame(0);
 map_dot43.setFrame(0);
 map_dot44.setFrame(0);
 map_dot45.setFrame(0);
 map_dot46.setFrame(0);
 map_dot47.setFrame(0);


}

function correct_for_dot_iterator_via_map_button() {
 if ($world_numeral == 1) {
  $map_dot_max = 0;
 }
 if ($world_numeral == 2) {
  $map_dot_max = 6;
 }
 if ($world_numeral == 3) {
  $map_dot_max = 9;
 }
 if ($world_numeral == 4) {
  $map_dot_max = 13;
 }
 if ($world_numeral == 5) {
  $map_dot_max = 18;
 }
 if ($world_numeral == 6) {
  $map_dot_max = 24;
 }
 if ($world_numeral == 7) {
  $map_dot_max = 28;
 }
 if ($world_numeral == 8) {
  $map_dot_max = 38;
 }
 if ($world_numeral == 9) {
  $map_dot_max = 43;
 }
 if ($world_numeral == 10) {
  $map_dot_max = 48;
 }
}

function comptroller::unlock_all_previous_worlds_at_start( % this) {
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);
 echo("Starting map unlocking function at: $maximum_world_player_got_to "
  @ $maximum_world_player_got_to @ " $iterate_through_world_icons "
  @ $iterate_through_world_icons);

 if ($maximum_world_player_got_to > 1 & $iterate_through_world_icons <= $maximum_world_player_got_to) {
  echo("entering comptroller::unlock_all_previous_worlds_at_start specific at "
   @ $iterate_through_world_icons); % identify_button_to_untoggle = "mapsel_"
  @ $iterate_through_world_icons; % identify_button_to_untoggle.setFrame(0); % identify_button_to_untoggle.unlocked = 1;
  $iterate_through_world_icons += 1;
  comptroller.schedule(1, "unlock_all_previous_worlds_at_start", 0);
 }
}

function levsel_buttons::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ( % this.unlocked == 1 & $no_clicking_levsel_buttons != 1 & $activate_continuing_tutorial != 1) {
   $delay_mouseup_of_levsel_buttons = 0; % this.setFrame(2);
   levsel_day_text.text = "Round "
   @ % this.switch_to_round;
  }
  if ( % this.switch_to_round == 2 & $activate_continuing_tutorial == 1) {
   $delay_mouseup_of_levsel_buttons = 0; % this.setFrame(2);
   levsel_day_text.text = "Round "
   @ % this.switch_to_round;
  }
 }
}

function levsel_buttons::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 01-03-2015 to assume-fix blackout delay error upon options button
  $disable_pause_for_black_out = 0;
  //Need to identify the last world was completed so if you go back and play level 10 again, everything wont screw up
  if ( % this.switch_to_round == 1) { % previous_world = $current_world - 1;
   $previous_world_has_been_completed[ % previous_world] = 1;
  }
  //If at end of tutorial, switch it off permanently
  if ( % this.switch_to_round == 2 & $activate_continuing_tutorial == 1 & $tut_ext_segment == 13) {
   $activate_continuing_tutorial = 0;
   hide_remaining_tutorial_cache();
  }

  if ( % this.unlocked == 1 & $no_clicking_levsel_buttons != 1 & $delay_mouseup_of_levsel_buttons != 1 & $activate_continuing_tutorial != 1) {
   //edit 06-29-2014 reactivate coin tip for char1 on
   green_light_chars();
   reset_sodajerk_statuses();
   check_if_need_to_hide_appetizers();
   //appetizer1.setBlendAlpha(1);
   //appetizer2.setBlendAlpha(1);	
   //appetizer1.setFrame($world_numeral);
   //appetizer2.setFrame($world_numeral);

   if ( % this.cheat_button == 999) {
    //cheatsies is located here, it's just been classed
    $cheating_to_level_10 = 1;
    //make all 10 levels of that world all gold winners
    //find the base^10 of every world
    % find_ten_from_twenty_start_ss_world_data = (($world_numeral * 10) - 10);
    //define what gold is to the computer
    $define_gold_status = 3;
    //define levels to cheat on to input array
    $cheat_gold_on_level_01 = 0 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_02 = 1 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_03 = 2 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_04 = 3 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_05 = 4 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_06 = 5 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_07 = 6 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_08 = 7 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_09 = 8 + % find_ten_from_twenty_start_ss_world_data;
    $cheat_gold_on_level_10 = 9 + % find_ten_from_twenty_start_ss_world_data;
    //input to array
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_01, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_02, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_03, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_04, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_05, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_06, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_07, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_08, $define_gold_status);
    $star_system_array = setWord($star_system_array, $cheat_gold_on_level_09, $define_gold_status);
    //$star_system_array = setWord($star_system_array, $cheat_gold_on_level_10, $define_gold_status); 
    echo("$star_system_array CHEATED AT 10 = "
     @ $star_system_array);
    //level_number.text = 10;

   } % this.setFrame(1);
   echo("COMPUTER PREDICTED $round_numeral = "
    @ $round_numeral);
   echo("COMPUTER PREDICTED $round_numeral = "
    @ $round_numeral);
   echo("COMPUTER PREDICTED $round_numeral = "
    @ $round_numeral);
   $round_numeral = % this.switch_to_round;
   echo("FORCE PREDICTED $round_numeral = "
    @ $round_numeral);
   echo("FORCE PREDICTED $round_numeral = "
    @ $round_numeral);
   echo("FORCE PREDICTED $round_numeral = "
    @ $round_numeral);
   level_number.text = ""
   @ $round_numeral;
   if ($round_numeral > 10) {
    level_number.text = 10;
   }
   //edit 03-22-2014 cheater 10 exemption
   if ( % this.cheat_button == 999) {
    level_number.text = ""
    @ 10;
   }
   $toggle_off_go_to_specific_level = 0;
   $game_has_started_for_clock = 1;
   $toggle_initial_spawner_via_clock = 0;
   $default_audio = $world_audio;
   /*
   alxStopAll();		
   alxPlay($default_audio);
   */

   //edit 02-12-2014 go_to_specific_level function readjusts setting necessary to keep proper level number so adding exception 
   //minus 1 because the function adds one indiscrimenantly
   $current_level = $round_numeral - 1;
   $last_levsel_click_was = % this.switch_to_round;
   //edit 02-17-2014 secretly force level 1 to switch to level 2 temporarily to avoid conflicts
   if ( % this.switch_to_round == 1) {
    $round_numeral = 2;
    $current_level = $round_numeral - 1;
   }
   //edit 02-22-2015 special circumstance disable
   $hearts_disable_from_coin_tip = 1;
   //edit 06-11-2014 added to cancel schedules immediately before levsel clicking
   sched_cancel_all();
   go_to_specific_level();
   //edit 02-17-2014 secretly switch data back to level 1		
   if ( % this.switch_to_round == 1) {
    $round_numeral = 1;
    //$current_level = $round_numeral - 1;
    level_number.text = $round_numeral;
    if ($round_numeral > 10) {
     level_number.text = 10;
    }
    //edit 03-22-2014 cheater 10 exemption
    if ( % this.cheat_button == 999) {
     level_number.text = ""
     @ 10;
    }
   }
   $initialize_bonus_portals_to_appear_random = 1;
   pre_calculate_round_max_times();
   levsel_day_text.text = "Round "
   @ % this.switch_to_round;
   coin_me_up.record_me += 1;
   drink_out1.active = 0;
   drink_out2.active = 0;
   drink_out3.active = 0;
   drink_out4.active = 0;
   //edit 02-16-2014 adjustment for out-of-order plays
   alxStopAll();
   //$default_audio = $default_audio[%this.switch_to_round];
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   //edit 02-11-2014 New round digit identifying and animating system
   if ($round_numeral < 10) {
    $find_first_digit_of_round_display = 0;
    $find_second_digit_of_round_display = % this.switch_to_round;
    $level_number.text = % this.switch_to_round;
    if ($round_numeral > 10) {
     level_number.text = 10;
    }
    //edit 03-22-2014 cheater 10 exemption
    if ( % this.cheat_button == 999) {
     level_number.text = ""
     @ 10;
    }
    round_digit1.setFrame($find_first_digit_of_round_display);
    round_digit2.setFrame($find_second_digit_of_round_display);
   }
   if ($round_numeral == 10) {
    $find_first_digit_of_round_display = 1;
    $find_second_digit_of_round_display = 0;
    $level_number.text = % this.switch_to_round;
    //edit 03-22-2014 cheater 10 exemption
    if ( % this.cheat_button == 999) {
     level_number.text = ""
     @ 10;
    }
    round_digit1.setFrame($find_first_digit_of_round_display);
    round_digit2.setFrame($find_second_digit_of_round_display);
   }
   //edit 02-11-2014 adding continued round number animaion via startButton
   path_round_num.setSpeed(round_num, 30);
  }
  //if(level_number
 }
}

function levsel_buttons::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.switch_to_round <= 5) { % find_clock_frame = % this.switch_to_round - 1;
  clock_hand.setFrame( % find_clock_frame);
  clock_hand.setPositionX(-212.987);
  clock_hand.setFlipX(false);
 }
 if ( % this.switch_to_round > 5) { % find_clock_frame = % this.switch_to_round - 6;
  clock_hand.setFrame( % find_clock_frame);
  clock_hand.setPositionX(-186.309);
  clock_hand.setFlipX(true);
 }
 if ( % this.unlocked == 1 & $no_clicking_levsel_buttons != 1) { % this.setFrame(1);
  levsel_day_text.text = "Round "
  @ % this.switch_to_round;
 }
}

function levsel_buttons::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.unlocked == 1 & $no_clicking_levsel_buttons != 1) { % this.setFrame(0);
  levsel_day_text.text = "-";
 }

 if ( % this.unlocked == 0 & $no_clicking_levsel_buttons != 1) { % this.setFrame(3);
  levsel_day_text.text = "-";
 }
}

function levsel_redd::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_button_levsel_menu_because_tut_ext != 1) { % this.setFrame(2);
  }
 }
}

function levsel_redd::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_button_levsel_menu_because_tut_ext != 1) { % this.setFrame(1);
  }
 }
}

function levsel_redd::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_button_levsel_menu_because_tut_ext != 1) { % this.setFrame(1);
 }
}

function levsel_redd::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_button_levsel_menu_because_tut_ext != 1) { % this.setFrame(0);
 }
}

function levsel_map::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_button_levsel_menu_because_tut_ext != 1) {
   if ($toggle_off_transitioning_screens == 1) {
    //edit 06-10-2014 making every scenario possible for map
    $allow_clicking_on_map = 1;
    $world_numeral = $maximum_world_player_got_to;
    $current_level = $maximum_level_player_got_to;
    //and everything else...
    $stall_map_related_mouseups = 1;
    $screen_position_x = 0;
    $screen_position_y = 150;
    activate_side_borders();
    sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
    //$allow_clicking_on_map = 1;
    $toggle_from_map_button = 1;

   }
  }
 }
}

function levsel_map::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_button_levsel_menu_because_tut_ext != 1) {
   $toggle_off_transitioning_screens = 1;
  }
 }
}

function levsel_menu::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_button_levsel_menu_because_tut_ext != 1) {
   change_entertainer_icon_for_order_menu();
   $screen_position_x = 100;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   menu_coinage_left.text = $coinage;
   _menu_coinage_left.text = $coinage;
   order_menu_world.text = $_level_world_text[$world_numeral];
  }
 }
}

function mapsel::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.unlocked == 1) { % this.setFrame(2);
  mapsel_lock.setPositionX(9999);
  mapsel_lock.setPositionY(9999);
 }
 if ( % this.unlocked == 0) { % x_point = % this.getPositionX(); % y_point = % this.getPositionY();
  mapsel_lock.setPositionX( % x_point);
  mapsel_lock.setPositionY( % y_point);
 }
}

function mapsel::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.unlocked == 1) { % this.setFrame(0);
  mapsel_lock.setPositionX(9999);
  mapsel_lock.setPositionY(9999);
 }
 mapsel_lock.setPositionX(9999);
 mapsel_lock.setPositionY(9999);
}

function mapsel::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($stall_map_related_mouseups != 1 & $lock_map_buttons_until_released == 1) {
   if ( % this.unlocked == 1) {
    //edit 01-04-2015 turn off function killer for scenario level 10 - next world, lvl 2 - prev world, lvl 10
    $function_killer = 0;
    //06-10-2014 sigh fuck shit making world equal upon click
    $world_numeral = % this.world_ident;
    $the_current_world = % this.world_ident;
    reset_sodajerk_statuses();
    $timeless_world_numeral = % this.world_ident;
    //edit 12-29-2013 Trying to grasp what current world is regardless of dynamics
    if ( % this.world_ident < $maximum_world_player_got_to) {
     //%this.world_ident = $world_numeral;
     //$timeless_world_numeral = %this.world_ident;
     echo("$timeless_world_numeral"
      @ $timeless_world_numeral);
    }
    $world_numeral = % this.world_ident;
    //edit 02-13-2014 check if appetizers are ready yet
    check_if_need_to_hide_appetizers();
    //exception: if player decides after beating level ten, map dot iterates, and they go back, pause storyboards until they do what they're supposed to
    if ($allow_clicking_on_map == 1 & $world_numeral != $maximum_world_player_got_to) {
     $delay_storyboard_stuff = 1;
     $allow_clicking_on_map = 0;
     which_allow.text = 4;
    }
    if ($world_numeral == $maximum_world_player_got_to & $delay_storyboard_stuff == 1) {
     $allow_clicking_on_map = 1;
     $delay_storyboard_stuff = 0;
    }

    echo("$maximum_world_player_got_to "
     @ $maximum_world_player_got_to @ " %this.world_ident "
     @ % this.world_ident @ " $maximum_level_player_got_to "
     @ $maximum_level_player_got_to @ " $current_level "
     @ $current_level);

    //edit 03-17-2014 Attempting a more accurate bypass for straight through playing
    if ($maximum_world_player_got_to == % this.world_ident & $maximum_level_player_got_to == 1 & $current_level == 1) {
     $allow_clicking_on_map = 1;
    }
    if ($maximum_world_player_got_to == % this.world_ident & $maximum_level_player_got_to != 1) {
     $allow_clicking_on_map = 0;
     which_allow.text = 5;
    }
    if ($maximum_world_player_got_to == % this.world_ident & $current_level != 1) {
     $allow_clicking_on_map = 0;
     which_allow.text = 6;
    }
    if ($maximum_world_player_got_to != % this.world_ident) {
     $allow_clicking_on_map = 0;
     which_allow.text = 7;
    }
    //$current_level = $maximum_level_player_got_to;
    //switching order menu makes $allow_clicking_on_map == 0, $world_numeral = 1, $maximum_world_player_got_to = 2
    if ($allow_clicking_on_map == 1 & $world_numeral == $maximum_world_player_got_to) {
     //THIS GOES TO STORYBOARDS
     echo("\c2 SWITCHING TO STORYBOARDS");
     echo("\c2 SWITCHING TO STORYBOARDS");
     echo("\c2 SWITCHING TO STORYBOARDS");
     $screen_position_x = -100;
     $screen_position_y = 150;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);

     /* repair any damaged storyboards from moving around worlds, playing rounds before continuing to storyboard initial level */
     $storyboard_frame = 0;
     repair_damaged_storyboards();
     storyboard.setFrame(0);
     $game_text_block_identifier = 1;
     print_game_text();


     $allow_clicking_on_map = 0;
     which_allow.text = 8;
     $bypass_mapsel_to_levsel = 1;
     //edit 01-28-2014 make drink_out reset via map_sel as well
     drink_out1.active = 0;
     drink_out2.active = 0;
     drink_out3.active = 0;
     drink_out4.active = 0;
    } % level_button_bitmap = "levsel_world"
    @ $world_numeral @ "_buttonImageMap"; % level_bkgd_bitmap = "levsel_bkgd_"
    @ $world_numeral @ "ImageMap";

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
    bkgd_levsel_main.setImageMap( % level_bkgd_bitmap);
    if ($world_numeral < $maximum_world_player_got_to) {
     levsel_1.setFrame(0);
     levsel_2.setFrame(0);
     levsel_3.setFrame(0);
     levsel_4.setFrame(0);
     levsel_5.setFrame(0);
     levsel_6.setFrame(0);
     levsel_7.setFrame(0);
     levsel_8.setFrame(0);
     levsel_9.setFrame(0);
     levsel_10.setFrame(0);

     levsel_1.unlocked = 1;
     levsel_2.unlocked = 1;
     levsel_3.unlocked = 1;
     levsel_4.unlocked = 1;
     levsel_5.unlocked = 1;
     levsel_6.unlocked = 1;
     levsel_7.unlocked = 1;
     levsel_8.unlocked = 1;
     levsel_9.unlocked = 1;
     levsel_10.unlocked = 1;
    }
    if ($world_numeral == $maximum_world_player_got_to) {
     levsel_1.setFrame(3);
     levsel_2.setFrame(3);
     levsel_3.setFrame(3);
     levsel_4.setFrame(3);
     levsel_5.setFrame(3);
     levsel_6.setFrame(3);
     levsel_7.setFrame(3);
     levsel_8.setFrame(3);
     levsel_9.setFrame(3);
     levsel_10.setFrame(3);

     $iterate_through_level_select_buttons = 1;
     $iterate_through_locked_select_buttons = $maximum_level_player_got_to + 1; % identify_button_to_untoggle = "levsel_"
     @ $maximum_level_player_got_to; % identify_button_to_untoggle.setFrame(0); % identify_button_to_untoggle.unlocked = 1; % this_buttons_x = % identify_button_to_untoggle.getPositionX(); % this_buttons_y = % identify_button_to_untoggle.getPositionY();
     levsel_pulse_glow_echo.setPositionX( % this_buttons_x);
     levsel_pulse_glow_echo.setPositionY( % this_buttons_y);
     //edit 12-29-2013 extra functionality to accurately tell which past-present-future world youre on			
     if ($timeless_world_numeral >= $maximum_world_player_got_to) {
      comptroller.schedule(1, "unlock_all_previous_level_select_buttons_just_incase", 0);
      comptroller.schedule(1, "lock_all_future_level_select_buttons_just_incase", 0);
     }
     if ($timeless_world_numeral < $maximum_world_player_got_to) {
      $world_numeral = $timeless_world_numeral;
     }
    }
    $no_clicking_levsel_buttons = 1;
    $delay_mouseup_of_levsel_buttons = 1;
    comptroller.schedule(500, "undelay_clicking_on_levsel_buttons_to_prevent_click_throughs", 0);
    if ($bypass_mapsel_to_levsel != 1) {
     $screen_position_x = -200;
     $screen_position_y = 0;
     activate_side_borders();
     sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
     fix_any_levsel_errors();
    }
    $bypass_mapsel_to_levsel = 0;

    //edit 02-16-2014 trying to get game to correctly identify the world its in for out of order level purposes
    $world_numeral = % this.world_ident;
    /* edit 02-16-2014 schedule in star system animation events */
    //edit 02-16-2014 $current_levely may break things, or fix EVERYTHING
    $current_level = 0;
    levsel_stars1.setAnimation(star_sys0Animation);
    levsel_stars2.setAnimation(star_sys0Animation);
    levsel_stars3.setAnimation(star_sys0Animation);
    levsel_stars4.setAnimation(star_sys0Animation);
    levsel_stars5.setAnimation(star_sys0Animation);
    levsel_stars6.setAnimation(star_sys0Animation);
    levsel_stars7.setAnimation(star_sys0Animation);
    levsel_stars8.setAnimation(star_sys0Animation);
    levsel_stars9.setAnimation(star_sys0Animation);
    levsel_stars10.setAnimation(star_sys0Animation);
    goto_levsel.schedule(250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(750, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1000, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(1750, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2000, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2250, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2500, "process_in_list_of_star_system_levels", 0);
    goto_levsel.schedule(2550, "reset_list_of_star_system_levels", 0);
   }
   if ( % this.unlocked == 0) {

   }

   //if tutorial extended at map section:
   if ($toggle_off_om_map_button_because_tut_ext == 3 & % this.world_ident == 1) {
    start_tut_ext_segment8();
    //sceneWindow2D.setCurrentCameraPosition( "-200 0 100 75" );		
   }
   $lock_map_buttons_until_released = 0; % levsel_root_text = "level_world_text"
   @ $world_numeral;
   $find_levsel_text = $_[ % levsel_root_text];
   levsel_world_text.text = $find_levsel_text;
   _levsel_world_text.text = $find_levsel_text;
  }
 }
}

function mapsel::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $stall_map_related_mouseups = 0;
  $lock_map_buttons_until_released = 1;
 }
}

function comptroller::undelay_clicking_on_levsel_buttons_to_prevent_click_throughs() {
 $no_clicking_levsel_buttons = 0;
}

function mute_game_music::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(1);
 }
}

function mute_game_music2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(1);
 }
}

function mute_game_music::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
 }
}

function mute_game_music2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
 }
}

function mute_game_music::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(2);
  }
 }
}

function mute_game_music2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(2);
  }
 }
}

function mute_game_music::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
   $mute_music = 1;
   $toggle_mute_music = 1;
   $toggle_from_mute_music_mouseUp = 1;
   mute_game_music.setPositionX(168.108);
   mute_game_music.setPositionY(-31.931);
   mute_game_music2.setPositionX(133.173);
   mute_game_music2.setPositionY(-30.975);
   alxStopAll();
  }
 }
}

function mute_game_music2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
   $mute_music = 0;
   $toggle_mute_music = 0;
   $toggle_from_mute_music_mouseUp = 0;
   mute_game_music2.setPositionX(168.108);
   mute_game_music2.setPositionY(-31.931);
   mute_game_music.setPositionX(133.173);
   mute_game_music.setPositionY(-30.975);
   alxPlay($default_audio);
  }
 }
}

function mute_game_soundfx::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(1);
 }
}

function mute_game_soundfx2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(1);
 }
}

function mute_game_soundfx::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
 }
}

function mute_game_soundfx2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
 }
}

function mute_game_soundfx::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(2);
  }
 }
}

function mute_game_soundfx2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(2);
  }
 }
}

function mute_game_soundfx::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
   $mute_soundfx = 1;
   $toggle_mute_soundfx = 1;
   $toggle_from_mute_soundfx_mouseUp = 1;
   mute_game_soundfx.setPositionX(165.356);
   mute_game_soundfx.setPositionY(-32.006);
   mute_game_soundfx2.setPositionX(130.421);
   mute_game_soundfx2.setPositionY(-31.050);
  }
 }
}

function mute_game_soundfx2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.setFrame(0);
   $mute_soundfx = 0;
   $toggle_mute_soundfx = 0;
   $toggle_from_mute_soundfx_mouseUp = 0;
   mute_game_soundfx2.setPositionX(165.356);
   mute_game_soundfx2.setPositionY(-32.006);
   mute_game_soundfx.setPositionX(130.421);
   mute_game_soundfx.setPositionY(-31.050);
  }
 }
}

function exit_out_game::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  alxStopAll();
  monster_shake.setScenePause(true);
  //write_to_save_file();
  quit();
 }
}

function options_to_main_menu::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function options_to_main_menu::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
}

function options_to_main_menu::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function options_to_main_menu::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 //$options_to_main_menu = 0;
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 02-13-2015 unlocking storyboard skip locks if you 
  //lack of skip_button.onMouseDown() still fucks up game when switching to profile that starts on storyboard (with no celebs?)
  //edit 02-15-2015 New sysytem for locking-unlocking based only on celeb levels and only inter profile
  if ($inter_profile_unlocks == 1 & $disable_new_edits != 1) {

   //note : if $inter_profile_unlocks was activated, so was $make_storyboard_into_skip_because_locks for external so do this
   $make_storyboard_into_skip_because_locks = 1;
   //reset $inter_profile_unlocks
   $inter_profile_unlocks = 0;
  }
  echo("-----------GOING BACK TO MAIN MENU------------------------------------------------------------------------------------------");
  echo("-----------GOING BACK TO MAIN MENU------------------------------------------------------------------------------------------");
  echo("-----------GOING BACK TO MAIN MENU------------------------------------------------------------------------------------------");
  echo("-----------GOING BACK TO MAIN MENU------------------------------------------------------------------------------------------");
  if ($window_mode == 1) {
   echo("$window_mode"); % res = getDesktopResolution();
   $desktopWidth = getWord( % res, 0);
   $desktopHeight = getWord( % res, 1);
   $bpp = getWord( % res, 2);

   setScreenMode(1024, 768, $bpp, $fullScreen);
   $horizontal_scaling = 100;
   $screen_position_x = -200;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  }
  if ($via_main_menu == 1) {
   echo("$via_main_menu"); % this.setFrame(0);
   $screen_position_x = 0;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   button_options_ingame.setFrame(0);
   $THE_GAME_IS_PAUSED = 0;
   //alxStopAll();
   //alxPlay($default_audio);
   $pooooo = monster_shake.getSceneTime();
   monster_shake.setScenePause(false);
   $timescale = 1;
   $toggle_mm_buttons_off = 0;
   //edit 06-29-2014 disabling excess unpause
   //soft_unpause();
   //hard_unpause();
  }
  $default_audio = "mainmenu_theme";
  alxStopAll();
  if ($toggle_mute_music != 1) {
   alxPlay($default_audio);
  }
  //edit 02-09-2014 Added to save audio data	
  write_to_save_file();
  $screen_position_x = 0;
  $screen_position_y = 0;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  //edit 03-10-2015 this is the cause of last error
  if ($any_profile_slot_has_been_clicked != 1 & $mm_profile_button_has_been_clicked == 1) {
   $disable_the_last_game_profile_error = 1;
  }
  if ($disable_the_last_game_profile_error != 1) {
   $game_profile_has_not_yet_changed = 1;
  }
  $last_profile_played = $profile_for_this_session;

 }
}

//INITIAL TIME SPACE CHECK
function bonus_portal1::check_time_space( % identify_this_time_space, % identify_this_time_space2, % identify_this_time_space3) {
  //comptroller.identify_time_space = %identify_this_time_space;
  schedule_checker.text = "event id "
  @ % identify_this_time_space;
  schedule_checker2.text = "world "
  @ % identify_this_time_space2;
  schedule_checker3.text = "level "
  @ % identify_this_time_space3;
 }
 //bonus_portal
function bonus_portal1::bonus_portal_spawn( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  //schedule_checker.text = "level " @ $identify_this_time_space;
  if ($left_the_level_space != 1) {
   $bonus_portal_active1 = 1;
   bonus_portal1.setAnimation(vortex_in4Animation);
  }
 }
}

function bonus_portal1::bonus_portal_repeat( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {
  if ($left_the_level_space != 1) {
   bonus_portal1.setAnimation(vortex4Animation);

   echo("bonus portal_1");
   $animate_bonus_once = 0;
   $bonus_portal_active1 = 1;
   if ($activate_continuing_tutorial == 1 & $hint_bonus1_disabled != 1) {
    hint_bonus1.setBlendAlpha(1);
    $hint_bonus1_disabled = 1;
   }
  }
 }
}

function bonus_portal1::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  if ($bonus_portal_active1 == 1) {
   if ($left_the_level_space != 1) {
    if ($mute_soundfx != 1) {
     alxPlay(voop);
    }
    bonus_portal1.setAnimation(click_boomAnimation);
    if ($activate_continuing_tutorial == 1) {
     hint_bonus1.setBlendAlpha(0);
    }
    $points_amount += 10;
    points_number.text = $points_amount;
    point_up_empty_space3.setPositionX($points_number_x);
    point_up_empty_space3.setPositionY($points_number_y);
    point_up_empty_space3.setAnimation(fx_point_up1bAnimation);
    box_points.setFrame(1);
    comptroller.schedule(2000, "turn_off_ui_glow1", 0);

   }

   $vortexes_collected += 1;

   if ($vortexes_collected == 20 & $trophy_toggle_off_mount2 != 1) {
    $root_trophy_identfier = "mount2";
    win_this_trophy();
    $trophy_toggle_off_mount2 = 1;
   }
   $bonus_portal_active1 = 0;
  }
 }
}

function bonus_portal2::bonus_portal_spawn( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   $bonus_portal_active2 = 1;
   bonus_portal2.setAnimation(vortex_in4Animation);
  }
 }
}

function bonus_portal2::bonus_portal_repeat( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {
  if ($left_the_level_space != 1) {
   $a_bonus_portal_is_active = 1;
   bonus_portal2.setAnimation(vortex4Animation);
   echo("bonus portal_2");
   $animate_bonus_once = 0;
   $bonus_portal_active2 = 1;
   if ($activate_continuing_tutorial == 1 & $hint_bonus2_disabled != 1) {
    hint_bonus2.setBlendAlpha(1);
    $hint_bonus2_disabled = 1;
   }
  }
 }
}

function bonus_portal2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  if ($bonus_portal_active2 == 1) {
   if ($left_the_level_space != 1) {
    if ($mute_soundfx != 1) {
     alxPlay(voop);
    }
    bonus_portal2.setAnimation(click_boomAnimation);
    $points_amount += 10;
    points_number.text = $points_amount;
    point_up_empty_space3.setPositionX($points_number_x);
    point_up_empty_space3.setPositionY($points_number_y);
    point_up_empty_space3.setAnimation(fx_point_up1bAnimation);
    box_points.setFrame(1);
    comptroller.schedule(2000, "turn_off_ui_glow1", 0);
    if ($activate_continuing_tutorial == 1) {
     hint_bonus2.setBlendAlpha(0);
    }

   }

   $vortexes_collected += 1;

   if ($vortexes_collected == 20 & $trophy_toggle_off_mount2 != 1) {
    $root_trophy_identfier = "mount2";
    win_this_trophy();
    $trophy_toggle_off_mount2 = 1;
   }
   $bonus_portal_active2 = 0;
  }
 }
}

function bonus_portal3::bonus_portal_spawn( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   $bonus_portal_active3 = 1;
   bonus_portal3.setAnimation(vortex_in4Animation);
  }
 }
}

function bonus_portal3::bonus_portal_repeat( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {
  if ($left_the_level_space != 1) {
   bonus_portal3.setAnimation(vortex4Animation);
   echo("bonus portal_3");
   $animate_bonus_once = 0;
   $bonus_portal_active3 = 1;
  }
 }
}

function bonus_portal3::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  if ($bonus_portal_active3 == 1) {
   if ($left_the_level_space != 1) {
    if ($mute_soundfx != 1) {
     alxPlay(voop);
    }
    bonus_portal3.setAnimation(click_boomAnimation);
    $points_amount += 10;
    points_number.text = $points_amount;
    point_up_empty_space3.setPositionX($points_number_x);
    point_up_empty_space3.setPositionY($points_number_y);
    point_up_empty_space3.setAnimation(fx_point_up1bAnimation);
    box_points.setFrame(1);
    comptroller.schedule(2000, "turn_off_ui_glow1", 0);

   }

   $vortexes_collected += 1;

   if ($vortexes_collected == 20 & $trophy_toggle_off_mount2 != 1) {
    $root_trophy_identfier = "mount2";
    win_this_trophy();
    $trophy_toggle_off_mount2 = 1;
   }
   $bonus_portal_active3 = 0;
  }
 }
}

function bonus_portal4::bonus_portal_spawn( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {
  if ($left_the_level_space != 1) {
   $bonus_portal_active4 = 1;
   bonus_portal4.setAnimation(vortex_in4Animation);
  }
 }
}

function bonus_portal4::bonus_portal_repeat( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {
  if ($left_the_level_space != 1) {
   bonus_portal4.setAnimation(vortex4Animation);
   echo("bonus portal_4");
   $animate_bonus_once = 0;
   $bonus_portal_active4 = 1;
  }
 }
}

function bonus_portal4::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  if ($bonus_portal_active4 == 1) {
   if ($left_the_level_space != 1) {
    if ($mute_soundfx != 1) {
     alxPlay(voop);
    }
    bonus_portal4.setAnimation(click_boomAnimation);
    $points_amount += 10;
    points_number.text = $points_amount;
    point_up_empty_space3.setPositionX($points_number_x);
    point_up_empty_space3.setPositionY($points_number_y);
    point_up_empty_space3.setAnimation(fx_point_up1bAnimation);
    box_points.setFrame(1);
    comptroller.schedule(2000, "turn_off_ui_glow1", 0);

   }

   $vortexes_collected += 1;

   if ($vortexes_collected == 20 & $trophy_toggle_off_mount2 != 1) {
    $root_trophy_identfier = "mount2";
    win_this_trophy();
    $trophy_toggle_off_mount2 = 1;
   }
   $bonus_portal_active4 = 0;
  }
 }
}

function bonus_portal1::bonus_extra_portal_end_all() {
 $bonus_portal_active1 = 0;
 $bonus_portal_active2 = 0;
 $bonus_portal_active3 = 0;
 $bonus_portal_active4 = 0;

 bonus_portal1.setAnimation(empty_char_spaceAnimation);
 bonus_portal2.setAnimation(empty_char_spaceAnimation);
 bonus_portal3.setAnimation(empty_char_spaceAnimation);
 bonus_portal4.setAnimation(empty_char_spaceAnimation);
 $animate_bonus_once = 1;
}

function flying_coin::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  echo("$flying_coin_active $flying_coin_active $flying_coin_active = "
   @ $flying_coin_active);
  if ($flying_coin_active == 1) {
   if ($mute_soundfx != 1) {
    alxPlay(coin_collect_sound);
   }
   $flying_coins_collected += 1;
   if ($flying_coins_collected == 15 & $trophy_toggle_off_button2 != 1) {
    $root_trophy_identfier = "button2";
    win_this_trophy();
    $trophy_toggle_off_button2 = 1;
   }

   flying_coin.setAnimation(click_boomAnimation);
   point_up_empty_space2.setPositionX($score_number_x);
   point_up_empty_space2.setPositionY($score_number_y);
   point_up_empty_space2.setAnimation(fx_point_up2bAnimation);
   $coinage += 20; % score_number_update = $coinage;
   score_number.text = % score_number_update;
   $flying_coin_active = 0;

   box_score.setFrame(1);
   comptroller.schedule(2000, "turn_off_ui_glow2", 0);
  }

  if ($flying_coin_active == 0) {
   //repeat invisible just incase
   //flying_coin.setAnimation(empty_char_spaceAnimation);
  }
 }
}

function flying_coin2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  echo("$flying_coin_active $flying_coin_active $flying_coin_active = "
   @ $flying_coin_active);
  if ($flying_coin2_active == 1) {
   if ($mute_soundfx != 1) {
    alxPlay(coin_collect_sound);
   }
   $flying_coins_collected += 1;
   if ($flying_coins_collected == 15 & $trophy_toggle_off_button2 != 1) {
    $root_trophy_identfier = "button2";
    win_this_trophy();
    $trophy_toggle_off_button2 = 1;
   }

   flying_coin2.setAnimation(click_boomAnimation);
   point_up_empty_space2.setPositionX($score_number_x);
   point_up_empty_space2.setPositionY($score_number_y);
   point_up_empty_space2.setAnimation(fx_point_up2bAnimation);
   $coinage += 20; % score_number_update = $coinage;
   score_number.text = % score_number_update;
   $flying_coin2_active = 0;

   box_score.setFrame(1);
   comptroller.schedule(2000, "turn_off_ui_glow2", 0);
  }

  if ($flying_coin_active == 0) {
   //repeat invisible just incase
   //flying_coin.setAnimation(empty_char_spaceAnimation);
  }
 }
}

function establish_all_awards_won() {
 /*
 	if($_trophy_dollar_activated == 1)
 	{
 		trophy_dollar.BlendColor = "1 1 1 1";
 	}
 */
}

function trophies::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 $base_name = % this.name;
 echo($base_name); % root_trophy_activated = $base_name @ "_activated";
 echo( % root_trophy_activated);
 $find_trophy_activation_status = $_[ % root_trophy_activated];
 echo($find_trophy_activation_status);
 if ($find_trophy_activation_status != 1) { % this.BlendColor = "1 1 1 0.5";
  $identify_award_base = % this.name;
  $identify_concat_name_base = % this.name @ "_name";
  $identify_concat_desc_base = % this.name @ "_description";
  $concat_award_name = $_[$identify_concat_name_base];
  $concat_award_description = $_[$identify_concat_desc_base];
  award_left_text.text = $concat_award_name;
  award_right_text.text = $concat_award_description;
 }
 if ($find_trophy_activation_status == 1) { % this.BlendColor = "1 1 1 1";
  $identify_award_base = % this.name;
  $identify_concat_name_base = % this.name @ "_name";
  $identify_concat_desc_base = % this.name @ "_description";
  $concat_award_name = $_[$identify_concat_name_base];
  $concat_award_description = $_[$identify_concat_desc_base];
  award_left_text.text = $concat_award_name;
  award_right_text.text = $concat_award_description;
 }
}

function trophy_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_om_awards_button_because_tut_ext < 1) { % this.setBlendAlpha(0);
  }
 }
}

function trophy_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_om_awards_button_because_tut_ext < 1) { % this.setBlendAlpha(0);
 }
}

function trophy_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_om_awards_button_because_tut_ext != 1) { % this.setBlendAlpha(1);
 }
}

function trophy_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 echo("trophy button moused down");
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_off_om_awards_button_because_tut_ext < 1) {
   $screen_position_x = -100;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  }
  if ($toggle_off_om_awards_button_because_tut_ext == 2) {
   $screen_position_x = -100;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   //start_tut_ext_segment4();
  }
  /* NEED TROPHY REFILLERS VIA SAVE FILE HERE */
  //activate won trophies
  if ($_trophy_trophy1_activated == 1) {
   trophy_trophy1.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy2_activated == 1) {
   trophy_trophy2.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy3_activated == 1) {
   trophy_trophy3.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy4_activated == 1) {
   trophy_trophy4.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy5_activated == 1) {
   trophy_trophy5.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy6_activated == 1) {
   trophy_trophy6.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy7_activated == 1) {
   trophy_trophy7.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy8_activated == 1) {
   trophy_trophy8.BlendColor = "1 1 1 1";
  }
  if ($_trophy_trophy9_activated == 1) {
   trophy_trophy9.BlendColor = "1 1 1 1";
  }
  //activate won plaques
  if ($_trophy_plaque1_activated == 1) {
   trophy_plaque1.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque2_activated == 1) {
   trophy_plaque2.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque3_activated == 1) {
   trophy_plaque3.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque4_activated == 1) {
   trophy_plaque4.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque5_activated == 1) {
   trophy_plaque5.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque6_activated == 1) {
   trophy_plaque6.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque7_activated == 1) {
   trophy_plaque7.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque8_activated == 1) {
   trophy_plaque8.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque9_activated == 1) {
   trophy_plaque9.BlendColor = "1 1 1 1";
  }
  if ($_trophy_plaque10_activated == 1) {
   trophy_plaque10.BlendColor = "1 1 1 1";
  }
  //activate won ribbons
  if ($_trophy_ribbon1_activated == 1) {
   trophy_ribbon1.BlendColor = "1 1 1 1";
  }
  if ($_trophy_ribbon2_activated == 1) {
   trophy_ribbon2.BlendColor = "1 1 1 1";
  }
  if ($_trophy_ribbon3_activated == 1) {
   trophy_ribbon3.BlendColor = "1 1 1 1";
  }
  if ($_trophy_ribbon4_activated == 1) {
   trophy_ribbon4.BlendColor = "1 1 1 1";
  }
  if ($_trophy_ribbon5_activated == 1) {
   trophy_ribbon5.BlendColor = "1 1 1 1";
  }
  if ($_trophy_ribbon6_activated == 1) {
   trophy_ribbon6.BlendColor = "1 1 1 1";
  }
  //activate won button
  if ($_trophy_button1_activated == 1) {
   trophy_button1.BlendColor = "1 1 1 1";
  }
  if ($_trophy_button2_activated == 1) {
   trophy_button2.BlendColor = "1 1 1 1";
  }
  if ($_trophy_button3_activated == 1) {
   trophy_button3.BlendColor = "1 1 1 1";
  }
  if ($_trophy_button4_activated == 1) {
   trophy_button4.BlendColor = "1 1 1 1";
  }
  if ($_trophy_button5_activated == 1) {
   trophy_button5.BlendColor = "1 1 1 1";
  }
  if ($_trophy_button6_activated == 1) {
   trophy_button6.BlendColor = "1 1 1 1";
  }
  //activate won mount
  if ($_trophy_mount1_activated == 1) {
   trophy_mount1.BlendColor = "1 1 1 1";
  }
  if ($_trophy_mount2_activated == 1) {
   trophy_mount2.BlendColor = "1 1 1 1";
  }
  if ($_trophy_mount3_activated == 1) {
   trophy_mount3.BlendColor = "1 1 1 1";
  }
  if ($_trophy_mount4_activated == 1) {
   trophy_mount4.BlendColor = "1 1 1 1";
  }
  //activate won mount
  if ($_trophy_dollar_activated == 1) {
   trophy_dollar.BlendColor = "1 1 1 1";
  }

  //BlendColor = "0 0 0 0.5";

  //Disable any not-yet-won awards
  if ($_trophy_trophy1_activated == 0) {
   trophy_trophy1.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy2_activated == 0) {
   trophy_trophy2.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy3_activated == 0) {
   trophy_trophy3.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy4_activated == 0) {
   trophy_trophy4.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy5_activated == 0) {
   trophy_trophy5.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy6_activated == 0) {
   trophy_trophy6.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy7_activated == 0) {
   trophy_trophy7.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy8_activated == 0) {
   trophy_trophy8.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_trophy9_activated == 0) {
   trophy_trophy9.BlendColor = "0 0 0 0.5";
  }
  //deactivate won plaques
  if ($_trophy_plaque1_activated == 0) {
   trophy_plaque1.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque2_activated == 0) {
   trophy_plaque2.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque3_activated == 0) {
   trophy_plaque3.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque4_activated == 0) {
   trophy_plaque4.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque5_activated == 0) {
   trophy_plaque5.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque6_activated == 0) {
   trophy_plaque6.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque7_activated == 0) {
   trophy_plaque7.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque8_activated == 0) {
   trophy_plaque8.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque9_activated == 0) {
   trophy_plaque9.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_plaque10_activated == 0) {
   trophy_plaque10.BlendColor = "0 0 0 0.5";
  }
  //deactivate won ribbons
  if ($_trophy_ribbon1_activated == 0) {
   trophy_ribbon1.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_ribbon2_activated == 0) {
   trophy_ribbon2.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_ribbon3_activated == 0) {
   trophy_ribbon3.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_ribbon4_activated == 0) {
   trophy_ribbon4.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_ribbon5_activated == 0) {
   trophy_ribbon5.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_ribbon6_activated == 0) {
   trophy_ribbon6.BlendColor = "0 0 0 0.5";
  }
  //deactivate won button
  if ($_trophy_button1_activated == 0) {
   trophy_button1.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_button2_activated == 0) {
   trophy_button2.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_button3_activated == 0) {
   trophy_button3.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_button4_activated == 0) {
   trophy_button4.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_button5_activated == 0) {
   trophy_button5.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_button6_activated == 0) {
   trophy_button6.BlendColor = "0 0 0 0.5";
  }
  //deactivate won mount
  if ($_trophy_mount1_activated == 0) {
   trophy_mount1.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_mount2_activated == 0) {
   trophy_mount2.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_mount3_activated == 0) {
   trophy_mount3.BlendColor = "0 0 0 0.5";
  }
  if ($_trophy_mount4_activated == 0) {
   trophy_mount4.BlendColor = "0 0 0 0.5";
  }
  //deactivate won mount
  if ($_trophy_dollar_activated == 0) {
   trophy_dollar.BlendColor = "0 0 0 0.5";
  }
 }
}

function the_blue_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $blue_alpha_level = % this.getBlendAlpha();
  the_blue_button.blue_fade_alpha();
 }
}

function the_blue_button::blue_fade_alpha( % this) {

 if ($blue_alpha_level >= 0) {
  $blue_alpha_level -= 0.1;
  the_blue_button.setBlendAlpha($blue_alpha_level);
  the_blue_button.schedule(100, "blue_fade_alpha", 0);
 }
}

function trophies::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $base_name = % this.name;
 echo($base_name); % root_trophy_activated = $base_name @ "_activated";
 echo( % root_trophy_activated);
 $find_trophy_activation_status = $_[ % root_trophy_activated];
 echo($find_trophy_activation_status);
 if ($find_trophy_activation_status != 1) { % this.BlendColor = "0 0 0 0.5";
  award_left_text.text = " ";
  award_right_text.text = " ";
 }

 if ($find_trophy_activation_status == 1) { % this.BlendColor = "1 1 1 1";
  award_left_text.text = " ";
  award_right_text.text = " ";
 }
 //if(%this.collected == 1)
 //{
 //%this.BlendColor = "1 1 1 1";	
 //}
}

function clean_up_level_transitions() {
 //This fixes black shop screen errors
 echo("function clean_up_level_transitions() called");
 echo("$toggle_off_go_to_specific_level is at "
  @ $toggle_off_go_to_specific_level);
 //note 12-27-2013 locate here
 if ($toggle_off_go_to_specific_level == 1) {
  /* on normal, this would cause map infinity */
  /* on not-normal, this would go through*/
  $toggle_off_go_to_specific_level = 0;
  /* end */
  $clean_up_in_progress_so_skip_the_map = 1;
  go_to_specific_level();
  /* on normal, this would go through */
  /* on not-normal black-screen */
  //$toggle_off_go_to_specific_level = 0;	
  /* end */
  //In this special circumstance, if the max recorded world is equal to the world youre going into, make the level the max level you got to, to. As youre clearly here from mapsel
  //For the first time only and this would happen
  //And!!! DO NOT CHANGE THE ORDER OF THESE EVENTS! OR ELSE YOU WILL GET INFINITE MAP REPEATING ERROR, eg click mapsel, go to storyboard, continue, back to map, repeats
  if ($world_numeral == $maximum_world_player_got_to) {
   $round_numeral = $maximum_level_player_got_to;
   level_number.text = ""
   @ $round_numeral;
   if ($round_numeral > 10) {
    level_number.text = 10;
   }
   echo("At clean_up_level_transitions, level_number.text = "
    @ $round_numeral);

  }

 }
}

function pre_calculate_round_max_times() {
 //note 30 is the coins you get per customer on gold, -10 is one flying coin pass
 $calculate_distribution = ($points_you_need - 10) / 30; % individual_customer_time = $game_clock_limit / 2;
 $calculate_what_sold_out_means = $calculate_distribution * % individual_customer_time;
}

function calculate_appetizer_amounts() {
 echo($total_appetizers_collected);
 $collected_appetizers1 = $appetizer1_purchased1 + $appetizer1_purchased2 + $appetizer1_purchased3 + $appetizer1_purchased4 + $appetizer1_purchased5 + $appetizer1_purchased6 + $appetizer1_purchased7 + $appetizer1_purchased8 + $appetizer1_purchased9 + $appetizer1_purchased10;
 $collected_appetizers2 = $appetizer2_purchased1 + $appetizer2_purchased2 + $appetizer2_purchased3 + $appetizer2_purchased4 + $appetizer2_purchased5 + $appetizer2_purchased6 + $appetizer2_purchased7 + $appetizer2_purchased8 + $appetizer2_purchased9 + $appetizer2_purchased10;
 $total_appetizers_collected = $collected_appetizers1 + $collected_appetizers2;
}

/* SPECIAL CHARACTER CONDITIONS */

function check_for_special_characters() {
 echo("function check_for_special_characters()");
 $prechosen_world_for_special_char = $world_numeral;
 //$current_level = 1;
 //$round_numeral = 1;
 //$world_numeral = 1;

 /* RESET SPECIAL CHARACTERS IF NOT A SPECIAL LEVEL */
 if ($world_numeral == 1) {
  $special_dialog_identifier = 0;
  $spawn_special_character = 0;
  $prechosen_seat_num_for_special_char = 99;
 }
 if ($world_numeral == 2) {
  $special_dialog_identifier = 0;
  $spawn_special_character = 0;
  $prechosen_seat_num_for_special_char = 99;
 }
 if ($world_numeral == 5) {
  $special_dialog_identifier = 0;
  $spawn_special_character = 0;
  $prechosen_seat_num_for_special_char = 99;
 }
 if ($world_numeral == 6) {
  $special_dialog_identifier = 0;
  $spawn_special_character = 0;
  $prechosen_seat_num_for_special_char = 99;
 }
 if ($world_numeral == 7) {
  $special_dialog_identifier = 0;
  $spawn_special_character = 0;
  $prechosen_seat_num_for_special_char = 99;
 }

 /* CELEBRITY */
 if ($world_numeral == 4) {
  //this is used to identify which dynamic speech segment in game_text is used when you fail
  $special_dialog_identifier = 1;
  $special_char_world = $world_numeral;
  $special_char_level = $current_level;
  //activate level and table of said world spec char spawns in
  if ($current_level == 1 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 2 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 3 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 4 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 5 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 0;
   //which char should it be?
   //$prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 6 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 7 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 8 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 9 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 10 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }

 }

 /* PRESS CORPS */
 //activate world spec char spawns in
 if ($world_numeral == 3) {
  //this is used to identify which dynamic speech segment in game_text is used when you fail
  $special_dialog_identifier = 2;
  $special_char_world = $world_numeral;
  $special_char_level = $current_level;
  //activate level and table of said world spec char spawns in
  if ($current_level == 1 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 2 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 3 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 4 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 5 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 0;
   //which char should it be?
   //$prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 6 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 7 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 8 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 9 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 10 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }

 }

 /* FOOD INSPECTOR */

 //activate world spec char spawns in
 if ($world_numeral == 9) {
  //this is used to identify which dynamic speech segment in game_text is used when you fail
  $special_dialog_identifier = 3;
  $special_char_world = $world_numeral;
  $special_char_level = $current_level;
  //activate level and table of said world spec char spawns in
  if ($current_level == 1 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 2 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 3 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 4 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 5 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 0;
   //which char should it be?
   //$prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 6 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 7 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 8 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 9 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 10 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }

 }

 /* FOOD CRITIC */

 //activate world spec char spawns in

 if ($world_numeral == 8) {
  //this is used to identify which dynamic speech segment in game_text is used when you fail
  $special_dialog_identifier = 4;
  $special_char_world = $world_numeral;
  $special_char_level = $current_level;
  //activate level and table of said world spec char spawns in
  /* if current_level == 1 and $special_char_already_used == 1 */
  if ($current_level == 1 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 2 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 3 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 4 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 5 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 0;
   //which char should it be?
   //$prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 6 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 7 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 8 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 9 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 10 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }

 }

 /* MAYOR */

 //activate world spec char spawns in
 if ($world_numeral == 10) {
  //this is used to identify which dynamic speech segment in game_text is used when you fail
  $special_dialog_identifier = 5;
  $special_char_world = $world_numeral;
  $special_char_level = $current_level;
  //activate level and table of said world spec char spawns in
  if ($current_level == 1 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 2 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 3 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 4 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 5 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 0;
   //which char should it be?
   //$prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 6 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 7 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 2;
  }
  if ($current_level == 8 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }
  if ($current_level == 9 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 4;
  }
  if ($current_level == 10 & $special_char_already_used != 1) {
   //activate special char clause for char_button spawner and game_clock if it should be
   $spawn_special_character = 1;
   //which char should it be?
   $prechosen_seat_num_for_special_char = 3;
  }

 }

 /* POSSIBLE VINCE VANDERSIN */

}


/* SPECIAL ENDING OF LEVEL EARLY */
// NOTE! FUNCTIONS TO CAUSE CHAR FAILS ARE IN COIN_TIP 	

function game_fail_countdown() {
 $end_the_clock = 1;
 $game_has_started_for_clock = 0;
 alxStopAll();
 if ($mute_soundfx != 1) {
  alxPlay(womp_womp);
 }
 echo("+++++++++++++++++++++++++calling game fail countdown");

 $game_fail_number_preset = 9;
 game_fail_number.setFrame($game_fail_number_preset);
 game_fail_number.schedule(1000, "minus_number", 0);

 game_fail_number.schedule(2000, "minus_number", 0);
 game_fail_number.schedule(3000, "minus_number", 0);
 //game_fail_number.schedule(3100, "reset_level", 0);
 game_fail_number.schedule(4000, "minus_number", 0);
 game_fail_number.schedule(5000, "minus_number", 0);
 game_fail_number.schedule(6000, "minus_number", 0);
 game_fail_number.schedule(7000, "minus_number", 0);
 game_fail_number.schedule(8000, "minus_number", 0);
 //game_fail_number.schedule(9000, "minus_number", 0);	
 game_fail_number.schedule(8100, "reload_level", 0);
}

function game_fail_number::minus_number() {
 $game_fail_number_preset -= 1;
 game_fail_number.setFrame($game_fail_number_preset);

}

function game_fail_number::reload_level() {

 //edit 06-12-2014 clearing tables 
 sched_cancel_cooks();
 sched_cancel_chars_and_waiters();
 clear_out_dirty_cups_for_good();
 //edit 01-27-2015 fx stopping error -two parts-
 //edit 02-03-2015 disabled and it fixed FX errors, hope errors
 if ($special_char_already_used != 1) {
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 2 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 2 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 2 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");

  //sched_cancel_all();
 }
 hide_any_coin_flyers();
 release_all_special_char_toggles();
 echo("testing 1");
 purge_any_current_ingame_stuff();
 purge_any_remnants();
 $special_char_already_used = 0;
 check_for_special_characters();
 $disable_pause_for_black_out = 0;
 button_pause.setBlendAlpha(1);
 button_pause2.setBlendAlpha(1);
 echo("***RESTARTING THE LEVEL DUE TO FAILURE***");
 game_fail_text.setBlendAlpha(0);
 game_fail_number.setBlendAlpha(0);
 $game_clock_number = 0;
 //write_to_save_file();
 //For sodajerks and others to stop schedules
 //$world_ended = 1;
 black_stretch.BlendColor = "0 0 0 0";
 black_stretch.setPositionX(9999);
 $round_restart_switch += 1;
 //Kill all char_attributes to release deteleport locks, and then deteleport them all
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;
 //Reset the score
 $coinage = $special_record_coins_at_round_start;
 score_number.text = $coinage;
 $points_amount = $special_record_points_at_round_start;
 points_number.text = $points_amount;
 alxStopAll();
 if ($toggle_mute_music != 1) {
  alxPlay($default_audio);
 }
 //$toggle_mute_music = 1;
 //$toggle_from_mute_music_mouseUp = 1;
 pre_calculate_round_max_times();
 $initialize_bonus_portals_to_appear_random = 1;
 $game_has_started_for_clock = 1;
 $toggle_initial_spawner_via_clock = 0;
 //$world_ended = 0;
 $end_the_clock = 0;
 echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ D");
 $left_the_level_space = 0;
 //sceneWindow2D.setCurrentCameraPosition( "100 0 100 75" ); 

 empty_coin1.reset_coin_tips();
 empty_coin2.reset_coin_tips();
 empty_coin3.reset_coin_tips();
 empty_coin4.reset_coin_tips();

 empty_char_space1.schedule(0, "delete_old_data", 0);
 empty_char_space1.is_angry = 1;
 empty_char_space1.schedule(0, "deteleport", 0);
 empty_char_space2.schedule(0, "delete_old_data", 0);
 empty_char_space2.is_angry = 1;
 empty_char_space2.schedule(0, "deteleport", 0);
 empty_char_space3.schedule(0, "delete_old_data", 0);
 empty_char_space3.is_angry = 1;
 empty_char_space3.schedule(0, "deteleport", 0);
 empty_char_space4.schedule(0, "delete_old_data", 0);
 empty_char_space4.is_angry = 1;
 empty_char_space4.schedule(0, "deteleport", 0);

 //release single-play toggles for feeding special characters during a round
 release_all_special_char_toggles();
 echo("testing 2");
 purge_any_current_ingame_stuff();
 purge_any_remnants();
 //rejigger_the_hearts_schedules();

 //$end_the_clock = 0;
 //$game_has_started_for_clock = 1;
 //there is an alx override for music and sound	
 //alxPlay($default_audio);
 //edit 01-07-2015 up the appetizer amount because you suck
 $appetizer1_amount[$world_numeral] += 4;
 $appetizer2_amount[$world_numeral] += 4;
 appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 appetizer2_amt_ingame.text = $appetizer2_amount[$world_numeral];
}

function release_all_special_char_toggles() {
 //edit 01-06-2015 adding $disable_special_char release for new errors
 $disable_special_char = 0;
 $toggle_off_special_char_for_round = 0;
 $toggle_off_model5_via_drink_vers1 = 0;
 $toggle_off_model5_via_drink_vers2 = 0;
 $toggle_off_model5_via_wait = 0;
}
//game_fail_number.setBlendAlpha(1);
//game_fail_countdown();

function goto_levsel::process_in_list_of_star_system_levels() {
 /*
 //tester
 //note getSubStr(string, (number + 1) * 2), 1)
 		setWord(string, (number + 1), input_number)

 $test_indie_char = getSubStr($star_system_array, 3, 1);
 echo($test_indie_char);

 $test_star_string = "1234567890000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
 $star_system_array = "1 2 3 4 5 6 7 8 9 0";

 $star_system_array = setWord($star_system_array, 4, "7"); 
 echo($star_system_array);
 */
 //$star_system_array = "0 0 0 0 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";

 //get dynamic number for reading in/out of array
 //now in inventory!
 //adjust for starting at zero in array
 echo("-----process_in_list_of_star_system_levels-------------------------------------------");
 echo("$input_ss_level_num = "
  @ $input_ss_level_num);
 echo("-------------------------------------------------------------------------------------");
 $zero_start_ss_level_data = (($input_ss_level_num * 2) - 2);
 //find additional base 10 world worth
 //edit 02-17-2014 adjusting to better world numeral identifier
 //$twenty_times_start_ss_world_data = (($world_numeral * 20) - 20);
 $twenty_times_start_ss_world_data = (($the_current_world * 20) - 20);
 //adjust for space-delimited listing in array
 $space_ss_level_data = $zero_start_ss_level_data + $twenty_times_start_ss_world_data;

 //Assign each world an array weight via an algorithm
 //Pattern Below
 //0, 20, 40, 60, 80, 100
 //		    =
 //1   2   3   4   5   6
 //$step_back_a_numeral_on_base_pattern = $world_numeral - 1;
 //get dynamic world number for reading in/out array and weigh it at base 20
 //$ss_world_number = $step_back_a_numeral_on_base_pattern * 2;

 //find exact number you want in array
 //$exact_ss_number = $ss_world_number + $space_ss_level_data;
 $exact_ss_number = $space_ss_level_data;
 //read out what star sys value is at that position for animation record
 $read_out_ss_number = getSubStr($star_system_array, $exact_ss_number, 1);
 echo("START STAR SYS ARRAY****************88888888888888******************888888888888888888*********************888********************88888888888**********************88888888*88888888888888*");

 echo("$read_out_ss_number"
  @ $read_out_ss_number);

 //calculate animation based on number
 $ss_animation_name = ("star_sys"
  @ $read_out_ss_number @ "bAnimation");

 $levsel_stars_name = "levsel_stars"
 @ $input_ss_level_num;
 $levsel_stars_name.setBlendAlpha(1);
 //if($the_current_world >= $maximum_world_player_got_to)
 //{
 $levsel_stars_name.setAnimation($ss_animation_name);
 //}
 //edit 02-17-2014 this is not acceptable, as it needs to read previous worlds data, not just make all them gold
 //if($the_current_world < $maximum_world_player_got_to)
 //{
 //$levsel_stars_name.setAnimation(star_sys3bAnimation);
 //}
 echo("STAR SYS ARRAY = "
  @ $star_system_array);
 echo("^^^$declare_level_via_space_delimited_array = "
  @ $declare_level_via_space_delimited_array);
 echo("PROCESSING STAR SYS AS $input_ss_level_num ="
  @ $input_ss_level_num @ " $zero_start_ss_level_data ="
  @ $zero_start_ss_level_data @ " $space_ss_level_data ="
  @ $space_ss_level_data @ " $ss_world_number ="
  @ $ss_world_number);
 echo("AND $world_numeral ="
  @ $world_numeral @ " $exact_ss_number ="
  @ $exact_ss_number @ " $read_out_ss_number ="
  @ $read_out_ss_number);
 echo("END STAR SYS ARRAY****************88888888888888******************888888888888888888*********************888********************88888888888**********************88888888*88888888888888*");

 $input_ss_level_num += 1;

}

function goto_levsel::reset_list_of_star_system_levels() {
 /* DON'T MESS WITH ME!! I MAKE IT SO THE NEXT ROUND OF SAME WORLD DOESNT START AT 11!!! */
 $input_ss_level_num = 1;
 echo("-----reset_list_of_star_system_levels-------------------------------------------");
 echo("$input_ss_level_num = "
  @ $input_ss_level_num);
 echo("-------------------------------------------------------------------------------------");
 echo("where 888 originaly stemmed from");
}

function reset_alpha_of_star_system_levels() {
 //alpha of all the level star animations upon mousedown of goto_levsel
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
}

function reset_all_new_ss_levels_after_saving_prior() {
 //hopefully you saved these star system states before next world! Because I'm purging them!
 levsel_stars1.setAnimation("star_sys0bAnimation");
 levsel_stars2.setAnimation("star_sys0bAnimation");
 levsel_stars3.setAnimation("star_sys0bAnimation");
 levsel_stars4.setAnimation("star_sys0bAnimation");
 levsel_stars5.setAnimation("star_sys0bAnimation");
 levsel_stars6.setAnimation("star_sys0bAnimation");
 levsel_stars7.setAnimation("star_sys0bAnimation");
 levsel_stars8.setAnimation("star_sys0bAnimation");
 levsel_stars9.setAnimation("star_sys0bAnimation");
 levsel_stars10.setAnimation("star_sys0bAnimation");
}

function declare_star_sys_data_for_level() {
 //check on how many times this function is called
 $declare_star_sys_data_for_level_use_counter += 1;
 echo("Detect declaration of ss data at "
  @ $declare_star_sys_data_for_level_use_counter);
 //edit 03-01-2014 THE STAR SYS ERROR IS HERE, CURRENT LEVEL SHOULD BE 1 LESS (IT GETS MINUSED LATER FOR ZERO STARTER)
 $detect_level = $current_level;
 //find world, so that if 1, levels are 1-10, if 2, levels are 11-20 etc
 $ten_from_twenty_start_ss_world_data = (($world_numeral * 10) - 10);
 //note! making this less than 1 will cause array to go to -1, which will crash torque
 $declare_level_via_space_delimited_array = ($detect_level - 1) + $ten_from_twenty_start_ss_world_data;

 echo("Detect level at "
  @ $detect_level);
 echo("Check 1/3 Via declare_star_sys_data_for_level, $current_level = "
  @ $current_level @ " $declare_level_via_space_delimited_array ="
  @ $declare_level_via_space_delimited_array @ ", $star_sys_medal_won = "
  @ $star_sys_medal_won);
 echo("Check 2/3 Via declare_star_sys_data_for_level, $current_level = "
  @ $current_level @ " $declare_level_via_space_delimited_array ="
  @ $declare_level_via_space_delimited_array @ ", $star_sys_medal_won = "
  @ $star_sys_medal_won);
 echo("Check 3/3 Via declare_star_sys_data_for_level, $current_level = "
  @ $current_level @ " $declare_level_via_space_delimited_array ="
  @ $declare_level_via_space_delimited_array @ ", $star_sys_medal_won = "
  @ $star_sys_medal_won);
 //edit 02-16-2014 if past level 11, it shouldnt record because its over the 10 level limit and will bleed into next world record
 if ($current_level <= 10) {
  /* THIS IS WHERE THE STAR SYSTEM ARRAY GETS WRITTEN */
  echo("-----declare_star_sys_data_for_level before-------------------------------------------");
  echo("$star_system_array = "
   @ $star_system_array);
  echo("-------------------------------------------------------------------------------------");
  $star_system_array = setWord($star_system_array, $declare_level_via_space_delimited_array, $star_sys_medal_won);
  echo("-----declare_star_sys_data_for_level after-------------------------------------------");
  echo("$star_system_array = "
   @ $star_system_array);
  echo("-------------------------------------------------------------------------------------");
 }
 echo($star_system_array);

 //ISSUE
 //NUMBERS ARE SETTING BUT APPEAR TO BE 1 LEVEL OFF IN WORLD 2 IN RECORDING, CHECK WORLD 1 AS WELL POST 4, WORLD 1 TO WORLD 2 TO SEE THE DIFFERENCE THAT EVOKED LEVELS MAKE IN THIS
 //POST 4 WORKS, AT WORLD 2 4 WOULD BE BLANK, 1-2-3-5 WOULD BE GOLD EVEN THOUGH 5 WASNT BEATEN LAST WORLD, ASSUMED REPEAT OF DATA ABOVE FROM THERE...SIGH
 //CONFIRMED! ARRAY GETS KNOWCKED BACK TO -2, ALL NUMBERS PUSHED BACK 1 CAUSING MISLINK, REAFFIRMATION OF GOLDS ON WORLD 2 IS A PROPER RESET ISSUE. PROPER RESET MAY DELETE ALL"
 /* fixed above, gold works perfect at cheat as well, world 2 does not work. itll put 1,2, and whatever at gold */
 /* 01-13-2014 Reproes are based on gold first vs cheat clicks, and in what order, causing varying reproes. next repro was world 2: 1 gold 3 gold, nothing else at gold" */

}

function debug_mode_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $debug_mode_on = 1;
 }
}

//set waiter position based on obstacles in each world
//set all other exceptions via this because it works so well
function set_waiter_node_position() {
 drink_out1.active = 0;
 drink_out2.active = 0;
 drink_out3.active = 0;
 drink_out4.active = 0;
 //and Callie and Podium as well!

 if ($start_button_was_pressed == 1) {

  echo("IF GRAY ERROR, IT'S BECAUSE IT DOESN'T SOMEHOW EXIST IN MEMORY, CHECK DYNAMICS, LOAD-UNLOAD, BECAUSE IT'S A BASIC OBJECT");
  echo("set_waiter_node_position @ world# "
   @ $world_numeral);

  //world 1
  if ($world_numeral == 1) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(0);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(125.143);
   callie.setPositionY(10.221);
  }

  //world 2
  if ($world_numeral == 2) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(1);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(125.143);
   callie.setPositionY(10.221);
  }
  //world 3
  if ($world_numeral == 3) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(106);
   way_point1.setPositionY(21);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(132);
   podium.setPositionY(5);
   podium.setFrame(0);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(133);
   callie.setPositionY(-2.6);
  }
  //world 4
  if ($world_numeral == 4) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(106);
   way_point1.setPositionY(21);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(134.5);
   podium.setPositionY(-2);
   podium.setFrame(0);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(135.5);
   callie.setPositionY(-9.5);
  }

  //world 5
  if ($world_numeral == 5) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(128);
   podium.setPositionY(23);
   podium.setFrame(0);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(129);
   callie.setPositionY(15.5);
  }

  //world 6
  if ($world_numeral == 6) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(2);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(141);
   callie.setPositionY(1.8);
  }
  //exception for FUCKING TRAIN
  if ($world_numeral == 7) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100);
   way_point1.setPositionX(102);
   way_point1.setPositionY(9);
   fx_special_seat.setImageMap(custom_train_seatImageMap);
   empty_char_space1.setLayer(7);
   thought1.setLayer(9);
   fx_special_seat.setLayer(10);
   appetizer_thought1.setLayer(6);
   hearts_1.setLayer(7);
   p_wantb1.setLayer(7);
   p_want1.setLayer(7);
   //podium placement
   podium.setPositionX(112);
   podium.setPositionY(-12);
   podium.setFrame(0);
   podium.setLayer(15);
   //callie placement
   callie.setPositionX(113);
   callie.setPositionY(-19.5);
  }

  //normal mode for 8 through infinity
  if ($world_numeral == 8) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(2);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(141);
   callie.setPositionY(1.5);
  }

  //normal mode for 9 through infinity
  if ($world_numeral == 9) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(0);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(125.143);
   callie.setPositionY(10.221);
  }

  //normal mode for 10 through infinity
  if ($world_numeral == 10) {
   //way_point1.setImageMap(mount_pointImageMap);
   main_bg.setPositionX(100.250);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(2);
   podium.setLayer(11);
   //callie placement
   callie.setPositionX(140);
   callie.setPositionY(-0.9);
  }

  //normal mode for 8 through infinity
  if ($world_numeral > 10 & $world_numeral <= 99) {
   //way_point1.setImageMap(mount_pointImageMap);
   way_point1.setPositionX(104.301);
   way_point1.setPositionY(26.57);
   fx_special_seat.setImageMap(empty_char_spaceImageMap);
   empty_char_space1.setLayer(16);
   thought1.setLayer(10);
   appetizer_thought1.setLayer(8);
   hearts_1.setLayer(9);
   p_wantb1.setLayer(9);
   p_want1.setLayer(9);
   //podium placement
   podium.setPositionX(124.367);
   podium.setPositionY(17.824);
   podium.setFrame(2);
   //callie placement
   callie.setPositionX(140);
   callie.setPositionY(-0.9);
  }

  //$waiter_way_pointX = way_point1.getPositionX();
  //$waiter_way_pointY = way_point1.getPositionY();		
  //waiter1.setPositionX($waiter_way_pointX);
  //waiter1.setPositionY($waiter_way_pointY);
 }
}

/* ----------- HELP MENU --------------- */

//In-game Help Button
function ingame_help::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //%this.setFrame(2);
 }
}

function ingame_help::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $THE_GAME_IS_PAUSED != 1) {
  //%this.setFrame(0);
  monster_shake.setScenePause(true);
  $THE_GAME_IS_PAUSED = 1;
  $timescale = 0;

  text_basic_gameplay.font = "cambo";
  text_appetizers_bonuses.font = "cambo";
  text_ingame_menu.font = "cambo";
  text_order_menu.font = "cambo";
  text_level_select.font = "cambo";
  text_world_map.font = "cambo";
  text_tips_tricks.font = "cambo";

  $screen_position_x = -100;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  //sceneWindow2D.setCurrentCameraPosition( "-200 225 100 75" );
 }
}

function ingame_help::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 //%this.setFrame(0);
}

function ingame_help::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 //%this.setFrame(1);
}

//Help Menu Done Button
function help_menu_done_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function help_menu_done_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(0);
  monster_shake.setScenePause(false);
  $THE_GAME_IS_PAUSED = 0;
  $timescale = 1;
  $screen_position_x = 100;
  $screen_position_y = 0;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function help_menu_done_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function help_menu_done_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
}

/* --------- SUB HELP MENU PROCESSORS ------------- */

//Set Individual Help Menus
function set_help_sub_menu() {
 echo("$find_sub_menu = "
  @ $find_sub_menu);
 //gameplay submenu
 if ($find_sub_menu == 1) {
  $hide_help_menu_back = 1;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_basic_gameplayImageMap);
  help_menu_back_button.setBlendAlpha(0);
  help_menu_more_button.setBlendAlpha(1);
 }
 //gameplay continued submenu
 if ($find_sub_menu == 2) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_basic_gameplay2ImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //appetizers and bonus submenu
 if ($find_sub_menu == 3) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_appetizers_bonusesImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //appetizers and bonus continued submenu
 if ($find_sub_menu == 4) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_appetizers_bonuses2ImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //ingame menu items submenu
 if ($find_sub_menu == 5) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_ingame_menuImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //ingame order menu submenu
 if ($find_sub_menu == 6) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_order_menuImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //ingame level select submenu	
 if ($find_sub_menu == 7) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_level_select_menuImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //ingame world map submenu	
 if ($find_sub_menu == 8) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  bkgd_sub_help.setImageMap(bkgd_help2_world_mapImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(1);
 }
 //ingame tips and tricks submenu		
 if ($find_sub_menu == 9) {
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 1;
  bkgd_sub_help.setImageMap(bkgd_help2_tips_tricksImageMap);
  help_menu_back_button.setBlendAlpha(1);
  help_menu_more_button.setBlendAlpha(0);
 }
}

function define_help_menu_back() {
 if ($find_sub_menu == 1) {
  //Do nothing as there's no 'back' yet
 }
 if ($find_sub_menu == 2) {
  bkgd_sub_help.setImageMap(bkgd_help2_basic_gameplayImageMap);
  $hide_help_menu_back = 1;
  help_menu_back_button.setBlendAlpha(0);
  $find_sub_menu = 1;
 }
 if ($find_sub_menu == 3) {
  bkgd_sub_help.setImageMap(bkgd_help2_basic_gameplay2ImageMap);
  $find_sub_menu = 2;
 }
 if ($find_sub_menu == 4) {
  bkgd_sub_help.setImageMap(bkgd_help2_appetizers_bonusesImageMap);
  $find_sub_menu = 3;
 }
 if ($find_sub_menu == 5) {
  bkgd_sub_help.setImageMap(bkgd_help2_appetizers_bonuses2ImageMap);
  $find_sub_menu = 4;
 }
 if ($find_sub_menu == 6) {
  bkgd_sub_help.setImageMap(bkgd_help2_ingame_menuImageMap);
  $find_sub_menu = 5;
 }
 if ($find_sub_menu == 7) {
  bkgd_sub_help.setImageMap(bkgd_help2_order_menuImageMap);
  $find_sub_menu = 6;
 }
 if ($find_sub_menu == 8) {
  bkgd_sub_help.setImageMap(bkgd_help2_level_select_menuImageMap);
  $find_sub_menu = 7;
 }
 if ($find_sub_menu == 9) {
  bkgd_sub_help.setImageMap(bkgd_help2_world_mapImageMap);
  $find_sub_menu = 8;
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  help_menu_more_button.setBlendAlpha(1);
 }
}

function define_help_menu_more() {
 //reverse order for everything because it is a toggle state, so normal order would run through to end, reverse stops after one iteratively
 if ($find_sub_menu == 9) {
  //do nothing because last help menu
 }
 if ($find_sub_menu == 8) {
  $find_sub_menu = 9;
  set_help_sub_menu();
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 1;
  help_menu_more_button.setBlendAlpha(0);
 }
 if ($find_sub_menu == 7) {
  $find_sub_menu = 8;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 6) {
  $find_sub_menu = 7;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 5) {
  $find_sub_menu = 6;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 4) {
  $find_sub_menu = 5;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 3) {
  $find_sub_menu = 4;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 2) {
  $find_sub_menu = 3;
  set_help_sub_menu();
 }
 if ($find_sub_menu == 1) {
  $find_sub_menu = 2;
  set_help_sub_menu();
 }

}

/* --------- SUB HELP MENU BUTTONS ------------- */

//From Sub-Help Menu to Main Help Menu Button
function help_menu_help_menu_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(2);
 }
}

function help_menu_help_menu_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { % this.setFrame(0);
  $hide_help_menu_back = 0;
  $hide_help_menu_more = 0;
  $screen_position_x = -100;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function help_menu_help_menu_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function help_menu_help_menu_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(1);
}

//Sub-Help Menu Back Button
function help_menu_back_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($hide_help_menu_back != 1) { % this.setFrame(2);
  }
 }
}

function help_menu_back_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($hide_help_menu_back != 1) { % this.setFrame(0);
   define_help_menu_back();
  }
 }
}

function help_menu_back_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($hide_help_menu_back != 1) { % this.setFrame(0);
 }
}

function help_menu_back_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($hide_help_menu_back != 1) { % this.setFrame(1);
 }
}

//Sub-Help Menu More Button
function help_menu_more_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($hide_help_menu_more != 1) { % this.setFrame(2);
  }
 }
}

function help_menu_more_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($hide_help_menu_more != 1) { % this.setFrame(0);
   define_help_menu_more();
  }
 }
}

function help_menu_more_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($hide_help_menu_more != 1) { % this.setFrame(0);
 }
}

function help_menu_more_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($hide_help_menu_more != 1) { % this.setFrame(1);
 }
}

/* --------- SUB HELP MENUS VIA MAIN HELP MENU ------------- */

//Sub Basic Gameplay Invisible Button
function to_sub_basic_gameplay::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_basic_gameplay.BlendColor = "0.5 0.5 0 1";
  help_star1.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_basic_gameplay::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_basic_gameplay.BlendColor = "1 1 1 1";
  help_star1.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 1;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_basic_gameplay::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_basic_gameplay.BlendColor = "1 1 1 1";
 help_star1.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_basic_gameplay::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_basic_gameplay.BlendColor = "1 1 0 1";
 help_star1.setImageMap(icon_star_goldImageMap);
}

//Sub Appetizers Bonus Invisible Button
function to_sub_appetizers_bonus::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_appetizers_bonuses.BlendColor = "0.5 0.5 0 1";
  help_star2.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_appetizers_bonus::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_appetizers_bonuses.BlendColor = "1 1 1 1";
  help_star2.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 3;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_appetizers_bonus::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_appetizers_bonuses.BlendColor = "1 1 1 1";
 help_star2.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_appetizers_bonus::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_appetizers_bonuses.BlendColor = "1 1 0 1";
 help_star2.setImageMap(icon_star_goldImageMap);
}

//Sub Ingame Menu Invisible Button
function to_sub_ingame_menu::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_ingame_menu.BlendColor = "0.5 0.5 0 1";
  help_star3.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_ingame_menu::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_ingame_menu.BlendColor = "1 1 1 1";
  help_star3.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 5;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_ingame_menu::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_ingame_menu.BlendColor = "1 1 1 1";
 help_star3.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_ingame_menu::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_ingame_menu.BlendColor = "1 1 0 1";
 help_star3.setImageMap(icon_star_goldImageMap);
}

//Sub Order Menu Invisible Button
function to_sub_order_menu::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_order_menu.BlendColor = "0.5 0.5 0 1";
  help_star4.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_order_menu::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_order_menu.BlendColor = "1 1 1 1";
  help_star4.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 6;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_order_menu::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_order_menu.BlendColor = "1 1 1 1";
 help_star4.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_order_menu::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_order_menu.BlendColor = "1 1 0 1";
 help_star4.setImageMap(icon_star_goldImageMap);
}

//Sub Level Select Invisible Button
function to_sub_level_select::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_level_select.BlendColor = "0.5 0.5 0 1";
  help_star5.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_level_select::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_level_select.BlendColor = "1 1 1 1";
  help_star5.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 7;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_level_select::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_level_select.BlendColor = "1 1 1 1";
 help_star5.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_level_select::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_level_select.BlendColor = "1 1 0 1";
 help_star5.setImageMap(icon_star_goldImageMap);
}

//Sub Level Select Invisible Button
function to_sub_world_map::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_world_map.BlendColor = "0.5 0.5 0 1";
  help_star6.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_world_map::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_world_map.BlendColor = "1 1 1 1";
  help_star6.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 8;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_world_map::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_world_map.BlendColor = "1 1 1 1";
 help_star6.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_world_map::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_world_map.BlendColor = "1 1 0 1";
 help_star6.setImageMap(icon_star_goldImageMap);
}

//Sub Tips and Tricks Invisible Button
function to_sub_tips_tricks::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_tips_tricks.BlendColor = "0.5 0.5 0 1";
  help_star7.setImageMap(icon_star_bronzeImageMap);
 }
}

function to_sub_tips_tricks::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  text_tips_tricks.BlendColor = "1 1 1 1";
  help_star7.setImageMap(icon_star_bronzeImageMap);
  $find_sub_menu = 9;
  set_help_sub_menu();
  $screen_position_x = -200;
  $screen_position_y = 225;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 }
}

function to_sub_tips_tricks::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 text_tips_tricks.BlendColor = "1 1 1 1";
 help_star7.setImageMap(icon_star_bronzeImageMap);
}

function to_sub_tips_tricks::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 text_tips_tricks.BlendColor = "1 1 0 1";
 help_star7.setImageMap(icon_star_goldImageMap);
}

function reset_sodajerk_statuses() {
 sodajerk1.is_blending = 0;
 sodajerk2.is_blending = 0;
 sodajerk3.is_blending = 0;
 sodajerk4.is_blending = 0;
 drink_out1.BlendColor = "1 1 1 1";
 drink_out2.BlendColor = "1 1 1 1";
 drink_out3.BlendColor = "1 1 1 1";
 drink_out4.BlendColor = "1 1 1 1";
 $calculate_all_sodajerks_business = 0;
 display_occupied.text = $calculate_all_sodajerks_business;
}

function reset_entire_game_profile() {
 purge_save_file();
 $profile_downed = 0;
 $make_start_button_into_continue = 0;
 $toggle_mm_buttons_off = 0;
 $maximum_world_player_got_to = 1;
 $maximum_level_player_got_to = 1;
 $world_numeral = 1;
 $round_numeral = 1;
 $current_level = 1;
 main_bg.setImageMap(bkgd_castle_finalImageMap);
 write_to_save_file();

}

function comptroller::relock_levels_that_were_falsely_unlocked() {
 if ($relocking_start_number <= 10) { % correct_levsel = "levsel_"
  @ $relocking_start_number; % correct_levsel.unlocked = 0; % correct_levsel.setFrame(3);
  $relocking_start_number += 1;
  comptroller.schedule(10, "relock_levels_that_were_falsely_unlocked", 0);
  echo("RELOCKING LEVEL "
   @ $relocking_start_number);
 }
}
$qInExtentChange = false;

function sceneWindow2D::onExtentChange( % this, % data) {
 echo("2 DETECTING WINDOW MODE CHANGE!!!!");
 echo("2 DETECTING WINDOW MODE CHANGE!!!!");
 echo("2 DETECTING WINDOW MODE CHANGE!!!!");
 if ($qInExtentChange) return;
 $qInExtentChange = true;
 setAcceptableScreenRatio();
 $qInExtentChange = false;
}

function setAcceptableScreenRatio() { % screenWidth = getWord(Canvas.extent, 0); % screenHeight = getWord(Canvas.extent, 1);

 % screenRatio = % screenWidth / % screenHeight; % optimalRatio = 1024.0 / 768.0; // WLS - Our Design resolution  

 % newWidth = % screenWidth; % newHeight = % screenHeight;
 if ( % screenRatio < % optimalRatio)
  % newHeight = % screenWidth / % optimalRatio;
 else if ( % screenRatio > % optimalRatio)
  % newWidth = % screenHeight * % optimalRatio; % newX = ( % screenWidth - % newWidth) / 2.0; % newY = ( % screenHeight - % newHeight) / 2.0;
 sceneWindow2D.setPosition( % newX, % newY);
 sceneWindow2D.setExtent( % newWidth, % newHeight);
}

function calculate_screen() { % screenWidth = getWord(Canvas.extent, 0); % screenHeight = getWord(Canvas.extent, 1); % extX = getWord(sceneWindow2D.getExtent(), 0); % extY = getWord(sceneWindow2D.getExtent(), 1); % moo = sceneWindow2D.getCurrentCameraSize(); % moo2 = sceneWindow2D.getWindowExtents();
 //%moo3 = getDesktopResolution();
 % moo3 = $desktopWidth; % moo4 = $desktopHeight;
 //sceneWindow2D.setCurrentCameraPosition(100, 0, 90, 70);
 echo("ratio 1 : "
  @ % screenWidth);
 echo("ratio 2 : "
  @ % screenHeight);
 echo("ratio 3 : "
  @ % extX);
 echo("ratio 4 : "
  @ % extY);
 echo("ratio 5 : "
  @ % moo);
 echo("ratio 6 : "
  @ % moo2);
 echo("ratio 7 : "
  @ % moo3);
 echo("ratio 7 : "
  @ % moo4);
}

//comptroller.award_breaker();
function comptroller::award_breaker( % this) {
 $end_trophy_ribbon3 = 0; % this.schedule(10, "fake_win", 0);

 $end_trophy_ribbon2 = 0; % this.schedule(3900, "fake_win2", 0);

 $end_trophy_ribbon1 = 0; % this.schedule(7790, "fake_win3", 0);

}

function comptroller::award_breaker2( % this) {
 $end_trophy_ribbon2 = 0; % this.schedule(3900, "fake_win2", 0);
}

function comptroller::fake_win( % this) {
 echo("fake win");
 $root_trophy_identfier = "ribbon3";
 win_this_trophy();
}

function comptroller::fake_win2( % this) {
 echo("fake win2");
 $root_trophy_identfier = "ribbon2";
 win_this_trophy();
}

function comptroller::fake_win3( % this) {
 echo("fake win3");
 $root_trophy_identfier = "ribbon1";
 win_this_trophy();
}

function check_current_profile_text_length() {
 echo("$current_profile_slot = "
  @ $current_profile_slot);
 $check_profile_slot_text_length = strlen($current_profile_slot.text);
 echo("$check_profile_slot_text_length = "
  @ $check_profile_slot_text_length);
 echo($check_profile_slot_text_length);
}

function comptroller::blinky_profile_box( % this) {
 if ($already_blinking_profile != 1) { % find_reciprocating_slot_number = $current_profile_slot.id_number;
  echo("Blinky slot profile is "
   @ % find_reciprocating_slot_number);
  $current_blinky_slot = "profile_text_slot"
  @ % find_reciprocating_slot_number; % this.schedule(200, "prof_blink", 0); % this.schedule(400, "prof_unblink", 0); % this.schedule(600, "prof_blink", 0); % this.schedule(800, "prof_unblink", 0); % this.schedule(1000, "prof_blink", 0); % this.schedule(1200, "prof_unblink", 0); % this.schedule(1400, "prof_blink", 0); % this.schedule(1600, "prof_unblink", 0); % this.schedule(1800, "prof_blink", 0); % this.schedule(2000, "prof_unblink", 0); % this.schedule(2200, "prof_blink", 0); % this.schedule(2400, "prof_unblink_end", 0);
  $already_blinking_profile = 1;
 }
}

function comptroller::blinky_profile_box_first_profile( % this) {
 if ($already_blinking_profile != 1) { % find_reciprocating_slot_number = 0;
  echo("Blinky slot profile is "
   @ % find_reciprocating_slot_number);
  $current_blinky_slot = "profile_text_slot"
  @ % find_reciprocating_slot_number; % this.schedule(200, "prof_blink", 0); % this.schedule(400, "prof_unblink", 0); % this.schedule(600, "prof_blink", 0); % this.schedule(800, "prof_unblink", 0); % this.schedule(1000, "prof_blink", 0); % this.schedule(1200, "prof_unblink", 0); % this.schedule(1400, "prof_blink", 0); % this.schedule(1600, "prof_unblink", 0); % this.schedule(1800, "prof_blink", 0); % this.schedule(2000, "prof_unblink", 0); % this.schedule(2200, "prof_blink", 0); % this.schedule(2400, "prof_unblink_end", 0);
  $already_blinking_profile = 1;
 }
}

function comptroller::prof_blink( % this) {
 $current_blinky_slot.setBlendAlpha(0.5);
}

function comptroller::prof_unblink( % this) {
 $current_blinky_slot.setBlendAlpha(1);
}

function comptroller::prof_unblink_end( % this) {
 $current_blinky_slot.setBlendAlpha(1);
 $already_blinking_profile = 0;
}

function reload_factory_settings() {
 $bob_test = $current_profile_slot.text;
 $current_level = 1;
 $round_numeral = 1;
 $world_numeral = 1;
 $coinage = 0;
 $coinage_max = 120;

 /* trophies data */
 $_trophy_trophy1_activated = 0;
 $_trophy_trophy2_activated = 0;
 $_trophy_trophy3_activated = 0;
 $_trophy_trophy4_activated = 0;
 $_trophy_trophy5_activated = 0;
 $_trophy_trophy6_activated = 0;
 $_trophy_trophy7_activated = 0;
 $_trophy_trophy8_activated = 0;
 $_trophy_trophy9_activated = 0;

 $_trophy_plaque1_activated = 0;
 $_trophy_plaque2_activated = 0;
 $_trophy_plaque3_activated = 0;
 $_trophy_plaque4_activated = 0;
 $_trophy_plaque5_activated = 0;
 $_trophy_plaque6_activated = 0;
 $_trophy_plaque7_activated = 0;
 $_trophy_plaque8_activated = 0;
 $_trophy_plaque9_activated = 0;
 $_trophy_plaque10_activated = 0;

 $_trophy_ribbon1_activated = 0;
 $_trophy_ribbon2_activated = 0;
 $_trophy_ribbon3_activated = 0;
 $_trophy_ribbon4_activated = 0;
 $_trophy_ribbon5_activated = 0;
 $_trophy_ribbon6_activated = 0;

 $_trophy_button1_activated = 0;
 $_trophy_button2_activated = 0;
 $_trophy_button3_activated = 0;
 $_trophy_button4_activated = 0;
 $_trophy_button5_activated = 0;
 $_trophy_button6_activated = 0;

 $_trophy_mount1_activated = 0;
 $_trophy_mount2_activated = 0;
 $_trophy_mount3_activated = 0;
 $_trophy_mount4_activated = 0;

 $_trophy_dollar_activated = 0;
 $trophy_all_gold_in_round = 0;
 $trophy_angered_a_customer = 0;
 $trophy_no_angry_customers = 0;

 $points_you_have = 0;
 $points_you_need = 250;

 $trophy_toggle_off_all_gold_in_round = 0;

 $maximum_level_player_got_to = 1;
 $maximum_world_player_got_to = 1;

 levsel_1.unlocked = 1;
 levsel_2.unlocked = 0;
 levsel_3.unlocked = 0;
 levsel_4.unlocked = 0;
 levsel_5.unlocked = 0;
 levsel_6.unlocked = 0;
 levsel_7.unlocked = 0;
 levsel_8.unlocked = 0;
 levsel_9.unlocked = 0;
 levsel_10.unlocked = 0;

 //points accumulated
 $points_amount = 0;

 //flying coins collected for trophy purposes
 $flying_coins_collected = 0;

 $vortexes_collected = 0;

 //toggle load states for mega manager trophy counter
 $trophy_toggle_off_plaque1 = 0;
 $trophy_toggle_off_plaque2 = 0;
 $trophy_toggle_off_plaque3 = 0;
 $trophy_toggle_off_plaque4 = 0;
 $trophy_toggle_off_plaque5 = 0;
 $trophy_toggle_off_plaque6 = 0;
 $trophy_toggle_off_plaque7 = 0;
 $trophy_toggle_off_plaque8 = 0;
 $trophy_toggle_off_plaque9 = 0;
 $trophy_toggle_off_plaque10 = 0;

 $mega_manager_counter = 0;

 $customers_served_counter = 0;

 $appetizer1_purchased1 = 1;
 $appetizer1_purchased2 = 1;
 $appetizer1_purchased3 = 1;
 $appetizer1_purchased4 = 1;
 $appetizer1_purchased5 = 1;
 $appetizer1_purchased6 = 1;
 $appetizer1_purchased7 = 1;
 $appetizer1_purchased8 = 1;
 $appetizer1_purchased9 = 1;
 $appetizer1_purchased10 = 1;

 $appetizer2_purchased1 = 1;
 $appetizer2_purchased2 = 1;
 $appetizer2_purchased3 = 1;
 $appetizer2_purchased4 = 1;
 $appetizer2_purchased5 = 1;
 $appetizer2_purchased6 = 1;
 $appetizer2_purchased7 = 1;
 $appetizer2_purchased8 = 1;
 $appetizer2_purchased9 = 1;
 $appetizer2_purchased10 = 1;


 $star_system_array = "0 0 0 0 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";

 $sfx_level = 1;
 $music_level = 1;
 $soundfx_loudness = 99;
 $music_loudness = 99;
 $appetizer1_amount1 = $appetizer_default_amount;
 $appetizer1_amount2 = $appetizer_default_amount;
 $appetizer1_amount3 = $appetizer_default_amount;
 $appetizer1_amount4 = $appetizer_default_amount;
 $appetizer1_amount5 = $appetizer_default_amount;
 $appetizer1_amount6 = $appetizer_default_amount;
 $appetizer1_amount7 = $appetizer_default_amount;
 $appetizer1_amount8 = $appetizer_default_amount;
 $appetizer1_amount9 = $appetizer_default_amount;
 $appetizer1_amount10 = $appetizer_default_amount;

 //$appetizer2_amount0 = 10;
 $appetizer2_amount1 = $appetizer_default_amount;
 $appetizer2_amount2 = $appetizer_default_amount;
 $appetizer2_amount3 = $appetizer_default_amount;
 $appetizer2_amount4 = $appetizer_default_amount;
 $appetizer2_amount5 = $appetizer_default_amount;
 $appetizer2_amount6 = $appetizer_default_amount;
 $appetizer2_amount7 = $appetizer_default_amount;
 $appetizer2_amount8 = $appetizer_default_amount;
 $appetizer2_amount9 = $appetizer_default_amount;
 $appetizer2_amount10 = $appetizer_default_amount;


 $entertainer1_bought_world1 = 0;
 $entertainer2_bought_world1 = 0;
 $entertainer1_bought_world2 = 0;
 $entertainer2_bought_world2 = 0;
 $entertainer1_bought_world3 = 0;
 $entertainer2_bought_world3 = 0;
 $entertainer1_bought_world4 = 0;
 $entertainer2_bought_world4 = 0;
 $entertainer1_bought_world5 = 0;
 $entertainer2_bought_world5 = 0;
 $entertainer1_bought_world6 = 0;
 $entertainer2_bought_world6 = 0;
 $entertainer1_bought_world7 = 0;
 $entertainer2_bought_world7 = 0;
 $entertainer1_bought_world8 = 0;
 $entertainer2_bought_world8 = 0;
 $entertainer1_bought_world9 = 0;
 $entertainer2_bought_world9 = 0;
 $entertainer1_bought_world10 = 0;
 $entertainer2_bought_world10 = 0;
 write_to_save_file();
}

function reload_factory_settings_no_save() {
 $bob_test = $current_profile_slot.text;
 $current_level = 1;
 $round_numeral = 1;
 $world_numeral = 1;
 $coinage = 0;
 $coinage_max = 120;

 /* trophies data */
 $_trophy_trophy1_activated = 0;
 $_trophy_trophy2_activated = 0;
 $_trophy_trophy3_activated = 0;
 $_trophy_trophy4_activated = 0;
 $_trophy_trophy5_activated = 0;
 $_trophy_trophy6_activated = 0;
 $_trophy_trophy7_activated = 0;
 $_trophy_trophy8_activated = 0;
 $_trophy_trophy9_activated = 0;

 $_trophy_plaque1_activated = 0;
 $_trophy_plaque2_activated = 0;
 $_trophy_plaque3_activated = 0;
 $_trophy_plaque4_activated = 0;
 $_trophy_plaque5_activated = 0;
 $_trophy_plaque6_activated = 0;
 $_trophy_plaque7_activated = 0;
 $_trophy_plaque8_activated = 0;
 $_trophy_plaque9_activated = 0;
 $_trophy_plaque10_activated = 0;

 $_trophy_ribbon1_activated = 0;
 $_trophy_ribbon2_activated = 0;
 $_trophy_ribbon3_activated = 0;
 $_trophy_ribbon4_activated = 0;
 $_trophy_ribbon5_activated = 0;
 $_trophy_ribbon6_activated = 0;

 $_trophy_button1_activated = 0;
 $_trophy_button2_activated = 0;
 $_trophy_button3_activated = 0;
 $_trophy_button4_activated = 0;
 $_trophy_button5_activated = 0;
 $_trophy_button6_activated = 0;

 $_trophy_mount1_activated = 0;
 $_trophy_mount2_activated = 0;
 $_trophy_mount3_activated = 0;
 $_trophy_mount4_activated = 0;

 $_trophy_dollar_activated = 0;
 $trophy_all_gold_in_round = 0;
 $trophy_angered_a_customer = 0;
 $trophy_no_angry_customers = 0;

 $points_you_have = 0;
 $points_you_need = 250;

 $trophy_toggle_off_all_gold_in_round = 0;

 $maximum_level_player_got_to = 1;
 $maximum_world_player_got_to = 1;

 levsel_1.unlocked = 1;
 levsel_2.unlocked = 0;
 levsel_3.unlocked = 0;
 levsel_4.unlocked = 0;
 levsel_5.unlocked = 0;
 levsel_6.unlocked = 0;
 levsel_7.unlocked = 0;
 levsel_8.unlocked = 0;
 levsel_9.unlocked = 0;
 levsel_10.unlocked = 0;

 //points accumulated
 $points_amount = 0;

 //flying coins collected for trophy purposes
 $flying_coins_collected = 0;

 $vortexes_collected = 0;

 //toggle load states for mega manager trophy counter
 $trophy_toggle_off_plaque1 = 0;
 $trophy_toggle_off_plaque2 = 0;
 $trophy_toggle_off_plaque3 = 0;
 $trophy_toggle_off_plaque4 = 0;
 $trophy_toggle_off_plaque5 = 0;
 $trophy_toggle_off_plaque6 = 0;
 $trophy_toggle_off_plaque7 = 0;
 $trophy_toggle_off_plaque8 = 0;
 $trophy_toggle_off_plaque9 = 0;
 $trophy_toggle_off_plaque10 = 0;

 $mega_manager_counter = 0;

 $customers_served_counter = 0;

 $appetizer1_purchased1 = 1;
 $appetizer1_purchased2 = 1;
 $appetizer1_purchased3 = 1;
 $appetizer1_purchased4 = 1;
 $appetizer1_purchased5 = 1;
 $appetizer1_purchased6 = 1;
 $appetizer1_purchased7 = 1;
 $appetizer1_purchased8 = 1;
 $appetizer1_purchased9 = 1;
 $appetizer1_purchased10 = 1;

 $appetizer2_purchased1 = 1;
 $appetizer2_purchased2 = 1;
 $appetizer2_purchased3 = 1;
 $appetizer2_purchased4 = 1;
 $appetizer2_purchased5 = 1;
 $appetizer2_purchased6 = 1;
 $appetizer2_purchased7 = 1;
 $appetizer2_purchased8 = 1;
 $appetizer2_purchased9 = 1;
 $appetizer2_purchased10 = 1;

 $star_system_array = "0 0 0 0 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";

 $sfx_level = 1;
 $music_level = 1;
 $soundfx_loudness = 99;
 $music_loudness = 99;

 $appetizer1_amount1 = $appetizer_default_amount;
 $appetizer1_amount2 = $appetizer_default_amount;
 $appetizer1_amount3 = $appetizer_default_amount;
 $appetizer1_amount4 = $appetizer_default_amount;
 $appetizer1_amount5 = $appetizer_default_amount;
 $appetizer1_amount6 = $appetizer_default_amount;
 $appetizer1_amount7 = $appetizer_default_amount;
 $appetizer1_amount8 = $appetizer_default_amount;
 $appetizer1_amount9 = $appetizer_default_amount;
 $appetizer1_amount10 = $appetizer_default_amount;

 //$appetizer2_amount0 = 10;
 $appetizer2_amount1 = $appetizer_default_amount;
 $appetizer2_amount2 = $appetizer_default_amount;
 $appetizer2_amount3 = $appetizer_default_amount;
 $appetizer2_amount4 = $appetizer_default_amount;
 $appetizer2_amount5 = $appetizer_default_amount;
 $appetizer2_amount6 = $appetizer_default_amount;
 $appetizer2_amount7 = $appetizer_default_amount;
 $appetizer2_amount8 = $appetizer_default_amount;
 $appetizer2_amount9 = $appetizer_default_amount;
 $appetizer2_amount10 = $appetizer_default_amount;

 $entertainer1_bought_world1 = 0;
 $entertainer2_bought_world1 = 0;
 $entertainer1_bought_world2 = 0;
 $entertainer2_bought_world2 = 0;
 $entertainer1_bought_world3 = 0;
 $entertainer2_bought_world3 = 0;
 $entertainer1_bought_world4 = 0;
 $entertainer2_bought_world4 = 0;
 $entertainer1_bought_world5 = 0;
 $entertainer2_bought_world5 = 0;
 $entertainer1_bought_world6 = 0;
 $entertainer2_bought_world6 = 0;
 $entertainer1_bought_world7 = 0;
 $entertainer2_bought_world7 = 0;
 $entertainer1_bought_world8 = 0;
 $entertainer2_bought_world8 = 0;
 $entertainer1_bought_world9 = 0;
 $entertainer2_bought_world9 = 0;
 $entertainer1_bought_world10 = 0;
 $entertainer2_bought_world10 = 0;
}

function hide_remaining_tutorial_cache() {
 $activate_continuing_tutorial = 0;
 $toggle_off_om_appetizer_buttons_because_tut_ext = 0;
 $toggle_off_om_awards_button_because_tut_ext = 0;
 $toggle_off_om_map_button_because_tut_ext = 0;
 $toggle_off_om_continue_button_because_tut_ext = 0;
 $toggle_off_button_levsel_menu_because_tut_ext = 0;
 $toggle_off_button_levsel_map_because_tut_ext = 0;

 mask_levsel.setPositionX(105);
 mask_levsel.setPositionY(69);
 mask_levsel.setSize(5, 5);
 mask_levsel.setBlendAlpha(0);
 isolater_mask.setPositionX(124.169);
 isolater_mask.setPositionY(98.063);
 isolater_mask.setSize(11.735, 9.085);
 isolater_mask.setBlendAlpha(0);
 tutorial_extended_text1.text = "";
 tutorial_extended_text1.setPositionX(115.664);
 tutorial_extended_text1.setPositionY(80.422);
 tutorial_extended_text1.setBlendAlpha(0);
 tutorial_extended_text2.text = "";
 tutorial_extended_text2.setPositionX(115.664);
 tutorial_extended_text2.setPositionY(80.422);
 tutorial_extended_text2.setBlendAlpha(0);
 tutorial_ext_bar1.setPositionX(115.664);
 tutorial_ext_bar1.setPositionY(80.422);
 tutorial_ext_bar1.setSize(5, 5);
 tutorial_ext_bar1.setBlendAlpha(0);
 tutorial_ext_bar2.setPositionX(115.664);
 tutorial_ext_bar2.setPositionY(80.422);
 tutorial_ext_bar2.setSize(5, 5);
 tutorial_ext_bar2.setBlendAlpha(0);
 tut_ext_continue.setPositionX(87.690);
 tut_ext_continue.setPositionY(98.215);
 tut_ext_continue.setBlendAlpha(0);
 clock_hand.setBlendAlpha(1);
 levsel_1.setBlendAlpha(1);
 levsel_2.setBlendAlpha(1);
 levsel_pulse_glow_echo.setBlendAlpha(1);
 levsel_stars1.setBlendAlpha(1);
 tutorial_clicker.setPositionX(95.182);
 tutorial_clicker.setPositionY(89.717);
 tutorial_clicker.setBlendAlpha(0);
 tut_ext_pointer.setPositionX(81.788);
 tut_ext_pointer.setPositionY(74.917);
 tut_ext_pointer.setBlendAlpha(0);
 tut_ext_pointer2.setRotation(0);
 tut_ext_pointer2.setPositionX(81.788);
 tut_ext_pointer2.setPositionY(74.917);
 tut_ext_pointer2.setBlendAlpha(0);
 tut_ext_pointer2.setRotation(0);
 //$tutorial_activate_cook_sequence = 0;

}

function quickly_identify_world_audio() {
 if ($world_numeral == 1) {
  $default_audio = "castle_theme";
  $world_audio = "castle_theme";
 }
 if ($world_numeral == 2) {
  $default_audio = "swamp_theme";
  $world_audio = "swamp_theme";
 }
 if ($world_numeral == 3) {
  $default_audio = "airship_theme";
  $world_audio = "airship_theme";
 }
 if ($world_numeral == 4) {
  $default_audio = "hawaii_theme";
  $world_audio = "hawaii_theme";
 }
 if ($world_numeral == 5) {
  $default_audio = "viking_theme";
  $world_audio = "viking_theme";
 }
 if ($world_numeral == 6) {
  $default_audio = "forest_theme";
  $world_audio = "forest_theme";
 }
 if ($world_numeral == 7) {
  $default_audio = "train_theme";
  $world_audio = "train_theme";
 }
 if ($world_numeral == 8) {
  $default_audio = "france_theme";
  $world_audio = "france_theme";
 }
 if ($world_numeral == 9) {
  $default_audio = "newyork_theme";
  $world_audio = "newyork_theme";
 }
 if ($world_numeral == 10) {
  $default_audio = "hometown_theme";
  $world_audio = "hometown_theme";
 }
}

function purge_any_current_ingame_stuff() {
 echo("***PURGING ANY INGAME STUFF***");
 game_fail_text.setBlendAlpha(0);
 game_fail_number.setBlendAlpha(0);
 $game_clock_number = 0;
 //write_to_save_file();
 //For sodajerks and others to stop schedules
 //$world_ended = 1;
 black_stretch.BlendColor = "0 0 0 0";
 black_stretch.setPositionX(9999);

 //Kill all char_attributes to release deteleport locks, and then deteleport them all
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;
 //Reset the score
 $coinage = $special_record_coins_at_round_start;
 score_number.text = $coinage;
 $points_amount = $special_record_points_at_round_start;
 points_number.text = $points_amount;
 alxStopAll();
 if ($toggle_mute_music != 1) {
  //edit 12-29-2014 re-enabled this since it cancels out music during game fail restart if not muted
  alxPlay($default_audio);
 }
 pre_calculate_round_max_times();
 $initialize_bonus_portals_to_appear_random = 1;
 //edit 01-25-2015 THIS IS BLACKHEART
 if ($black_heart_pass == 1) {
  $game_has_started_for_clock = 1;
 }
 $toggle_initial_spawner_via_clock = 0;
 $world_ended = 0;
 $end_the_clock = 0;
 echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ E");
 $left_the_level_space = 0;
 //sceneWindow2D.setCurrentCameraPosition( "100 0 100 75" ); 

 empty_coin1.reset_coin_tips();
 empty_coin2.reset_coin_tips();
 empty_coin3.reset_coin_tips();
 empty_coin4.reset_coin_tips();

 empty_char_space1.schedule(0, "delete_old_data", 0);
 empty_char_space1.is_angry = 1;
 //new stuff
 empty_char_space1.is_despawned = 0;
 empty_char_space1.accidental_deteleport_preventer = 0;
 empty_char_space1.detected_incoming_drink = 0;
 empty_char_space1.lock_incoming_drink = 0;
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;

 empty_char_space1.detected_incoming_drink = 0;
 empty_char_space1.schedule(0, "deteleport", 0);

 empty_char_space2.schedule(0, "delete_old_data", 0);
 empty_char_space2.is_angry = 1;
 //new stuff
 empty_char_space2.is_despawned = 0;
 empty_char_space2.accidental_deteleport_preventer = 0;
 empty_char_space2.detected_incoming_drink = 0;
 empty_char_space2.lock_incoming_drink = 0;
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;

 empty_char_space2.detected_incoming_drink = 0;
 empty_char_space2.schedule(0, "deteleport", 0);

 empty_char_space3.schedule(0, "delete_old_data", 0);
 empty_char_space3.is_angry = 1;
 //new stuff
 empty_char_space3.is_despawned = 0;
 empty_char_space3.accidental_deteleport_preventer = 0;
 empty_char_space3.detected_incoming_drink = 0;
 empty_char_space3.lock_incoming_drink = 0;
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;

 empty_char_space3.detected_incoming_drink = 0;
 empty_char_space3.schedule(0, "deteleport", 0);

 empty_char_space4.schedule(0, "delete_old_data", 0);
 empty_char_space4.is_angry = 1;
 //new stuff
 empty_char_space4.is_despawned = 0;
 empty_char_space4.accidental_deteleport_preventer = 0;
 empty_char_space4.detected_incoming_drink = 0;
 empty_char_space4.lock_incoming_drink = 0;
 $p1_present = 0;
 $cease_infinite_spawning_issues = 0;
 $char1_tutorial_over_with = 1;

 empty_char_space4.detected_incoming_drink = 0;
 empty_char_space4.schedule(0, "deteleport", 0);

 //release single-play toggles for feeding special characters during a round
 release_all_special_char_toggles();

 special_character_hili.setPositionX(171.899);
 special_character_hili.setPositionY(-70.529);
 //DISABLE ALL MASKS
 isolater_mask.setBlendAlpha(0);
 isolater_mask2.setBlendAlpha(0);
 black_stretch2.setBlendAlpha(0);
 black_stretch3.setBlendAlpha(0);
 mask_levsel.setBlendAlpha(0);
 black_box1.setBlendAlpha(0);
 prestarter_black.setBlendAlpha(0);

 //AND JUST INCASE!
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

 //$appetizer1_purchased1 = 1;
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

 //resets sodajerks
 reset_sodajerk_statuses();

 drink_out1.active = 0;
 drink_out2.active = 0;
 drink_out3.active = 0;
 drink_out4.active = 0;
 drink_in1.dirty = 0;
 drink_in2.dirty = 0;
 drink_in3.dirty = 0;
 drink_in4.dirty = 0;
 drink_out1.setAnimation(drink_popupAnimation);
 drink_out2.setAnimation(drink_popupAnimation);
 drink_out3.setAnimation(drink_popupAnimation);
 drink_out4.setAnimation(drink_popupAnimation);
 drink_in1.setAnimation(drink_popupAnimation);
 drink_in2.setAnimation(drink_popupAnimation);
 drink_in3.setAnimation(drink_popupAnimation);
 drink_in4.setAnimation(drink_popupAnimation);

 waiter_cancel1.setPositionX(159.313);
 waiter_cancel1.setPositionY(19.539);
 drink_cancel1.setPositionX(159.313);
 drink_cancel1.setPositionY(25.215);
 hearts_1.setBlendAlpha(0);
 hearts_2.setBlendAlpha(0);
 hearts_3.setBlendAlpha(0);
 hearts_4.setBlendAlpha(0);
 appetizer_thought1.setBlendAlpha(0);
 appetizer_thought2.setBlendAlpha(0);
 appetizer_thought3.setBlendAlpha(0);
 appetizer_thought4.setBlendAlpha(0);
 drink_ident1.setImageMap(empty_coinImageMap);
 drink_ident11.setImageMap(empty_coinImageMap);
 drink_ident1.setFrame(0);
 drink_ident11.setFrame(0);
 drink_ident2.setImageMap(empty_coinImageMap);
 drink_ident12.setImageMap(empty_coinImageMap);
 drink_ident2.setFrame(0);
 drink_ident12.setFrame(0);
 drink_ident3.setImageMap(empty_coinImageMap);
 drink_ident13.setImageMap(empty_coinImageMap);
 drink_ident3.setFrame(0);
 drink_ident13.setFrame(0);
 drink_ident4.setImageMap(empty_coinImageMap);
 drink_ident14.setImageMap(empty_coinImageMap);
 drink_ident4.setFrame(0);
 drink_ident14.setFrame(0);
 pointer_cook1.setAnimation(empty_char_spaceAnimation);
 pointer_cook2.setAnimation(empty_char_spaceAnimation);
 pointer_cook3.setAnimation(empty_char_spaceAnimation);
 pointer_cook4.setAnimation(empty_char_spaceAnimation);
 drink_out1.up_status = 0;
 drink_out2.up_status = 0;
 drink_out3.up_status = 0;
 drink_out4.up_status = 0;
 //$toggle_no_drink_switch_til_dropped_off = 0;			
}

function purge_any_remnants() {
 echo("PURGE ANY REMNANTS..............");
 echo("PURGE ANY REMNANTS..............");
 echo("PURGE ANY REMNANTS..............");
 //$toggle_no_drink_switch_til_dropped_off = 0;
 //$toggle_no_drink_switch_til_dropped_off = 0;
 /* Do not remove drink_cancel1.onMouseDown, it clears all data of the last drink you were on under all circumstances */
 drink_cancel1.onMouseDown();
 waiter_cancel1.setPositionX(159.313);
 waiter_cancel1.setPositionY(19.539);
 drink_cancel1.setPositionX(159.313);
 drink_cancel1.setPositionY(25.215);
 hearts_1.setBlendAlpha(0);
 hearts_2.setBlendAlpha(0);
 hearts_3.setBlendAlpha(0);
 hearts_4.setBlendAlpha(0);
 appetizer_thought1.setBlendAlpha(0);
 appetizer_thought2.setBlendAlpha(0);
 appetizer_thought3.setBlendAlpha(0);
 appetizer_thought4.setBlendAlpha(0);
 dirty_extra_cup1.setBlendAlpha(0);
 dirty_extra_cup1.active = 0;
 dirty_extra_cup2.setBlendAlpha(0);
 dirty_extra_cup2.active = 0;
 dirty_extra_cup3.setBlendAlpha(0);
 dirty_extra_cup3.active = 0;
 dirty_extra_cup4.setBlendAlpha(0);
 dirty_extra_cup4.active = 0;
 $toggle_serve_cursor = 0;
 $toggle_dirty_cursor = 0;
 $toggle_toss_cursor = 0;
 set_cursor_to_default();

 $appetizer1_amount1 = $appetizer_default_amount;
 $appetizer1_amount2 = $appetizer_default_amount;
 $appetizer1_amount3 = $appetizer_default_amount;
 $appetizer1_amount4 = $appetizer_default_amount;
 $appetizer1_amount5 = $appetizer_default_amount;
 $appetizer1_amount6 = $appetizer_default_amount;
 $appetizer1_amount7 = $appetizer_default_amount;
 $appetizer1_amount8 = $appetizer_default_amount;
 $appetizer1_amount9 = $appetizer_default_amount;
 $appetizer1_amount10 = $appetizer_default_amount;

 //$appetizer2_amount0 = 10;
 $appetizer2_amount1 = $appetizer_default_amount;
 $appetizer2_amount2 = $appetizer_default_amount;
 $appetizer2_amount3 = $appetizer_default_amount;
 $appetizer2_amount4 = $appetizer_default_amount;
 $appetizer2_amount5 = $appetizer_default_amount;
 $appetizer2_amount6 = $appetizer_default_amount;
 $appetizer2_amount7 = $appetizer_default_amount;
 $appetizer2_amount8 = $appetizer_default_amount;
 $appetizer2_amount9 = $appetizer_default_amount;
 $appetizer2_amount10 = $appetizer_default_amount;
}

//function guiBitmapButtonCtrl::onMouseDragged(%this)  

function drag_cup() { % cursorpos = Canvas.getCursorPos(); % xPos = getWord( % cursorpos, 0) + 32; //%xOffset;  
 % yPos = getWord( % cursorpos, 1) + 32; //%yOffset; 
 echo(" "
  @ % xPos @ " x "
  @ % yPos);

}

function button_options_custom_cursor::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 $toggle_off_custom_cursors = 1;
 if ($platform $ = "macos") {
  Canvas.setcursor(macCursor);
 }
 if ($platform != "macos") {
  Canvas.setcursor(windowsCursor);
 }
}

function set_cursor_to_default() {
 if ($toggle_serve_cursor != 1 & $toggle_dirty_cursor != 1 & $toggle_off_custom_cursors != 1) {
  $toggle_cursor_is_serving = 0;
  Canvas.setcursor(DefaultCursor);
 }
}

function set_cursor_to_hand() {
 if ($toggle_serve_cursor != 1 & $toggle_dirty_cursor != 1 & $toggle_off_custom_cursors != 1) {
  Canvas.setcursor(HandCursor);
 }
}

function set_cursor_to_serve() {
 if ($toggle_toss_cursor != 1 & $toggle_dirty_cursor != 1 & $toggle_off_custom_cursors != 1) {
  Canvas.setcursor(ServeCupCursor);
  $toggle_cursor_is_serving = 1;
 }
}

function set_cursor_to_dirty() {
 if ($toggle_serve_cursor != 1 & $toggle_toss_cursor != 1 & $toggle_off_custom_cursors != 1) {
  Canvas.setcursor(DirtyCupCursor);
  $toggle_no_drink_switch_til_dropped_off = 1;
 }
}

function set_cursor_to_toss() {
 if ($toggle_off_custom_cursors != 1) {
  Canvas.setcursor(TossCupCursor);
 }
}

function set_cursor_to_hili() {
 if ($toggle_serve_cursor != 1 & $toggle_dirty_cursor != 1 & $toggle_toss_cursor != 1 & $toggle_off_custom_cursors != 1) {
  Canvas.setcursor(HiliCursor);
 }
}

/* appetizer cursors */

function set_cursor_to_appetizer1() {
 if ($toggle_serve_cursor == 1 & $toggle_off_custom_cursors != 1) { % find_appetizer1 = "appetizer_cursor1_"
  @ $world_numeral;
  Canvas.setcursor( % find_appetizer1);
  $toggle_appetizer_cursor = 1;
 }
}

function set_cursor_to_appetizer2() {
 if ($toggle_serve_cursor == 1 & $toggle_off_custom_cursors != 1) { % find_appetizer2 = "appetizer_cursor2_"
  @ $world_numeral;
  Canvas.setcursor( % find_appetizer2);
  $toggle_appetizer_cursor = 2;
 }
}

function hearts_1::five_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 echo("HEARTS 1 AT 5 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%%%%%%%%%%%%%%%%");
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 5;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h5 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle @ " VS %has_left_the_game_version="
   @ % has_left_the_game_version);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo(" 88888 HEARTS 88888 ------- "
    @ % identify_this_time_space @ " "
    @ % confirm_world_numeral @ " "
    @ % confirm_round_numeral @ " "
    @ % round_restart_toggle);
   echo(" 88888 HEARTS 88888 ------- "
    @ % identify_this_time_space @ " "
    @ % confirm_world_numeral @ " "
    @ % confirm_round_numeral @ " "
    @ % round_restart_toggle);
   echo(" 88888 HEARTS 88888 ------- "
    @ % identify_this_time_space @ " "
    @ % confirm_world_numeral @ " "
    @ % confirm_round_numeral @ " "
    @ % round_restart_toggle);
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(0);
    hearts_1.setBlendAlpha(1);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    hearts_1.setFrame(0);
    hearts_1.setBlendAlpha(1);
   }
  }
 }
}

function hearts_1::four_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 echo("HEARTS 1 AT 4 $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%%%%%%%%%%%%%%%%");
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 4;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h4 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle @ " VS %has_left_the_game_version="
   @ % has_left_the_game_version);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(1);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    //hearts_1.setFrame(0);
    //hearts_1.setBlendAlpha(1);	
   }
  }
 }
}

function hearts_1::three_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 3;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h3 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(2);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    //hearts_1.setFrame(0);
    //hearts_1.setBlendAlpha(1);	
   }
  }
 }
}

function hearts_1::two_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 2;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h2 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(3);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    //hearts_1.setFrame(0);
    //hearts_1.setBlendAlpha(1);	
   }
  }
 }
}

function hearts_1::one_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 1;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  echo("h1 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(4);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    //hearts_1.setFrame(0);
    //hearts_1.setBlendAlpha(1);	
   }
  }
 }
}

function hearts_1::zero_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 02-28-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 0;

  % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h0 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled1 == 1) {
    hearts_1.setFrame(5);
   }
   if ($hearts_scheduled1 == 0) {
    hearts_1.setBlendAlpha(0);
   }
   if ($tutorial_popup_officially_ended_via_yes_or_no == 1) {
    //hearts_1.setFrame(0);
    //hearts_1.setBlendAlpha(1);	
   }
  }
 }
}

function hearts_2::five_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 5; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h5 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(0);
    hearts_2.setBlendAlpha(1);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_2::four_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 4; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h4 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(1);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_2::three_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 3; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h3 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(2);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_2::two_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 2; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h2 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(3);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_2::one_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 1; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h1 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(4);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_2::zero_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 0; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h0 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled2 == 1) {
    hearts_2.setFrame(5);
   }
   if ($hearts_scheduled2 == 0) {
    hearts_2.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::five_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 5; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h5 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(0);
    hearts_3.setBlendAlpha(1);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::four_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 4; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h4 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(1);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::three_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 3; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h3 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(2);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::two_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 2; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h2 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(3);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::one_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 1; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h1 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(4);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_3::zero_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 0; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h0 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled3 == 1) {
    hearts_3.setFrame(5);
   }
   if ($hearts_scheduled3 == 0) {
    hearts_3.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::five_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 5; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h5 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(0);
    hearts_4.setBlendAlpha(1);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::four_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 4; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h4 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(1);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::three_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 3; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h3 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(2);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::two_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 2; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h2 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(3);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::one_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 1; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h1 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(4);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function hearts_4::zero_hearts( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version) {
 //edit 03-01-2015 trying to make it so if youre out of the game you cant reset the cell number
 if ($screen_position_x == 100 & $screen_position_y == 0 & $seeing_the_game != 1 & % has_left_the_game_version == $has_left_the_game_version) { % this.in_cell = 0; % find_base_num = % this.num; % find_if_despawned = ("empty_char_space"
   @ % find_base_num).is_despawned;
  echo("h0 CHAR"
   @ % this.num @ ", %find_if_despawned="
   @ % find_if_despawned @ "VS 0, $world_numeral="
   @ $world_numeral @ " VS %identify_this_time_space="
   @ % identify_this_time_space @ ", $current_level="
   @ $current_level @ " VS %confirm_world_numeral="
   @ % confirm_world_numeral @ ", $round_restart_switch="
   @ $round_restart_switch @ " VS %round_restart_toggle="
   @ % round_restart_toggle);
  fix_reentry_on_level1_for_schedules();
  //check for post-scheduling using world and level comparators, incremented one back due to passing interference
  if ( % find_if_despawned != 1 & $world_numeral == % identify_this_time_space & $current_level == % confirm_world_numeral & $round_restart_switch == % round_restart_toggle) {
   echo("%identify_this_time_space = "
    @ % identify_this_time_space @ " %confirm_world_numeral = "
    @ % confirm_world_numeral @ " %confirm_round_numeral = "
    @ % confirm_round_numeral);
   if ($hearts_scheduled4 == 1) {
    hearts_4.setFrame(5);
   }
   if ($hearts_scheduled4 == 0) {
    hearts_4.setBlendAlpha(0);
   }
  }
 }
}

function change_entertainer_icon_for_order_menu() {

 //castle
 if ($world_numeral == 1) {
  if ($entertainer1_bought_world1 != 1) {
   entertainer_icon1.setImageMap(lute_player_playing3ImageMap);
   entertainer_icon1.setSize(9.570, 16.895);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 1;
  }

  if ($entertainer2_bought_world1 != 1) {
   entertainer_icon2.setImageMap(char_jester_juggle4ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 1;
  }
  if ($entertainer1_bought_world1 == 1) {
   entertainer_icon1.setImageMap(lute_player_playing3ImageMap);
   entertainer_icon1.setSize(9.570, 16.895);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 1;
  }

  if ($entertainer2_bought_world1 == 1) {
   entertainer_icon2.setImageMap(char_jester_juggle4ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 1;
  }
 }

 //swamp
 if ($world_numeral == 2) {
  if ($entertainer1_bought_world2 != 1) {
   entertainer_icon1.setImageMap(banjo_player_playingImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 2;
  }
  if ($entertainer2_bought_world2 != 1) {
   entertainer_icon2.setImageMap(swamp_harmonica2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 2;
  }
  if ($entertainer1_bought_world2 == 1) {
   entertainer_icon1.setImageMap(banjo_player_playingImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 2;
  }
  if ($entertainer2_bought_world2 == 1) {
   entertainer_icon2.setImageMap(swamp_harmonica2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 2;
  }
 }

 //airship
 if ($world_numeral == 3) {
  if ($entertainer1_bought_world3 != 1) {
   entertainer_icon1.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 3;
  }
  if ($entertainer2_bought_world3 != 1) {
   entertainer_icon2.setImageMap(employee_magician2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 3;
  }
  if ($entertainer1_bought_world3 == 1) {
   entertainer_icon1.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 3;
  }
  if ($entertainer2_bought_world3 == 1) {
   entertainer_icon2.setImageMap(employee_magician2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 3;
  }
 }

 //hawaii
 if ($world_numeral == 4) {
  if ($entertainer1_bought_world4 != 1) {
   entertainer_icon1.setImageMap(hula_dancer4ImageMap);
   entertainer_icon1.setSize(9.570, 16.895);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 4;
  }
  if ($entertainer2_bought_world4 != 1) {
   entertainer_icon2.setImageMap(hula_dancer4ImageMap);
   entertainer_icon2.setSize(9.570, 16.895);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 4;
  }
  if ($entertainer1_bought_world4 == 1) {
   entertainer_icon1.setImageMap(hula_dancer4ImageMap);
   entertainer_icon1.setSize(9.570, 16.895);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 4;
  }
  if ($entertainer2_bought_world4 == 1) {
   entertainer_icon2.setImageMap(hula_dancer4ImageMap);
   entertainer_icon2.setSize(9.570, 16.895);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 4;
  }
 }

 //mead hall
 if ($world_numeral == 5) {
  if ($entertainer1_bought_world5 != 1) {
   entertainer_icon1.setImageMap(viking_king3ImageMap);
   entertainer_icon1.setSize(11.816, 17.285);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 5;
  }
  if ($entertainer2_bought_world5 != 1) {
   entertainer_icon2.setImageMap(viking_king3ImageMap);
   entertainer_icon2.setSize(11.816, 17.285);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);		
   entertainer_icon2.on_world = 5;
  }
  if ($entertainer1_bought_world5 == 1) {
   entertainer_icon1.setImageMap(viking_king3ImageMap);
   entertainer_icon1.setSize(11.816, 17.285);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 5;
  }
  if ($entertainer2_bought_world5 == 1) {
   entertainer_icon2.setImageMap(viking_king3ImageMap);
   entertainer_icon2.setSize(11.816, 17.285);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);		
   entertainer_icon2.on_world = 5;
  }
 }

 //dark forest
 if ($world_numeral == 6) {
  if ($entertainer1_bought_world6 != 1) {
   entertainer_icon1.setImageMap(ghost_iconImageMap);
   entertainer_icon1.setSize(11.816, 17.285);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 6;
  }
  if ($entertainer2_bought_world6 != 1) {
   entertainer_icon2.setImageMap(ghost_iconImageMap);
   entertainer_icon2.setSize(11.816, 17.285);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 6;
  }
  if ($entertainer1_bought_world6 == 1) {
   entertainer_icon1.setImageMap(ghost_iconImageMap);
   entertainer_icon1.setSize(11.816, 17.285);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 6;
  }
  if ($entertainer2_bought_world6 == 1) {
   entertainer_icon2.setImageMap(ghost_iconImageMap);
   entertainer_icon2.setSize(11.816, 17.285);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 6;
  }
 }

 //train
 if ($world_numeral == 7) {
  if ($entertainer1_bought_world7 != 1) {
   entertainer_icon1.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 7;
  }
  if ($entertainer2_bought_world7 != 1) {
   entertainer_icon2.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 7;
  }
  if ($entertainer1_bought_world7 == 1) {
   entertainer_icon1.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 7;
  }
  if ($entertainer2_bought_world7 == 1) {
   entertainer_icon2.setImageMap(bellhop_bored2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 7;
  }
 }

 //france
 if ($world_numeral == 8) {
  if ($entertainer1_bought_world8 != 1) {
   entertainer_icon1.setImageMap(accordionist2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 8;
  }
  if ($entertainer2_bought_world8 != 1) {
   entertainer_icon2.setImageMap(employee_violinist2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 8;
  }
  if ($entertainer1_bought_world8 == 1) {
   entertainer_icon1.setImageMap(accordionist2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);
   entertainer_icon1.on_world = 8;
  }
  if ($entertainer2_bought_world8 == 1) {
   entertainer_icon2.setImageMap(employee_violinist2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 8;
  }
 }

 //big city
 if ($world_numeral == 9) {
  if ($entertainer1_bought_world9 != 1) {
   entertainer_icon1.setImageMap(beatnik_drum2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 9;
  }
  if ($entertainer2_bought_world9 != 1) {
   entertainer_icon2.setImageMap(employee_bassist2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 9;
  }
  if ($entertainer1_bought_world9 == 1) {
   entertainer_icon1.setImageMap(beatnik_drum2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 9;
  }
  if ($entertainer2_bought_world9 == 1) {
   entertainer_icon2.setImageMap(employee_bassist2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);	
   entertainer_icon2.on_world = 9;
  }
 }

 //hometown
 if ($world_numeral == 10) {
  if ($entertainer1_bought_world10 != 1) {
   entertainer_icon1.setImageMap(greaser_lean2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "1 1 1 1";
   entertainer1_cost.BlendColor = "1 1 1 1";
   entertainer1_tag.BlendColor = "1 1 1 1";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 10;
  }
  if ($entertainer2_bought_world10 != 1) {
   entertainer_icon2.setImageMap(employee_dancer2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "1 1 1 1";
   entertainer2_cost.BlendColor = "1 1 1 1";
   entertainer2_tag.BlendColor = "1 1 1 1";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 10;
  }
  if ($entertainer1_bought_world10 == 1) {
   entertainer_icon1.setImageMap(greaser_lean2ImageMap);
   entertainer_icon1.setSize(11.816, 17.188);
   entertainer_icon1.setPositionX(110.657);
   entertainer_icon1.setPositionY(142.960);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_cost.BlendColor = "0 0 0 0.25";
   entertainer1_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon1.setBlendAlpha(1);	
   entertainer_icon1.on_world = 10;
  }
  if ($entertainer2_bought_world10 == 1) {
   entertainer_icon2.setImageMap(employee_dancer2ImageMap);
   entertainer_icon2.setSize(11.816, 17.188);
   entertainer_icon2.setPositionX(135.643);
   entertainer_icon2.setPositionY(144.198);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_cost.BlendColor = "0 0 0 0.25";
   entertainer2_tag.BlendColor = "0 0 0 0.25";
   //entertainer_icon2.setBlendAlpha(1);
   entertainer_icon2.on_world = 10;
  }
 }
}

function entertainer_icon1::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 employee_info_display.setPositionX(100);
 employee_info_display.setPositionY(138);
 employee_info_display2.setPositionX(100.2);
 employee_info_display2.setPositionY(138.3);
 if ( % this.on_world == 1 & $entertainer1_bought_world1 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 2 & $entertainer1_bought_world2 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 3 & $entertainer1_bought_world3 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 4 & $entertainer1_bought_world4 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 5 & $entertainer1_bought_world5 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 6 & $entertainer1_bought_world6 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 7 & $entertainer1_bought_world7 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 8 & $entertainer1_bought_world8 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 9 & $entertainer1_bought_world9 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 10 & $entertainer1_bought_world10 != 1) {
  entertainer_icon1.BlendColor = "1 1 0 1";
 }
}

function entertainer_icon1::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 employee_info_display.setPositionX(139.729);
 employee_info_display.setPositionY(94.294);
 employee_info_display2.setPositionX(139.729);
 employee_info_display2.setPositionY(94.294);
 if ( % this.on_world == 1 & $entertainer1_bought_world1 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 2 & $entertainer1_bought_world2 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 3 & $entertainer1_bought_world3 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 4 & $entertainer1_bought_world4 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 5 & $entertainer1_bought_world5 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 6 & $entertainer1_bought_world6 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 7 & $entertainer1_bought_world7 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 8 & $entertainer1_bought_world8 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 9 & $entertainer1_bought_world9 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 10 & $entertainer1_bought_world10 != 1) {
  entertainer_icon1.BlendColor = "1 1 1 1";
  entertainer1_cost.BlendColor = "1 1 1 1";
 }
}

function entertainer_icon1::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.on_world == 1 & $coinage < $entertainer1_price_world1 & $entertainer1_bought_world1 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 2 & $coinage < $entertainer1_price_world2 & $entertainer1_bought_world2 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 3 & $coinage < $entertainer1_price_world3 & $entertainer1_bought_world3 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 4 & $coinage < $entertainer1_price_world4 & $entertainer1_bought_world4 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 5 & $coinage < $entertainer1_price_world5 & $entertainer1_bought_world5 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 6 & $coinage < $entertainer1_price_world6 & $entertainer1_bought_world6 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 7 & $coinage < $entertainer1_price_world7 & $entertainer1_bought_world7 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 8 & $coinage < $entertainer1_price_world8 & $entertainer1_bought_world8 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 9 & $coinage < $entertainer1_price_world9 & $entertainer1_bought_world9 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 10 & $coinage < $entertainer1_price_world10 & $entertainer1_bought_world10 != 1) {
  entertainer_icon1.BlendColor = "1 0 0 1";
  entertainer1_cost.BlendColor = "1 0 0 1";
 }
}

function entertainer_icon1::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

  if ( % this.on_world == 1 & $coinage >= $entertainer1_price_world1 & $entertainer1_bought_world1 != 1) {
   $coinage -= $entertainer1_price_world1;
   $employee_alpha1_world1 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world1);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world1 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 2 & $coinage >= $entertainer1_price_world2 & $entertainer1_bought_world2 != 1) {
   $coinage -= $entertainer1_price_world2;
   $employee_alpha1_world2 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world2);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world2 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 3 & $coinage >= $entertainer1_price_world3 & $entertainer1_bought_world3 != 1) {
   $coinage -= $entertainer1_price_world3;
   $employee_alpha1_world3 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world3);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world3 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 4 & $coinage >= $entertainer1_price_world4 & $entertainer1_bought_world4 != 1) {
   $coinage -= $entertainer1_price_world4;
   $employee_alpha1_world4 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world4);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world4 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 5 & $coinage >= $entertainer1_price_world5 & $entertainer1_bought_world5 != 1) {
   $coinage -= $entertainer1_price_world5;
   $employee_alpha1_world5 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world5);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world5 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 6 & $coinage >= $entertainer1_price_world6 & $entertainer1_bought_world6 != 1) {
   $coinage -= $entertainer1_price_world6;
   $employee_alpha1_world6 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world6);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world6 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 7 & $coinage >= $entertainer1_price_world7 & $entertainer1_bought_world7 != 1) {
   $coinage -= $entertainer1_price_world7;
   $employee_alpha1_world7 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world7);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world7 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 8 & $coinage >= $entertainer1_price_world8 & $entertainer1_bought_world8 != 1) {
   $coinage -= $entertainer1_price_world8;
   $employee_alpha1_world8 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world8);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world8 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 9 & $coinage >= $entertainer1_price_world9 & $entertainer1_bought_world9 != 1) {
   $coinage -= $entertainer1_price_world9;
   $employee_alpha1_world9 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world9);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world9 = 1;
   extra_person1.setBlendAlpha(1);
  }
  if ( % this.on_world == 10 & $coinage >= $entertainer1_price_world10 & $entertainer1_bought_world10 != 1) {
   $coinage -= $entertainer1_price_world10;
   $employee_alpha1_world10 = 1;
   entertainer_icon1.setBlendAlpha($employee_alpha1_world10);
   entertainer_icon1.BlendColor = "0 0 0 0.25";
   entertainer1_tag.setBlendAlpha(0.1);
   entertainer1_cost.setBlendAlpha(0.1);
   $entertainer1_bought_world10 = 1;
   extra_person1.setBlendAlpha(1);
  }
  menu_coinage_left.text = $coinage;
  _menu_coinage_left.text = $coinage;
  score_number.text = $coinage;
 }
}

/* ----------------------- ENTERTAINER ICON 2 ------------------------------- */

function entertainer_icon2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 employee_info_display.setPositionX(122);
 employee_info_display.setPositionY(140.262);
 employee_info_display2.setPositionX(122.2);
 employee_info_display2.setPositionY(140.562);
 if ( % this.on_world == 1 & $entertainer2_bought_world1 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 2 & $entertainer2_bought_world2 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 3 & $entertainer2_bought_world3 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 4 & $entertainer2_bought_world4 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 5 & $entertainer2_bought_world5 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 6 & $entertainer2_bought_world6 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 7 & $entertainer2_bought_world7 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 8 & $entertainer2_bought_world8 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 9 & $entertainer2_bought_world9 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
 if ( % this.on_world == 10 & $entertainer2_bought_world10 != 1) {
  entertainer_icon2.BlendColor = "1 1 0 1";
 }
}

function entertainer_icon2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 employee_info_display.setPositionX(139.729);
 employee_info_display.setPositionY(94.294);
 employee_info_display2.setPositionX(139.729);
 employee_info_display2.setPositionY(94.294);
 if ( % this.on_world == 1 & $entertainer2_bought_world1 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 2 & $entertainer2_bought_world2 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 3 & $entertainer2_bought_world3 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 4 & $entertainer2_bought_world4 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 5 & $entertainer2_bought_world5 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 6 & $entertainer2_bought_world6 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 7 & $entertainer2_bought_world7 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 8 & $entertainer2_bought_world8 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 9 & $entertainer2_bought_world9 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
 if ( % this.on_world == 10 & $entertainer2_bought_world10 != 1) {
  entertainer_icon2.BlendColor = "1 1 1 1";
  entertainer2_cost.BlendColor = "1 1 1 1";
 }
}

function entertainer_icon2::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.on_world == 1 & $coinage < $entertainer2_price_world1 & $entertainer2_bought_world1 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 2 & $coinage < $entertainer2_price_world2 & $entertainer2_bought_world2 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 3 & $coinage < $entertainer2_price_world3 & $entertainer2_bought_world3 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 4 & $coinage < $entertainer2_price_world4 & $entertainer2_bought_world4 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 5 & $coinage < $entertainer2_price_world5 & $entertainer2_bought_world5 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 6 & $coinage < $entertainer2_price_world6 & $entertainer2_bought_world6 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 7 & $coinage < $entertainer2_price_world7 & $entertainer2_bought_world7 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 8 & $coinage < $entertainer2_price_world8 & $entertainer2_bought_world8 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 9 & $coinage < $entertainer2_price_world9 & $entertainer2_bought_world9 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
 if ( % this.on_world == 10 & $coinage < $entertainer2_price_world10 & $entertainer2_bought_world10 != 1) {
  entertainer_icon2.BlendColor = "1 0 0 1";
  entertainer2_cost.BlendColor = "1 0 0 1";
 }
}

//entertainer icon 2
function entertainer_icon2::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ( % this.on_world == 1 & $coinage >= $entertainer2_price_world1 & $entertainer2_bought_world1 != 1) {
   $coinage -= $entertainer2_price_world1;
   $employee_alpha2_world1 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world1);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world1 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 2 & $coinage >= $entertainer2_price_world2 & $entertainer2_bought_world2 != 1) {
   $coinage -= $entertainer2_price_world2;
   $employee_alpha2_world2 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world2);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world2 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 3 & $coinage >= $entertainer2_price_world3 & $entertainer2_bought_world3 != 1) {
   $coinage -= $entertainer2_price_world3;
   $employee_alpha2_world3 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world3);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world3 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 4 & $coinage >= $entertainer2_price_world4 & $entertainer2_bought_world4 != 1) {
   $coinage -= $entertainer2_price_world4;
   $employee_alpha2_world4 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world4);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world4 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 5 & $coinage >= $entertainer2_price_world5 & $entertainer2_bought_world5 != 1) {
   $coinage -= $entertainer2_price_world5;
   $employee_alpha2_world5 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world5);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world5 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 6 & $coinage >= $entertainer2_price_world6 & $entertainer2_bought_world6 != 1) {
   $coinage -= $entertainer2_price_world6;
   $employee_alpha2_world6 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world6);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world6 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 7 & $coinage >= $entertainer2_price_world7 & $entertainer2_bought_world7 != 1) {
   $coinage -= $entertainer2_price_world7;
   $employee_alpha2_world7 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world7);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world7 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 8 & $coinage >= $entertainer2_price_world8 & $entertainer2_bought_world8 != 1) {
   $coinage -= $entertainer2_price_world8;
   $employee_alpha2_world8 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world8);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world8 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 9 & $coinage >= $entertainer2_price_world9 & $entertainer2_bought_world9 != 1) {
   $coinage -= $entertainer2_price_world9;
   $employee_alpha2_world9 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world9);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world9 = 1;
   extra_person2.setBlendAlpha(1);
  }
  if ( % this.on_world == 10 & $coinage >= $entertainer2_price_world10 & $entertainer2_bought_world10 != 1) {
   $coinage -= $entertainer2_price_world10;
   $employee_alpha2_world10 = 1;
   entertainer_icon2.setBlendAlpha($employee_alpha2_world10);
   entertainer_icon2.BlendColor = "0 0 0 0.25";
   entertainer2_tag.setBlendAlpha(0.1);
   entertainer2_cost.setBlendAlpha(0.1);
   $entertainer2_bought_world10 = 1;
   extra_person2.setBlendAlpha(1);
  }
  menu_coinage_left.text = $coinage;
  _menu_coinage_left.text = $coinage;
  score_number.text = $coinage;
 }
}


function find_all_entertainers_bought() {
 //This for save file recall

 if ($entertainer1_bought_world1 == 1) {
  $employee_alpha1_world1 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world1);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world2 == 1) {
  $employee_alpha1_world2 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world2);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world3 == 1) {
  $employee_alpha1_world3 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world3);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world4 == 1) {
  $coinage -= $entertainer1_price_world4;
  $employee_alpha1_world4 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world4);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world5 == 1) {
  $employee_alpha1_world5 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world5);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world6 == 1) {
  $employee_alpha1_world6 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world6);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world7 == 1) {
  $employee_alpha1_world7 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world7);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world8 == 1) {
  $employee_alpha1_world8 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world8);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world9 == 1) {
  $employee_alpha1_world9 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world9);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }
 if ($entertainer1_bought_world10 == 1) {
  $employee_alpha1_world10 = 1;
  entertainer_icon1.setBlendAlpha($employee_alpha1_world10);
  entertainer_icon1.BlendColor = "0 0 0 0.25";
  entertainer1_tag.setBlendAlpha(0.1);
  entertainer1_cost.setBlendAlpha(0.1);
  extra_person1.setBlendAlpha(1);
 }

 //employee 2
 if ($entertainer2_bought_world1 == 1) {
  $employee_alpha2_world1 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world1);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world2 == 1) {
  $employee_alpha2_world2 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world2);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world3 == 1) {
  $employee_alpha2_world3 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world3);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world4 == 1) {
  $employee_alpha2_world4 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world4);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world5 == 1) {
  $employee_alpha2_world5 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world5);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world6 == 1) {
  $employee_alpha2_world6 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world6);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world7 == 1) {
  $employee_alpha2_world7 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world7);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world8 == 1) {
  $employee_alpha2_world8 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world8);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world9 == 1) {
  $employee_alpha2_world9 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world9);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
 if ($entertainer2_bought_world10 == 1) {
  $employee_alpha2_world10 = 1;
  entertainer_icon2.setBlendAlpha($employee_alpha2_world10);
  entertainer_icon2.BlendColor = "0 0 0 0.25";
  entertainer2_tag.setBlendAlpha(0.1);
  entertainer2_cost.setBlendAlpha(0.1);
  extra_person2.setBlendAlpha(1);
 }
}

function set_entertainer_costs_at_start() {
 if ($world_numeral == 1) {
  entertainer1_cost.text = $entertainer1_price_world1;
  entertainer2_cost.text = $entertainer2_price_world1;
 }
 if ($world_numeral == 2) {
  entertainer1_cost.text = $entertainer1_price_world2;
  entertainer2_cost.text = $entertainer2_price_world2;
 }
 if ($world_numeral == 3) {
  entertainer1_cost.text = $entertainer1_price_world3;
  entertainer2_cost.text = $entertainer2_price_world3;
 }
 if ($world_numeral == 4) {
  entertainer1_cost.text = $entertainer1_price_world4;
  entertainer2_cost.text = $entertainer2_price_world4;
 }
 if ($world_numeral == 5) {
  entertainer1_cost.text = $entertainer1_price_world5;
  entertainer2_cost.text = $entertainer2_price_world5;
 }
 if ($world_numeral == 6) {
  entertainer1_cost.text = $entertainer1_price_world6;
  entertainer2_cost.text = $entertainer2_price_world6;
 }
 if ($world_numeral == 7) {
  entertainer1_cost.text = $entertainer1_price_world7;
  entertainer2_cost.text = $entertainer2_price_world7;
 }
 if ($world_numeral == 8) {
  entertainer1_cost.text = $entertainer1_price_world8;
  entertainer2_cost.text = $entertainer2_price_world8;
 }
 if ($world_numeral == 9) {
  entertainer1_cost.text = $entertainer1_price_world9;
  entertainer2_cost.text = $entertainer2_price_world9;
 }
 if ($world_numeral == 10) {
  entertainer1_cost.text = $entertainer1_price_world10;
  entertainer2_cost.text = $entertainer2_price_world10;
 }
}

function equalize_appetizers() {
 if ( % check_if_appetizer1_saved_less_than_ten < $appetizer_default_amount) {
  $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
  appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 }
 if ( % check_if_appetizer2_saved_less_than_ten < $appetizer_default_amount) {
  $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
  appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 }
}

function first_start_equalize_appetizers() {
 if ($world_numeral == 1 & $current_level == 1 & % check_if_appetizer1_saved_less_than_ten > $appetizer_default_amount) {
  $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
  appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 }
 if ($world_numeral == 1 & $current_level == 1 & % check_if_appetizer2_saved_less_than_ten > $appetizer_default_amount) {
  $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
  appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 }
}
//test if this breaks black error in weird startup
function prestart_ship::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { % this.setImageMap(bkgd_airship_finalImageMap);
}


/* OPTIONS BUTTONS FOR SCREEN TOGGLES AND MOUSE-TOUCHPAD STATES */
function button_options_window::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 1) { % this.setFrame(1);
  options_warning.text = "*This May Take a Few Seconds...";
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(1);
 }
}

function button_options_window::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 1) { % this.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_window::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($window_mode != 1) { % this.setFrame(2);
  }
 }
}

function button_options_window::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $window_mode = 1; % res = getDesktopResolution();
  $desktopWidth = getWord( % res, 0);
  $desktopHeight = getWord( % res, 1);
  $bpp = getWord( % res, 2);

  setScreenMode(1024, 768, $bpp, $fullScreen);
  $horizontal_scaling = 100;

  $screen_position_x = -200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
  if ($window_mode == 1) { % this.setFrame(3);
   button_options_full.setFrame(0);
   button_options_stretch.setFrame(0);
   button_options_stretchb.setFrame(0);

  }
 }
}

function button_options_full::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 99) { % this.setFrame(1);
 }
}

function button_options_full::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 99) { % this.setFrame(0);
 }
}

function button_options_full::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($window_mode != 99) { % this.setFrame(2);
  }
 }
}

function button_options_full::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $window_mode = 99; % res = getDesktopResolution();
  $desktopWidth = getWord( % res, 0);
  $desktopHeight = getWord( % res, 1);
  $bpp = getWord( % res, 2);

  setScreenMode($desktopWidth, $desktopHeight, $bpp, $fullScreen);
  $horizontal_scaling = 100;
  $screen_position_x = -200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);

  % this.setFrame(3);
  button_options_window.setFrame(0);
  button_options_stretch.setFrame(0);
  button_options_stretchb.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_stretch::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 2) { % this.setFrame(1);
  options_warning.text = "*This May Take a Few Seconds...";
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(1);
 }
}

function button_options_stretch::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 2) { % this.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_stretch::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($window_mode != 2) { % this.setFrame(2);
  }
 }
}

function button_options_stretch::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $window_mode = 2; % res = getDesktopResolution();
  $desktopWidth = getWord( % res, 0);
  $desktopHeight = getWord( % res, 1);
  $bpp = getWord( % res, 2);

  //setScreenMode(1024, 768, $bpp, $fullScreen);
  setScreenMode(1024, 768, $bpp, $Game::FullScreen);
  $horizontal_scaling = 100;
  $screen_position_x = -200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75); % this.setFrame(3);
  button_options_window.setFrame(0);
  button_options_full.setFrame(0);
  button_options_stretchb.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_stretchb::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 3) { % this.setFrame(1);
  options_warning.text = "*This May Take a Few Seconds...";
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(1);
 }
}

function button_options_stretchb::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($window_mode != 3) { % this.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_stretchb::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($window_mode != 3) { % this.setFrame(2);
  }
 }
}

function button_options_stretchb::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $window_mode = 3; % res = getDesktopResolution();
  $desktopWidth = getWord( % res, 0);
  $desktopHeight = getWord( % res, 1);
  $bpp = getWord( % res, 2);

  //setScreenMode(1024, 768, $bpp, $fullScreen);
  setScreenMode(1024, 768, $bpp, $Game::FullScreen);
  $horizontal_scaling = 125;
  $screen_position_x = -200;
  $screen_position_y = 150;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75); % this.setFrame(3);
  button_options_window.setFrame(0);
  button_options_stretch.setFrame(0);
  button_options_full.setFrame(0);
  options_warning.setPositionX(-199.911);
  options_warning.setBlendAlpha(0);
 }
}

function button_options_mouse::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 options_warning.text = "*This Will Reset The Current Level...";
 options_warning.setBlendAlpha(1);

 if ($touchpad_activated == 1) { % this.setFrame(1);
 }
}

function button_options_touchpad::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 options_warning.text = "*This Will Reset The Current Level...";
 options_warning.setBlendAlpha(1);

 if ($touchpad_activated == 0) { % this.setFrame(1);
 }
}

function button_options_mouse::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 options_warning.setBlendAlpha(0);
 if ($touchpad_activated == 1) { % this.setFrame(0);
 }
}

function button_options_touchpad::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 options_warning.setBlendAlpha(0);
 if ($touchpad_activated == 0) { % this.setFrame(0);
 }
}

function button_options_mouse::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($touchpad_activated == 1) { % this.setFrame(2);
  }
 }
}

function button_options_touchpad::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($touchpad_activated == 0) { % this.setFrame(2);
  }
 }
}

function button_options_mouse::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-10-2015 last last heart tranfer error
  //$either_mouse_or_touchpad_clicked = 1;
  $touchpad_activated = 0; % this.setFrame(3);
  button_options_touchpad.setFrame(0);
  $game_clock_limit = 40000;
  $game_clock_limit_01 = 40000;
  $game_clock_limit_02 = 38000;
  $game_clock_limit_03 = 36000;
  $game_clock_limit_04 = 34000;
  $game_clock_limit_05 = 33000;
  $game_clock_limit_06 = 32000;
  $game_clock_limit_07 = 31000;
  $game_clock_limit_08 = 30000;
  $game_clock_limit_09 = 28800;
  $game_clock_limit_10 = 27500;
  $changed_mouse_or_touchpad = 1;
 }
}

function button_options_touchpad::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-10-2015 last last heart tranfer error
  //$either_mouse_or_touchpad_clicked = 1;	
  $touchpad_activated = 1; % this.setFrame(3);
  button_options_mouse.setFrame(0);
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
  $changed_mouse_or_touchpad = 1;
 }
}

function activate_side_borders() {
 /*
 activate_side_borders();
 $screen_position_x = ;
 $screen_position_y = ;
 */
 hide_map_locks();
 side_border1.setSize(100, 75);
 side_border2.setSize(100, 75);
 $border1_x = $screen_position_x - 100;
 $border1_y = $screen_position_y;
 $border2_x = $screen_position_x + 100;
 $border2_y = $screen_position_y;
 side_border1.setPositionX($border1_x);
 side_border1.setPositionY($border1_y);
 side_border2.setPositionX($border2_x);
 side_border2.setPositionY($border2_y);

 if ($screen_position_x == -200 & $screen_position_y == 0) {
  $screen_locator = 1;
 }
 if ($screen_position_x == -100 & $screen_position_y == 0) {
  $screen_locator = 2;
 }
 if ($screen_position_x == 0 & $screen_position_y == 0) {
  $screen_locator = 3;
 }
 if ($screen_position_x == 100 & $screen_position_y == 0) {
  $screen_locator = 4;
 }
 if ($screen_position_x == -200 & $screen_position_y == 75) {
  $screen_locator = 5;
 }
 if ($screen_position_x == -100 & $screen_position_y == 75) {
  $screen_locator = 6;
 }
 if ($screen_position_x == 0 & $screen_position_y == 75) {
  $screen_locator = 7;
 }
 if ($screen_position_x == 100 & $screen_position_y == 75) {
  $screen_locator = 8;
 }
 if ($screen_position_x == -200 & $screen_position_y == 150) {
  $screen_locator = 9;
 }
 if ($screen_position_x == -100 & $screen_position_y == 150) {
  $screen_locator = 10;
 }
 if ($screen_position_x == 0 & $screen_position_y == 150) {
  $screen_locator = 11;
  reset_star_base();
 }
 if ($screen_position_x == 100 & $screen_position_y == 150) {
  $screen_locator = 12;
 }
 if ($screen_position_x == -200 & $screen_position_y == 225) {
  $screen_locator = 13;
 }
 if ($screen_position_x == -100 & $screen_position_y == 225) {
  $screen_locator = 14;
 }
 if ($screen_position_x == 0 & $screen_position_y == 225) {
  $screen_locator = 15;
 }
 if ($screen_position_x == 100 & $screen_position_y == 225) {
  $screen_locator = 16;
 }
}

function side_border1::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 /*
 if($MASTER_ALL_BUTTONS_DISABLED != 1)
 {
 */
 $MASTER_ALL_BUTTONS_DISABLED = 1;
 master_displayer.text = $MASTER_ALL_BUTTONS_DISABLED;
}

function side_border2::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 $MASTER_ALL_BUTTONS_DISABLED = 1;
 master_displayer.text = $MASTER_ALL_BUTTONS_DISABLED;
}

function side_border1::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $MASTER_ALL_BUTTONS_DISABLED = 0;
 master_displayer.text = $MASTER_ALL_BUTTONS_DISABLED;
}

function side_border2::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 $MASTER_ALL_BUTTONS_DISABLED = 0;
 master_displayer.text = $MASTER_ALL_BUTTONS_DISABLED;
}

function disable_screen1() {
 $disable_screen1 = 1;
}

function skip_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($world_numeral == 11) {
  $temp_lock_skip_numeral11 = 0;
 } % this.setFrame(1);
}

function skip_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {

 % this.setFrame(1);

}

function skip_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { % this.setFrame(0);
}

function comptroller::turn_off_ui_glow1() {
 box_points.setFrame(0);
}

function comptroller::turn_off_ui_glow2() {
 box_score.setFrame(0);
}

function hide_map_locks() {
 mapsel_lock.setPositionX(9999);
 mapsel_lock.setPositionY(9999);
}

function sched_cancel_chars_and_waiters() {
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV sched_cancel_chars_and_waiters VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV sched_cancel_chars_and_waiters VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV sched_cancel_chars_and_waiters VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 sched_cancel_cooks();

 cancel($char_sched_01);
 cancel($char_sched_02);
 cancel($char_sched_03);
 cancel($char_sched_04);
 cancel($char_sched_05);
 cancel($char_sched_06);
 cancel($char_sched_07);
 cancel($char_sched_08);
 cancel($char_sched_09);

 cancel($waiter_sched_01);
 cancel($waiter_sched_02);
 cancel($waiter_sched_03);
 cancel($waiter_sched_04);
 cancel($waiter_sched_05);
 cancel($waiter_sched_06);
 cancel($waiter_sched_07);
 cancel($waiter_sched_08);
 cancel($waiter_sched_09);
 cancel($waiter_sched_10);
 cancel($waiter_sched_11);
 cancel($waiter_sched_12);
 cancel($waiter_sched_13);
 cancel($waiter_sched_14);
 cancel($waiter_sched_15);
 cancel($waiter_sched_16);
 cancel($waiter_sched_17);
 cancel($waiter_sched_18);
 cancel($waiter_sched_19);
 cancel($waiter_sched_20);
 cancel($waiter_sched_21);
 cancel($waiter_sched_22);
 cancel($waiter_sched_23);
 cancel($waiter_sched_24);
}

function sched_cancel_all() {
 //edit 02-22-2015 fixes error but also kills all hearts
 //all new heats problems spawn from here
 if ($hearts_disable_from_coin_tip != 1) {
  if ($world_numeral != 1) {
   //$no_hearts_at_all = 1;
  }
  //hearts_1.setBlendAlpha(1);
 }
 //edit 02-22-2015 exceptions from coin tip
 $hearts_disable_from_coin_tip = 0;
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV sched_cancel_all VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 cancel($comptroller_starter_sched_1);

 cancel($hearts_sched_5a);
 cancel($hearts_sched_4a);
 cancel($hearts_sched_3a);
 cancel($hearts_sched_2a);
 cancel($hearts_sched_1a);
 cancel($hearts_sched_0a);

 cancel($hearts_sched_5b);
 cancel($hearts_sched_4b);
 cancel($hearts_sched_3b);
 cancel($hearts_sched_2b);
 cancel($hearts_sched_1b);
 cancel($hearts_sched_0b);

 cancel($hearts_sched_5c);
 cancel($hearts_sched_4c);
 cancel($hearts_sched_3c);
 cancel($hearts_sched_2c);
 cancel($hearts_sched_1c);
 cancel($hearts_sched_0c);

 cancel($hearts_sched_5d);
 cancel($hearts_sched_4d);
 cancel($hearts_sched_3d);
 cancel($hearts_sched_2d);
 cancel($hearts_sched_1d);
 cancel($hearts_sched_0d);

 hearts_1.setBlendAlpha(0);
 hearts_2.setBlendAlpha(0);
 hearts_3.setBlendAlpha(0);
 hearts_4.setBlendAlpha(0);

 cancel($fly_sched_01);
 cancel($fly_sched_02);
 cancel($fly_sched_03);
 cancel($fly_sched_04);
 cancel($fly_sched_05);
 cancel($fly_sched_06);
 cancel($fly_sched_07);
 cancel($fly_sched_08);
 cancel($fly_sched_09);
 cancel($fly_sched_10);
 cancel($fly_sched_11);
 cancel($fly_sched_12);
 cancel($fly_sched_13);
 cancel($fly_sched_14);
 cancel($fly_sched_15);
 cancel($fly_sched_16);
 cancel($fly_sched_17);
 cancel($fly_sched_18);
 cancel($fly_sched_19);
 cancel($fly_sched_20);
 cancel($fly_sched_21);
 cancel($fly_sched_22);
 cancel($fly_sched_23);
 cancel($fly_sched_24);
 cancel($fly_sched_25);
 cancel($fly_sched_26);
 cancel($fly_sched_27);
 cancel($fly_sched_28);
 cancel($fly_sched_29);
 cancel($fly_sched_30);
 cancel($fly_sched_31);
 cancel($fly_sched_32);
 cancel($fly_sched_33);
 cancel($fly_sched_34);
 cancel($fly_sched_35);
 cancel($fly_sched_36);
 cancel($fly_sched_37);
 cancel($fly_sched_38);
 cancel($fly_sched_39);
 cancel($fly_sched_40);
 cancel($fly_sched_41);
 cancel($fly_sched_42);
 cancel($fly_sched_43);
 cancel($fly_sched_44);
 cancel($fly_sched_45);
 cancel($fly_sched_46);
 cancel($fly_sched_47);
 cancel($fly_sched_48);
 cancel($fly_sched_49);
 cancel($fly_sched_50);
 cancel($fly_sched_51);
 cancel($fly_sched_52);
 cancel($fly_sched_53);
 cancel($fly_sched_54);
 cancel($fly_sched_55);
 cancel($fly_sched_56);
 cancel($fly_sched_57);
 cancel($fly_sched_58);
 cancel($fly_sched_59);
 cancel($fly_sched_60);
 cancel($fly_sched_61);
 cancel($fly_sched_62);

 flying_coin.setPositionX(155.153);
 flying_coin.setPositionY(-9.813);
 flying_coin2.setPositionX(109.762);
 flying_coin2.setPositionY(-40.715);

 cancel($bonus_sched_01);
 cancel($bonus_sched_02);
 cancel($bonus_sched_03);
 cancel($bonus_sched_04);
 cancel($bonus_sched_05);
 cancel($bonus_sched_06);
 cancel($bonus_sched_07);
 cancel($bonus_sched_08);
 cancel($bonus_sched_09);
 cancel($bonus_sched_10);
 cancel($bonus_sched_11);
 cancel($bonus_sched_12);
 cancel($bonus_sched_13);
 cancel($bonus_sched_14);
 cancel($bonus_sched_15);
 cancel($bonus_sched_16);
 cancel($bonus_sched_17);
 cancel($bonus_sched_18);
 cancel($bonus_sched_19);
 cancel($bonus_sched_20);
 cancel($bonus_sched_21);
 cancel($bonus_sched_22);
 cancel($bonus_sched_23);
 cancel($bonus_sched_24);
 cancel($bonus_sched_25);
 cancel($bonus_sched_26);
 cancel($bonus_sched_27);
 cancel($bonus_sched_28);
 cancel($bonus_sched_29);
 cancel($bonus_sched_30);
 cancel($bonus_sched_31);
 cancel($bonus_sched_32);
 cancel($bonus_sched_33);
 cancel($bonus_sched_34);
 cancel($bonus_sched_35);
 cancel($bonus_sched_36);
 cancel($bonus_sched_37);
 cancel($bonus_sched_38);
 cancel($bonus_sched_39);
 cancel($bonus_sched_40);
 cancel($bonus_sched_41);
 cancel($bonus_sched_42);
 cancel($bonus_sched_43);
 cancel($bonus_sched_44);
 cancel($bonus_sched_45);
 cancel($bonus_sched_46);
 cancel($bonus_sched_47);
 cancel($bonus_sched_48);
 cancel($bonus_sched_49);
 cancel($bonus_sched_50);
 cancel($bonus_sched_51);
 cancel($bonus_sched_52);
 cancel($bonus_sched_53);
 cancel($bonus_sched_54);
 cancel($bonus_sched_55);
 cancel($bonus_sched_56);
 cancel($bonus_sched_57);
 cancel($bonus_sched_58);
 cancel($bonus_sched_59);
 cancel($bonus_sched_60);
 cancel($bonus_sched_61);
 cancel($bonus_sched_62);
 cancel($bonus_sched_63);
 cancel($bonus_sched_64);
 cancel($bonus_sched_65);
 cancel($bonus_sched_66);
 cancel($bonus_sched_67);
 cancel($bonus_sched_68);
 cancel($bonus_sched_69);
 cancel($bonus_sched_70);
 cancel($bonus_sched_71);
 cancel($bonus_sched_72);
 cancel($bonus_sched_73);
 cancel($bonus_sched_74);
 cancel($bonus_sched_75);
 cancel($bonus_sched_76);
 cancel($bonus_sched_77);
 cancel($bonus_sched_78);
 cancel($bonus_sched_79);
 cancel($bonus_sched_80);
 cancel($bonus_sched_81);

 cancel($fxi_sched_01);
 cancel($fxi_sched_02);
 cancel($fxi_sched_03);
 cancel($fxi_sched_04);
 cancel($fxi_sched_05);
 cancel($fxi_sched_06);
 cancel($fxi_sched_07);
 cancel($fxi_sched_08);
 cancel($fxi_sched_09);
 cancel($fxi_sched_10);
 cancel($fxi_sched_11);
 cancel($fxi_sched_12);
 cancel($fxi_sched_13);
 cancel($fxi_sched_14);
 cancel($fxi_sched_15);
 cancel($fxi_sched_16);
 cancel($fxi_sched_17);
 cancel($fxi_sched_18);
 cancel($fxi_sched_19);
 cancel($fxi_sched_20);
 cancel($fxi_sched_21);
 cancel($fxi_sched_22);
 cancel($fxi_sched_23);
 cancel($fxi_sched_24);
 cancel($fxi_sched_25);
 cancel($fxi_sched_26);
 //shorebreak fx
 //edit 02-21-2015 Already in cancel fx, this causes redundancy errors so clipping
 /*
 cancel($fxi_sched_27);
 cancel($fxi_sched_28);
 cancel($fxi_sched_29);
 cancel($fxi_sched_30);
 cancel($fxi_sched_31);
 */
 bonus_portal1.bonus_extra_portal_end_all();
}

function cancel_any_lingering_fx() {
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV cancel_any_lingering_fx VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV cancel_any_lingering_fx VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 echo("VVVVVVVVVVVVVVVVVVVVVVVVVVVVV cancel_any_lingering_fx VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
 cancel($fxi_sched_01);
 cancel($fxi_sched_02);
 cancel($fxi_sched_03);
 cancel($fxi_sched_04);
 cancel($fxi_sched_05);
 cancel($fxi_sched_06);
 cancel($fxi_sched_07);
 cancel($fxi_sched_08);
 cancel($fxi_sched_09);
 cancel($fxi_sched_10);
 cancel($fxi_sched_11);
 cancel($fxi_sched_12);
 cancel($fxi_sched_13);
 cancel($fxi_sched_14);
 cancel($fxi_sched_15);
 cancel($fxi_sched_16);
 cancel($fxi_sched_17);
 cancel($fxi_sched_18);
 cancel($fxi_sched_19);
 cancel($fxi_sched_20);
 cancel($fxi_sched_21);
 cancel($fxi_sched_22);
 cancel($fxi_sched_23);
 cancel($fxi_sched_24);
 cancel($fxi_sched_25);
 cancel($fxi_sched_26);
 //shorebreak
 cancel($fxi_sched_27);
 cancel($fxi_sched_28);
 cancel($fxi_sched_29);
 cancel($fxi_sched_30);
 cancel($fxi_sched_31);
}

function fix_any_levsel_errors() {
 //fix any black levsels that happen
 if ($maximum_level_player_got_to <= 1) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
 }
 if ($maximum_level_player_got_to == 2) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
 }
 if ($maximum_level_player_got_to == 3) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
 }
 if ($maximum_level_player_got_to == 4) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
 }
 if ($maximum_level_player_got_to == 5) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
 }
 if ($maximum_level_player_got_to == 6) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
  levsel_6.unlocked = 1;
  levsel_6.setFrame(0);
 }
 if ($maximum_level_player_got_to == 7) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
  levsel_6.unlocked = 1;
  levsel_6.setFrame(0);
  levsel_7.unlocked = 1;
  levsel_7.setFrame(0);
 }
 if ($maximum_level_player_got_to == 8) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
  levsel_6.unlocked = 1;
  levsel_6.setFrame(0);
  levsel_7.unlocked = 1;
  levsel_7.setFrame(0);
  levsel_8.unlocked = 1;
  levsel_8.setFrame(0);
 }
 if ($maximum_level_player_got_to == 9) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
  levsel_6.unlocked = 1;
  levsel_6.setFrame(0);
  levsel_7.unlocked = 1;
  levsel_7.setFrame(0);
  levsel_8.unlocked = 1;
  levsel_8.setFrame(0);
  levsel_9.unlocked = 1;
  levsel_9.setFrame(0);
 }
 if ($maximum_level_player_got_to > 9) {
  levsel_1.unlocked = 1;
  levsel_1.setFrame(0);
  levsel_2.unlocked = 1;
  levsel_2.setFrame(0);
  levsel_3.unlocked = 1;
  levsel_3.setFrame(0);
  levsel_4.unlocked = 1;
  levsel_4.setFrame(0);
  levsel_5.unlocked = 1;
  levsel_5.setFrame(0);
  levsel_6.unlocked = 1;
  levsel_6.setFrame(0);
  levsel_7.unlocked = 1;
  levsel_7.setFrame(0);
  levsel_8.unlocked = 1;
  levsel_8.setFrame(0);
  levsel_9.unlocked = 1;
  levsel_9.setFrame(0);
  levsel_10.unlocked = 1;
  levsel_10.setFrame(0);
 }
}

function make_sure_fruits_are_enabled_after_tut() {
 //all
 $tut_char_fruit_choices = 0;
 $until_tut_char_is_activated_dont_do_fruits = 0;
 $disable_ui_and_rgbp_swap = 0;
 $disable_all_remaining_fruit_ui = 0;
 $skip_the_rest_of_this_because_tutorial = 0;
 //green
 $tut_iterate_green = 0;
 $disable_tut_green_part = 0;
 $make_kiwi_the_only_pickable_fruit = 0;
 $completely_unlock_second_fruit_iterator = 0;
 //red
 $tut_iterate_red = 0;
 $make_cherry_the_only_pickable_fruit = 0;
 $disable_tut_red_part = 0;
 //orange
 $lock_down_isolater_mask_part_i_to_ii = 0;
 $completely_unlock_first_fruit_iterator = 0;
 $lock_down_first_fruit_iterator = 0;
 $tut_iterate_orange = 0;
 $toggle_off_orange_fruit_for_tut = 0;
 //yellow	
 $tut_iterate_yellow = 0;
 $toggle_off_yellow_fruit_for_tut = 0;

}

function view_main() {
 sceneWindow2D.setCurrentCameraPosition("100 0 100 75");
}

function view_boards() {
 sceneWindow2D.setCurrentCameraPosition("-100 150 100 75");
}

function view_mm() {
 sceneWindow2D.setCurrentCameraPosition("0 0 100 75");
}

function reset_fruit_cycle_order() {
 $fruit_frame = 0;
 button_red_fruit.setFrame(0);
 button_yellow_fruit.setFrame(0);
 button_orange_fruit.setFrame(0);
 button_green_fruit.setFrame(0);
 button_blue_fruit.setFrame(0);
 button_purple_fruit.setFrame(0);
}

function start_tutorial_proper() {
 sched_cancel_all();
 reset_fruit_cycle_order();
 $NEW_sodajerk_number = 1;
 //$fruit_frame = 3;
 //ui_button_swap.onMouseDown();
 $isolater_mask_spawn_once_only = 0;
 $tut_yes_is_active = 0;
 $lock_down_isolater_mask_part_i_to_ii = 0;
 $toggle_off_alpha_in = 0;
 $toggle_off_fade_out_one_and_part_two_in = 0;
 $disable_ui_and_rgbp_swap = 0;
 $tutorial_activate_cook_sequence = 0;
 $activate_tutorial_serve_char_sequence = 0;
 $tutorial_activate_tip_sequence = 0;
 $activate_tutorial_cointip = 0;
 $activate_tut_cointip_portion = 0;
 $toggle_off_default_tut_statement = 0;
 $tutorial_activate_extra_sequence = 0;
 $tut_char_fruit_choices = 0;
 $tut_go_to_fruits = 0;
 $cease_masking_of_dial = 0;
 $skip_the_rest_of_this_because_tutorial = 0;
 $tutorial_end_fading_bs = 0;
 $end_the_tutorial = 0;
 $tut_text_alpha = 1;
 $until_tut_char_is_activated_dont_do_fruits = 0;
 $tut_make_cancelling_impossible = 0;
 $toggle_tut_appetizer = 0;
 $lock_down_retoggling_during_tutorial = 0;
 $disable_all_clicks_of_chars_via_tutorial = 0;
 $its_okay_to_click_tutchar1 = 0;
 $toggle_off_orange_fruit_for_tut = 0;
 $toggle_off_yellow_fruit_for_tut = 0;
 $tut_make_reclicking_drink_out_impossible = 0;
 $tut_coin_tip_override = 0;
 $tut_toggle_off_drink_out = 0;
 $disable_all_remaining_fruit_ui = 0;
 $tut_toggle_off_cook = 0;
 $tut_iterate_yellow = 0;
 $tut_iterate_orange = 0;
 $tut_iterate_red = 0;
 $tut_iterate_green = 0;
 $disable_tut_red_part = 0;
 $disable_tut_green_part = 0;
 $completely_unlock_first_fruit_iterator = 0;
 $completely_unlock_second_fruit_iterator = 0;
 $unlock_subtle_red_mouseover = 0;
 $tutorial_popup_officially_ended_via_yes_or_no = 0;
 $wait_for_tut_drink_out_fader_to_finish = 0;
 $tut_fade_maximum = 0.5;
 $disable_tutorial_clicker = 0;
 $disable_reenabling_pointer_clicker_red = 0;
 $disable_reenabling_pointer_clicker_green = 0;
 $make_cherry_the_only_pickable_fruit = 0;
 $make_kiwi_the_only_pickable_fruit = 0;
 $lock_the_cook_for_tutorial = 0;
 $activate_continuing_tutorial = 0;
 $lock_down_first_fruit_iterator = 0;
 $hint_bonus1_disabled = 0;
 $hint_bonus2_disabled = 0;
 $hint_bonus3_disabled = 0;
 $temporarily_disable_ingame_options_before_tutorial = 0;
 $cancel_event_shittt = 0;
 $do_final_tutorial_part_only_once = 0;
 $tut_new_revised = 0;
 $end_previous_non_new_tut_bits = 0;
 $tut_appetizer1_active = 0;
 $tut_appetizer1_clicked = 0;
 $tut_very_last_char_clicked = 0;
 $toggle_off_om_appetizer_buttons_because_tut_ext = 0;
 $toggle_off_om_awards_button_because_tut_ext = 0;
 $toggle_off_om_map_button_because_tut_ext = 0;
 $toggle_off_om_continue_button_because_tut_ext = 0;
 $toggle_off_button_levsel_menu_because_tut_ext = 0;
 $toggle_off_button_levsel_map_because_tut_ext = 0;
 $tut_ext_segment = 0;
 //extras found...
 $tut_toggle_new_appetizer = 0;
 $tut_appetizers_part_b = 0;
 $tut_very_last_part = 0;
 $tut_very_last_part_completely = 0;
}

function reset_star_base() {
 $star_sys_medal_won = 3;
 gold_clock_limit_says.text = "reset_star_base";
 silver_clock_limit_says.text = 0;
 bronze_clock_limit_says.text = 0;
}

function fix_reentry_on_level1_for_schedules() {
 if ($round_numeral == 1 & $current_level == 2) {
  $current_level = 1;
 }
}

function sched_cancel_cooks() {
 cancel($cook_sched_01);
 cancel($cook_sched_02);
 cancel($cook_sched_03);
 cancel($cook_sched_04);
 cancel($cook_sched_05);
 cancel($cook_sched_06);
 cancel($cook_sched_07);
 cancel($cook_sched_08);
 cancel($cook_sched_09);
 cancel($cook_sched_10);
 cancel($cook_sched_11);
 cancel($cook_sched_12);
 cancel($cook_sched_13);
 cancel($cook_sched_14);
 cancel($cook_sched_15);
 cancel($cook_sched_16);
 cancel($cook_sched_17);
 cancel($cook_sched_18);
 cancel($cook_sched_19);
 cancel($cook_sched_20);

 sodajerk1.schedule(0, "just_idle", 0);
 sodajerk2.schedule(0, "just_idle", 0);
 sodajerk3.schedule(0, "just_idle", 0);
 sodajerk4.schedule(0, "just_idle", 0);

 cook_wait1.setAnimation(empty_char_spaceAnimation);
 cook_wait2.setAnimation(empty_char_spaceAnimation);
 cook_wait3.setAnimation(empty_char_spaceAnimation);
 cook_wait4.setAnimation(empty_char_spaceAnimation);

 flying_coin.setBlendAlpha(0);
 flying_coin2.setBlendAlpha(0);
}

function hide_any_coin_flyers() {
 flying_coin.setBlendAlpha(0);
 flying_coin2.setBlendAlpha(0);
}

function hard_pause() {

 $game_is_hard_paused = 1;
 $end_the_clock = 1;
 $game_has_started_for_clock = 0;
 //edit 01-27-2015 fx stopping error -two parts-
 //echo($special_char_already_used)
 if ($special_char_already_used != 1) {
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 1 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 1 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");
  echo(">>>>>>>>>> >>>>>>>>>>> >>>>>>>>>>> FX BUG FROM HERE 1 SCHED CANCEL <<<<<<<<<< <<<<<<<<<<<<< <<<<<<<<<<");

  sched_cancel_all();
 }
 sched_cancel_cooks();
 sched_cancel_chars_and_waiters();

 empty_char_space1.toggle_off_star_timer = 1;
 empty_char_space2.toggle_off_star_timer = 1;
 empty_char_space3.toggle_off_star_timer = 1;
 empty_char_space4.toggle_off_star_timer = 1;
 cancel($star_timer_sched_1);
 cancel($star_timer_sched_2);
 cancel($star_timer_sched_3);
 cancel($star_timer_sched_4);

 if (sodajerk1.is_being_used == 1) {
  sodajerk1.hard_paused = 1;
  if (sodajerk1.in_cell == 1) {
   sodajerk1.hard_pause_in_cell = 1;
  }
  if (sodajerk1.in_cell == 2) {
   sodajerk1.hard_pause_in_cell = 2;
  }
  if (sodajerk1.in_cell == 3) {
   sodajerk1.hard_pause_in_cell = 3;
  }
  if (sodajerk1.in_cell == 4) {
   sodajerk1.hard_pause_in_cell = 4;
  }
  if (sodajerk1.in_cell == 5) {
   sodajerk1.hard_pause_in_cell = 5;
  }
 }
 if (sodajerk2.is_being_used == 1) {
  sodajerk2.hard_paused = 1;
  if (sodajerk2.in_cell == 1) {
   sodajerk2.hard_pause_in_cell = 1;
  }
  if (sodajerk2.in_cell == 2) {
   sodajerk2.hard_pause_in_cell = 2;
  }
  if (sodajerk2.in_cell == 3) {
   sodajerk2.hard_pause_in_cell = 3;
  }
  if (sodajerk2.in_cell == 4) {
   sodajerk2.hard_pause_in_cell = 4;
  }
  if (sodajerk2.in_cell == 5) {
   sodajerk2.hard_pause_in_cell = 5;
  }
 }
 if (sodajerk3.is_being_used == 1) {
  sodajerk3.hard_paused = 1;
  if (sodajerk3.in_cell == 1) {
   sodajerk3.hard_pause_in_cell = 1;
  }
  if (sodajerk3.in_cell == 2) {
   sodajerk3.hard_pause_in_cell = 2;
  }
  if (sodajerk3.in_cell == 3) {
   sodajerk3.hard_pause_in_cell = 3;
  }
  if (sodajerk3.in_cell == 4) {
   sodajerk3.hard_pause_in_cell = 4;
  }
  if (sodajerk3.in_cell == 5) {
   sodajerk3.hard_pause_in_cell = 5;
  }
 }
 if (sodajerk4.is_being_used == 1) {
  sodajerk4.hard_paused = 1;
  if (sodajerk4.in_cell == 1) {
   sodajerk4.hard_pause_in_cell = 1;
  }
  if (sodajerk4.in_cell == 2) {
   sodajerk4.hard_pause_in_cell = 2;
  }
  if (sodajerk4.in_cell == 3) {
   sodajerk4.hard_pause_in_cell = 3;
  }
  if (sodajerk4.in_cell == 4) {
   sodajerk4.hard_pause_in_cell = 4;
  }
  if (sodajerk4.in_cell == 5) {
   sodajerk4.hard_pause_in_cell = 5;
  }
 }

 if (sodajerk1.is_being_used == 0) {
  sodajerk1.hard_paused = 0;
 }
 if (sodajerk2.is_being_used == 0) {
  sodajerk2.hard_paused = 0;
 }
 if (sodajerk3.is_being_used == 0) {
  sodajerk3.hard_paused = 0;
 }
 if (sodajerk4.is_being_used == 0) {
  sodajerk4.hard_paused = 0;
 }

 display_hp_sj1.text = sodajerk1.hard_paused;
 display_hp_sj2.text = sodajerk2.hard_paused;
 display_hp_sj3.text = sodajerk3.hard_paused;
 display_hp_sj4.text = sodajerk4.hard_paused;

 if (empty_char_space1.despawned != 1 & empty_char_space1.has_been_spawned == 1) {
  empty_char_space1.hard_paused = 1;
 }
 if (empty_char_space2.despawned != 1 & empty_char_space2.has_been_spawned == 1) {
  empty_char_space2.hard_paused = 1;
 }
 if (empty_char_space3.despawned != 1 & empty_char_space3.has_been_spawned == 1) {
  empty_char_space3.hard_paused = 1;
 }
 if (empty_char_space4.despawned != 1 & empty_char_space4.has_been_spawned == 1) {
  empty_char_space4.hard_paused = 1;
 }

 if (empty_char_space1.despawned == 1 & empty_char_space1.has_been_spawned != 1) {
  empty_char_space1.hard_paused = 0;
 }
 if (empty_char_space2.despawned == 1 & empty_char_space2.has_been_spawned != 1) {
  empty_char_space2.hard_paused = 0;
 }
 if (empty_char_space3.despawned == 1 & empty_char_space3.has_been_spawned != 1) {
  empty_char_space3.hard_paused = 0;
 }
 if (empty_char_space4.despawned == 1 & empty_char_space4.has_been_spawned != 1) {
  empty_char_space4.hard_paused = 0;
 }

 if (empty_char_space1.in_cell_anger == 1) {
  empty_char_space1.hard_paused_anger = 1;
 }
 if (empty_char_space2.in_cell_anger == 1) {
  empty_char_space2.hard_paused_anger = 1;
 }
 if (empty_char_space3.in_cell_anger == 1) {
  empty_char_space3.hard_paused_anger = 1;
 }
 if (empty_char_space4.in_cell_anger == 1) {
  empty_char_space4.hard_paused_anger = 1;
 }


 check_the_numbas.text = $global_char_identify_based_on_spawn.seat_num;
}

function hard_unpause() {
 //edit 03-10-2015 either_mouse_or_touchpad_clicked
 if ($either_mouse_or_touchpad_clicked != 1) {
  $game_is_hard_paused = 0;
  $end_the_clock = 0;
  echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ F");
  $game_has_started_for_clock = 1;
  //hearts1
  //hearts_1.setBlendAlpha(1);
  check_the_numbas.text = $global_char_identify_based_on_spawn.seat_num;

  empty_char_space1.toggle_off_star_timer = 0;
  empty_char_space2.toggle_off_star_timer = 0;
  empty_char_space3.toggle_off_star_timer = 0;
  empty_char_space4.toggle_off_star_timer = 0;
  empty_char_space1.set_star_timer();
  test_case3.text = "activated C 1";
  empty_char_space2.set_star_timer();
  empty_char_space3.set_star_timer();
  empty_char_space4.set_star_timer();

  $NEW_sodajerk_number = 1;
  /*
  sodajerk1.hard_paused = 0;
  sodajerk2.hard_paused = 0;
  sodajerk3.hard_paused = 0;
  sodajerk4.hard_paused = 0;
  */
  if (sodajerk1.is_being_used == 1) {
   $NEW_sodajerk_number = 1;
   inform_cooks();
  }
  if (sodajerk2.is_being_used == 1) {
   $NEW_sodajerk_number = 2;
   inform_cooks();
  }
  if (sodajerk3.is_being_used == 1) {
   $NEW_sodajerk_number = 3;
   inform_cooks();
  }
  if (sodajerk4.is_being_used == 1) {
   $NEW_sodajerk_number = 4;
   inform_cooks();
  }
  //$NEW_sodajerk_number
  //inform_cooks();
  /* find_last_hearts_amount_for_char1 */
  echo("SPAWNING VIA HARD PAUSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
  echo("SPAWNING VIA HARD PAUSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
  echo("SPAWNING VIA HARD PAUSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

  if (empty_char_space1.hard_paused == 1 & empty_char_space1.despawned != 1) {
   echo(">>>>>>>>>><><><><><><><<><>< SPAWN CHAR 1 VIA HARD UNPAUSE <><><>><<>><<<<<<<<<<<<<<<<<<<<<<");
   echo(">>>>>>>>>><><><><><><><<><>< SPAWN CHAR 1 VIA HARD UNPAUSE <><><>><<>><<<<<<<<<<<<<<<<<<<<<<");
   echo(">>>>>>>>>><><><><><><><<><>< SPAWN CHAR 1 VIA HARD UNPAUSE <><><>><<>><<<<<<<<<<<<<<<<<<<<<<");
   empty_char_space1.spawn_char_new();
  }
  if (empty_char_space2.hard_paused == 1 & empty_char_space2.despawned != 1) {
   empty_char_space2.spawn_char_new();
  }
  if (empty_char_space3.hard_paused == 1 & empty_char_space3.despawned != 1) {
   empty_char_space3.spawn_char_new();
  }
  if (empty_char_space4.hard_paused == 1 & empty_char_space4.despawned != 1) {
   empty_char_space4.spawn_char_new();
  }

  if (waiter1.in_cell == 1) {
   display_waiter_cells.text = "1";
   display_waiter_stars.text = % pass_char_data_locally.star_points;
   $waiter_sched_01 = waiter1.schedule(10, "start_waiter_part4", 0);
   $waiter_sched_02 = waiter1.schedule(5540, "activate_clicking_on_waiter_when_theyre_not_busy", 0);
  }
  if (waiter1.in_cell == 2) {
   display_waiter_cells.text = "2";
   display_waiter_stars.text = % pass_char_data_locally.star_points;
   //echo(empty_char_space1.star_points);
   % pass_char_data_locally = $char_for_hard_pause;
   $waiter_sched_12 = waiter1.schedule(400, "end_waiter", % pass_char_data_locally);
   $waiter_sched_13 = waiter1.schedule(5000, "wait_for_char_to_finish", % pass_char_data_locally);
   //needs to go to approval
  }
  if (waiter1.in_cell == 3) {
   display_waiter_cells.text = "3";
   display_waiter_stars.text = % pass_char_data_locally.star_points; % pass_char_data_locally = $char_for_hard_pause; % delay_limit = $game_clock_limit / 2;
   $waiter_sched_17 = % pass_char_data_locally.schedule( % delay_limit, "undelay_any_reteleports", 0);
   //star spawners
   $waiter_sched_24 = waiter1.schedule(3000, "wait_for_char_to_pay", % pass_char_data_locally);
  }

  if (empty_char_space1.in_cell_anger == 1) {
   empty_char_space1.hard_paused_anger = 0; % clock_limit_anger = $game_clock_limit / 4;
   empty_char_space1.schedule( % clock_limit_anger, "deteleport", 0);
  }
  if (empty_char_space2.in_cell_anger == 1) {
   empty_char_space2.hard_paused_anger = 0; % clock_limit_anger = $game_clock_limit / 4;
   empty_char_space2.schedule( % clock_limit_anger, "deteleport", 0);
  }
  if (empty_char_space3.in_cell_anger == 1) {
   empty_char_space3.hard_paused_anger = 0; % clock_limit_anger = $game_clock_limit / 4;
   empty_char_space3.schedule( % clock_limit_anger, "deteleport", 0);
  }
  if (empty_char_space4.in_cell_anger == 1) {
   empty_char_space4.hard_paused_anger = 0; % clock_limit_anger = $game_clock_limit / 4;
   empty_char_space4.schedule( % clock_limit_anger, "deteleport", 0);
  }
 }
}

function check_for_employee_bonus() {
 if ($entertainer1_bought_world[$world_numeral] == 1) {
  $employee1_bonus_points = 10;
  point_up_bonus_space.setAnimation(fx_point_up1bAnimation);
 }
 if ($entertainer2_bought_world[$world_numeral] == 1) {
  $employee2_bonus_points = 10;
  point_up_bonus_space2.setAnimation(fx_point_up1bAnimation);
 }
 if ($entertainer1_bought_world[$world_numeral] != 1) {
  $employee1_bonus_points = 0;
 }
 if ($entertainer2_bought_world[$world_numeral] != 1) {
  $employee2_bonus_points = 0;
 }
}

function comptroller::delay_schedules_start_in() {
 //echo($end_the_clock);
 $end_the_clock = 0;
 echo(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>$end_the_clock = 0 @ G"); % new_customer_idle_animation = "char_witchdoctor_idleAnimation";
 empty_char_space1.setAnimation( % new_customer_idle_animation); % new_customer_width = $width_customer1; % new_customer_height = $height_customer1;
 empty_char_space1.setSize( % new_customer_width, % new_customer_height);
 empty_char_space1.is_despawned = 0;
 empty_char_space1.occupied = 1;
 obj_teleport1.setAnimation(teleportAnimation);
 empty_char_space1.star_timer = 0;
 empty_char_space1.star_points = 0;
}

function erase_hard_pause_data() {
 empty_char_space1.hard_paused = 0;
 empty_char_space2.hard_paused = 0;
 empty_char_space3.hard_paused = 0;
 empty_char_space4.hard_paused = 0;
 waiter1.in_cell = 0;
}

function green_light_chars() {
 /*
 //test function
 	empty_char_space1.green_light_star_timer = 1;
 	empty_char_space2.green_light_star_timer = 1;
 	empty_char_space3.green_light_star_timer = 1;
 	empty_char_space4.green_light_star_timer = 1;	
 */
}

function re_alpha_the_hearts() {
 if (empty_char_space1.is_despawned == 0) {
  hearts_1.setBlendAlpha(1);
 }
 if (empty_char_space2.is_despawned == 0) {
  hearts_2.setBlendAlpha(1);
 }
 if (empty_char_space3.is_despawned == 0) {
  hearts_3.setBlendAlpha(1);
 }
 if (empty_char_space4.is_despawned == 0) {
  hearts_4.setBlendAlpha(1);
 }
}

function erase_usage_of_cooks() {
 sodajerk1.is_being_used = 0;
 sodajerk2.is_being_used = 0;
 sodajerk3.is_being_used = 0;
 sodajerk4.is_being_used = 0;
 sodajerk1.hard_paused = 0;
 sodajerk2.hard_paused = 0;
 sodajerk3.hard_paused = 0;
 sodajerk4.hard_paused = 0;
 $decide_drink_part1 = 0;
 $decide_drink_part2 = 0;
 $ingredients_drink_part1 = 0;
 $ingredients_drink_part2 = 0;
}

function clear_employee_alphas() {
 $employee_alpha1_world1 = 0;
 $employee_alpha2_world1 = 0;
 $employee_alpha1_world2 = 0;
 $employee_alpha2_world2 = 0;
 $employee_alpha1_world3 = 0;
 $employee_alpha2_world3 = 0;
 $employee_alpha1_world4 = 0;
 $employee_alpha2_world4 = 0;
 $employee_alpha1_world5 = 0;
 $employee_alpha2_world5 = 0;
 $employee_alpha1_world6 = 0;
 $employee_alpha2_world6 = 0;
 $employee_alpha1_world7 = 0;
 $employee_alpha2_world7 = 0;
 $employee_alpha1_world8 = 0;
 $employee_alpha2_world8 = 0;
 $employee_alpha1_world9 = 0;
 $employee_alpha2_world9 = 0;
 $employee_alpha1_world10 = 0;
 $employee_alpha2_world10 = 0;
}

function should_we_hard_start_the_clock() {
 //edit 01-04-2015
 if ($world_numeral == 1 & $round_numeral == 1) {
  $ignore_hard_start_clock = 1;
 }
 if ($world_numeral == 1 & $round_numeral > 1) {
  $ignore_hard_start_clock = 0;
 }
 if ($world_numeral > 1) {
  $ignore_hard_start_clock = 0;
 }
 if ($ignore_hard_start_clock == 0) {
  $end_the_clock = 0;
 }

}

function should_we_skip_ending_fx() {
 echo("should_we_skip_ending_fx..... ?");
 //426
 if ($world_numeral == 1 & $round_numeral == 1) {
  $skip_ending_fx = 1;
 }
 if ($world_numeral == 1 & $round_numeral > 1) {
  $skip_ending_fx = 0;
 }
 if ($world_numeral > 1) {
  $skip_ending_fx = 0;
 }
}

function comptroller::special_storyboard_lock_for_world11_credits() {
 $temp_lock_skip_numeral11 = 0;
}

function see_game() {
 //$seeing_the_game = 1;
 $screen_position_x = 100;
 $screen_position_y = 0;
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 black_stretch.setBlendAlpha(0);
 black_stretch2.setBlendAlpha(0);
 black_stretch3.setBlendAlpha(0);
 black_box1.setBlendAlpha(0);
 side_border1.setBlendAlpha(0);
 side_border2.setBlendAlpha(0);
 hearts_1.setBlendAlpha(1);
 hearts_2.setBlendAlpha(1);
 hearts_3.setBlendAlpha(1);
 hearts_4.setBlendAlpha(1);
}

function cancel_the_hearts() {

 //"hearts_1!! it doesnt know which char it is currently going to do?"
 hearts_1.in_cell = 5;
 hearts_2.in_cell = 5;
 hearts_3.in_cell = 5;
 hearts_4.in_cell = 5;
 echo( % this.seat_num);
 cancel($hearts_sched_5a);
 cancel($hearts_sched_4a);
 cancel($hearts_sched_3a);
 cancel($hearts_sched_2a);
 cancel($hearts_sched_1a);
 cancel($hearts_sched_0a);

 cancel($hearts_sched_5b);
 cancel($hearts_sched_4b);
 cancel($hearts_sched_3b);
 cancel($hearts_sched_2b);
 cancel($hearts_sched_1b);
 cancel($hearts_sched_0b);

 cancel($hearts_sched_5c);
 cancel($hearts_sched_4c);
 cancel($hearts_sched_3c);
 cancel($hearts_sched_2c);
 cancel($hearts_sched_1c);
 cancel($hearts_sched_0c);

 cancel($hearts_sched_5d);
 cancel($hearts_sched_4d);
 cancel($hearts_sched_3d);
 cancel($hearts_sched_2d);
 cancel($hearts_sched_1d);
 cancel($hearts_sched_0d);

}

//edit 03-03-2015 fruit switching error 
function SceneWindow2D::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 echo("SceneWindow2D onMouseUp");
 if ($disable_fruits_temporarily_due_to_swap_mousedown_error == 1) {
  button_swap.AutoRotation = 0;
  button_swap.Rotation = 0;
  button_swap.BlendColor = "1 1 1 1";

  button_red_fruit.setFrame($fruit_frame);
  button_yellow_fruit.setFrame($fruit_frame);
  button_orange_fruit.setFrame($fruit_frame);
  button_green_fruit.setFrame($fruit_frame);
  button_blue_fruit.setFrame($fruit_frame);
  button_purple_fruit.setFrame($fruit_frame);
  $disable_fruits_temporarily_due_to_swap_mousedown_error = 0;
 }
}

//edit 03-15-2015 making sure if cup isnt active, cup shouldnt be visible
function make_sure_dirty_cups_are_gone() {
 if (dirty_extra_cup1.active != 1) {
  dirty_extra_cup1.setBlendAlpha(0);
 }
 if (dirty_extra_cup2.active != 1) {
  dirty_extra_cup2.setBlendAlpha(0);
 }
 if (dirty_extra_cup3.active != 1) {
  dirty_extra_cup3.setBlendAlpha(0);
 }
 if (dirty_extra_cup4.active != 1) {
  dirty_extra_cup4.setBlendAlpha(0);
 }
}