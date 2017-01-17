// ***************************************************************************************
// File Name:   optionsButton.cs
// Author:      Roger Campbell 
// Purpose:     Functions for the options button
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

function optionsButton::onAdd( % this) {
 button_options.setUseMouseEvents(true);
}

function optionsButton::onMouseMove( % this, % modifier, % worldPosition, % mouseClicks) {
 button_options.setFrame("1");
 set_cursor_to_hili();
}

function optionsButton::onMouseLeave( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($toggle_mm_buttons_off != 1) {
  button_options.setFrame("0");
 }
 set_cursor_to_default();
}

function optionsButton::onMouseDown( % this, % modifier, % worldPosition, % mouseClicks) {
 if ($MASTER_ALL_BUTTONS_DISABLED != 1) {
  if ($toggle_mm_buttons_off != 1) {
   button_options.setFrame("2");

  }
 }
}