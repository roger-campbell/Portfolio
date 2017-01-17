// **************************************************************************************************************
// File Name:   main.cs
// Author:      Roger Campbell 
// Purpose:     Initialize Game, Load GUI, Initialize Preloader, Load Data Blocks, Adjust For Screen Resolution 
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// **************************************************************************************************************

function initializeProject() {
 resize_the_screen_at_start();
 echo("project initialized");
 wait_for_resize();
}

function load_up_the_game() {
 exec("~/gui/guitest.gui");
 guicontroltest();
 echo("Project Initialized...");
 
 new GuiCursor(CursorNol) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_nol.png";
 };
 
 Canvas.setCursor(CursorNol);
 // Load up the in game gui.
 exec("~/gui/mainScreen.gui");
 exec("~/gui/sponsorsplash.gui");
 echo("zaossplash");
 exec("~/gui/zaossplash.gui");
 exec("./gameScripts/FileIO.cs");
 exec("./gameScripts/ProfileInputIO.cs");
 // Exec game scripts.
 exec("./audioDatablocks.cs");
 exec("./gameScripts/filetst2.cs");
 exec("./gameScripts/game.cs");

 new GuiCursor(macCursor) {
  hotSpot = "4 4";
  renderOffset = "0 0";
  bitmapName = "~/gui/images/macCursor";
 };
 new GuiCursor(windowsCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "~/gui/images/defaultCursor";
 };
 new GuiCursor(DefaultCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_green2.png";
 };
 new GuiCursor(ServeCupCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_serve_cup2.png";
 };
 new GuiCursor(DirtyCupCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_dirty_cup2.png";
 };
 new GuiCursor(TossCupCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_toss_cup2.png";
 };
 new GuiCursor(HandCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_hand.png";
 };
 new GuiCursor(HiliCursor) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_hili.png";
 };

 //appetizer1 cursors
 new GuiCursor(appetizer_cursor1_1) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_1.png";
 };
 new GuiCursor(appetizer_cursor1_2) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_2.png";
 };
 new GuiCursor(appetizer_cursor1_3) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_3.png";
 };
 new GuiCursor(appetizer_cursor1_4) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_4.png";
 };
 new GuiCursor(appetizer_cursor1_5) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_5.png";
 };
 new GuiCursor(appetizer_cursor1_6) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_6.png";
 };
 new GuiCursor(appetizer_cursor1_7) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_7.png";
 };
 new GuiCursor(appetizer_cursor1_8) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_8.png";
 };
 new GuiCursor(appetizer_cursor1_9) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_9.png";
 };
 new GuiCursor(appetizer_cursor1_10) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer1_10.png";
 };

 //appetizer2 cursors
 new GuiCursor(appetizer_cursor2_1) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_1.png";
 };
 new GuiCursor(appetizer_cursor2_2) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_2.png";
 };
 new GuiCursor(appetizer_cursor2_3) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_3.png";
 };
 new GuiCursor(appetizer_cursor2_4) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_4.png";
 };
 new GuiCursor(appetizer_cursor2_5) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_5.png";
 };
 new GuiCursor(appetizer_cursor2_6) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_6.png";
 };
 new GuiCursor(appetizer_cursor2_7) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_7.png";
 };
 new GuiCursor(appetizer_cursor2_8) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_8.png";
 };
 new GuiCursor(appetizer_cursor2_9) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_9.png";
 };
 new GuiCursor(appetizer_cursor2_10) {
  hotSpot = "1 1";
  renderOffset = "0 0";
  bitmapName = "./data/images/cursor_appetizer2_10.png";
 };
}

function fontbitmapIO_NEW( % import) {
 $bitmap_font_name = "Cambo"; 
 % pngdir = "pngs/"; 
 % fontdir = "C:/Users/Roger/Desktop/Project_MonsterShake/torque/Monster_Shake/game/data/cache/"; 
 % font = $bitmap_font_name; 
 % size = "102"; 
 % weight = 3; 
 % fileName = % fontdir @ % pngdir @ % font SPC % size @ ".png";
 importCachedFont( % font, % size, % fileName, % weight, 0);
 writeFontCache();
}

function load_up_datablocks() { % datablock_partb = expandFilename("game/managed/datablock_partb.cs");
 exec( % datablock_partb);
 loadgradient.setExtent(30, 51);
 schedule(100, 0, load_up_datablock1);
}

function load_up_datablock1() { % datablock_part1 = expandFilename("game/managed/datablock_part1.cs");
 exec( % datablock_part1);
 loadgradient.setExtent(60, 51);
 schedule(200, 0, load_up_datablock2);
}

function load_up_datablock2() { % datablock_part2 = expandFilename("game/managed/datablock_part2.cs");
 exec( % datablock_part2);
 loadgradient.setExtent(120, 51);
 schedule(200, 0, load_up_datablock3);
}

function load_up_datablock3() { % datablock_part3 = expandFilename("game/managed/datablock_part3.cs");
 exec( % datablock_part3);
 loadgradient.setExtent(180, 51);
 schedule(200, 0, load_up_datablock4);
}

function load_up_datablock4() { % datablock_part4 = expandFilename("game/managed/datablock_part4.cs");
 exec( % datablock_part4);
 loadgradient.setExtent(240, 51);
 schedule(200, 0, load_up_datablock5);
}

function load_up_datablock5() { % datablock_part5 = expandFilename("game/managed/datablock_part5.cs");
 exec( % datablock_part5);
 loadgradient.setExtent(300, 51);
 schedule(200, 0, load_up_datablock6);
}

function load_up_datablock6() { % datablock_part6 = expandFilename("game/managed/datablock_part6.cs");
 exec( % datablock_part6);
 loadgradient.setExtent(360, 51);
 schedule(200, 0, load_up_datablock7);
}

function load_up_datablock7() { % datablock_part7 = expandFilename("game/managed/datablock_part7.cs");
 exec( % datablock_part7);
 loadgradient.setExtent(420, 51);
 schedule(200, 0, load_up_datablock8);
}

function load_up_datablock8() { % datablock_part8 = expandFilename("game/managed/datablock_part8.cs");
 exec( % datablock_part8);
 loadgradient.setExtent(480, 51);
 schedule(500, 0, load_up_datablock9);
}

function load_up_datablock9() { % datablock_part9 = expandFilename("game/managed/datablock_part9.cs");
 exec( % datablock_part9);
 loadgradient.setExtent(540, 51);
 schedule(600, 0, load_up_datablock10);
}

function load_up_datablock10() { % datablock_part10 = expandFilename("game/managed/datablock_part10.cs");
 exec( % datablock_part10);
 loadgradient.setExtent(600, 51);
 schedule(600, 0, load_up_datablock11);
}

function load_up_datablock11() { % datablock_part11 = expandFilename("game/managed/datablock_part11.cs");
 exec( % datablock_part11);
 loadgradient.setExtent(658, 51);
 schedule(1000, 0, guitimer);
}

function end_the_game() {
 sceneWindow2D.endLevel();
}

function resize_the_screen_at_start() {
 $window_mode = 3; % res = getDesktopResolution();
 $desktopWidth = getWord( % res, 0);
 $desktopHeight = getWord( % res, 1);
 $bpp = getWord( % res, 2);
 echo("$desktopWidth = "
  @ $desktopWidth @ "---------------------------------------------<<<<<");
 echo("$desktopHeight = "
  @ $desktopHeight @ "---------------------------------------------<<<<<");

 //CUSTOM SCREEN MODES---------------------------------------------------------------//
 $desktopRatio = $desktopWidth / $desktopHeight;
 //4:3 Mode
 if ($desktopRatio <= 1.4) {
  echo("Override the default settings and set resolution for 4:3 (1024 x 768 x 32)");
  setScreenMode(1024, 768, $bpp, $Game::FullScreen);
 }
 //3:2 Mode
 if ($desktopRatio > 1.4 & $desktopRatio < 1.54) {
  echo("Override the default settings and set resolution for 3:2 (1280 x 720 x 32)");
  setScreenMode(1280, 720, $bpp, $Game::FullScreen);
 }
 //16:10 Mode (including Mobile PC Display)	
 if ($desktopRatio >= 1.54 & $desktopRatio < 1.7) {
  echo("Override the default settings and set resolution for 16:10 (1280 x 800 x 32)");
  setScreenMode(1280, 720, $bpp, $Game::FullScreen);
 }
 if ($desktopRatio >= 1.7) {
  echo("Override the default settings and set resolution for 16:9 (1280 x 720 x 32)");
  setScreenMode(1280, 720, $bpp, $Game::FullScreen);
 }

 //quick defaults for testing
 //setScreenMode(1024, 768, $bpp, $fullScreen);
 //setScreenMode(1280, 800, $bpp, $Game::FullScreen);
 $screen_has_been_set = 1;
}

function resize_the_screen_at_start_widescreen() {
 $window_mode = 3; % res = getDesktopResolution();
 $desktopWidth = getWord( % res, 0);
 $desktopHeight = getWord( % res, 1);
 $bpp = getWord( % res, 2);
 setScreenMode(1280, 800, $bpp, $Game::FullScreen);
}

function load_new() {
 sceneWindow2D.loadLevel("game/data/levels/monstershake_v0005c.t2d");
}

function guicontroltest() {
 canvas.setContent(guitest);
 loadgradient.setExtent(5, 51);
 echo("guitest");
 schedule(6000, 0, load_up_datablocks);
}

function wait_for_resize() {
 if ($screen_has_been_set == 1)
  echo_resize_done();

 else
  wait_for_resize();
}

function echo_resize_done() {
 echo("made the screen resize................................................");
 load_up_the_game();
}

function echo_test_start() {
 wait_for_resize();
}

function guitimer()

{

 if (guitest.done)

 //load_up_datablocks();
  loadSplashScreen();

 else
 //load_up_datablocks();
  loadSplashScreen();

}

function loadSplashScreen() {
 // canvas.setContent(zaossplash);
 canvas.setContent(sponsorsplash);
 schedule(100, 0, checkSponsorTime);
}

function loadLogo() {
 canvas.setContent(zaossplash);
 schedule(100, 0, checkSplashTime);
}

function checkSponsorTime() {
 if (sponsorsplash.done)
  loadLogo();

 else

  loadSplashScreen();
}

function checkSplashTime()

{

 if (zaossplash.done)
  startGame(expandFilename($Game::DefaultScene));

 else

  loadLogo();

}

function t2dSceneObject::onLevelLoaded( % this, % scenegraph) {
 //kick off the timer here  
 schedule(256, 0, startAnimationTimer);
}


function shutdownProject() {
 endGame();
}


function setupKeybinds() {
 //bind keys moved to profileInputIO.cs
}