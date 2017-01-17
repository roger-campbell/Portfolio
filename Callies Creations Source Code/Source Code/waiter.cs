// ***************************************************************************************
// File Name:   ui_generic_buttons.cs
// Author:      Roger Campbell 
// Purpose:     All waiter functions, animations and interactions 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function waiter::onAdd( % this) {
 set_waiter_node_position(); 
 % this.setUseMouseEvents(true);
 //redundancy for hili states just in case
 $no_clicking_waiter = 0;
 $hesitate = 0;
 $flip_check = 0;
 $drinkp1_cleared = 0;
 $waiter_init = 0;
 $waiter_untoggle = 0;
 $drink_up_for_cleaning = 0;
 $special_case_clause_to_prevent_char1_reteleport_animation_temporarily = 0;
 $wait_for_selected_waiter_to_do_something_first = 0;
 $waiter_canceled = 0;
 $waiter_is_cancelable = 0;
 $testing_tip_collect = 0;
 $this_waiter = % this.Name;
 $activation_of_movement = 0;
 $activation_of_movementB = 0;
 $logged_char_num_at_pay = 99;
 $current_waiter = "waiter1";
 $stop_interaction_with_all_waiters = 0;
 $waiter_is_mobile = 0;
 /*- Hide mount_points and way_points below- */

}

function waiter::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {

 }
}

function waiter::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { 
 % this.BlendColor = "1 1 1 1";
 }
}

function waiter::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
  if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
   if ($THE_GAME_IS_PAUSED != 1) {
    if ($mute_soundfx != 1) {
     alxPlay(nice_click);
    } 
	% char_x = % this.getPositionX(); 
	% char_y = % this.getPositionY();
    click_sonar.BlendColor = "1 1 1 0.4";
    % this.BlendColor = "1 0 0 0.9";
   }
  }
 }
 //}
function waiter::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) { % this.BlendColor = "1 1 1 1";
  }
 }
}

function initialize_waiter() {
 if ($customer_clicked == 0) {
  //if no customer clicked after waiter initialized, do not start waiter
  //This ends up prepping-controlling waiter going to the customer	
  $waiter_init = 1;
  //echo("Waiter ready and clicked");
 }

}

function waiter::start_waiter( % this) { 
 % this.in_cell = 1;
 $waiter_waiting_for_old_world_data_to_die = 0;
 //added 01-22-2013 globals to identify char at time of delivery since theres one waiter so its unchangeable during this
 % find_direct_char_name = "empty_char_space"
 @ waiter1.direct_pass_char; % find_direct_char_num = waiter1.direct_pass_char; % pass_char_data_locally = % find_direct_char_name;
 $record_char_num_for_waiter = % find_direct_char_num;

 //edit 02-01-2014 ripping up the entire waiter system, trying local function to function data pass
 % pass_char_data_locally = % find_direct_char_name;
 ("drink_out" @ $selected_drink).active = 0; % echo_data_drink_out = ("drink_out" @ $selected_drink);
 echo("DRINK OUT #" @ % echo_data_drink_out @ " active at function waiter::start_waiter");
 waiter_cancel1.setImageMap(want_emptyImageMap); % this.is_serving = 1; % this.pass_drink_info = $selected_drink; % future_coin_tip_identifier = "empty_coin"
 @ % find_direct_char_num; % future_coin_tip_identifier.pass_last_drink_info = $selected_drink; % this.BlendColor = "1 1 1 1";
 $quick_adjust_waiter_x1 = % this.getPositionX();
 $quick_adjust_waiter_x2 = $quick_adjust_waiter_x1 - 2;
 $waiter_is_informed = 1;
 //edit 02-20-2014 adding extra direct drink out info
 % fruit_direct1 = ("drink_out" @ $selected_drink).fruit1; 
 % fruit_direct2 = ("drink_out" @ $selected_drink).fruit2;
 $waiter_sched_01 = % this.schedule(10, "start_waiter_part4", % pass_char_data_locally, % fruit_direct1, % fruit_direct2);
 $waiter_sched_02 = % this.schedule(5540, "activate_clicking_on_waiter_when_theyre_not_busy", 0);
 echo("\c2 Scheduled waiter for 5540ms then activate_clicking_on_waiter_when_theyre_not_busy");
 $activation_of_movement = 0;
 $activation_of_movementB = 0;
 drink_cancel1.setPositionX(999);
 if ($mute_soundfx != 1) {
  alxPlay(waiter_rush);
 }
}

function waiter::start_waiter_adjustment1( % this) { % this.setFlipX(0);
 echo("start_waiter_adjustment1"); % this.BlendColor = "1 1 1 1";
 $gather_drink_latest_pos_x = $drink_out_actual_drink.getPositionX();
 $gather_drink_latest_pos_y = $drink_out_actual_drink.getPositionY();
 $waiter_to_drink_pos_x = $gather_drink_latest_pos_x + 2;
 $waiter_to_drink_pos_y = $gather_drink_latest_pos_y + 2;

 if (isEventPending($waiter_spawn_event)) {
  echo("EVENT IS PENDING REGISTERS, CANCELS DO NOT REGISTER OR SOMETHING");
 }
 $waiter_sched_03 = % this.schedule(2665, "start_waiter_part2", 0);
}


function waiter::start_waiter_collecting_tip( % this) {
 //02-02-2013 Added to statement to stop waiter from collecting blank tips
 // NOTE :: 0 means it IS AVAILABLE, 1 means unavailable
 if ($current_coin_tip_available == 0 & $waiter_is_already_collecting_tips == 0) {
  //05-13-2013 Adding special case for when you start collecting tip and click on another char to get their thoughts, because at connecting function the waiter will jump tables
  % prerecord_current_char_for_next_sequence = $char_number;
  $globalize_new_precorded_char_number = % prerecord_current_char_for_next_sequence;

  /* Special Case 31 : If waiter not clicked first, re-declare info from that event */
  if ($testing_tip_collect == 1) {
   echo("\c2 $testing_tip_collect == 1"); % this.pass_drink_info = $current_coin_tip.pass_last_drink_info;
   echo("\c2 %this.pass_drink_info = "
    @ $selected_drink); % declare_char_for_backtracking_algorithm = $current_coin_tip.pass_last_drink_info;
   echo("\c2 %declare_char_for_backtracking_algorithm = "
    @ $current_coin_tip.pass_last_drink_info);
   /* Special Case 30 : If timing inconsistency happens in which directed_char via char_button.cs mouseDown, is not declared, use global char_name instead */
   % nol_identifier = "nol";
   if ( % declare_char_for_backtracking_algorithm == % nol_identifier) {
    //%declare_char_for_backtracking_algorithm = $char_name;
    % declare_char_for_backtracking_algorithm = $current_coin_tip.pass_last_drink_info;
    echo("\c2 WARNING WARNING WARNING SPECIAL CASE 30 ACTIVATED");
   }
   /* -----------------------------------------------------------------------------------------------------------------------*/
   //char.deliver_drink_info = waiter.pass_drink_info via drink_out

   % declare_char_for_backtracking_algorithm.deliver_drink_info = % this.pass_drink_info;
   echo("\c2 %declare_char_for_backtracking_algorithm.deliver_drink_info = "
    @ % this.pass_drink_info); % declare_char_for_backtracking_algorithm = % this.pass_drink_info;
   //%this.pass_drink_info = %declare_char_for_backtracking_algorithm;
   echo("\c2 char.deliver_drink_info = "
    @ % declare_char_for_backtracking_algorithm.deliver_drink_info);
  }
  /* --------------------------------------------------------------------------      */
  //%this.pass_drink_info = $current_coin_tip.pass_last_drink_info;
  echo("\c2 At waiter start collecting tip, %this.pass_drink_info = "
   @ % this.pass_drink_info @ " VS (not zero)"); % always_current_waiter_name = $global_current_waiter; % always_current_waiter_name = % this.Name;
  echo("\c2 AT START OF COLLECT, always_current_waiter_name = "
   @ % always_current_waiter_name @ " vs input "
   @ % this.Name);
  //%this = $mousedown_waiter;
  //ceases all action if turned to 1
  $stop_interaction_with_all_waiters = 0;
  //%this = $the_selected_waiter_is;
  % this.BlendColor = "1 1 1 1";
  //%this.setAnimation(waiter_poof_emptyAnimation);
  if ($mute_soundfx != 1) {
   alxPlay(waiter_rush);
  } % this.setSize(19.824, 23.828);
  $waiter_sched_04 = % this.schedule(500, "start_waiter_collect", 0);
  $testing_tip_collect = 0;
  /* 12-27-2012 Added statement to control other tips from moving their X/Y to other positions by accident */
  $hiatus_on_positioning_tip_collect = 1;
  //%this.schedule(5040, "activate_clicking_on_waiter_when_theyre_not_busy", 0);
  echo("\c2 aT function waiter::start_waiter_collecting_tip, $CHAR_NUMBER @ END = "
   @ $char_number);
  //05-13-2013 new preventative clause
  $waiter_is_already_collecting_tips = 1;
 }
}

function waiter::start_waiter_collect( % this) {
 //05-13-2013 replacing $char_number with isolationist constant $globalize_new_precorded_char_number
 callie.god_touch();
 $waiter_waiting_for_old_world_data_to_die = 0;
 echo("\c2 aT function waiter::start_waiter_collect, $CHAR_NUMBER @ START = "
  @ $char_number @ " vs better# "
  @ $globalize_new_precorded_char_number); % find_last_char = ("empty_char_space"
  @ $globalize_new_precorded_char_number); % pointer_tip_renamer = ("pointer_tip"
  @ $globalize_new_precorded_char_number); % smellyb_renamer = ("smellyb"
  @ $globalize_new_precorded_char_number);
 echo("If you see a delivery failure it might be because last char was char"
  @ $globalize_new_precorded_char_number); % always_current_waiter_name = % this.Name;
 echo("\c2 AT START OF COLLECT, always_current_waiter_name = "
  @ % always_current_waiter_name @ " vs input "
  @ % this.Name);
 $waiter_mount_point_x = ("mount_point"
  @ $globalize_new_precorded_char_number).getPositionX();
 $waiter_mount_point_y = ("mount_point"
  @ $globalize_new_precorded_char_number).getPositionY();

 % this.setSize(18.457, 20.215);

 //despawn icons
 echo("\c2 aT function waiter::start_waiter_collect, $CHAR_NUMBER @ SMELLY = "
  @ $char_number @ " vs better# "
  @ $globalize_new_precorded_char_number);
 //edit 02-02-2013 gave control of smelly animation to coin_tip instead, so erasing control here
 echo("\c2 LEGACY CRAP FFS pointer_tip"
  @ $char_number @ " & "
  @ "smellyb"
  @ $char_number @ " vs better# "
  @ $globalize_new_precorded_char_number);
 //edit 02-02-2013 gave control of coin_tip to coin_tip instead, so erasing control here

 $waiter_sched_05 = % this.schedule(10, "end_waiter_collect_turn", 0);

 //edit 04082013 maybe interference with tip collect
 //edit 06-09-2013 attempting to convert this coin_tip global to a dynamic field local so no overwrite
 $find_coin_tip = "empty_coin"
 @ $char_number;
 $find_coin_tip.collect_tip = 0;
 $waiter_is_mobile = 1;
}

function waiter::end_waiter_collect_poof( % this) {
 /* edit 12-26-2012 : delayed empty_coin.collected as clicking on waiter to init before collecting tip in certain order may cause premature mousedown halt */
 //edit 02-02-2013 giving control of collection of empty_coin to empty_coin.cs instead of waiter.cs so you cant cross-collect if clicking two tips really fast
 //("empty_coin" @ $char_number).collected = 1;	
 //%this.setAnimation(waiter_poof_backAnimation);
 if ($mute_soundfx != 1) {
  alxPlay(waiter_rush);
 }
 $waiter_sched_06 = % this.schedule(400, "end_waiter_collect_turn", 0);
 echo("end_waiter_collect_poof");
}

function waiter::end_waiter_collect_turn( % this) {
 //edit 02-02-2013 Need another clause so waiter doesnt collect tip and serve drink at the same time
 $waiter_currently_collecting_tip_please_wait = 0;
 /* edit 12-27-2012 : switched from "way_point" @ %this.num to $char_number in hopes of accurate tip colletion */
 $current_way_point = ("way_point" @ $char_number);
 $waiter_way_point_x = $current_way_point.getPositionX();
 $waiter_way_point_y = $current_way_point.getPositionY();
 $clear_out_legacy_drink = "drink_out" @ $drink_being_sent_back;
 /* Special Case 29 : If coin tip exists, is clicked, and is clicked after another coin tip is, reset incoming drink data based on char_number
 which is now controlled via coin_tip, and is accurate in this circumstance*/
 $tip_collected_reestablish_number = "empty_coin"
 @ $char_number;
 if ($tip_collected_reestablish_number.collected == 1) {
  $drink_being_sent_back = $char_number;
  $clear_out_legacy_drink = "drink_out" @ $char_number;
 }

 //Remount their position to drink_out 
 $gather_drink_latest_pos_x = $clear_out_legacy_drink.getPositionX();
 $gather_drink_latest_pos_y = $clear_out_legacy_drink.getPositionY();
 $waiter_to_drink_pos_x = $gather_drink_latest_pos_x + 2;
 $waiter_to_drink_pos_y = $gather_drink_latest_pos_y + 2;
 $waiter_sched_07 = % this.schedule(1300, "extra_poof_back", 0);
 $wait_for_end_waiter_active = 1;
 $waiter_sched_08 = % this.schedule(1310, "special_case_additional_wait_time_needed", 0);
 $no_clicking_waiter = 0;
 echo("\c2 ENDED waiter_collect_turn, $no_clicking_waiter = 0");


}

function waiter::extra_poof_back( % this) { % this.BlendColor = "1 1 1 1";
 $waiter_is_informed = 1;
 $waiter_sched_09 = % this.schedule(500, "end_waiter", % pass_char_data_locally);
 $stop_interaction_with_all_waiters = 0;
 $pause_all_chars = 0;


}

function waiter::special_case_additional_wait_time_needed( % this) {
 //special case 27 : Additional time needed just in case of monkey clicking when waiter is collecting tip
 //intercepting and preventing further chars from collecting
 $wait_for_selected_waiter_to_do_something_first = 0;
 echo("wait_for_selected_waiter_to_do_something_first = 0 triggered via waiter::special_case_additional_wait_time_needed");
}

function waiter::activate_clicking_on_waiter_when_theyre_not_busy( % this) {
 $no_clicking_waiter = 0;
 echo("\c2 NO CLICKING WAITER NOW EQUALS ZERO");
}

function waiter::start_waiter_part2( % this) { % this.BlendColor = "1 1 1 1"; % this.setSize(19.824, 23.828);
 $waiter_is_informed = 1;
 $waiter_sched_10 = % this.schedule(450, "start_waiter_part3", 0);

}

function waiter::start_waiter_part3( % this) {
 $correct_char_num = $current_char.seat_num; % this.BlendColor = "1 1 1 1";
 //$no_clicking_waiter = 0;
 $waiter_mount_point_x = ("mount_point"  @ $correct_char_num).getPositionX();
 $waiter_mount_point_y = ("mount_point"  @ $correct_char_num).getPositionY();
 $waiter_is_informed = 1;
 $waiter_sched_11 = % this.schedule(1530, "start_waiter_part4", 0);

}

function waiter::start_waiter_part4( % this, % pass_char_data_locally, % fruit_direct1, % fruit_direct2) {
 $char_for_hard_pause = % pass_char_data_locally;
 echo("%pass_char_data_locally::start_waiter_part4 = " @ % pass_char_data_locally);
 //edit 01-26-2014 to prevent any inconsistencies in declaring which character is who, make a local based off of a dynamic_field based on a passed %this
 % character_final_identifier = % this.record_char_num;

 //if($tut_yes_is_active == 0)
 //{
 //Edit 05-12-2013 Added to prevent character from last world morphing into same placement char of next world and completing approval and giving User a tip
 if ($waiter_waiting_for_old_world_data_to_die != 1) {
  if ($mute_soundfx != 1) {
   alxPlay(place_down_drink);
  }
  $drink_was_clicked = 0; % pass_char_data_locally = % pass_char_data_locally;
  //01-22-2013 replaced all $drink1_num with %pass_char_data_locally.thirst_p1;
  //01-22-2013 replaced all $drink2_num with %pass_char_data_locally.thirst_p2;

  //edit 05-14-2013 If char left before this point, too bad, you lose. Too many stipulations are going on.
  if ( % pass_char_data_locally.is_despawned != 1) {
   //edit 08-13-2013 exception for char1 ignition
   //edit 06-09-2014 adding clause for tutorial only gold:  & $world_numeral == 1 & $round_numeral == 1
   if ($reset_star_value_for_init_char1 == 1 & % pass_char_data_locally.seat_num == 1 & $world_numeral == 1 & $round_numeral == 1) {
    //give player a freebie for char1 to end all dillemas
    % pass_char_data_locally.star_timer = 10000;
    $reset_star_value_for_init_char1 = 0;
   }
   //edit 05-20-2013 adding capture value for star timer
   display_get_it3.text = % pass_char_data_locally.star_timer; % star_value = % pass_char_data_locally.star_timer;



   echo("\c2 ****STAR TIMER**** WOOOOOOOOOO AT "
    @ % star_value);

   echo("\c2 function waiter::start_waiter_part4 END is $flip_check == "
    @ $flip_check @ " & $drink_out_selected2 == "
    @ $drink_out_selected2 @ " & , char num "
    @ $char_number);

   //$match_drink_frame = $drink_name_[$declare_drink_out_bottom_icon];
   //$match_drink_frame_b = $drinkb_name_[$declare_drink_out_bottom_icon];
   % everything_approved = 0;
   //I think this is frame only...
   % determine_drink_frame = % this.pass_drink_info;
   echo("PASSED DRINK INFO IS "
    @ % determine_drink);

   $match_drink_frame = $drink_name_[$selected_drink2];
   $match_drink_frame_b = $drinkb_name_[$selected_drink2];

   $drink_out_selected1 = % this.pass_drink_nameA;
   $drink_out_selected2 = % this.pass_drink_nameB;

   $find_image_frame1 = $more_accurate_frame_finder1;
   $find_image_frame2 = $more_accurate_frame_finder2;

   //echo("TEST VS FOR PART2 " @ $testing_shit);
   /* NOTE! DURING TUTORIAL DRINK WANTED BY CHAR ARE SUPRESSED AND REROUTED, THUS THEIR LOCAL WANTS DO NOT REPRESENT THEIR CURRENT WANTS THAT ARE FAKED */

   //edit 02-18-2014 doing a sum check comparison since out-of-order drinks should always equal original and can never equal another since 1 part is always the same and the other is not
   % sumcheck1 = $drink_out_selected1 + $drink_out_selected2; % sumcheck2 = % pass_char_data_locally.thirst_p1 + % pass_char_data_locally.thirst_p2;

   //$find_image_frame1
   if ($drink_out_selected1 == % pass_char_data_locally.thirst_p1 & $match_drink_frame == $find_image_frame1 & % sumcheck1 == % sumcheck2) {

    //echo("Ing 1 EQUALS input ing 1");
    //drink p1 of 2 accepted
    $drinkp1_cleared = 1;
   }

   //edit 02-13-2014 adding = %pass_char_data_locally.thirst_p2 check for IF first fruit equals second fruit, if first fruit doesn't equal other first fruit
   // & $drink_out_selected1 == %pass_char_data_locally.thirst_p2
   if ($drink_out_selected1 != % pass_char_data_locally.thirst_p1 & % sumcheck1 == % sumcheck2) {
    //drink p1 of 2 false, but maybe the drinks were correct but out of order
    $hesitate = 1;
   }

   //edit 01-30-2013 Found that drink reversal names were B > A but frames were A > A, probably working out of luck. Fixed.
   if ($drink_out_selected2 == % pass_char_data_locally.thirst_p1 & $match_drink_frame_b == $find_image_frame1 & $hesitate == 1 & % sumcheck1 == % sumcheck2) {
    //echo("Ing 2 EQUALS ing 1");	
    //drink p1 of 2 false, but the drinks WERE correct but out of order
    $flip_check = 1;
   }
   //if tutorial mode is on, make this an easy win
   if ($tut_yes_is_active == 1) {
    $flip_check = 1;
    $drink_out_selected1 = % pass_char_data_locally.thirst_p2; % star_value = 10000; % everything_approved = 1;
    //edit 02-20-2014 realized this part was crucial since tutorial could only be progressed by exact fruits, and sum check fixes the rest of the game
    % sumcheck1 = % sumcheck2;
   }
   //edit 02-13-2014 adding = %pass_char_data_locally.thirst_p1 check for IF first fruit equals second fruit, if first fruit doesn't equal other first fruit
   // & $drink_out_selected2 == %pass_char_data_locally.thirst_p1
   if ($flip_check == 1 & $drink_out_selected1 == % pass_char_data_locally.thirst_p2 & % sumcheck1 == % sumcheck2) {
    //echo("Ing 1 EQUALS ing 2, ing2 equals ing1");	
    //drinks out of order but correct, p1 is p2, p2 is p1
    //affect character positively
    $char1_occupied = 1;
    //02-04-2013 Remounting reanimating dynamic concat		
    //force-picks
    //edit 05-20-2013 Adding star and point system
    //edit 06-06-2013 replacing %pass_char_data_locally with %pass_char_data_locally
    % quarter_clock_limit_star = $game_clock_limit / 4; % gold_clock_limit_star = $game_clock_limit / 2; % silver_clock_limit_star = $game_clock_limit; % bronze_clock_limit_star = $game_clock_limit + % quarter_clock_limit_star;
    gold_clock_limit_says.text = % gold_clock_limit_star;
    silver_clock_limit_says.text = % silver_clock_limit_star;
    bronze_clock_limit_says.text = % gold_clock_limit_star; % gold_min = 1; % silver_min = % gold_clock_limit_star + 1; % bronze_min = % silver_clock_limit_star + 1; % fail_min = % bronze_clock_limit_star + 1; % echo_fail_min = % bronze_clock_limit_star + 3000;
    display_get_it.text = % star_value;
    display_get_it2.text = % gold_clock_limit_star;
    if ( % star_value <= % gold_clock_limit_star & % star_value >= % gold_min) { % pass_char_data_locally.star_points = 3;

    }
    if ( % star_value <= % silver_clock_limit_star & % star_value >= % silver_min) { % pass_char_data_locally.star_points = 2;
    }
    if ( % star_value <= % bronze_clock_limit_star & % star_value >= % bronze_min) { % pass_char_data_locally.star_points = 1;

    }
    if ( % star_value >= % fail_min) { % pass_char_data_locally.star_points = 0;

    }
    if ( % star_value >= % echo_fail_min) {
     echo("***PLAYER WAS TOO SLOW TO EARN***, " @ % pass_char_data_locally @ " was served at " @ % star_value @ " milliseconds");

    }

    echo("\c2 >>>>>>star points = " @ % pass_char_data_locally.star_points); 
	% find_mount_pos_x = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionX(); 
	% find_mount_pos_y = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionY(); 
	% new_customer_xpos = $xpos_customer[ % pass_char_data_locally.model_type]; 
	% new_customer_ypos = $ypos_customer[ % pass_char_data_locally.model_type]; 
	% reposition_customer_x = % find_mount_pos_x - % new_customer_xpos; 
	% reposition_customer_y = % find_mount_pos_y - % new_customer_ypos;
    //edit 01-02-2014 adding extra functionality for special characters
    % make_unique_char_num_incase_special_chars = % pass_char_data_locally; % specific_specialized_char = % make_unique_char_num_incase_special_chars.seat_num;
    if ($toggle_off_model5_via_drink_vers1 == 1) { % make_unique_char_num_incase_special_chars.model_type = % pass_char_data_locally.seat_num;
    }
    if ($spawn_special_character == 1 & $special_char_world == $world_numeral & $special_char_level == $current_level & % specific_specialized_char == $prechosen_seat_num_for_special_char & $toggle_off_model5_via_drink_vers1 != 1 & $disable_special_char == 0) {
     echo(">>> model type switched to 5 via drink vers 1"); % make_unique_char_num_incase_special_chars.model_type = 5;
     //02-20-2014 don't fail the elvis							
     if ( % star_value < 27000 & $world_numeral == 4) {
      check_for_elvis_non_black_out();
     }
     //If you serve silver or lower, fail the user							
     if ( % star_value >= 27001) {
      force_black_out();
      special_character_hili.setPositionX(9999);
      special_character_hili.setPositionY(9999);
     }
     //02-20-2014 don't fail the elvis
     if ( % star_value < 27000 & $world_numeral == 4) {
      check_for_elvis_non_black_out();
     }

     //TROPHY: Press Release
     if ( % star_value < 27000 & $world_numeral == 3 & $round_numeral == 10 & $end_trophy_ribbon1 != 1) {
      $root_trophy_identfier = "ribbon1";
      win_this_trophy();
      $end_trophy_ribbon1 = 1;
     }

     //TROPHY: Best of France Magazine
     if ( % star_value < 27000 & $world_numeral == 8 & $round_numeral == 10 & $end_trophy_ribbon5 != 1) {
      $root_trophy_identfier = "ribbon5";
      win_this_trophy();
      $end_trophy_ribbon5 = 1;
     }

     //TROPHY: Flawless Inspection
     if ( % star_value < 27000 & $world_numeral == 9 & $round_numeral == 10 & $end_trophy_ribbon3 != 1) {
      $root_trophy_identfier = "ribbon3";
      win_this_trophy();
      $end_trophy_ribbon3 = 1;
     }

     //TROPHY: Celebrity Status
     if ( % star_value < 27000 & $world_numeral == 4 & $round_numeral == 10 & $end_trophy_ribbon2 != 1) {
      $root_trophy_identfier = "ribbon2";
      win_this_trophy();
      $end_trophy_ribbon2 = 1;
     }

     $toggle_off_model5_via_drink_vers1 = 1;
     $disable_special_char = 1;
    }
    //end edit 01-02-2014 adding extra functionality for special characters					

    % new_customer_width = $width_customer[ % make_unique_char_num_incase_special_chars.model_type]; % new_customer_height = $height_customer[ % make_unique_char_num_incase_special_chars.model_type]; % new_customer_idle_animation = $customer[ % make_unique_char_num_incase_special_chars.model_type] @ "_drinkAnimation";
    //edit 03-20-2015
    echo("<<<<<<<<<<<<<<<<< from drink 1");
    $enable_red_x = 0; % this.in_cell = 2;
    ("appetizer_thought"
     @ % pass_char_data_locally.seat_num).setImageMap(want_emptyImageMap);
    $toggle_serve_cursor = 0;
    $toggle_appetizer_cursor = 0;
    set_cursor_to_default();
    //customer drank drink, so untoggle the customers served counter
    $toggle_customers_served_counter = 0;

    //scripted sequence for tutorial only
    if ($tutorial_activate_tip_sequence == 1) {
     tutorial_text_block.setBlendAlpha(100);
     tutorial_text_block.text = $tut_06;
     tutorial_text_block.setPositionX(118);
     tutorial_text_block.setPositionY(9.626);
     tutorial_bar.setPositionX(126);
     tutorial_bar.setPositionY(9.626);
     pointer_tutorial.setPositionX(9999);
     pointer_tutorial.setPositionY(-4);
     pointer_tutorial.setRotation(270);
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setBlendAlpha(0);
    }


    % pass_char_data_locally.setPositionX( % reposition_customer_x); % pass_char_data_locally.setPositionY( % reposition_customer_y);
    //edit 01-02-2014 adding extra functionality for special characters
    % make_unique_char_num_incase_special_chars.setAnimation( % new_customer_idle_animation); % make_unique_char_num_incase_special_chars.setSize( % new_customer_width, % new_customer_height);
    //edit 01-23-2014 lop off serving drinks again to customer since they're already drinking
    % make_unique_char_num_incase_special_chars.already_served = 1;
    /* EDIT 05-09-2013 */
    % pass_char_data_locally.detected_incoming_drink = 1; % pass_char_data_locally.lock_incoming_drink = 1;
    echo("!!!!!!!!!!!!@@@lock possible char anger at waiter part 2");

    ("icon_exclame" @ % pass_char_data_locally.seat_num).setAnimation(empty_char_spaceAnimation);
    ("thought" @ % pass_char_data_locally.seat_num).setAnimation(empty_char_spaceAnimation);
    ("p_want" @ % pass_char_data_locally.seat_num).setImageMap(empty_char_spaceImageMap);
    ("p_wantb" @ % pass_char_data_locally.seat_num).setImageMap(empty_char_spaceImageMap);
    echo("\c2 PPPPPPPPPPPPPPPPPPPPPPPwant @ waiter::wait_for_char_to_pay is $flip_check == 1 & $drink_out_selected2 == %pass_char_data_locally.thirst_p1, char num " @ $char_number);
    //%this.setAnimation(waiter_poof_backAnimation);
    if ($mute_soundfx != 1) {
     alxPlay(waiter_rush);
    } % this.setSize(19.824, 23.828);
    $waiter_sched_12 = % this.schedule(400, "end_waiter", % pass_char_data_locally);
    $wait_for_end_waiter_active = 1;
    $wait_for_selected_waiter_to_do_something_first = 0; 
	% everything_approved = 1; 
	% this.is_serving = 1;
    $waiter_sched_13 = % this.schedule(5000, "wait_for_char_to_finish", % pass_char_data_locally);

    //for trophy "Close Shave" award
    if ( % pass_char_data_locally.is_angry == 1 & $trophy_toggle_off_mount1 != 1) {
     $root_trophy_identfier = "mount1";
     win_this_trophy();
     $trophy_toggle_off_mount1 = 1;
    }

    //Customers served counter for trophies
    if ($toggle_customers_served_counter != 1) {
     $customers_served_counter += 1;
     $toggle_customers_served_counter = 1;
    }
    //TROPHIES: 50 Served, 100 Served, 200 Served
    if ($customers_served_counter == 50 & $trophy_toggle_off_trophy6 != 1) {
     $root_trophy_identfier = "trophy6";
     win_this_trophy();
     $trophy_toggle_off_trophy6 = 1;
    }

    if ($customers_served_counter == 100 & $trophy_toggle_off_trophy7 != 1) {
     $root_trophy_identfier = "trophy7";
     win_this_trophy();
     $trophy_toggle_off_trophy7 = 1;
    }

    if ($customers_served_counter == 200 & $trophy_toggle_off_trophy8 != 1) {
     $root_trophy_identfier = "trophy8";
     win_this_trophy();
     $trophy_toggle_off_trophy8 = 1;
    }
    //End trophies 50, 100, 200 customers

    //note you have to double these up since its waiter
    if ($customers_served_counter == 55 & $trophy_toggle_off_trophy2 != 1) {
     $root_trophy_identfier = "trophy2";
     win_this_trophy();
     $trophy_toggle_off_trophy2 = 1;
    }
   }
   /* Special Case 12-27-2012 A */

   //if last char logged at pay does not exist yet, make the function below special case work
   if ($logged_char_num_at_pay == 99) { % pass_char_data_locally.waiting_for_char = 0;
   }

   //if last char to tip interrupts this sequence, check if last char is this char, if not, then proceed
   if ($logged_char_num_at_pay != % pass_char_data_locally.seat_num) { % pass_char_data_locally.waiting_for_char = 0;
   }

   if ($logged_char_num_at_pay != $char_number) { % pass_char_data_locally.waiting_for_char = 0;
   }
   /*-------------------------*/

   //edit 05-14-2013 seeing as start_waiter should be fully isolated and secure, adding clause so drink sending doesn't here
   % pass_char_data_locally.waiting_for_char = 0;

   if ($drinkp1_cleared == 1 & $drink_out_selected2 == % pass_char_data_locally.thirst_p2 & % pass_char_data_locally.waiting_for_char == 0) {
	
    //drink p2 of 2 correct, and drink p1 of 2 correct
    //affect character positively
    $char1_occupied = 1;
    //02-04-2013 Remounting reanimating dynamic concat		
    //force-picks
    //%pass_char_data_locally.model_type = 1;
    echo("\c2 >>>>>>%pass_char_data_locally = "
     @ % pass_char_data_locally.seat_name);
    gold_clock_limit_says.text = % star_value;
    silver_clock_limit_says.text = % star_value;
    bronze_clock_limit_says.text = % star_value;

    //Trophy: Speedster Delivery
    if ( % pass_char_data_locally.seat_num != 1 & % star_value <= 26000 & % star_value >= 1 & $trophy_toggle_off_button4 != 1) {
     $root_trophy_identfier = "button4";
     win_this_trophy();
     $trophy_toggle_off_button4 = 1;
    }




    //edit 05-20-2013 Adding star and point system
    display_get_it.text = % star_value @ " 2";
    display_get_it2.text = % gold_clock_limit_star @ "2";
    if ( % star_value <= 27000 & % star_value >= 1) { % pass_char_data_locally.star_points = 3;
     //determine star_system_award rating
     if ($star_sys_medal_won > 2) {
      $star_sys_medal_won = 3;
     }
    }

    if ( % star_value <= 30000 & % star_value >= 27001) { % pass_char_data_locally.star_points = 2;
     //determine star_system_award rating
     if ($star_sys_medal_won > 1) {
      $star_sys_medal_won = 2;
     }
    }

    if ( % star_value <= 33000 & % star_value >= 30001) { % pass_char_data_locally.star_points = 1;
     //determine star_system_award rating
     if ($star_sys_medal_won > 0) {
      $star_sys_medal_won = 1;
     }
    }

    if ( % star_value <= 36000 & % star_value >= 33001) { % pass_char_data_locally.star_points = 0;
     //determine star_system_award rating
     if ($star_sys_medal_won > 0) {
      $star_sys_medal_won = 1;
     }
    }
    //edit 01-08-2014 Apparently there wasn't an exception for really-really-slow
    if ( % star_value > 36000) {
     //root of char5 only error :(
     % pass_char_data_locally.star_points = 0;
     //determine star_system_award rating
     //make sure its not 999
     if ($star_sys_medal_won > 0) {
      $star_sys_medal_won = 1;
     }
    }

    echo("\c2 >>>>>>star points = " @ % pass_char_data_locally.star_points); 
	% find_mount_pos_x = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionX(); 
	% find_mount_pos_y = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionY(); 
	% new_customer_xpos = $xpos_customer[ % pass_char_data_locally.model_type]; 
	% new_customer_ypos = $ypos_customer[ % pass_char_data_locally.model_type]; 
	% reposition_customer_x = % find_mount_pos_x - % new_customer_xpos; 
	% reposition_customer_y = % find_mount_pos_y - % new_customer_ypos;
    //edit 01-02-2014 adding extra functionality for special characters
    % make_unique_char_num_incase_special_chars = % pass_char_data_locally;
    if ($toggle_off_model5_via_drink_vers2 == 1) { % make_unique_char_num_incase_special_chars.model_type = % pass_char_data_locally.seat_num;
    }
    if ($spawn_special_character == 1 & $spawn_special_character == 1 & $special_char_world == $world_numeral & $special_char_level == $current_level & % specific_specialized_char == $prechosen_seat_num_for_special_char & $toggle_off_model5_via_drink_vers2 != 1 & $disable_special_char == 0) {
     echo(">>> model type switched to 5 via drink vers 2"); % make_unique_char_num_incase_special_chars.model_type = 5;
     //02-20-2014 don't fail the elvis							
     if ( % star_value < 27000 & $world_numeral == 4) {
      check_for_elvis_non_black_out();
     }
     //If you serve silver or lower, fail the user
     if ( % star_value >= 27001) {
      force_black_out();
      special_character_hili.setPositionX(9999);
      special_character_hili.setPositionY(9999);
     }

     //TROPHY: Press Release
     if ( % star_value < 27000 & $world_numeral == 3 & $round_numeral == 10 & $end_trophy_ribbon1 != 1) {
      $root_trophy_identfier = "ribbon1";
      win_this_trophy();
      $end_trophy_ribbon1 = 1;
     }

     //TROPHY: Best of France Magazine
     if ( % star_value < 27000 & $world_numeral == 8 & $round_numeral == 10 & $end_trophy_ribbon5 != 1) {
      $root_trophy_identfier = "ribbon5";
      win_this_trophy();
      $end_trophy_ribbon5 = 1;
     }

     //TROPHY: Flawless Inspection
     if ( % star_value < 27000 & $world_numeral == 9 & $round_numeral == 10 & $end_trophy_ribbon3 != 1) {
      $root_trophy_identfier = "ribbon3";
      win_this_trophy();
      $end_trophy_ribbon3 = 1;
     }
     //TROPHY: Celebrity Status
     if ( % star_value < 27000 & $world_numeral == 4 & $round_numeral == 10 & $end_trophy_ribbon2 != 1) {
      $root_trophy_identfier = "ribbon2";
      win_this_trophy();
      $end_trophy_ribbon2 = 1;
     }
     $toggle_off_model5_via_drink_vers2 = 1;
     $disable_special_char = 1;
    }
    //end edit 01-02-2014 adding extra functionality for special characters	
    % new_customer_width = $width_customer[ % make_unique_char_num_incase_special_chars.model_type]; % new_customer_height = $height_customer[ % make_unique_char_num_incase_special_chars.model_type]; % new_customer_idle_animation = $customer[ % make_unique_char_num_incase_special_chars.model_type] @ "_drinkAnimation";
    //edit 03-20-2015
    echo("<<<<<<<<<<<<<<<<< from drink 2");
    $enable_red_x = 0; % this.in_cell = 2;
    ("appetizer_thought"
     @ % pass_char_data_locally.seat_num).setImageMap(want_emptyImageMap);
    $toggle_serve_cursor = 0;
    $toggle_appetizer_cursor = 0;
    set_cursor_to_default();
    //customer drank drink, so untoggle the customers served counter
    $toggle_customers_served_counter = 0;
    //scripted sequence for tutorial only
    if ($tutorial_activate_tip_sequence == 1) {
     tutorial_text_block.setBlendAlpha(100);
     tutorial_text_block.text = $tut_06;
     tutorial_text_block.setPositionX(118);
     tutorial_text_block.setPositionY(9.626);
     tutorial_bar.setPositionX(126);
     tutorial_bar.setPositionY(9.626);
     pointer_tutorial.setPositionX(9999);
     pointer_tutorial.setPositionY(-4);
     pointer_tutorial.setRotation(270);
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setBlendAlpha(0);
    }

    % pass_char_data_locally.setPositionX( % reposition_customer_x); % pass_char_data_locally.setPositionY( % reposition_customer_y); % make_unique_char_num_incase_special_chars.setAnimation( % new_customer_idle_animation); % make_unique_char_num_incase_special_chars.setSize( % new_customer_width, % new_customer_height);
    //edit 01-23-2014 lop off serving drinks again to customer since they're already drinking
    % make_unique_char_num_incase_special_chars.already_served = 1;

    /* EDIT 05-09-2013b */
    % pass_char_data_locally.detected_incoming_drink = 1; % pass_char_data_locally.lock_incoming_drink = 1;
    ("icon_exclame" @ % pass_char_data_locally.seat_num).setAnimation(empty_char_spaceAnimation);
    ("thought" @ % pass_char_data_locally.seat_num).setAnimation(empty_char_spaceAnimation);
    ("p_want" @ % pass_char_data_locally.seat_num).setImageMap(empty_char_spaceImageMap);
    ("p_wantb" @ % pass_char_data_locally.seat_num).setImageMap(empty_char_spaceImageMap);
    //%this.setAnimation(waiter_poof_backAnimation);
    if ($mute_soundfx != 1) {
     alxPlay(waiter_rush);
    } % this.setSize(19.824, 23.828);
    $waiter_sched_14 = % this.schedule(400, "end_waiter", % pass_char_data_locally);
    $wait_for_end_waiter_active = 1; % everything_approved = 1; % this.is_serving = 1;
    $waiter_sched_15 = % this.schedule(5000, "wait_for_char_to_finish", % pass_char_data_locally);

    //for trophy "Close Shave" award	
    if ( % pass_char_data_locally.is_angry == 1 & $trophy_toggle_off_mount1 != 1) {
     $root_trophy_identfier = "mount1";
     win_this_trophy();
     $trophy_toggle_off_mount1 = 1;
    }

    //Customers served counter for trophies
    if ($toggle_customers_served_counter != 1) {
     $customers_served_counter += 1;
     $toggle_customers_served_counter = 1;
    }
    //TROPHIES: 50 Served, 100 Served, 200 Served
    if ($customers_served_counter == 50 & $trophy_toggle_off_trophy6 != 1) {
     $root_trophy_identfier = "trophy6";
     win_this_trophy();
     $trophy_toggle_off_trophy6 = 1;
    }

    if ($customers_served_counter == 100 & $trophy_toggle_off_trophy7 != 1) {
     $root_trophy_identfier = "trophy7";
     win_this_trophy();
     $trophy_toggle_off_trophy7 = 1;
    }

    if ($customers_served_counter == 200 & $trophy_toggle_off_trophy8 != 1) {
     $root_trophy_identfier = "trophy8";
     win_this_trophy();
     $trophy_toggle_off_trophy8 = 1;
    }
    //End trophies 50, 100, 200 customers

    //note you have to double these up since its waiter
    if ($customers_served_counter == 55 & $trophy_toggle_off_trophy2 != 1) {
     $root_trophy_identfier = "trophy2";
     win_this_trophy();
     $trophy_toggle_off_trophy2 = 1;
    }
   }

   if ($waiting_for_char > 0) {
    //lock off alternate animation requests please
   }

   //edit 05-14-2013 If char left before this point, too bad, you lose. END CLAUSE
  }

  //edit 03-20-2015 redoing red x
  if ($toggle_cursor_is_serving == 1 & $enable_red_x == 1) {
   echo("RED X HAD GONE THROUGH");
   make_red_x();
  }
  $enable_red_x = 1;

  //if incorrect drink send waiter back to idle
  if ( % everything_approved == 0) {
   callie.shame();
   //%this.BlendColor = "1 0 0 0.9";
   % this_x = % pass_char_data_locally.getPositionX(); % this_y = % pass_char_data_locally.getPositionY(); % reset_pos_x = % this_x - 3; % reset_pos_y = % this_y - 9;
   //edit 03-19-2015 fix for double red_x				
   if ($red_x_used_already != 1) {
    icon_what.setPositionX( % reset_pos_x);
    icon_what.setPositionY( % reset_pos_y);
    //edit 03-20-2015 disabling old red x					
    $red_x_used_already = 1;
   }
   echo("red_xAnimation played for char "
    @ % pass_char_data_locally.seat_num);
   if ($mute_soundfx != 1) {
    alxPlay(error_noise);
   }
   if ($mute_soundfx != 1) {
    alxPlay(waiter_rush);
   }
   $toggle_serve_cursor = 0;
   set_cursor_to_default();
   $waiter_sched_16 = % this.schedule(10, "end_waiter", % pass_char_data_locally);
  }

 }
}

//add Part 5 function for turn back anim
function waiter::send_back_drink( % this, % pass_char_data_locally) {
 //need to pass char data to coin tip!!!!! char no longer exists at coin tip and waiter is variable
 echo("%pass_char_data_locally = " @ % pass_char_data_locally);

 //%this.pass_drink_info = $current_coin_tip.pass_last_drink_info;
 % drink_being_sent_back = % this.pass_drink_info;
 //switched drink_being_sent_back from $ to % and redclared what it is. delete all of above clauses to undo and swith all % below to $
 $active_to_clean_drink = "drink_in" @ % drink_being_sent_back;
 //edit 01-06-2013 declare sodajerk attributes for drink_in
 % set_sodajerk_cleaner = "sodajerk" @ % drink_being_sent_back; 
 % set_sodajerk_cleaner.should_wash_dish = 1;
 //05-06-2013 declaring incoming drink as dirty;
 $active_to_clean_drink.dirty = 1;
 echo("%set_sodajerk_cleaner = " @ % set_sodajerk_cleaner);
 % this_sodajerk_num = % drink_being_sent_back;
 $cook_red_stop[ % this_sodajerk_num] = 0; 
 % set_sodajerk_cleaner.redify();


 $clear_out_legacy_drink = "drink_out" @ % drink_being_sent_back;

 //spawn icon pointer bad

 $pointer_bad_num = % drink_being_sent_back;
 $pointer_bad_name = "pointer_bad"
 @ $pointer_bad_num;
 $this_drinks_x = $active_to_clean_drink.getPositionX();
 $this_drinks_y = $active_to_clean_drink.getPositionY();
 $drink_reset_pos_x = $this_drinks_x;
 $drink_reset_pos_y = $this_drinks_y - 6;
 $pointer_bad_name.setPositionX($drink_reset_pos_x);
 $pointer_bad_name.setPositionY($drink_reset_pos_y);
 $pointer_bad_name.setAnimation(icon_pointer_badAnimation);

 //-----------------------------------------------------------------//
 //%declare_char_for_backtracking_algorithm.deliver_drink_info
 $drink_up_for_cleaning = % drink_being_sent_back;
 $give_to_sodajerk = "sodajerk"
 @ $drink_up_for_cleaning;
 $give_to_sodajerk.drink_up_for_cleaning = $drink_up_for_cleaning;
 echo("\c2 DRINK being sent back is "
  @ $drink_up_for_cleaning);
 //**********************************************************************************
 //$active_to_clean_drink.onMouseDown(%this);
 $active_to_clean_drink.schedule(800, "wash_cup", 0);
}

function waiter::end_waiter( % this, % pass_char_data_locally) {
 echo("%pass_char_data_locally::end_waiter = "
  @ % pass_char_data_locally);
 //05-13-2013 Adding to prevent jumping from tip to tip immediately
 $current_waiter.is_collecting_tip = 0;
 $waiter_is_already_collecting_tips = 0;

 //edit 05-12-2013 Reusing statement so waiter cant pickup drinks while he's busy so theres no mis-orders or overlap
 $waiter_currently_collecting_tip_please_wait = 0;
 $waiter_is_mobile = 0;
 //edit 04082013 maybe interference with tip collect
 //edit 06-09-2013 Making this hopefully local via dynamic field array vs global which causes issues if you monkey click coin_tip to coin_tip
 $find_coin_tip = "empty_coin"
 @ % pass_char_data_locally;
 $find_coin_tip.collect_tip = 0;
 //added 01-22-2013 globals to identify char at time of delivery since theres one waiter so its unchangeable during this
 //removed 08-27-2013 tip error is via idle_no_char, no more of these were found except here
 $wait_for_end_waiter_active = 1;
 $hiatus_on_positioning_tip_collect = 0; % this.setSize(17.188, 22.363);
 $current_way_point = way_point @ % this.num;

 $waiter_is_informed = 0;
 $cook_is_done = 0;

 $waiter_init = 0;
 $customer_clicked = 0;
 $current_char.waiting_for_char = 0;
 $wait_for_end_waiter_active = 0;

 % this.activation_of_movement = 0; % this.is_serving = 0;

}

function waiter::wait_for_char_to_finish( % this, % pass_char_data_locally) {

 echo("%pass_char_data_locally::wait_for_char_to_finish = "
  @ % pass_char_data_locally);
 //Edit 05-12-2013 Added to prevent character from last world morphing into same placement char of next world and completing approval and giving User a tip
 if ($waiter_waiting_for_old_world_data_to_die != 1) { % test_with_cache_in_char = "empty_char_space"
  @ $cache_in_char; % current_char_numeric_identifier = % pass_char_data_locally.seat_num; % initial_name_run_at_tutorial = "empty_char_spacename"; % pass_char_data_locally = % pass_char_data_locally;

  if ($cache_in_char == % current_char_numeric_identifier) {
   echo("$cache_in_char numeric = %pass_char_data_locally numeric");
  }
  if ($cache_in_char != % current_char_numeric_identifier) {
   //Special Case 36: Initial name at start of game not established so force name to %pass_char_data_locally
   echo("Special Case 36 Activated: Initial name at start of game not established so force name to %pass_char_data_locally"); % pass_char_data_locally = % pass_char_data_locally;
  }
  //%pass_char_data_locally = %test_with_cache_in_char;	
  echo("\c2 current_char for coin tip transfer is "
   @ % pass_char_data_locally); % pass_char_data_locally = % pass_char_data_locally;
  //edit 01-02-2014 adding extra functionality for special characters
  % make_unique_char_num_incase_special_chars = % pass_char_data_locally; % specific_specialized_char = % pass_char_data_locally.seat_num;
  if ($toggle_off_model5_via_wait == 1) { % make_unique_char_num_incase_special_chars.model_type = % pass_char_data_locally.seat_num;
  }
  if ($spawn_special_character == 1 & $special_char_world == $world_numeral & $special_char_level == $current_level & % specific_specialized_char == $prechosen_seat_num_for_special_char & $toggle_off_model5_via_wait != 1) {
   echo("$toggle_off_model5_via_wait special clause via approval activated"); % make_unique_char_num_incase_special_chars.model_type = 5;

   special_character_hili.setPositionX(9999);
   special_character_hili.setPositionY(9999);
   $toggle_off_model5_via_wait = 1;
   echo("$toggle_off_model5_via_wait special clause via approval ended");

  }
  //end edit 01-02-2014 adding extra functionality for special characters
  /* ------------------------------------------------------------------------------NEEDS TO BE LOCAL TO CHAR */
  % pass_char_data_locally.waiting_for_char = 1;
  //edit 05-14-2013 Added clause so char doesn't prematurely (and wrongly) go from approve to get_angry > deteleport
  % pass_char_data_locally.detected_incoming_drink = 1;

  % find_mount_pos_x = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionX(); 
  % find_mount_pos_y = ("mount_point" @ % pass_char_data_locally.seat_num).getPositionY(); 
  % new_customer_xpos = $xpos_customer[ % pass_char_data_locally.model_type]; 
  % new_customer_ypos = $ypos_customer[ % pass_char_data_locally.model_type]; 
  % reposition_customer_x = % find_mount_pos_x - % new_customer_xpos; 
  % reposition_customer_y = % find_mount_pos_y - % new_customer_ypos;
  //edit 01-02-2014 adding extra functionality for special characters
  //echo 02-01-2014 adapting global data to passed local 
  echo("DETECTING PROBLEM HERE..............................................................................");
  echo("%make_unique_char_num_incase_special_chars = " @ % make_unique_char_num_incase_special_chars);
  echo("%make_unique_char_num_incase_special_chars.model_type = " @ % make_unique_char_num_incase_special_chars.model_type); 
  % new_customer_width = $width_customer[ % make_unique_char_num_incase_special_chars.model_type]; 
  % new_customer_height = $height_customer[ % make_unique_char_num_incase_special_chars.model_type]; 
  % new_customer_idle_animation = $customer[ % make_unique_char_num_incase_special_chars.model_type] @ "_approveAnimation"; 
  % this.in_cell = 3; % pass_char_data_locally.setPositionX( % reposition_customer_x); 
  % pass_char_data_locally.setPositionY( % reposition_customer_y); 
  % pass_char_data_locally.setAnimation( % new_customer_idle_animation); 
  % pass_char_data_locally.setSize( % new_customer_width, % new_customer_height);
  //delays character so no insta-respawn
  % pass_char_data_locally.keep_me_gone_longer = 1;
  //undelays this after certain time limit
  % delay_limit = $game_clock_limit / 2;
  $waiter_sched_17 = % pass_char_data_locally.schedule( % delay_limit, "undelay_any_reteleports", 0);
  echo("\c2 SCHEDULED Keep Me Gone Longer for"
   @ % pass_char_data_locally.seat_name @ " via waiter>approve");

  //%pass_char_data_locally.powerup_buy_time = 0;


  sparkle_emitter.setPositionX( % reposition_customer_x);
  sparkle_emitter.setPositionY( % reposition_customer_y);
  sparkle_emitter.setEffectLifeMode(STOP, 1.0);
  sparkle_emitter.playEffect();
  if ($mute_soundfx != 1) {
   alxPlay(approve_sparkles);
  } % pass_char_data_locally.powerup_buy_time = 0;
  //edit 05-20-2013 for spawning star and points
  if ( % pass_char_data_locally.star_points == 3) {
   $total_combo_level += 1;

   if ($new_level_so_reset_combos_to_none == 1) {
    $total_combo_level = 1;
    $new_level_so_reset_combos_to_none = 0;
   }

   if ($total_combo_level >= 2) {
    $toggle_on_combo_anim = 1;
    combo_alert.setPositionX( % find_mount_pos_x);
    combo_alert.setPositionY( % find_mount_pos_y);
    combo_alert.setAnimation(elec_introAnimation);
    combo_animater.setAnimation(empty_char_spaceAnimation);
    $combo_animater_alpha = 1;
    combo_animater.setBlendAlpha($combo_animater_alpha);
    combo_animater.setPositionX( % find_mount_pos_x);
    combo_animater.setPositionY( % find_mount_pos_y);

    $score_number_x = score_number.getPositionX();
    $score_number_y = score_number.getPositionY();
    point_up_empty_space2.setPositionX($score_number_x);
    point_up_empty_space2.setPositionY($score_number_y);
    point_up_empty_space2.setAnimation(fx_point_up1bAnimation);
    $coinage += 10;
    $points_you_have += 10;
    score_number.text = $coinage;

    if ($total_combo_level == 2) {
     combo_animater.setAnimation(combo_2xAnimation);

    }
    if ($total_combo_level == 3) {
     combo_animater.setAnimation(combo_3xAnimation);
    }
    if ($total_combo_level == 4) {
     combo_animater.setAnimation(combo_4xAnimation);
    }
    if ($total_combo_level == 5) {
     combo_animater.setAnimation(combo_streakAnimation);
    }
    if ($total_combo_level == 6) {
     combo_animater.setAnimation(combo_super_streakAnimation);
    }
    if ($total_combo_level == 7) {
     $activate_callie_777 = 1;
     callie_popup_777.activate_all();
    }
    if ($total_combo_level == 8) {
     combo_animater.setAnimation(combo_mega_streakAnimation);
    }
    if ($total_combo_level == 9) {
     combo_animater.setAnimation(combo_insane_streakAnimation);
    }
    if ($total_combo_level == 10) {
     combo_animater.setAnimation(combo_perfectAnimation);
    }
   }

   star_empty_space.setPositionX( % reposition_customer_x);
   star_empty_space.setPositionY( % reposition_customer_y);
   point_up_empty_space.setPositionX( % reposition_customer_x);
   point_up_empty_space.setPositionY( % reposition_customer_y); % localize_char_name_for_gap_safety = % pass_char_data_locally;
   $waiter_sched_18 = % localize_char_name_for_gap_safety.schedule(2000, "star_spawner_gold", 0);
   $waiter_sched_19 = % localize_char_name_for_gap_safety.schedule(3000, "point_spawner_30", 0);
  }
  if ( % pass_char_data_locally.star_points == 2) {
   $total_combo_level = 0;
   star_empty_space.setPositionX( % reposition_customer_x);
   star_empty_space.setPositionY( % reposition_customer_y);
   point_up_empty_space.setPositionX( % reposition_customer_x);
   point_up_empty_space.setPositionY( % reposition_customer_y); % localize_char_name_for_gap_safety = % pass_char_data_locally;
   $waiter_sched_20 = % localize_char_name_for_gap_safety.schedule(2000, "star_spawner_silver", 0);
   $waiter_sched_21 = % localize_char_name_for_gap_safety.schedule(2000, "point_spawner_20", 0);
  }
  if ( % pass_char_data_locally.star_points == 1) {
   $total_combo_level = 0;
   star_empty_space.setPositionX( % reposition_customer_x);
   star_empty_space.setPositionY( % reposition_customer_y);
   point_up_empty_space.setPositionX( % reposition_customer_x);
   point_up_empty_space.setPositionY( % reposition_customer_y); % localize_char_name_for_gap_safety = % pass_char_data_locally;
   $waiter_sched_22 = % localize_char_name_for_gap_safety.schedule(2000, "star_spawner_bronze", 0);
   $waiter_sched_23 = % localize_char_name_for_gap_safety.schedule(3000, "point_spawner_10", 0);
  }
  if ( % pass_char_data_locally.star_points == 0) {
   $total_combo_level = 0;
   //you suck, and thus get nothing
  }


  % discover_coin_tip_equivalent = "empty_coin"
  @ % pass_char_data_locally.seat_num;
  echo("\c2 CoIn TiP name is " @ % discover_coin_tip_equivalent); 
  % discover_coin_tip_equivalent.pass_last_drink_info = % pass_char_data_locally.deliver_drink_info;
  echo("\c2 CoIn TiP :::: empty_coin" @ % pass_char_data_locally.seat_num @ " .pass_last_drink_info = " @ % discover_coin_tip_equivalent.pass_last_drink_info);
  $waiter_sched_24 = % this.schedule(3000, "wait_for_char_to_pay", % pass_char_data_locally);
  echo("at waiter::wait_for_char_to_finish is " @ % pass_char_data_locally);

  % pass_char_data_locally.powerup_buy_time = 0;


  if ($tut_yes_is_active == 1) {
   $toggle_off_fade_out_one_and_part_two_in = 0;
   isolater_mask.fade_out_one_and_part_two_in();
   $tutorial_activate_cook_sequence = 5;
  }

  if ($spawn_special_character == 1 & $prechosen_seat_num_for_special_char == % pass_char_data_locally.seat_num) {
   $special_char_already_used = 1;
  }
 }
}

function waiter::wait_for_char_to_pay( % this, % pass_char_data_locally) {
  display_stars2.text = "#" @ % pass_char_data_locally @ "#";
  echo("%pass_char_data_locally = " @ % pass_char_data_locally);
  //06-07-2013 Switched all remaining $current_char 's to %pass_char_data_locally as it is better
  //06-07-2013 NOTE: In console, it will seem as if the previous function was correct with $current_char, this is because of a lag delay between choosing chars
  //06-07-2013 - so whatever char you're on will be displayed as $current_char. Isolate_char is correct, believe me. ALSO %this.#anything refers to WAITER in here,
  //06-07-2013 - not character, which is why there are a lot of blank echoes, the chars are hitting their dynamic fields correctly after all.
  //05-13-2013 adjust $char_number to $globalize_new_precorded_char_number
  if ( % pass_char_data_locally.is_despawned == 1) {
   //edit 01-13-2014 attempting tut_char 1 exception for star timers across all levels
   % pass_char_data_locally.star_timer = 0;
   //log chosen seat occupied data
   $chosen_seat.occupied = 0;
  }
  if ( % pass_char_data_locally.is_despawned != 1) {
   if ($char1_tutorial_over_with == 0) {
    $special_case_clause_to_prevent_char1_reteleport_animation_temporarily = 1;
   }

   /* EDIT 05-09-2013 */
   % pass_char_data_locally.detected_incoming_drink = 0; % pass_char_data_locally.lock_incoming_drink = 0;

   echo("\c2 !!!HITTING--- SPECIAL CASE 37: $current_char = " @ $current_char @ " vs $isolate at " @ % pass_char_data_locally);
   $drink_being_sent_back = % pass_char_data_locally.drink_accepted_is;
   /* Special Case 37 */
   /* if another char is clicked, isolate_char becomes other character since it's based on $current_char, need new local/field/or lock off */
   /* 12-27-2012 Disabled statement below as it looks to interfere with multiple customers being served */
   /////////////////////////////////////////
   //this needs to be zero in special cases where this cycle isnt complete yet and you click aanother char
   ////////////////////////////////////////
   /* 12-27-2012 Adding extra global $logged_char_num_at_pay in case trying to serve another char while another char is tipping and flips waiting_for_char to 2 instead of wanted 0 */
   $logged_char_num_at_pay = % pass_char_data_locally.seat_num;
   //05-13-2013 Found Elusive Error here with echo despawn, switching from $current_char to %pass_char_data_locally
   //NOTE : This is for Approval-based-deteleportation
   //("obj_teleport" @ $current_char.seat_num).setAnimation(teleportAnimation2);
   ("obj_teleport" @ % pass_char_data_locally.seat_num).setAnimation(teleportAnimation2); 
   % this.in_cell = 4;
   //edit 06-15-2014 new identifier for beginning of rounds when nothings been established for spawn/despawn
   % pass_char_data_locally.has_been_spawned = 0; 
   % pass_char_data_locally.setAnimation(empty_char_spaceAnimation);
   //edit 04-12-2014 adding hearts info
   % find_hearts = "hearts_" @ % pass_char_data_locally.seat_num; 
   % find_hearts.setBlendAlpha(0);
   $hearts_scheduled[ % pass_char_data_locally.seat_num] = 0;


   //edit 08-20-2013 Adding clause to empty out any freeze data
   % pass_char_data_locally.freeze = 0; 
   % pass_char_data_locally.powerup_buy_time = 0;
   //edit 05-20-2013 star_timer resetter
   % pass_char_data_locally.star_timer = 0;
   $char1_tutorial_over_with = 1; 
   % pass_char_data_locally.is_despawned = 1; 
   % pass_char_data_locally.disabled = 1;
   echo("at waiter::wait_for_char_to_pay is " @ % pass_char_data_locally @ " vs legacy current char @ " @ $current_char);
   //Erase customer's thoughts and thought bubble upon leaving
   /* edit 12-26-2012 : thought bubble called was thought1 only, not based on concat numeric */
   /* edit 12-26-2012b : switched to $isolate_char since $current_char was not fully accurate, here's to hoping*/
   ("thought" @ % pass_char_data_locally.seat_num).setAnimation(thought_bubble_emptyAnimation);
   ("thought" @ % pass_char_data_locally.seat_num).AutoRotation = 0;
   //if they're still here-
   ("p_want"  @ % pass_char_data_locally.seat_num).setImageMap(want_emptyImageMap);
   ("p_wantb" @ % pass_char_data_locally.seat_num).setImageMap(want_emptyImageMap);

   $reteleport = 1;
   $p1_present = 0; 
   % this_coin_tip = "empty_coin" @ % pass_char_data_locally.seat_num; 
   % this_dirty_extra_cup = "dirty_extra_cup" @ % pass_char_data_locally.seat_num;
   $char_number = % pass_char_data_locally.seat_num; % localized_char_number = % pass_char_data_locally.seat_num;
   display_stars.text = % pass_char_data_locally.star_points;
   if ( % pass_char_data_locally.star_points > 0 & % pass_char_data_locally.star_points < 5) { 
   % this_coin_tip.setSize(1.758, 6.934); 
   % this_coin_tip.setAnimation(coin_flipAnimation); 
   % this_coin_tip.is_present = 1;
   % dirty_glow = "dirty_glow" @ % localized_char_number; 
   % dirty_glow.setAnimation(fx_mana_glow2Animation);
   }
   if ( % pass_char_data_locally.star_points == 0) { 
   % this_coin_tip.is_present = 0;
   }
   if ( % pass_char_data_locally.star_points == 999) {
   }
   //scripted sequence for tutorial only
   if ($tut_yes_is_active == 1 & $activate_tutorial_cointip == 1 & $tut_very_last_part != 1) {
    //disable fading via cook sequences
    $tutorial_activate_cook_sequence = 9999;
    $tutorial_activate_tip_sequence = 2;
    isolater_mask.fade_in_part_two();
   }
   if ($tut_yes_is_active == 1 & $tut_very_last_part == 1) {
    tutorial_text_block.text = $tut_14;
    tutorial_text_block.setPositionX(105);
    tutorial_text_block.setPositionY(7);
    tutorial_text_block.setBlendAlpha(1);
    tutorial_bar.setPositionX(100);
    tutorial_bar.setPositionY(7);
    //echo(tutorial_bar.setPositionY());
    $tut_very_last_part_completely = 1;
   }

   echo("DIRTY GLOW "
    @ % dirty_glow);
   if ($mute_soundfx != 1) {
    alxPlay(coin_tip_sound);
   }
   /* 12-28-2012 changed to $this_coin_tip from ("empty_coin" @ $char_number) in hopes of better accuracy and no more cascading coint_tip failures */
   % this_coin_tip.collected = 0;

   % present_coin_x = % this_coin_tip.getPositionX(); 
   % present_coin_y = ( % this_coin_tip.getPositionY()) - 6; 
   % present_coin_y2 = ( % this_coin_tip.getPositionY()) - 9; 
   % this_dirty_extra_cup.setSize(1.953, 4.102); 
   % this_dirty_extra_cup.setAnimation(dirty_cup_testAnimation); 
   % this_dirty_extra_cup.active = 1; 
   % this_dirty_extra_cup.setBlendAlpha(1);
   ("pointer_tip" @ % localized_char_number).setPositionX( % present_coin_x);
   ("pointer_tip" @ % localized_char_number).setPositionY( % present_coin_y);
   ("pointer_tip" @ % localized_char_number).setAnimation(icon_pointer_badAnimation);
   echo("\c2 POINTER TIP RESET AT END FOR CHAR" @ % localized_char_number);
   ("smellyb" @ % localized_char_number).setPositionX( % present_coin_x);
   ("smellyb" @ % localized_char_number).setPositionY( % present_coin_y2);
   ("smellyb" @ % localized_char_number).setAnimation(smellAnimation);
   echo("\c2 POINTER TIP RESET AT END FOR CHAR" @ $char_number);

   //edit 02-02-2013 adding extra redundancy to eliminate red exclame by smelly dish collect
   ("icon_exclame" @ $char_number).setAnimation(empty_char_spaceAnimation);
   //and just incase operations are too quick and global is overwritten
   ("icon_exclame" @ % localized_char_number).setAnimation(empty_char_spaceAnimation);
   $waiter_untoggle = 0; 
   % this.is_serving = 0;
   echo("end of waiter::wait_for_char_to_pay is empty_char_space" @ % pass_char_data_locally.seat_num); % pass_char_data_locally.powerup_buy_time = 0;
   //edit 01-24-2014 make it so you can serve char later again (this prevented the same char from being served 2+ times if approved)
   % pass_char_data_locally.already_served = 0;

   //edit 03-02-2014 this prevents long empty delays caused by keep_me_gone_longer function
   % check_if_everyone_is_gone = 0 + empty_char_space1.is_despawned + empty_char_space2.is_despawned + empty_char_space3.is_despawned + empty_char_space4.is_despawned;
   echo("Checking if everyone is gone: " @ % check_if_everyone_is_gone @ "/4 are gone.");
   if ( % check_if_everyone_is_gone == 4 & % pass_char_data_locally.seat_num != $clocked_char) {
    echo("Everyone Is Gone And Character That Left Is Not The Scheduled Char...");
    echo("...So Unlocking Everyone For Spawnability.");
    //keep_me_gone_longer all get stuck too in scenario A preventing spawn
    empty_char_space1.keep_me_gone_longer = 0;
    empty_char_space2.keep_me_gone_longer = 0;
    empty_char_space3.keep_me_gone_longer = 0;
    empty_char_space4.keep_me_gone_longer = 0;
    //toggles all get stuck too in scenario B preventing spawn
    //either way, the only problem is when everyone's gone, so this corrects it
    $toggle_char1_spawn = 0;
    $toggle_char2_spawn = 0;
    $toggle_char3_spawn = 0;
    $toggle_char4_spawn = 0;
   }
   if ( % check_if_everyone_is_gone == 4 & % pass_char_data_locally.seat_num == $clocked_char) {
    echo("Everyone Is Gone And Character That Left Is The Same As The Scheduled Char");
    echo("...So Unlocking Everyone But Current Char For Spawnability.");

    if ( % pass_char_data_locally.seat_num == 1) {
     empty_char_space1.keep_me_gone_longer = 1;
     empty_char_space2.keep_me_gone_longer = 0;
     empty_char_space3.keep_me_gone_longer = 0;
     empty_char_space4.keep_me_gone_longer = 0;
     $toggle_char1_spawn = 1;
     $toggle_char2_spawn = 0;
     $toggle_char3_spawn = 0;
     $toggle_char4_spawn = 0;
    }
    if ( % pass_char_data_locally.seat_num == 2) {
     empty_char_space1.keep_me_gone_longer = 0;
     empty_char_space2.keep_me_gone_longer = 1;
     empty_char_space3.keep_me_gone_longer = 0;
     empty_char_space4.keep_me_gone_longer = 0;
     $toggle_char1_spawn = 0;
     $toggle_char2_spawn = 1;
     $toggle_char3_spawn = 0;
     $toggle_char4_spawn = 0;
    }
    if ( % pass_char_data_locally.seat_num == 3) {
     empty_char_space1.keep_me_gone_longer = 0;
     empty_char_space2.keep_me_gone_longer = 0;
     empty_char_space3.keep_me_gone_longer = 1;
     empty_char_space4.keep_me_gone_longer = 0;
     $toggle_char1_spawn = 0;
     $toggle_char2_spawn = 0;
     $toggle_char3_spawn = 1;
     $toggle_char4_spawn = 0;
    }
    if ( % pass_char_data_locally.seat_num == 4) {
     empty_char_space1.keep_me_gone_longer = 0;
     empty_char_space2.keep_me_gone_longer = 0;
     empty_char_space3.keep_me_gone_longer = 0;
     empty_char_space4.keep_me_gone_longer = 1;
     $toggle_char1_spawn = 0;
     $toggle_char2_spawn = 0;
     $toggle_char3_spawn = 0;
     $toggle_char4_spawn = 1;
    }

   }

  }
 }
 //edit 03-19-2015 added new red x
function make_red_x() {
 if ($tut_yes_is_active != 1) {
  echo("test777 make red");
  echo($current_char);
  echo($red_x_position_global @ " " @ $red_y_position_global); 
  % red_pos_x = $current_char.getPositionX(); 
  % red_pos_y = $current_char.getPositionY();
  red_x2.setBlendAlpha(1);
  //edit 03-21-2015 reverted from %red_pos_x/y because not accurate enough
  red_x2.setPositionX($red_x_position_global);
  red_x2.setPositionY($red_y_position_global);
  red_x2.setAnimation(red_xAnimation);
  if ($make_test_red_x == 1) {
   test_red_x.setAnimation(red_xAnimation);
  }
  $need_a_red_x = 0;
  $red_x_used_already = 0;
 }
}