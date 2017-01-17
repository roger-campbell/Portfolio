// ***************************************************************************************
// File Name:   game.cs
// Author:      Roger Campbell 
// Purpose:     Initial loading of the game
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function startGame( % level) {
 exec("./pre_done_button.cs");
 exec("./startButton.cs");
 exec("./optionsButton.cs");
 exec("./exitButton.cs");
 exec("./profileButton.cs");
 exec("./profile_cancel_button.cs");
 exec("./profileInput1.cs");
 exec("./profilecheck1.cs");
 exec("./testtimer.cs");
 exec("./tutNoButton.cs");
 exec("./char_button.cs");
 exec("./inventory.cs");
 exec("./ui_button_apple.cs");
 exec("./ui_button_orange.cs");
 exec("./ui_button_yellow.cs");
 exec("./ui_button_green.cs");
 exec("./ui_button_blue.cs");
 exec("./ui_button_purple.cs");
 exec("./ui_button_swap.cs");
 exec("./cooks.cs");
 exec("./waiter.cs");
 exec("./coin_tip.cs");
 exec("./drink_out.cs");
 exec("./waiter_cancel.cs");
 exec("./ui_generic_buttons.cs");
 exec("./game_text.txt");
 exec("./map_functions.cs");
 exec("./level_fx.cs");

 Canvas.setContent(mainScreenGui);
 if ($toggle_off_custom_cursors != 1) {
  Canvas.setCursor(DefaultCursor);
 }
 new ActionMap(moveMap);
 moveMap.push();
 $enableDirectInput = true;
 activateDirectInput();
 enableJoystick();
 sceneWindow2D.setUseObjectMouseEvents(true);
 sceneWindow2D.loadLevel( % level);
 $screen_position_x = -100;
 $screen_position_y = 75;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
 if ($window_mode == 1) {
  button_options_window.setFrame(3);
  button_options_full.setFrame(0);
  button_options_stretch.setFrame(0);
  button_options_stretchb.setFrame(0);
 }

 /* edit 08-09-2013 New Check System for whether game has ever been played or not */
 $sfile = new FileObject();
 if ($sfile.openForRead("./data/profile_finder.ccf")) {
  $profile_for_this_session = $sfile.readLine();
  echo("\c2 identify profile as " @ $profile_for_this_session);
  $sfile.close();
 }
 //this means game has been started before
 if ($profile_for_this_session >= 1) {
  convert_all_text_to_bitmap();
  $screen_position_x = -200;
  $screen_position_y = 75;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  if ($window_mode == 1) {
   button_options_window.setFrame(3);
   button_options_full.setFrame(0);
   button_options_stretch.setFrame(0);
   button_options_stretchb.setFrame(0);
  }
  hide_ui_mouse_or_pad();
 }
 //this means game has never been started before
 else {
  $first_game_ever_played_predetected = 1;
  convert_all_text_to_bitmap();
  $screen_position_x = -200;
  $screen_position_y = 75;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  button_options_window.setFrame(3);
  button_options_full.setFrame(0);
  button_options_stretch.setFrame(0);
  button_options_stretchb.setFrame(0);
  //force profile slot to enter automatically without selecting
  //edit 02-06-2014 adding extra bits for first ever play only
  $profile_has_been_moused_down = 1;
  $profile_downed = 1;
  $input_to_profile_slot = 1;
  prof_name_input_field0.text = "";
  blinky_underscore.animate_blinky_underscore1();
  show_ui_mouse_or_pad();
 }
}

function show_ui_mouse_or_pad() {
 ui_mouse_or_pad.setPositionX(-200.000);
 button_question_mouse.setPositionX(-212.691);
 button_question_pad.setPositionX(-187.796);
 initialize_game_button.setPositionX(-270);
 $first_game_ever_ever = 1;
}

function question_mouse::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $screen_position_x = -100;
  $screen_position_y = 75;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  $black_heart_pass = 1;
 }
}

function question_mouse::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  button_question_mouse.setFrame(2);
 }
}

function question_mouse::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 button_question_mouse.setFrame(1);
}

function question_mouse::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 button_question_mouse.setFrame(0);
}

function question_pad::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $screen_position_x = -100;
  $screen_position_y = 75;
  activate_side_borders();
  sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
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
  $touchpad_activated = 1;
  $black_heart_pass = 1;
 }
}

function question_pad::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  button_question_pad.setFrame(2);
 }
}

function question_pad::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 button_question_pad.setFrame(1);
}

function question_pad::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 button_question_pad.setFrame(0);
}

function hide_ui_mouse_or_pad() {
 ui_mouse_or_pad.setPositionX(-300.000);
 button_question_mouse.setPositionX(-312.691);
 button_question_pad.setPositionX(-287.796);
 initialize_game_button.setPositionX(-200);
}

function calculate_screen2() { % res = getDesktopResolution();
 $desktopWidth = getWord( % res, 0);
 $desktopHeight = getWord( % res, 1);
 $bpp = getWord( % res, 2);
 setScreenMode($desktopWidth, $desktopHeight, $bpp, $fullScreen);
}

function convert_all_text_to_bitmap() {
 storyboard_text.font = "cambo";
 skip_button.font = "cambo";
 prof_name_input_field0.font = "cambo";
 text_soundfx_level.font = "cambo";
 text_music_level.font = "cambo";
 options_warning.font = "cambo";
 game_pause_text.font = "cambo";
 game_fail_text.font = "cambo";
 menu_coinage_left.font = "cambo";
 appetizer1_cost.font = "cambo";
 appetizer2_cost.font = "cambo";
 appetizer1_amt.font = "cambo";
 appetizer2_amt.font = "cambo";
 appetizer1_amt_ingame.font = "cambo";
 appetizer2_amt_ingame.font = "cambo";
 profile_name_warning.font = "cambo";
 profile_name_warning2.font = "cambo";
 profile_name_warning.setBlendAlpha(0);
 profile_name_warning2.setBlendAlpha(0);
 prof_name_input_field1.font = "cambo";
 prof_name_input_field2.font = "cambo";
 prof_name_input_field3.font = "cambo";
 prof_name_input_field4.font = "cambo";
 ui_label_points_text.font = "cambo";
 ui_label_coins_text.font = "cambo";
 ui_label_level_text.font = "cambo";
 award_left_text.font = "cambo";
 award_right_text.font = "cambo";
 points_number.font = "cambo";
 score_number.font = "cambo";
 level_number.font = "cambo";
 ui_outof.font = "cambo";
 hint_bonus1.font = "cambo";
 hint_bonus2.font = "cambo";
 hint_bonus3.font = "cambo";
 tutorial_extended_text1.font = "cambo";
 tutorial_extended_text2.font = "cambo";
 appetizer1_tag.font = "cambo";
 appetizer2_tag.font = "cambo";
 entertainer1_tag.font = "cambo";
 entertainer2_tag.font = "cambo";
 entertainer1_cost.font = "cambo";
 entertainer2_cost.font = "cambo";
 hint_bonus1.setBlendAlpha(0);
 hint_bonus2.setBlendAlpha(0);
 hint_bonus3.setBlendAlpha(0);
 the_end.font = "cambo";
 credits_list.font = "cambo";
 order_menu_world.font = "cambo";
 employee_info_display.font = "cambo";
 employee_info_display2.font = "cambo";
 _prof_name_input_field1.font = "cambo";
 _dynamic_name_slot.font = "cambo";
 _levsel_menu_text.font = "cambo";
 _levsel_map_text.font = "cambo";
 _menu_coinage_left.font = "cambo";
 _levsel_world_text.font = "cambo";
 read_from_unique_save_file();
}

function onLevelLoaded( % this, % scenegraph) { % this.testtimer();
}
// endGame
function endGame() {
 sceneWindow2D.endLevel();
 moveMap.pop();
 moveMap.delete();
}