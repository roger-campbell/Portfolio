// ***************************************************************************************
// File Name:   exitButton.cs
// Author:      Roger Campbell 
// Purpose:     Button for exiting the game 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************
function exitButton::onAdd( % this) {
 echo("Exit Button in Game");
 % this.setUseMouseEvents(true);
}

function exitButton::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_mm_buttons_off != 1) {
  echo("Mouse Enter Working"); % this.setFrame("1");
 }
 set_cursor_to_hili();
}

function exitButton::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_mm_buttons_off != 1) {
  echo("Mouse Enter Working"); % this.setFrame("0");
 }
 set_cursor_to_default();
}

function exitButton::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_mm_buttons_off != 1) {
   echo("Exit Clicked"); % this.setFrame("2");
  }
 }
}

function exitButton::onMouseUp( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($mm_exit_completed == 1) {
   if ($toggle_mm_buttons_off != 1) {
    quit();
   }
  }
 }
}