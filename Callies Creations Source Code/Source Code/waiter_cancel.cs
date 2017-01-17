// ***************************************************************************************
// File Name:   waiter_cancel.cs
// Author:      Roger Campbell 
// Purpose:     To cancel waiter actions at any point during gameplay
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function drink_cancel1::onAdd( % this) { 
 % this.setUseMouseEvents(true);
}

function drink_cancel1::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) { 
 % this.setFrame(1);
 $toggle_toss_cursor = 1;
 set_cursor_to_toss();
}

function drink_cancel1::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) { 
 % this.setFrame(0);
 $toggle_toss_cursor = 0;
 if ($toggle_serve_cursor == 1) {
  if ($toggle_appetizer_cursor == 0) {
   set_cursor_to_serve();
  }
  if ($toggle_appetizer_cursor == 1) {
   set_cursor_to_appetizer1();
  }
  if ($toggle_appetizer_cursor == 2) {
   set_cursor_to_appetizer2();
  }
 }
 if ($toggle_dirty_cursor == 1) {
  set_cursor_to_dirty();
 }
 if ($toggle_dirty_cursor != 1 & $toggle_dirty_cursor != 1) {
  set_cursor_to_default();
 }
}

function drink_cancel1::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($mute_soundfx != 1) {
   alxPlay(clank);
  }
  comptroller.schedule(200, "double_clank", 0);
  drink_cancel1.setPositionX(159.313);
  drink_cancel1.setPositionY(25.215);
  $toggle_toss_cursor = 0;
  $toggle_serve_cursor = 0;
  $toggle_dirty_cursor = 0;
  $toggle_appetizer_cursor = 0;
  set_cursor_to_default();
  $appetizer1_used = 0;
  $appetizer2_used = 0;
  $toggle_no_drink_switch_til_dropped_off = 0;
  if ($tut_yes_is_active == 1 & $tut_very_last_part_completely != 1) {
   if ($tut_go_to_fruits != 1) {
    $tut_new_revised = 1;
   }
  }
  if ($activate_tut_cointip_portion == 3 & $tut_yes_is_active == 1 & $tut_very_last_part_completely != 1) {

   $tutorial_activate_cook_sequence = 9999;
   $tutorial_activate_tip_sequence = 4;
   $toggle_off_fade_out_one_and_part_two_in = 0;
   $activate_tut_cointip_portion = 4;
   $tutorial_activate_tip_sequence = 5;
   $tut_make_reclicking_drink_out_impossible = 0;
   isolater_mask.fade_out_one_and_part_two_in();

   $game_has_started_for_clock = 1;
   $toggle_initial_spawner_via_clock = 0;
   $game_clock_number = 0;
   tut_lock_char1_in_alone_again();
   appetizer2.schedule(250, "tut_lock_char1_in_alone_again", 0);

   $tutorial_activate_extra_sequence = 2;
   $toggle_off_fade_out_one_and_part_two_in = 0;
   isolater_mask.fade_out_one_and_part_two_in();
   $toggle_tut_appetizer = 1;
   $lock_down_retoggling_during_tutorial = 0;
   $tut_toggle_off_drink_out = 0;
   $disable_all_remaining_fruit_ui = 0;

  }

  if ($tut_very_last_part_completely == 1) {
   isolater_mask.do_final_tutorial_part();
  }

  if ($toggle_sodajerk_data_transfer != 1) {
   //05-14-2013 New unbreakable statement to prove whether drink is available or not
   % check_drink_out_status = "drink_out" @ $selected_drink;
   if ( % check_drink_out_status.up_status == 1) {

    if ($waiter_is_cancelable == 1) {
     $waiter_canceled = 1;
     $no_clicking_waiter = 0;
     $this_waiter.BlendColor = "1 1 1 1";
     $wait_for_end_waiter_active = 1;
     $this_waiter.setAnimation(waiter_idle2Animation);
     $this_waiter.setSize(17.188, 22.363);
     $current_way_point = way_point @ $this_waiter.num;
     $waiter_way_point_x = $current_way_point.getPositionX();
     $waiter_way_point_y = $current_way_point.getPositionY();
     $this_waiter.setPositionX($waiter_way_point_x);
     $this_waiter.setPositionY($waiter_way_point_y);

     $waiter_is_informed = 0;
     $waiter_init = 0;
     $customer_clicked = 0;
     $waiting_for_char = 0;
     $wait_for_end_waiter_active = 0;
    }

    % drink_being_sent_back = $selected_drink; % drink_being_sent_back = $selected_drink;


    //edit 01-06-2013 declare sodajerk attributes for drink_in
    % set_sodajerk_cleaner = "sodajerk" @ % drink_being_sent_back; 
	% set_sodajerk_cleaner.should_wash_dish = 1;

    //switched drink_being_sent_back from $ to % and redclared what it is. delete all of above clauses to undo and swith all % below to $
    $active_to_clean_drink = "drink_in" @ % drink_being_sent_back;
    $active_to_clean_drink.schedule(1, "wash_cup", 0);

    $clear_out_legacy_drink = "drink_out" @ % drink_being_sent_back;
    $drink_out_removal = "drink_out" @ % drink_being_sent_back;
    //remove drink_out
    $drink_out_removal.setAnimation(drink_idleAnimation);
    $drink_out_removal.BlendColor = "1 1 1 1";
    //05-14-2013 Changing up_status
    $drink_out_removal.up_status = 0; % identify_this_sodajerk_number = % drink_being_sent_back; % declare_drink_out_bottom_icon = ( % identify_this_sodajerk_number + 10);
    //declare name of containers for icon images of outgoing drink
    % drink_out_icon_name_a = ("drink_ident" @ % identify_this_sodajerk_number); 
	% drink_out_icon_name_b = ("drink_ident" @ % declare_drink_out_bottom_icon); 
	% drink_out_icon_name_a.setImageMap(empty_coinImageMap); 
	% drink_out_icon_name_b.setImageMap(empty_coinImageMap); 
	% drink_out_icon_name_a.setFrame(0); 
	% drink_out_icon_name_b.setFrame(0); 
	% pointer_cook_name = "pointer_cook" @ % identify_this_sodajerk_number; 
	% pointer_cook_name.setAnimation(empty_char_spaceAnimation);
    //edit 06-15-2013 adding more mana glow lop off
    % mana_glow = ("mana_glow" @ % identify_this_sodajerk_number); 
	% mana_glow.setAnimation(empty_char_spaceAnimation);
    //-----------------------------------------------------------------//
    //%declare_char_for_backtracking_algorithm.deliver_drink_info
    $drink_up_for_cleaning = % drink_being_sent_back;
    $give_to_sodajerk = "sodajerk" @ $drink_up_for_cleaning;
    $give_to_sodajerk.drink_up_for_cleaning = $drink_up_for_cleaning;
    echo("\c2 DRINK being sent back is " @ $drink_up_for_cleaning);
    //**********************************************************************************

    $drink_out_removal.active = 0;
    $all_drinks_shutdown_temporarily = 0;
    $drink_was_clicked = 0;
    $waiter_currently_collecting_tip_please_wait = 0;
    $drink_out_removal.cancelled = 1;
    drink_cancel1.setPositionX(999);
    $activation_of_movementB = 0;

    $active_to_clean_drink.dirty = 1;

    //edit 05-14-2013 Making new tangible up_status
    //edit 02-12-2014 adding check off all combined busy and clogged statuses
    $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
    display_occupied.text = $calculate_all_sodajerks_business;
    //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
    if ($calculate_all_sodajerks_business > 4) {
     $calculate_all_sodajerks_business = 4;
     display_occupied.text = $calculate_all_sodajerks_business;
    }

   }
   //edit 03-16-2015
   $drink_out_toggled = 0;
  }

  if ($toggle_sodajerk_data_transfer == 1) {
   waiter1.send_back_drink();
   $toggle_sodajerk_data_transfer = 0;
  }

 }
}

function waiter_cancel::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {

 }
}

function comptroller::double_clank() {
 if ($mute_soundfx != 1) {
  alxPlay(clank);
 }
}