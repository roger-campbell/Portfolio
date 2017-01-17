// ***************************************************************************************
// File Name:   drink_out.cs
// Author:      Roger Campbell 
// Purpose:     All actions related to interacting with and sending out a drink 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function drink_out::onAdd( % this) {
 $drink_out_toggled = 0;
 $all_drinks_shutdown_temporarily = 0;
}

function drink_out::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($drink_out_toggled == 0 & $toggle_no_drink_switch_til_dropped_off == 0) { % this.BlendColor = "0 1 0 0.9";
 }
 if ($drink_out_toggled == 0 & $toggle_no_drink_switch_til_dropped_off == 1) { % this.BlendColor = "1 0 0 0.9";
 }
 if ( % this.active == 1) {
  set_cursor_to_hand();
 }
}

function drink_out::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($drink_out_toggled == 0) { % this.BlendColor = "1 1 1 1";
 }
 if ( % this.active == 0) { % this.BlendColor = "1 1 1 1";
 }
 if ( % this.up_status == 0) { % this.BlendColor = "1 1 1 1";
 }

 set_cursor_to_default();

}

function drink_out::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  //edit 01-24-2014 adding extra clauses for tut_only faders
  if ($tut_make_reclicking_drink_out_impossible != 1 & $wait_for_tut_drink_out_fader_to_finish != 1) {
   % char_x = % this.getPositionX(); % char_y = % this.getPositionY();

   if ($waiter_currently_collecting_tip_please_wait == 1) {
    icon_wait.setPositionX( % char_x);
    icon_wait.setPositionY( % char_y);
    icon_wait.setAnimation(icon_waitAnimation);
   }

   //edit 02-02-2013 statement so you can't select an outgoing drink while selecting tip
   //edit 07-08-2014 Jen found error here $waiter_currently_collecting_tip_please_wait = 1, please wait indefinitely
   if ($waiter_currently_collecting_tip_please_wait != 1 & $drink_was_clicked != 1) { % echo_identify_sodajerk = "sodajerk" @ % this.numeric;

    if ($all_drinks_shutdown_temporarily != 1) {
     if ( % this.active == 0) {
      echo("drink_out inactive on mouseDown");
     }
     if ( % this.active == 1 & % this.cancelled != 1 & $toggle_no_drink_switch_til_dropped_off != 1) {
      //edit 04-12-2014 adding new cursor states
      $worthy_drink_clicked = 1;
      $worthy_of_drink_is_appetizer1 = 1;
      $worthy_of_drink_is_appetizer2 = 1;
      $appetizer1_used = 0;
      $appetizer2_used = 0;
      set_cursor_to_serve();
      $toggle_serve_cursor = 1;
      $toggle_appetizer_cursor = 0;

      //edit 01-17-2014 make all drinks normal, then turn this green later so that this is the highlighted one
      drink_out1.BlendColor = "1 1 1 1";
      drink_out2.BlendColor = "1 1 1 1";
      drink_out3.BlendColor = "1 1 1 1";
      drink_out4.BlendColor = "1 1 1 1";

      //edit 02-15-2014 Need to attach this directly to a character
      $activate_char_from_drink_out = 1;

      if ($tut_yes_is_active == 1 & $tut_toggle_off_drink_out != 1 & $end_previous_non_new_tut_bits != 1 & $tut_appetizers_part_b != 1) {
       $toggle_off_default_tut_statement = 9999;
       $toggle_off_fade_out_one_and_part_two_in = 0;
       isolater_mask.fade_out_one_and_part_two_in();
       $tutorial_activate_cook_sequence = 3;
       $tut_make_cancelling_impossible = 1;
       $tut_make_reclicking_drink_out_impossible = 1;
       $tut_coin_tip_override = 1;
       $tut_toggle_off_drink_out = 1;
      }

      if ($tut_yes_is_active == 1 & $end_previous_non_new_tut_bits == 1 & $tut_appetizers_part_b != 1) {
       tutorial_text_block.text = $tut_11;
       tutorial_clicker.setBlendAlpha(1);
       tutorial_clicker.setPositionX(98);
       tutorial_clicker.setPositionY(22);
       tutorial_text_block.setPositionY(-3);
       tutorial_text_block.setPositionX(100);
       tutorial_bar.setPositionX(100);
       tutorial_bar.setPositionY(-3);
      }
      if ($tut_yes_is_active == 1 & $tut_appetizers_part_b == 1) {
       tutorial_text_block.text = $tut_13;
       tutorial_clicker.setBlendAlpha(1);
       tutorial_clicker.setPositionX(98);
       tutorial_clicker.setPositionY(22);
       $tut_appetizer1_active = 1;

      }
      if ($mute_soundfx != 1) {
       alxPlay(blipAudio);
      }
      click_sonar.BlendColor = "1 1 1 0.4";
      click_sonar.setPositionX( % char_x);
      click_sonar.setPositionY( % char_y);
      click_sonar.setAnimation(click_faderAnimation);
      //edit 01-06-2013 set sodajerk's attributes
      $set_sodajerk_for_drink_out = "sodajerk" @ % this.numeric;
      $set_sodajerk_for_drink_out.drink_out_blocking = 0;
      echo("\c2 DRINK_OUT FROM " @ $set_sodajerk_for_drink_out);
      echo("\c2 DRINK_OUT blocking = " @ $set_sodajerk_for_drink_out.drink_out_blocking);
      $drink_out_toggled = 1;
      $selected_drink = % this.numeric;
      $selected_drink2 = ( % this.numeric + 10);

      echo("NUMERIC IS " @ % this.numeric);
      $drink_out_selected1 = $drink_[$selected_drink];
      $drink_out_selected2 = $drink_[$selected_drink2];
      echo("\c2 DRINKS ARE " @ $drink_out_selected1 @ " & " @ $drink_out_selected2);
      % this.BlendColor = "0 1 0 1";
      $activation_of_movementB = 1;
      //-----------------------------------------------------------------//
      //05-14-2013 cancel button now dependent on up_status of drink_out
      if ( % this.up_status == 1 & $tut_make_cancelling_impossible != 1) {
       drink_cancel1.setPositionX(77.133);
       drink_cancel1.setPositionY(16.462);
      }
      //edit 01-30-2013 Added new global, schedule, and function to protect players from clicking multiple drinks and rapidly serving them out
      $all_drinks_shutdown_temporarily = 1; % this.schedule(240, "delay_pickup", 0);
      $drink_was_clicked = 1;
     }
    }
   }
  }
 }
}

function drink_out::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
  if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
   if ($drink_out_toggled == 0) { 
   % this.BlendColor = "1 1 1 1";
   }
  }
 }
 //edit 01-30-2013 Added new global, schedule, and function to protect players from clicking multiple drinks and rapidly serving them out
function drink_out::delay_pickup( % this) {
 $all_drinks_shutdown_temporarily = 0;
 $drink_was_clicked = 0;
 echo("drink out delayed pickup");
}