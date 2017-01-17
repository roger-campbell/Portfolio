// ***************************************************************************************
// File Name:   profile_cancel_button.cs
// Author:      Roger Campbell 
// Purpose:     Functions for "cancel" button in the profile menu
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function profile_cancel_button::onAdd( % this) {

 // enable mouse events for the mole so we can easily determine when it is clicked on
 % this.setUseMouseEvents(true);
 % this.timer1 += 1;
 $textobject1 = 2;
}

function profile_cancel_button::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("2");
 }
 if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
 }
}

function profile_cancel_button::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("0");
 }
 if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
 }
}

function profile_cancel_button::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("1");
  }
  if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
  }
 }
}

function profile_cancel_button::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($disallow_leaving_profile_menu_until_choose_new_slot == 1) { % this.setFrame("3");
  }

  if ($disallow_leaving_profile_menu_until_choose_new_slot != 1) { % this.setFrame("0");
   $screen_position_x = 0;
   $screen_position_y = 0;
   activate_side_borders();
   sceneWindow2d.setCurrentCameraPosition($screen_position_x, $screen_position_y, $horizontal_scaling, 75);
  }
 }
}