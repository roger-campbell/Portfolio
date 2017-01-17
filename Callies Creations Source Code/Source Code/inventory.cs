// ***************************************************************************************
// File Name:   inventory.cs
// Author:      Roger Campbell 
// Purpose:     Inventory of all global attributes for the game
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

//console cheat for stopping audio
function shh()
{
	alxStopAll();
}

$enable_red_x = 1;

$horizontal_scaling = 100;
$GAME_HAS_NEVER_BEEN_STARTED = 1;
$end_the_clock = 0;
$debug_mode_on = 0;
$initialize_bonus_portals_to_appear_random = 1;

$inv_apple = 10;
$inv_cherry = 10;
$inv_strawberry = 10;
$inv_orange = 10;
$inv_peach = 10;
$inv_mango = 10;
$inv_banana = 10;
$inv_lemon = 10;
$inv_pineapple = 10;
$inv_lime = 10;
$inv_pear = 10;
$inv_kiwi = 10;
$inv_blueberry = 10;
$inv_currant = 10;
$inv_plum = 10;
$inv_grapes = 10;
$inv_blackberry = 10;
$inv_fig = 10;

/* appetizer prices */
$current_bite_rate_for_world0 = 19;
$current_bite_rate_for_world1 = 19;
$current_bite_rate_for_world2 = 29;
$current_bite_rate_for_world3 = 39;
$current_bite_rate_for_world4 = 49;
$current_bite_rate_for_world5 = 54;
$current_bite_rate_for_world6 = 64;
$current_bite_rate_for_world7 = 72;
$current_bite_rate_for_world8 = 81;
$current_bite_rate_for_world9 = 91;
$current_bite_rate_for_world10 = 100;
$current_bite_rate_for_world11 = 100;

$current_bev_rate_for_world0 = 34;
$current_bev_rate_for_world1 = 34;
$current_bev_rate_for_world2 = 44;
$current_bev_rate_for_world3 = 54;
$current_bev_rate_for_world4 = 64;
$current_bev_rate_for_world5 = 75;
$current_bev_rate_for_world6 = 85;
$current_bev_rate_for_world7 = 86;
$current_bev_rate_for_world8 = 97;
$current_bev_rate_for_world9 = 99;
$current_bev_rate_for_world10 = 110;
$current_bev_rate_for_world11 = 110;

/* appetizer amounts */
$appetizer_default_amount = 4;
//$appetizer1_amount0 = 10;
$appetizer1_amount1 = $appetizer_default_amount;
$appetizer1_amount2 = $appetizer_default_amount;
$appetizer1_amount3 = $appetizer_default_amount;
$appetizer1_amount4 = $appetizer_default_amount;
$appetizer1_amount5 = $appetizer_default_amount;
$appetizer1_amount6 = $appetizer_default_amount;
$appetizer1_amount7 = $appetizer_default_amount;
$appetizer1_amount8 = $appetizer_default_amount;
$appetizer1_amount9 = $appetizer_default_amount;
$appetizer1_amount10 = $appetizer_default_amount;

//$appetizer2_amount0 = 10;
$appetizer2_amount1 = $appetizer_default_amount;
$appetizer2_amount2 = $appetizer_default_amount;
$appetizer2_amount3 = $appetizer_default_amount;
$appetizer2_amount4 = $appetizer_default_amount;
$appetizer2_amount5 = $appetizer_default_amount;
$appetizer2_amount6 = $appetizer_default_amount;
$appetizer2_amount7 = $appetizer_default_amount;
$appetizer2_amount8 = $appetizer_default_amount;
$appetizer2_amount9 = $appetizer_default_amount;
$appetizer2_amount10 = $appetizer_default_amount;

/* bank */
$bank_amount = 0;
$coinage = 0;
$points_amount = 0;
$points_number_x = points_number.getPositionX();
$points_number_y = points_number.getPositionY();
//cheat $coinage += 80;
$coinage_max = 120;
$current_level = 1;
$round_numeral = 1;
$world_numeral = 1;
$total_rounds_per_world = 11;
$game_text_block_identifier = 0;

/* Profiler */
$input_to_profile_slot = 0;
$profile_has_been_moused_down = 0;
$bob_test = "default_profile";
$key_down_toggled = 0;
$new_string = "";
$back_spaced_toggled = 0;
$disallow_leaving_profile_menu_until_choose_new_slot = 0;
$check_string_length = 0;
$profile_char_limit = 11;
$slot_zero_active = 0;
$toggle_slot_zero_clearer = 0;
$pre_done_button_toggle = 0;
$toggle_custom_char1_spawn = 0;
$first_profile_slot_ever_pressed = 99;
$first_ever_text_length = 0;
$stop_pre_done_button_from_continuing = 0;
$first_game_ever_played_predetected = 0;
$no_blinky_underscore = 0;

$lock_map_buttons_until_released = 0;
$map_dot_iterater = 0;
$map_dot_max = 0;
$total_map_dots_max = 48;
$allow_clicking_on_map = 0;
which_allow.text = 999;
$toggle_from_map_button = 0;
//Character Information
//$character_
$toggled_screen = 0;

//World declaration-death data
$world_numeral = 1;
$world_ended = 0;
$waiter_waiting_for_old_world_data_to_die = 0;

$deactivate_all_clear_profilers = 1;
$start_button_was_pressed = 0;

$already_blinking_profile = 0;
$current_blinky_slot = "no_profile_slot";
$clicked_down_on_a_profile = 0;
$key_down_on_a_profile = 0;
$new_profile_text = "NEW PROFILE";
$old_profile_state = 1;
$capture_this_only_once_per_session = 0;
$function_killer = 0;

/* audio */
$music_level = 1;
$sfx_level = 1;

/* Options Menu Related */
$make_start_button_into_continue = 0;
$via_main_menu = 0;
$via_ingame = 0;

$widget1_x = 117.772;
$widget1_y = -11.597;
$widget2_x = 117.772;
$widget2_y = -5.321;
$widget3_x = 103.604;
$widget3_y = 0.765;

$activate_scrolling = 0;
$activate_scrolling2 = 0;
$activate_scrolling3 = 0;

$toggle_mm_buttons_off = 0;
$options_location = 0;

//06-25-2013 retrofitting sliders to timed buttons
$soundfx_loudness = 99;
$music_loudness = 99;
$difficulty_level = 1;

$minus_soundfx_stopped = 1;
$minus_soundfx_deca_accelerate = 0;
$plus_soundfx_stopped = 1;
$plus_soundfx_deca_accelerate = 0;

$minus_music_stopped = 1;
$minus_music_deca_accelerate = 0;
$plus_music_stopped = 1;
$plus_music_deca_accelerate = 0;

$minus_difficulty_stopped = 1;
$minus_difficulty_deca_accelerate = 0;
$plus_difficulty_stopped = 1;
$plus_difficulty_deca_accelerate = 0;

/* Level FX Related */
$lvl1_light_alpha = 0;
$lvl1_delay_toggled = 0;
$lvl1b_light_alpha = 0;
$lvl1b_delay_toggled = 0;
$lvl1c_light_alpha = 0;
$lvl1c_delay_toggled = 0;
$shore_speed_test = 5;
$shorebreak_iterator = 0;
$keep_shorebreak_moving = 0;
$toggle_on_combo_anim = 0;
$total_combo_level = 0;
$toggle_combo_fade = 0;
$combo_animater_alpha = 1;

$cue_tab1_alpha = 1;
$toggle_cue_tab1_fade = 0;
$cue_tab1_alpha_b = 1;
$toggle_cue_tab1_fade_b = 0;

$start_prestart_fader = 1;
$prestart_fader_alpha_level = 0;
$cease_prestart_fader = 1;
$toggle_delay_the_tutorial = 0;

$suspend_callie = 0;

$animate_bonus_once = 0;

$new_level_so_reset_combos_to_none = 1;

//sodajerks-cooks
$cook_redness1 = 0.98;
$cook_is_red_because_zero1 = 1;
$cook_red_stop1 = 0;

$cook_redness2 = 0.98;
$cook_is_red_because_zero2 = 1;
$cook_red_stop2 = 0;

$cook_redness3 = 0.98;
$cook_is_red_because_zero3 = 1;
$cook_red_stop3 = 0;

$cook_redness4 = 0.98;
$cook_is_red_because_zero4 = 1;
$cook_red_stop4 = 0;

$activate_callie_777 = 0;

$last_levsel_click_was = 0;

/* Misc */
$coin_tip_disable_all_clicking_until_reaches_end_of_the_function_first = 0;
$globalize_new_precorded_char_number = 9999;
$waiter_is_already_collecting_tips = 0;
$halt_post_storyboard_adjustments = 0;
$storyboard_custom_intro_castle_switch = 0;
$transitioning_from_skip_button = 0;
$stop_mass_clicking_last_tip_case_scenario = 0;
$cooks_current_world1 = 999;
$cooks_current_world2 = 999;
$cooks_current_world3 = 999;
$cooks_current_world4 = 999;
$currently_between_levels = 0;
$reset_star_value_for_init_char1 = 0;
$cheat_to_world = 2;
$cheating_to_level_10 = 0;
$clean_up_in_progress_so_skip_the_map = 0;
$activate_char_from_drink_out = 0;
$stall_map_related_mouseups = 0;
echo("-X-X-X-X-X-X-X-X-X-X-x-x-X-x-x-x-x-X-x : ANGER AMT COUNTER 3: X-X-X-X_X_X-X-X-x-X_X_X_x-x_X_X_X_X_X_X_-x-X-X_-x_X_XX_-x-xX");	
$anger_amount_counter = 0;
$round_restart_switch = 0;
$check_cue_number = 0;
$disable_all_shorebreaks = 0;
$first_game_ever_ever = 0;
//$appetizer1_amount1 = 10;
//$appetizer2_amount1 = 10;

/* Trophies */
$find_chars_served = 0;
$toggle_trophy_start = 0;
$toggle_trophy_end = 0;

$trophy_dollar_collected = 0;
$trophy_all_gold_in_round = 0;
$trophy_angered_a_customer = 0;
$trophy_no_angry_customers = 0;
$in_between_levels_trophy_protect = 0;
$trophy_toggle_off_all_gold_in_round = 0;
$trophy_toggle_off_mount1 = 0;
$end_trophy_trophy4 = 0;
$trophy_toggle_off_button1 = 0;
$end_trophy_trophy5 = 0;
$trophy_toggle_off_trophy1 = 0;
$trophy_toggle_off_button4 = 0;
$restart_timer_for_individual_char = 0;
$individualized_char_timer = 0;
$trophy_toggle_off_button5 = 0;
$trophy_toggle_off_button2 = 0;
$trophy_toggle_off_mount2 = 0;
$toggle_customers_served_counter = 0;
$trophy_toggle_off_trophy6 = 0;
$trophy_toggle_off_trophy7 = 0;
$trophy_toggle_off_trophy8 = 0;
$trophy_toggle_off_ribbon6 = 0;

$temp_trophy_opacity = 0;
$coin_tips_per_round_collected = 0;
$deactivate_speedster_order_taker_trophy = 0;
$flying_coins_collected = 0; 
$vortexes_collected = 0;
$total_appetizers_collected = 0;

$trophy_toggle_off_plaque1 = 0;
$trophy_toggle_off_plaque2 = 0;
$trophy_toggle_off_plaque3 = 0;
$trophy_toggle_off_plaque4 = 0;
$trophy_toggle_off_plaque5 = 0;
$trophy_toggle_off_plaque6 = 0;
$trophy_toggle_off_plaque7 = 0;
$trophy_toggle_off_plaque8 = 0;
$trophy_toggle_off_plaque9 = 0;
$trophy_toggle_off_plaque10 = 0;

$end_trophy_ribbon1 = 0;
$end_trophy_ribbon2 = 0;
$end_trophy_ribbon3 = 0;
$end_trophy_ribbon4 = 0;
$end_trophy_ribbon5 = 0;

$mega_manager_counter = 0;
$customers_served_counter = 0;

$au_alpha_already_up = 0;
$au_alpha_already_down = 0;
$au_alpha_already_up_set_zero = 0;

//trophy data is dynamic and can be listed but I don't want to
//on account that it saves at least 120 lines of space

$touchpad_activated = 0;

/* Game Clock */
$THE_GAME_IS_PAUSED = 0;

$lock_game_clock = 0;
$game_clock_number = 0;
//minimum speed
$game_clock_limit = 40000;
$game_clock_limit_01 = 40000;
$game_clock_limit_02 = 38000;
$game_clock_limit_03 = 36000;
$game_clock_limit_04 = 34000;
$game_clock_limit_05 = 33000;
$game_clock_limit_06 = 33000;
$game_clock_limit_07 = 33000;
$game_clock_limit_08 = 33000;
$game_clock_limit_09 = 33000;
$game_clock_limit_10 = 33000;

$points_you_have = 0;
$points_you_need = 250;

$start_game_time_only_once = 0;

//maximum speed
//$game_clock_limit = 15000;
$toggle_initial_spawner_via_clock = 0;
$game_has_started_for_clock = 0;
$do_not_animate_teleport = 0;
$whole_round_clock = 0;
$game_is_hard_paused = 0;

/* Special Character */
$spawn_special_character = 0;
$disable_special_char = 0;

/* Tutorial */
$isolater_mask_spawn_once_only = 0;
$tut_yes_is_active = 0;
$lock_down_isolater_mask_part_i_to_ii = 0;
$toggle_off_alpha_in = 0;
$toggle_off_fade_out_one_and_part_two_in = 0;
$disable_ui_and_rgbp_swap = 0;
$tutorial_activate_cook_sequence = 0;
$activate_tutorial_serve_char_sequence = 0;
$tutorial_activate_tip_sequence = 0;
$activate_tutorial_cointip = 0;
$activate_tut_cointip_portion = 0;
$toggle_off_default_tut_statement = 0;
$tutorial_activate_extra_sequence = 0;
$tut_char_fruit_choices = 0;
$tut_go_to_fruits = 0;
$cease_masking_of_dial = 0;
$skip_the_rest_of_this_because_tutorial = 0;
$tutorial_end_fading_bs = 0;
$end_the_tutorial = 0;
$tut_text_alpha = 1;
$until_tut_char_is_activated_dont_do_fruits = 0;
$tut_make_cancelling_impossible = 0;
$toggle_tut_appetizer = 0;
$lock_down_retoggling_during_tutorial = 0;
$disable_all_clicks_of_chars_via_tutorial = 0;
$its_okay_to_click_tutchar1 = 0;
$toggle_off_orange_fruit_for_tut = 0;
$toggle_off_yellow_fruit_for_tut = 0;
$tut_make_reclicking_drink_out_impossible = 0;
$tut_coin_tip_override = 0;
$tut_toggle_off_drink_out = 0;
$disable_all_remaining_fruit_ui = 0;
$tut_toggle_off_cook = 0;
$tut_iterate_yellow = 0;
$tut_iterate_orange = 0;
$tut_iterate_red = 0;
$tut_iterate_green = 0;
$disable_tut_red_part = 0;
$disable_tut_green_part = 0;
$completely_unlock_first_fruit_iterator = 0;
$completely_unlock_second_fruit_iterator = 0;
$unlock_subtle_red_mouseover = 0;
$tutorial_popup_officially_ended_via_yes_or_no = 0;
$wait_for_tut_drink_out_fader_to_finish = 0;
$tut_fade_maximum = 0.5;
$disable_tutorial_clicker = 0;
$disable_reenabling_pointer_clicker_red = 0;
$disable_reenabling_pointer_clicker_green = 0;
$make_cherry_the_only_pickable_fruit = 0;
$make_kiwi_the_only_pickable_fruit = 0;	
$lock_the_cook_for_tutorial = 0;
$activate_continuing_tutorial = 0;
$lock_down_first_fruit_iterator = 0;
$hint_bonus1_disabled = 0;
$hint_bonus2_disabled = 0;
$hint_bonus3_disabled = 0;
$temporarily_disable_ingame_options_before_tutorial = 0;
$cancel_event_shittt = 0;
$do_final_tutorial_part_only_once = 0;
$tut_new_revised = 0;
$end_previous_non_new_tut_bits = 0;
$tut_appetizer1_active = 0;
$tut_appetizer1_clicked = 0;
$tut_very_last_char_clicked = 0;
$tut_toggle_new_appetizer = 0;
$tut_appetizers_part_b = 0;
$tut_very_last_part = 0;
$tut_very_last_part_completely = 0;

/* Tutorial Extended */
$toggle_off_om_appetizer_buttons_because_tut_ext = 0;
$toggle_off_om_awards_button_because_tut_ext = 0;	
$toggle_off_om_map_button_because_tut_ext = 0;
$toggle_off_om_continue_button_because_tut_ext = 0;	
$toggle_off_button_levsel_menu_because_tut_ext = 0;
$toggle_off_button_levsel_map_because_tut_ext = 0;
$tut_ext_segment = 0;
$tutorial_cue_tab_control = 0;

/* Bonus Animations */
$bonus_portal_active1 = 0;
$bonus_portal_active2 = 0;
$bonus_portal_active3 = 0;
$bonus_portal_active4 = 0;

$flying_coin_init = 1;
$flying_coin_active = 0;

$left_the_level_space = 0;

comptroller.identify_bonus_time_space = 0;

/* Main Menu Animations */
$toggle_off_main_menu_bkgd_on_mouse_move = 0;
$main_menu_animation_timer = 0;
$toggle_world = 1;
$mm_start_completed = 0;
$mm_options_completed = 0;
$mm_exit_completed = 0;
$mm_profile_completed = 0;

/* star and point animation sizes */
//$star_size_x = 4.199;
//$star_size_y = 5.371;
//$point_up_size_x = 3.320;
//$point_up_size_y = 5.859;

/* Music and Themes */
$default_audio = "poop";
$mute_music = 0;
$mute_soundfx = 0;
$toggle_mute_music = 0;
$default_music = "castle_theme";
$world_audio = "castle_theme";

/* Bitmap Font Formation */
$prev_char = 0;
$on_current_character = 0;
$position_enumerator = 0;
$text_starting_frame = 32;
$iterate_through_char_map = 0;
$all_characters_printed = 0;
$delete_enumerator = 0;
$storyboard_base_identifier = "error_no_world";
$char_line_on = 0;
$what_char = 0;
$integer_conversion = 0;
$redefine_y = 0;
$old_text_length = 0;
$uninterrupted_iterator = 0;
$recast_deletion_number = 0;

/* Level Select */
$maximum_world_player_got_to = 1;
$maximum_level_player_got_to = 1;
$timeless_world_numeral = 0;
$toggle_off_go_to_specific_level = 0;
$alert_levsel_bypass = 0;
$toggle_off_transitioning_screens = 0;
$iterate_through_level_select_buttons = 0;
$no_clicking_levsel_buttons = 0;
$delay_mouseup_of_levsel_buttons = 0;
$iterate_through_locked_select_buttons = 0;
$iterate_through_world_icons = 0;
$bypass_mapsel_to_levsel = 0;
$delay_storyboard_stuff = 0;
$the_current_world = 1;
$relocking_start_number = 0;

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

/* MUSIC ADJUSTMENTS */
$default_audio1 = "castle_theme";
$default_audio2 = "swamp_theme";
$default_audio3 = "airship_theme";
$default_audio4 = "hawaii_theme";
$default_audio5 = "viking_theme";
$default_audio6 = "forest_theme";
$default_audio7 = "train_theme";
$default_audio8 = "france_theme";
$default_audio9 = "newyork_theme";
$default_audio10 = "hometown_theme";

/* LEVEL STAR SYSTEM */
//every 10 is a new world, ^ starts at level 1 of new world
//----------------------------------------^-------------------^-------------------^-------------------^-------------------^-------------------^-------------------^-------------------^-------------------^-------------------^ <(11)
$star_system_array = "0 0 0 0 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0";
$input_ss_level_num = 1;
$star_sys_cleared = 0;
$star_sys_medal_won = 979;
$declare_star_sys_data_for_level_use_counter = 0;
coin_me_up.record_me = 0;


/* LEVEL FAILS-SPECIALS */
$game_fail_number_preset = 0;
$special_record_points_at_round_start = 0;
$special_record_coins_at_round_start = 0;
$toggle_off_special_char_for_round = 0;
$toggle_off_model5_via_drink_vers1 = 0;
$toggle_off_model5_via_drink_vers2 = 0;
$toggle_off_model5_via_wait = 0;
$special_dialog_identifier = 0;

/* HELP MENUS */
$find_sub_menu = 0;
$hide_help_menu_back = 0;
$hide_help_menu_more = 0;

/* CURSOR STATES */
$toggle_serve_cursor = 0;
$toggle_toss_cursor = 0;
$toggle_dirty_cursor = 0;
$toggle_cursor_is_serving = 0;

/* HEARTS */
$hearts_scheduled1 = 0;
$hearts_scheduled2 = 0;
$hearts_scheduled3 = 0;
$hearts_scheduled4 = 0;

/* EMPLOYEES */
$employee_alpha1_world1 = 0;
$employee_alpha2_world1 = 0;
$employee_alpha1_world2 = 0;
$employee_alpha2_world2 = 0;
$employee_alpha1_world3 = 0;
$employee_alpha2_world3 = 0;
$employee_alpha1_world4 = 0;
$employee_alpha2_world4 = 0;
$employee_alpha1_world5 = 0;
$employee_alpha2_world5 = 0;
$employee_alpha1_world6 = 0;
$employee_alpha2_world6 = 0;
$employee_alpha1_world7 = 0;
$employee_alpha2_world7 = 0;
$employee_alpha1_world8 = 0;
$employee_alpha2_world8 = 0;
$employee_alpha1_world9 = 0;
$employee_alpha2_world9 = 0;
$employee_alpha1_world10 = 0;
$employee_alpha2_world10 = 0;

$entertainer1_price_world1 = 840;
$entertainer2_price_world1 = 1120;
$entertainer1_price_world2 = 1685;
$entertainer2_price_world2 = 1965;
$entertainer1_price_world3 = 1685;
$entertainer2_price_world3 = 1965;
$entertainer1_price_world4 = 1695;
$entertainer2_price_world4 = 1975;
$entertainer1_price_world5 = 1705;
$entertainer2_price_world5 = 1975;
$entertainer1_price_world6 = 1715;
$entertainer2_price_world6 = 1985;
$entertainer1_price_world7 = 1715;
$entertainer2_price_world7 = 1995;
$entertainer1_price_world8 = 1715;
$entertainer2_price_world8 = 2005;
$entertainer1_price_world9 = 1725;
$entertainer2_price_world9 = 2005;
$entertainer1_price_world10 = 1730;
$entertainer2_price_world10 = 2015;

$entertainer1_bought_world1 = 0;
$entertainer2_bought_world1 = 0;
$entertainer1_bought_world2 = 0;
$entertainer2_bought_world2 = 0;
$entertainer1_bought_world3 = 0;
$entertainer2_bought_world3 = 0;
$entertainer1_bought_world4 = 0;
$entertainer2_bought_world4 = 0;
$entertainer1_bought_world5 = 0;
$entertainer2_bought_world5 = 0;
$entertainer1_bought_world6 = 0;
$entertainer2_bought_world6 = 0;
$entertainer1_bought_world7 = 0;
$entertainer2_bought_world7 = 0;
$entertainer1_bought_world8 = 0;
$entertainer2_bought_world8 = 0;
$entertainer1_bought_world9 = 0;
$entertainer2_bought_world9 = 0;
$entertainer1_bought_world10 = 0;
$entertainer2_bought_world10 = 0;

function print_game_text()
{
//storyboard_text.font = "cambo";
$recast_deletion_number = $uninterrupted_iterator;
//storyboard_text.delete_old_text();

if($world_numeral == 1)
{
//note I am only calling storyboard_text because it'll automatically call all text via that or any other
//calling others to delete old text will result in duplicate process errors
//storyboard_text.delete_old_text();
storyboard_text.text = $storyboard_intro[$game_text_block_identifier];
storyboard_text2.text = $storyboard_introb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_introc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_introd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_introe[$game_text_block_identifier];

}
if($world_numeral == 2)
{
storyboard_text.text = $storyboard_swamp[$game_text_block_identifier];
storyboard_text2.text = $storyboard_swampb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_swampc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_swampd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_swampe[$game_text_block_identifier];
}
if($world_numeral == 3)
{
storyboard_text.text = $storyboard_airship[$game_text_block_identifier];
storyboard_text2.text = $storyboard_airshipb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_airshipc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_airshipd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_airshipe[$game_text_block_identifier];
}
if($world_numeral == 4)
{
storyboard_text.text = $storyboard_hawaii[$game_text_block_identifier];
storyboard_text2.text = $storyboard_hawaiib[$game_text_block_identifier];
storyboard_text3.text = $storyboard_hawaiic[$game_text_block_identifier];
storyboard_text4.text = $storyboard_hawaiid[$game_text_block_identifier];
storyboard_text5.text = $storyboard_hawaiie[$game_text_block_identifier];
}
if($world_numeral == 5)
{
storyboard_text.text = $storyboard_viking[$game_text_block_identifier];
storyboard_text2.text = $storyboard_vikingb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_vikingc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_vikingd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_vikinge[$game_text_block_identifier];
}
if($world_numeral == 6)
{
storyboard_text.text = $storyboard_haunted[$game_text_block_identifier];
storyboard_text2.text = $storyboard_hauntedb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_hauntedc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_hauntedd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_hauntede[$game_text_block_identifier];
}
if($world_numeral == 7)
{
storyboard_text.text = $storyboard_train[$game_text_block_identifier];
storyboard_text2.text = $storyboard_trainb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_trainc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_traind[$game_text_block_identifier];
storyboard_text5.text = $storyboard_traine[$game_text_block_identifier];
}
if($world_numeral == 8)
{
storyboard_text.text = $storyboard_france[$game_text_block_identifier];
storyboard_text2.text = $storyboard_franceb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_francec[$game_text_block_identifier];
storyboard_text4.text = $storyboard_franced[$game_text_block_identifier];
storyboard_text5.text = $storyboard_francee[$game_text_block_identifier];
}
if($world_numeral == 9)
{
storyboard_text.text = $storyboard_metro[$game_text_block_identifier];
storyboard_text2.text = $storyboard_metrob[$game_text_block_identifier];
storyboard_text3.text = $storyboard_metroc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_metrod[$game_text_block_identifier];
storyboard_text5.text = $storyboard_metroe[$game_text_block_identifier];
}
if($world_numeral == 10)
{
storyboard_text.text = $storyboard_hometown[$game_text_block_identifier];
storyboard_text2.text = $storyboard_hometownb[$game_text_block_identifier];
storyboard_text3.text = $storyboard_hometownc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_hometownd[$game_text_block_identifier];
storyboard_text5.text = $storyboard_hometowne[$game_text_block_identifier];
}
if($world_numeral == 11)
{
echo("TOUCHED UPON FINAL STORYBOARD STATEMENT");
storyboard_text.text = $storyboard_outro[$game_text_block_identifier];
storyboard_text2.text = $storyboard_outrob[$game_text_block_identifier];
storyboard_text3.text = $storyboard_outroc[$game_text_block_identifier];
storyboard_text4.text = $storyboard_outrod[$game_text_block_identifier];
storyboard_text5.text = $storyboard_outroe[$game_text_block_identifier];
}

}

function go_to_next_world()
{
//edit 09-15-2014 sometimes switching between storyboards levels and non-storyboard, after ordering drinks, causes drink and cook data from last profile to spill over
erase_usage_of_cooks();
	//edit 03-27-2014 Process time space to be able to better control scheduled events via level start
	//locals seem to get passed down one, so every next one equals the one before
	%identify_this_time_space = $world_numeral;
	%identify_this_time_space2 = $round_numeral;
	%identify_this_time_space3 = 0;
	//bonus_portal1.schedule(5000, "check_time_space", %identify_this_time_space);
	bonus_portal1.schedule(5000, "check_time_space", %identify_this_time_space, %identify_this_time_space2, %identify_this_time_space3);
	//%obj.schedule(100, "myMethodName", %param1, %param2, %paramEtc);
//edit 02-15-2014 adding checkers across all world numerals for correct appetizer prices
appetizer1_cost.text = $current_bite_rate_for_world[$world_numeral];
appetizer2_cost.text = $current_bev_rate_for_world[$world_numeral];
//edit 02-15-2014 hide parallax map depending on level
if($world_numeral != 3)
{
	sky_parallax_bg.setBlendAlpha(0);
}
if($world_numeral == 3)
{
	sky_parallax_bg.setBlendAlpha(1);
}
if($world_numeral != 4)
{
	$disable_all_shorebreaks = 1;
	$shore_speed_test = 0;	
	$fx_default_position_x = fx_image1.getPositionX();
	$fx_default_position_y = fx_image1.getPositionY();	
	fx_image1.moveTo($fx_default_position_x, $fx_default_position_y, 0, true, true, true, 0.1);
}
if($world_numeral == 4)
{
	$disable_all_shorebreaks = 0;
	$shore_speed_test = 5;
	$toggle_off_shorebreak = 0;
	$disable_all_shorebreaks = 0;
	$lvl1_light_alpha = 1;
	fx_image1.setBlendAlpha($lvl1_light_alpha);
}
//decide the rest of the game bitmaps per world

		drink_out1.active = 0;
		drink_out2.active = 0;
		drink_out3.active = 0;
		drink_out4.active = 0;
	if($world_numeral == 1)
	{
		cancel_any_lingering_fx();
		set_waiter_node_position();
		$points_you_need = 200;
		$game_clock_limit = $game_clock_limit_01;
		$default_audio = "castle_theme";
		$world_audio = "castle_theme";
		$map_dot_max = 0;
	
		//reset level fx to zero and start dynamic fading
		fx_image1.setBlendAlpha(0);
		fx_image2.setBlendAlpha(0);
		fx_image3.setBlendAlpha(1);		
		fx_image1.alpha_up();
		fx_image2.alpha_up();
		fx_image3.do_nothing();
	
		if($round_numeral != 1)
		{
		echo("END THE CLOCK VIA INVENTORY 1 ********************************************************************************************");
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		$customer2 = "char_king2";
		$customer1 = "char_queen3";
		$customer3 = "char_jester2";
		$customer4 = "char_knight2";
		$width_customer1 = 9.57;
		$width_customer2 = 9.57;
		$width_customer3 = 10.853;
		//$width_customer4 = 12.207;
		$height_customer1 = 16.895;
		$height_customer2 = 16.895;
		$height_customer3 = 12.207;
		//$height_customer4 = 16.016;
		$xpos_customer1 = -4.335;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.335;
		//$xpos_customer4 = -3.787;
		$ypos_customer1 = 8.117;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.117;
		//$ypos_customer4 = 10.163;	
		
		$width_customer4 = 11.816;
		$height_customer4 = 17.188;
		$xpos_customer4 = -4.695;
		$ypos_customer4 = 8.313;

		//World Data
		main_bg.setImageMap(bkgd_castle_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.022);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(26.065);		
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(19.0);
		
		//Extra People Data		
		extra_person1.setAnimation(lute_player_Playing3Animation);
		extra_person1.setPositionX(121.012);
		extra_person1.setPositionY(-19.674);
		extra_person1.setSize(9.57, 16.895);
		extra_person1.setLayer(17);	
		extra_person1.setFlipX(false);
		extra_person1.setBlendAlpha($employee_alpha1_world1);		
		
		extra_person2.setAnimation(char_jester_juggle4Animation);
		extra_person2.setPositionX(144.771);
		extra_person2.setPositionY(15.643);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);	
		extra_person2.setFlipX(false);		
		extra_person2.setBlendAlpha($employee_alpha2_world1);
		
		//FX Data
		fx_box1.setAnimation(env_torchAnimation);
		fx_box1.setPositionX(68.611);
		fx_box1.setPositionY(-19.892);
		fx_box1.setSize(5.859, 7.715);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);
		
		fx_box2.setAnimation(env_torchAnimation);
		fx_box2.setPositionX(80.847);
		fx_box2.setPositionY(-27.1);
		fx_box2.setSize(5.859, 7.715);
		fx_box2.setLayer(14);
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(env_torchAnimation);
		fx_box3.setPositionX(93.184);
		fx_box3.setPositionY(-34.35);
		fx_box3.setSize(5.859, 7.715);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);

		fx_box4.setAnimation(env_torchAnimation);
		fx_box4.setPositionX(145);
		fx_box4.setPositionY(-28.609);
		fx_box4.setSize(5.859, 7.715);
		fx_box4.setLayer(14);
		fx_box4.setFlipX(true);		
		
		fx_box5.setAnimation(empty_char_spaceAnimation);
		fx_box5.setPositionX(999);
		fx_box5.setPositionY(999);
		fx_box5.setSize(2.344, 2.441);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);		
		
		fx_box6.setAnimation(empty_char_spaceAnimation);
		fx_box6.setPositionX(999);
		fx_box6.setPositionY(999);
		fx_box6.setSize(2.344, 2.441);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		
		
		fx_box7.setAnimation(empty_char_spaceAnimation);
		fx_box7.setPositionX(999);
		fx_box7.setPositionY(999);
		fx_box7.setSize(2.344, 2.441);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(empty_char_spaceAnimation);
		fx_box8.setPositionX(999);
		fx_box8.setPositionY(999);
		fx_box8.setSize(2.344, 2.441);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(2.344, 2.441);
		fx_box9.setLayer(14);
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(2.344, 2.441);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);		
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(2.344, 2.441);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(2.344, 2.441);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);
		
		//image layers and fx
		
		fx_image1.setImageMap(fx_castle_castlightImageMap);
		fx_image1.setPositionX(126.766);
		fx_image1.setPositionY(-35.590);
		fx_image1.setSize(11.133, 15.137);
		fx_image1.setLayer(15);
		fx_image1.setFlipX(false);
		
		fx_image2.setImageMap(fx_castle_castlightImageMap);
		fx_image2.setPositionX(139.752);
		fx_image2.setPositionY(-27.746);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(15);	
		fx_image2.setFlipX(false);
		
		fx_image3.setImageMap(layer_arches);
		fx_image3.setPositionX(999.752);
		fx_image3.setPositionY(-27.746);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);	

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(19.823);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(19.0);		
	}
	
	if($world_numeral == 2)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();
	$points_you_need = 200;
	$game_clock_limit = $game_clock_limit_02;
	$default_audio = "swamp_theme";	
	$world_audio = "swamp_theme";
		$map_dot_max = 6;
	
		//level effects
		fx_image1.do_nothing();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
		
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_swamp_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}
		$customer1 = "char_witchdoctor";
		$customer2 = "char_swampwitch3";
		$customer3 = "char_crabfisher";
		$customer4 = "char_voodoodoll";
		$width_customer1 = 9.570;
		$width_customer2 = 11.816;
		$width_customer3 = 11.816;
		$width_customer4 = 11.816;
		$height_customer1 = 16.895;
		$height_customer2 = 17.188;
		$height_customer3 = 17.188;
		$height_customer4 = 17.188;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.695;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.695;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.313;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.313;	
		
		//World Data
		main_bg.setImageMap(bkgd_swamp_finalImageMap);
		
		//Appetizer Data
		echo("$appetizer1_purchased2 = " @ $appetizer1_purchased2);
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.022);
		appetizer2.setPositionX(109.2);
		appetizer2.setPositionY(26.065);		
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(19.0);
		
		//Extra People Data		
		extra_person1.setAnimation(banjo_player_playingAnimation);
		extra_person1.setPositionX(145.845);
		extra_person1.setPositionY(-13.816);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);	
		extra_person1.setFlipX(false);
		extra_person1.setBlendAlpha($employee_alpha1_world2);
		
		extra_person2.setAnimation(swamp_harmonica2Animation);
		extra_person2.setPositionX(148);
		extra_person2.setPositionY(-2);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);
		extra_person2.setFlipX(false);		
		extra_person2.setBlendAlpha($employee_alpha2_world2);
		
		//FX Data
		fx_box1.setAnimation(fx_candlelightAnimation);
		fx_box1.setPositionX(51.243);
		fx_box1.setPositionY(-18.668);
		fx_box1.setSize(2.344, 2.441);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);
		
		fx_box2.setAnimation(fx_candlelightAnimation);
		fx_box2.setPositionX(66.857);
		fx_box2.setPositionY(-27.062);
		fx_box2.setSize(2.344, 2.441);
		fx_box2.setLayer(14);		
		fx_box2.setFlipX(false);
		
		fx_box3.setAnimation(fx_candlelightAnimation);
		fx_box3.setPositionX(81.262);
		fx_box3.setPositionY(-34.562);
		fx_box3.setSize(2.344, 2.441);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(fx_candlelightAnimation);
		fx_box4.setPositionX(115.229);
		fx_box4.setPositionY(-30.698);
		fx_box4.setSize(2.344, 2.441);
		fx_box4.setLayer(14);	
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(fx_candlelightAnimation);
		fx_box5.setPositionX(137.690);
		fx_box5.setPositionY(-17.538);
		fx_box5.setSize(2.344, 2.441);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(fx_candlelightAnimation);
		fx_box6.setPositionX(146.294);
		fx_box6.setPositionY(11.552);
		fx_box6.setSize(2.344, 2.441);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(fx_candlelightAnimation);
		fx_box7.setPositionX(143.065);
		fx_box7.setPositionY(13.988);
		fx_box7.setSize(2.344, 2.441);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(fx_candlelightAnimation);
		fx_box8.setPositionX(127.366);
		fx_box8.setPositionY(24.247);
		fx_box8.setSize(2.344, 2.441);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(fx_candlelightAnimation);
		fx_box9.setPositionX(123.281);
		fx_box9.setPositionY(23.969);
		fx_box9.setSize(2.344, 2.441);
		fx_box9.setLayer(14);	
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(fx_croc_mouthAnimation);
		fx_box10.setPositionX(130.901);
		fx_box10.setPositionY(-33.516);
		fx_box10.setSize(16.406, 7.617);
		fx_box10.setLayer(18);
		fx_box10.setFlipX(true);
		
		fx_box11.setAnimation(fx_croc_mouthAnimation);
		fx_box11.setPositionX(133.143);
		fx_box11.setPositionY(-21.628);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(18);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(fx_croc_mouthAnimation);
		fx_box12.setPositionX(59.039);
		fx_box12.setPositionY(27.774);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(18);	
		fx_box12.setFlipX(false);
		obj_generic_caller.schedule(10, "set_custom_croc_anim", 0);
		//image layers and fx
		
		fx_image1.setImageMap(empty_coinImageMap);
		fx_image1.setPositionX(77);
		fx_image1.setPositionY(14.193);
		fx_image1.setSize(3.711, 7.813);
		fx_image1.setLayer(11);
		fx_image1.setFlipX(false);

		fx_image2.setImageMap(empty_coinImageMap);
		fx_image2.setPositionX(999);
		fx_image2.setPositionY(999);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(15);	
		fx_image2.setFlipX(false);
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(19.823);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(19.0);			
	}

	if($world_numeral == 3)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();
	$points_you_need = 250;
	$game_clock_limit = $game_clock_limit_03;
	/* AIRSHIP */
	$default_audio = "airship_theme";
	$world_audio = "airship_theme";	
	//$map_dot_max = 3;
	$map_dot_max = 9;
	
		//level effects
		fx_image1.do_nothing();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_airship_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}
		$customer1 = "char_baron";
		$customer2 = "char_victorianwoman";
		$customer3 = "char_victorianman2";
		$customer4 = "char_amelia";
		$width_customer1 = 11.816;
		$width_customer2 = 9.57;
		$width_customer3 = 11.816;
		$width_customer4 = 9.57;
		$height_customer1 = 17.188;
		$height_customer2 = 16.895;
		$height_customer3 = 17.188;
		$height_customer4 = 16.895;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.335;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.117;	
		
		//Special character : Press
		$customer5 = "char_press";
		$width_customer5 = 11.816;
		$height_customer5 = 17.188;
		$xpos_customer5 = -4.695;		
		$ypos_customer5 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_airship_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.5);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(25);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(110.7);
		appetizer2_amt_ingame.setPositionY(17.7);
		
		//Extra People Data		
		extra_person1.setAnimation(bellhop_bored2Animation);
		extra_person1.setPositionX(139.626);
		extra_person1.setPositionY(25);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);	
		extra_person1.setFlipX(false);
		extra_person1.setBlendAlpha($employee_alpha1_world3);
		
		extra_person2.setAnimation(employee_magician2Animation);
		extra_person2.setPositionX(83.961);
		extra_person2.setPositionY(-27.041);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);
		extra_person2.setFlipX(true);		
		extra_person2.setBlendAlpha($employee_alpha2_world3);
		
		//FX Data
		fx_box1.setAnimation(swinging_lampAnimation);
		fx_box1.setPositionX(104.943);
		fx_box1.setPositionY(-28.600);
		fx_box1.setSize(4.297, 8.008);
		fx_box1.setLayer(18);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(swinging_lampAnimation);
		fx_box2.setPositionX(122.595);
		fx_box2.setPositionY(-18.221);
		fx_box2.setSize(4.297, 8.008);
		fx_box2.setLayer(18);
		fx_box2.setFlipX(false);			
		
		fx_box3.setAnimation(fx_pulse_glowAnimation);
		fx_box3.setPositionX(104.860);
		fx_box3.setPositionY(-27.931);
		fx_box3.setSize(5.762, 5.566);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);			

		fx_box4.setAnimation(fx_pulse_glowAnimation);
		fx_box4.setPositionX(122.521);
		fx_box4.setPositionY(-17.594);
		fx_box4.setSize(5.762, 5.566);
		fx_box4.setLayer(14);
		fx_box4.setFlipX(false);			
		
		fx_box5.setAnimation(fx_propeller1Animation);
		fx_box5.setPositionX(65.042);
		fx_box5.setPositionY(30.277);
		fx_box5.setSize(30.078, 14.453);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);			

		fx_box6.setAnimation(fx_propeller2Animation);
		fx_box6.setPositionX(141.837);
		fx_box6.setPositionY(-18.549);
		fx_box6.setSize(13.379, 17.383);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);			

		fx_box7.setAnimation(fx_engine1Animation);
		fx_box7.setPositionX(126.667);
		fx_box7.setPositionY(18.014);
		fx_box7.setSize(20.898, 18.848);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);			
		
		fx_box8.setAnimation(fx_pulse_glowAnimation);
		fx_box8.setPositionX(75.151);
		fx_box8.setPositionY(15.230);
		fx_box8.setSize(5.762, 5.566);
		fx_box8.setLayer(10);
		fx_box8.setFlipX(false);			

		fx_box9.setAnimation(airship_conductorAnimation);
		fx_box9.setPositionX(61.620);
		fx_box9.setPositionY(-21.4);
		fx_box9.setSize(11.816, 17.188);
		fx_box9.setLayer(17);
		fx_box9.setFlipX(true);
	
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(16.406, 7.617);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);			
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);			

		//image layers and fx
		
		fx_image1.setImageMap(empty_coinImageMap);
		fx_image1.setPositionX(75.231);
		fx_image1.setPositionY(14.193);
		fx_image1.setSize(3.711, 7.813);
		fx_image1.setLayer(11);
		fx_image1.setFlipX(false);			

		fx_image2.setImageMap(empty_coinImageMap);
		fx_image2.setPositionX(999);
		fx_image2.setPositionY(999);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(15);	
		fx_image2.setFlipX(false);		
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);		

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(111);
		appetizer_tab_float2.setPositionY(18.5);		

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(110.7);
		appetizer2_amt_ingame.setPositionY(17.7);			
	}		
	
	if($world_numeral == 4)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();
	way_point1.setPositionX(104.301);
	way_point1.setPositionY(23);
	$points_you_need = 300;
	$game_clock_limit = $game_clock_limit_04;
	/* HAWAII */
	$default_audio = "hawaii_theme";
	$world_audio = "hawaii_theme";		
	//$map_dot_max = 4;
	$map_dot_max = 13;
	
		//level effects
		//fx_image1.shorebreak_in();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_hawaii_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_hulagirl3";
		$customer2 = "char_tourist";
		$customer3 = "char_hawaiiwarrior";
		$customer4 = "char_tiki";
		$width_customer1 = 9.57;
		$width_customer2 = 11.816;
		$width_customer3 = 9.57;
		$width_customer4 = 9.57;
		$height_customer1 = 16.895;
		$height_customer2 = 17.188;
		$height_customer3 = 16.895;
		$height_customer4 = 16.895;
		$xpos_customer1 = -4.335;
		$xpos_customer2 = -4.695;
		$xpos_customer3 = -4.335;
		$xpos_customer4 = -4.335;
		$ypos_customer1 = 8.117;
		$ypos_customer2 = 8.313;
		$ypos_customer3 = 8.117;
		$ypos_customer4 = 8.117;
		
		//Special character : Elvis
		$customer5 = "char_elvis";
		$width_customer5 = 11.816;
		$height_customer5 = 17.188;
		$xpos_customer5 = -4.695;		
		$ypos_customer5 = 8.313;	
		
		//World Data
		main_bg.setImageMap(bkgd_hawaii_final2ImageMap);

		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.022);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(26.065);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);
		
		//Extra People Data		
		extra_person1.setAnimation(hula_dancer4Animation);
		extra_person1.setPositionX(129.568);
		extra_person1.setPositionY(-24.213);
		extra_person1.setSize(9.570, 16.895);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(false);		
		extra_person1.setBlendAlpha($employee_alpha1_world4);
		
		extra_person2.setAnimation(hula_dancer4Animation);
		extra_person2.setPositionX(85.999);
		extra_person2.setPositionY(-24.875);
		extra_person2.setSize(9.570, 16.895);
		extra_person2.setLayer(17);	
		extra_person2.setFlipX(true);		
		extra_person2.setBlendAlpha($employee_alpha2_world4);
		
		//FX Data
		fx_box1.setAnimation(fx_candlelightAnimation);
		fx_box1.setPositionX(51.902);
		fx_box1.setPositionY(-15.511);
		fx_box1.setSize(3.727, 4.112);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(fx_candlelightAnimation);
		fx_box2.setPositionX(61.485);
		fx_box2.setPositionY(-21.177);
		fx_box2.setSize(3.727, 4.112);
		fx_box2.setLayer(14);	
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(fx_candlelightAnimation);
		fx_box3.setPositionX(74.733);
		fx_box3.setPositionY(-28.176);
		fx_box3.setSize(3.727, 4.112);
		fx_box3.setLayer(14);	
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(fx_candlelightAnimation);
		fx_box4.setPositionX(93.231);
		fx_box4.setPositionY(-32.675);
		fx_box4.setSize(3.727, 4.112);
		fx_box4.setLayer(14);	
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(fx_candlelightAnimation);
		fx_box5.setPositionX(110.229);
		fx_box5.setPositionY(-32.592);
		fx_box5.setSize(3.727, 4.112);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(fx_candlelightAnimation);
		fx_box6.setPositionX(127.227);
		fx_box6.setPositionY(-32.759);
		fx_box6.setSize(3.727, 4.112);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(fx_candlelightAnimation);
		fx_box7.setPositionX(136.809);
		fx_box7.setPositionY(-28.259);
		fx_box7.setSize(3.727, 4.112);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(fx_candlelightAnimation);
		fx_box8.setPositionX(116.516);
		fx_box8.setPositionY(21.460);
		fx_box8.setSize(3.727, 4.112);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(fx_candlelightAnimation);
		fx_box9.setPositionX(82.485);
		fx_box9.setPositionY(20.856);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(16.406, 7.617);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(shorebreakImageMap);
		fx_image1.setPositionX(148.532);
		fx_image1.setPositionY(37.770);
		fx_image1.setSize(35.054, 19.223);
		fx_image1.setLayer(11);
		fx_image1.setFlipX(false);		
		//fix 02-10-2014 case controlled situation now		
		fx_image1.shorebreak_in();
		
		fx_image2.setImageMap(empty_coinImageMap);
		fx_image2.setPositionX(999);
		fx_image2.setPositionY(999);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(15);	
		fx_image2.setFlipX(false);			
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);
		fx_image3.setFlipX(false);			

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(19);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);			
	}	
	
	if($world_numeral == 5)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();	
	$points_you_need = 350;
	$game_clock_limit = $game_clock_limit_05;
	/* VIKING */
	$default_audio = "viking_theme";
	$world_audio = "viking_theme";
	//$map_dot_max = 5;
	$map_dot_max = 18;
	
		//level effects
		fx_image1.do_nothing();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_meadhall_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_viking1";
		$customer2 = "char_viking2";
		$customer3 = "char_viking3b";
		$customer4 = "char_vikingwoman";
		$width_customer1 = 11.816;
		$width_customer2 = 11.816;
		$width_customer3 = 11.816;
		$width_customer4 = 11.816;
		$height_customer1 = 17.188;
		$height_customer2 = 17.188;
		$height_customer3 = 17.188;
		$height_customer4 = 17.188;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.695;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.695;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.313;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_meadhall_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(18.8);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(25.8);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);
		
		//Extra People Data		
		extra_person1.setAnimation(viking_king3Animation);
		extra_person1.setPositionX(121.237);
		extra_person1.setPositionY(-28.134);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(false);		
		extra_person1.setBlendAlpha($employee_alpha1_world5);
		
		extra_person2.setAnimation(viking_king3Animation);
		extra_person2.setPositionX(72.747);
		extra_person2.setPositionY(-12.958);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);
		extra_person2.setFlipX(true);		
		extra_person2.setBlendAlpha($employee_alpha2_world5);
		
		//FX Data
		fx_box1.setAnimation(empty_char_spaceAnimation);
		fx_box1.setPositionX(52.702);
		fx_box1.setPositionY(-23.820);
		fx_box1.setSize(5.859, 7.715);
		fx_box1.setLayer(15);
		fx_box1.setFlipX(false);			
		
		fx_box2.setAnimation(env_torchAnimation);
		fx_box2.setPositionX(65.321);
		fx_box2.setPositionY(-31.200);
		fx_box2.setSize(5.859, 7.715);
		fx_box2.setLayer(15);
		fx_box2.setFlipX(false);			
		
		fx_box3.setAnimation(chandelier1Animation);
		fx_box3.setPositionX(57.609);
		fx_box3.setPositionY(-19.482);
		fx_box3.setSize(15.332, 10.742);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);			

		fx_box4.setAnimation(chandelier1Animation);
		fx_box4.setPositionX(77.905);
		fx_box4.setPositionY(-31.494);
		fx_box4.setSize(15.332, 10.742);
		fx_box4.setLayer(14);	
		fx_box4.setFlipX(false);			
		
		fx_box5.setAnimation(chandelier1Animation);
		fx_box5.setPositionX(135.337);
		fx_box5.setPositionY(-38.758);
		fx_box5.setSize(15.332, 10.742);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);			

		fx_box6.setAnimation(chandelier1Animation);
		fx_box6.setPositionX(135.825);
		fx_box6.setPositionY(1.643);
		fx_box6.setSize(15.332, 10.742);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);			

		fx_box7.setAnimation(chandelier1Animation);
		fx_box7.setPositionX(115.326);
		fx_box7.setPositionY(14.010);
		fx_box7.setSize(15.332, 10.742);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);			
		
		fx_box8.setAnimation(fx_open_flameAnimation);
		fx_box8.setPositionX(103.315);
		fx_box8.setPositionY(-5.936);
		fx_box8.setSize(5.859, 7.715);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);			
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);
		fx_box9.setFlipX(false);			
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(16.406, 7.617);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);			
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);
		fx_box12.setFlipX(false);			

		//image layers and fx
		
		fx_image1.setImageMap(empty_char_spaceAnimation);
		fx_image1.setPositionX(999);
		fx_image1.setPositionY(999);
		fx_image1.setSize(3.711, 7.813);
		fx_image1.setLayer(11);
		fx_image1.setFlipX(false);			

		fx_image2.setImageMap(empty_char_spaceAnimation);
		fx_image2.setPositionX(999);
		fx_image2.setPositionY(999);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(15);	
		fx_image2.setFlipX(false);		
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);		

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(19);

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);			
	}	
	
	if($world_numeral == 6)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();		
	$points_you_need = 400;
	$game_clock_limit = $game_clock_limit_06;
	/* HAUNTED FOREST */
	//$map_dot_max = 6;
	$default_audio = "forest_theme";
	$world_audio = "forest_theme";	
	$map_dot_max = 24;
	
		//level effects
		
		$lvl1_delay_toggled = 0;
		$lvl1b_delay_toggled = 0;
		fx_image1.blink_in();
		fx_image2.blink_in();
		fx_image3.do_nothing();	
		//fx_image1.blink_out();
		//fx_image2.blink_out();
		
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_haunted_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}	
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_wolfman";
		$customer2 = "char_witch";
		$customer3 = "char_pumpkinhead";
		$customer4 = "char_death";
		$width_customer1 = 11.816;
		$width_customer2 = 9.57;
		$width_customer3 = 11.816;
		$width_customer4 = 11.816;
		$height_customer1 = 17.188;
		$height_customer2 = 16.895;
		$height_customer3 = 17.188;
		$height_customer4 = 17.188;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.695;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_haunted_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.022);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(25.5);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(17.8);
		
		//Extra People Data		
		extra_person1.setAnimation(ghostAnimation);
		extra_person1.setPositionX(134.730);
		extra_person1.setPositionY(21.341);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(true);		
		extra_person1.setBlendAlpha($employee_alpha1_world6);
		
		extra_person2.setAnimation(ghostAnimation);
		extra_person2.setPositionX(122.423);
		extra_person2.setPositionY(-28.135);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);			
		extra_person2.setFlipX(false);	
		extra_person2.setBlendAlpha($employee_alpha2_world6);
		
		obj_generic_caller.schedule(10, "set_custom_ghost_anim", 0);
		obj_generic_caller.schedule(10, "set_custom_ghost_anim2", 0);
		//FX Data
		fx_box1.setAnimation(empty_char_spaceAnimation);
		fx_box1.setPositionX(54.674);
		fx_box1.setPositionY(-12.969);
		fx_box1.setSize(5.762, 5.566);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);			
		
		fx_box2.setAnimation(empty_char_spaceAnimation);
		fx_box2.setPositionX(136.595);
		fx_box2.setPositionY(-9.488);
		fx_box2.setSize(5.859, 7.715);
		fx_box2.setLayer(14);
		fx_box2.setFlipX(false);			
		
		fx_box3.setAnimation(swing_lamp2Animation);
		fx_box3.setPositionX(80.736);
		fx_box3.setPositionY(-38.799);
		fx_box3.setSize(4.590, 18.066);
		fx_box3.setLayer(14);	
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(swing_lamp2Animation);
		fx_box4.setPositionX(95.821);
		fx_box4.setPositionY(-43.798);
		fx_box4.setSize(4.590, 18.066);
		fx_box4.setLayer(14);
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(swing_lamp1Animation);
		fx_box5.setPositionX(104.352);
		fx_box5.setPositionY(-37.962);
		fx_box5.setSize(4.395, 12.793);
		fx_box5.setLayer(14);	
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(swing_lamp1Animation);
		fx_box6.setPositionX(129.882);
		fx_box6.setPositionY(-35.345);
		fx_box6.setSize(4.395, 12.793);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(swing_lamp2Animation);
		fx_box7.setPositionX(147.279);
		fx_box7.setPositionY(-28.285);
		fx_box7.setSize(4.590, 18.066);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(fx_jackolanternAnimation);
		fx_box8.setPositionX(135.725);
		fx_box8.setPositionY(11.894);
		fx_box8.setSize(6.250, 6.836);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(fx_jackolanternAnimation);
		fx_box10.setPositionX(59.522);
		fx_box10.setPositionY(-9.737);
		fx_box10.setSize(6.250, 6.836);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(true);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(blinkImageMap);
		fx_image1.setPositionX(63.158);
		fx_image1.setPositionY(-18.452);
		fx_image1.setSize(2.246, 0.781);
		fx_image1.setLayer(17);
		fx_image1.setFlipX(false);		

		fx_image2.setImageMap(blinkImageMap);
		fx_image2.setPositionX(140.467);
		fx_image2.setPositionY(-22.023);
		fx_image2.setSize(2.246, 0.781);
		fx_image2.setLayer(17);	
		fx_image2.setFlipX(false);			
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);			

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(18.6);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(17.8);			
	}		
	
	if($world_numeral == 7)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();		
	$points_you_need = 450;
	$game_clock_limit = $game_clock_limit_07;
	/* TRAIN */
	$default_audio = "train_theme";
	$world_audio = "train_theme";		
	//$map_dot_max = 4;
	$map_dot_max = 28;
	
		//level effects
		fx_image1.do_nothing();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
				
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_train_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_trainman2";
		$customer2 = "char_conductor";
		$customer3 = "char_trainwoman";
		$customer4 = "char_bellhop";
		$width_customer1 = 11.816;
		$width_customer2 = 11.816;
		$width_customer3 = 9.57;
		$width_customer4 = 11.816;
		$height_customer1 = 17.188;
		$height_customer2 = 17.188;
		$height_customer3 = 16.895;
		$height_customer4 = 17.188;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.695;
		$xpos_customer3 = -4.335;
		$xpos_customer4 = -4.695;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.313;
		$ypos_customer3 = 8.117;
		$ypos_customer4 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_train_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(69.906);
		appetizer1.setPositionY(-13.155);		
		appetizer2.setPositionX(82.336);
		appetizer2.setPositionY(-21.442);
		appetizer1_amt_ingame.setPositionX(70);
		appetizer1_amt_ingame.setPositionY(-20);
		appetizer2_amt_ingame.setPositionX(81.5);
		appetizer2_amt_ingame.setPositionY(-28);
		
		//Extra People Data		
		extra_person1.setAnimation(bellhop_bored2Animation);
		extra_person1.setPositionX(128);
		extra_person1.setPositionY(-27);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(false);		
		extra_person1.setBlendAlpha($employee_alpha1_world7);
		
		extra_person2.setAnimation(bellhop_bored2Animation);
		extra_person2.setPositionX(75.7);
		extra_person2.setPositionY(-16);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);
		extra_person2.setFlipX(true);			
		extra_person2.setBlendAlpha($employee_alpha2_world7);
		
		//FX Data
		fx_box1.setAnimation(fx_train_handleAnimation);
		fx_box1.setPositionX(51.628);
		fx_box1.setPositionY(-18.794);
		fx_box1.setSize(4.102, 17.285);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(fx_train_handleAnimation);
		fx_box2.setPositionX(63.584);
		fx_box2.setPositionY(-25.577);
		fx_box2.setSize(4.102, 17.285);
		fx_box2.setLayer(14);	
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(fx_train_handleAnimation);
		fx_box3.setPositionX(76.345);
		fx_box3.setPositionY(-32.360);
		fx_box3.setSize(4.102, 17.285);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(train_sky_fx2Animation);
		fx_box4.setPositionX(72.554);
		fx_box4.setPositionY(-24.445);
		fx_box4.setSize(45.020, 26.172);
		fx_box4.setLayer(19);		
		fx_box4.setFlipX(false);
		
		fx_box5.setAnimation(train_track_fxAnimation);
		fx_box5.setPositionX(127.197);
		fx_box5.setPositionY(24.954);
		fx_box5.setSize(45.605, 25.098);
		fx_box5.setLayer(19);	
		fx_box5.setFlipX(false);
		
		fx_box6.setAnimation(fx_train_handleAnimation);
		fx_box6.setPositionX(89.345);
		fx_box6.setPositionY(-39.577);
		fx_box6.setSize(4.102, 17.285);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(empty_char_spaceAnimation);
		fx_box7.setPositionX(999);
		fx_box7.setPositionY(999);
		fx_box7.setSize(4.590, 18.066);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(empty_char_spaceAnimation);
		fx_box8.setPositionX(999);
		fx_box8.setPositionY(999);
		fx_box8.setSize(6.250, 6.836);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);	
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(3.727, 4.112);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(empty_coinImageMap);
		fx_image1.setPositionX(999);
		fx_image1.setPositionY(999);
		fx_image1.setSize(2.246, 0.781);
		fx_image1.setLayer(17);
		fx_image1.setFlipX(false);		

		fx_image2.setImageMap(empty_coinImageMap);
		fx_image2.setPositionX(999);
		fx_image2.setPositionY(999);
		fx_image2.setSize(2.246, 0.781);
		fx_image2.setLayer(17);	
		fx_image2.setFlipX(false);		
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);
		fx_image3.setFlipX(false);		
			
		appetizer_tab_float1.setPositionX(68.257);
		appetizer_tab_float1.setPositionY(-21.531);		
		appetizer_tab_float2.setPositionX(81.076);
		appetizer_tab_float2.setPositionY(-28.986);

		appetizer1_amt_ingame.setPositionX(68.272);		
		appetizer1_amt_ingame.setPositionY(-22.253);	
		appetizer2_amt_ingame.setPositionX(81.044);		
		appetizer2_amt_ingame.setPositionY(-29.638);			
	}	
	
	if($world_numeral == 8)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();		
	$points_you_need = 500;
	$game_clock_limit = $game_clock_limit_08;
	/* FRENCH */
	$default_audio = "france_theme";
	$world_audio = "france_theme";			
	//$map_dot_max = 10;
	$map_dot_max = 38;
	
		//level effects
		fx_image1.do_nothing();
		fx_image2.do_nothing();
		fx_image3.do_nothing();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0; 
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_france_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}	
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_mime";
		$customer2 = "char_frenchwoman";
		$customer3 = "char_frenchman";
		$customer4 = "char_moulin2";
		$width_customer1 = 11.816;
		$width_customer2 = 9.57;
		$width_customer3 = 11.816;
		$width_customer4 = 9.57;
		$height_customer1 = 17.188;
		$height_customer2 = 16.895;
		$height_customer3 = 17.188;
		$height_customer4 = 16.895;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.335;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.117;
		
		//Special character : Critic
		$customer5 = "char_critic";
		$width_customer5 = 11.816;
		$height_customer5 = 17.188;
		$xpos_customer5 = -4.695;		
		$ypos_customer5 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_france_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
			
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.6);		
		appetizer2.setPositionX(107.8);
		appetizer2.setPositionY(24.5);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.8);
		appetizer2_amt_ingame.setPositionY(19.0);
		
		//Extra People Data		
		extra_person1.setAnimation(accordionist2Animation);
		extra_person1.setPositionX(90.817);
		extra_person1.setPositionY(-28.070);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(true);		
		extra_person1.setBlendAlpha($employee_alpha1_world8);
		
		extra_person2.setAnimation(employee_violinist2Animation);
		extra_person2.setPositionX(78.971);
		extra_person2.setPositionY(-20.594);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);	
		extra_person2.setFlipX(true);		
		extra_person2.setBlendAlpha($employee_alpha2_world8);
		
		//FX Data
		fx_box1.setAnimation(fx_chandelier2Animation);
		fx_box1.setPositionX(125.548);
		fx_box1.setPositionY(-33.393);
		fx_box1.setSize(18.457, 12.012);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(fx_chandelier2Animation);
		fx_box2.setPositionX(144.402);
		fx_box2.setPositionY(-22.816);
		fx_box2.setSize(18.457, 12.012);
		fx_box2.setLayer(14);	
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(empty_char_spaceAnimation);
		fx_box3.setPositionX(999);
		fx_box3.setPositionY(999);
		fx_box3.setSize(4.102, 17.285);
		fx_box3.setLayer(14);	
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(empty_char_spaceAnimation);
		fx_box4.setPositionX(999);
		fx_box4.setPositionY(999);
		fx_box4.setSize(4.590, 18.066);
		fx_box4.setLayer(14);		
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(empty_char_spaceAnimation);
		fx_box5.setPositionX(999);
		fx_box5.setPositionY(999);
		fx_box5.setSize(4.395, 12.793);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(empty_char_spaceAnimation);
		fx_box6.setPositionX(999);
		fx_box6.setPositionY(999);
		fx_box6.setSize(4.395, 12.793);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(empty_char_spaceAnimation);
		fx_box7.setPositionX(999);
		fx_box7.setPositionY(999);
		fx_box7.setSize(4.590, 18.066);
		fx_box7.setLayer(14);	
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(empty_char_spaceAnimation);
		fx_box8.setPositionX(999);
		fx_box8.setPositionY(999);
		fx_box8.setSize(6.250, 6.836);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);	
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(3.727, 4.112);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(fx_castle_castlightImageMap);
		fx_image1.setPositionX(139.689);
		fx_image1.setPositionY(-33.508);
		fx_image1.setSize(11.133, 15.137);
		fx_image1.setLayer(17);
		fx_image1.setFlipX(false);		

		fx_image2.setImageMap(fx_castle_castlightImageMap);
		fx_image2.setPositionX(60.365);
		fx_image2.setPositionY(-35.577);
		fx_image2.setSize(11.133, 15.137);
		fx_image2.setLayer(17);	
		fx_image2.setFlipX(true);
		
		fx_image3.setImageMap(empty_coinImageMap);
		fx_image3.setPositionX(999);
		fx_image3.setPositionY(999);
		fx_image3.setSize(11.133, 15.137);
		fx_image3.setLayer(16);	
		fx_image3.setFlipX(false);		

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(110.1);
		appetizer_tab_float2.setPositionY(19.823);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.8);
		appetizer2_amt_ingame.setPositionY(19.0);		
	}	
	
	if($world_numeral == 9)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();		
	$points_you_need = 550;
	$game_clock_limit = $game_clock_limit_09;
	/* CITY */
	$default_audio = "newyork_theme";
	$world_audio = "newyork_theme";		
	//$map_dot_max = 5;
	$map_dot_max = 43;
	
		//level effects
		fx_image1.setBlendAlpha(0);
		fx_image2.setBlendAlpha(0);
		fx_image3.setBlendAlpha(0);			
		fx_image1.alpha_up();
		fx_image2.alpha_up();
		fx_image3.alpha_up();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_newyork_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}	
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_beatnik2";
		$customer2 = "char_bizwoman";
		$customer3 = "char_seattlite";
		$customer4 = "char_valley";
		$width_customer1 = 11.816;
		$width_customer2 = 9.57;
		$width_customer3 = 11.816;
		$width_customer4 = 9.57;
		$height_customer1 = 17.188;
		$height_customer2 = 16.895;
		$height_customer3 = 17.188;
		$height_customer4 = 16.895;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.335;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.117;
		
		//Special character : Food Inspector
		$customer5 = "char_foodinspector";
		$width_customer5 = 11.816;
		$height_customer5 = 17.188;
		$xpos_customer5 = -4.695;		
		$ypos_customer5 = 8.313;
		
		//World Data
		main_bg.setImageMap(bkgd_metro_finalImageMap);
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(20.022);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(25.5);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);
		
		//Extra People Data		
		extra_person1.setAnimation(beatnik_drum2Animation);
		extra_person1.setPositionX(121.526);
		extra_person1.setPositionY(-26.690);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(false);		
		extra_person1.setBlendAlpha($employee_alpha1_world9);
		
		extra_person2.setAnimation(employee_bassist2Animation);
		extra_person2.setPositionX(138.893);
		extra_person2.setPositionY(-12.888);
		extra_person2.setSize(11.816, 17.188);
		extra_person2.setLayer(17);		
		extra_person2.setFlipX(false);		
		extra_person2.setBlendAlpha($employee_alpha2_world9);
		
		//FX Data
		fx_box1.setAnimation(fx_pulse_glowAnimation);
		fx_box1.setPositionX(114.611);
		fx_box1.setPositionY(-37.914);
		fx_box1.setSize(7.367, 7.476);
		fx_box1.setLayer(14);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(fx_pulse_glowAnimation);
		fx_box2.setPositionX(127.612);
		fx_box2.setPositionY(-29.680);
		fx_box2.setSize(7.367, 7.476);
		fx_box2.setLayer(14);	
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(fx_pulse_glowAnimation);
		fx_box3.setPositionX(150.689);
		fx_box3.setPositionY(-1.945);
		fx_box3.setSize(7.367, 7.476);
		fx_box3.setLayer(14);
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(empty_char_spaceAnimation);
		fx_box4.setPositionX(999);
		fx_box4.setPositionY(999);
		fx_box4.setSize(4.590, 18.066);
		fx_box4.setLayer(14);
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(empty_char_spaceAnimation);
		fx_box5.setPositionX(999);
		fx_box5.setPositionY(999);
		fx_box5.setSize(4.395, 12.793);
		fx_box5.setLayer(14);	
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(empty_char_spaceAnimation);
		fx_box6.setPositionX(999);
		fx_box6.setPositionY(999);
		fx_box6.setSize(4.395, 12.793);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(empty_char_spaceAnimation);
		fx_box7.setPositionX(999);
		fx_box7.setPositionY(999);
		fx_box7.setSize(4.590, 18.066);
		fx_box7.setLayer(14);
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(empty_char_spaceAnimation);
		fx_box8.setPositionX(999);
		fx_box8.setPositionY(999);
		fx_box8.setSize(6.250, 6.836);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);	
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(empty_char_spaceAnimation);
		fx_box10.setPositionX(999);
		fx_box10.setPositionY(999);
		fx_box10.setSize(3.727, 4.112);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(false);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image1.setPositionX(59.974);
		fx_image1.setPositionY(-22.367);
		fx_image1.setSize(14.453, 19.238);
		fx_image1.setLayer(17);
		fx_image1.setFlipX(false);		

		fx_image2.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image2.setPositionX(67.158);
		fx_image2.setPositionY(-28.109);
		fx_image2.setSize(14.453, 19.238);
		fx_image2.setLayer(17);
		fx_image2.setFlipX(false);
		
		fx_image3.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image3.setPositionX(77.559);
		fx_image3.setPositionY(-33.851);
		fx_image3.setSize(14.453, 19.238);
		fx_image3.setLayer(17);
		fx_image3.setFlipX(false);		

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11.722);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(19);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(11.000);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(18.2);			
	}	
	
	if($world_numeral == 10)
	{
	cancel_any_lingering_fx();
	set_waiter_node_position();		
	$points_you_need = 600;
	$game_clock_limit = $game_clock_limit_10;
	/* HOMETOWN */
	$default_audio = "hometown_theme";
	$world_audio = "hometown_theme";		
	//$map_dot_max = 5;
	$map_dot_max = 48;
	
		//level effects
		fx_image1.setBlendAlpha(0);
		fx_image2.setBlendAlpha(0);
		fx_image3.setBlendAlpha(0);	
		fx_image1.alpha_up();
		fx_image2.alpha_up();
		fx_image3.alpha_up();	
			
		if($round_numeral != 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			clean_up_level_transitions();			
			$world_ended = 0;
		}
		
		if($round_numeral == 1 & $clean_up_in_progress_so_skip_the_map != 1)
		{
			start_with_the_map();		
			$game_text_block_identifier = 1;
			//sceneWindow2D.setCurrentCameraPosition( "-100 150 100 75" ); 
			storyboard.setImageMap(storyboard_hometown_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}	
		
		if($clean_up_in_progress_so_skip_the_map == 1)
		{
			$end_the_clock = 0;
			$left_the_level_space = 0;
			$screen_position_x = 100;
			$screen_position_y = 0;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			$world_ended = 0;	
			$clean_up_in_progress_so_skip_the_map = 0;			
		}		
		$customer1 = "char_jock";
		$customer2 = "char_poodlegirl";
		$customer3 = "char_greaser";
		$customer4 = "char_housewife";
		$width_customer1 = 11.816;
		$width_customer2 = 9.57;
		$width_customer3 = 11.816;
		$width_customer4 = 9.57;
		$height_customer1 = 17.188;
		$height_customer2 = 16.895;
		$height_customer3 = 17.188;
		$height_customer4 = 16.895;
		$xpos_customer1 = -4.695;
		$xpos_customer2 = -4.335;
		$xpos_customer3 = -4.695;
		$xpos_customer4 = -4.335;
		$ypos_customer1 = 8.313;
		$ypos_customer2 = 8.117;
		$ypos_customer3 = 8.313;
		$ypos_customer4 = 8.117;
		
		//Special character : Mayor
		$customer5 = "char_mayor";
		$width_customer5 = 11.816;
		$height_customer5 = 17.188;
		$xpos_customer5 = -4.695;		
		$ypos_customer5 = 8.313;	
		
		//World Data
		main_bg.setImageMap(bkgd_hometown_final2ImageMap);
		
		
		//Appetizer Data
		
		if($appetizer1_purchased[$world_numeral] == 0){
		appetizer1.setFrame($world_numeral);
		}
		if($appetizer1_purchased[$world_numeral] == 1){
		appetizer1.setFrame($world_numeral);
		}		
		if($appetizer2_purchased[$world_numeral] == 0){
		appetizer2.setFrame($world_numeral);
		}
		if($appetizer2_purchased[$world_numeral] == 1){
		appetizer2.setFrame($world_numeral);
		}
		appetizer1.setPositionX(96.171);
		appetizer1.setPositionY(18.5);		
		appetizer2.setPositionX(108.665);
		appetizer2.setPositionY(26.065);
		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(10);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(17.7);
		
		//Extra People Data		
		extra_person1.setAnimation(greaser_lean2Animation);
		extra_person1.setPositionX(115.268);
		extra_person1.setPositionY(-30.326);
		extra_person1.setSize(11.816, 17.188);
		extra_person1.setLayer(17);
		extra_person1.setFlipX(false);		
		extra_person1.setBlendAlpha($employee_alpha1_world10);
		
		extra_person2.setAnimation(employee_dancer2Animation);
		extra_person2.setPositionX(90.587);
		extra_person2.setPositionY(-26.690);
		extra_person2.setSize(9.570, 16.895);
		extra_person2.setLayer(17);		
		extra_person2.setFlipX(true);			
		extra_person2.setBlendAlpha($employee_alpha2_world10);
		
		//FX Data
		fx_box1.setAnimation(fx_jukeboxAnimation);
		fx_box1.setPositionX(108.666);
		fx_box1.setPositionY(-30.876);
		fx_box1.setSize(7.715, 11.328);
		fx_box1.setLayer(15);
		fx_box1.setFlipX(false);		
		
		fx_box2.setAnimation(fx_neon1Animation);
		fx_box2.setPositionX(144.867);
		fx_box2.setPositionY(-28.015);
		fx_box2.setSize(6.348, 6.641);
		fx_box2.setLayer(14);	
		fx_box2.setFlipX(false);		
		
		fx_box3.setAnimation(empty_char_spaceAnimation);
		fx_box3.setPositionX(999);
		fx_box3.setPositionY(999);
		fx_box3.setSize(4.102, 17.285);
		fx_box3.setLayer(14);	
		fx_box3.setFlipX(false);		

		fx_box4.setAnimation(empty_char_spaceAnimation);
		fx_box4.setPositionX(999);
		fx_box4.setPositionY(999);
		fx_box4.setSize(4.590, 18.066);
		fx_box4.setLayer(14);
		fx_box4.setFlipX(false);		
		
		fx_box5.setAnimation(empty_char_spaceAnimation);
		fx_box5.setPositionX(999);
		fx_box5.setPositionY(999);
		fx_box5.setSize(4.395, 12.793);
		fx_box5.setLayer(14);
		fx_box5.setFlipX(false);		

		fx_box6.setAnimation(empty_char_spaceAnimation);
		fx_box6.setPositionX(999);
		fx_box6.setPositionY(999);
		fx_box6.setSize(4.395, 12.793);
		fx_box6.setLayer(14);
		fx_box6.setFlipX(false);		

		fx_box7.setAnimation(empty_char_spaceAnimation);
		fx_box7.setPositionX(999);
		fx_box7.setPositionY(999);
		fx_box7.setSize(4.590, 18.066);
		fx_box7.setLayer(14);	
		fx_box7.setFlipX(false);		
		
		fx_box8.setAnimation(empty_char_spaceAnimation);
		fx_box8.setPositionX(999);
		fx_box8.setPositionY(999);
		fx_box8.setSize(6.250, 6.836);
		fx_box8.setLayer(14);
		fx_box8.setFlipX(false);		
		
		fx_box9.setAnimation(empty_char_spaceAnimation);
		fx_box9.setPositionX(999);
		fx_box9.setPositionY(999);
		fx_box9.setSize(3.727, 4.112);
		fx_box9.setLayer(14);
		fx_box9.setFlipX(false);		
		
		fx_box10.setAnimation(fx_neon1Animation);
		fx_box10.setPositionX(50.791);
		fx_box10.setPositionY(-29.775);
		fx_box10.setSize(6.348, 6.641);
		fx_box10.setLayer(14);
		fx_box10.setFlipX(true);
		
		fx_box11.setAnimation(empty_char_spaceAnimation);
		fx_box11.setPositionX(999);
		fx_box11.setPositionY(999);
		fx_box11.setSize(16.406, 7.617);
		fx_box11.setLayer(14);
		fx_box11.setFlipX(false);		
		
		fx_box12.setAnimation(empty_char_spaceAnimation);
		fx_box12.setPositionX(999);
		fx_box12.setPositionY(999);
		fx_box12.setSize(16.406, 7.617);
		fx_box12.setLayer(14);	
		fx_box12.setFlipX(false);		

		//image layers and fx
		
		fx_image1.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image1.setPositionX(57.943);
		fx_image1.setPositionY(-21.413);
		fx_image1.setSize(14.453, 19.238);
		fx_image1.setLayer(17);
		fx_image1.setFlipX(false);		

		fx_image2.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image2.setPositionX(67.625);
		fx_image2.setPositionY(-26.805);
		fx_image2.setSize(14.453, 19.238);
		fx_image2.setLayer(17);
		fx_image2.setFlipX(false);
		
		fx_image3.setImageMap(fx_sodaftn_castlightImageMap);
		fx_image3.setPositionX(77.418);
		fx_image3.setPositionY(-32.526);
		fx_image3.setSize(14.453, 19.238);
		fx_image3.setLayer(17);	
		fx_image3.setFlipX(false);		

		appetizer_tab_float1.setPositionX(96.294);
		appetizer_tab_float1.setPositionY(11);		
		appetizer_tab_float2.setPositionX(109.486);
		appetizer_tab_float2.setPositionY(18.6);	

		appetizer1_amt_ingame.setPositionX(96.0);
		appetizer1_amt_ingame.setPositionY(10);
		appetizer2_amt_ingame.setPositionX(109.2);
		appetizer2_amt_ingame.setPositionY(17.7);			
	}	

	if($world_numeral == 11 & $storyboard_frame != 1)
	{
	set_waiter_node_position();		
		//god knows how many things will happen here without or with the exceptions that the other levels have
		if($round_numeral == 1)
		{
			$game_text_block_identifier = 1; 
			$screen_position_x = -100;
			$screen_position_y = 150;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			//clean_up_level_transitions();
			storyboard.setImageMap(storyboard_end_finalImageMap);
			storyboard.setFrame(0);
			$storyboard_frame = 0;
			storyboard.setSize(62.5, 46.876);
			print_game_text();
		}	
	}
	//edit 01-24-2015 last skip button, storyboard frame 2 fix
	if($world_numeral == 11 & $storyboard_frame == 1)
	{
	set_waiter_node_position();		
		//god knows how many things will happen here without or with the exceptions that the other levels have
		if($round_numeral == 1)
		{
			$game_text_block_identifier = 1; 
			$screen_position_x = -100;
			$screen_position_y = 150;
			activate_side_borders();	
			sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);			
			//clean_up_level_transitions();
			storyboard.setImageMap(storyboard_end_finalImageMap);
			storyboard.setFrame(1);
			$storyboard_frame = 1;
			storyboard.setSize(62.5, 46.876);
			//print_game_text();
		}	
	}
}
//sb_seq11ImageMap
/* Custom gator mouth animation */
function obj_generic_caller::set_custom_croc_anim(%this)
{
	if($world_numeral == 2)
	{
		%test_anim_status = fx_box10.getIsAnimationFinished();
		if(%test_anim_status != 1 & $world_numeral == 2)
		{
		//echo("!@#$%^&*!@#$%^&*" @ %test_anim_status);
		obj_generic_caller.schedule(2000, "set_custom_croc_anim", 0);
		}
		if(%test_anim_status == 1 & $world_numeral == 2)
		{
		fx_box10.setAnimation(fx_croc_mouthAnimation);
		fx_box11.setAnimation(fx_croc_mouthAnimation);
		fx_box12.setAnimation(fx_croc_mouthAnimation);
		obj_generic_caller.schedule(8000, "set_custom_croc_anim", 0);
		}
	}
}


/* Custom ghost1 play animation */
function obj_generic_caller::set_custom_ghost_anim(%this)
{
	%test_anim_status = extra_person1.getIsAnimationFinished();
if(%test_anim_status != 1 & $world_numeral == 6)
{
	obj_generic_caller.schedule(2000, "set_custom_ghost_anim", 0);
}
if(%test_anim_status == 1 & $world_numeral == 6)
{
	extra_person1.setAnimation(ghostAnimation);
	obj_generic_caller.schedule(8000, "set_custom_ghost_anim", 0);
}
}

function obj_generic_caller::set_custom_ghost_anim2(%this)
{
	%test_anim_status = extra_person2.getIsAnimationFinished();
if(%test_anim_status != 1 & $world_numeral == 6)
{
	obj_generic_caller.schedule(2000, "set_custom_ghost_anim2", 0);
}
if(%test_anim_status == 1 & $world_numeral == 6)
{
	extra_person2.setAnimation(ghostAnimation);
	obj_generic_caller.schedule(13000, "set_custom_ghost_anim2", 0);
}
}