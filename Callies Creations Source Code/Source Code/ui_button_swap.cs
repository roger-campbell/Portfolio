// ***************************************************************************************
// File Name:   ui_button_swap.cs
// Author:      Roger Campbell 
// Purpose:     In-game selection menu button and all it interacts with 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function ui_button_swap::onAdd( % this) { 
 % this.setUseMouseEvents(true);
 $fruit_frame = 0;
}

function ui_button_swap::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ($disable_ui_and_rgbp_swap != 1 & $tut_char_fruit_choices != 1 & $tut_char_fruit_choices != 2) {
   button_swap.BlendColor = "1 0.7 0.7 0.9";
  }
 }
}

function ui_button_swap::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($THE_GAME_IS_PAUSED != 1) {
  if ($disable_ui_and_rgbp_swap != 1 & $tut_char_fruit_choices != 1 & $tut_char_fruit_choices != 2) {
   unred_out_everything();
  }
  if ($completely_unlock_second_fruit_iterator == 1) {
   unred_out_everything();
  }
  button_swap.AutoRotation = 0;
  button_swap.Rotation = 0;

 }
}

function ui_button_swap::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-02-2015 swap carrying over mousedown error to fruits
  //but thisll disable all mouseDowns
  $disable_fruits_temporarily_due_to_swap_mousedown_error = 1;
  if ($THE_GAME_IS_PAUSED != 1) {
   if ($until_tut_char_is_activated_dont_do_fruits != 1 & $end_previous_non_new_tut_bits != 1) {
    if ($disable_ui_and_rgbp_swap != 1) {
     if ($mute_soundfx != 1) {
      alxPlay(waiter_rush);
     }
     button_swap.BlendColor = "0.5 0.5 0.5 1";
     button_swap.AutoRotation = 1000;
     if ($fruit_frame <= 2) {
      $fruit_frame += 1;
     }
     if ($fruit_frame > 2) {
      $fruit_frame = 0;
     }
    }

    if ($fruit_frame == 0 & $tut_go_to_fruits == 1 & $tut_yes_is_active == 1 & $disable_tutorial_clicker != 1 & $end_previous_non_new_tut_bits != 1) {
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setPositionX(64);
     tutorial_clicker.setPositionY(27);
     tutorial_clicker.setBlendAlpha(1);
    }
    if ($fruit_frame == 1 & $tut_go_to_fruits == 1 & $tut_yes_is_active == 1 & $disable_tutorial_clicker != 1 & $end_previous_non_new_tut_bits != 1 & $tut_iterate_red < 1) {
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setPositionX(64);
     tutorial_clicker.setPositionY(19);
     tutorial_clicker.setBlendAlpha(1);
    }
    if ($fruit_frame == 2 & $tut_go_to_fruits == 1 & $tut_yes_is_active == 1 & $disable_tutorial_clicker != 1 & $end_previous_non_new_tut_bits != 1 & $tut_iterate_green < 1) {
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setPositionX(64);
     tutorial_clicker.setPositionY(35);
     tutorial_clicker.setBlendAlpha(1);
    }
    //03-10-2014 exception: if cherry clicked, move pointer clicker to swap button
    if ($fruit_frame == 1 & $tut_iterate_red >= 1 & $tut_yes_is_active == 1 & $disable_tutorial_clicker != 1 & $end_previous_non_new_tut_bits != 1) {
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setPositionX(64);
     tutorial_clicker.setPositionY(27);
     tutorial_clicker.setBlendAlpha(1);
    }
    if ($fruit_frame == 2 & $tut_iterate_green >= 1 & $tut_yes_is_active == 1 & $disable_tutorial_clicker != 1 & $end_previous_non_new_tut_bits != 1) {
     pointer_tutorial.setBlendAlpha(0);
     tutorial_clicker.setPositionX(64);
     tutorial_clicker.setPositionY(27);
     tutorial_clicker.setBlendAlpha(1);
    }

   }
  }
 }
}

function ui_button_swap::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 03-02-2015 swap carrying over mousedown error to fruits
  $disable_fruits_temporarily_due_to_swap_mousedown_error = 0;
  if ($disable_all_remaining_fruit_ui != 1 & $THE_GAME_IS_PAUSED != 1 & $tut_char_fruit_choices != 1) {
   unred_out_everything();
  }
  if ($THE_GAME_IS_PAUSED != 1) {
   button_swap.AutoRotation = 0;
   button_swap.Rotation = 0;
   button_swap.BlendColor = "1 1 1 1";

   button_red_fruit.setFrame($fruit_frame);
   button_yellow_fruit.setFrame($fruit_frame);
   button_orange_fruit.setFrame($fruit_frame);
   button_green_fruit.setFrame($fruit_frame);
   button_blue_fruit.setFrame($fruit_frame);
   button_purple_fruit.setFrame($fruit_frame);
  }
 }
}

/* NEW REVOLVER SHAPE BUTTONS ---------------------------- */
function ui_button_triangle::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(1); 
  % this.setBlendAlpha(0.5);
 }

}

function ui_button_triangle::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(0); 
  % this.setBlendAlpha(1);
 }
}

function ui_button_triangle::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ( % this.trigger_up != 1) { 
   % this.setFrame(2); 
   % this.setBlendAlpha(1);
  }
 }
}

function ui_button_triangle::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { 
  % this.trigger_up = 1; 
  % this.setFrame(1); 
  % this.setBlendAlpha(1);
  ui_button_circle.trigger_up = 0;
  ui_button_circle.setFrame(0);
  ui_button_square.trigger_up = 0;
  ui_button_square.setFrame(0); 
  % this.setFrame(1);
  $fruit_frame = 1;
  button_red_fruit.setFrame($fruit_frame);
  button_yellow_fruit.setFrame($fruit_frame);
  button_orange_fruit.setFrame($fruit_frame);
  button_green_fruit.setFrame($fruit_frame);
  button_blue_fruit.setFrame($fruit_frame);
  button_purple_fruit.setFrame($fruit_frame);
 }
}

function ui_button_circle::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(1); 
  % this.setBlendAlpha(0.5);
 }

}

function ui_button_circle::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(0); 
  % this.setBlendAlpha(1);
 }
}

function ui_button_circle::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ( % this.trigger_up != 1) { 
   % this.setFrame(2); 
   % this.setBlendAlpha(1);
  }
 }
}

function ui_button_circle::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { 
  % this.trigger_up = 1; 
  % this.setFrame(1); 
  % this.setBlendAlpha(1);
  ui_button_triangle.trigger_up = 0;
  ui_button_triangle.setFrame(0);
  ui_button_square.trigger_up = 0;
  ui_button_square.setFrame(0);
  $fruit_frame = 0;
  button_red_fruit.setFrame($fruit_frame);
  button_yellow_fruit.setFrame($fruit_frame);
  button_orange_fruit.setFrame($fruit_frame);
  button_green_fruit.setFrame($fruit_frame);
  button_blue_fruit.setFrame($fruit_frame);
  button_purple_fruit.setFrame($fruit_frame);
 }
}

function ui_button_square::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(1); 
  % this.setBlendAlpha(0.5);
 }

}

function ui_button_square::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ( % this.trigger_up != 1) { 
  % this.setFrame(0); 
  % this.setBlendAlpha(1);
 }
}

function ui_button_square::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ( % this.trigger_up != 1) { 
   % this.setFrame(2); 
   % this.setBlendAlpha(1);
  }
 }
}

function ui_button_square::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) { 
  % this.trigger_up = 1; 
  % this.setFrame(1); 
  % this.setBlendAlpha(1);
  ui_button_triangle.trigger_up = 0;
  ui_button_triangle.setFrame(0);
  ui_button_circle.trigger_up = 0;
  ui_button_circle.setFrame(0);
  $fruit_frame = 2;
  button_red_fruit.setFrame($fruit_frame);
  button_yellow_fruit.setFrame($fruit_frame);
  button_orange_fruit.setFrame($fruit_frame);
  button_green_fruit.setFrame($fruit_frame);
  button_blue_fruit.setFrame($fruit_frame);
  button_purple_fruit.setFrame($fruit_frame);
 }
}