// ***************************************************************************************
// File Name:   level_fx.cs
// Author:      Roger Campbell 
// Purpose:     All effects, particles and dynamic animations
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

/* Main Menu Background FX */
function main_menu_bkgd::start_animations() {
 if ($toggle_off_main_menu_bkgd_on_mouse_move != 1) {

  $main_menu_animation_timer = 0;
  main_menu_bkgd.setBlendAlpha(0);
  main_menu_bkgd.activate_animations();
  $toggle_off_main_menu_bkgd_on_mouse_move = 1;
  $toggle_confetti_storm = 0;
 }
}

function main_menu_bkgd::activate_animations() {
 if ($toggle_confetti_storm != 1) {
  confetti_storm.setEffectLifeMode(STOP, 2.0);
  confetti_storm.playEffect();
  $toggle_confetti_storm = 1;
 }

 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 1) {
  sub_main_menu_bkgd.setImageMap(bkgd_hometown_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_castle_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 2) {
  sub_main_menu_bkgd.setImageMap(bkgd_castle_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_swamp_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 3) {
  sub_main_menu_bkgd.setImageMap(bkgd_swamp_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_airship01ImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 4) {
  sub_main_menu_bkgd.setImageMap(bkgd_airship01ImageMap);
  main_menu_bkgd.setImageMap(bkgd_hawaii_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 5) {
  sub_main_menu_bkgd.setImageMap(bkgd_hawaii_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_meadhall_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 6) {
  sub_main_menu_bkgd.setImageMap(bkgd_meadhall_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_haunted_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 7) {
  sub_main_menu_bkgd.setImageMap(bkgd_haunted_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_train_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 8) {
  sub_main_menu_bkgd.setImageMap(bkgd_train_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_france_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 9) {
  sub_main_menu_bkgd.setImageMap(bkgd_france_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_metro_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 if ($main_menu_animation_timer >= 0 & $main_menu_animation_timer <= 1 & $toggle_world == 10) {
  sub_main_menu_bkgd.setImageMap(bkgd_metro_finalImageMap);
  main_menu_bkgd.setImageMap(bkgd_hometown_finalImageMap);
  main_menu_bkgd.setBlendAlpha($main_menu_animation_timer);
 }
 //timers-faders-repeaters
 if ($main_menu_animation_timer > 1 & $toggle_world < 10) {
  $main_menu_animation_timer = 0;
  $toggle_world += 1;
 }
 if ($main_menu_animation_timer > 1 & $toggle_world >= 10) {
  $main_menu_animation_timer = 0;
  $toggle_world = 1;
 }

 $main_menu_animation_timer += 0.02;
 main_menu_bkgd.schedule(100, "activate_animations", 0);
}

/* Main Menu Buttons MOVING ON SCREEN FX */
/* MM_LOGO BOUNCE ANIMATION TEST */

function mm_logo::onAdd( % this) {
 if ($prof1_info == 1) {
  mm_logo.schedule(1000, "delay_in", 0);
  mm_callie.schedule(1100, "delay_in", 0);
  mm_start_button.schedule(1200, "delay_in", 0);
  button_options.schedule(1300, "delay_in", 0);
  mm_exit_button.schedule(1350, "delay_in", 0);
  mm_profile_button.schedule(1375, "delay_in", 0);
 }
}

function mm_logo::delay_in( % this) {

 $mm_logo_athis_x = -1.659;
 $mm_logo_athis_y = -21.585; % this.moveTo($mm_logo_athis_x, $mm_logo_athis_y, 60, true, true, true, 0.1);
 mm_logo.schedule(10, "check_first_y_position", 0);
}

//dynamic scheduling for delay_in to bounce
function mm_logo::check_first_y_position( % this) { % this_y = mm_logo.getPositionY();
 if ( % this_y >= $mm_logo_athis_y) {
  mm_logo.schedule(10, "bounce", 0);
 }
 if ( % this_y < $mm_logo_athis_y) {
  mm_logo.schedule(10, "check_first_y_position", 0);
 }
}

function mm_logo::bounce( % this) {
 $mm_logo_athis_y2 = -22.585; % this.moveTo($mm_logo_athis_x, $mm_logo_athis_y2, 30, true, true, true, 0.1);
 mm_logo.schedule(10, "check_first_y_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function mm_logo::check_first_y_position2( % this) { % this_y = mm_logo.getPositionY();
 if ( % this_y >= $mm_logo_athis_y2) {
  mm_logo.schedule(10, "bounce2", 0);
 }
 if ( % this_y < $mm_logo_athis_y2) {
  mm_logo.schedule(10, "check_first_y_position2", 0);
 }
}

function mm_logo::bounce2( % this) {
 $mm_logo_athis_y = -21.585; % this.moveTo($mm_logo_athis_x, $mm_logo_athis_y, 30, true, true, true, 0.1);
}

/* MM_CALLIE BOUNCE ANIMATION TEST */
function mm_callie::onAdd( % this) {
 if ($prof1_info == 1) {
  mm_callie.schedule(1100, "delay_in", 0);
 }
}

function mm_callie::delay_in( % this) {

 $mm_callie_athis_x = -30.580;
 $mm_callie_athis_y = 7.907; % this.moveTo($mm_callie_athis_x, $mm_callie_athis_y, 60, true, true, true, 0.1);
 mm_callie.schedule(10, "check_first_x_position", 0);
}

//dynamic scheduling for delay_in to bounce
function mm_callie::check_first_x_position( % this) { % this_x = mm_callie.getPositionX();
 if ( % this_x >= $mm_callie_athis_x) {
  mm_callie.schedule(10, "bounce", 0);
 }
 if ( % this_x < $mm_callie_athis_x) {
  mm_callie.schedule(10, "check_first_x_position", 0);
 }
}

function mm_callie::bounce( % this) {
 $mm_callie_athis_x2 = -29.580; % this.moveTo($mm_callie_athis_x2, $mm_callie_athis_y, 30, true, true, true, 0.1);
 mm_callie.schedule(10, "check_first_x_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function mm_callie::check_first_x_position2( % this) { % this_x = mm_callie.getPositionX();
 if ( % this_x <= $mm_callie_athis_x2) {
  mm_callie.schedule(10, "bounce2", 0);
 }
 if ( % this_x > $mm_callie_athis_x2) {
  mm_callie.schedule(10, "check_first_x_position2", 0);
 }
}

function mm_callie::bounce2( % this) {
 $mm_callie_athis_x = -30.580; % this.moveTo($mm_callie_athis_x, $mm_callie_athis_y, 30, true, true, true, 0.1);
 //mm_callie.schedule(10, "check_first_y_position2", 0);
}


///////////////////////////////////////////////////////////////////
/* MM_START_BUTTON BOUNCE ANIMATION TEST */

function mm_start_button::delay_in( % this) {

 $mm_start_button_athis_x = 30.458;
 $mm_start_button_athis_y = 1.076; % this.moveTo($mm_start_button_athis_x, $mm_start_button_athis_y, 60, true, true, true, 0.1);
 mm_start_button.schedule(10, "check_first_x_position", 0);
}

//dynamic scheduling for delay_in to bounce
function mm_start_button::check_first_x_position( % this) { % this_x = mm_start_button.getPositionX();
 if ( % this_x <= $mm_start_button_athis_x) {
  mm_start_button.schedule(10, "bounce", 0);
 }
 if ( % this_x > $mm_start_button_athis_x) {
  mm_start_button.schedule(10, "check_first_x_position", 0);
 }
}

function mm_start_button::bounce( % this) {
 $mm_start_button_athis_x2 = 31.458; % this.moveTo($mm_start_button_athis_x2, $mm_start_button_athis_y, 30, true, true, true, 0.1);
 mm_start_button.schedule(10, "check_first_x_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function mm_start_button::check_first_x_position2( % this) { % this_x = mm_start_button.getPositionX();
 if ( % this_x >= $mm_start_button_athis_x2) {
  mm_start_button.schedule(10, "bounce2", 0);
 }
 if ( % this_x < $mm_start_button_athis_x2) {
  mm_start_button.schedule(10, "check_first_x_position2", 0);
 }
}

function mm_start_button::bounce2( % this) {
 $mm_start_button_x = 30.458; % this.moveTo($mm_start_button_athis_x, $mm_start_button_athis_y, 30, true, true, true, 0.1);
 $mm_start_completed = 1;
}

/* MM_OPTIONS_BUTTON BOUNCE ANIMATION TEST */

function button_options::delay_in( % this) {
 $button_options_button_athis_x = 30.458;
 $button_options_button_athis_y = 11.716; % this.moveTo($button_options_button_athis_x, $button_options_button_athis_y, 60, true, true, true, 0.1);
 button_options.schedule(10, "check_first_x_position", 0);
}

//dynamic scheduling for delay_in to bounce
function button_options::check_first_x_position( % this) { % this_x = button_options.getPositionX();
 if ( % this_x <= $button_options_button_athis_x) {
  button_options.schedule(10, "bounce", 0);
 }
 if ( % this_x > $button_options_button_athis_x) {
  button_options.schedule(10, "check_first_x_position", 0);
 }
}

function button_options::bounce( % this) {
 $button_options_button_athis_x2 = 31.458; % this.moveTo($button_options_button_athis_x2, $button_options_button_athis_y, 30, true, true, true, 0.1);
 button_options.schedule(10, "check_first_x_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function button_options::check_first_x_position2( % this) { % this_x = button_options.getPositionX();
 if ( % this_x >= $button_options_button_athis_x2) {
  button_options.schedule(10, "bounce2", 0);
 }
 if ( % this_x < $button_options_button_athis_x2) {
  button_options.schedule(10, "check_first_x_position2", 0);
 }
}

function button_options::bounce2( % this) {
 $button_options_athis_x = 30.458; % this.moveTo($button_options_button_athis_x, $button_options_button_athis_y, 30, true, true, true, 0.1);
 //button_options.schedule(10, "check_first_y_position2", 0);
 $mm_options_completed = 1;
}

/* MM_EXIT_BUTTON BOUNCE ANIMATION TEST */

function mm_exit_button::delay_in( % this) {
 $mm_exit_button_athis_x = 30.458;
 $mm_exit_button_athis_y = 22.375; % this.moveTo($mm_exit_button_athis_x, $mm_exit_button_athis_y, 60, true, true, true, 0.1);
 mm_exit_button.schedule(10, "check_first_x_position", 0);
}

//dynamic scheduling for delay_in to bounce
function mm_exit_button::check_first_x_position( % this) { % this_x = mm_exit_button.getPositionX();
 if ( % this_x <= $mm_exit_button_athis_x) {
  mm_exit_button.schedule(10, "bounce", 0);
 }
 if ( % this_x > $mm_exit_button_athis_x) {
  mm_exit_button.schedule(10, "check_first_x_position", 0);
 }
}

function mm_exit_button::bounce( % this) {
 $mm_exit_button_athis_x2 = 31.458; % this.moveTo($mm_exit_button_athis_x2, $mm_exit_button_athis_y, 30, true, true, true, 0.1);
 mm_exit_button.schedule(10, "check_first_x_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function mm_exit_button::check_first_x_position2( % this) { % this_x = mm_exit_button.getPositionX();
 if ( % this_x >= $mm_exit_button_athis_x2) {
  mm_exit_button.schedule(10, "bounce2", 0);
 }
 if ( % this_x < $mm_exit_button_athis_x2) {
  mm_exit_button.schedule(10, "check_first_x_position2", 0);
 }
}

function mm_exit_button::bounce2( % this) {
 $mm_exit_button = 30.458; % this.moveTo($mm_exit_button_athis_x, $mm_exit_button_athis_y, 30, true, true, true, 0.1);
 $mm_exit_completed = 1;
}

/* MM_PROFILE_BUTTON BOUNCE ANIMATION TEST */

function mm_profile_button::delay_in( % this) {

 $mm_profile_button_athis_x = 30.026;
 $mm_profile_button_athis_y = 31.004; % this.moveTo($mm_profile_button_athis_x, $mm_profile_button_athis_y, 60, true, true, true, 0.1);
 mm_profile_button.schedule(10, "check_first_x_position", 0);
}

//dynamic scheduling for delay_in to bounce
function mm_profile_button::check_first_x_position( % this) { % this_x = mm_profile_button.getPositionX();
 if ( % this_x <= $mm_profile_button_athis_x) {
  mm_profile_button.schedule(10, "bounce", 0);
 }
 if ( % this_x > $mm_profile_button_athis_x) {
  mm_profile_button.schedule(10, "check_first_x_position", 0);
 }
}

function mm_profile_button::bounce( % this) {
 $mm_profile_button_athis_x2 = 31.026; % this.moveTo($mm_profile_button_athis_x2, $mm_profile_button_athis_y, 30, true, true, true, 0.1);
 mm_profile_button.schedule(10, "check_first_x_position2", 0);
}

//dynamic scheduling for bounce to bounce2
function mm_profile_button::check_first_x_position2( % this) { % this_x = mm_profile_button.getPositionX();
 if ( % this_x >= $mm_profile_button_athis_x2) {
  mm_profile_button.schedule(10, "bounce2", 0);
 }
 if ( % this_x < $mm_profile_button_athis_x2) {
  mm_profile_button.schedule(10, "check_first_x_position2", 0);
 }
}

function mm_profile_button::bounce2( % this) {
 $mm_profile_button = 30.026; % this.moveTo($mm_profile_button_athis_x, $mm_profile_button_athis_y, 30, true, true, true, 0.1);
 $mm_profile_completed = 1;
}

function mm_music_starter::delay_in( % this) {
 $default_audio = "mainmenu_theme";
 alxStopAll();
 if ($toggle_mute_music != 1) {
  alxPlay($default_audio);
 }
}

/* light fader fx 1 in lvl1 */
function fx_image1::alpha_up() {
 if ($world_numeral != 4) {
  if ($lvl1_light_alpha < 1) {
   $lvl1_light_alpha += 0.02;
   fx_image1.setBlendAlpha($lvl1_light_alpha);
   $fxi_sched_01 = fx_image1.schedule(120, "alpha_up", 0);
  }
  if ($lvl1_light_alpha >= 1) {
   $fxi_sched_02 = fx_image1.schedule(250, "delay", 0);
  }
 }
}

function fx_image1::delay() {
 if ($world_numeral != 4) {
  if ($lvl1_delay_toggled == 0) {
   $fxi_sched_03 = fx_image1.schedule(550, "alpha_down", 0);
   $lvl1_delay_toggled = 1;
  }
 }
}

function fx_image1::alpha_down() {
 if ($world_numeral != 4) {
  if ($lvl1_light_alpha > 0) {
   $lvl1_light_alpha -= 0.02;
   fx_image1.setBlendAlpha($lvl1_light_alpha);
   $fxi_sched_04 = fx_image1.schedule(120, "alpha_down", 0);
  }
  if ($lvl1_light_alpha <= 0) {
   $fxi_sched_05 = fx_image1.schedule(250, "alpha_up", 0);
   $lvl1_delay_toggled = 0;
  }
 }
}

/* light fader fx 2 in lvl1 */
function fx_image2::alpha_up() {
 if ($world_numeral != 4) {
  if ($lvl1b_light_alpha < 1) {
   $lvl1b_light_alpha += 0.02;
   fx_image2.setBlendAlpha($lvl1b_light_alpha);
   $fxi_sched_06 = fx_image2.schedule(120, "alpha_up", 0);
  }
  if ($lvl1b_light_alpha >= 1) {
   $fxi_sched_07 = fx_image2.schedule(250, "delay", 0);
  }
 }
}

function fx_image2::delay() {
 if ($lvl1b_delay_toggled == 0) {
  $fxi_sched_08 = fx_image2.schedule(550, "alpha_down", 0);
  $lvl1b_delay_toggled = 1;
 }
}

function fx_image2::alpha_down() {
 if ($lvl1b_light_alpha > 0) {
  $lvl1b_light_alpha -= 0.02;
  fx_image2.setBlendAlpha($lvl1b_light_alpha);
  $fxi_sched_09 = fx_image2.schedule(120, "alpha_down", 0);
 }
 if ($lvl1b_light_alpha <= 0) {
  $fxi_sched_10 = fx_image2.schedule(250, "alpha_up", 0);
  $lvl1b_delay_toggled = 0;
 }
}

/* light fader fx 3 in lvl9 */
function fx_image3::alpha_up() {
 if ($lvl1c_light_alpha < 1) {
  $lvl1c_light_alpha += 0.02;
  fx_image3.setBlendAlpha($lvl1c_light_alpha);
  $fxi_sched_11 = fx_image3.schedule(120, "alpha_up", 0);
 }
 if ($lvl1c_light_alpha >= 1) {
  $fxi_sched_12 = fx_image3.schedule(250, "delay", 0);
 }
}

function fx_image3::delay() {
 if ($lvl1c_delay_toggled == 0) {
  $fxi_sched_13 = fx_image3.schedule(550, "alpha_down", 0);
  $lvl1c_delay_toggled = 1;
 }
}

function fx_image3::alpha_down() {
 if ($lvl1c_light_alpha > 0) {
  $lvl1c_light_alpha -= 0.02;
  fx_image3.setBlendAlpha($lvl1c_light_alpha);
  $fxi_sched_14 = fx_image3.schedule(120, "alpha_down", 0);
 }
 if ($lvl1c_light_alpha <= 0) {
  $fxi_sched_15 = fx_image3.schedule(250, "alpha_up", 0);
  $lvl1c_delay_toggled = 0;
 }
}

/* Do Nothing Image FX*/
function fx_image1::do_nothing() {
 fx_image1.setBlendAlpha(1);
}

function fx_image2::do_nothing() {
 fx_image2.setBlendAlpha(1);
}

function fx_image3::do_nothing() {
 fx_image3.setBlendAlpha(1);
}


/* LVL6 blinker 1 fx */
function fx_image1::blink_in() {

 if ($world_numeral != 4) {
  if ($lvl1_light_alpha < 1) {
   $lvl1_light_alpha += 0.02;
   fx_image1.setBlendAlpha($lvl1_light_alpha);
   $fxi_sched_16 = fx_image1.schedule(60, "blink_in", 0);
  }
  if ($lvl1_light_alpha >= 1) {
   $fxi_sched_17 = fx_image1.schedule(650, "delay_blink", 0);
  }
 }
}

function fx_image1::delay_blink() {
 if ($world_numeral != 4) {
  if ($lvl1_delay_toggled == 0) {
   $fxi_sched_18 = fx_image1.schedule(550, "blink_out", 0);
   $lvl1_delay_toggled = 1;
  }
 }
}

function fx_image1::blink_out() {
 if ($world_numeral != 4) {
  if ($lvl1_light_alpha > 0) {
   $lvl1_light_alpha -= 0.02;
   fx_image1.setBlendAlpha($lvl1_light_alpha);
   $fxi_sched_19 = fx_image1.schedule(60, "blink_out", 0);
  }
  if ($lvl1_light_alpha <= 0) {
   $fxi_sched_20 = fx_image1.schedule(250, "blink_in", 0);
   $lvl1_delay_toggled = 0;
  }
 }
}

/* LVL6 blinker 2 fx */
function fx_image2::blink_in() {
 if ($lvl1b_light_alpha < 1) {
  $lvl1b_light_alpha += 0.02;
  fx_image2.setBlendAlpha($lvl1b_light_alpha);
  $fxi_sched_22 = fx_image2.schedule(60, "blink_in", 0);
 }
 if ($lvl1b_light_alpha >= 1) {
  $fxi_sched_23 = fx_image2.schedule(250, "delay_blink", 0);
 }
}

function fx_image2::delay_blink() {
 if ($lvl1b_delay_toggled == 0) {
  $fxi_sched_24 = fx_image2.schedule(850, "blink_out", 0);
  $lvl1b_delay_toggled = 1;
 }
}

function fx_image2::blink_out() {
 if ($lvl1b_light_alpha > 0) {
  $lvl1b_light_alpha -= 0.02;
  fx_image2.setBlendAlpha($lvl1b_light_alpha);
  $fxi_sched_25 = fx_image2.schedule(60, "blink_out", 0);
 }
 if ($lvl1b_light_alpha <= 0) {
  $fxi_sched_26 = fx_image2.schedule(250, "blink_in", 0);
  $lvl1b_delay_toggled = 0;
 }
}

/* Tutorial FX */

function isolater_mask::alpha_in() {
 $tutorial_cue_tab_control = 1;
 isolater_mask.spawn_char1_once();
 isolater_mask.schedule(250, "delay", 0);
 tutorial_text_block.font = "cambo";
 tutorial_text_block2.font = "cambo";
 tutorial_text_block.text = $tut_01;
 tutorial_text_block.setPositionX(105.878);
 tutorial_text_block.setPositionY(12.771);
 tutorial_text_block.setBlendAlpha(1);
 tutorial_bar.setPositionX(105.75);
 tutorial_bar.setPositionY(12.85);
 $toggle_off_alpha_in = 1;

 tutorial_clicker.setPositionX(112);
 tutorial_clicker.setPositionY(1);
 tutorial_clicker.setBlendAlpha(1);

}

function isolater_mask::spawn_char1_once() {
 if ($isolater_mask_spawn_once_only != 1) {
  empty_char_space1.is_despawned = 0;
  empty_char_space1.occupied = 1;
  $isolater_mask_spawn_once_only = 1;
  $its_okay_to_click_tutchar1 = 1;
  $lock_down_retoggling_during_tutorial = 0;
 }
}

function isolater_mask::delay() {
 $tutorial_options_finished = 1;
 $disable_all_clicks_of_chars_via_tutorial = 0;
}

function isolater_mask::fade_out_one_and_part_two_in() {

 $isolater_mask_alpha = 0;
 if ($isolater_mask_alpha <= 0) {

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 0 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(74.473);
   isolater_mask.setPositionY(24.601);
   isolater_mask.setSize(186.478, 139.859);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 1 & $tutorial_end_fading_bs != 1) {

   isolater_mask.setPositionX(60);
   isolater_mask.setPositionY(-4);
   isolater_mask.setSize(186.478, 139.859);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 2 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(82);
   isolater_mask.setPositionY(13);
   isolater_mask.setSize(186.478, 139.859);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 3 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 4 & $tutorial_end_fading_bs != 1) {
   //wait for char1 to tell you what to do
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_cook_sequence == 5 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }
  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_tip_sequence == 2 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_tip_sequence == 3 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_tip_sequence == 4 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(77);
   isolater_mask.setPositionY(14);
   isolater_mask.setSize(186.478, 139.859);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }
  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_activate_tip_sequence == 5 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
   $tutorial_activate_extra_sequence = 2;
  }

  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tut_char_fruit_choices == 2 & $tutorial_end_fading_bs != 1) {
   isolater_mask.setPositionX(60);
   isolater_mask.setPositionY(23);
   isolater_mask.setSize(186.478, 139.859);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $tut_go_to_fruits = 1;
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }
  if ($toggle_off_fade_out_one_and_part_two_in != 1 & $tutorial_end_fading_bs == 1 & $tut_toggle_new_appetizer != 2) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "special_statement", 0);
   isolater_mask.schedule(251, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }
  if ($tut_toggle_new_appetizer == 2) {
   isolater_mask.setPositionX(107.066);
   isolater_mask.setPositionY(-1.467);
   isolater_mask.setSize(141.4, 106.050);
   isolater_mask.schedule(250, "fade_in_part_two", 0);
   $toggle_off_fade_out_one_and_part_two_in = 1;
  }

 }
}

function isolater_mask::fade_in_part_two() {
 $tutorial_end_fading_bs = 0;
 if ($tutorial_end_fading_bs != 1) {

  $tut_fade_maximum = 0;
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_cook_sequence == 0) {
   tutorial_clicker.setPositionX(73);
   tutorial_clicker.setPositionY(27);
   tutorial_clicker.setBlendAlpha(1);
   tutorial_text_block.text = $tut_02;
   isolater_mask.setBlendAlpha(0);
   isolater_mask.schedule(250, "delay2", 0);

  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_cook_sequence == 1) {
   $tutorial_cue_tab_control = 0;
   pointer_tutorial.setPositionX(65);
   pointer_tutorial.setPositionY(-6);
   pointer_tutorial.setRotation(90);
   pointer_tutorial.setBlendAlpha(1);

   $toggle_off_default_tut_statement = 1;
   tutorial_text_block.text = $tut_03;
   tutorial_text_block2.text = $tut_03b;
   tutorial_text_block.setPositionY(-5);
   tutorial_text_block.setPositionX(106);
   tutorial_text_block2.setPositionY(-1);
   tutorial_text_block2.setPositionX(106);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_text_block2.setBlendAlpha(1);
   tutorial_bar.setPositionX(106);
   tutorial_bar.setPositionY(-5);
   tutorial_bar2.setPositionX(106);
   tutorial_bar2.setPositionY(-1);
   tutorial_bar2.setSize(30, 4.980);
   tutorial_bar2.setBlendAlpha(1);
   isolater_mask.schedule(250, "delay_for_cooks", 0);
   $wait_for_tut_drink_out_fader_to_finish = 1;
  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_cook_sequence == 2) {

   tutorial_clicker.setPositionX(85);
   tutorial_clicker.setPositionY(16);
   tutorial_clicker.setBlendAlpha(0);

   tutorial_text_block.text = $tut_04;
   tutorial_text_block.setPositionY(13);
   tutorial_text_block.setPositionX(118);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_text_block2.setBlendAlpha(0);
   tutorial_bar.setPositionX(128);
   tutorial_bar.setPositionY(13);
   tutorial_bar2.setBlendAlpha(0);
   isolater_mask.schedule(250, "delay_for_cooks", 0);
   pointer_tutorial.setBlendAlpha(0);
   drink_ident1.setImageMap(button_orange_fruit3ImageMap);
   drink_ident11.setImageMap(button_yellow_fruit3ImageMap);
   drink_ident1.setFrame(0);
   drink_ident11.setFrame(0);


  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_cook_sequence == 3) {

   pointer_tutorial.setBlendAlpha(0);
   tutorial_clicker.setPositionX(113);
   tutorial_clicker.setPositionY(1);
   tutorial_clicker.setBlendAlpha(1);

   tutorial_text_block.text = $tut_05;
   tutorial_text_block.setPositionY(11);
   tutorial_text_block.setPositionX(122);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_bar.setPositionX(134);
   tutorial_bar.setPositionY(11);
   isolater_mask.schedule(250, "delay_for_drink_to_char1", 0);
   $activate_tutorial_cointip = 1;
   $tutorial_activate_tip_sequence = 1;
  }

  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_tip_sequence == 2) {

   pointer_tutorial.setBlendAlpha(0);
   tutorial_clicker.setPositionX(108.5);
   tutorial_clicker.setPositionY(4.3);
   tutorial_clicker.setBlendAlpha(1);

   tutorial_text_block.text = $tut_07;
   tutorial_text_block.setPositionX(120);
   tutorial_text_block.setPositionY(9.45);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_bar.setPositionX(130);
   tutorial_bar.setPositionY(9.45);
   $activate_tut_cointip_portion = 1;

  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_tip_sequence == 3) {

   tutorial_text_block.text = $tut_08;
   tutorial_clicker.setPositionX(108.5);
   tutorial_clicker.setPositionY(2);
   tutorial_clicker.setBlendAlpha(1);
  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_tip_sequence == 4) {
   tutorial_text_block.text = $tut_08b;
   tutorial_text_block.setPositionX(116);
   tutorial_text_block.setPositionY(9.45);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_bar.setPositionX(120);
   tutorial_bar.setPositionY(9.45);
   tutorial_clicker.setPositionX(80);
   tutorial_clicker.setPositionY(19);
   tutorial_clicker.setBlendAlpha(1);
  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_tip_sequence == 5) {
  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tut_toggle_new_appetizer == 2 & $tut_appetizers_part_b != 1) {
   $tutorial_cue_tab_control = 0;
   tutorial_text_block.text = $tut_12b;
  }

  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_extra_sequence == 1) {
   pointer_tutorial.setBlendAlpha(0);
   tutorial_clicker.setPositionX(86);
   tutorial_clicker.setPositionY(-18);
   tutorial_clicker.setBlendAlpha(1);
   $lock_the_cook_for_tutorial = 1;

   tutorial_text_block.text = $tut_09;
   tutorial_text_block.setPositionX(100);
   tutorial_text_block.setPositionY(-13);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_text_block2.text = $tut_09b;
   tutorial_text_block2.setPositionX(100);
   tutorial_text_block2.setPositionY(-9);
   tutorial_text_block2.setBlendAlpha(1);
   tutorial_bar.setPositionX(105);
   tutorial_bar.setPositionY(-13);
   tutorial_bar.setSize(110, 4.980);
   tutorial_bar2.setBlendAlpha(1);
   tutorial_bar2.setPositionX(105);
   tutorial_bar2.setPositionY(-9);
   tutorial_bar2.setSize(110, 4.980);
   //this activates spawning of char1_tut as char1_tut #2 via mouseDown on Appetizer 2
   $tutorial_activate_tip_sequence = 6;
   //edit 01-23-2014 re-adding appetizer2 partition
   appetizer2.setBlendAlpha(1);
   appetizer2.setImageMap(appetizer1ImageMap);
   appetizer2.setFrame(1);
   appetizer2.setPositionX(83.5);
   appetizer2.setPositionY(-19);
   appetizer2_amt_ingame.text = 1;

  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tutorial_activate_extra_sequence == 2) {
   $tutorial_cue_tab_control = 1;
   $disable_all_remaining_fruit_ui = 1;
   pointer_tutorial.setBlendAlpha(0);
   tutorial_clicker.setPositionX(113);
   tutorial_clicker.setPositionY(1);
   tutorial_clicker.setBlendAlpha(1);

   tutorial_text_block.text = $tut_10;
   tutorial_text_block.setPositionX(100);
   tutorial_text_block.setPositionY(-23);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_bar.setPositionX(110);
   tutorial_bar.setPositionY(-23);
   tutorial_bar.setSize(120, 4.980);
   tutorial_bar2.setPositionX(106.5);
   tutorial_bar2.setPositionY(10.697);
   tutorial_bar2.setSize(50, 4.980);
   tutorial_bar2.setBlendAlpha(1);
   tutorial_text_block2.text = $tut_10b;
   tutorial_text_block2.setPositionX(106.564);
   tutorial_text_block2.setPositionY(10.697);
   tutorial_text_block2.setBlendAlpha(1);
   //this activates spawning of char1_tut as char1_tut #2 via mouseDown on Appetizer 2
   $this_char_x = empty_char_space1.getPositionX();
   $this_char_y = empty_char_space1.getPositionY();
   $char_reset_pos_x = $this_char_x - 2;
   $char_reset_pos_y = $this_char_y - 10;

   $tut_char_fruit_choices = 2;

   //making sure appetizer returns to normal states since hacked it into hot cross buns
   appetizer2.setBlendAlpha(0);
   appetizer2.setImageMap(appetizer2ImageMap);
   appetizer2.setFrame(1);
   appetizer2.setPositionX(83.067);
   appetizer2.setPositionY(-21.076);
   appetizer2_amt_ingame.text = 0;
   //edit 03-10-2014 lock down cherry and kiwi as only pickable fruits
   $make_cherry_the_only_pickable_fruit = 1;
   $make_kiwi_the_only_pickable_fruit = 1;

  }
  if ($isolater_mask_alpha >= $tut_fade_maximum & $tut_go_to_fruits == 1 & $end_previous_non_new_tut_bits != 1) {
   pointer_tutorial.setBlendAlpha(0);
   tutorial_clicker.setPositionX(64);
   tutorial_clicker.setPositionY(27);
   tutorial_clicker.setBlendAlpha(1);

   tutorial_text_block2.setBlendAlpha(0);
   $tutorial_activate_extra_sequence = 9999;
   $tutorial_activate_tip_sequence = 9999;
   tutorial_text_block.text = $tut_11;
   tutorial_text_block.setPositionX(100);
   tutorial_text_block.setPositionY(9);
   tutorial_text_block.setBlendAlpha(1);
   tutorial_bar.setPositionX(100);
   tutorial_bar.setPositionY(9);
   tutorial_bar.setSize(120, 4.980);
   tutorial_bar2.setPositionX(106.5);
   tutorial_bar2.setPositionY(-40);
   tutorial_bar2.setSize(50, 4.980);
   $completely_unlock_second_fruit_iterator = 1;
   $disable_all_remaining_fruit_ui = 0;


  }
 }
}

function isolater_mask::special_statement() {
 if ($tut_yes_is_active == 1) {
  $tutorial_cue_tab_control = 0;
  pointer_tutorial.setBlendAlpha(0);
  tutorial_clicker.setBlendAlpha(0);
  tutorial_text_block.text = $tut_12;
  tutorial_text_block.setPositionX(105);
  tutorial_text_block.setPositionY(-24);
  tutorial_text_block.setBlendAlpha(1);
  tutorial_bar.setPositionX(132);
  tutorial_bar.setPositionY(-24);
  tutorial_bar.setSize(120, 4.980);
  tutorial_bar2.setPositionX(132);
  tutorial_bar2.setPositionY(-24);
  tutorial_bar2.setSize(120, 4.980);
  //disable alpha for pointer clicker and disable pointer clicker all together
  tutorial_clicker.setBlendAlpha(0);
  $disable_tutorial_clicker = 1;
  $lock_the_cook_for_tutorial = 0;
 }
}

/* END FUNCTION FOR TUTORIAL */

function isolater_mask::do_final_tutorial_part() {
 //this is where swap is able to be clicked before hand
 if ($tut_yes_is_active == 1) {
  tut_help_pointer.setPositionX(118.840);
  tut_help_pointer.setPositionY(-35.588);
  tut_help_pointer.setBlenAlpha(1);
  tutorial_text_block.text = $tut_14b;
  tutorial_text_block.setPositionX(105);
  tutorial_text_block.setPositionY(-22);
  tutorial_text_block.setBlendAlpha(1);
  tutorial_text_block2.setBlendAlpha(100);
  tutorial_text_block2.text = $tut_13d;
  tutorial_text_block2.setPositionX(100);
  tutorial_text_block2.setPositionY(15);
  tutorial_bar.setPositionX(105);
  tutorial_bar.setPositionY(-22);
  tutorial_bar.setSize(120, 4.980);
  tutorial_bar2.setPositionX(105);
  tutorial_bar2.setPositionY(15);
  tutorial_bar2.setSize(120, 4.980);
  tutorial_bar3.setPositionX(105);
  tutorial_bar3.setPositionY(-22);
  tutorial_bar3.setSize(120, 4.980);
  tutorial_bar4.setPositionX(105);
  tutorial_bar4.setPositionY(15);
  tutorial_bar4.setSize(120, 4.980);
  isolater_mask.schedule(8000, "fade_out_final_text", 0);
  /* Add extra 10 appetizers hereeeeeeeeeee */
  $appetizer1_purchased1 = 1;
  if ($world_numeral == 1 & $round_numeral == 1) {
   $appetizer_default_amount = 8;
  }
  $appetizer1_amount1 = $appetizer_default_amount;
  appetizer1_amt.text = $appetizer1_amount1;
  appetizer1_amt_ingame.text = $appetizer1_amount1;
  $appetizer2_purchased1 = 1;
  $appetizer2_amount1 = $appetizer_default_amount;
  appetizer2_amt.text = $appetizer2_amount1;
  appetizer2_amt_ingame.text = $appetizer2_amount1;
  appetizer1.setBlendAlpha(1);
  appetizer2.setBlendAlpha(1);
  appetizer1.setFrame(1);
  appetizer2.setFrame(1);
  appetizer1.setLayer(18);
  appetizer2.setLayer(18);
  appetizer1.setPositionX(96.171);
  appetizer1.setPositionY(20.022);
  appetizer2.setPositionX(108.665);
  appetizer2.setPositionY(26.065);

  $appetizer_default_amount = 4;
  tab_cancel1.setBlendAlpha(1);
  tutorial_clicker.setBlendAlpha(0);

 }
}

function isolater_mask::fade_out_final_text() {
 //this is where fruits are able to be clicked before hand
 if ($tut_text_alpha > 0) {
  $tut_text_alpha -= 0.2;
  tutorial_text_block.setBlendAlpha($tut_text_alpha);
  tutorial_text_block2.setBlendAlpha($tut_text_alpha);
  tutorial_bar.setBlendAlpha($tut_text_alpha);
  tutorial_bar2.setBlendAlpha($tut_text_alpha);
  tutorial_bar3.setBlendAlpha($tut_text_alpha);
  tutorial_bar4.setBlendAlpha($tut_text_alpha);
  isolater_mask.schedule(60, "fade_out_final_text", 0);
 }
 if ($tut_text_alpha <= 0) {
  if ($do_final_tutorial_part_only_once != 1) {
   tut_help_pointer.setPositionX(82.275);
   tut_help_pointer.setPositionY(69.067);
   tut_help_pointer.setBlenAlpha(0);
   $disable_ui_and_rgbp_swap = 0;
   $tut_yes_is_active = 0;
   $tut_char_fruit_choices = 9999;
   $end_the_tutorial = 9999;
   $toggle_initial_spawner_via_clock = 0;
   $game_has_started_for_clock = 1;
   $tut_make_cancelling_impossible = 0;
   $toggle_tut_appetizer = 0;
   $lock_down_retoggling_during_tutorial = 0;
   $disable_all_clicks_of_chars_via_tutorial = 0;
   $toggle_off_orange_fruit_for_tut = 0;
   $toggle_off_yellow_fruit_for_tut = 0;
   $tut_make_reclicking_drink_out_impossible = 0;
   //remove tutorial bars
   tutorial_bar.setSize(81.543, 4.980);
   tutorial_bar.setPositionX(105);
   tutorial_bar.setPositionY(-40);
   tutorial_bar2.setSize(81.543, 4.980);
   tutorial_bar2.setPositionX(105);
   tutorial_bar2.setPositionY(-40);
   tutorial_bar3.setSize(81.543, 4.980);
   tutorial_bar3.setPositionX(105);
   tutorial_bar3.setPositionY(-40);
   tutorial_bar4.setSize(81.543, 4.980);
   tutorial_bar4.setPositionX(105);
   tutorial_bar4.setPositionY(-40);

   $lock_down_first_fruit_iterator = 1;
   $tut_iterate_orange = 0;
   $tut_iterate_yellow = 0;
   $tut_iterate_red = 0;
   $tut_iterate_green = 0;
   button_options_ingame.BlendColor = "1 1 1 1";
   $temporarily_disable_ingame_options_before_tutorial = 0;

   //05-29-2014 clip out final stuff for re-ignition if player decides to play tutorial again
   $tut_coin_tip_override = 0;
   $lock_down_isolater_mask_part_i_to_ii = 0;
   $end_previous_non_new_tut_bits = 0;
   make_sure_fruits_are_enabled_after_tut();
   $do_final_tutorial_part_only_once = 1;

  }
 }

}

function isolater_mask::fade_in_part_two_set_layers_once() {
 if ($toggle_off_part_two_set_layers != 1) {
  $toggle_off_part_two_set_layers = 1;
 }
}

function isolater_mask::delay2() {
 if ($cease_masking_of_dial == 0) {
  $disable_ui_and_rgbp_swap = 1;
  button_red_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_green_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_blue_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_purple_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_swap.BlendColor = "0.25 0.25 0.25 1";
  $until_tut_char_is_activated_dont_do_fruits = 0;
  $completely_unlock_first_fruit_iterator = 1;
  $unlock_subtle_red_mouseover = 1;
 }
}

function isolater_mask::delay_for_cooks() {
 if ($tutorial_activate_cook_sequence == 2) {
  $wait_for_tut_drink_out_fader_to_finish = 0;
 }
 if ($cease_masking_of_dial == 0) {
  $disable_ui_and_rgbp_swap = 1;
  $disable_all_remaining_fruit_ui = 1;
  button_yellow_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_orange_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_red_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_green_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_blue_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_purple_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_swap.BlendColor = "0.25 0.25 0.25 1";
  monster_shake.setScenePause(false);
 }
}



function isolater_mask::delay_for_drink_to_char1() {
 if ($cease_masking_of_dial == 0) {
  $disable_ui_and_rgbp_swap = 1;
  button_red_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_green_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_blue_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_purple_fruit.BlendColor = "0.25 0.25 0.25 1";
  button_swap.BlendColor = "0.25 0.25 0.25 1";
  $activate_tutorial_serve_char_sequence = 1;
  $completely_unlock_first_fruit_iterator = 0;
 }
}

function isolater_mask::turn_fruit_dial_to_normal() {
  if ($cease_masking_of_dial == 1) {
   $disable_ui_and_rgbp_swap = 0;
   button_yellow_fruit.BlendColor = "1 1 1 1";
   button_orange_fruit.BlendColor = "1 1 1 1";
   button_red_fruit.BlendColor = "1 1 1 1";
   button_green_fruit.BlendColor = "1 1 1 1";
   button_blue_fruit.BlendColor = "1 1 1 1";
   button_purple_fruit.BlendColor = "1 1 1 1";
   button_swap.BlendColor = "1 1 1 1";
   monster_shake.setScenePause(false);
  }
 }
 //edit 01-24-2014 adding new pre-tutorial masking function for fruits... sigh
function isolater_mask::turn_off_fruit_dial() {
 $until_tut_char_is_activated_dont_do_fruits = 1;
 $disable_ui_and_rgbp_swap = 1;
 $disable_all_remaining_fruit_ui = 1;
 button_yellow_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_orange_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_red_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_green_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_blue_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_purple_fruit.BlendColor = "0.25 0.25 0.25 1";
 button_swap.BlendColor = "0.25 0.25 0.25 1";
 monster_shake.setScenePause(false);
}

function isolater_mask::turn_back_on_fruit_dial() {
  $until_tut_char_is_activated_dont_do_fruits = 0;
  $disable_ui_and_rgbp_swap = 0;
  $disable_all_remaining_fruit_ui = 0;
  button_yellow_fruit.BlendColor = "1 1 1 1";
  button_orange_fruit.BlendColor = "1 1 1 1";
  button_red_fruit.BlendColor = "1 1 1 1";
  button_green_fruit.BlendColor = "1 1 1 1";
  button_blue_fruit.BlendColor = "1 1 1 1";
  button_purple_fruit.BlendColor = "1 1 1 1";
  button_swap.BlendColor = "1 1 1 1";
  monster_shake.setScenePause(false);
 }

function fx_image1::shorebreak_in( % this) {
 shorebreak_displayer.text = "shorebreak_in";
 shorebreak_displayer2.text = $shore_speed_test;
 if ($world_numeral != 4) {
  shorebreak_displayer.text = "shorebreak ceased";
  $shore_speed_test = 0;
  echo("shorebreak in");
 }
 if ($world_numeral == 4 & $disable_all_shorebreaks != 1) {
  echo("shorebreak in p2");
  $shorebreak_athis_x = 133.038;
  $shorebreak_athis_y = 28.086;
  shorebreak_displayer3.text = "shorebreak 1A";
  fx_image1.moveTo($shorebreak_athis_x, $shorebreak_athis_y, $shore_speed_test, true, true, true, 0.1);
  $fxi_sched_27 = fx_image1.schedule(10, "check_first_shore_position", 0);
 }
}

function fx_image1::check_first_shore_position( % this) {
 shorebreak_displayer.text = "check_first_shore_position";
 shorebreak_displayer2.text = $shore_speed_test; % get_local_x = fx_image1.getPositionX(); % get_local_y = fx_image1.getPositionY(); % get_size_x = 35.054; % get_size_y = 19.223;
 if ($world_numeral != 4) {
  shorebreak_displayer.text = "shorebreak ceased";
  $shore_speed_test = 0;
 }
 if ($world_numeral == 4 & $toggle_off_shorebreak != 1 & $disable_all_shorebreaks != 1) {
  if ($shore_speed_test >= 0.45 & $keep_shorebreak_moving != 1) {
   $shore_speed_test -= 0.007;
   //use this for acc-dec
   shorebreak_displayer3.text = "shorebreak 2A";
   fx_image1.moveTo($shorebreak_athis_x, $shorebreak_athis_y, $shore_speed_test, true, true, true, 0.1);
   //echo("fx_image1 @ >= 0.45");
  }
  if ($shore_speed_test < 0.45) {
   $keep_shorebreak_moving = 1;
   $shore_speed_test = 0.45;
   fx_image1.moveTo($shorebreak_athis_x, $shorebreak_athis_y, $shore_speed_test, true, true, true, 0.1);
   //echo("fx_image1 @ < 0.45");
  }
  if ( % get_local_x != $shorebreak_athis_x || % get_local_y != $shorebreak_athis_y) {
   if ($toggle_off_shorebreak != 1) {
    $fxi_sched_28 = fx_image1.schedule(10, "check_first_shore_position", 0);
   }
  }
  //echo("%get_local_x = " @ %get_local_x @ " $shorebreak_athis_x = " @ $shorebreak_athis_x @ "%get_local_y = " @ %get_local_y @ " $shorebreak_athis_y = " @ $shorebreak_athis_y);
  if ( % get_local_x == $shorebreak_athis_x & % get_local_y == $shorebreak_athis_y) {
   //echo("Shorebreak 3f");
   $shorebreak_bthis_x = 148.532;
   $shorebreak_bthis_y = 37.770;
   shorebreak_displayer3.text = "shorebreak 2C";
   fx_image1.moveTo($shorebreak_bthis_x, $shorebreak_bthis_y, $shore_speed_test, true, true, true, 0.1);
   //echo("fx_image1 @ %get_local_x");
   $toggle_off_shorebreak = 1;
   $shore_speed_test = 0;
   $shorebreak_iterator = 0;
   $keep_shorebreak_moving = 0;
   $fxi_sched_29 = fx_image1.schedule(10, "check_second_shore_position", 0);
   //fx_image1.schedule(10, "test_var_spd", 0);
  }
 }
}

function fx_image1::check_second_shore_position( % this) {
 shorebreak_displayer.text = "check_second_shore_position";
 shorebreak_displayer2.text = $shore_speed_test; % get_local_x = fx_image1.getPositionX(); % get_local_y = fx_image1.getPositionY(); % get_size_x = 35.054; % get_size_y = 19.223;
 if ($world_numeral != 4) {
  shorebreak_displayer.text = "shorebreak ceased";
  $shore_speed_test = 0;
 }
 if ($world_numeral == 4 & $disable_all_shorebreaks != 1) {
  if ( % get_local_x != $shorebreak_bthis_x || % get_local_y != $shorebreak_bthis_y) {
   if ($toggle_off_shorebreak == 1) {
    if ($shore_speed_test <= 5 & $keep_shorebreak_moving != 1) {
     $shore_speed_test += 0.03;
     //use this for acc-dec
     fx_image1.moveTo($shorebreak_bthis_x, $shorebreak_bthis_y, $shore_speed_test, true, true, true, 0.1);
     //echo("fx_image1_check2nd @ <= 5");

    }
    if ($shore_speed_test > 5) {
     $keep_shorebreak_moving = 1;
     $shore_speed_test = 5;
     fx_image1.moveTo($shorebreak_bthis_x, $shorebreak_bthis_y, $shore_speed_test, true, true, true, 0.1);
     //echo("fx_image1_check2nd @ > 5");
    }
    $lvl1_light_alpha -= 0.005;
    $shorebreak_iterator += 0.014; % reset_size_x = % get_size_x; % reset_size_y = % get_size_y; % declare_size_x = % reset_size_x + $shorebreak_iterator; % declare_size_y = % reset_size_y + $shorebreak_iterator;
    //echo("DECLARE: " @ %declare_size_x @ " " @ %declare_size_y);
    fx_image1.setSize( % declare_size_x, % declare_size_y);
    //echo($shore_speed_test);

    fx_image1.setBlendAlpha($lvl1_light_alpha);
    $fxi_sched_30 = fx_image1.schedule(10, "check_second_shore_position", 0);
   }
  }
  if ( % get_local_x == $shorebreak_bthis_x & % get_local_y == $shorebreak_bthis_y) {
   $lvl1_light_alpha = 1;
   $shore_speed_test = 5;
   $shorebreak_iterator = 0;
   fx_image1.setBlendAlpha($lvl1_light_alpha);
   fx_image1.setSize( % get_size_x, % get_size_y);
   $keep_shorebreak_moving = 0;
   $shore_speed_test = 5;
   fx_image1.moveTo($shorebreak_athis_x, $shorebreak_athis_y, $shore_speed_test, true, true, true, 0.1);
   //echo("fx_image1_check2nd @ %get_local_x");
   $toggle_off_shorebreak = 0;
   $fxi_sched_31 = fx_image1.schedule(10, "shorebreak_in", 0);
  }
 }
}

function combo_alert::onAnimationEnd( % this) {
 if ($toggle_on_combo_anim == 1) {

  combo_alert.setAnimation(elec_streamAnimation);
  combo_alert.schedule(3000, "turn_off_electricity", 0);
 }
}

function combo_alert::turn_off_electricity( % this) {
 $toggle_on_combo_anim = 0;
 combo_alert.setAnimation(empty_char_spaceAnimation);
 $toggle_combo_fade = 1;
 combo_animater.schedule(10, "fade_out", 0);
}

function combo_animater::fade_out( % this) {
 if ($toggle_combo_fade == 1 & $combo_animater_alpha > 0) {

  $combo_animater_alpha -= 0.01;
  combo_animater.setBlendAlpha($combo_animater_alpha);
  combo_animater.schedule(10, "fade_out", 0);
 }
 if ($toggle_combo_fade == 1 & $combo_animater_alpha <= 0) {

  $toggle_combo_fade = 0;
 }
}

function flying_coin::fly( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   flying_coin.setAnimation(flyer_coinAnimation);
   flying_coin.setBlendAlpha(1);
   $flying_coin_active = 1;
   $flying_coin_start_x = 155.153;
   $flying_coin_start_y = -9.813;
   $flying_coin_end_x = 40;
   $flying_coin_end_y = -9.813;
   flying_coin.setPositionX(155.153);
   flying_coin.moveTo($flying_coin_end_x, $flying_coin_end_y, 20, true, true, true, 0.1);
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled == 1) {
    hint_bonus3.setBlendAlpha(0);
   }
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled != 1) {
    hint_bonus3.setBlendAlpha(1);
    hint_bonus3.moveTo($flying_coin_end_x, $flying_coin_end_y, 20, true, true, true, 0.1);
    $hint_bonus3_disabled = 1;
   }
  }
 }
}

//vertical flyer data
function flying_coin2::fly( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   flying_coin2.setAnimation(flyer_coinAnimation);
   flying_coin2.setBlendAlpha(1);
   $flying_coin2_active = 1;
   $flying_coin2_start_x = 109.762;
   $flying_coin2_start_y = -40.715;
   $flying_coin2_end_x = 109.762;
   $flying_coin2_end_y = 42.513;
   flying_coin2.setPositionY(-40.715);
   flying_coin2.moveTo($flying_coin2_end_x, $flying_coin2_end_y, 20, true, true, true, 0.1);
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled == 1) {
    hint_bonus3.setBlendAlpha(0);
   }
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled != 1) {
    hint_bonus3.setBlendAlpha(1);
    hint_bonus3.moveTo($flying_coin2_end_x, $flying_coin2_end_y, 20, true, true, true, 0.1);
    $hint_bonus3_disabled = 1;
   }
  }
 }
}

function flying_coin2::fly_back( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   flying_coin2.setAnimation(flyer_coinAnimation);
   flying_coin2.setBlendAlpha(1);
   $flying_coin2_active = 1;
   $flying_coin2_end_x = 109.762;
   $flying_coin2_end_y = -40.715;
   $flying_coin2_start_x = 109.762;
   $flying_coin2_start_y = 42.513;
   flying_coin2.setPositionY(42.513);
   flying_coin2.moveTo($flying_coin2_end_x, $flying_coin2_end_y, 20, true, true, true, 0.1);
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled == 1) {
    hint_bonus3.setBlendAlpha(0);
   }
   if ($activate_continuing_tutorial == 1 & $hint_bonus3_disabled != 1) {
    hint_bonus3.setBlendAlpha(1);
    hint_bonus3.moveTo($flying_coin2_end_x, $flying_coin_end2_y, 20, true, true, true, 0.1);
    $hint_bonus3_disabled = 1;
   }
  }
 }
}

function flying_coin::fly_back( % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % confirm_world_numeral == $world_numeral & % confirm_round_numeral == $round_numeral) {

  if ($left_the_level_space != 1) {
   flying_coin.setAnimation(flyer_coinAnimation);
   flying_coin.setBlendAlpha(1);
   $flying_coin_active = 1;
   $flying_coin_start_x = 155.153;
   $flying_coin_start_y = -9.813;
   $flying_coin_end_x = 40;
   $flying_coin_end_y = -9.813;
   flying_coin.setPositionX(40);
   flying_coin.moveTo($flying_coin_start_x, $flying_coin_start_y, 30, true, true, true, 0.1);
   hint_bonus3.setBlendAlpha(0);
  }
 }
}

function flying_coin::constantly_check_position( % this) {
 $flying_coin_x_checker = flying_coin.getPositionX();

 if ($flying_coin_x_checker <= 55) {
  flying_coin.setBlendAlpha(0);
 }

 if ($flying_coin_x_checker > 55) {
  flying_coin.setBlendAlpha(1);
 }

 flying_coin.schedule(200, "constantly_check_position", 0);
}

function cue_tab1::end_it_early( % id_tag, % local_cue_number) {
 cue_displayer.text = $check_cue_number;
 cue_displayer2.text = % local_cue_number;
 if ( % local_cue_number == $check_cue_number) {
  cue_tab1.cease_all();
 }
}

function cue_tab1::yellow_fader( % this) {

 $cue_tab1_blendcolor = "1 1 "
 @ $cue_tab1_alpha @ " 1";
 if ($toggle_cue_tab1_fade == 1 & $cue_tab1_alpha > 0) {
  $cue_tab1_alpha -= 0.01;
  cue_tab1.BlendColor = $cue_tab1_blendcolor;
  cue_tab1.schedule(10, "yellow_fader", 0);
 }
 if ($toggle_cue_tab1_fade == 1 & $cue_tab1_alpha <= 0) {
  echo("\c2 cue tab 1 fader DONE");
  $toggle_cue_tab1_fade = 0;
 }
}

function cue_tab1::shut_off_yellow( % this) {
 $cue_tab1_alpha = 1;
 $toggle_cue_tab1_fade = 0;
 $cue_tab1_blendcolor = "1 1 1 1";
 cue_tab1.BlendColor = "1 1 1 1";
}

function cue_tab1::green_fader( % this) {

 $cue_tab1_blendcolor_b = $cue_tab1_alpha_b @ " 1 "
 @ $cue_tab1_alpha_b @ " 1";
 if ($toggle_cue_tab1_fade_b == 1 & $cue_tab1_alpha_b > 0) {
  $cue_tab1_alpha_b -= 0.01;
  cue_tab1.BlendColor = $cue_tab1_blendcolor_b;
  cue_tab2.BlendColor = $cue_tab1_blendcolor_b;
  cue_tab1.schedule(10, "green_fader", 0);
 }
 if ($toggle_cue_tab1_fade_b == 1 & $cue_tab1_alpha_b <= 0) {
  echo("\c2 cue tab 1 fader DONE");
  $toggle_cue_tab1_fade_b = 0;
 }
}

function tab_cancel1::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $tut_yes_is_active != 1) {
  $check_cue_number += 1;
  //fix 09-15-2014 adding cease all for rare tab2 getting stuck, following it with original cease_tab1_only makes it derive code back to original afterward
  cue_tab1.cease_all();
  cue_tab1.cease_tab1_only();

 }
}

function cue_tab1::cease_tab1_only( % this) {
 if ($tut_yes_is_active != 1) {
  cue_tab1.setAnimation(cue_tab_down3Animation);
  //cue_tab2.setAnimation(cue_tab_down3Animation);
  cue1_fruit.setImageMap(want_emptyImageMap);
  //cue2_fruit.setImageMap(want_emptyImageMap);
  $cue_tab1_alpha = 1;
  //$cue_tab1_alpha_b = 1;		
  $toggle_cue_tab1_fade = 0;
  //$toggle_cue_tab1_fade_b = 0;		
  $cue_tab1_blendcolor = "1 1 1 1";
  //$cue_tab1_blendcolor_b = "1 1 1 1";		
  cue_tab1.BlendColor = "1 1 1 1";
  //cue_tab2.BlendColor = "1 1 1 1";	
  $ingredients_drink_part1 = 0;
  $ingredients_drink_part2 = 0;
  $decide_drink_part1 = 0;
  $decide_drink_part2 = 0;
  //%authenticate_this = 1;
  tab_cancel1.setPositionX(85.687);
  tab_cancel1.setPositionY(40.883);
 }
}

function cue_tab1::cease_all( % this) {

 if ($tutorial_cue_tab_control == 0) {
  cue_tab1.setAnimation(cue_tab_down3Animation);
  cue_tab2.setAnimation(cue_tab_down3Animation);
  cue1_fruit.setImageMap(want_emptyImageMap);
  cue2_fruit.setImageMap(want_emptyImageMap);
  $cue_tab1_alpha = 1;
  $cue_tab1_alpha_b = 1;
  $toggle_cue_tab1_fade = 0;
  $toggle_cue_tab1_fade_b = 0;
  $cue_tab1_blendcolor = "1 1 1 1";
  $cue_tab1_blendcolor_b = "1 1 1 1";
  cue_tab1.BlendColor = "1 1 1 1";
  cue_tab2.BlendColor = "1 1 1 1";
  tab_cancel1.setPositionX(85.687);
  tab_cancel1.setPositionY(40.883);
  $decide_drink_part1 = 0;
  $decide_drink_part2 = 0;
  $ingredients_drink_part1 = 0;
  $ingredients_drink_part2 = 0;
 }
}

function cue_tab1::cease_colors( % this) {
 $cue_tab1_alpha = 1;
 $cue_tab1_alpha_b = 1;
 $toggle_cue_tab1_fade = 0;
 $toggle_cue_tab1_fade_b = 0;
 $cue_tab1_blendcolor = "1 1 1 1";
 $cue_tab1_blendcolor_b = "1 1 1 1";
 cue_tab1.BlendColor = "1 1 1 1";
 cue_tab2.BlendColor = "1 1 1 1";
}

function red_out_everything() {
 sodajerk1.BlendColor = "1 0 0 1";
 sodajerk2.BlendColor = "1 0 0 1";
 sodajerk3.BlendColor = "1 0 0 1";
 sodajerk4.BlendColor = "1 0 0 1";
 button_red_fruit.BlendColor = "1 0 0 1";
 button_orange_fruit.BlendColor = "1 0 0 1";
 button_yellow_fruit.BlendColor = "1 0 0 1";
 button_green_fruit.BlendColor = "1 0 0 1";
 button_blue_fruit.BlendColor = "1 0 0 1";
 button_purple_fruit.BlendColor = "1 0 0 1";
 button_swap.BlendColor = "1 0 0 1";
 hint_serve_yo_drinks.setAnimation(serve_yo_drinksAnimation);
}

function red_out_everything2() {
 sodajerk1.BlendColor = "1 0 0 1";
 sodajerk2.BlendColor = "1 0 0 1";
 sodajerk3.BlendColor = "1 0 0 1";
 sodajerk4.BlendColor = "1 0 0 1";
 button_red_fruit.BlendColor = "1 0 0 1";
 button_orange_fruit.BlendColor = "1 0 0 1";
 button_yellow_fruit.BlendColor = "1 0 0 1";
 button_green_fruit.BlendColor = "1 0 0 1";
 button_blue_fruit.BlendColor = "1 0 0 1";
 button_purple_fruit.BlendColor = "1 0 0 1";
 button_swap.BlendColor = "1 0 0 1";
 hint_serve_yo_drinks.setAnimation(serve_yo_drinksAnimation);
 hint_serve_yo_drinks2.setAnimation(serve_yo_drinksAnimation);
}

function red_out_everything3() {
 sodajerk1.BlendColor = "1 0 0 1";
 sodajerk2.BlendColor = "1 0 0 1";
 sodajerk3.BlendColor = "1 0 0 1";
 sodajerk4.BlendColor = "1 0 0 1";
 button_red_fruit.BlendColor = "1 0 0 1";
 button_orange_fruit.BlendColor = "1 0 0 1";
 button_yellow_fruit.BlendColor = "1 0 0 1";
 button_green_fruit.BlendColor = "1 0 0 1";
 button_blue_fruit.BlendColor = "1 0 0 1";
 button_purple_fruit.BlendColor = "1 0 0 1";
 button_swap.BlendColor = "1 0 0 1";
 hint_serve_yo_drinks2.setAnimation(serve_yo_drinksAnimation);
}


function unred_out_everything() {
 sodajerk1.BlendColor = "1 1 1 1";
 sodajerk2.BlendColor = "1 1 1 1";
 sodajerk3.BlendColor = "1 1 1 1";
 sodajerk4.BlendColor = "1 1 1 1";
 button_red_fruit.BlendColor = "1 1 1 1";
 button_orange_fruit.BlendColor = "1 1 1 1";
 button_yellow_fruit.BlendColor = "1 1 1 1";
 button_green_fruit.BlendColor = "1 1 1 1";
 button_blue_fruit.BlendColor = "1 1 1 1";
 button_purple_fruit.BlendColor = "1 1 1 1";
 button_swap.BlendColor = "1 1 1 1";
}

function au_box::alpha_up() {
 echo("au_box::alpha_UP() @ $au_alpha_already_up = "
  @ $au_alpha_already_up @ " $au_alpha_already_down = "
  @ $au_alpha_already_down);
 //edit 02-26-2014 this IF prevents oversetting the alpha up toggle, eg. if 0.9 hits 1, up_toggle will hit zero but reschedule will hit this function again and set it back to 1 and break the alpha down schedule
 if ($au_alpha_already_up_set_zero != 1) {
  //edit 02-26-2014 this is the toggle for alpha increment up
  $au_alpha_already_up = 1;
 }
 echo("alpha % = "
  @ $au_box_alpha_level @ " UP = "
  @ $au_alpha_already_up);
 if ($toggle_trophy_start == 1) {
  if ($au_box_alpha_level < 1 & $au_alpha_already_down != 1) {
   $au_box_alpha_level += 0.1;
   au_box.setBlendAlpha($au_box_alpha_level);
   trophy_gold_bar.setBlendAlpha($au_box_alpha_level);
   achievement_unlocked_text.setBlendAlpha($au_box_alpha_level);
   au_box.schedule(60, "alpha_up", 0);
  }
  if ($au_box_alpha_level >= 1 & $cease_au_box_alpha == 1) {
   $toggle_trophy_end = 1;
   if ($au_alpha_already_down != 1) {
    $au_alpha_already_up = 0;
    $au_alpha_already_up_set_zero = 1;
    $au_alpha_already_down_set_zero = 0;
    echo("UP#2 = "
     @ $au_alpha_already_up);
    au_box.schedule(6000, "alpha_down", 0);
   }
   $toggle_trophy_start = 0;
  }
 }
}

function au_box::alpha_down() {
 echo("au_box::alpha_DOWN() @ $au_alpha_already_up = "
  @ $au_alpha_already_up @ " $au_alpha_already_down = "
  @ $au_alpha_already_down);
 echo("alpha % = "
  @ $au_box_alpha_level);
 //edit 02-26-2014 this IF makes it so if this doesn't pass, it skips back to alpha_up, repeats the fader schedules normally, and fades out after the same delay if an award is won simultaneously
 if ($au_alpha_already_up != 1 & $au_alpha_already_down_set_zero != 1) {
  //edit 02-26-2014 this toggles alpha decrement down
  $au_alpha_already_down = 1;
 }
 if ($toggle_trophy_end == 1) {
  if ($au_box_alpha_level > 0 & $au_alpha_already_up != 1) {
   $cease_au_box_alpha = 0;
   $au_box_alpha_level -= 0.1;
   au_box.setBlendAlpha($au_box_alpha_level);
   trophy_gold_bar.setBlendAlpha($au_box_alpha_level);
   achievement_unlocked_text.setBlendAlpha($au_box_alpha_level);
   au_box.schedule(60, "alpha_down", 0);
  }
  if ($au_box_alpha_level <= 0) {
   achievement_unlocked_text.text = " ";
   $cease_au_box_alpha = 0;
   au_sparkle_emitter.setPositionX(161.827);
   au_sparkle_emitter.setPositionY(39.141);
   $toggle_trophy_end = 0;
   $au_alpha_already_down = 0;
   $au_alpha_already_up_set_zero = 0;
   $au_alpha_already_down_set_zero = 1;
  }

 }
}

function play_achievement() {
 echo("function play_achievement");
 achievement_unlocked_text.font = "cambo";
 achievement_unlocked_text.text = ""
 @ $award_unlocked @ ""
 @ $this_award_text;
 au_box.setImageMap($this_award_image); % resize_award_x = $this_award_size_x * 0.62; % resize_award_y = $this_award_size_y * 0.62;
 au_box.setSize( % resize_award_x, % resize_award_y);
 au_box.setFrame($this_award_frame);
 au_box.alpha_up();
 $cease_au_box_alpha = 1;
 au_sparkle_emitter.setPositionX(143.666);
 au_sparkle_emitter.setPositionY(31.695);
 au_sparkle_emitter.setEffectLifeMode(STOP, 1.0);
 au_sparkle_emitter.playEffect();
}

function bitmap_font_test::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  bitmap_font_test.removeAllFontSizes();
  bitmap_font_test.addFontSize(24);
  bitmap_font_test.font = "Cambo";
 }
}

//Manually Delete When Needed *RECIPROCATING FONT*.uft from cache(AppData) or else massive in program bitmap-interpolation overwrite will occur to make it look like f'ed greek letters
//populateFonts()		  identifies all fonts cached to game
//fontbitmapIO(false)    font bitmaps will be overwritten with new b&w ones
//replace bitmap         make perty (102 seems necessary, current read is generally off 18 tho)
//fontbitmapIO(true)	rewrites NEW BITMAP > VECTOR > BITMAP > CACHE PERMANENTLY IN GAME
//golden!


function populateFonts() {
 $bitmap_font_name = "Cambo"; % font = $bitmap_font_name; % sizes = "18 24 32 36 102";
 // ---  
 for ( % i = 0; % i < getWordCount( % sizes); % i++)
  populateFontCacheRange( % font, getWord( % sizes, % i), 32, 126);

 writeFontCache();
}

function fontbitmapIO( %
 import) {
 $bitmap_font_name = "Cambo"; % pngdir = "pngs/"; % fontdir = "C:/Users/Roger/Desktop/Project_MonsterShake/torque/Monster_Shake/game/data/cache/";
 % font = $bitmap_font_name;
 % sizes = "18 24 32 36 102";
 // ---  
 for ( % i = 0; % i < getWordCount( % sizes); % i++) { % size = getWord( % sizes, % i);

  % weight = 3;
  % fileName = % fontdir @ % pngdir @ % font SPC % size @ ".png";
  //%fileName.close();		  
  if ( %
   import)
   importCachedFont( % font, % size, % fileName, % weight, 0);
  else
   exportCachedFont( % font, % size, % fileName, % weight, 0);
 }

 writeFontCache();
}

function write_a_bitmap_font() {
 $bitmap_font_name = "Cambo 102";
 populateFonts();
 fontbitmapIO(); % export_name = "C:/Users/Roger/Desktop/Project_MonsterShake/torque/Monster_Shake/game/data/cache/pngs/"
 @ $bitmap_font_name @ ".png";
 //%export_name = "~/game/data/cache/pngs/" @ $bitmap_font_name @ ".png";
 exportCachedFont($bitmap_font_name, "24", % export_name, 3, 0);
}

function save_a_bitmap_font() {
 $bitmap_font_name = "Cambo 102";
 populateFonts();
 fontbitmapIO(); % export_name = "C:/Users/Roger/Desktop/Project_MonsterShake/torque/Monster_Shake/game/data/cache/pngs/"
 @ $bitmap_font_name @ ".png";
 //%export_name = "~/game/data/cache/pngs/" @ $bitmap_font_name @ ".png";
 importCachedFont($bitmap_font_name, "24", % export_name, 3, 0);
}

function win_this_trophy() {
 echo("win this trophy @ $root_trophy_identfier " @ $root_trophy_identfier); 
 % root_trophy_activation_test = "trophy_" @ $root_trophy_identfier @ "_activated";

 if ($_[ % root_trophy_activation_test] != 1) {
  echo("PASSED root trophy activation test"); 
  % root_trophy_finder = "trophy_"
  @ $root_trophy_identfier; 
  % root_trophy_name = "trophy_"
  @ $root_trophy_identfier @ "_name"; 
  % root_trophy_description = "trophy_"
  @ $root_trophy_identfier @ "_description"; 
  % root_trophy_image = "trophy_"
  @ $root_trophy_identfier @ "_image"; 
  % root_trophy_frame = "trophy_"
  @ $root_trophy_identfier @ "_frame"; 
  % root_trophy_sizex = "trophy_"
  @ $root_trophy_identfier @ "_sizex"; 
  % root_trophy_sizey = "trophy_"
  @ $root_trophy_identfier @ "_sizey"; 
  % root_trophy_activated = "trophy_"
  @ $root_trophy_identfier @ "_activated";
  $_[ % root_trophy_activated] = 1;
  //use this if [] doesnt work
  //achievement_unlocked_text.text = "" @ $award_unlocked @ "" @ $this_award_text;
  $this_award_text = $_[ % root_trophy_name];
  $this_award_image = $_[ % root_trophy_image];
  $this_award_frame = $_[ % root_trophy_frame];
  $this_award_size_x = $_[ % root_trophy_sizex];
  $this_award_size_y = $_[ % root_trophy_sizey];
  $toggle_trophy_start = 1; % root_trophy_finder.BlendColor = "1 1 1 1";

  play_achievement();
 }
}

function prestart_fader::alpha_up() {
 if ($start_prestart_fader == 1) {
  if ($prestart_fader_alpha_level < 1) {
   $prestart_fader_alpha_level += 0.1;
   prestart_fader.setBlendAlpha($prestart_fader_alpha_level);
   prestart_fader.schedule(60, "alpha_up", 0);
  }
  if ($prestart_fader_alpha_level >= 1 & $cease_prestart_fader == 1) {
   $screen_position_x = 0;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
   $cease_prestart_fader = 2;
  }
 }
}

function callie::idle() {
 callie.setAnimation(callie_idle3Animation);
 $suspend_callie = 0;
}

//callie.signal();
function callie::signal() {
 callie.setAnimation(callie_oneplease2Animation);
 callie.schedule(1100, "idle", 0);
}

//callie.point_out();
function callie::point_out() {
 callie.setAnimation(callie_custspawnAnimation);
 callie.schedule(2200, "idle", 0);
}

//callie.shame();
function callie::shame() {
 callie.setAnimation(callie_shameAnimation);
 callie.schedule(2100, "idle", 0);
}

//callie.god_touch();
function callie::god_touch() {
 callie.setAnimation(callie_god_touchAnimation);
 callie.schedule(1200, "idle", 0);
}

function callie::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ($suspend_callie != 1) {
   callie.schedule(1200, "god_touch", 0);
   $suspend_callie = 1;
  }
 }
}



function setCorrectScreenRatio() { % screenWidth = getWord(Canvas.extent, 0); % screenHeight = getWord(Canvas.extent, 1);

 % screenRatio = % screenWidth / % screenHeight; % optimalRatio = 1024.0 / 768.0; // WLS - Our Design resolution  
 % newWidth = % screenWidth; % newHeight = % screenHeight;
 if ( % screenRatio < % optimalRatio)
  % newHeight = % screenWidth / % optimalRatio;
 else if ( % screenRatio > % optimalRatio)
  % newWidth = % screenHeight * % optimalRatio; % newX = ( % screenWidth - % newWidth) / 2.0; % newY = ( % screenHeight - % newHeight) / 2.0;
 sceneWindow2D.setPosition( % newX, % newY);
 sceneWindow2D.setExtent( % newWidth, % newHeight);
}

function sodajerk::redify( % this) {
 //note: was red, now is yellow
 % this_sodajerk_num = % this.cook_num;
 % this_sodajerk = "sodajerk"
 @ % this_sodajerk_num; 
 % cook_red_stop = $cook_red_stop[ % this_sodajerk_num]; 
 % cook_is_red_because_zero = $cook_is_red_because_zero[ % this_sodajerk_num]; 
 % cook_redness = $cook_redness[ % this_sodajerk_num];

 if ( % cook_red_stop != 1) {

  if ( % cook_redness < 0.99 & % cook_redness > 0.8 & % cook_is_red_because_zero != 0) {
   % this_sodajerk.schedule(80, "redify_up", 0, % this);
  }
  if ( % cook_redness <= 0.8 & % cook_is_red_because_zero != 0) {
   % cook_redness = 0.8; % cook_is_red_because_zero = 0;
  }
  if ( % cook_redness >= 0.8 & % cook_redness < 0.99 & % cook_is_red_because_zero == 0) {
   % this_sodajerk.schedule(80, "redify_down", 0, % this);
  }
  if ( % cook_redness >= 1 & % cook_is_red_because_zero == 0) {
   % cook_redness = 1; % cook_is_red_because_zero = 1; % this_sodajerk.schedule(110, "reset", 0, % this);
  }
 }
 if ( % cook_red_stop == 1) { % this_sodajerk.BlendColor = "1 1 1 1";
 }
}

function sodajerk::redify_up( % this) {

 % this_sodajerk_num = % this.cook_num; % this_sodajerk = "sodajerk" @ % this_sodajerk_num; % cook_redness = $cook_redness[ % this_sodajerk_num];
 % this_drink = "drink_in" @ % this_sodajerk_num; % cook_red_stop = $cook_red_stop[ % this_sodajerk_num];

 if ( % cook_red_stop != 1) {
  $cook_redness[ % this_sodajerk_num] -= 0.025; % cook_redness_numbers = "1 "  @ % cook_redness @ " " @ % cook_redness @ " 1"; % this_sodajerk.BlendColor = % cook_redness_numbers; 
  % this_drink.BlendColor = % cook_redness_numbers; % this_sodajerk.schedule(60, "redify", 0);
 }
}

function sodajerk::redify_down( % this) { 
 % this_sodajerk_num = % this.cook_num; % this_sodajerk = "sodajerk" @ % this_sodajerk_num; % cook_redness = $cook_redness[ % this_sodajerk_num];
 % this_drink = "drink_in" @ % this.cook_num; % cook_red_stop = $cook_red_stop[ % this_sodajerk_num];

 if ( % cook_red_stop != 1) {
  $cook_redness[ % this_sodajerk_num] += 0.025; % cook_redness_numbers = "1 "  @ % cook_redness @ " "  @ % cook_redness @ " 1"; 
  % this_sodajerk.BlendColor = % cook_redness_numbers; % this_drink.BlendColor = % cook_redness_numbers; 
  % this_sodajerk.schedule(60, "redify", 0);
 }
}

function sodajerk::reset( % this) { % cook_red_stop = $cook_red_stop[ % this_sodajerk_num];

 if ( % cook_red_stop != 1) { 
  % this_sodajerk_num = % this.cook_num; % this_sodajerk = "sodajerk" @ % this_sodajerk_num; 
  % cook_redness = $cook_redness[ % this_sodajerk_num];
  echo("reset" @ % this_sodajerk); % cook_redness = 0.98; % this_sodajerk.schedule(10, "redify", 0);
 }
}

function callie_popup_777::activate_all( % this) {
 callie_popup_777.schedule(10, "pop_up", 0);
 callie_popup_777.schedule(1500, "move_left", 0);
 callie_popup_777.schedule(1750, "move_right", 0);
 callie_popup_777.schedule(2000, "move_left", 0);
 callie_popup_777.schedule(2250, "move_right", 0);
 callie_popup_777.schedule(2500, "move_left", 0);
 callie_popup_777.schedule(2750, "move_right", 0);
 callie_popup_777.schedule(3000, "pop_down", 0);
}

function callie_popup_777::pop_up( % this) {
 if ($activate_callie_777 == 1) {
  if ($mute_soundfx != 1) {
   alxPlay(slot_machine);
  }
  $callie_popup_start_x = 135;
  $callie_popup_start_y = 52;
  $callie_popup_end_x = 135;
  $callie_popup_end_y = 24;
  callie_popup_777.moveTo($callie_popup_end_x, $callie_popup_end_y, 30, true, true, true, 0.1);
 }
}

function callie_popup_777::move_left( % this) {
 callie_popup_777.setPositionX(134);
}

function callie_popup_777::move_right( % this) {
 callie_popup_777.setPositionX(135);
}

function callie_popup_777::pop_down( % this) {
 $activate_callie_777 = 0;
 $callie_popup_start_x = 135;
 $callie_popup_start_y = 52;
 $callie_popup_end_x = 135;
 $callie_popup_end_y = 24;
 callie_popup_777.moveTo($callie_popup_start_x, $callie_popup_start_y, 10, true, true, true, 0.1);
}

function fade_ui_heads() {
 //4 frames per set * (world 1 - 1) = 4 * (0) = 0
 //4 frames per set * (world 2 - 1) = 4 * (1) = 4
 % world_interpret = 4 * ($world_numeral - 1);
 //(char 1 + 0) - 1 = (1) - 1 = frame 0 (aka set 1, first frame)
 //(char 1 + 4) - 1 = (5) - 1 = frame 4 (aka set 2, first frame)
 % head1_frame = ($clocked_char + % world_interpret) - 1;
 ui_head1.setFrame( % head1_frame);

 //special chars
 if ($prechosen_seat_num_for_special_char == $clocked_char & $toggle_off_special_char_for_round != 1) {
  if ($world_numeral == 3) {
   ui_head1.setFrame(40);
  }
  if ($world_numeral == 4) {
   ui_head1.setFrame(44);
  }
  if ($world_numeral == 8) {
   ui_head1.setFrame(41);
  }
  if ($world_numeral == 9) {
   ui_head1.setFrame(42);
  }
  if ($world_numeral == 10) {
   ui_head1.setFrame(43);
  }
 }
 //determine other 3 heads based on ui_head1!
 if ($clocked_char == 1) { % head2_frame = (2 + % world_interpret) - 1; % head3_frame = (3 + % world_interpret) - 1; % head4_frame = (4 + % world_interpret) - 1;
  ui_head2.setFrame( % head2_frame);
  ui_head3.setFrame( % head3_frame);
  ui_head4.setFrame( % head4_frame);
 }

 if ($clocked_char == 2) { % head2_frame = (3 + % world_interpret) - 1; % head3_frame = (4 + % world_interpret) - 1; % head4_frame = (1 + % world_interpret) - 1;
  ui_head2.setFrame( % head2_frame);
  ui_head3.setFrame( % head3_frame);
  ui_head4.setFrame( % head4_frame);
 }

 if ($clocked_char == 3) { % head2_frame = (4 + % world_interpret) - 1; % head3_frame = (1 + % world_interpret) - 1; % head4_frame = (2 + % world_interpret) - 1;
  ui_head2.setFrame( % head2_frame);
  ui_head3.setFrame( % head3_frame);
  ui_head4.setFrame( % head4_frame);
 }

 if ($clocked_char == 4) { % head2_frame = (1 + % world_interpret) - 1; % head3_frame = (2 + % world_interpret) - 1; % head4_frame = (3 + % world_interpret) - 1;
  ui_head2.setFrame( % head2_frame);
  ui_head3.setFrame( % head3_frame);
  ui_head4.setFrame( % head4_frame);
 }

}

function reset_credits_position() {
 credits_list.setPositionX($credits_start_x);
 credits_list.setPositionY($credits_start_y);
}

function comptroller::roll_credits() {
 storyboard.schedule(39000, "reset_game", 0);
 sceneWindow2d.setCurrentCameraPosition(200, 150, $horizontal_scaling, 75);
 the_end.setBlendAlpha(0);
 $credits_start_x = 200;
 $credits_start_y = 247.760;
 $credits_end_x = 200;
 $credits_end_y = 54.166;
 credits_list.moveTo($credits_end_x, $credits_end_y, 5, true, true, true, 0.1);
}

function repair_damaged_storyboards() {
 //edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
 erase_usage_of_cooks();
 if ($world_numeral == 1) {
  storyboard.setImageMap(storyboard_castle_finalImageMap);
 }
 if ($world_numeral == 2) {
  storyboard.setImageMap(storyboard_swamp_finalImageMap);
 }
 if ($world_numeral == 3) {
  storyboard.setImageMap(storyboard_airship_finalImageMap);
 }
 if ($world_numeral == 4) {
  storyboard.setImageMap(storyboard_hawaii_finalImageMap);
 }
 if ($world_numeral == 5) {
  storyboard.setImageMap(storyboard_meadhall_finalImageMap);
 }
 if ($world_numeral == 6) {
  storyboard.setImageMap(storyboard_haunted_finalImageMap);
 }
 if ($world_numeral == 7) {
  storyboard.setImageMap(storyboard_train_finalImageMap);
 }
 if ($world_numeral == 8) {
  storyboard.setImageMap(storyboard_france_finalImageMap);
 }
 if ($world_numeral == 9) {
  storyboard.setImageMap(storyboard_newyork_finalImageMap);
 }
 if ($world_numeral == 10) {
  storyboard.setImageMap(storyboard_hometown_finalImageMap);
 }
}

function repair_damaged_levsels() { 
% level_button_bitmap = "levsel_world" @ $world_numeral @ "_buttonImageMap"; 
% level_bkgd_bitmap = "levsel_bkgd_" @ $world_numeral @ "ImageMap";
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
}

function repair_outdated_levsel_buttons() {
 if (levsel_1.unlocked == 0) {
  levsel_1.setFrame(3);
 }
 if (levsel_2.unlocked == 0) {
  levsel_2.setFrame(3);
 }
 if (levsel_3.unlocked == 0) {
  levsel_3.setFrame(3);
 }
 if (levsel_4.unlocked == 0) {
  levsel_4.setFrame(3);
 }
 if (levsel_5.unlocked == 0) {
  levsel_5.setFrame(3);
 }
 if (levsel_6.unlocked == 0) {
  levsel_6.setFrame(3);
 }
 if (levsel_7.unlocked == 0) {
  levsel_7.setFrame(3);
 }
 if (levsel_8.unlocked == 0) {
  levsel_8.setFrame(3);
 }
 if (levsel_9.unlocked == 0) {
  levsel_9.setFrame(3);
 }
 if (levsel_10.unlocked == 0) {
  levsel_10.setFrame(3);
 }
}

function reset_trophy_iterators() {
 $find_chars_served = 0;
 $coin_tips_per_round_collected = 0;
 $flying_coins_collected = 0;
 $trophy_no_angry_customers = 0;
 $vortexes_collected = 0;
 $total_combo_level = 0;
}

function clear_out_dirty_cups_for_good() {
 dirty_extra_cup1.setAnimation(empty_char_spaceAnimation);
 dirty_extra_cup2.setAnimation(empty_char_spaceAnimation);
 dirty_extra_cup3.setAnimation(empty_char_spaceAnimation);
 dirty_extra_cup4.setAnimation(empty_char_spaceAnimation);
 dirty_extra_cup1.active = 0;
 dirty_extra_cup2.active = 0;
 dirty_extra_cup3.active = 0;
 dirty_extra_cup4.active = 0;
 smellyb1.setAnimation(empty_char_spaceAnimation);
 dirty_glow1.setAnimation(empty_char_spaceAnimation);
 pointer_tip1.setAnimation(empty_char_spaceAnimation);
 smellyb2.setAnimation(empty_char_spaceAnimation);
 dirty_glow2.setAnimation(empty_char_spaceAnimation);
 pointer_tip2.setAnimation(empty_char_spaceAnimation);
 smellyb3.setAnimation(empty_char_spaceAnimation);
 dirty_glow3.setAnimation(empty_char_spaceAnimation);
 pointer_tip3.setAnimation(empty_char_spaceAnimation);
 smellyb4.setAnimation(empty_char_spaceAnimation);
 dirty_glow4.setAnimation(empty_char_spaceAnimation);
 pointer_tip4.setAnimation(empty_char_spaceAnimation);
}