// ***************************************************************************************
// File Name:   ui_button_blue.cs
// Author:      Roger Campbell 
// Purpose:     In-game selection menu button and all it interacts with 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function ui_button_blue_fruit::onAdd( % this) { % this.setUseMouseEvents(true);
 //$number_of_waiters = 0;
 //this is stictly for testing purposes, no waiter control should be established here
 $number_of_idle_waiters = 1;
 $decide_drink_part1 = 0;
 $decide_drink_part2 = 0;
 $ingredients_drink_part1 = 0;
 $ingredients_drink_part2 = 0; % authenticate_this = 0; % inform_waiter_fruit_wanted_is = 0;
}

function ui_button_blue_fruit::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ($disable_ui_and_rgbp_swap != 1 & $tut_char_fruit_choices != 1) {
   button_blue_fruit.BlendColor = "1 0.7 0.7 0.9";
  }
 }
}

function ui_button_blue_fruit::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ($disable_ui_and_rgbp_swap != 1 & $tut_char_fruit_choices != 1) {
   unred_out_everything();
  }
 }
}

function ui_button_blue_fruit::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $disable_fruits_temporarily_due_to_swap_mousedown_error != 1) {
  if ($THE_GAME_IS_PAUSED != 1) {
   $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing; % check_to_see_if_drink_out_blocked = drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status;
   if ( % check_to_see_if_drink_out_blocked == 4) {
    red_out_everything();
   }
   if ($until_tut_char_is_activated_dont_do_fruits != 1 & % check_to_see_if_drink_out_blocked != 4) {
    if ($tut_char_fruit_choices == 2) {
     button_blue_fruit.BlendColor = "1 0 0 1";
    }
    if ($disable_ui_and_rgbp_swap != 1 & $tut_char_fruit_choices != 2) {
     //edit 02-12-2014 if every chef is busy and all drink_outs are clogged, red up chefs
     % check_to_see_if_drink_out_blocked = drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status;
     if ( % check_to_see_if_drink_out_blocked < 4 & % check_to_see_if_drink_out_blocked > 0 & $calculate_all_sodajerks_business >= 4) {
      red_out_everything2();
     }
     if ( % check_to_see_if_drink_out_blocked == 0 & $calculate_all_sodajerks_business >= 4) {
      red_out_everything3();
     }

     click_sonar.BlendColor = "1 1 1 0.4"; % char_x = % this.getPositionX(); % char_y = % this.getPositionY();
     click_sonar.setPositionX( % char_x);
     click_sonar.setPositionY( % char_y);
     click_sonar.setAnimation(click_faderAnimation);
     button_blue_fruit.BlendColor = "0.5 0.5 0.5 1";
     //if inventory has enough, go ahead

     if ($fruit_frame == 0 & $inv_blueberry > 0) { 
	  % authenticate_this = 1;
      $inv_blueberry += 1; 
	  % inform_waiter_fruit_wanted_is = 5;
      echo("inv_blueberry: " @ $inv_blueberry);
      $identify_corresponding_image = "button_blue_fruits3ImageMap";
      $identify_corresponding_frame = 0;
     }

     if ($fruit_frame == 1 & $inv_currant > 0) { 
	  % authenticate_this = 1;
      $inv_currant += 1; 
	  % inform_waiter_fruit_wanted_is = 11;
      echo("inv_currant: " @ $inv_currant);
      $identify_corresponding_image = "button_blue_fruits3ImageMap";
      $identify_corresponding_frame = 1;
     }

     if ($fruit_frame == 2 & $inv_plum > 0) { 
	  % authenticate_this = 1;
      $inv_plum += 1; 
	  % inform_waiter_fruit_wanted_is = 17;
      echo("inv_plum: " @ $inv_plum);
      $identify_corresponding_image = "button_blue_fruits3ImageMap";
      $identify_corresponding_frame = 2;
     }

     //if inventory is bare, halt clicking

     if ($fruit_frame == 0 & $inv_blueberry <= 0) { 
	  % authenticate_this = 0;
     }

     if ($fruit_frame == 1 & $inv_currant <= 0) { 
	  % authenticate_this = 0;
     }

     if ($fruit_frame == 2 & $inv_plum <= 0) { 
	  % authenticate_this = 0;
     }
     $check_cue_number += 1;
     //Note- As this is a button MouseDown state, it will only perform one of these functions singularly 
     //So it doesn't run through all commands at once eg. if true then var = 1, if2 = true & var = 1 then blah = 2, its written out of order (backwards) aka:
     //If UI button to assemble second half of drink hasn't been clicked, do so
     //If UI button to assemble first half of drink hasn't been clicked, do so
     if ($decide_drink_part1 == 1 & $decide_drink_part2 == 1) {
      //reset
      $ingredients_drink_part1 = 0;
      $decide_drink_part1 = 0;
      $decide_drink_part2 = 0; % authenticate_this = 1;
      echo("Drink decision reset to " @ $decide_drink_part1 @ " and " @ $decide_drink_part2);
     }
     if ($decide_drink_part1 == 1 & % authenticate_this == 1) {
      $decide_drink_part2 = 1;
      echo("ASSEMBLY 2 of 2 complete");
      $ingredients_drink_part2 = % inform_waiter_fruit_wanted_is;
      $record_drink_b = $identify_corresponding_image;
      $record_drink_bframe = $identify_corresponding_frame;
      inform_cooks();

      //Auto-start waiter since 2 out of 2 parts of drink are confirmed
      $inform_waiter_number = $number_of_idle_waiters;
      $start_waiter_on_blending = 1;
      cue_tab2.setAnimation(cue_tab_upAnimation);
      cue_tab1.shut_off_yellow();
      $toggle_cue_tab1_fade_b = 1;
      cue_tab1.green_fader();
      cue2_fruit.setImageMap($identify_corresponding_image);
      cue2_fruit.setFrame($identify_corresponding_frame);
      $temporarily_lock_cue_tab = 0; % this.schedule(1000, "set_cue_down", 0);
      echo("Function set_cue_down Scheduled");
      if ($mute_soundfx != 1) {
       alxPlay(cue_up);
      }
     }
     if ($ingredients_drink_part1 == 0 & % authenticate_this == 1) {
      tab_cancel1.setPositionX(80.917);
      tab_cancel1.setPositionY(30.764);
      $temporarily_lock_cue_tab = 1;
      $decide_drink_part1 = 1;
      $ingredients_drink_part1 = % inform_waiter_fruit_wanted_is;
      $record_drink_a = $identify_corresponding_image;
      $record_drink_aframe = $identify_corresponding_frame;
      echo("ASSEMBLY 1 of 2 complete");
      cue_tab1.setAnimation(cue_tab_upAnimation); % local_cue_number += $check_cue_number; % id_tag += $check_cue_number;
      cue_tab1.schedule(4000, "end_it_early", % id_tag, % local_cue_number);
      cue_tab1.cease_colors();
      $toggle_cue_tab1_fade = 1;
      cue_tab1.yellow_fader();
      cue1_fruit.setImageMap($identify_corresponding_image);
      cue1_fruit.setFrame($identify_corresponding_frame);
      cue2_fruit.setImageMap(want_emptyImageMap);
      if ($mute_soundfx != 1) {
       alxPlay(cue_up);
      }
     }
     //--------------------------------------------------------------------------------------------
     //If inventory of said item is bone dry, warn player

     if ( % authenticate_this == 0) {
      echo("This inventory is now bare");
     }

     //--------------------------------------------------------------------------------------------
    }
   }
  }
 }
}

function ui_button_blue_fruit::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($disable_all_remaining_fruit_ui != 1 & $THE_GAME_IS_PAUSED != 1 & $tut_char_fruit_choices != 1) {
   unred_out_everything();
  }
 }
}

function ui_button_blue_fruit::set_cue_down() {
 echo("Function set_cue_down Activated");
 if ($temporarily_lock_cue_tab != 1) {
  cue_tab1.cease_all();
 }
}