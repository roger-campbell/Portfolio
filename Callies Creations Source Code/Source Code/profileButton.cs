// ***************************************************************************************
// File Name:   profileButton.cs
// Author:      Roger Campbell 
// Purpose:     Functions for "Profiles" button
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function profileButton::onAdd( % this) {

 // enable mouse events for the mole so we can easily determine when it is clicked on
 % this.setUseMouseEvents(true);
 % this.timer1 += 1;
 $textobject1 = 2;
}

function profileButton::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 mm_profile_button.setFrame("1");
 set_cursor_to_hili();
}

function profileButton::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 mm_profile_button.setFrame("0");
 set_cursor_to_default();
}

function profileButton::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  mm_profile_button.setFrame("2");
 }
}

function profileButton::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  $this_is_the_first_time_ever_played = 2;

  if ($mm_profile_completed == 1) {
   mm_profile_button.setFrame("1");
   //edit 02-27-2014 declaring more current profile information
   echo("VIA mm profile name button, $current_profile_number = "
    @ $current_profile_number);
   $current_profile_slot = "prof_name_input_field"
   @ $current_profile_number;
   //edit 02-03-2014 adding particulars to entering profile menu based on if if first start ever
   if ($GAME_HAS_NEVER_BEEN_STARTED == 1) {
    dynamic_name_slot.font = "cambo";

    $sfile = new FileObject();
    if ($sfile.openForRead("./data/test1.ccf")) {
     echo("UPON pre_done_button, $sfile.openForRead-test1.ccf"); % declare_profile = $sfile.readLine();
     echo( % declare_profile);
     prof_name_input_field1.text = % declare_profile;
     _prof_name_input_field1.text = % declare_profile;
     echo(prof_name_input_field1.text);
     $sfile.close();
    }
    //edit 02-03-2014 removing previous profile menu constraints
    $pre_done_button_toggle = 0;
    //edit 02-27-2014 declaring more current profile information
    echo("VIA mm profile name button, $current_profile_number = " @ $current_profile_number);
    $current_profile_slot = "prof_name_input_field" @ $current_profile_number;
    //edit 02-28-2014 adding history states for profile
    //edit 02-28-2014 capturing profile histories
    if ($capture_this_only_once_per_session != 1) { % capture_history_of_current_profile = $current_profile_slot.id_number; % old_current_profile = % capture_history_of_current_profile;
     $old_profile_state = % old_current_profile;
     echo("old profile state @ " @ $old_profile_state);
     $capture_this_only_once_per_session = 1;
    }
    //edit 03-02-2014 there are legacy overwrite conditions for first time playing
    $GAME_HAS_NEVER_BEEN_STARTED = 0;
   }

   $screen_position_x = 0;
   $screen_position_y = 75;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75); % find_profile_for_dynamic_slot = "prof_name_input_field"
   @ $profile_for_this_session; % read_profile_for_dynamic_slot = % find_profile_for_dynamic_slot.text;
   //exception for when map echo clips into profile menu
   pointer_world_map.setBlendAlpha(0);
   world_map_echo.setBlendAlpha(0);
   //$input_to_profile_slot = %read_profile_for_dynamic_slot;
  }
 }
}