// ***************************************************************************************
// File Name:   coin_tip.cs
// Author:      Roger Campbell 
// Purpose:     All interactions with collecting coin tips and dirty dishes 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function coin_tip::onAdd( % this) {
 $fully_black = 0;
 $scene_blacked_out = 0;
 $globalize_scene_time_start = 0; 
 % this.setUseMouseEvents(true);
 $specify_only_one_table_open = 0;
 $current_coin_tip_available = 9999;
}

function coin_tip::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ( % this.collected == 0 & % this.is_present == 1) {
   set_cursor_to_hand();
  }
 }
}

function coin_tip::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  set_cursor_to_default();
 }
}

function dirty_extra_cups::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.active == 1) {
  set_cursor_to_hand();
 }
 //edit 03-15-2015 making sure if cup isnt active, cup shouldnt be visible
 make_sure_dirty_cups_are_gone();
}

function dirty_extra_cups::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 set_cursor_to_default(); % this.BlendColor = "1 1 1 1";
 //edit 03-15-2015 making sure if cup isnt active, cup shouldnt be visible
 make_sure_dirty_cups_are_gone();
}

function dirty_extra_cups::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 //edit 03-15-2015 making sure if cup isnt active, cup shouldnt be visible
 make_sure_dirty_cups_are_gone();
}

function dirty_extra_cups::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 //edit 03-15-2015 making sure if cup isnt active, cup shouldnt be visible
 make_sure_dirty_cups_are_gone();
 //edit 03-19-2015 Added new addition & %this.active != 0 as preventitive for picking up dirty drink temporarily
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $activate_tut_cointip_portion != 1 & $drink_out_toggled == 1 & % this.active != 0) { % this.BlendColor = "1 0 0 0.9";
 }
 //edit 03-14-2015 echo $drink_out_toggled != 1 added to prevent picking up dirty drink while you have a servable drink in hand
 if ($MASTER_ALL_BUTTONS_DISABLED != 1 & $activate_tut_cointip_portion != 1 & $drink_out_toggled != 1) {
  //force proxy coin_1 mouse_down to check events, if any
  //empty_coin1.onMouseDown();
  if ( % this.active == 1) {
   //edit 03-13-2015 need to know whether or not this has been collected
   //$dirty_drink_that_has_been_collected = %this.num;
   //if($activate_tut_cointip_portion == 2 & $tut_yes_is_active == 1 & $end_previous_non_new_tut_bits != 1)
   if ($tut_yes_is_active == 1 & $tut_appetizers_part_b != 1 & $tut_very_last_part != 1) {
    //tutorial_text_block.text = "Wooh! Money!";
    $tutorial_activate_cook_sequence = 9999;
    $tutorial_activate_tip_sequence = 4;
    $toggle_off_fade_out_one_and_part_two_in = 0;
    isolater_mask.fade_out_one_and_part_two_in();
    $activate_tut_cointip_portion = 3;
    $tut_make_reclicking_drink_out_impossible = 0;
    $tut_dirty_cups_down = 1;
    //$tut_coin_tip_override = 0;
   }

   $toggle_serve_cursor = 0;
   $toggle_dirty_cursor = 1;
   set_cursor_to_dirty(); % identify_dirty_cup = "dirty_extra_cup" @ % this.num; 
   % identify_dirty_cup.setAnimation(empty_char_spaceAnimation);
   ("smellyb" @ % this.num).setAnimation(empty_char_spaceAnimation);
   ("dirty_glow" @ % this.num).setAnimation(empty_char_spaceAnimation);
   ("pointer_tip" @ % this.num).setAnimation(empty_char_spaceAnimation);
   drink_cancel1.setPositionX(77.133);
   drink_cancel1.setPositionY(16.462);
   $toggle_sodajerk_data_transfer = 1; % this.active = 0;
  }
  //waiter1.send_back_drink();
  /* ------------- NOW CONNECT THE DRINK_IN - COOK WASH TO THIS INSTEAD OF TIP ----- */
 }
}

function coin_tip::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

  if ($THE_GAME_IS_PAUSED != 1) {
   if ($tut_yes_is_active == 1 & $tut_very_last_part == 1) {

   }
   //scripted seq specifically for tutorial on coin tip
   if ( % this.collected == 0 & $activate_tut_cointip_portion == 1 & $tut_yes_is_active == 1 & $tut_very_last_part != 1) {
    $tutorial_activate_cook_sequence = 9999;
    $tutorial_activate_tip_sequence = 3;
    $toggle_off_fade_out_one_and_part_two_in = 0;
    isolater_mask.fade_out_one_and_part_two_in();
    $activate_tut_cointip_portion = 2;
    $tut_make_reclicking_drink_out_impossible = 0;
   }

   if ( % this.collected == 0 & $tutorial_end_fading_bs == 1 & $tut_yes_is_active == 1 & $tut_very_last_part != 1) {
    $end_the_tutorial = 1;
   }
   % char_x = % this.getPositionX(); 
   % char_y = % this.getPositionY();

   //02-02-2013 Adding ability to stop waiter from collecting empty tips
   $current_coin_tip_available = % this.collected;

   //05-14-2013 Added wait animation for tips when waiter is too busy to collect them
   if ($current_waiter.is_collecting_tip == 1) {
    icon_wait.setPositionX( % char_x);
    icon_wait.setPositionY( % char_y);
    icon_wait.setAnimation(icon_waitAnimation);
   }

   if ($current_waiter.is_serving == 1) {
    icon_wait.setPositionX( % char_x);
    icon_wait.setPositionY( % char_y);
    icon_wait.setAnimation(icon_waitAnimation);
   }
   /* edit 06-09-2013 Special Case of over-clicking if waiter is idle but coin tip thinks its not because a follow through of the next function */
   if ($current_waiter.is_collecting_tip == 1 & $waiter_is_already_collecting_tips == 0) {
    echo("Special coin_tip case 06-09-2013 activated");
    $current_waiter.is_collecting_tip = 0;
   }
   if ($current_waiter.is_collecting_tip == 0 & $current_waiter.is_serving == 0) {
    //05-13-2013 Adding exception for clicking between tips super-super fucking fast before this function can actuall get all the way through
    $coin_tip_disable_all_clicking_until_reaches_end_of_the_function_first = 1;

    if ( % this.collected == 0) {
     /* CHECK FOR IF THE RECIPROCATING CHAR ALLOWS THIS SINCE COIN TIP DOES NOT */
     //edit 12-27-2013 added for trophy purposes
     $coin_tips_per_round_collected += 1;
     if ($coin_tips_per_round_collected == 4 & $trophy_toggle_off_button1 != 1) {
      $root_trophy_identfier = "button1";
      win_this_trophy();
      $trophy_toggle_off_button1 = 1;
     }
     if ( % this.is_present == 1) {
      sparkle_emitter.setPositionX( % char_x);
      sparkle_emitter.setPositionY( % char_y);
      sparkle_emitter.setEffectLifeMode(STOP, 1.0);
      sparkle_emitter.playEffect();
     }
     if ($mute_soundfx != 1) {
      alxPlay(coin_collect_sound);
     } 
	 % this.setAnimation(empty_coinAnimation); 
	 % dirty_glow = "dirty_glow" @ % this.num; % dirty_glow.setAnimation(empty_char_spaceAnimation);
	 
     if ($all_tables_are_dirty == 1) {
      $all_tables_are_dirty = 0;
      $timescale = 1;
      $specify_only_one_table_open = 1;
      spawn_char();
     }

     $char_number = % this.num; % this.collect_tip = 1;
     $wait_for_selected_waiter_to_do_something_first = 0;
     $current_coin_tip = "empty_coin" @ % this.num; 
	 % find_char_to_resend_info = "empty_char_space" @ % this.num; 
	 % this.pass_last_drink_info = % find_char_to_resend_info.drink_accepted_is;
    }

    if ( % this.collected == 1) { 
	 % this.collect_tip = 0;
     % this.setAnimation(empty_coinAnimation); 
	 % dirty_glow = "dirty_glow" @ % this.num; 
	 % dirty_glow.setAnimation(empty_char_spaceAnimation);
    }

    if ( % this.collect_tip == 0) {
     if ($current_waiter.pass_drink_info == 0) {
      $current_waiter.pass_drink_info = % this.pass_last_drink_info;
     }

     $this_coin_tip = "empty_coin" @ % this.num;
     echo("COIN TIP ACCEPTED, COIN TIP NUMBER IS " @ % this.num);
     $testing_tip_collect = 1;
     $current_waiter.BlendColor = "1 1 1 1";
     $current_waiter.start_waiter_collecting_tip();
    }

    if ( % this.collect_tip == 1 & $stop_interaction_with_all_waiters == 0 & % this.collected == 0) {
     if ($current_waiter.pass_drink_info == 0) {
      $current_waiter.pass_drink_info = % this.pass_last_drink_info;
      echo("\c2 COIN TIP @ LAST PASS BEFORE WAITER IS: " @ % this.pass_last_drink_info);
     }
     if ( % this.is_present == 1) {
      sparkle_emitter.setPositionX( % char_x);
      sparkle_emitter.setPositionY( % char_y);
      sparkle_emitter.setEffectLifeMode(STOP, 1.0);
      sparkle_emitter.playEffect();
     }
     $this_coin_tip = "empty_coin" @ % this.num;
     echo("COIN TIP ACCEPTED, COIN TIP NUMBER IS " @ % this.num);
     $testing_tip_collect = 1;
     $current_waiter.BlendColor = "1 1 1 1";
     $current_waiter.start_waiter_collecting_tip();
    }
    //05-13-2013 Adding to prevent jumping from tip to tip immediately
    $current_waiter.is_collecting_tip = 1;
    //05-13-2013 Adding exception for clicking between tips super-super fucking fast before this function can actually get all the way through
    $coin_tip_disable_all_clicking_until_reaches_end_of_the_function_first = 0;
   }

   if ( % this.collected == 0) {

    if ( % this.collect_tip != 0) {
     //edit 05-20-2013 Adjusting for star system
     $score_number_x = score_number.getPositionX();
     $score_number_y = score_number.getPositionY();
     $points_number_x = points_number.getPositionX();
     $points_number_y = points_number.getPositionY();
     //edit 06-06-2013 adding better $current_char identifier
     % get_char_name = "empty_char_space" @ % this.num;
     echo("\c2 >>> DEBUG: coin tip clicked is " @ % this.num);
     echo("\c2 >>> DEBUG: coin tip expected is " @ % get_char_name.seat_num);
     echo("\c2 >>> DEBUG: star timer for this at " @ % get_char_name.star_timer);

     if ( % get_char_name.star_points == 3) {
      point_up_empty_space2.setPositionX($score_number_x);
      point_up_empty_space2.setPositionY($score_number_y);
      point_up_empty_space2.setAnimation(fx_point_up3bAnimation);
      point_up_empty_space3.setPositionX($points_number_x);
      point_up_empty_space3.setPositionY($points_number_y);
      point_up_empty_space3.setAnimation(fx_point_up2bAnimation);
      $coinage += 30;
      $points_you_have += 30;
      check_for_employee_bonus(); % derive_points_amount = $employee1_bonus_points + $employee2_bonus_points + 20;
      $points_amount += % derive_points_amount;
      box_points.setFrame(1);
      box_score.setFrame(1);
      comptroller.schedule(2000, "turn_off_ui_glow1", 0);
      comptroller.schedule(2000, "turn_off_ui_glow2", 0);
      if ($trophy_all_gold_in_round != 2) {
       $trophy_all_gold_in_round = 1;
      }

     }

     if ( % get_char_name.star_points == 2) {
      point_up_empty_space2.setPositionX($score_number_x);
      point_up_empty_space2.setPositionY($score_number_y);
      point_up_empty_space2.setAnimation(fx_point_up2bAnimation);
      point_up_empty_space3.setPositionX($points_number_x);
      point_up_empty_space3.setPositionY($points_number_y);
      point_up_empty_space3.setAnimation(fx_point_up1bAnimation);
      $coinage += 20;
      $points_you_have += 20;
      check_for_employee_bonus(); % derive_points_amount = $employee1_bonus_points + $employee2_bonus_points + 10;
      $points_amount += % derive_points_amount;
      box_points.setFrame(1);
      box_score.setFrame(1);
      comptroller.schedule(2000, "turn_off_ui_glow1", 0);
      comptroller.schedule(2000, "turn_off_ui_glow2", 0);
      $trophy_all_gold_in_round = 2;

     }

     if ( % get_char_name.star_points == 1) {
      point_up_empty_space2.setPositionX($score_number_x);
      point_up_empty_space2.setPositionY($score_number_y);
      point_up_empty_space2.setAnimation(fx_point_up1bAnimation);
      $coinage += 10;
      $points_you_have += 10;
      check_for_employee_bonus(); % derive_points_amount = $employee1_bonus_points + $employee2_bonus_points + 5;
      $points_amount += % derive_points_amount;
      box_points.setFrame(1);
      box_score.setFrame(1);
      comptroller.schedule(2000, "turn_off_ui_glow1", 0);
      comptroller.schedule(2000, "turn_off_ui_glow2", 0);
      $trophy_all_gold_in_round = 2;

     }
     if ( % get_char_name.star_points == 0) {
      //you're always a winner here!
      $points_you_have += 5;
      $trophy_angered_a_customer = 1;
      $trophy_all_gold_in_round = 3;
      box_points.setFrame(1);
      comptroller.schedule(2000, "turn_off_ui_glow1", 0);
     }

     % score_number_update = $coinage;
     score_number.text = % score_number_update;
     menu_coinage_left.text = % score_number_update;
     _menu_coinage_left.text = % score_number_update;
     points_number.text = $points_amount; % this.collect_tip = 0;
    }
    // 01-05-2013 Added to make sure this seat is spawnable upon collection of coin_tip
    $chosen_seat = ("empty_char_space" @ % this.num);
    $chosen_seat.occupied = 0;

    $char_number = % this.num;
    echo("$char_number rewritten by coin_tip mousedown instead of char mousedown");

   }
   //Special Trophy 09132013 EDIT trophy_dollar
   if ($coinage >= 10 & $trophy_dollar_collected != 1) {
    $root_trophy_identfier = "dollar";
    win_this_trophy();
    $trophy_dollar_collected = 1;
   }

   //edit 08-20-2013 switching to point system constant for winning
   //if($coinage >= $coinage_max & $stop_mass_clicking_last_tip_case_scenario != 1)
   if ($points_you_have >= $points_you_need & $stop_mass_clicking_last_tip_case_scenario != 1) {
    if ($trophy_all_gold_in_round == 1 & $trophy_toggle_off_all_gold_in_round != 1) {
     $root_trophy_identfier = "trophy9";
     win_this_trophy();
     $trophy_toggle_off_all_gold_in_round = 1;
    }
    if ($trophy_all_gold_in_round >= 2) {
     $trophy_all_gold_in_round = 0;
    }
    if ($trophy_angered_a_customer != 1) {
     $in_between_levels_trophy_protect = 1;

     if ($trophy_no_angry_customers < 2) {
      $trophy_no_angry_customers += 1;
     }
     if ($trophy_no_angry_customers == 2) {
      $root_trophy_identfier = "button3";
      win_this_trophy();
      $trophy_no_angry_customers = 9999;
     }
    }

    //Trophy award for Mega Manager
    //(multi-part)
    if ($_trophy_plaque1_activated == 1 & $world_numeral == 1 & $trophy_toggle_off_plaque1 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque1 = 1;
    }
    if ($_trophy_plaque2_activated == 1 & $world_numeral == 2 & $trophy_toggle_off_plaque2 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque2 = 1;
    }
    if ($_trophy_plaque3_activated == 1 & $world_numeral == 3 & $trophy_toggle_off_plaque3 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque3 = 1;
    }
    if ($_trophy_plaque4_activated == 1 & $world_numeral == 4 & $trophy_toggle_off_plaque4 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque4 = 1;
    }
    if ($_trophy_plaque5_activated == 1 & $world_numeral == 5 & $trophy_toggle_off_plaque5 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque5 = 1;
    }
    if ($_trophy_plaque6_activated == 1 & $world_numeral == 6 & $trophy_toggle_off_plaque6 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque6 = 1;
    }
    if ($_trophy_plaque7_activated == 1 & $world_numeral == 7 & $trophy_toggle_off_plaque7 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque7 = 1;
    }
    if ($_trophy_plaque8_activated == 1 & $world_numeral == 8 & $trophy_toggle_off_plaque8 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque8 = 1;
    }
    if ($_trophy_plaque9_activated == 1 & $world_numeral == 9 & $trophy_toggle_off_plaque9 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque9 = 1;
    }
    if ($_trophy_plaque10_activated == 1 & $world_numeral == 10 & $trophy_toggle_off_plaque10 != 1) {
     $mega_manager_counter += 1;
     $trophy_toggle_off_plaque10 = 1;
    }
    if ($mega_manager_counter == 10 & $trophy_toggle_off_mount3 != 1) {
     $root_trophy_identfier = "mount3";
     win_this_trophy();
     $trophy_toggle_off_mount3 = 1;
    }
    //end mega manager trophy code

    //Trophy: Plaques (for beating last round of each world)
    if ($world_numeral == 1 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque1";
     win_this_trophy();
    }
    if ($world_numeral == 2 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque2";
     win_this_trophy();
    }
    if ($world_numeral == 3 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque3";
     win_this_trophy();
    }
    if ($world_numeral == 4 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque4";
     win_this_trophy();
    }
    if ($world_numeral == 5 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque5";
     win_this_trophy();
    }
    if ($world_numeral == 6 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque6";
     win_this_trophy();
    }
    if ($world_numeral == 7 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque7";
     win_this_trophy();
    }
    if ($world_numeral == 8 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque8";
     win_this_trophy();
    }
    if ($world_numeral == 9 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque9";
     win_this_trophy();
    }
    //TROPHY: New York's Finest Magazine
    if ($world_numeral == 9 & $round_numeral == 7 & $end_trophy_ribbon4 != 1) {
     $root_trophy_identfier = "ribbon4";
     win_this_trophy();
     $end_trophy_ribbon4 = 1;
    }
    if ($world_numeral == 10 & $round_numeral == 10) {
     $root_trophy_identfier = "plaque10";
     win_this_trophy();
    }

    //Trophy award for Overtime
    if ($maximum_world_player_got_to > $world_numeral & $trophy_toggle_off_trophy1 != 1) {
     $root_trophy_identfier = "trophy1";
     win_this_trophy();
     $trophy_toggle_off_trophy1 = 1;
    }

    //Trophy award for Sold Out
    pre_calculate_round_max_times();
    if ($round_numeral != 1 & $round_numeral != 2 & $calculate_what_sold_out_means >= $game_clock_number & $trophy_toggle_off_mount4 != 1) {
     $root_trophy_identfier = "mount4";
     win_this_trophy();
     $trophy_toggle_off_mount4 = 1;
    }


    //END THE LEVEL DATA and MOVE TO SHOP SCREEN
    echo("switching to shop screen..........................................");
    % this.schedule(5000, "switch_to_shop_screen", 0); 
	% this.schedule(1, "double_chime", 0);
    //$appetizer1_amount[$world_numeral] = 
    appetizer1_amt.text = $appetizer1_amount[$world_numeral];
    appetizer2_amt.text = $appetizer2_amount[$world_numeral];
    appetizer1_tag.text = $appetizer1_tag_text[$world_numeral];
    appetizer2_tag.text = $appetizer2_tag_text[$world_numeral];
    entertainer1_tag.text = $entertainer1_tag_text[$world_numeral];
    entertainer2_tag.text = $entertainer2_tag_text[$world_numeral];
    change_entertainer_icon_for_order_menu();
    menu_coinage_left.text = $coinage;
    _menu_coinage_left.text = $coinage;
    confetti_storm.setLayer(1);
    confetti_storm.setPositionX(100);
    confetti_storm.setEffectLifeMode(INFINITE, 1.0);
    confetti_storm.playEffect(); % snapshot_scene_time_info = monster_shake.getSceneTime();
    $globalize_scene_time_start = % snapshot_scene_time_info;
    black_out();
    closing_sign.setPositionX(100);
    closing_sign.setPositionY(0);
    closing_sign.setAnimation(closing_sign5Animation);
    black_stretch.setPositionX(100);
    black_stretch.setPositionY(0);
    black_stretch.setSize(100, 100);
    $currently_between_levels = 1;
    $new_level_so_reset_combos_to_none = 1;
    //edit 02-15-2014
    reset_sodajerk_statuses();
    //edit 02-22-2015 special circumstance disable
    $hearts_disable_from_coin_tip = 1;
    sched_cancel_all();

    if ($round_numeral < $total_rounds_per_world) {
     declare_star_sys_data_for_level();

     //new round

     $round_numeral += 1;
     round_digit1.setFrame(0);
     round_digit2.setFrame($round_numeral);
     if ($maximum_level_player_got_to < $round_numeral & $maximum_world_player_got_to == $world_numeral) {
      $maximum_level_player_got_to = $round_numeral;
      $current_level = $maximum_level_player_got_to;
     }
     write_to_save_file();
    }
    //edit 01-04-2015 kill the next function if scenario level 10 - next world, lvl 2 - prev world, lvl 10
    if ($maximum_world_player_got_to != $the_current_world & $current_level == 11) {
     $function_killer = 1;
    }
    if ($round_numeral == $total_rounds_per_world & $function_killer != 1) {
     $round_numeral += 1;
     if ($maximum_level_player_got_to < $round_numeral & $maximum_world_player_got_to == $world_numeral) {
      $maximum_level_player_got_to = $round_numeral;
      $current_level = $maximum_level_player_got_to;
     }
	 
     write_to_save_file();
    }
    if ($round_numeral == 10) {
     round_digit1.setFrame(1);
     round_digit2.setFrame(0);
    }
    if ($round_numeral > $total_rounds_per_world)
    {
     reset_alpha_of_star_system_levels();
     reset_all_new_ss_levels_after_saving_prior();
     //new world, round
     $world_numeral += 1;
     $round_numeral = 1;
     $zero_start_ss_level_data = 0;
     $input_ss_level_num = 1;

     if ($maximum_world_player_got_to < $world_numeral) {
      $maximum_world_player_got_to = $world_numeral;
      $maximum_level_player_got_to = $round_numeral; 
	  % level_button_bitmap = "levsel_world" @ $world_numeral @ "_buttonImageMap"; 
	  % level_bkgd_bitmap = "levsel_bkgd_" @ $world_numeral @ "ImageMap";
      levsel_day_text.text = "-";

      //echo animation and pointer for WORLD MAP selection
      if ($world_numeral <= 10) { 
	   % find_current_world_locale = "mapsel_" @ $world_numeral; 
	   % world_locale_x = % find_current_world_locale.getPositionX(); 
	   % world_locale_y = % find_current_world_locale.getPositionY();
       world_map_echo.setPositionX( % world_locale_x);
       world_map_echo.setPositionY( % world_locale_y);
       pointer_world_map.setPositionX( % world_locale_x); 
	   % upper_world_locale_y = % world_locale_y - 10;
       pointer_world_map.setPositionY( % upper_world_locale_y);

       if ($world_numeral == $maximum_world_player_got_to) { 
	   % find_current_world_locale.unlocked = 1; 
	   % find_current_world_locale.setFrame(0);
       }
      }
	  
      //if you beat the game, declare the echo selector and pointer to be world 10
      if ($world_numeral >= 11) { % find_current_world_locale = "mapsel_10"; % world_locale_x = % find_current_world_locale.getPositionX(); % world_locale_y = % find_current_world_locale.getPositionY();
       world_map_echo.setPositionX( % world_locale_x);
       world_map_echo.setPositionY( % world_locale_y);
       pointer_world_map.setPositionX( % world_locale_x); 
	   % upper_world_locale_y = % world_locale_y - 10;
       pointer_world_map.setPositionY( % upper_world_locale_y); 
	   % find_current_world_locale.unlocked = 1; 
	   % find_current_world_locale.setFrame(0);
      }
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

      bkgd_levsel_main.setImageMap( % level_bkgd_bitmap);

      levsel_1.setFrame(0);
      levsel_2.setFrame(3);
      levsel_3.setFrame(3);
      levsel_4.setFrame(3);
      levsel_5.setFrame(3);
      levsel_6.setFrame(3);
      levsel_7.setFrame(3);
      levsel_8.setFrame(3);
      levsel_9.setFrame(3);
      levsel_10.setFrame(3);

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

      $alert_levsel_bypass = 1;
      $current_level = $maximum_level_player_got_to;
     }
     round_digit1.setFrame(0);
     round_digit2.setFrame($round_numeral);
     write_to_save_file();
    }

    $stop_mass_clicking_last_tip_case_scenario = 1;
    //edit 01-24-2014 Moved this up here because it was writing per coin_tip, this is a just incase you win and no clause works, write to save file anyway
    write_to_save_file();
   }

   if ( % this.collected == 1) {
    echo("Coin tip ultimately registers as collected");
   }
  }
 }
}

function coin_tip::switch_to_shop_screen() {
 if ($world_numeral == 11) {
  //edit 01-18-2015 move world echo temporarily to purchase screen to signify only continue button is possible
  world_map_echo.setPositionX(142.317);
  world_map_echo.setPositionY(174.357);
  $temp_lock_skip_numeral11 = 1;
 }
 //alxPlay(end_chime);
 purge_any_remnants();
 equalize_appetizers();
 appetizer_world_display.text = $world_numeral;
 appetizer_level_display.text = $current_level;
 order_menu_world.text = $_level_world_text[$world_numeral];
 check_if_need_to_hide_appetizers();
 change_entertainer_icon_for_order_menu();
 set_entertainer_costs_at_start();
 $anger_amount_counter = 0;
 $toggle_off_special_char_for_round = 0;
 //12-21-2013 added to stop clock at absolute end of level
 $end_the_clock = 1;
 //12-21-2013 added to stop bonus vortexes and flyers that dont use the clock
 $left_the_level_space = 1;

 //establish_all_awards_won();
 confetti_storm.stopEffect();
 echo("Switching to shopscreen");
 $screen_position_x = 100;
 $screen_position_y = 150;
 activate_side_borders();
 sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);

 //extended tutorial activator
 $default_audio = "map_theme";
 alxStopAll();
 if ($toggle_mute_music != 1) {
  alxPlay($default_audio);
 }

 $special_char_already_used = 0;
 //edit 03-14-2015 $trophy_angered_a_customer needs to be reset
 $trophy_angered_a_customer = 0;
}

function coin_tip::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) {
	//leave blank
  }
 }
}

function monster_shake::onUpdateScene( % this) {
 $initify_timers = monster_shake.getSceneTime();
 if ($scene_blacked_out == 1) {
  $reinit_timers = $initify_timers - $globalize_scene_time_start;
  $tenth_of_timers = $reinit_timers / 2;

  if ($tenth_of_timers < 1) {
   $fully_black = $tenth_of_timers;
  }
  if ($tenth_of_timers >= 1) {
   $fully_black = 1;
  }

  $trial2 = "1 1 1 " @ $fully_black;
  black_stretch.BlendColor = $trial2;
 }
}

function black_out() {
 $scene_blacked_out = 1;
 $trial1 = 0;
 $initify_timers = monster_shake.getSceneTime();
}

function force_black_out() {
 //edit 06-12-2014 making sure dirty cups go and schedules get cancelled for game_fail
 sched_cancel_cooks();
 sched_cancel_chars_and_waiters();
 clear_out_dirty_cups_for_good();
 $disable_pause_for_black_out = 1;
 % appetizer1_amt = $appetizer1_amount[$world_numeral]; 
 % appetizer2_amt = $appetizer2_amount[$world_numeral];
 if ( % appetizer1_amt < $appetizer_default_amount) {
  $appetizer1_amount[$world_numeral] = $appetizer_default_amount;
 }
 appetizer1_amt_ingame.text = $appetizer1_amount[$world_numeral];
 if ( % appetizer2_amt < $appetizer_default_amount) {
  $appetizer2_amount[$world_numeral] = $appetizer_default_amount;
 }
 appetizer2_amt_ingame.text = $appetizer2_amount[$world_numeral];
 % snapshot_scene_time_info = monster_shake.getSceneTime();
 $globalize_scene_time_start = % snapshot_scene_time_info;
 black_out();
 game_fail_text.text = $special_dialog[$special_dialog_identifier];
 if ($anger_amount_counter >= 3) {
  game_fail_text.text = $special_dialog6;
 }
 game_fail_text.setBlendAlpha(1);
 game_fail_number.setBlendAlpha(1);
 game_fail_countdown();
 black_stretch.setPositionX(100);
 black_stretch.setPositionY(0);
 black_stretch.setSize(100, 100);
 $currently_between_levels = 1;
 $new_level_so_reset_combos_to_none = 1;
 $anger_amount_counter = 0;
}

function check_for_elvis_non_black_out() {
 if ($world_numeral != 4) {
  $coinage += 70; % score_number_update = $coinage;
  score_number.text = % score_number_update;
  menu_coinage_left.text = % score_number_update;
  _menu_coinage_left.text = % score_number_update;
  points_number.text = $points_amount; % this.collect_tip = 0;
 }
}

function coin_tip::reset_coin_tips( % this) {
 ("pointer_tip" @ % this.num).setAnimation(empty_char_spaceAnimation);
 ("smellyb" @ % this.num).setAnimation(empty_char_spaceAnimation);
 ("icon_exclame" @ % this.num).setAnimation(empty_char_spaceAnimation);
 % this.setAnimation(empty_coinAnimation); % dirty_glow = "dirty_glow" @ % this.num; 
 % dirty_glow.setAnimation(empty_char_spaceAnimation); 
 % this.collected = 1;
 
}

function test_fake_scenario() {
 $root_trophy_identfier = "dollar";
 win_this_trophy();

}

function test_fake_scenario2() {
 $root_trophy_identfier = "plaque2";
 win_this_trophy();

}

function coin_tip::double_chime() {
 if ($mute_soundfx != 1) {
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
  alxPlay(end_chime);
 }
}

function flush_level_entirely() {
 echo("-X-X-X-X-X-X-X-X-X-X-x-x-X-x-x-x-x-X-x : FLUSH LEVEL : X-X-X-X_X_X-X-X-x-X_X_X_x-x_X_X_X_X_X_X_-x-X-X_-x_X_XX_-x-xX");
 hearts_1.in_cell = 6;
 hearts_2.in_cell = 6;
 hearts_3.in_cell = 6;
 hearts_4.in_cell = 6;

 game_fail_number.reload_level();

}