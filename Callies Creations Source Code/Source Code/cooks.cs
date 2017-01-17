// ***************************************************************************************
// File Name:   cooks.cs
// Author:      Roger Campbell 
// Purpose:     All actions and schedules for cooks/sodajerks 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function sodajerk::onAdd( % this) {
 $drink_1 = 0;
 $drink_11 = 0;

 $drink_name_1 = "placeholder";
 $drink_name_11 = 0;
 $drinkb_name_1 = "placeholder";
 $drinkb_name_11 = 0;

 $drink_2 = 0;
 $drink_12 = 0;

 $drink_name_2 = "placeholder";
 $drink_name_12 = 0;
 $drinkb_name_2 = "placeholder";
 $drinkb_name_12 = 0;

 $drink_3 = 0;
 $drink_13 = 0;

 $drink_name_3 = "placeholder";
 $drink_name_13 = 0;
 $drinkb_name_3 = "placeholder";
 $drinkb_name_13 = 0;

 $drink_4 = 0;
 $drink_14 = 0;

 $drink_name_4 = "placeholder";
 $drink_name_14 = 0;
 $drinkb_name_4 = "placeholder";
 $drinkb_name_14 = 0;
 //01-04-2013 All new values
 $NEW_sodajerk_number = 1;
 $NEW_total_number_of_sodajerks = 4;
}

function inform_cooks() {
 display_hp_sj1.text = sodajerk1.hard_paused;
 display_hp_sj2.text = sodajerk2.hard_paused;
 display_hp_sj3.text = sodajerk3.hard_paused;
 display_hp_sj4.text = sodajerk4.hard_paused;

 if ($tut_yes_is_active == 1 & $tut_char_fruit_choices != 2 & $tut_new_revised != 1 & $tut_yes_is_active == 1) {
  $toggle_off_fade_out_one_and_part_two_in = 0;
  isolater_mask.fade_out_one_and_part_two_in();
  $tutorial_activate_cook_sequence = 1;
  $until_tut_char_is_activated_dont_do_fruits = 1;
  tutorial_clicker.setBlendAlpha(0);
 }

 if ($tut_yes_is_active == 1 & $tut_new_revised == 1) {
  $tutorial_cue_tab_control = 0;
  tutorial_text_block.text = $tut_12;
  tutorial_text_block.setPositionY(-3);
  tutorial_text_block.setPositionX(106);
  tutorial_bar.setPositionX(120);
  tutorial_bar.setPositionY(-3);
  tutorial_clicker.setBlendAlpha(0);
  $end_previous_non_new_tut_bits = 1;
 }

 callie.signal();
 $uncancel_this_drink = "drink_out" @ % this.cook_num;
 $uncancel_this_drink.cancelled = 0;
 echo("\c2 sodajerk" @ % this.cook_num @ "::inform_cooks initiated");
 //declare new sodajerk
 % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;

 $drink_1 = 0;
 $drink_11 = 0;

 $drink_name_1 = "placeholder";
 $drink_name_11 = 0;
 $drinkb_name_1 = "placeholder";
 $drinkb_name_11 = 0;

 $drink_2 = 0;
 $drink_12 = 0;

 $drink_name_2 = "placeholder";
 $drink_name_12 = 0;
 $drinkb_name_2 = "placeholder";
 $drinkb_name_12 = 0;

 $drink_3 = 0;
 $drink_13 = 0;

 $drink_name_3 = "placeholder";
 $drink_name_13 = 0;
 $drinkb_name_3 = "placeholder";
 $drinkb_name_13 = 0;

 $drink_4 = 0;
 $drink_14 = 0;

 $drink_name_4 = "placeholder";
 $drink_name_14 = 0;
 $drinkb_name_4 = "placeholder";
 $drinkb_name_14 = 0;
 //01-04-2013 All new values
 $NEW_sodajerk_number = 1;
 $NEW_total_number_of_sodajerks = 4;
}

function inform_cooks() {
 display_hp_sj1.text = sodajerk1.hard_paused;
 display_hp_sj2.text = sodajerk2.hard_paused;
 display_hp_sj3.text = sodajerk3.hard_paused;
 display_hp_sj4.text = sodajerk4.hard_paused;

 if ($tut_yes_is_active == 1 & $tut_char_fruit_choices != 2 & $tut_new_revised != 1 & $tut_yes_is_active == 1) {
  $toggle_off_fade_out_one_and_part_two_in = 0;
  isolater_mask.fade_out_one_and_part_two_in();
  $tutorial_activate_cook_sequence = 1;
  $until_tut_char_is_activated_dont_do_fruits = 1;
  tutorial_clicker.setBlendAlpha(0);
 }

 if ($tut_yes_is_active == 1 & $tut_new_revised == 1) {
  $tutorial_cue_tab_control = 0;
  tutorial_text_block.text = $tut_12;
  tutorial_text_block.setPositionY(-3);
  tutorial_text_block.setPositionX(106);
  tutorial_bar.setPositionX(120);
  tutorial_bar.setPositionY(-3);
  tutorial_clicker.setBlendAlpha(0);
  $end_previous_non_new_tut_bits = 1;
 }

 callie.signal();
 $uncancel_this_drink = "drink_out" @ % this.cook_num;
 $uncancel_this_drink.cancelled = 0;
 echo("\c2 sodajerk" @ % this.cook_num @ "::inform_cooks initiated");
 //declare new sodajerk
 % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;

 //edit checking cooks
 echo("\c2 %NEW_current_sodajerk = " @ % NEW_current_sodajerk);
 echo("\c2 %NEW_current_sodajerk = " @ % NEW_current_sodajerk);
 echo("\c2 %NEW_current_sodajerk = " @ % NEW_current_sodajerk);
 //edit 05-14-2013 New statement to check if drink_in is really dirty just in case out of sync
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
 % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 //edit 02-12-2014 
 if ($calculate_all_sodajerks_business < 4) { % NEW_current_sodajerk.is_blending = 1;
  //calculate all busy chefs with all current clogged up drink_outs
  $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
  display_occupied.text = $calculate_all_sodajerks_business;
  //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
  if ($calculate_all_sodajerks_business > 4) {
   $calculate_all_sodajerks_business = 4;
   display_occupied.text = $calculate_all_sodajerks_business;
  }
 }

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }

 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }

 if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
 % NEW_current_sodajerk.drink_out_blocking = 0;
 }

 //check if a drink has been sent out that is blocking the sodajerk
 //if so, iterate through sodajerks to find an available one
 if ( % NEW_current_sodajerk.drink_out_blocking == 1) {
  //if sodajerk is 4 or greater, revert to sodajerk1 since they're already blocked, so already useless and last one in line
  if ($NEW_sodajerk_number >= $NEW_total_number_of_sodajerks) {
   $NEW_sodajerk_number = 1; % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
  }

  //CHECK REAL BLOCKED STATUS EACH ITERATION
  % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
  % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

  if ( % drink_block_checker.dirty == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }

  if ( % drink_out_block_checker.up_status == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }

  if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
  % NEW_current_sodajerk.drink_out_blocking = 0;
  }
  //if for some reason sodajerk is out of bounds and recorded as 0 or negatives, revert to sodajerk1
  if ($NEW_sodajerk_number < 1) {
   $NEW_sodajerk_number = 1; 
   % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
  }
  //CHECK REAL BLOCKED STATUS EACH ITERATION
  % drink_block_checker = "drink_in"
  @ $NEW_sodajerk_number; 
  % drink_out_block_checker = "drink_out"
  @ $NEW_sodajerk_number;

  if ( % drink_block_checker.dirty == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
  % NEW_current_sodajerk.drink_out_blocking = 0;
  }
  //if sodajerk1 is unavailable because of drink_out blocking, iterate forward
  if ($NEW_sodajerk_number == 1 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
   $NEW_sodajerk_number = 2; 
   % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
  }
  //CHECK REAL BLOCKED STATUS EACH ITERATION
  % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
  % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

  if ( % drink_block_checker.dirty == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
  % NEW_current_sodajerk.drink_out_blocking = 0;
  }
  //if sodajerk2 is unavailable because of drink_out blocking, iterate forward
  if ($NEW_sodajerk_number == 2 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
   $NEW_sodajerk_number = 3; 
   % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
  }
  //CHECK REAL BLOCKED STATUS EACH ITERATION
  % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
  % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

  if ( % drink_block_checker.dirty == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
  % NEW_current_sodajerk.drink_out_blocking = 0;
  }
  //if sodajerk3 is unavailable because of drink_out blocking, iterate forward and cease on sodajerk 4
  //because loop is complete and they're all busy for now
  if ($NEW_sodajerk_number == 3 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
   $NEW_sodajerk_number = 4; % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
  }
  //CHECK REAL BLOCKED STATUS EACH ITERATION
  % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
  % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

  if ( % drink_block_checker.dirty == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 1) { 
  % NEW_current_sodajerk.drink_out_blocking = 1;
  }
  if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
  % NEW_current_sodajerk.drink_out_blocking = 0;
  }
 }

 //check if new sodajerk is busy or has drink blocking, if not go ahead
 if ( % NEW_current_sodajerk.busy != 1 & % NEW_current_sodajerk.drink_out_blocking == 0) {
  //edit 03222013 clause and statement added to prevent making drink, while dirty drink is up, so cancelling function couldnt overwrite
  //specific to cancel button only right now
  $clean_this_drink = "drink_in" @ % NEW_current_sodajerk.cook_num;
  if ($clean_this_drink.dirty != 1) {
   //declare new sodajerk fruit assignments
   if ( % NEW_current_sodajerk.hard_paused != 1) {
    echo("......SODAJERK IS NOT HARD-PAUSED, CONTINUING DRINK IDENT!"); 
	% NEW_current_sodajerk.fruit1_number = $ingredients_drink_part1; 
	% NEW_current_sodajerk.fruit1_frame = $record_drink_aframe; 
	% NEW_current_sodajerk.fruit1_image_name = $record_drink_a; 
	% NEW_current_sodajerk.fruit2_number = $ingredients_drink_part2; 
	% NEW_current_sodajerk.fruit2_frame = $record_drink_bframe; 
	% NEW_current_sodajerk.fruit2_image_name = $record_drink_b; 
	% NEW_current_sodajerk.is_being_used = 1;
   }

   if ( % NEW_current_sodajerk.hard_paused == 1) { 
   % NEW_current_sodajerk.hard_paused = 0;
   }

   display_fn_sj1.text = sodajerk1.fruit1_number;
   display_ff_sj1.text = sodajerk1.fruit1_frame;
   display_fi_sj1.text = sodajerk1.fruit1_image_name;

   display_fn_sj2.text = sodajerk2.fruit1_number;
   display_ff_sj2.text = sodajerk2.fruit1_frame;
   display_fi_sj2.text = sodajerk2.fruit1_image_name;

   display_fn_sj3.text = sodajerk3.fruit1_number;
   display_ff_sj3.text = sodajerk3.fruit1_frame;
   display_fi_sj3.text = sodajerk3.fruit1_image_name;

   display_fn_sj4.text = sodajerk4.fruit1_number;
   display_ff_sj4.text = sodajerk4.fruit1_frame;
   display_fi_sj4.text = sodajerk4.fruit1_image_name;

   display_hp_sj1.text = sodajerk1.hard_paused;
   display_hp_sj2.text = sodajerk2.hard_paused;
   display_hp_sj3.text = sodajerk3.hard_paused;
   display_hp_sj4.text = sodajerk4.hard_paused;

   //declare new sodajerk attributes
   % NEW_current_sodajerk.busy = 1;
   //echo(sodajerk1.busy);
   //declare new sodajerk schedules all at once
   /* ----- SCHEDULE ALL SODAJERK 1 TASKS ----------------------------------------------------------------- */
   if ( % NEW_current_sodajerk.cook_num == 1) {
    if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
     $cook_sched_01 = sodajerk1.schedule(50, "part1", 0);
     $cook_sched_02 = sodajerk1.schedule(3000, "part2", 0);
     $cook_sched_03 = sodajerk1.schedule(6000, "part2b", 0);
     $cook_sched_04 = sodajerk1.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_05 = sodajerk1.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
     $cook_sched_02 = sodajerk1.schedule(0, "part2", 0);
     $cook_sched_03 = sodajerk1.schedule(3000, "part2b", 0);
     $cook_sched_04 = sodajerk1.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_05 = sodajerk1.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
     $cook_sched_03 = sodajerk1.schedule(0, "part2b", 0);
     $cook_sched_04 = sodajerk1.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_05 = sodajerk1.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
     $cook_sched_04 = sodajerk1.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_05 = sodajerk1.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_05 = sodajerk1.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
   }
   /* ----- SCHEDULE ALL SODAJERK 2 TASKS ----------------------------------------------------------------- */
   if ( % NEW_current_sodajerk.cook_num == 2) {
    if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
     $cook_sched_06 = sodajerk2.schedule(50, "part1", 0);
     $cook_sched_07 = sodajerk2.schedule(3000, "part2", 0);
     $cook_sched_08 = sodajerk2.schedule(6000, "part2b", 0);
     $cook_sched_09 = sodajerk2.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_10 = sodajerk2.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
     $cook_sched_07 = sodajerk2.schedule(0, "part2", 0);
     $cook_sched_08 = sodajerk2.schedule(3000, "part2b", 0);
     $cook_sched_09 = sodajerk2.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_10 = sodajerk2.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
     $cook_sched_08 = sodajerk2.schedule(0, "part2b", 0);
     $cook_sched_09 = sodajerk2.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_10 = sodajerk2.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
     $cook_sched_09 = sodajerk2.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_10 = sodajerk2.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_10 = sodajerk2.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
   }
   /* ----- SCHEDULE ALL SODAJERK 3 TASKS ----------------------------------------------------------------- */
   if ( % NEW_current_sodajerk.cook_num == 3) {
    if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
     $cook_sched_11 = sodajerk3.schedule(50, "part1", 0);
     $cook_sched_12 = sodajerk3.schedule(3000, "part2", 0);
     $cook_sched_13 = sodajerk3.schedule(6000, "part2b", 0);
     $cook_sched_14 = sodajerk3.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_15 = sodajerk3.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
     $cook_sched_12 = sodajerk3.schedule(0, "part2", 0);
     $cook_sched_13 = sodajerk3.schedule(3000, "part2b", 0);
     $cook_sched_14 = sodajerk3.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_15 = sodajerk3.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
     $cook_sched_13 = sodajerk3.schedule(0, "part2b", 0);
     $cook_sched_14 = sodajerk3.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_15 = sodajerk3.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
     $cook_sched_14 = sodajerk3.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_15 = sodajerk3.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_15 = sodajerk3.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
   }
   /* ----- SCHEDULE ALL SODAJERK 4 TASKS ----------------------------------------------------------------- */
   if ( % NEW_current_sodajerk.cook_num == 4) {
    if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
     $cook_sched_16 = sodajerk4.schedule(50, "part1", 0);
     $cook_sched_17 = sodajerk4.schedule(3000, "part2", 0);
     $cook_sched_18 = sodajerk4.schedule(6000, "part2b", 0);
     $cook_sched_19 = sodajerk4.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_20 = sodajerk4.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
     $cook_sched_17 = sodajerk4.schedule(0, "part2", 0);
     $cook_sched_18 = sodajerk4.schedule(3000, "part2b", 0);
     $cook_sched_19 = sodajerk4.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_20 = sodajerk4.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
     $cook_sched_18 = sodajerk4.schedule(0, "part2b", 0);
     $cook_sched_19 = sodajerk4.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_20 = sodajerk4.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
     $cook_sched_19 = sodajerk4.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_20 = sodajerk4.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
    if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
     $cook_sched_20 = sodajerk4.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
    }
   }
   /* ----- END SCHEDULING SODAJERK TASKS ----------------------------------------------------------------- */
   //edit 06-15-2013 Added for next world exception error
   % current_world_protection = $world_numeral; 
   % cook_number = % NEW_current_sodajerk.cook_num;
   $cooks_current_world[ % cook_number] = % current_world_protection;
   //iterate sodajerk so it can't be used again
   if ($NEW_sodajerk_number <= $NEW_total_number_of_sodajerks) {
    $NEW_sodajerk_number += 1;
   }
   //iterate back to 1 if sodajerk is beyond total number
   if ($NEW_sodajerk_number > $NEW_total_number_of_sodajerks) {
    $NEW_sodajerk_number = 1;
   }
  }
 }
}

function sodajerk::part1( % this) {
 /* RESETTER RIGHT HERE */
 % this.setSize(13.769, 17.188); 
 % this.setAnimation(sodajerk_m1_prep5Animation); 
 % this.BlendColor = "1 1 0.75 1"; 
 % cook_wait_icon = "cook_wait" @ % this.cook_num; 
 % cook_wait_icon.setBlendAlpha(1); 
 % this.in_cell = 1;
}

function sodajerk::part2( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_mix3Animation); 
% this.in_cell = 2;
}

function sodajerk::part2b( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_pour5cAnimation); 
% this.in_cell = 3;
 if ($mute_soundfx != 1) {
  alxPlay(cook_pour);
 }
}

function sodajerk::part3( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_idle6Animation);
 //edit 06-13-2013 Added to fix lack of drink vacuum animation after drink pour, retrofitting old disabled code
 % identify_cook_num = % this.cook_num; 
 % set_drink_vacuum_out = ("drink_in" @ % identify_cook_num); 
 % set_drink_vacuum_out.setAnimation(drink_popupAnimation); 
 % this.in_cell = 4;

}

function sodajerk::drink_arrival( % this, % what_level_was_previous, % what_level_was_this_on) { 
% this.in_cell = 5; % cook_wait_icon = "cook_wait" @ % this.cook_num; 
% cook_wait_icon.setBlendAlpha(0); 
% this.BlendColor = "1 1 1 1";

 //edit 12-22-2013 to prevent past scheduled events from coming into future level events and running amok
 if ( % what_level_was_this_on == $current_level) {
  //05-11-2013 New stipulation to prevent sending out drink after order-but then collect tip-continue-skip-new level and sodajerk is just finishing, sends out drink with last levels data
  //this is dislodged via char_button
  //edit 06-15-2013 Added for world_end exception overlap
  % cook_number = % this.cook_num;
  if ($world_ended != 1 & $cooks_current_world[ % cook_number] == $world_numeral) {
   //declare name of containers for icon images of outgoing drink
   % drink_out_icon_name_a = ("drink_ident" @ % identify_this_sodajerk_number); % drink_out_icon_name_b = ("drink_ident" @ % declare_drink_out_bottom_icon);
   //find target path name for images of outgoing drink
   % de_array_set_image_a = % this.fruit1_image_name; % de_array_set_image_b = % this.fruit2_image_name;
   //declare frame numbers of outgoing drinks
   % de_array_set_frame_a = % this.fruit1_frame; % de_array_set_frame_b = % this.fruit2_frame;
   //write global for corresponding fruit-drink identifying numbers so waiter/char can recieve them
   $drink_[ % identify_this_sodajerk_number] = % this.fruit1_number;
   $drink_[ % declare_drink_out_bottom_icon] = % this.fruit2_number;
   //edit 02-20-2014 since now drink_out to char, establish direct link numbers better
   ("drink_out" @ % this.cook_num).fruit1 = % this.fruit1_number;
   ("drink_out" @ % this.cook_num).fruit2 = % this.fruit2_number;
   //write global for corresponding fruit-drink frames so waiter/char can recieve them
   //note- both are iterated to 10 + number ie 11 vs 1 because 1 is global written name version of fruits and 11 is numeric of fruit frames
   $drink_name_[ % declare_drink_out_bottom_icon] = % this.fruit1_frame;
   $drinkb_name_[ % declare_drink_out_bottom_icon] = % this.fruit2_frame;
   //set outgoing drink icon images based on info above
   % drink_out_icon_name_a.setImageMap( % de_array_set_image_a); 
   % drink_out_icon_name_b.setImageMap( % de_array_set_image_b);
   //set outgoing drink icon image frames based on info above
   % drink_out_icon_name_a.setFrame( % de_array_set_frame_a); 
   % drink_out_icon_name_b.setFrame( % de_array_set_frame_b);
   //declare drink_out cup and set animation/attributes
   % the_drink_out = ("drink_out"
    @ % identify_this_sodajerk_number); 
	% the_drink_out.setAnimation(drink_popup2Animation); 
	% mana_glow = ("mana_glow" @ % identify_this_sodajerk_number); 
	% mana_glow.setAnimation(fx_mana_glow2Animation); 
	% this.is_being_used = 0;
   //edit 05-11-2013 Un-cancel drinks if canceled
   % the_drink_out.cancelled = 0;
   //edit 05-14-2013 Making new tangible up_status
   % the_drink_out.up_status = 1;

   //edit 02-12-2014 
   % this.is_blending = 0;
   //calculate all busy chefs with all current clogged up drink_outs
   //edit 02-12-2014 
   $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
   display_occupied.text = $calculate_all_sodajerks_business;
   //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
   if ($calculate_all_sodajerks_business > 4) {
    $calculate_all_sodajerks_business = 4;
    display_occupied.text = $calculate_all_sodajerks_business;
   }
   if ($mute_soundfx != 1) {
    alxPlay(drink_popping_up);
   } 
   % the_drink_out.active = 1;
   //declare drink_out will be blocking future drink making combos until removed
   % this.drink_out_blocking = 1;
   //declare pointer icon data for drink_out
   % pointer_cook_name = "pointer_cook" @ % identify_this_sodajerk_number; 
   % pointer_cook_name.setAnimation(icon_exclame_yellowAnimation); 
   % this_cooks_x = % the_drink_out.getPositionX(); 
   % this_cooks_y = % the_drink_out.getPositionY(); 
   % cooks_reset_pos_x = % this_cooks_x; 
   % cooks_reset_pos_y = % this_cooks_y - 12;
   % pointer_cook_name.setPositionX( % cooks_reset_pos_x);
   % pointer_cook_name.setPositionY( % cooks_reset_pos_y);

   //define X & Y information for drink icon image
   % set_output_mini_icon_posX = % the_drink_out.getPositionX(); 
   % set_output_mini_icon_posY = % the_drink_out.getPositionY();
   //declare outgoing drink icon image size and position
   % drink_out_icon_name_a.setPositionX( % set_output_mini_icon_posX);
   % drink_out_icon_name_a.setPositionY( % set_output_mini_icon_posY - 7); 
   % drink_out_icon_name_a.setSize(3, 3); 
   % drink_out_icon_name_b.setPositionX( % set_output_mini_icon_posX); 
   % drink_out_icon_name_b.setPositionY( % set_output_mini_icon_posY - 4); 
   % drink_out_icon_name_b.setSize(3, 3);
   //declare sodajerk no longer busy
   % this.busy = 0;
  }
  if ($tut_yes_is_active == 1 & $tut_char_fruit_choices != 2 & $tut_toggle_new_appetizer < 1) {
   $toggle_off_fade_out_one_and_part_two_in = 0;
   isolater_mask.fade_out_one_and_part_two_in();
   $tutorial_activate_cook_sequence = 2;
  }

 }
 //$tut_toggle_new_appetizer = 1;
 if ($tut_toggle_new_appetizer == 1 & $tut_yes_is_active == 1 & $end_previous_non_new_tut_bits == 1 & $tut_dirty_cups_down == 1) {
  $tutorial_cue_tab_control = 0;
  $tutorial_activate_cook_sequence = 9999;
  $tutorial_activate_tip_sequence = 4;
  $toggle_off_fade_out_one_and_part_two_in = 0;
  $activate_tut_cointip_portion = 9999;
  $tutorial_activate_tip_sequence = 9999;
  $tutorial_activate_extra_sequence = 9999;
  $tut_toggle_new_appetizer = 2;
  $tut_make_reclicking_drink_out_impossible = 0;
  isolater_mask.fade_out_one_and_part_two_in();
  tutorial_text_block.text = $tut_12b;
  tutorial_clicker.setBlendAlpha(1);
  tutorial_clicker.setPositionX(87.5);
  tutorial_clicker.setPositionY(15);
  $tut_appetizers_part_b = 1;
 }
}

//redundant function to check mouseDown for drink_in in proxy of sodajerk
function drink_in::wash_cup( % this) {
 if ($lock_the_cook_for_tutorial != 1) {
  //edit 04-30-2014 took off restrictions to prevent stopping cooks ever.
  % NEW_current_sodajerk.redify(); % this.setAnimation(drink_popup2Animation);
  $pointer_bad_num = % this.num;
  $pointer_bad_name = "pointer_bad" @ $pointer_bad_num;
  $this_drinks_x = % this.getPositionX();
  $this_drinks_y = % this.getPositionY();
  $drink_reset_pos_x = $this_drinks_x;
  $drink_reset_pos_y = $this_drinks_y - 6;
  $pointer_bad_name.setPositionX($drink_reset_pos_x);
  $pointer_bad_name.setPositionY($drink_reset_pos_y);
  $pointer_bad_name.setAnimation(icon_pointer_badAnimation);

  % NEW_current_sodajerk.schedule(810, "wash_dish", 0); 
  % NEW_current_sodajerk.is_washing = 1;
  $everyone_washing = sodajerk1.is_washing + sodajerk2.is_washing + sodajerk3.is_washing + sodajerk4.is_washing;
  display_occupied2.text = $everyone_washing;
  $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing; % NEW_current_sodajerk.schedule(6133, "just_idle", 0); % NEW_current_sodajerk.busy = 1; % NEW_current_sodajerk.should_wash_dish = 0;

 }
}

function sodajerk::wash_dish( % this) { % this_sodajerk_num = % this.cook_num; % this_sodajerk_name = % this.cook_name;

  $cook_red_stop[ % this_sodajerk_num] = 1;
  $uncancel_this_drink = "drink_out" @ % this.cook_num;
  $uncancel_this_drink.cancelled = 0;
  $clean_this_drink = "drink_in" @ % this.cook_num;
  $clean_this_drink.dirty = 0;
  $clean_this_drink.BlendColor = "1 1 1 1"; 
  % this_sodajerk_name.BlendColor = "1 1 1 1";
  if ($mute_soundfx != 1) {
   alxPlay(clean_dish);
  }
  echo("\c2 sodajerk::" @ % this.cook_num @ "wash_dish Initiated"); 
  % this.setSize(13.769, 17.188); 
  % this.setAnimation(sodajerk_m1_wash2bAnimation);
  //despawn previous drink art and icons
  //despawn icon pointer bad
  % pointer_bad_num = % this.cook_num; % pointer_bad_name = "pointer_bad"
  @ % pointer_bad_num; % pointer_bad_name.setAnimation(empty_char_spaceAnimation);
  //-----------------------------------------------------------------
  //despawn drink associated
  % get_rid_of_this_drink = "drink_in" @ % this.cook_num; 
  % get_rid_of_this_drink.setAnimation(drink_idleAnimation); 
  % this_drinks_x = % get_rid_of_this_drink.getPositionX(); 
  % this_drinks_y = % get_rid_of_this_drink.getPositionY();
 }
 
 //05-11-2013 abrupt cheater washing all dishes for next world
function sodajerk::abrupt_wash_dish( % this) {
 % this_sodajerk_num = % this.cook_num;
 $cook_red_stop[ % this_sodajerk_num] = 1; 
 % cancel_this_drink = "drink_out" @ % this.cook_num; 
 % cancel_this_drink.cancelled = 0;
 $clean_this_drink = "drink_in" @ % this.cook_num;
 $clean_this_drink.dirty = 0;
 $clean_this_drink.BlendColor = "1 1 1 1"; % this_sodajerk_name.BlendColor = "1 1 1 1";
 //despawn previous drink art and icons
 //despawn icon pointer bad
 % pointer_bad_num = % this.cook_num; 
 % pointer_bad_name = "pointer_bad" @ % pointer_bad_num; 
 % pointer_bad_name.setAnimation(empty_char_spaceAnimation);
 //-----------------------------------------------------------------
 //despawn drink associated
 % get_rid_of_this_drink = "drink_in" @ % this.cook_num; 
 % get_rid_of_this_drink.setAnimation(drink_idleAnimation); 
 % this_drinks_x = % get_rid_of_this_drink.getPositionX(); 
 % this_drinks_y = % get_rid_of_this_drink.getPositionY();
 % this.schedule(100, "just_idle", 0);
 % this.should_wash_dish = 0;

 //for drink_out removal
 % cancel_this_drink.cancelled = 1;
 //edit 02-15-2014 I think this is wrong
 % cancel_this_drink.active = 0; 
 % cancel_this_drink.setAnimation(drink_idleAnimation);
 //05-14-2013 Changing up_status
 % cancel_this_drink.up_status = 0;

 % identify_this_sodajerk_number = % this.cook_num; 
 % declare_drink_out_bottom_icon = ( % identify_this_sodajerk_number + 10); 
 % drink_out_exclame = ("icon_exclame"  @ % identify_this_sodajerk_number); 
 % drink_out_exclame.setAnimation(empty_char_spaceAnimation); 
 % pointer_cook_name = "pointer_cook" @ % identify_this_sodajerk_number; 
 % pointer_cook_name.setAnimation(empty_char_spaceAnimation);
 //declare name of containers for icon images of outgoing drink
 % drink_out_icon_name_a = ("drink_ident" @ % identify_this_sodajerk_number); 
 % drink_out_icon_name_b = ("drink_ident" @ % declare_drink_out_bottom_icon); 
 % drink_out_icon_name_a.setImageMap(empty_coinImageMap); 
 % drink_out_icon_name_b.setImageMap(empty_coinImageMap); 
 % drink_out_icon_name_a.setFrame(0); 
 % drink_out_icon_name_b.setFrame(0);
 //for drink_out attributes removal
 $drink_was_clicked = 0;
 $all_drinks_shutdown_temporarily = 0;
 $waiter_currently_collecting_tip_please_wait = 0;
 $activation_of_movementB = 0;

}

function sodajerk::just_idle( % this) {
 echo("\c2 sodajerk::" @ % this.cook_num @ "just_idle"); 
 % this_sodajerk_name = % this.cook_name; 
 % this_sodajerk_name.is_washing = 0;
 $everyone_washing = sodajerk1.is_washing + sodajerk2.is_washing + sodajerk3.is_washing + sodajerk4.is_washing;
 $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
 display_occupied2.text = $everyone_washing; 
 % this.setAnimation(sodajerk_m1_idle6Animation); 
 % this.setSize(13.769, 17.188); 
 % this.busy = 0;
}

//edit 05-14-2013 New statement to check if drink_in is really dirty just in case out of sync
% drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
% drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

//edit 02-12-2014 
if ($calculate_all_sodajerks_business < 4) { % NEW_current_sodajerk.is_blending = 1;
 //calculate all busy chefs with all current clogged up drink_outs
 $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
 display_occupied.text = $calculate_all_sodajerks_business;
 //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
 if ($calculate_all_sodajerks_business > 4) {
  $calculate_all_sodajerks_business = 4;
  display_occupied.text = $calculate_all_sodajerks_business;
 }
}

if ( % drink_block_checker.dirty == 1) { 
% NEW_current_sodajerk.drink_out_blocking = 1;
}

if ( % drink_out_block_checker.up_status == 1) { 
% NEW_current_sodajerk.drink_out_blocking = 1;
}

if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
% NEW_current_sodajerk.drink_out_blocking = 0;
}

//check if a drink has been sent out that is blocking the sodajerk
//if so, iterate through sodajerks to find an available one
if ( % NEW_current_sodajerk.drink_out_blocking == 1) {
 //if sodajerk is 4 or greater, revert to sodajerk1 since they're already blocked, so already useless and last one in line
 if ($NEW_sodajerk_number >= $NEW_total_number_of_sodajerks) {
  $NEW_sodajerk_number = 1; 
  % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
 }

 //CHECK REAL BLOCKED STATUS EACH ITERATION
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
 % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }

 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }

 if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
 % NEW_current_sodajerk.drink_out_blocking = 0;
 }
 //if for some reason sodajerk is out of bounds and recorded as 0 or negatives, revert to sodajerk1
 if ($NEW_sodajerk_number < 1) {
  $NEW_sodajerk_number = 1; 
  % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
 }
 //CHECK REAL BLOCKED STATUS EACH ITERATION
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
 % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
 % NEW_current_sodajerk.drink_out_blocking = 0;
 }
 //if sodajerk1 is unavailable because of drink_out blocking, iterate forward
 echo("sodajerk number is " @ $NEW_sodajerk_number @ " and %.drink_out_blocking = " @ % NEW_current_sodajerk.drink_out_blocking);
 if ($NEW_sodajerk_number == 1 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
  $NEW_sodajerk_number = 2; 
  % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
 }
 //CHECK REAL BLOCKED STATUS EACH ITERATION
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; 
 % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
 % NEW_current_sodajerk.drink_out_blocking = 0;
 }
 //if sodajerk2 is unavailable because of drink_out blocking, iterate forward
 echo("sodajerk number is "  @ $NEW_sodajerk_number @ " and %.drink_out_blocking = " @ % NEW_current_sodajerk.drink_out_blocking);
 if ($NEW_sodajerk_number == 2 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
  $NEW_sodajerk_number = 3; % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
 }
 //CHECK REAL BLOCKED STATUS EACH ITERATION
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 0 & 
 % drink_block_checker.dirty == 0) { % NEW_current_sodajerk.drink_out_blocking = 0;
 }
 //if sodajerk3 is unavailable because of drink_out blocking, iterate forward and cease on sodajerk 4
 //because loop is complete and they're all busy for now
 echo("sodajerk number is " @ $NEW_sodajerk_number @ " and %.drink_out_blocking = " @ % NEW_current_sodajerk.drink_out_blocking);
 if ($NEW_sodajerk_number == 3 & % NEW_current_sodajerk.drink_out_blocking == 1 & $NEW_sodajerk_number < $NEW_total_number_of_sodajerks) {
  $NEW_sodajerk_number = 4; % NEW_current_sodajerk = "sodajerk" @ $NEW_sodajerk_number;
 }
 echo("sodajerk number is " @ $NEW_sodajerk_number @ " and %.drink_out_blocking = " @ % NEW_current_sodajerk.drink_out_blocking);
 //CHECK REAL BLOCKED STATUS EACH ITERATION
 % drink_block_checker = "drink_in" @ $NEW_sodajerk_number; % drink_out_block_checker = "drink_out" @ $NEW_sodajerk_number;

 if ( % drink_block_checker.dirty == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 1) { 
 % NEW_current_sodajerk.drink_out_blocking = 1;
 }
 if ( % drink_out_block_checker.up_status == 0 & % drink_block_checker.dirty == 0) { 
 % NEW_current_sodajerk.drink_out_blocking = 0;
  //%drink_out_block_checker.active = 0;
 }
}

//check if new sodajerk is busy or has drink blocking, if not go ahead
if ( % NEW_current_sodajerk.busy != 1 & % NEW_current_sodajerk.drink_out_blocking == 0) {
 //edit 03222013 clause and statement added to prevent making drink, while dirty drink is up, so cancelling function couldnt overwrite
 //specific to cancel button only right now
 $clean_this_drink = "drink_in" @ % NEW_current_sodajerk.cook_num;
 if ($clean_this_drink.dirty != 1) {
  //declare new sodajerk fruit assignments
  if ( % NEW_current_sodajerk.hard_paused != 1) {
   echo("......SODAJERK IS NOT HARD-PAUSED, CONTINUING DRINK IDENT!"); 
   % NEW_current_sodajerk.fruit1_number = $ingredients_drink_part1; 
   % NEW_current_sodajerk.fruit1_frame = $record_drink_aframe; 
   % NEW_current_sodajerk.fruit1_image_name = $record_drink_a; 
   % NEW_current_sodajerk.fruit2_number = $ingredients_drink_part2; 
   % NEW_current_sodajerk.fruit2_frame = $record_drink_bframe; 
   % NEW_current_sodajerk.fruit2_image_name = $record_drink_b; 
   % NEW_current_sodajerk.is_being_used = 1;
  }

  if ( % NEW_current_sodajerk.hard_paused == 1) { 
  % NEW_current_sodajerk.hard_paused = 0;
  }

  display_fn_sj1.text = sodajerk1.fruit1_number;
  display_ff_sj1.text = sodajerk1.fruit1_frame;
  display_fi_sj1.text = sodajerk1.fruit1_image_name;

  display_fn_sj2.text = sodajerk2.fruit1_number;
  display_ff_sj2.text = sodajerk2.fruit1_frame;
  display_fi_sj2.text = sodajerk2.fruit1_image_name;

  display_fn_sj3.text = sodajerk3.fruit1_number;
  display_ff_sj3.text = sodajerk3.fruit1_frame;
  display_fi_sj3.text = sodajerk3.fruit1_image_name;

  display_fn_sj4.text = sodajerk4.fruit1_number;
  display_ff_sj4.text = sodajerk4.fruit1_frame;
  display_fi_sj4.text = sodajerk4.fruit1_image_name;

  display_hp_sj1.text = sodajerk1.hard_paused;
  display_hp_sj2.text = sodajerk2.hard_paused;
  display_hp_sj3.text = sodajerk3.hard_paused;
  display_hp_sj4.text = sodajerk4.hard_paused;

  //declare new sodajerk attributes
  % NEW_current_sodajerk.busy = 1;
  //declare new sodajerk schedules all at once
  /* ----- SCHEDULE ALL SODAJERK 1 TASKS ----------------------------------------------------------------- */
  if ( % NEW_current_sodajerk.cook_num == 1) {
   if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
    $cook_sched_01 = sodajerk1.schedule(50, "part1", 0);
    $cook_sched_02 = sodajerk1.schedule(3000, "part2", 0);
    $cook_sched_03 = sodajerk1.schedule(6000, "part2b", 0);
    $cook_sched_04 = sodajerk1.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_05 = sodajerk1.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
    $cook_sched_02 = sodajerk1.schedule(0, "part2", 0);
    $cook_sched_03 = sodajerk1.schedule(3000, "part2b", 0);
    $cook_sched_04 = sodajerk1.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_05 = sodajerk1.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
    $cook_sched_03 = sodajerk1.schedule(0, "part2b", 0);
    $cook_sched_04 = sodajerk1.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_05 = sodajerk1.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
    $cook_sched_04 = sodajerk1.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_05 = sodajerk1.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_05 = sodajerk1.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
  }
  /* ----- SCHEDULE ALL SODAJERK 2 TASKS ----------------------------------------------------------------- */
  if ( % NEW_current_sodajerk.cook_num == 2) {
   if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
    $cook_sched_06 = sodajerk2.schedule(50, "part1", 0);
    $cook_sched_07 = sodajerk2.schedule(3000, "part2", 0);
    $cook_sched_08 = sodajerk2.schedule(6000, "part2b", 0);
    $cook_sched_09 = sodajerk2.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_10 = sodajerk2.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
    $cook_sched_07 = sodajerk2.schedule(0, "part2", 0);
    $cook_sched_08 = sodajerk2.schedule(3000, "part2b", 0);
    $cook_sched_09 = sodajerk2.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_10 = sodajerk2.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
    $cook_sched_08 = sodajerk2.schedule(0, "part2b", 0);
    $cook_sched_09 = sodajerk2.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_10 = sodajerk2.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
    $cook_sched_09 = sodajerk2.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_10 = sodajerk2.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_10 = sodajerk2.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
  }
  /* ----- SCHEDULE ALL SODAJERK 3 TASKS ----------------------------------------------------------------- */
  if ( % NEW_current_sodajerk.cook_num == 3) {
   if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
    $cook_sched_11 = sodajerk3.schedule(50, "part1", 0);
    $cook_sched_12 = sodajerk3.schedule(3000, "part2", 0);
    $cook_sched_13 = sodajerk3.schedule(6000, "part2b", 0);
    $cook_sched_14 = sodajerk3.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_15 = sodajerk3.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
    $cook_sched_12 = sodajerk3.schedule(0, "part2", 0);
    $cook_sched_13 = sodajerk3.schedule(3000, "part2b", 0);
    $cook_sched_14 = sodajerk3.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_15 = sodajerk3.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
    $cook_sched_13 = sodajerk3.schedule(0, "part2b", 0);
    $cook_sched_14 = sodajerk3.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_15 = sodajerk3.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
    $cook_sched_14 = sodajerk3.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_15 = sodajerk3.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_15 = sodajerk3.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
  }
  /* ----- SCHEDULE ALL SODAJERK 4 TASKS ----------------------------------------------------------------- */
  if ( % NEW_current_sodajerk.cook_num == 4) {
   if ( % NEW_current_sodajerk.hard_pause_in_cell != 2 & % NEW_current_sodajerk.hard_pause_in_cell != 3 & % NEW_current_sodajerk.hard_pause_in_cell != 4 & % NEW_current_sodajerk.hard_pause_in_cell != 5) {
    $cook_sched_16 = sodajerk4.schedule(50, "part1", 0);
    $cook_sched_17 = sodajerk4.schedule(3000, "part2", 0);
    $cook_sched_18 = sodajerk4.schedule(6000, "part2b", 0);
    $cook_sched_19 = sodajerk4.schedule(9500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_20 = sodajerk4.schedule(12000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 2) {
    $cook_sched_17 = sodajerk4.schedule(0, "part2", 0);
    $cook_sched_18 = sodajerk4.schedule(3000, "part2b", 0);
    $cook_sched_19 = sodajerk4.schedule(6500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_20 = sodajerk4.schedule(9000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 3) {
    $cook_sched_18 = sodajerk4.schedule(0, "part2b", 0);
    $cook_sched_19 = sodajerk4.schedule(3500, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_20 = sodajerk4.schedule(6000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 4) {
    $cook_sched_19 = sodajerk4.schedule(0, "part3", 0); % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_20 = sodajerk4.schedule(3000, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
   if ( % NEW_current_sodajerk.hard_pause_in_cell == 5) { % what_level_was_previous = $round_numeral; % what_level_was_this_on = $current_level;
    $cook_sched_20 = sodajerk4.schedule(0, "drink_arrival", % what_level_was_previous, % what_level_was_this_on);
   }
  }
  /* ----- END SCHEDULING SODAJERK TASKS ----------------------------------------------------------------- */
  //edit 06-15-2013 Added for next world exception error
  % current_world_protection = $world_numeral; % cook_number = % NEW_current_sodajerk.cook_num;
  $cooks_current_world[ % cook_number] = % current_world_protection;
  echo("%current_world_protection = "
   @ % current_world_protection @ " $world_numeral = "
   @ $world_numeral @ " %cook_number = "
   @ % cook_number @ " $cooks_current_world[%cook_number] = "
   @ $cooks_current_world[ % cook_number]);


  //iterate sodajerk so it can't be used again
  if ($NEW_sodajerk_number <= $NEW_total_number_of_sodajerks) {
   $NEW_sodajerk_number += 1;
  }
  //iterate back to 1 if sodajerk is beyond total number
  if ($NEW_sodajerk_number > $NEW_total_number_of_sodajerks) {
   echo("SJ went back to 1 since min went over max");
   $NEW_sodajerk_number = 1;
  }
 }
}
}

function sodajerk::part1( % this) {
 /* NEED A RESETTER RIGHT HERE */
 % this.setSize(13.769, 17.188); 
 % this.setAnimation(sodajerk_m1_prep5Animation); 
 % this.BlendColor = "1 1 0.75 1"; 
 % cook_wait_icon = "cook_wait" @ % this.cook_num; 
 % cook_wait_icon.setBlendAlpha(1); 
 % this.in_cell = 1;
}

function sodajerk::part2( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_mix3Animation); 
% this.in_cell = 2;
}

function sodajerk::part2b( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_pour5cAnimation); 
% this.in_cell = 3;
 if ($mute_soundfx != 1) {
  alxPlay(cook_pour);
 }
}

function sodajerk::part3( % this) { 
% this.setSize(13.769, 17.188); 
% this.setAnimation(sodajerk_m1_idle6Animation);
 //edit 06-13-2013 Added to fix lack of drink vacuum animation after drink pour, retrofitting old disabled code
 % identify_cook_num = % this.cook_num; % set_drink_vacuum_out = ("drink_in"  @ % identify_cook_num); 
 % set_drink_vacuum_out.setAnimation(drink_popupAnimation); 
 % this.in_cell = 4;

}

function sodajerk::drink_arrival( % this, % what_level_was_previous, % what_level_was_this_on) { 
% this.in_cell = 5; 
% cook_wait_icon = "cook_wait" @ % this.cook_num; 
% cook_wait_icon.setBlendAlpha(0); 
% this.BlendColor = "1 1 1 1";
 echo("HEY THIS WAS ACTIVATED ON LEVEL " @ % what_level_was_this_on);
 //edit 12-22-2013 to prevent past scheduled events from coming into future level events and running amok
 if ( % what_level_was_this_on == $current_level) {
  //05-11-2013 New stipulation to prevent sending out drink after order-but then collect tip-continue-skip-new level and sodajerk is just finishing, sends out drink with last levels data
  //this is dislodged via char_button
  //edit 06-15-2013 Added for world_end exception overlap
  % cook_number = % this.cook_num;
  if ($world_ended != 1 & $cooks_current_world[ % cook_number] == $world_numeral) {
   //declare this sodajerk's number/corresponding fruit number & +10 for unique frame_B name
   echo("\c2 sodajerk" @ % this.cook_num @ "::drink_arrival initiated");
   echo("sodajerk::drink_arrival %identify_this_sodajerk_number = " @ % identify_this_sodajerk_number); 
   % identify_this_sodajerk_number = % this.cook_num; 
   % declare_drink_out_bottom_icon = ( % identify_this_sodajerk_number + 10);

   //declare name of containers for icon images of outgoing drink
   % drink_out_icon_name_a = ("drink_ident" @ % identify_this_sodajerk_number); % drink_out_icon_name_b = ("drink_ident" @ % declare_drink_out_bottom_icon);
   //find target path name for images of outgoing drink
   % de_array_set_image_a = % this.fruit1_image_name; 
   % de_array_set_image_b = % this.fruit2_image_name;
   //declare frame numbers of outgoing drinks
   % de_array_set_frame_a = % this.fruit1_frame; 
   % de_array_set_frame_b = % this.fruit2_frame;
   //write global for corresponding fruit-drink identifying numbers so waiter/char can recieve them
   $drink_[ % identify_this_sodajerk_number] = % this.fruit1_number;
   $drink_[ % declare_drink_out_bottom_icon] = % this.fruit2_number;
   //edit 02-20-2014 since now drink_out to char, establish direct link numbers better
   ("drink_out" @ % this.cook_num).fruit1 = % this.fruit1_number;
   ("drink_out" @ % this.cook_num).fruit2 = % this.fruit2_number;
   //write global for corresponding fruit-drink frames so waiter/char can recieve them
   //note- both are iterated to 10 + number ie 11 vs 1 because 1 is global written name version of fruits and 11 is numeric of fruit frames
   $drink_name_[ % declare_drink_out_bottom_icon] = % this.fruit1_frame;
   $drinkb_name_[ % declare_drink_out_bottom_icon] = % this.fruit2_frame;
   //set outgoing drink icon images based on info above
   % drink_out_icon_name_a.setImageMap( % de_array_set_image_a); 
   % drink_out_icon_name_b.setImageMap( % de_array_set_image_b);
   //set outgoing drink icon image frames based on info above
   % drink_out_icon_name_a.setFrame( % de_array_set_frame_a); 
   % drink_out_icon_name_b.setFrame( % de_array_set_frame_b);
   //declare drink_out cup and set animation/attributes
   % the_drink_out = ("drink_out" @ % identify_this_sodajerk_number); 
	% the_drink_out.setAnimation(drink_popup2Animation); % mana_glow = ("mana_glow" @ % identify_this_sodajerk_number); 
	% mana_glow.setAnimation(fx_mana_glow2Animation); 
	% this.is_being_used = 0;
   //edit 05-11-2013 Un-cancel drinks if canceled
   % the_drink_out.cancelled = 0;
   //edit 05-14-2013 Making new tangible up_status
   % the_drink_out.up_status = 1;

   //edit 02-12-2014 
   % this.is_blending = 0;
   //calculate all busy chefs with all current clogged up drink_outs
   //edit 02-12-2014 
   $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
   display_occupied.text = $calculate_all_sodajerks_business;
   //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
   if ($calculate_all_sodajerks_business > 4) {
    $calculate_all_sodajerks_business = 4;
    display_occupied.text = $calculate_all_sodajerks_business;
   }
   if ($mute_soundfx != 1) {
    alxPlay(drink_popping_up);
   } 
   % the_drink_out.active = 1;
   //declare drink_out will be blocking future drink making combos until removed
   % this.drink_out_blocking = 1;
   //declare pointer icon data for drink_out
   % pointer_cook_name = "pointer_cook" @ % identify_this_sodajerk_number; 
   % pointer_cook_name.setAnimation(icon_exclame_yellowAnimation); 
   % this_cooks_x = % the_drink_out.getPositionX(); 
   % this_cooks_y = % the_drink_out.getPositionY(); 
   % cooks_reset_pos_x = % this_cooks_x; 
   % cooks_reset_pos_y = % this_cooks_y - 12; 
   % pointer_cook_name.setPositionX( % cooks_reset_pos_x);
   % pointer_cook_name.setPositionY( % cooks_reset_pos_y);

   //define X & Y information for drink icon image
   % set_output_mini_icon_posX = % the_drink_out.getPositionX(); 
   % set_output_mini_icon_posY = % the_drink_out.getPositionY();
   //declare outgoing drink icon image size and position
   % drink_out_icon_name_a.setPositionX( % set_output_mini_icon_posX); 
   % drink_out_icon_name_a.setPositionY( % set_output_mini_icon_posY - 7); 
   % drink_out_icon_name_a.setSize(3, 3); 
   % drink_out_icon_name_b.setPositionX( % set_output_mini_icon_posX); 
   % drink_out_icon_name_b.setPositionY( % set_output_mini_icon_posY - 4); 
   % drink_out_icon_name_b.setSize(3, 3);
   //declare sodajerk no longer busy
   % this.busy = 0;
  }
  if ($tut_yes_is_active == 1 & $tut_char_fruit_choices != 2 & $tut_toggle_new_appetizer < 1) {
   $toggle_off_fade_out_one_and_part_two_in = 0;
   isolater_mask.fade_out_one_and_part_two_in();
   $tutorial_activate_cook_sequence = 2;

  }
 }

 if ($tut_toggle_new_appetizer == 1 & $tut_yes_is_active == 1 & $end_previous_non_new_tut_bits == 1 & $tut_dirty_cups_down == 1) {
  $tutorial_cue_tab_control = 0;
  $tutorial_activate_cook_sequence = 9999;
  $tutorial_activate_tip_sequence = 4;
  $toggle_off_fade_out_one_and_part_two_in = 0;
  $activate_tut_cointip_portion = 9999;
  $tutorial_activate_tip_sequence = 9999;
  $tutorial_activate_extra_sequence = 9999;
  $tut_toggle_new_appetizer = 2;
  $tut_make_reclicking_drink_out_impossible = 0;
  isolater_mask.fade_out_one_and_part_two_in();
  tutorial_text_block.text = $tut_12b;
  tutorial_clicker.setBlendAlpha(1);
  tutorial_clicker.setPositionX(87.5);
  tutorial_clicker.setPositionY(15);
  $tut_appetizers_part_b = 1;
 }
}

//redundant function to check mouseDown for drink_in in proxy of sodajerk
//function drink_in::onMouseDown(%this, %modifier, %worldPosition, %mouseClicks)
function drink_in::wash_cup( % this) {
 if ($lock_the_cook_for_tutorial != 1) {
  echo("\c2 sodajerk" @ % this.cook_num @ "::drink_in::MouseDown Initiated"); 
  % NEW_current_sodajerk = "sodajerk" @ % this.num;
  //edit 04-30-2014 took off restrictions to prevent stopping cooks ever.
  % NEW_current_sodajerk.redify(); 
  % this.setAnimation(drink_popup2Animation);
  $pointer_bad_num = % this.num;
  $pointer_bad_name = "pointer_bad"
  @ $pointer_bad_num;
  $this_drinks_x = % this.getPositionX();
  $this_drinks_y = % this.getPositionY();
  $drink_reset_pos_x = $this_drinks_x;
  $drink_reset_pos_y = $this_drinks_y - 6;
  $pointer_bad_name.setPositionX($drink_reset_pos_x);
  $pointer_bad_name.setPositionY($drink_reset_pos_y);
  $pointer_bad_name.setAnimation(icon_pointer_badAnimation);
  % NEW_current_sodajerk.schedule(810, "wash_dish", 0); 
  % NEW_current_sodajerk.is_washing = 1;
  $everyone_washing = sodajerk1.is_washing + sodajerk2.is_washing + sodajerk3.is_washing + sodajerk4.is_washing;
  display_occupied2.text = $everyone_washing;
  $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing; % NEW_current_sodajerk.schedule(6133, "just_idle", 0); % NEW_current_sodajerk.busy = 1; % NEW_current_sodajerk.should_wash_dish = 0;

 }
}

function sodajerk::wash_dish( % this) { 
  % this_sodajerk_num = % this.cook_num; 
  % this_sodajerk_name = % this.cook_name;
  $cook_red_stop[ % this_sodajerk_num] = 1;
  $uncancel_this_drink = "drink_out" @ % this.cook_num;
  $uncancel_this_drink.cancelled = 0;
  $clean_this_drink = "drink_in" @ % this.cook_num;
  $clean_this_drink.dirty = 0;
  $clean_this_drink.BlendColor = "1 1 1 1"; % this_sodajerk_name.BlendColor = "1 1 1 1";
  if ($mute_soundfx != 1) {
   alxPlay(clean_dish);
  }
  echo("\c2 sodajerk::" @ % this.cook_num @ "wash_dish Initiated"); 
  % this.setSize(13.769, 17.188); 
  % this.setAnimation(sodajerk_m1_wash2bAnimation);
  //despawn previous drink art and icons
  //despawn icon pointer bad
  % pointer_bad_num = % this.cook_num; % pointer_bad_name = "pointer_bad"
  @ % pointer_bad_num; % pointer_bad_name.setAnimation(empty_char_spaceAnimation);
  //-----------------------------------------------------------------
  //despawn drink associated
  % get_rid_of_this_drink = "drink_in" @ % this.cook_num; 
  % get_rid_of_this_drink.setAnimation(drink_idleAnimation); 
  % this_drinks_x = % get_rid_of_this_drink.getPositionX(); 
  % this_drinks_y = % get_rid_of_this_drink.getPositionY();
 }
 //05-11-2013 abrupt cheater washing all dishes for next world
function sodajerk::abrupt_wash_dish( % this) { 
% this_sodajerk_num = % this.cook_num;
 $cook_red_stop[ % this_sodajerk_num] = 1; 
 % cancel_this_drink = "drink_out" @ % this.cook_num; 
 % cancel_this_drink.cancelled = 0;
 $clean_this_drink = "drink_in" @ % this.cook_num;
 $clean_this_drink.dirty = 0;
 $clean_this_drink.BlendColor = "1 1 1 1"; % this_sodajerk_name.BlendColor = "1 1 1 1";
 //despawn previous drink art and icons
 //despawn icon pointer bad
 % pointer_bad_num = % this.cook_num; 
 % pointer_bad_name = "pointer_bad" @ % pointer_bad_num; 
 % pointer_bad_name.setAnimation(empty_char_spaceAnimation);
 //-----------------------------------------------------------------
 //despawn drink associated
 % get_rid_of_this_drink = "drink_in" @ % this.cook_num; 
 % get_rid_of_this_drink.setAnimation(drink_idleAnimation); 
 % this_drinks_x = % get_rid_of_this_drink.getPositionX(); 
 % this_drinks_y = % get_rid_of_this_drink.getPositionY();
 % this.schedule(100, "just_idle", 0);
 % this.should_wash_dish = 0;

 //for drink_out removal
 % cancel_this_drink.cancelled = 1;
 //edit 02-15-2014 I think this is wrong
 % cancel_this_drink.active = 0; 
 % cancel_this_drink.setAnimation(drink_idleAnimation);
 //05-14-2013 Changing up_status
 % cancel_this_drink.up_status = 0;

 % identify_this_sodajerk_number = % this.cook_num; 
 % declare_drink_out_bottom_icon = ( % identify_this_sodajerk_number + 10); 
 % drink_out_exclame = ("icon_exclame"  @ % identify_this_sodajerk_number); 
 % drink_out_exclame.setAnimation(empty_char_spaceAnimation); 
 % pointer_cook_name = "pointer_cook" @ % identify_this_sodajerk_number; 
 % pointer_cook_name.setAnimation(empty_char_spaceAnimation);
 //declare name of containers for icon images of outgoing drink
 % drink_out_icon_name_a = ("drink_ident" @ % identify_this_sodajerk_number); 
 % drink_out_icon_name_b = ("drink_ident" @ % declare_drink_out_bottom_icon); 
 % drink_out_icon_name_a.setImageMap(empty_coinImageMap); 
 % drink_out_icon_name_b.setImageMap(empty_coinImageMap); 
 % drink_out_icon_name_a.setFrame(0); 
 % drink_out_icon_name_b.setFrame(0);
 //for drink_out attributes removal
 $drink_was_clicked = 0;
 $all_drinks_shutdown_temporarily = 0;
 $waiter_currently_collecting_tip_please_wait = 0;
 $activation_of_movementB = 0;

}

function sodajerk::just_idle( % this) {
 $everyone_washing = sodajerk1.is_washing + sodajerk2.is_washing + sodajerk3.is_washing + sodajerk4.is_washing;
 $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
 display_occupied2.text = $everyone_washing; 
 % this.setAnimation(sodajerk_m1_idle6Animation); 
 % this.setSize(13.769, 17.188); % this.busy = 0;

}