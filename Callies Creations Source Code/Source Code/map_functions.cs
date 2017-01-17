// ***************************************************************************************
// File Name:   map_functions.cs
// Author:      Roger Campbell 
// Purpose:     All functions for the world map screen
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function map_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $world_numeral != 11) {
  if ($toggle_off_om_map_button_because_tut_ext < 1) { % this.setBlendAlpha(0);
  }
 }
}

function map_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_om_map_button_because_tut_ext < 1 & $world_numeral != 11) { % this.setBlendAlpha(0);
 }
}

function map_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_off_om_map_button_because_tut_ext != 1 & $world_numeral != 11) { % this.setBlendAlpha(1);
 }
}

function map_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($world_numeral == 11) {
  //do nothing, prevent errors related to exiting before very end
 }
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $world_numeral != 11) {
  //edit 03-22-2014 specific case where you beat 10 rounds of a level, then click on map_button instead of goto_levsel
  correct_for_dot_iterator_via_map_button();
  //edit 06-10-2014 making all situations work
  $allow_clicking_on_map = 1;
  $world_numeral = $maximum_world_player_got_to;
  $current_level = $maximum_level_player_got_to;
  //and everything else...
  if ($toggle_off_om_map_button_because_tut_ext < 1) { % this.setBlendAlpha(0);
   $default_audio = "map_theme";
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }

   $toggle_from_map_button = 1;
   $screen_position_x = 0;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75); 
   % this.schedule(200, "iterate_dots", 0);
  }
  if ($toggle_off_om_map_button_because_tut_ext == 2) { 
   % this.setBlendAlpha(0);
   $default_audio = "map_theme";
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   $toggle_from_map_button = 1;
   $screen_position_x = 0;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75); 
   % this.schedule(200, "iterate_dots", 0);
   //and then tutorial extended
   start_tut_ext_segment7();
  }
 }
}

function map_button::iterate_dots( % this) {
 if ($map_dot_iterater < $map_dot_max) {
  $map_dot_iterater += 1;

  //If map dot is map_dot01 through map_dot09 for 0 based numbers
  if ($map_dot_iterater < 10) { % map_dot_name = "map_dot0"
   @ $map_dot_iterater; % map_dot_name.setFrame(1);
   echo( % map_dot_name);
  }

  //If map dot is map_dot10 and up	
  if ($map_dot_iterater >= 10) { % map_dot_name = "map_dot"
   @ $map_dot_iterater; % map_dot_name.setFrame(1);
  }
  map_button.schedule(300, "iterate_dots", 0);
 }
 if ($map_dot_iterater >= $map_dot_max) {
  //stop
 }
}

function start_with_the_map() {
 $default_audio = "map_theme";
 alxStopAll();
 if ($toggle_mute_music != 1) {
  alxPlay($default_audio);
 }
 the_entire_map.schedule(500, "delay_clicking_on_map", 0);
 $screen_position_x = 0;
 $screen_position_y = 150;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 map_button.schedule(200, "iterate_dots", 0);
 echo("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX CLOCK HAS BEEN ENDED XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
 $end_the_clock = 1;
}

function the_entire_map::delay_clicking_on_map( % this) {
 $allow_clicking_on_map = 1;
}

function the_entire_map::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //to storyboards, then in-game
  if ($allow_clicking_on_map == 1) {
   $screen_position_x = -100;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   $allow_clicking_on_map = 0;
   which_allow.text = 1;
  }

  //to menu
  if ($toggle_from_map_button == 1) {
   $default_audio = "mainmenu_theme";
   alxStopAll();
   if ($toggle_mute_music != 1) {
    alxPlay($default_audio);
   }
   $screen_position_x = 100;
   $screen_position_y = 150;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   $toggle_from_map_button = 0;
  }
 }
}