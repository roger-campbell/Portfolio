// ***************************************************************************************
// File Name:   char_button.cs
// Author:      Roger Campbell 
// Purpose:     All character interactions in game activated by clicking characters 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function char_button::onAdd( % this) { % this.setUseMouseEvents(true);
 $max_number_of_seats = 4;
 $p1_active = 0;
 $reteleport = 0;
 $p1_present = 1;
 $find_image_name1 = want_emptyImageMap;
 $find_image_name2 = want_emptyImageMap;
 $customer_clicked = 0;
 $char_name = "empty_char_space1";
 $char_name_post_spawn = "empty_char_space"
 @ $random_seat_num;
 $disable_all_of_this = 0;
 $disable_char_until_reteleport = 0;
 $start_random_character_spawning = 0;
 empty_char_space1.occupied = 1;
 $declare_incoming_char1 = 0;
 $declare_incoming_char2 = 0;
 $declare_incoming_char3 = 0;
 $declare_incoming_char4 = 0;
 $reset_randomers = 0;
 $char_base_num = 1;
 $char_temp_slot1 = "name";
 $char_temp_slot2 = "name";
 $char_temp_slot3 = "name";
 $char_temp_slot4 = "name";
 $stop_redundant_schedules = 0;
 $char_ticker = 0;
 $empty_char_info = "empty_char_space";
 $empty_char1_info = "empty_char_space1";
 $empty_char2_info = "empty_char_space2";
 $char1_tutorial_over_with = 0;
 $minimum_number_of_seats = 2;
 $stop_reinitializing_this_char1_specific_function = 0;
 $all_tables_are_dirty = 0;
 $start_new_rapid_respawner = 1;
 $identify_the_scheduled_char = "name_not_identified";
 $pause_all_chars = 0;
 $random_customer_num = 0;
 $random_seat_num = 1;
}

function char_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.BlendColor = "1 1 0 1";
 }
}

function char_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) { % this.BlendColor = "1 1 1 1";
 }
}


function char_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {

 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($THE_GAME_IS_PAUSED != 1) {
   //TROPHY: Speedster Order
   $deactivate_speedster_order_taker_trophy = 0;

   //TROPHY: half-way around the world
   if ( % this.is_despawned == 0 & $world_numeral == 5 & $round_numeral == 1 & $end_trophy_trophy4 != 1) {
    $root_trophy_identfier = "trophy4";
    win_this_trophy();
    $end_trophy_trophy4 = 1;
   }
   //TROPHY: round trip
   if ( % this.is_despawned == 0 & $world_numeral == 10 & $round_numeral == 1 & $end_trophy_trophy5 != 1) {
    $root_trophy_identfier = "trophy5";
    win_this_trophy();
    $end_trophy_trophy5 = 1;
   }

   //TROPHY: 20 Best Bites
   if ( % this.is_despawned == 0 & $world_numeral == 10 & $round_numeral >= 1 & $appetizer1_counted_for_trophy == 1 & $appetizer2_counted_for_trophy == 1 & $trophy_toggle_off_ribbon6 != 1) {
    $root_trophy_identfier = "ribbon6";
    win_this_trophy();
    $trophy_toggle_off_ribbon6 = 1;
   }

   if ( % this.is_despawned == 0 & $tut_yes_is_active != 1 & $initialize_bonus_portals_to_appear_random == 1) {
    //register world and level and pass it through schedules to determine if they are scheduling on correct level
    //note: locals seem to get transposed down one, so every next one equals the one before
    % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;

    //Flying coin custom schedules
    if ($round_numeral == 1) {
     $flying_coin2_active = 1;
     $fly_sched_01 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_02 = flying_coin.schedule(115000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_03 = flying_coin2.schedule(115000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_04 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_05 = flying_coin.schedule(320000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 2) {
     $flying_coin2_active = 1;
     $fly_sched_06 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_07 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_08 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_09 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_10 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 3) {
     $flying_coin2_active = 1;
     $fly_sched_11 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_12 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_13 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_14 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_15 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_16 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 4) {
     $flying_coin2_active = 1;
     $fly_sched_17 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_18 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_19 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_20 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_21 = flying_coin.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_22 = flying_coin2.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_23 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_24 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 5) {
     $flying_coin2_active = 1;
     $fly_sched_25 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_26 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_27 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_28 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_29 = flying_coin.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_30 = flying_coin2.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_31 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_32 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 6) {
     $flying_coin2_active = 1;
     $fly_sched_33 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_34 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_35 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_36 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_37 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_38 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 7) {
     $flying_coin2_active = 1;
     $fly_sched_39 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_40 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_41 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_42 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_43 = flying_coin.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_44 = flying_coin2.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_45 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_46 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 8) {
     $flying_coin2_active = 1;
     $fly_sched_47 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_48 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_49 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_50 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_51 = flying_coin.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_52 = flying_coin2.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_53 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_54 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 9) {
     $flying_coin2_active = 1;
     $fly_sched_55 = flying_coin.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_56 = flying_coin2.schedule(68000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_57 = flying_coin.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_58 = flying_coin2.schedule(120000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_59 = flying_coin.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_60 = flying_coin2.schedule(180000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_61 = flying_coin.schedule(220000, "fly", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $fly_sched_62 = flying_coin.schedule(320000, "fly_back", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($round_numeral == 10) {
     //coin storm			
    }

    bonus_portal1.schedule(29400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    bonus_portal1.schedule(30000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //note- this ends all portals, it just needed to be objected-oriented so I picked bonus_portal1
    bonus_portal1.schedule(35000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    if ($world_numeral == 1 & $round_numeral != 1) {
     $bonus_sched_01 = bonus_portal2.schedule(34400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_02 = bonus_portal2.schedule(35000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_03 = bonus_portal1.schedule(40000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

     $bonus_sched_04 = bonus_portal4.schedule(51400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_05 = bonus_portal4.schedule(52000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_06 = bonus_portal1.schedule(57000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    if ($world_numeral > 1) {
     $bonus_sched_07 = bonus_portal2.schedule(34400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_08 = bonus_portal2.schedule(35000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_09 = bonus_portal1.schedule(40000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

     $bonus_sched_10 = bonus_portal4.schedule(51400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_11 = bonus_portal4.schedule(52000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $bonus_sched_12 = bonus_portal1.schedule(57000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }

    //triple play
    $bonus_sched_13 = bonus_portal1.schedule(59400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_14 = bonus_portal1.schedule(60000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_15 = bonus_portal1.schedule(65000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_16 = bonus_portal2.schedule(60400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_17 = bonus_portal2.schedule(61000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_18 = bonus_portal1.schedule(66000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_19 = bonus_portal3.schedule(61400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_20 = bonus_portal3.schedule(62000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_21 = bonus_portal1.schedule(67000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //end triple play

    $bonus_sched_22 = bonus_portal4.schedule(75400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_23 = bonus_portal4.schedule(76000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_24 = bonus_portal1.schedule(81000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_25 = bonus_portal2.schedule(89400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_26 = bonus_portal2.schedule(90000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_27 = bonus_portal1.schedule(95000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    //double play
    $bonus_sched_28 = bonus_portal3.schedule(108400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_29 = bonus_portal3.schedule(109000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_30 = bonus_portal1.schedule(114000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_31 = bonus_portal4.schedule(109400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_32 = bonus_portal4.schedule(110000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_33 = bonus_portal1.schedule(115000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //end double play

    $bonus_sched_34 = bonus_portal2.schedule(116400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_35 = bonus_portal2.schedule(117000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_36 = bonus_portal2.schedule(122000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_37 = bonus_portal1.schedule(134400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_38 = bonus_portal1.schedule(135000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_39 = bonus_portal1.schedule(140000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    //triple play
    $bonus_sched_40 = bonus_portal4.schedule(149400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_41 = bonus_portal4.schedule(150000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_42 = bonus_portal1.schedule(155000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_43 = bonus_portal2.schedule(150400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_44 = bonus_portal2.schedule(151000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_45 = bonus_portal1.schedule(156000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_46 = bonus_portal1.schedule(151400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_47 = bonus_portal1.schedule(152000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_48 = bonus_portal1.schedule(157000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //end triple play

    $bonus_sched_49 = bonus_portal3.schedule(169400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_50 = bonus_portal3.schedule(170000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_51 = bonus_portal1.schedule(175000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    //triple play slow
    $bonus_sched_52 = bonus_portal2.schedule(189400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_53 = bonus_portal2.schedule(190000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_54 = bonus_portal1.schedule(195000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_55 = bonus_portal3.schedule(191400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_56 = bonus_portal3.schedule(192000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_57 = bonus_portal1.schedule(197000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_58 = bonus_portal4.schedule(194400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_59 = bonus_portal4.schedule(195000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_60 = bonus_portal1.schedule(200000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //end triple play slow

    $bonus_sched_61 = bonus_portal1.schedule(214400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_62 = bonus_portal1.schedule(215000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_63 = bonus_portal1.schedule(220000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_64 = bonus_portal2.schedule(224400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_65 = bonus_portal2.schedule(225000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_66 = bonus_portal1.schedule(230000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_67 = bonus_portal3.schedule(234400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_68 = bonus_portal3.schedule(235000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_69 = bonus_portal1.schedule(240000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    //double play
    $bonus_sched_70 = bonus_portal4.schedule(244400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_71 = bonus_portal4.schedule(245000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_72 = bonus_portal1.schedule(250000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_73 = bonus_portal1.schedule(245400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_74 = bonus_portal1.schedule(246000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_75 = bonus_portal1.schedule(251000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    //end double play

    $bonus_sched_76 = bonus_portal4.schedule(289400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_77 = bonus_portal4.schedule(290000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_78 = bonus_portal1.schedule(295000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $bonus_sched_79 = bonus_portal3.schedule(334400, "bonus_portal_spawn", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_80 = bonus_portal3.schedule(335000, "bonus_portal_repeat", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    $bonus_sched_81 = bonus_portal1.schedule(340000, "bonus_extra_portal_end_all", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

    $initialize_bonus_portals_to_appear_random = 0;
   }

   //tutorial mode if 'YES' selected only
   if ( % this.is_despawned == 0 & $tut_yes_is_active == 1) {
    hearts_1.setBlendAlpha(1);
   }

   if ($end_previous_non_new_tut_bits != 1) {
    if ($tut_yes_is_active == 1 & $lock_down_isolater_mask_part_i_to_ii != 1 & $disable_all_clicks_of_chars_via_tutorial != 1 & $tut_coin_tip_override != 1) {
     callie.point_out();
     isolater_mask.fade_out_one_and_part_two_in();
     $lock_down_isolater_mask_part_i_to_ii = 1;
     $lock_down_retoggling_during_tutorial = 1;
    }

    //tutorial advanced fruit choices
    if ($tut_char_fruit_choices == 2) {
     $disable_all_clicks_of_chars_via_tutorial = 0;
     $until_tut_char_is_activated_dont_do_fruits = 0;
     $tutorial_activate_extra_sequence = 9999;
     $toggle_off_fade_out_one_and_part_two_in = 0;
     $activate_tut_cointip_portion = 9999;
     $tutorial_activate_tip_sequence = 9999;
     isolater_mask.fade_out_one_and_part_two_in();
     $cease_masking_of_dial = 1;
     isolater_mask::turn_fruit_dial_to_normal();
     $lock_down_retoggling_during_tutorial = 1;
     $tut_toggle_off_cook = 0; % this.needs_appetizer = 3;
     $tut_toggle_new_appetizer = 1;
    }
   }

   if ($end_previous_non_new_tut_bits == 1 & $tut_appetizer1_clicked == 1 & $tut_very_last_char_clicked != 1) {
    tutorial_text_block.text = $tut_13c;
    tutorial_text_block.setPositionY(0);
    tutorial_text_block.setPositionX(100);
    tutorial_bar.setPositionX(100);
    tutorial_bar.setPositionY(0);
    tutorial_clicker.setBlendAlpha(0);
    $tut_very_last_part = 1;
    $tut_very_last_char_clicked = 1;
   }

   if ( % this.is_despawned != 1 & $disable_all_clicks_of_chars_via_tutorial != 1) {
    callie.point_out();
    //07-25-2013 hail mary edit to try and fix clickability
    % this.clickable = 1;
    //05-11-2013 Signify a new world by clicking on char
    $world_ended = 0;

    //05-10-2013 Prevent all anger modes and deteleports from here on
    if ( % this.is_angry == 1) {
     echo("ANGER MODE ACTIVE");
    }

    % char_x = % this.getPositionX(); % char_y = % this.getPositionY();
    click_sonar.BlendColor = "1 1 1 0.4";
    click_sonar.setPositionX( % char_x);
    click_sonar.setPositionY( % char_y);
    click_sonar.setAnimation(click_faderAnimation);

    if ($drink_was_clicked == 1) { % this.detected_incoming_drink = 1;
     $drink_was_clicked = 0;
     $current_char.lock_incoming_drink = 1;
    }

    //edit 01-06-2013 special case for if waiter is delivering while you click another char so that char's icons can be displayed
    if ($current_waiter.is_serving == 1) {
     if ($mute_soundfx != 1) {
      alxPlay(nice_click);
     }
     echo("edge case 01-06-2013 waiter serving, pick another char's drink");
     //edit 01-24-2013 extra measure to identify whether or not wants are displayed or not
     % this.displaying_wants = 1; % this.schedule(0, "pick_drink", 0);
    }

    //edit 01-24-2014 added .already_served	to make sure char is not re-served if already approved to drink
    if ($current_waiter.is_serving != 1 & % this.already_served != 1) {
     //red warning x positioning
     % this_x = % this.getPositionX(); % this_y = % this.getPositionY(); % reset_pos_x = % this_x; % reset_pos_y = % this_y;
     //edit 03-18-2015 establishing global red_x position
     $red_x_position_global = % reset_pos_x;
     $red_y_position_global = % reset_pos_y;

     //CHECK FOR APPETIZER NEEDS

     //AGAINST---
     //IF YOU SERVE WRONG DRINK, RIGHT APPETIZER #1, THEN RECLICK WITH WRONG DRINK, NO APPETIZER	
     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer == 3 & $appetizer1_used != 1) {

      //pending it's actually correct
      echo("red_x1"); 
	  % this.approve_appetizer = 0;
      $appetizer1_used = 0;
      icon_what.setPositionX( % reset_pos_x);
      icon_what.setPositionY( % reset_pos_y);
      make_red_x();
      //edit 03-19-2015 test for red x being used
      $red_x_used_already = 1;

     }

     //IF YOU SERVE WRONG DRINK, RIGHT APPETIZER #2, THEN RECLICK WITH WRONG DRINK, NO APPETIZER					
     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer == 4 & $appetizer2_used != 1) {
      //pending it's actually correct
      echo("red_x2"); 
	  % this.approve_appetizer = 0;
      $appetizer2_used = 0;
      icon_what.setPositionX( % reset_pos_x);
      icon_what.setPositionY( % reset_pos_y);
      make_red_x();
      //edit 03-19-2015 test for red x being used
      $red_x_used_already = 1;
     }

     //IF YOU SERVE WRONG DRINK, AND APPETIZER #1, TO A CUSTOMER NOT WANTING APPETIZERS	
     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer <= 2 & $appetizer1_used == 0) {
      echo("red_x1B"); 
	  % this.approve_appetizer = 0;
      icon_what.setPositionX( % reset_pos_x);
      icon_what.setPositionY( % reset_pos_y);
      $extra_red_x_situation = 1;
      make_red_x();
     }

     //IF YOU SERVE WRONG DRINK, AND APPETIZER #2, TO A CUSTOMER NOT WANTING APPETIZERS						
     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer <= 2 & $appetizer2_used == 0) {
      echo("red_x2B"); 
	  % this.approve_appetizer = 0;
      icon_what.setPositionX( % reset_pos_x);
      icon_what.setPositionY( % reset_pos_y);
      $extra_red_x_situation = 2;
      make_red_x();
     }

     //FOR---
     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer <= 2 & $appetizer1_used != 1 & $appetizer2_used != 1) {
      //always correct
      % this.approve_appetizer = 1;
     }

     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer == 3 & $appetizer1_used == 1) {
      //pending it's actually correct
      % this.approve_appetizer = 1;
      $appetizer1_used = 0;
     }

     if ($toggle_cursor_is_serving == 1 & % this.needs_appetizer == 4 & $appetizer2_used == 1) {
      //pending it's actually correct
      % this.approve_appetizer = 1;
      $appetizer2_used = 0;
     }

     //IF APPETIZERS NOT USED AND NOT WANTED, ALLOW PASSAGE
     if ($toggle_cursor_is_serving == 1 & $appetizer1_used == 0 & $appetizer2_used == 0 & % this.wants_appetizer == 0) {
      //bypass appetizer
      % this.wants_appetizer = 1;
     }

     //for red x animation
     if ($toggle_cursor_is_serving == 1 & % this.wants_appetizer == 0) {

      if ($toggle_appetizer_cursor == 1) {
       echo("red_x3");
       icon_what.setPositionX( % reset_pos_x);
       icon_what.setPositionY( % reset_pos_y);
       //edit 03-19-2015 test for red x being used
       $red_x_used_already = 1;
      }

      if ($toggle_appetizer_cursor == 2) {
       echo("red_x4");
       icon_what.setPositionX( % reset_pos_x);
       icon_what.setPositionY( % reset_pos_y);
       //edit 03-19-2015 test for red x being used
       $red_x_used_already = 1;
      }

     }

     //edit 02-15-2014 $activate_char_from_drink_out added as final check for passes
     if ($activation_of_movementB == 1 & % this.is_despawned == 0 & $tutorial_options_finished == 1 & $activate_char_from_drink_out == 1 & % this.approve_appetizer == 1 & % this.wants_appetizer == 1) {
      //12-18-2013 fixes wrong char switch via $activation_of_movementB > identify_scheduled_char > $identify_the_scheduled_char > char #
      if ($tut_yes_is_active == 1 & $activate_tutorial_serve_char_sequence == 1) {
       monster_shake.setScenePause(false);
       $toggle_off_fade_out_one_and_part_two_in = 0;
       isolater_mask.fade_out_one_and_part_two_in();
       $tutorial_activate_cook_sequence = 4;
      }

      if ($mute_soundfx != 1) {
       alxPlay(nice_click);
      }

      % this.schedule(5540, "identify_scheduled_char", 0);
      $current_waiter.activation_of_movement = 2;
      waiter1.direct_pass_char = % this.seat_num;
      $current_waiter.start_waiter();
      $current_waiter.record_char_num = % this.seat_num;
      $current_waiter.directed_char = % this.seat_name;
      $current_waiter.pass_drink_info = $selected_drink;
      $current_waiter.pass_drink_nameA = $drink_out_selected1;
      $current_waiter.pass_drink_nameB = $drink_out_selected2;
      $activate_char_from_drink_out = 0;

     }

     if ( % this.is_despawned == 0 & $tutorial_options_finished == 1) {


      $disable_char_until_reteleport = % this.disabled;
      $char_name = % this.seat_name;
      $char_number = % this.seat_num;
      $current_char = % this.seat_name;
      $this_char_clickability = % this.clickable;
      
	  //special case: any time character is physically there (not despawned only) and clicked, they should not be disabled or unclickable
      if ( % this.is_despawned == 0) { % this.disabled = 0;
       $disable_char_until_reteleport = % this.disabled;
       $this_char_clickability = % this.clickable;
      }

      if ($disable_char_until_reteleport == 1 & $tutorial_options_finished == 1) {
       $disable_all_of_this = 1;
      }

      if ($tutorial_options_finished == 1 & $disable_char_until_reteleport == 0 & % this.clickable == 1 & % this.displaying_wants != 1) {
       /* FIVE CUSTOMERS SERVED AWARD */
       $find_chars_served += 1; % award_five = $find_chars_served;

       if ( % award_five == 5) {
        $root_trophy_identfier = "trophy3";
        win_this_trophy();
       }
	   
       if ($mute_soundfx != 1) {
        alxPlay(nice_click);
       } % this.schedule(0, "pick_drink", 0);
	   
       $char_name.BlendColor = "0 1 0 1";
       ("thought" @ % this.seat_num).setAnimation(thought_bubble2Animation);
       ("thought" @ % this.seat_num).AutoRotation = 50;
       $p1_active = 1;
       //despawn yellow exclamation
       % icon_exclame_num = % this.seat_num; 
	   % icon_exclame_name = "icon_exclame" @ % icon_exclame_num; 
	   % this_char_x = % this.getPositionX(); 
	   % this_char_y = % this.getPositionY(); 
	   % char_reset_pos_x = % this_char_x + 1; 
	   % char_reset_pos_y = % this_char_y - 10; 
	   % icon_exclame_name.setPositionX( % char_reset_pos_x); 
	   % icon_exclame_name.setPositionY( % char_reset_pos_y); 
	   % icon_exclame_name.setAnimation(empty_char_spaceAnimation); 
	   % icon_exclame_name.setPositionX( % char_reset_pos_x); 
	   % thought_reset_pos_xb = % this_char_x - 2;
       ("thought" @ % this.seat_num).setPositionX( % thought_reset_pos_xb);
       ("thought" @ % this.seat_num).setPositionY( % char_reset_pos_y);
	   
       //exception 12-22-2013 for char 4 thought and p_wants moving down 1% due to hitting ceiling
       if ( % this.seat_num == 4) {
        $lcnn1_echo_test = % char_reset_pos_y;
        $lcnn2_echo_test = $p_reset_pos_y1; 
		% reposition_bubble_4 = -31.597; 
		% reposition_thoughts_4 = -31.597;
        thought4.setPositionY( % reposition_bubble_4);
        p_want4.setPositionY( % reposition_thoughts_4);
        p_wantb4.setPositionY( % reposition_thoughts_4);
       }
       //edit 01-24-2013 extra measure to identify whether or not pwants are displayed or not
       % this.displaying_wants = 1;

      }

      if ($disable_char_until_reteleport == 0 & % this.is_despawned == 0 & $tutorial_options_finished == 1) {
       echo("Entering drink_out disabler via char");
       if ($mute_soundfx != 1) {
        alxPlay(nice_click);
       }
       //delete drink_out images
       % convert_actual_drink_frame_b = $selected_drink + 10;
       $drink_out_actual_drink = "drink_out" @ $selected_drink; 
	   % drink_out_actual_frame_a = "drink_ident" @ $selected_drink; 
	   % drink_out_actual_frame_b = "drink_ident" @ % convert_actual_drink_frame_b; 
	   % drink_out_actual_frame_a.setImageMap(want_emptyImageMap); 
	   % drink_out_actual_frame_b.setImageMap(want_emptyImageMap);
       $drink_out_actual_drink.setAnimation(drink_idleAnimation); 
	   % mana_glow = "mana_glow" @ $selected_drink; % mana_glow.setAnimation(empty_char_spaceAnimation);
       $customer_clicked = 1;
       $waiter_untoggle = 1;
       $activation_of_movement = 1;
       echo("\c2 $activation_of_movement = " @ $activation_of_movement); 
	   % this.drink_accepted_is = $selected_drink;
       $cook_is_done = 0;
       $the_selected_waiter_is.BlendColor = "1 1 1 1";
       //despawn icon pointer selects for everything related
       icon_waiter_select.setAnimation(empty_char_spaceAnimation);
       $drink_out_despawner_name = "pointer_cook" @ $selected_drink;
       $drink_out_despawner_name.setAnimation(empty_char_spaceAnimation);
       $drink_out_actual_drink.BlendColor = "1 1 1 1";
       //legacy
       $waiter_is_cancelable = 0;
       $drink_out_toggled = 0;
       $drink_out_actual_drink.active = 0;
       //edit 05-14-2013 Making new tangible up_status
       $drink_out_actual_drink.up_status = 0;
       //edit 02-12-2014 adding check off all combined busy and clogged statuses
       $calculate_all_sodajerks_business = sodajerk1.is_blending + sodajerk2.is_blending + sodajerk3.is_blending + sodajerk4.is_blending + drink_out1.up_status + drink_out2.up_status + drink_out3.up_status + drink_out4.up_status + $everyone_washing;
       display_occupied.text = $calculate_all_sodajerks_business;
       //edit 02-12-2014 adding exception for if it goes over 4, to go back to 4 so it doesn't screw up
       if ($calculate_all_sodajerks_business > 4) {
        $calculate_all_sodajerks_business = 4;
        display_occupied.text = $calculate_all_sodajerks_business;
       }
      }

      if ($tutorial_options_finished == 1) {
       if ($mute_soundfx != 1) {
        alxPlay(nice_click);
       }
       //recording drink wants to object lvl
       $drink1_num = % this.thirst_p1;
       $drink2_num = % this.thirst_p2;
       $more_accurate_frame_finder1 = % this.thirst_frame_p1;
       $more_accurate_frame_finder2 = % this.thirst_frame_p2;
      }
     }
    }

    echo("\c2 *************OFFICIAL END OF MOUSEDOWN ON CHAR******************************");

   }
  }
 }
}



function char_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-19-2015
  $red_x_used_already = 0;
  if ($THE_GAME_IS_PAUSED != 1) {
   $deactivate_speedster_order_taker_trophy = 1;
   if ($tut_yes_is_active == 0) {
    make_sure_fruits_are_enabled_after_tut();
   }
  }
 }
}


function char_button::identify_scheduled_char( % this) {
 //DON'T DISABLE ME! I CONTROL THE TRANSITION BETWEEN DRINKING AND APPROVAL FOR ALL CHARACTERS EVER, DISABLING ME WILL LOCK ALL CHARS IN DRINKING MODE WHEN THEY REACH IT
 $identify_the_scheduled_char = % this.seat_name;
 echo("function char_button::identify_scheduled_char @ char " @ $identify_the_scheduled_char);
}


function char_button::check_anger_for_stalls( % this) {
 echo("\c2 CHECKING ANGER FOR STALLS ::: This should be 0 vs " @ % this.is_angry @ " @ char " @ % this.seat_name);
}

function char_button::set_anger_time( % this) {
 if ($timescale == 1 & $all_tables_are_dirty == 0) {

  if ($char1_occupied == 1) {
   echo("Initial timers for character DISABLED");
  }

  if ($char1_occupied == 0) {
   //do nothing for now
  }

  if ($timescale == 0) {
   //PAUSE GAME COMPLETELY!!!
  }

  //ONLY FOR CHAR 1 STARTING, NO ONE ELSE
  if ($timescale == 1) {
   //YOU ADJUSTED stop_redundant_schedules TO $stop_redundant_schedules IF ANYTHING IS WEIRD
   if ($timescale == 1 & $all_tables_are_dirty == 0) {
    echo("CHAR GET_ANGRY AND DETELEPORT SCHEDULED VIA PART A");
    //edit 01-29-2013 Added drink_requested = 0 here so it will always properly reset for pick_drink
    % this.seat_name.drink_requested = 0;
    //edit 01-30-2013 Added so deteleport adjust can reset here, preventative measure to keep adjust from looping
    % this.deteleport_adjust = 0;
    //06-08-2013 Adding reset clause for star timer upon spawn commands
    % this.seat_name.star_timer = 0;

    if ($lock_game_clock != 1) {
     $lock_game_clock = 1;
    }

   }

   echo("Initial timers for character activated");
   $stop_reinitializing_this_char1_specific_function = 1;
  }
 }
}

function char_button::start_game_clock( % this) {
 if ($end_the_clock != 1) {
  $game_clock_number += 100;
  $whole_round_clock += 100;
  spawn_time_checker.text = $game_clock_number;
 }
 % this.seat_name.schedule(100, "start_game_clock", 0);

 if ($game_has_started_for_clock == 1) {
  /* IGNITION ONLY CHAR1 SPAWN */
  if ($toggle_initial_spawner_via_clock != 1) {
   $points_you_have = 0;
   //make sure everything is cleared each ignition for each round or world!!
   empty_char_space1.accidental_deteleport_preventer = 0;
   empty_char_space2.accidental_deteleport_preventer = 0;
   empty_char_space3.accidental_deteleport_preventer = 0;
   empty_char_space4.accidental_deteleport_preventer = 0;
   $do_not_animate_teleport = 1;
   empty_char_space1.schedule(0, "deteleport", 0);
   empty_char_space2.schedule(0, "deteleport", 0);
   empty_char_space3.schedule(0, "deteleport", 0);
   empty_char_space4.schedule(0, "deteleport", 0);
   $do_not_animate_teleport = 0;
   empty_char_space1.star_timer = 0;
   empty_char_space1.star_points = 0;
   echo("\c2 Calling customer1 idle animation");
   empty_char_space1.schedule(0, "delete_old_data", 0);
   //additional data just in case there needs to be a future scheduling override
   % identify_this_time_space = $world_numeral; 
   % confirm_world_numeral = $round_numeral; 
   % confirm_round_numeral = 0;
   $char_sched_01 = empty_char_space1.schedule(0, "spawn_char_new", 0);
   $clocked_char = empty_char_space1.seat_num;
   fade_ui_heads();
   /* note this is the only char who's tips do not appear EVER */
   $game_clock_number = 0;
   $toggle_initial_spawner_via_clock = 1;
   $reset_star_value_for_init_char1 = 1;
   $toggle_char2_spawn = 0;
  }

  //edit 01-24-2014 spawn char 1, but all other chars are off limits during tutorial mode
  if ($tutorial_popup_officially_ended_via_yes_or_no != 0) {

   % clock_limit_01 = $game_clock_limit; 
   % clock_limit_02 = $game_clock_limit + $game_clock_limit; 
   % clock_limit_03 = $game_clock_limit + $game_clock_limit + $game_clock_limit; 
   % clock_limit_04 = $game_clock_limit + $game_clock_limit + $game_clock_limit + $game_clock_limit; 
   % half_clock_limit_01 = % clock_limit_01 / 2; 
   % half_clock_limit_02 = % clock_limit_01; 
   % half_clock_limit_03 = % clock_limit_01 + % half_clock_limit_01; 
   % half_clock_limit_04 = % clock_limit_02; 
   % half_clock_limit_05 = % clock_limit_02 + % half_clock_limit_01; 
   % half_clock_limit_06 = % clock_limit_03; 
   % half_clock_limit_07 = % clock_limit_03 + % half_clock_limit_01; 
   % half_clock_limit_08 = % clock_limit_04;
   % clock_limit_05 = % clock_limit_04 + 1;

   if ($game_clock_number >= % half_clock_limit_01 & $game_clock_number < % half_clock_limit_02) {
    status_checker.text = "1/8 @ char2";
   }
   if ($game_clock_number >= % half_clock_limit_02) {
    status_checker.text = "2/8 @ char3";
   }
   if ($game_clock_number >= % half_clock_limit_02 & $toggle_char2 != 1) {
    $toggle_char2 = 1;
    $toggle_char3 = 0;
   }
   if ($game_clock_number >= % half_clock_limit_03) {
    status_checker.text = "3/8 @ char4";
   }
   if ($game_clock_number >= % half_clock_limit_04) {
    status_checker.text = "4/8 @ char1";
   }
   if ($game_clock_number >= % half_clock_limit_04 & $toggle_char3 != 1) {
    $toggle_char3 = 1;
    $toggle_char4 = 0;
   }
   if ($game_clock_number >= % half_clock_limit_05) {
    status_checker.text = "5/8 @ char2";
   }
   if ($game_clock_number >= % half_clock_limit_06) {
    status_checker.text = "6/8 @ char3";
   }
   if ($game_clock_number >= % half_clock_limit_06 & $toggle_char4 != 1) {
    $toggle_char4 = 1;
    $toggle_char1 = 0;
   }
   if ($game_clock_number >= % half_clock_limit_07) {
    status_checker.text = "7/8 @ char4";
   }
   if ($game_clock_number >= % half_clock_limit_08) {
    status_checker.text = "8/8 @ char1";
   }
   if ($game_clock_number >= % half_clock_limit_08 & $toggle_char1 != 1) {
    $toggle_char1 = 1;
    $toggle_char2 = 0;
   }

   //RESTART CLOCK (eg- this means spawn all chars after initial tut_char_01)
   if ($game_clock_number >= % clock_limit_05) {
    $game_clock_number = 0;
   }

   /* Spawn chars faster than despawner */
   if ($game_clock_number >= % half_clock_limit_01 & $toggle_char2_spawn != 1 & $game_clock_number < % half_clock_limit_02) {
    empty_char_space4.accidental_anger_preventer = 0;
    if (empty_char_space4.is_despawned != 1 & empty_char_space4.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before, 
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space4.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space4.is_despawned != 1 & empty_char_space4.freeze > 0) {
     empty_char_space4.freeze -= 1;
    }

    if (empty_char_space2.is_despawned == 1 & empty_char_space2.keep_me_gone_longer == 0) {
     //01-02-2014 test spawn override of char2
     /* NOTE! 01-03 THIS CAN ACTUALLY JUST BE PLACED ONCE AT BEGINNING OF A ROUND NOW AND STILL WORK GLOBALLY, THERES A LOT OF CLAUSE RESTRAINTS BUILT IN */
     /* KEEPING HERE BECAUSE IT PRECALLS AND NO SPECIAL CHAR SHOULD BE TUT_CHAR */
     check_for_special_characters();

     empty_char_space2.accidental_anger_preventer = 1;
     empty_char_space2.accidental_deteleport_preventer = 1;
     empty_char_space2.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_02 = empty_char_space2.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);

     $clocked_char = empty_char_space2.seat_num;
     fade_ui_heads();
    }
    $toggle_char2_spawn = 1;
    $toggle_char3_spawn = 0;
    status_checker2.text = "Spawning Char 2 1/8";
   }
   if ($game_clock_number >= % half_clock_limit_02 & $toggle_char3_spawn != 1 & $game_clock_number < % half_clock_limit_03) {
    empty_char_space1.accidental_anger_preventer = 0;

    if (empty_char_space1.is_despawned != 1 & empty_char_space1.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before, quite schizophrenic
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space1.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space1.is_despawned != 1 & empty_char_space1.freeze > 0) {
     empty_char_space1.freeze -= 1;
    }

    if (empty_char_space3.is_despawned == 1 & empty_char_space3.keep_me_gone_longer == 0) {
     empty_char_space3.accidental_anger_preventer = 1;
     empty_char_space3.accidental_deteleport_preventer = 1;
     empty_char_space3.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_03 = empty_char_space3.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space3.seat_num;
     fade_ui_heads();
    }
    $toggle_char3_spawn = 1;
    $toggle_char4_spawn = 0;
    status_checker2.text = "Spawning Char 3 2/8";
   }
   if ($game_clock_number >= % half_clock_limit_03 & $toggle_char4_spawn != 1 & $game_clock_number < % half_clock_limit_04) {
    empty_char_space2.accidental_anger_preventer = 0;
    if (empty_char_space2.is_despawned != 1 & empty_char_space2.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before, quite schizophrenic				
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space2.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space2.is_despawned != 1 & empty_char_space2.freeze > 0) {
     empty_char_space2.freeze -= 1;
    }

    if (empty_char_space4.is_despawned == 1 & empty_char_space4.keep_me_gone_longer == 0) {
     empty_char_space4.accidental_anger_preventer = 1;
     empty_char_space4.accidental_deteleport_preventer = 1;
     empty_char_space4.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_04 = empty_char_space4.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space4.seat_num;
     fade_ui_heads();
    }
    $toggle_char4_spawn = 1;
    $toggle_char1_spawn = 0;
    status_checker2.text = "Spawning Char 4 3/8";
   }
   if ($game_clock_number >= % half_clock_limit_04 & $toggle_char1_spawn != 1 & $game_clock_number < % half_clock_limit_05) {
    empty_char_space3.accidental_anger_preventer = 0;
    if (empty_char_space3.is_despawned != 1 & empty_char_space3.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before, quite schizophrenic				
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space3.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space3.is_despawned != 1 & empty_char_space3.freeze > 0) {
     empty_char_space3.freeze -= 1;
    }

    if (empty_char_space1.is_despawned == 1 & empty_char_space1.keep_me_gone_longer == 0) {
     empty_char_space1.accidental_anger_preventer = 1;
     empty_char_space1.accidental_deteleport_preventer = 1;
     empty_char_space1.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_05 = empty_char_space1.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space1.seat_num;
     fade_ui_heads();
    }
    $toggle_char1_spawn = 1;
    $toggle_char2_spawn = 0;
    status_checker2.text = "Spawning Char 1 4/8";
   }

   /* Repeating Statements for other half of clock */

   if ($game_clock_number >= % half_clock_limit_05 & $toggle_char2_spawn != 1 & $game_clock_number < % half_clock_limit_06) {
    empty_char_space4.accidental_anger_preventer = 0;
    if (empty_char_space4.is_despawned != 1 & empty_char_space4.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before				
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space4.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space4.is_despawned != 1 & empty_char_space4.freeze > 0) {
     empty_char_space4.freeze -= 1;
    }

    if (empty_char_space2.is_despawned == 1 & empty_char_space2.keep_me_gone_longer == 0) {
     empty_char_space2.accidental_anger_preventer = 1;
     empty_char_space2.accidental_deteleport_preventer = 1;
     empty_char_space2.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_06 = empty_char_space2.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space2.seat_num;
     fade_ui_heads();
    }
    $toggle_char2_spawn = 1;
    $toggle_char3_spawn = 0;
    status_checker2.text = "Spawning Char 2 5/8";
   }
   if ($game_clock_number >= % half_clock_limit_06 & $toggle_char3_spawn != 1 & $game_clock_number < % half_clock_limit_07) {
    empty_char_space1.accidental_anger_preventer = 0;
    if (empty_char_space1.is_despawned != 1 & empty_char_space1.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before			
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space1.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space1.is_despawned != 1 & empty_char_space1.freeze > 0) {
     empty_char_space1.freeze -= 1;
    }

    if (empty_char_space3.is_despawned == 1 & empty_char_space3.keep_me_gone_longer == 0) {
     empty_char_space3.accidental_anger_preventer = 1;
     empty_char_space3.accidental_deteleport_preventer = 1;
     empty_char_space3.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_07 = empty_char_space3.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space3.seat_num;
     fade_ui_heads();
    }
    $toggle_char3_spawn = 1;
    $toggle_char4_spawn = 0;
    status_checker2.text = "Spawning Char 3 6/8";
   }
   if ($game_clock_number >= % half_clock_limit_07 & $toggle_char4_spawn != 1 & $game_clock_number < % half_clock_limit_08) {
    empty_char_space2.accidental_anger_preventer = 0;
    if (empty_char_space2.is_despawned != 1 & empty_char_space2.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before				
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space2.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space2.is_despawned != 1 & empty_char_space2.freeze > 0) {
     empty_char_space2.freeze -= 1;
    }

    if (empty_char_space4.is_despawned == 1 & empty_char_space4.keep_me_gone_longer == 0) {
     empty_char_space4.accidental_anger_preventer = 1;
     empty_char_space4.accidental_deteleport_preventer = 1;
     empty_char_space4.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_08 = empty_char_space4.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space4.seat_num;
     fade_ui_heads();
    }
    $toggle_char4_spawn = 1;
    $toggle_char1_spawn = 0;
    status_checker2.text = "Spawning Char 4 7/8";
   }
   if ($game_clock_number >= % half_clock_limit_08 & $toggle_char1_spawn != 1) {
    empty_char_space3.accidental_anger_preventer = 0;
    if (empty_char_space3.is_despawned != 1 & empty_char_space3.freeze == 0) {
     //register world and level and pass it through schedules to determine if they are scheduling on correct level
     //note: locals seem to get transposed down one, so every next one equals the one before				
     % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     empty_char_space3.schedule(0, "get_angry", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
    }
    if (empty_char_space3.is_despawned != 1 & empty_char_space3.freeze > 0) {
     empty_char_space3.freeze -= 1;
    }

    if (empty_char_space1.is_despawned == 1 & empty_char_space1.keep_me_gone_longer == 0) {
     empty_char_space1.accidental_anger_preventer = 1;
     empty_char_space1.accidental_deteleport_preventer = 1;
     empty_char_space1.schedule(0, "delete_old_data", 0); % identify_this_time_space = $world_numeral; % confirm_world_numeral = $round_numeral; % confirm_round_numeral = 0;
     $char_sched_09 = empty_char_space1.schedule(0, "spawn_char_new", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral);
     $clocked_char = empty_char_space1.seat_num;
     fade_ui_heads();
    }
    $toggle_char1_spawn = 1;
    $toggle_char2_spawn = 0;
    status_checker2.text = "Spawning Char 1 8/8";
   }

   if ($debug_mode_on == 1) {
    char_time_checkerb1.text = $game_clock_number;
    char_time_checkerb2.text = $game_clock_number;
    char_time_checkerb3.text = $game_clock_number;
    char_time_checkerb4.text = $game_clock_number;
   }
   if ($debug_mode_on != 1) {
    char_time_checkerb1.text = "";
    char_time_checkerb2.text = "";
    char_time_checkerb3.text = "";
    char_time_checkerb4.text = "";
   }
  }
 }
}

function char_button::set_star_timer( % this) {

 if ( % this.toggle_off_star_timer != 1 & % this.is_despawned != 1) { % this.star_timer += 100;
  display_get_it4.text = % this.star_timer;

  if ( % this.seat_num == 1) {
   //edit 07-11-2014 added to prevent dual scheduling of first char during certain starts
   if ($first_char_timing_activated != 1) {
    $star_timer_sched_1 = % this.seat_name.schedule(100, "set_star_timer", 0);
   }
   $first_char_timing_activated = 1;
   test_case2.text = "activated B 1";
  }
  if ( % this.seat_num == 2) {
   $star_timer_sched_2 = % this.seat_name.schedule(100, "set_star_timer", 0);
  }
  if ( % this.seat_num == 3) {
   $star_timer_sched_3 = % this.seat_name.schedule(100, "set_star_timer", 0);
  }
  if ( % this.seat_num == 4) {
   $star_timer_sched_4 = % this.seat_name.schedule(100, "set_star_timer", 0);
  }
  if ($debug_mode_on == 1) { % seat_for_array = ("char_time_checker"
    @ % this.seat_num); % seat_for_array.text = % this.star_timer;
   spawn_time_checker.setBlendAlpha(1);
   schedule_checker.setBlendAlpha(1);
   schedule_checker2.setBlendAlpha(1);
   schedule_checker3.setBlendAlpha(1);
  }
  if ($debug_mode_on != 1) {
   char_time_checker1.text = "";
   char_time_checker2.text = "";
   char_time_checker3.text = "";
   char_time_checker4.text = "";
  }
 }
 if ( % this.toggle_off_star_timer == 1) {
  if ($debug_mode_on == 1) { % seat_for_array = ("char_time_checker"
    @ % this.seat_num); % seat_for_array.text = "TOGGLE OFF";
   spawn_time_checker.setBlendAlpha(1);
   schedule_checker.setBlendAlpha(1);
   schedule_checker2.setBlendAlpha(1);
   schedule_checker3.setBlendAlpha(1);
  }
  if ($debug_mode_on != 1) {
   char_time_checker1.text = "";
   char_time_checker2.text = "";
   char_time_checker3.text = "";
   char_time_checker4.text = "";
  }
 }

}

function char_button::pick_drink( % this) {
 echo("PICK DRINK ACTIVATED FOR EMPTY_CHAR_SPACE" @ % this.seat_num);

 if ( % this.drink_requested != 2) {
  //click first character of round to initiate, after randomization works
  $drink1_num = (getRandom(1, 18));
  $drink2_num = (getRandom(1, 18));

  //FORCE PICKS OPTIONS BELOW
  //$drink1_num = 5;
  //$drink2_num = 6;
  //store picks to character	
  % this.thirst_p1 = $drink1_num; % this.thirst_p2 = $drink2_num;

  //Special Case if both drinks are equal, since you only have one button per each
  //This makes it so if equal, and the number is 11 or less, +1 from drink1 to make drink2
  if ($drink1_num == $drink2_num & $drink2_num < 18) {
   $drink2_num = ($drink1_num + 1);
   /* Special Case 25, renumber drink_num causing timing imbalance with waiter in this case. Solution, re-rename case */
   echo("\c2 SPECIAL CASE 25"); 
   % this.thirst_p2 = $drink2_num;
  }

  //Special Case if both drinks are equal, since you only have one button per each
  //This makes it so if equal, and the number is 12, make drink2 11, since minusing it would do it anyway
  if ($drink1_num == $drink2_num & $drink2_num == 18) {
   $drink2_num = 17;
   /* Special Case 25b, renumber drink_num causing timing imbalance with waiter in this case. Solution, re-rename case */
   echo("\c2 SPECIAL CASE 25b"); 
   % this.thirst_p2 = $drink2_num;
  }

  //------------------------------------
  //DECIPHER ALL VARIETIES OF DRINK HERE
  //------------------------------------

  if ($drink1_num == 1) {
   $find_image_name1 = "button_red_fruitsImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 1) {
   $find_image_name2 = "button_red_fruitsImageMap";
   $find_image_frame2 = 0;
  }
  if ($drink1_num == 2) {
   $find_image_name1 = "button_orange_fruit3ImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 2) {
   $find_image_name2 = "button_orange_fruit3ImageMap";
   $find_image_frame2 = 0;
  }
  if ($drink1_num == 3) {
   $find_image_name1 = "button_yellow_fruit3ImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 3) {
   $find_image_name2 = "button_yellow_fruit3ImageMap";
   $find_image_frame2 = 0;
  }
  if ($drink1_num == 4) {
   $find_image_name1 = "button_green_fruitsImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 4) {
   $find_image_name2 = "button_green_fruitsImageMap";
   $find_image_frame2 = 0;
  }
  if ($drink1_num == 5) {
   $find_image_name1 = "button_blue_fruits3ImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 5) {
   $find_image_name2 = "button_blue_fruits3ImageMap";
   $find_image_frame2 = 0;
  }
  if ($drink1_num == 6) {
   $find_image_name1 = "button_purple_fruit3ImageMap";
   $find_image_frame1 = 0;
  }
  if ($drink2_num == 6) {
   $find_image_name2 = "button_purple_fruit3ImageMap";
   $find_image_frame2 = 0;
  }

  //Frame 1
  if ($drink1_num == 7) {
   $find_image_name1 = "button_red_fruitsImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 7) {
   $find_image_name2 = "button_red_fruitsImageMap";
   $find_image_frame2 = 1;
  }
  if ($drink1_num == 8) {
   $find_image_name1 = "button_orange_fruit3ImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 8) {
   $find_image_name2 = "button_orange_fruit3ImageMap";
   $find_image_frame2 = 1;
  }
  if ($drink1_num == 9) {
   $find_image_name1 = "button_yellow_fruit3ImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 9) {
   $find_image_name2 = "button_yellow_fruit3ImageMap";
   $find_image_frame2 = 1;
  }
  if ($drink1_num == 10) {
   $find_image_name1 = "button_green_fruitsImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 10) {
   $find_image_name2 = "button_green_fruitsImageMap";
   $find_image_frame2 = 1;
  }
  if ($drink1_num == 11) {
   $find_image_name1 = "button_blue_fruits3ImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 11) {
   $find_image_name2 = "button_blue_fruits3ImageMap";
   $find_image_frame2 = 1;
  }
  if ($drink1_num == 12) {
   $find_image_name1 = "button_purple_fruit3ImageMap";
   $find_image_frame1 = 1;
  }
  if ($drink2_num == 12) {
   $find_image_name2 = "button_purple_fruit3ImageMap";
   $find_image_frame2 = 1;
  }

  //Frame 2
  if ($drink1_num == 13) {
   $find_image_name1 = "button_red_fruitsImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 13) {
   $find_image_name2 = "button_red_fruitsImageMap";
   $find_image_frame2 = 2;
  }
  if ($drink1_num == 14) {
   $find_image_name1 = "button_orange_fruit3ImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 14) {
   $find_image_name2 = "button_orange_fruit3ImageMap";
   $find_image_frame2 = 2;
  }
  if ($drink1_num == 15) {
   $find_image_name1 = "button_yellow_fruit3ImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 15) {
   $find_image_name2 = "button_yellow_fruit3ImageMap";
   $find_image_frame2 = 2;
  }
  if ($drink1_num == 16) {
   $find_image_name1 = "button_green_fruitsImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 16) {
   $find_image_name2 = "button_green_fruitsImageMap";
   $find_image_frame2 = 2;
  }
  if ($drink1_num == 17) {
   $find_image_name1 = "button_blue_fruits3ImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 17) {
   $find_image_name2 = "button_blue_fruits3ImageMap";
   $find_image_frame2 = 2;
  }
  if ($drink1_num == 18) {
   $find_image_name1 = "button_purple_fruit3ImageMap";
   $find_image_frame1 = 2;
  }
  if ($drink2_num == 18) {
   $find_image_name2 = "button_purple_fruit3ImageMap";
   $find_image_frame2 = 2;
  }

  if ($tut_yes_is_active == 1) {
   if ($tut_char_fruit_choices == 1) {
    $drink1_num = 2;
    $drink2_num = 3;
    $find_image_name1 = "button_orange_fruit3ImageMap";
    $find_image_frame1 = 0;
    $find_image_name2 = "button_yellow_fruit3ImageMap";
    $find_image_frame2 = 0;

   }
   if ($tut_char_fruit_choices == 2) {
    $drink1_num = 7;
    $drink2_num = 16;
    $find_image_name1 = "button_red_fruitsImageMap";
    $find_image_frame1 = 1;
    $find_image_name2 = "button_green_fruitsImageMap";
    $find_image_frame2 = 2;
   }
  }
  //store frames to character
  % this.thirst_frame_p1 = $find_image_frame1; 
  % this.thirst_frame_p2 = $find_image_frame2; 
  % localized_char_number = % this.seat_num;
  //edit 02-02-2013 in case of waiter serving, all char drink thought icons spawn from here, adding in thought bubble/exclame per that as well as positional data
  % this_char_x = % this.getPositionX(); 
  % this_char_y = % this.getPositionY(); 
  % char_reset_pos_x = % this_char_x + 1; 
  % char_reset_pos_y = % this_char_y - 10; 
  % icon_exclame_name = "icon_exclame" @ % localized_char_number; 
  % icon_exclame_name.setPositionX( % char_reset_pos_x); 
  % icon_exclame_name.setPositionY( % char_reset_pos_y);
  % icon_exclame_name.setSize(4.199, 5.371);
  
  if ( % this.powerup_buy_time == 0) { 
  % icon_exclame_name.setAnimation(icon_exclame_yellowAnimation); 
  % icon_exclame_name.setLayer(14);
  }
 
  % thought_reset_pos_xb = % this_char_x - 2;
  ("thought" @ % localized_char_number).setAnimation(thought_bubble2Animation);
  ("thought" @ % localized_char_number).AutoRotation = 50;
  ("thought" @ % this.seat_num).setPositionX( % thought_reset_pos_xb);
  ("thought" @ % this.seat_num).setPositionY( % char_reset_pos_y);

  //12-22-2013 exception for character 4, whos bubble is too far up

  ("p_want" @ % localized_char_number).setImageMap($find_image_name1);
  ("p_wantb" @ % localized_char_number).setImageMap($find_image_name2);
  ("p_want" @ % localized_char_number).setFrame($find_image_frame1);
  ("p_wantb" @ % localized_char_number).setFrame($find_image_frame2);
  $this_char_x = % this.getPositionX();
  $this_char_y = % this.getPositionY();
  $p_reset_pos_x1 = $this_char_x - 5.25;
  $p_reset_pos_x2 = $this_char_x + 1.25;
  $p_reset_pos_y1 = $this_char_y - 10;
  ("p_want" @ % localized_char_number).setPositionX($p_reset_pos_x1);
  ("p_wantb" @ % localized_char_number).setPositionX($p_reset_pos_x2);
  ("p_want" @ % localized_char_number).setPositionY($p_reset_pos_y1);
  ("p_wantb" @ % localized_char_number).setPositionY($p_reset_pos_y1);

  /* --- APPETIZER CONFIGURATION --- */
  //edit 04-12-2014 roll if they want appetizers
  % want_an_appetizer = (getRandom(1, 4));
  if ($tut_yes_is_active == 1 & $activate_tut_cointip_portion < 4) { 
  % want_an_appetizer = 1;
  }
  if ($tut_yes_is_active == 1 & $activate_tut_cointip_portion >= 4) { 
  % want_an_appetizer = 3;
  }
  if ( % want_an_appetizer == 1) {
   ("p_want" @ % localized_char_number).setPositionX($p_reset_pos_x1);
   ("p_wantb" @ % localized_char_number).setPositionX($p_reset_pos_x2);
   ("p_want"  @ % localized_char_number).setPositionY($p_reset_pos_y1);
   ("p_wantb" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   //do nothing, theres a 1 in 4 chance of wanting appetizer1 or 2, so half of four represents noting
   appetizer_num.text = "1"; 
   % this.needs_appetizer = 0; 
   % this.wants_appetizer = 0;
  }
  if ( % want_an_appetizer == 2) {
   ("p_want" @ % localized_char_number).setPositionX($p_reset_pos_x1);
   ("p_wantb" @ % localized_char_number).setPositionX($p_reset_pos_x2);
   ("p_want" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   ("p_wantb" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   //do nothing, theres a 1 in 4 chance of wanting appetizer1 or 2, so half of four represents noting
   appetizer_num.text = "2"; 
   % this.needs_appetizer = 0; 
   % this.wants_appetizer = 0;
  }
  if ( % want_an_appetizer < 1) {
   ("p_want" @ % localized_char_number).setPositionX($p_reset_pos_x1);
   ("p_wantb" @ % localized_char_number).setPositionX($p_reset_pos_x2);
   ("p_want" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   ("p_wantb" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   //weirdness check
   appetizer_num.text = "< 1"; 
   % this.needs_appetizer = 0; 
   % this.wants_appetizer = 0;
  }
  if ( % want_an_appetizer > 4) {
   ("p_want" @ % localized_char_number).setPositionX($p_reset_pos_x1);
   ("p_wantb" @ % localized_char_number).setPositionX($p_reset_pos_x2);
   ("p_want" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   ("p_wantb" @ % localized_char_number).setPositionY($p_reset_pos_y1);
   //weirdness check
   appetizer_num.text = "> 4"; 
   % this.needs_appetizer = 0; 
   % this.wants_appetizer = 0;
  }
  if ( % want_an_appetizer == 3) {
   % re_reset_pos_y = $p_reset_pos_y1 - 2;
   ("p_want" @ % localized_char_number).setPositionY( % re_reset_pos_y);
   ("p_wantb" @ % localized_char_number).setPositionY( % re_reset_pos_y); 
   % appetizer_pos_y = $p_reset_pos_y1 + 1.5; 
   % appetizer_pos_x = $p_reset_pos_x1 + 3; 
   % this_appetizer1 = "appetizer_thought" @ % this.seat_num; 
   % this_appetizer1.setPositionX( % appetizer_pos_x); 
   % this_appetizer1.setPositionY( % appetizer_pos_y); 
   % this_appetizer1.setSize(6.446, 5.127); 
   % this_appetizer1.setImageMap(appetizer1_thoughtsImageMap); 
   % this_appetizer1.setBlendAlpha(1); 
   % appetizer_thought_frame = $world_numeral - 1; 
   % this_appetizer1.setFrame( % appetizer_thought_frame); 
   % this.needs_appetizer = 3; 
   % this.wants_appetizer = 1;
   appetizer_num.text = "3";
  }
  if ( % want_an_appetizer == 4) { % re_reset_pos_y = $p_reset_pos_y1 - 2;
   ("p_want" @ % localized_char_number).setPositionY( % re_reset_pos_y);
   ("p_wantb" @ % localized_char_number).setPositionY( % re_reset_pos_y); 
   % appetizer_pos_y = $p_reset_pos_y1 + 1.5; 
   % appetizer_pos_x = $p_reset_pos_x1 + 3; 
   % this_appetizer1 = "appetizer_thought" @ % this.seat_num; 
   % this_appetizer1.setPositionX( % appetizer_pos_x); 
   % this_appetizer1.setPositionY( % appetizer_pos_y); 
   % this_appetizer1.setSize(6.446, 5.127);
   % this_appetizer1.setImageMap(appetizer2b_thoughtsImageMap); 
   % this_appetizer1.setBlendAlpha(1); 
   % appetizer_thought_frame = $world_numeral - 1; 
   % this_appetizer1.setFrame( % appetizer_thought_frame); 
   % this.needs_appetizer = 4; 
   % this.wants_appetizer = 1;
   appetizer_num.text = "4";
  }
  echo("\c2 PPPPPPPPPPPPPPPPPPPPPPPwant @ char_button::pick_drink is %localized_char_number"
   @ % localized_char_number);
  if ( % this.seat_num == 4 & % this.needs_appetizer != 3 & % this.needs_appetizer != 4) {
   $lcnn1_echo_test = % char_reset_pos_y;
   $lcnn2_echo_test = $p_reset_pos_y1; 
   % reposition_bubble_4 = -31.597; 
   % reposition_thoughts_4 = -31.597;
   thought4.setPositionY( % reposition_bubble_4);
   p_want4.setPositionY( % reposition_thoughts_4);
   p_wantb4.setPositionY( % reposition_thoughts_4);
  } % this.drink_requested = 2;
 }
 echo(">>>>>END OF PICK DRINK<<<<<");
}


function char_button::get_angry( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {

 if ( % identify_this_time_space == $world_numeral & % confirm_world_numeral == $round_numeral) {

  //edit 06-13-2013 added base name for identification without %this issues
  % register_base_name = % this.seat_name; 
  % register_base_num = % this.seat_num; 
  % accidently_angry = % this.accidental_anger_preventer;
  echo("New %register_base_name is " @ % register_base_name);

  if ( % accidently_angry != 1) {
   /* EDIT 05-09-2013 to prevent 'constipation' */
   /* need : IF SPAWNED AFTER BEING DELAYED, WAIT 1/4 CLOCK BEFORE ALLOWING ANGER BECAUSE A SLIGHT OFF-TIMING CAN CAUSE A CHAR TO INSTANTLY BECOME ANGRY */
   if ( % this.detected_incoming_drink != 1 & % this.lock_incoming_drink != 1) {
    if ($timescale == 1 & $all_tables_are_dirty == 0) {
     //**super special case: time incongruency can cause char = char1 to both equal and not equal char 1, in that case just wait
     //adds irrevelent info to list of actions if let off, no error though
     if ($p1_present == 0 & % input_seat_num == 0) {
      echo("\c2 WARNING: LINE 414 SEAT NAME UNKNOWN");
     }

     if ($p1_present == 0 & % input_seat_num == 1) {
      //do nothing
     }

     $pre_identify_this_char = "empty_char_space" @ % input_seat_num;
     
     if ($p1_present == 0 & $pre_identify_this_char.is_despawned == 0 & $timescale == 1 & $all_tables_are_dirty == 0) {
      callie.shame();
      //edit 01-04-2014 Adding special character ability to override anger mode
      % make_unique_char_num_incase_special_chars = % recast3_char;

      if ( % specific_specialized_char != $prechosen_seat_num_for_special_char) { 
	  % make_unique_char_num_incase_special_chars.model_type = % make_unique_char_num_incase_special_chars.seat_num;
      }

      if ($special_char_already_used != 1 & $spawn_special_character == 1 & $special_char_world == $world_numeral & $special_char_level == $current_level & % specific_specialized_char == $prechosen_seat_num_for_special_char) {
       % make_unique_char_num_incase_special_chars.model_type = 5;
       force_black_out();
       special_character_hili.setPositionX(9999);
       special_character_hili.setPositionY(9999);
      }

      % new_customer_idle_animation = $customer[ % make_unique_char_num_incase_special_chars.model_type] @ "_angerAnimation"; 
	  % this.in_cell_anger = 1; 
	  % recast3_char.setAnimation( % new_customer_idle_animation); 
	  % this.is_angry = 1;

      //spawn red exclamation
      % icon_exclame_num = % recast3_char.seat_num; 
	  % icon_exclame_name = "icon_exclame" @ % icon_exclame_num;
      $this_char_x = % recast3_char.getPositionX();
      $this_char_y = % recast3_char.getPositionY();
      $char_reset_pos_x = $this_char_x + 1;
      $char_reset_pos_y = $this_char_y - 10; 
	  % icon_exclame_name.setPositionX($char_reset_pos_x); 
	  % icon_exclame_name.setPositionY($char_reset_pos_y); 
	  % icon_exclame_name.setAnimation(icon_exclame_redAnimation); 
	  % icon_exclame_name.setSize(4.199, 5.371); 
	  % icon_exclame_name.setLayer(14);
      $anger_amount_counter += 1;

      if ($anger_amount_counter >= 3) {
       force_black_out();
      }
      if ($in_between_levels_trophy_protect != 1) {
       $trophy_angered_a_customer = 1;
      }
     }

     if ($reteleport == 0 & $char1_occupied == 0 & $p1_present == 1 & $timescale == 1 & $all_tables_are_dirty == 0) {
      echo("\c2 ALTERIOR ANGER MODE ATTEMPTED TO ACTIVATE");
     }

     if ($reteleport == 1) {
      echo("reteleport = 1");
     }

     //edit 07-25-2013 Attempting internal half timer for get angry - deteleport
     % clock_limit_anger = $game_clock_limit / 4; 
	 % clock_limit_quarter = $game_clock_limit / 4; 
	 % clock_limit_delay = $game_clock_limit + % clock_limit_quarter;
     //-----------------------------------------------------------------------DETELEPORT-----------------------------------------------------------------------------	
     % this.accidental_deteleport_preventer = 0; 
	 % this.schedule( % clock_limit_anger, "deteleport", 0);
     //edit 06-09-2014 make bronze star sys array if any anger
     $star_sys_medal_won = 1;
     gold_clock_limit_says.text = 0;
     silver_clock_limit_says.text = 0;
     bronze_clock_limit_says.text = 1; 
	 % gold_clock_limit_star = 0; 
	 % silver_clock_limit_star = 0; 
	 % bronze_clock_limit_star = 1; 
	 % hearts_identify = "hearts_" @ % register_base_num; % hearts_identify.setBlendAlpha(0);
     //-----------------------------------------------------------------------END DETELEPORT-----------------------------------------------------------------------------			

    }

    //05-14-2013 Found %this.lock_incoming_drink can cause get_angry to get stuck indefintiely if wait for drink clause happens and no drink is served, 
    //so making another clause for that
    //05-14-2013 Found lock_incoming_drink would never happen because you'd only lock it AFTER seeing char_anger start, so it would show up ONLY in deteleport

    if ( % this.lock_incoming_drink == 1) { 
	% this.drink_was_locked_at_anger = 1;
    }
    if ( % this.lock_incoming_drink == 0) { 
	% this.drink_was_locked_at_anger = 99998;
    }
   }
  }
 }
}


function char_button::deteleport_adjust( % this) {
 //edit 01-30-2013 Adding extra deteleport_adjust shutdown if statement so it doesn't loop and quick spawn in-out
 if ( % this.deteleport_adjust != 1) { % this.detected_incoming_drink = 0; % this.drink_requested = 0;
  echo("deteleport adjust was used for char number " @ % this.seat_num); % this.deteleport_adjust = 1;
 }
 echo("deteleport adjust ENDED for char number " @ % this.seat_num);
}


function char_button::deteleport( % this) {
 if ( % this.hard_paused_anger != 1) {
  echo("deteleport called for char number " @ % this.seat_num); % accidently_deteleporting = % this.accidental_deteleport_preventer;
  if ( % accidently_deteleporting != 1) {
   echo("deteleport accidently_deteleporting passed for char number " @ % this.seat_num);
   //05-14-2013 Special Case: If drink_was_locked when saw anger (meaning by the time you clicked anger, it was already over) then check for valid drink which was the point
   //of the lock_drink, to delay when valid drink arrives, if it wasn't valid, disable it below and let deteleport do it's job, so anger_mode doesnt get stuck in a loop
   if ( % this.lock_incoming_drink == 1) {
    //05-14-2013 if did not approve drink, then get out
    if ( % this.detected_incoming_drink != 1) { 
	% this.lock_incoming_drink = 0;
    }
   }

   //this causes char_cleared error
   //Basically, if char is already despawned, and you need to still despawn it, don't make it visible but make sure it's unlocked for when seat is filled by next char 
   if ( % this.is_despawned == 1) {
    $chosen_seat.occupied = 0;
   }
   echo("%this.is_despawned = " @ % this.is_despawned @ "%this.is_angry" @ % this.is_angry);
   //edit 05-14-2013 added %this.is_angry == 1 because it should never deteleport here unless angry first, otherwise it'd go through waiters alternative deteleporter
   if ( % this.is_despawned != 1 & % this.is_angry == 1) { 
	% this.has_been_spawned = 0;

    if ( % this.detected_incoming_drink != 1 & % this.lock_incoming_drink != 1) {
     //Warning- Not ending statements with char occupied will cause CRASH in empty_char animation as illegal timers have to be allowed to run through here once before
     //ending because they needed to be set off and in one instance their function needs to be invalidated, making them invalid when it hits here
     //See function char_button::set_anger_time
     //**special case: if char 1 is gone first, then start auto spawning, auto removing the rest
     $cease_infinite_spawning_issues = % this.cease_infinite_spawn;
     $currently_is_angry = % this.is_angry; % current_seat_num = % this.seat_num;

     if ( % this.is_angry == 1) {
      $cease_infinite_spawning_issues = 0;
     }

     if ($p1_present == 0 & $cease_infinite_spawning_issues == 0 & $char1_tutorial_over_with == 1) {
      $prefixize_name = "empty_char_space";
      //TESTING NEW DETELEPORTS
      % recast_char2.occupied = 0;
      $quickly_get_random_char_x = % recast_char2.getPositionX();
      $quickly_get_random_char_y = % recast_char2.getPositionY();

      if ($special_case_clause_to_prevent_char1_reteleport_animation_temporarily == 0) {
       echo("$special_case_clause_to_prevent_char1_reteleport_animation_temporarily for empty_char_space" @ % current_seat_num);
      }
      if ($do_not_animate_teleport != 1) {
       ("obj_teleport" @ % current_seat_num).setAnimation(teleportAnimation2);
      }
      //edit 06-16-2014 make sure hearts are hidden upon deteleport
      % hearts_hider = "hearts_" @ % recast_char2.seat_num; 
	  % hearts_hider.setBlendAlpha(0); 
	  % recast_char2.setAnimation(empty_char_spaceAnimation); 
	  % recast_char2.is_angry = 0; 
	  % recast_char2.is_despawned = 1;
      //06-08-2013 adding additional clauses for stopping star timer where char can despawn
      % recast_char2.star_timer = 0;
      //despawn yellow exclamation
      //edit 01-31-2013 renaming legacy globals for exclamations
      % icon_exclame_num = % recast_char2.seat_num; 
	  % icon_exclame_name = "icon_exclame" @ % icon_exclame_num;
      $this_char_x = % recast_char2.getPositionX();
      $this_char_y = % recast_char2.getPositionY();
      $char_reset_pos_x = $this_char_x + 1;
      $char_reset_pos_y = $this_char_y - 10; 
	  % icon_exclame_name.setPositionX($char_reset_pos_x); 
	  % icon_exclame_name.setPositionY($char_reset_pos_y); 
	  % icon_exclame_name.setAnimation(empty_char_spaceAnimation);
      ("thought" @ % this.seat_num).setAnimation(thought_bubble_emptyAnimation);
      ("thought" @ % this.seat_num).AutoRotation = 0;
      echo("This.seat_num = " @ % this.seat_num);
      ("p_want" @ % this.seat_num).setImageMap(want_emptyImageMap);
      ("p_wantb" @ % this.seat_num).setImageMap(want_emptyImageMap);
      (appetizer_thought @ % this.seat_num).setImageMap(want_emptyImageMap);
      (appetizer_thought @ % this.seat_num).setBlendAlpha(0);
      //edit 01-24-2013 extra measure to identify whether or not p-wants are displayed or not
      % this.displaying_wants = 0; 
	  % this.drink_requested = 0;
      //edit 05-20-2013 star_timer resetter
      % this.star_timer = 0; 
	  % this.powerup_buy_time = 0;
     }

     if ($reset_randomers == 1) {
      echo("char_button::deteleport > reset randomers = 1");
     }

     if ($char1_occupied == 1) {
      echo("char_button::deteleport > char1_occupied = 1");
     }

     if ($reteleport == 0 & $char1_occupied == 0) {
      //SPECIFICALLY CHAR1 DETELEPORT ONLY, no other chars use this
      if ($do_not_animate_teleport != 1) {
       ("obj_teleport" @ % this.seat_num).setAnimation(teleportAnimation2);
      }
      //edit 06-16-2014 make sure hearts are hidden upon deteleport
      % hearts_hider = "hearts_" @ % this.seat_num; % hearts_hider.setBlendAlpha(0); % this.setAnimation(empty_char_spaceAnimation);
      //edit 05-20-2013 star_timer resetter
      % this.star_timer = 0;
      % this.is_angry = 0; 
	  % this.is_despawned = 1; 
	  % this.busy = 0;
      echo("INITIALIZER: char1 deteleported");
      $char1_tutorial_over_with = 1;
      //despawn yellow exclamation
      % icon_exclame_num = % this.seat_num; 
	  % icon_exclame_name = "icon_exclame" @ % icon_exclame_num; 
	  % this_char_x = % this.getPositionX(); 
	  % this_char_y = % this.getPositionY(); 
	  % char_reset_pos_x = % this_char_x + 1; 
	  % char_reset_pos_y = % this_char_y - 10; 
	  % icon_exclame_name.setPositionX( % char_reset_pos_x); 
	  % icon_exclame_name.setPositionY( % char_reset_pos_y); 
	  % icon_exclame_name.setAnimation(empty_char_spaceAnimation);
      ("thought" @ % this.seat_num).setAnimation(thought_bubble_emptyAnimation);
      ("thought" @ % this.seat_num).AutoRotation = 0;
      ("p_want" @ % this.seat_num).setImageMap(want_emptyImageMap);
      ("p_wantb" @ % this.seat_num).setImageMap(want_emptyImageMap);
      (appetizer_thought @ % this.seat_num).setImageMap(want_emptyImageMap);
      (appetizer_thought @ % this.seat_num).setBlendAlpha(0);
      //edit 01-24-2013 extra measure to identify whether or not p-wants are displayed or not
      % this.displaying_wants = 0; 
	  % this.drink_requested = 0; 
	  % this.powerup_buy_time = 0;
     }

     /* PA CODE OUT - Adding this because is_angry does not get reset */
     % this.is_angry = 0;
     echo("\c2 PA CODE OUT START :: %this.is_angry = " @ % this.is_angry);

     //edit 01-25-2013 separating deteleport from get_out is unnecessary, combining the two
     $minimum_number_of_seats = 1;

     //Erase customer's thoughts and thought bubble upon leaving
     if ($p1_present == 0) {
      $stop_redundant_schedules = 1;
     }

	 //Debuggers
     if ( % this.is_angry == 0) {
      echo("At get_out, this.is_angry = 0"); % cease_infinite_spawning_issues = 0;
     }

     if ( % this.is_angry == 1) {
      echo("At get_out, this.is_angry = 1"); % cease_infinite_spawning_issues = 0;
     }

     if ( % this.is_angry != 0 & % this.is_angry != 1) {
      echo("At get_out, this.is_angry = SOMETHING SCREWED UP");
     }

     //Stop stuff from spawning forever
	 if ( % cease_infinite_spawning_issues == 0) {
      $reteleport = 1;
      $p1_present = 0;
      $stop_redundant_schedules = 1;
      $start_random_character_spawning = 1; 
	  % this.all_scheduled = 0;
     }

     % this.drink_requested = 0;
     % this.detected_incoming_drink = 0;
    }

    if ( % this.detected_incoming_drink == 1) {
     echo("DETELEPORT REPEAT EXCEPTION FOR EMPTY_CHAR_SPACE" @ % this.seat_num); 
	 % this.seat_name.schedule(19500, "deteleport_adjust", 0); 
	 % this.seat_name.schedule(20000, "deteleport", 0);
    }

    echo("DETELEPORT FOR EMPTY_CHAR_SPACE" @ % this.seat_num @ " ENDED");
   }
  }
 } % this.hard_paused_anger = 0;
}

/////////////////////////////////////////////////////////
//ENDING -> SPAWNING FUNCTIONS/////////////////////////////////////
/////////////////////////////////////////////////////////


function char_button::random_spawning( % this) {
 $output_seat_num = % this.seat_num;
}

function reset_values() {
 if ($rename_char.cease_infinite_spawn != 1) {

  if ($timescale == 1) {
   $random_seat_num = (getRandom($minimum_number_of_seats, $max_number_of_seats));

   if ($random_customer_num < 0) {
    $random_customer_num = 0;
   }
   //If 4 or greater, go back to 1
   if ($random_customer_num >= 4) {
    $random_customer_num = 0;
   }
   //If 1-3, iterate forward until 4
   if ($random_customer_num >= 0 & $random_customer_num < 4) {
    $random_customer_num += 1;
   }
   echo("AT RESET_VALUES, $random_customer_num = " @ $random_customer_num);
   $declare_incoming_char[$random_seat_num] = $random_seat_num;
   $after_char = $declare_incoming_char[$random_seat_num];
   $rename_char = ("empty_char_space" @ $after_char);
   // Special Case 34 : If outgoing table is also dirty AND (to prevent inf loop crash) if all tables are NOT dirty, spawn again 
   % check_if_table_is_clean = ("empty_coin" @ $after_char).collected;
   //prevents infinite loop crash if all tables are dirty and computer searches for clean one
   $table_1 = empty_coin1.collected;
   $table_2 = empty_coin2.collected;
   $table_3 = empty_coin3.collected;
   $table_4 = empty_coin4.collected; 
   % check_if_all_tables_are_dirty = $table_1 + $table_2 + $table_3 + $table_4;

   //If all tables are dirty, cease all
   if ( % check_if_all_tables_are_dirty == 0) {
    $all_tables_are_dirty = 1;
    $pause_all_chars = 1;
   }

   // Special Case 33 : If reset_values needs to be declared and char number is same 3 times in a row, or if dirty_table spawn and 2 in a row are the same, repeat this 
   if ($preset_char == $after_char) {
    reset_values();
   }

   if ( % check_if_table_is_clean == 0 & $all_tables_are_dirty == 0) {
    /* 01-09-2013 INFINITE LOOPER CRASH HAPPENS HERE- FIX APPLIED */
    $rename_char.cease_infinite_spawn = 1;
    reset_values();
   }
  }
 }
}

function char_button::spawn_char_new( % this, % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral) {
 //edit 06-27-2014 if can't find character, assume it is char1
 if ( % this.seat_num == 0) { 
 % this = "empty_char_space1";
 }
 display_char_thingy2.text = "x" @ % this.seat_num @ "x";
 //edit 06-15-2014 new identifier for beginning of rounds when nothings been established for spawn/despawn
 % this.has_been_spawned = 1; 
 % identify_this_time_space = $world_numeral; 
 % confirm_world_numeral = $round_numeral; 
 % confirm_round_numeral = 0;

 schedule_checker2.text = "world " @ % confirm_world_numeral;
 schedule_checker3.text = "level " @ % confirm_round_numeral;

 if ( % this.hard_paused != 1) {
  //For trophies
  $restart_timer_for_individual_char = 1;
  $individualized_char_timer = 0; % this.schedule(10, "retime_individual_char", 0);
  //edit 06-03-2014 put an already_served = 0 here so incase of a lockup in waiter code, it happens once upon spawn so it cant refuse you thoughts
  % this.already_served = 0;
  callie.signal();
 }


 % this_char_name = % this.seat_name;
 //edit 06-14-2014 new checksum for hard pause
 $global_char_identify_based_on_spawn = % this_char_name;
 check_the_numbas.text = $global_char_identify_based_on_spawn.seat_num; 
 % this_char_num = % this.seat_num;
 % time_frame_calc = $game_clock_limit / 5; 
 % time_frame_1 = % time_frame_calc * 1; 
 % time_frame_2 = % time_frame_calc * 2; 
 % time_frame_3 = % time_frame_calc * 3; 
 % time_frame_4 = % time_frame_calc * 4; 
 % time_frame_5 = % time_frame_calc * 5;
 display_testttb.text = $tut_yes_is_active;
 display_testttc.text = $tutorial_popup_officially_ended_via_yes_or_no;
 /* HEARTS */
 echo("***** HEARTS ACTIVATED ************************* HEARTS ACTIVATED ************************************");
 if ($tut_yes_is_active != 1 & $tutorial_popup_officially_ended_via_yes_or_no == 1) {
  $hearts_scheduled[ % this_char_num] = 1; % hearts_name = "hearts_"
  @ % this_char_num; % round_restart_toggle = $round_restart_switch;
  //edit 03-01-2015 adding another bit of data to pass
  //edit 03-10-2015 reswitching mouse to pad again and again
  //trial $redundant_switching_of_mouse_to_pad = 1;
  //03-10-2015 $redundant_switching_of_mouse_to_pad = 1; makes a game stall so use it right
  if ($redundant_switching_of_mouse_to_pad != 1) { % has_left_the_game_version = $has_left_the_game_version;
  }
  /* THIS IS WHERE IT IS AT ------------------------------------ */

  display_testtt.text = % this_char_num;
  if ( % this_char_num == 0) { % this_char_num = 1;
  }
  //edit 02-25-2015 added $no_hearts_at_all previously but forgot to comment
  if ( % this_char_num == 1 & $no_hearts_at_all != 1) {
   if (empty_char_space1.hard_paused != 1) {
    echo("***** HEARTS VIA CHAR 1 NORMAL, 5 HEARTS TOTAL *****");
    $hearts_sched_5a = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4a = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3a = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2a = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1a = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   //edit 02-27-2014 double spawning occurs so losing this part

   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 5) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 5 HEARTS TOTAL *****");
    $hearts_sched_5a = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4a = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3a = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2a = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1a = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 4) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 4 HEARTS TOTAL *****");
    $hearts_sched_4a = % hearts_name.schedule(0, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3a = % hearts_name.schedule( % time_frame_1, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2a = % hearts_name.schedule( % time_frame_2, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1a = % hearts_name.schedule( % time_frame_3, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_4, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 3) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 3 HEARTS TOTAL *****");
    $hearts_sched_3a = % hearts_name.schedule(0, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2a = % hearts_name.schedule( % time_frame_1, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1a = % hearts_name.schedule( % time_frame_2, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_3, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 2) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 2 HEARTS TOTAL *****");
    $hearts_sched_2a = % hearts_name.schedule(0, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1a = % hearts_name.schedule( % time_frame_1, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_2, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 1) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 1 HEARTS TOTAL *****");
    $hearts_sched_1a = % hearts_name.schedule(0, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0a = % hearts_name.schedule( % time_frame_1, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space1.hard_paused == 1 & hearts_1.in_cell == 0) {
    echo("***** HEARTS VIA CHAR 1 HARD_PAUSE, 0 HEARTS TOTAL *****");
    $hearts_sched_0a = % hearts_name.schedule(0, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

  }
  if ( % this_char_num == 2) {
   if (empty_char_space2.hard_paused != 1) {
    $hearts_sched_5b = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4b = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3b = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2b = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1b = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   //edit 02-27-2014 double spawning occurs so losing this part

   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 5) {
    $hearts_sched_5b = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4b = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3b = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2b = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1b = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 4) {
    $hearts_sched_4b = % hearts_name.schedule(0, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3b = % hearts_name.schedule( % time_frame_1, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2b = % hearts_name.schedule( % time_frame_2, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1b = % hearts_name.schedule( % time_frame_3, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_4, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 3) {
    $hearts_sched_3b = % hearts_name.schedule(0, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2b = % hearts_name.schedule( % time_frame_1, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1b = % hearts_name.schedule( % time_frame_2, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_3, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 2) {
    $hearts_sched_2b = % hearts_name.schedule(0, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1b = % hearts_name.schedule( % time_frame_1, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_2, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 1) {
    $hearts_sched_1b = % hearts_name.schedule(0, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0b = % hearts_name.schedule( % time_frame_1, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space2.hard_paused == 1 & hearts_2.in_cell == 0) {
    $hearts_sched_0b = % hearts_name.schedule(0, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

  }
  if ( % this_char_num == 3) {
   if (empty_char_space3.hard_paused != 1) {
    $hearts_sched_5c = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4c = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3c = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2c = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1c = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   //edit 02-27-2014 double spawning occurs so losing this part

   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 5) {
    $hearts_sched_5c = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4c = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3c = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2c = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1c = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 4) {
    $hearts_sched_4c = % hearts_name.schedule(0, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3c = % hearts_name.schedule( % time_frame_1, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2c = % hearts_name.schedule( % time_frame_2, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1c = % hearts_name.schedule( % time_frame_3, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_4, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 3) {
    $hearts_sched_3c = % hearts_name.schedule(0, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2c = % hearts_name.schedule( % time_frame_1, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1c = % hearts_name.schedule( % time_frame_2, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_3, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 2) {
    $hearts_sched_2c = % hearts_name.schedule(0, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1c = % hearts_name.schedule( % time_frame_1, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_2, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 1) {
    $hearts_sched_1c = % hearts_name.schedule(0, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_1, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space3.hard_paused == 1 & hearts_3.in_cell == 0) {
    $hearts_sched_0c = % hearts_name.schedule( % time_frame_1, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
  }
  if ( % this_char_num == 4) {
   if (empty_char_space4.hard_paused != 1) {
    $hearts_sched_5d = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4d = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3d = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2d = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1d = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   //edit 02-27-2014 double spawning occurs so losing this part

   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 5) {
    $hearts_sched_5d = % hearts_name.schedule(0, "five_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_4d = % hearts_name.schedule( % time_frame_1, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3d = % hearts_name.schedule( % time_frame_2, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2d = % hearts_name.schedule( % time_frame_3, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1d = % hearts_name.schedule( % time_frame_4, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_5, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }

   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 4) {
    $hearts_sched_4d = % hearts_name.schedule(0, "four_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_3d = % hearts_name.schedule( % time_frame_1, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2d = % hearts_name.schedule( % time_frame_2, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1d = % hearts_name.schedule( % time_frame_3, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_4, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 3) {
    $hearts_sched_3d = % hearts_name.schedule(0, "three_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_2d = % hearts_name.schedule( % time_frame_1, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1d = % hearts_name.schedule( % time_frame_2, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_3, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 2) {
    $hearts_sched_2d = % hearts_name.schedule(0, "two_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_1d = % hearts_name.schedule( % time_frame_1, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_2, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 1) {
    $hearts_sched_1d = % hearts_name.schedule(0, "one_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version);
    $hearts_sched_0d = % hearts_name.schedule( % time_frame_1, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
   if (empty_char_space4.hard_paused == 1 & hearts_4.in_cell == 0) {
    $hearts_sched_0d = % hearts_name.schedule(0, "zero_hearts", % identify_this_time_space, % confirm_world_numeral, % confirm_round_numeral, % round_restart_toggle, % has_left_the_game_version); % hearts_name.setBlendAlpha(1);
   }
  }
 }


 if ( % this.hard_paused != 1) { 
 % make_unique_char_num_incase_special_chars = % this.seat_num;
  //edit 06-27-2014 if data gets lost, assume it's char1
  if ( % make_unique_char_num_incase_special_chars == 0) { 
  % make_unique_char_num_incase_special_chars = 1;
  }
  display_char_thingy.text = "-" @ % make_unique_char_num_incase_special_chars @ "-";
  //edit 01-02-2014 Spawning in special characters, eg. press, food inspector, etc
  //note it was 3 and 2 for prechosen
  if ($special_char_already_used != 1 & $spawn_special_character == 1 & $world_numeral == $prechosen_world_for_special_char & % this_char_num == $prechosen_seat_num_for_special_char & $toggle_off_special_char_for_round != 1) { 
   % make_unique_char_num_incase_special_chars = 5;
   $toggle_off_special_char_for_round = 1; 
   % find_mount_pos_x = ("mount_point" @ % this_char_num).getPositionX(); 
   % find_mount_pos_y = ("mount_point" @ % this_char_num).getPositionY(); 
   % new_customer_xpos = $xpos_customer[ % this_char_num]; 
   % new_customer_ypos = $ypos_customer[ % this_char_num]; 
   % reposition_customer_x = % find_mount_pos_x - % new_customer_xpos; 
   % reposition_customer_y = % find_mount_pos_y - % new_customer_ypos;

   special_character_hili.setPositionX( % reposition_customer_x);
   special_character_hili.setPositionY( % reposition_customer_y);
  }

  //07-26-2013 implementing star timer into new timing system
  % this_char_name.toggle_off_star_timer = 0;
  //edit 06-29-2014 found that this toggle needed to be enabled and then disabled			
  % this_char_name.green_light_star_timer = 1;
  //07-26-2013 added new if statement, implementing star timer into new timing system
  if ( % this_char_name.green_light_star_timer != 1) {
   $first_char_timing_activated = 0;
  }

  if ( % this_char_name.green_light_star_timer == 1) { 
   % this_char_name.schedule(0, "set_star_timer", 0); 
   % this_char_name.green_light_star_timer = 0;
   test_case1.text = "activated A1";
   //edit 07-11-2014 added to prevent dual scheduling of first char during certain starts
   $first_char_timing_activated = 1;
  }

  //echo(empty_char_space1.green_light_star_timer)
  % find_mount_pos_x = ("mount_point" @ % this_char_num).getPositionX(); 
  % find_mount_pos_y = ("mount_point" @ % this_char_num).getPositionY(); 
  % new_customer_xpos = $xpos_customer[ % this_char_num]; 
  % new_customer_ypos = $ypos_customer[ % this_char_num]; 
  % reposition_customer_x = % find_mount_pos_x - % new_customer_xpos; 
  % reposition_customer_y = % find_mount_pos_y - % new_customer_ypos; 
  % new_customer_width = $width_customer[ % make_unique_char_num_incase_special_chars]; 
  % new_customer_height = $height_customer[ % make_unique_char_num_incase_special_chars]; 
  % new_customer_idle_animation = $customer[ % make_unique_char_num_incase_special_chars] @ "_idleAnimation"; 
  % this_char_name.setPositionX( % reposition_customer_x); % this_char_name.setPositionY( % reposition_customer_y);
  //06-08-2013 Adding another star_timer resetter here to stymie any non-resetting of star_timer which seems to still creep up 
  % this_char_name.star_timer = 0; 
  % this_char_name.setAnimation( % new_customer_idle_animation); 
  % this_char_name.setSize( % new_customer_width, % new_customer_height);
  
  if ($toggle_custom_char1_spawn == 1) { 
   % new_customer_idle_animation = $customer1 @ "_idleAnimation"; 
   % new_customer_width = $width_customer1; 
   % new_customer_height = $height_customer1; 
   % new_customer_xpos = $xpos_customer1; 
   % new_customer_ypos = $ypos_customer1; 
   % this_char_name.setAnimation( % new_customer_idle_animation); 
   % this_char_name.setSize( % new_customer_width, % new_customer_height);
   $toggle_custom_char1_spawn = 0;
  } 
  % this_char_name.model_type = % this_char_num;

  //needs slight teleport in idle here
  ("obj_teleport" @ % this_char_num).setAnimation(teleportAnimation); 
  % mount_point_x = ("mount_point" @ % this_char_num).getPositionX(); 
  % mount_point_y = ("mount_point" @ % this_char_num).getPositionY();
  ("obj_teleport" @ % this_char_num).setPositionX( % mount_point_x);
  ("obj_teleport" @ % this_char_num).setPositionY( % mount_point_y - 13);
  echo("ONLY TIME BASIC IDLE ANIMATION SHOULD BE CALLED");

  % this_char_name.occupied = 1; 
  % this_char_name.cease_infinite_spawn = 0;
  //edit 01-28-2013 to see if this affects anger time settings to B more than A
  % this_char_name.set_anger_time( % this);
  //spawn yellow exclamation
  % icon_exclame_num = % this_char_name.seat_num; 
  % icon_exclame_name = "icon_exclame" @ % icon_exclame_num; 
  % this_char_x = % this_char_name.getPositionX(); 
  % this_char_y = % this_char_name.getPositionY(); 
  % char_reset_pos_x = % this_char_x + 1; 
  % char_reset_pos_y = % this_char_y - 10; 
  % icon_exclame_name.setPositionX( % char_reset_pos_x); 
  % icon_exclame_name.setPositionY( % char_reset_pos_y); 
  % icon_exclame_name.setAnimation(icon_exclame_yellowAnimation); 
  % icon_exclame_name.setSize(4.199, 5.371); 
  % this_char_name.is_despawned = 0; 
  % this_char_name.clickable = 1;
  //edit 05-20-2013 star_timer resetter at spawn
  % this_char_name.star_timer = 0; 
  % this.anger_check = 0;

 } 
 % this.hard_paused = 0;
}

function char_button::delete_old_data( % this) { 
% this_char_name = % this.seat_name; 
% this_char_num = % this.seat_num;
% this_char_name.clickable = 0; 
% this_char_name.displaying_wants = 0; 
% this_char_name.drink_requested = 0; 
% this_char_name.no_keep_gone_command = 0;
echo("\c2 Deleted old data for" @ % this.seat_name);
}

function char_button::undelay_any_reteleports( % this) { 
% this_char_name = % this.seat_name; 
% this_char_num = % this.seat_num; 
% this_char_name.keep_me_gone_longer = 0;
echo("\c2 Keep Me Gone Longer Ended for" @ % this.seat_name);
}

function char_button::star_spawner_gold( % this) {
 star_empty_space.setAnimation(icon_star_goldAnimation);
}

function char_button::star_spawner_silver( % this) {
 star_empty_space.setAnimation(icon_star_silverAnimation);
}

function char_button::star_spawner_bronze( % this) {
 star_empty_space.setAnimation(icon_star_bronzeAnimation);
}

function char_button::point_spawner_30( % this) {
 point_up_empty_space.setAnimation(fx_point_up3bAnimation);
}

function char_button::point_spawner_20( % this) {
 point_up_empty_space.setAnimation(fx_point_up2bAnimation);
}

function char_button::point_spawner_10( % this) {
 point_up_empty_space.setAnimation(fx_point_up1bAnimation);
}

//For trophies
function char_button::retime_individual_char( % this) {
 //trophy speedster: order taker
 $individualized_char_timer += 1;
 char_time_blahh.text = $individualized_char_timer;
 status_checker3.text = $individualized_char_timer;
 if ( % this.seat_num != 1) {
  if ($deactivate_speedster_order_taker_trophy == 0 & $individualized_char_timer <= 29 & $trophy_toggle_off_button5 != 1) {
   $root_trophy_identfier = "button5";
   win_this_trophy();
   $trophy_toggle_off_button5 = 1;
  }
 } 
 % this.schedule(100, "retime_individual_char", 0);
 $restart_timer_for_individual_char = 0;
}