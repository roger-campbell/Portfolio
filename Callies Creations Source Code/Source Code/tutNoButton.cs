// ***************************************************************************************
// File Name:   tutNoButton.cs
// Author:      Roger Campbell 
// Purpose:     "No" Button during tutorial mode (disables all tutorial sequences) 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function tut_no_button::onAdd( % this) {

 $tutorial_options_finished = 0;
 // enable mouse events for the mole so we can easily determine when it is clicked on
 % this.setUseMouseEvents(true);
 $current_round_number = 1;
}

function tut_yes_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { 
% this.setFrame("1");
}

function tut_no_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { 
% this.setFrame("1");
}

function tut_no_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { 
% this.setFrame("0");
}

function tut_yes_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { 
% this.setFrame("0");
}

function tut_yes_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { 
 % this.setFrame("2");
 }
}

function tut_no_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
 % this.setFrame("2");
 }
}

function tut_no_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  echo("-------PRELIMINARY MOUSE UP ON TUT NO--------------------------------------------------------------------------------------------------------------------------");
  $end_the_clock = 0;
  if ($toggle_delay_the_tutorial == 2) { % this.setFrame("0");
   if ($mute_soundfx != 1) {
    alxPlay(blipAudio);
   }
   //edit 12-24-2014 Delete pre-existing hearts data for character 1 due to BACK BETA 10-01-2014a
   cancel($hearts_sched_5a);
   cancel($hearts_sched_4a);
   cancel($hearts_sched_3a);
   cancel($hearts_sched_2a);
   cancel($hearts_sched_1a);
   cancel($hearts_sched_0a);

   //edit 12-24-2014 Redefine all vars for hearts for character 1 due to BACK BETA 10-01-2014a			
   % time_frame_calc = $game_clock_limit / 5; 
   % time_frame_1 = % time_frame_calc * 1; 
   % time_frame_2 = % time_frame_calc * 2;
   % time_frame_3 = % time_frame_calc * 3; 
   % time_frame_4 = % time_frame_calc * 4; 
   % time_frame_5 = % time_frame_calc * 5; 
   % identify_this_time_space = $world_numeral; 
   % confirm_world_numeral = $round_numeral; 
   % confirm_round_numeral = 0; 
   % round_restart_toggle = $round_restart_switch;
   //edit 03-01-2015 adding another bit of data to pass
   % has_left_the_game_version = $has_left_the_game_version;

   //edit 12-24-2014 Restart all hearts for character 1 due to BACK BETA 10-01-2014a		

   $hearts_sched_5a = hearts_1.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   $hearts_sched_4a = hearts_1.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   $hearts_sched_3a = hearts_1.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   $hearts_sched_2a = hearts_1.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   $hearts_sched_1a = hearts_1.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   $hearts_sched_0a = hearts_1.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
   hearts_1.setBlendAlpha(1);
   path_tut.setSpeed(tutorial_box1, -60);
   path_round_num.setSpeed(round_num, 30);
   round_digit1.setFrame(0);
   round_digit2.setFrame(1);
   empty_char_space1.setAnimation(char_queen3_idleAnimation);
   empty_char_space1.setSize(9.57, 16.895);
   empty_char_space1.is_despawned = 0;
   empty_char_space1.occupied = 1;
   obj_teleport1.setAnimation(teleportAnimation);
   tut_no_button.schedule(10, "delay_starting_game", 0);
   empty_char_space1.star_timer = 0;
   empty_char_space1.star_points = 0;
   prestarter_black.setPositionX(-200);
   prestarter_black.setPositionY(75);
   $tutorial_popup_officially_ended_via_yes_or_no = 1;
   isolater_mask.turn_back_on_fruit_dial();
  }
  //re-enable options buttons
  button_options_ingame.BlendColor = "1 1 1 1";
  $temporarily_disable_ingame_options_before_tutorial = 0;
 }
}

function tut_yes_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  sched_cancel_all();
  echo("-------PRELIMINARY MOUSE UP ON TUT YES--------------------------------------------------------------------------------------------------------------------------");
  $end_the_clock = 0;
  if ($toggle_delay_the_tutorial == 2) {
   start_tutorial_proper();
   //edit 01-24-2014 resets char clock with new char limiters for tutorial start
   $tutorial_popup_officially_ended_via_yes_or_no = 1;
   $game_clock_number = 0;
   $game_has_started_for_clock = 1;
   //edit 01-24-2014 makes the fruit dial active for tutorial related BS
   isolater_mask.turn_back_on_fruit_dial();

   % this.setFrame("0");
   $tut_char_fruit_choices = 1;
   $game_has_started_for_clock = 0;
   $toggle_initial_spawner_via_clock = 1;
   $game_clock_number = 0;
   if ($mute_soundfx != 1) {
    alxPlay(blipAudio);
   }
   path_tut.setSpeed(tutorial_box1, -60); % snapshot_scene_time_info = monster_shake.getSceneTime();
   $globalize_scene_time_start = % snapshot_scene_time_info;
   isolater_mask.BlendColor = "1 1 1 0";
   $isolater_mask_alpha = 0;
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.alpha_in();
   $tut_yes_is_active = 1;
   $until_tut_char_is_activated_dont_do_fruits = 1;
   $lock_down_retoggling_during_tutorial = 1;
   $disable_all_clicks_of_chars_via_tutorial = 1;
   prestarter_black.setPositionX(-200);
   prestarter_black.setPositionY(75);
   tab_cancel1.setBlendAlpha(0);
   tutorial_bar.setBlendAlpha(1);
   tutorial_bar2.setBlendAlpha(1);
  }
 }
}

function tut_no_button::delay_starting_game() {
 $tutorial_options_finished = 1;
}