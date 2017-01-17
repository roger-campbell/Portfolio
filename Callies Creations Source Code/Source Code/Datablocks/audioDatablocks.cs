$sfx_level = 1.0;
$music_level = 1.0;
$SFXType = 1;
$GuiAudioType = 2;
new AudioDescription(AudioNonLooping)
{
volume = $sfx_level;
isLooping= false;
is3D = false;
type = $SFXType;
};
new AudioDescription(AudioNonLoopingSoft)
{
volume = $sfx_level;
isLooping= false;
is3D = false;
type = $SFXType;
};
new AudioDescription(AudioLooping)
{
volume = $music_level;
isLooping= true;
is3D = false;
type = $GuiAudioType;
};
new AudioDescription(AudioLooping2)
{
volume = $music_level;
isLooping= true;
is3D = false;
type = $GuiAudioType;
};
new AudioDescription(AudioLooping3)
{
volume = $music_level;
isLooping= true;
is3D = false;
type = $GuiAudioType;
};
// --------------------------------------------------------------------
// Background Loop.
// --------------------------------------------------------------------
new AudioProfile(backgroundAudio)
{
filename = "./data/audio/buttonclick.ogg";
description = "AudioLooping";
preload = true;
};

// --------------------------------------------------------------------
// Single Blip.
// --------------------------------------------------------------------
new AudioProfile(blipAudio)
{
filename = "./data/audio/buttonclick.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(cue_up)
{
filename = "./data/audio/switch-13.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(error_noise)
{
filename = "./data/audio/error2.ogg";
description = "AudioNonLoopingSoft";
preload = true;
};
new AudioProfile(coin_tip_sound)
{
filename = "./data/audio/coin-drop-4.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(coin_collect_sound)
{
filename = "./data/audio/coins-in-hand-1.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(approve_sparkles)
{
//filename = "./data/audio/jingle-bell-4.ogg";
filename = "./data/audio/magic_chime.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(place_down_drink)
{
filename = "./data/audio/plate-down-1.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(nice_click)
{
filename = "./data/audio/link_sound.ogg";
description = "AudioNonLoopingSoft";
preload = true;
};
new AudioProfile(drink_popping_up)
{
filename = "./data/audio/drink_popup.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(waiter_rush)
{
filename = "./data/audio/quick_dash.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(clean_dish)
{
filename = "./data/audio/water-faucet-2.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(cook_pour)
{
filename = "./data/audio/water-glass-fill-1.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(womp_womp)
{
//filename = "./data/audio/fail-trombone-03.ogg";
filename = "./data/audio/fail_trombone.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(slot_machine)
{
//filename = "./data/audio/fail-trombone-03.ogg";
filename = "./data/audio/bell-ringing-04b.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(voop)
{
//filename = "./data/audio/fail-trombone-03.ogg";
filename = "./data/audio/button-09.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(clank)
{
//filename = "./data/audio/fail-trombone-03.ogg";
filename = "./data/audio/mug-down-2.ogg";
description = "AudioNonLooping";
preload = true;
};
new AudioProfile(end_chime)
{
//filename = "./data/audio/fail-trombone-03.ogg";
filename = "./data/audio/magic-chime-02.ogg";
description = "AudioNonLooping";
preload = true;
};

/* MUSIC */
//LVL 0 (fill in)
new AudioProfile(mainmenu_theme)
{
filename = "./data/audio/mainmenu.ogg";
description = "AudioLooping2";
preload = true;
};

new AudioProfile(map_theme)
{
filename = "./data/audio/Open_Those_Bright_Eyes2.ogg";
description = "AudioLooping2";
preload = true;
};

//LVL 1
new AudioProfile(castle_theme)
{
filename = "./data/audio/Achaidh_Cheide3.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 2 (fill in)
new AudioProfile(swamp_theme)
{
filename = "./data/audio/Bama_Country.ogg";
description = "AudioLooping2";
preload = true;
};

//LVL 3
new AudioProfile(airship_theme)
{
filename = "./data/audio/Olde_Timey.ogg";
description = "AudioLooping3";
preload = true;
};

//LVL 4 (fill in)
new AudioProfile(hawaii_theme)
{
filename = "./data/audio/Bassa_Island_Game_Loop.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 5
new AudioProfile(viking_theme)
{
filename = "./data/audio/Thatched_Villagers.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 6
new AudioProfile(forest_theme)
{
filename = "./data/audio/One_eyed_Maestro.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 7 (fill in)
new AudioProfile(train_theme)
{
filename = "./data/audio/Amazing_Plan2.ogg";
description = "AudioLooping2";
preload = true;
};

//LVL 8 (fill in)
new AudioProfile(france_theme)
{
filename = "./data/audio/calltoadventurerevised2.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 9 (fill in)
new AudioProfile(newyork_theme)
{
filename = "./data/audio/Faster_Does_It2.ogg";
description = "AudioLooping";
preload = true;
};

//LVL 10
new AudioProfile(hometown_theme)
{
filename = "./data/audio/hometown_theme2.ogg";
description = "AudioLooping";
preload = true;
};

