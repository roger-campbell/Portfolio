// ***************************************************************************************
// File Name:   game_text.cs
// Author:      Roger Campbell 
// Purpose:     All global text and descriptions in game
// Note:        Usage of % vs. @ { and ; are due to TorqueScript syntax
// ****************************************************************************************

$new_prof = "New Profile?";
$new_prof = "Please Enter a Name:";

$menu_bites = "Bites";
$menu_beverages = "Beverages";
$menu_baristas = "Baristas";
$menu_awards = "Awards";
$menu_map = "Map";
$menu_options = "Options";
$menu_done = "Done";

$button_yes = "Yes!";
$button_no = "No";
$button_okay = "Okay";
$button_done = "Done";
$button_cancel = "Cancel";

$ui_score = "Score";
$ui_level = "Level";
$ui_pause = "Pause Game";
$ui_options = "Options";

$sub_sound = "Sound FX";
$sub_music = "Music";
$sub_screen = "Full Screen";

$sub_difficulty = "Difficulty:";
$sub_easy = "Easy";
$sub_med = "Medium";
$sub_hard = "Hard";

$sub_trophies = "Trophies";

$sub_credits = "Credits";

$tut_continue = "Continue";
$tut_intro = "Would you like a quick tutorial?.";
$tut_01 = "First, click the customer to see what they want.";
$tut_02 = "Click the fruits here to order up their drink.";
$tut_03 = "Excellent! The barista is making the drink for you now.";
$tut_03b = "Please Wait...";
$tut_04 = "Order up! Select the drink you just made.";
$tut_05 = "Now serve it to the customer.";
$tut_06 = "Perfect! We'll just wait for her to finish...";
//Caps-lockify
$tut_07 = "You got your first tip! Click to collect it!";
$tut_08 = "Don't forget to get the dirty dish!";
//$tut_08 = "Now wash the dirty cup so it can be used again!";
//$tut_08b = "Perfect!";
$tut_08b = "Now wash the dirty cup so it can be used again!";
$tut_09 = "Later on you can buy appetizers. Appetizers help calm customers";
$tut_09b = "because they'll leave if they have to wait too long. (click it to continue)";
$tut_10 = "Some customers want appetizers with their drinks.";
$tut_10b = "(Click Customer to continue)";
$tut_11 = "She wants a new flavor first. Click the cycle button and find that combo";
$tut_12 = "Let's wait for the cook and next we'll stack up some appetizers...";
$tut_12b = "Click the drink and then click this appetizer to stack them up";
$tut_13 = "...Now click this appetizer to stack them up";
$tut_13b = "Great! Now serve the customer.";
$tut_13c = "Perfect again! Let's wait for them to finish!";
$tut_14 = "Let's see you do the rest now...";
$tut_14b = "You're an ace! Congratulations!";

$tut_13d = "If you ever got lost, simply click the Help button. Good luck!";

$tut_09c = "Let's have a short wait for the barista while he prepares...";

//$tut_07 = "You've Sold Out For The Day! Good Work!";
//$tut_08 = "On The Left, You Can Buy Things To Help You Be More Productive.";
//$tut_09 = "On The Right You Can Check Trophies You've Earned And Places You've Been.";

$tut_extra1 = "Good!";

//Tutorial Extended Text
$tut_ext_00 = "Amazing Job! Just a few more moments and you'll be a PRO";
$tut_ext_00b = "";
$tut_ext_01 = "These are appetizers, like you used before to slow down customers...";
$tut_ext_01b = "";
$tut_ext_02 = "Ordering Bites stalls time temporarily if you use them...";
$tut_ext_02b = "Ordering Beverages completely freezes time when used, but are costly";
$tut_ext_03 = "This is your award room (Click Button to Enter Room)";
$tut_ext_03b = "";
$tut_ext_04 = "This is one of the awards you've won!";
$tut_ext_04b = "Mousing over others will tell you how to win more";
$tut_ext_05 = "Great! Let's go back to the Order Menu.";
$tut_ext_05b = "";
$tut_ext_06 = "Now click the Map Screen!";
$tut_ext_06b = "";
$tut_ext_07 = "Here is the world you're currently playing.";
$tut_ext_07b = "Clicking the World enters into the Round Menu (Click World to Continue)";
$tut_ext_08 = "Every circle here represents a round";
$tut_ext_08b = "You need to complete 10 to go to the next world";
$tut_ext_09 = "Yellow circles are rounds you've completed";
$tut_ext_09b = "Pulsing circles represent the next round in line";
$tut_ext_10 = "This is how many stars you've won for the round you played";
$tut_ext_10b = "3 Gold means you served all customers fast enough";
$tut_ext_11 = "2 Silver means you served at least one customer a little slow";
$tut_ext_11b = "1 Bronze means you served at least one customer too slowly";
$tut_ext_12 = "You can replay rounds you've done already, but for now let's continue playing.";
$tut_ext_12b = "";

/////////////////////////////////////////////////////////////////////////////p
/* Storyboard Text */
/* NOTE : BY DEFAULT "AS A COMPUTER I DONT KNOW THIS LETTER" BECOMES WHATEVER text_field_test FRAME # IS. RIGHT NOW
IT'S SET TO APOSTROPHE AS THAT IS THE ONLY MISUNDERSTOOD LETTER, THIS IS HALF-ASSED AND NEEDS TO BE FIXED IN BETA */

/* IMPORTANT! : VECTORIZED BITMAP TEXT CANNOT BE SMALLER THAN 3.5, MUST NOT HAVE INTEGER SNAP, AND MUST HAVE BILINEAR FILTERING */
/* IMPORTANT! : IF THE FONT IS STARK WHITE, THE LOCAL COMMON FONT IS THE OLD ONE, MUST HAVE BEEN MOVED/REPLACED FROM LOCATION */
/////////////////////////////////////////////////////////////////////////////
$storyboard_intro0 = "Callie was a bright, independent woman who started up her own smoothie stand: Callie's Creations.";
$storyboard_intro1 = "Business was booming and soon word spread across the globe of her healthy, delicious blended shakes. ";
$storyboard_intro2 = "Far away in Scotland, even the King of Aramore had discovered it and invited her to build a stand in his castle.";
$storyboard_intro3 = "Seeing the opportunity, you, Callie, accepted and began your adventure of building a brand across the world!"; 

$storyboard_swamp1 = "After delighting the king and his court, you received word from a shaman in a Louisiana bayou."; 
$storyboard_swamp2 = "Hearing of your great smoothie stand, he begged you to set up one in his humble retreat."; 

$storyboard_airship1 = "The shaman informed you of a nearby airship that was touring Lousiana while on its way to Hawaii and France.";  
$storyboard_airship2 = "You worked out a deal to cater aboard and when you arrived, you noticed the press corps was coming too.";
$storyboard_airship3 = "This was your big chance! Getting Callie's Creations in the newspaper could increase your store's popularity!";   
$storyboard_airship4 = "IMPORTANT: YOU MUST SERVE THE PRESS FAST ENOUGH TO WIN THE ROUND!";

$storyboard_hawaii1 = "Congratulations! You were a hit and your business was expanding now that you made it to the front page!"; 
$storyboard_hawaii2 = "One of the passengers was the owner of a Parisian restaurant and informed you that he'd like a stand as well.";  
$storyboard_hawaii3 = "You graciously accepted. The airship finally landed in Hawaii and you convinced a local retreat to host your stand.";  
$storyboard_hawaii4 = "IMPORTANT: YOU MUST SERVE THE CELEBRITY FAST ENOUGH TO WIN THE ROUND! (Bonus: You earn double winnings!)";

$storyboard_viking1 = "Well done. Now it was time for a well deserved break. You returned to the airship to rest and prepared for France.";  
$storyboard_viking2 = "While en route, the pilot announced they had to make an emergency landing at the Viking Isle due to engine trouble.";   
$storyboard_viking3 = "You found a place to stay at an inn above a mead hall, and setup shop inside to help pay for the room and board";  
   
$storyboard_haunted1 = "The vikings loved it! However, the next morning you arrived to find the airship had already left on its voyage to France!";  
$storyboard_haunted2 = "The inn-keeper informed you of a train station you could use to catch up with them in the next town, beyond a forest. ";    
$storyboard_haunted3 = "But as you passed through the forest though, you encountered creatures. In return for safe passage you offered them tasty smoothies.";

$storyboard_train1 = "It worked! The creatures were full and satisfied. ";
$storyboard_train2 = "As you cleared the forest and made it to the train station, you realized you'd been robbed."; 
$storyboard_train3 = "You tried sneaking aboard the train, but were discovered and offered up your catering services in exchange for passage to France.";   
/////////////////////////////////////////////////////////////////////////////
/* Menu Text */
////////////////////////////////////////////////////////////////////////////

$new_prof = "New Profile?";
$new_prof = "Please Enter a Name:";

$menu_bites = "Bites";
$menu_beverages = "Beverages";
$menu_baristas = "Baristas";
$menu_awards = "Awards";
$menu_map = "Map";
$menu_options = "Options";
$menu_done = "Done";

$button_yes = "Yes!";
$button_no = "No";
$button_okay = "Okay";
$button_done = "Done";
$button_cancel = "Cancel";

$ui_score = "Score";
$ui_level = "Level";
$ui_pause = "Pause Game";
$ui_options = "Options";

$sub_sound = "Sound FX";
$sub_music = "Music";
$sub_screen = "Full Screen";

$sub_difficulty = "Difficulty:";
$sub_easy = "Easy";
$sub_med = "Medium";
$sub_hard = "Hard";

$sub_trophies = "Trophies";

$sub_credits = "Credits";

$tut_continue = "Continue";
$tut_intro = "Would you like a quick tutorial?.";
$tut_01 = "First, click the customer to see what they want.";
$tut_02 = "Click the fruits here to order up their drink.";
$tut_03 = "Excellent! The barista is making the drink for you now.";
$tut_03b = "Please Wait...";
$tut_04 = "Order up! Select the drink you just made.";
$tut_05 = "Now serve it to the customer.";
$tut_06 = "Perfect! We'll just wait for her to finish...";
//Caps-lockify
$tut_07 = "You got your first tip! Click to collect it!";
$tut_08 = "Don't forget to get the dirty dish!";
//$tut_08 = "Now wash the dirty cup so it can be used again!";
//$tut_08b = "Perfect!";
$tut_08b = "Now wash the dirty cup so it can be used again!";
$tut_09 = "Later on you can buy appetizers. Appetizers help calm customers";
$tut_09b = "because they'll leave if they have to wait too long. (click it to continue)";
$tut_10 = "Some customers want appetizers with their drinks.";
$tut_10b = "(Click Customer to continue)";
$tut_11 = "She wants a new flavor first. Click the cycle button and find that combo";
$tut_12 = "Let's wait for the cook and next we'll stack up some appetizers...";
$tut_12b = "Click the drink and then click this appetizer to stack them up";
$tut_13 = "...Now click this appetizer to stack them up";
$tut_13b = "Great! Now serve the customer.";
$tut_13c = "Perfect again! Let's wait for them to finish!";
$tut_14 = "Let's see you do the rest now...";
$tut_14b = "You're an ace! Congratulations!";

$tut_13d = "If you ever got lost, simply click the Help button. Good luck!";

$tut_09c = "Let's have a short wait for the barista while he prepares...";

//$tut_07 = "You've Sold Out For The Day! Good Work!";
//$tut_08 = "On The Left, You Can Buy Things To Help You Be More Productive.";
//$tut_09 = "On The Right You Can Check Trophies You've Earned And Places You've Been.";

$tut_extra1 = "Good!";

//Tutorial Extended Text
$tut_ext_00 = "Amazing Job! Just a few more moments and you'll be a PRO";
$tut_ext_00b = "";
$tut_ext_01 = "These are appetizers, like you used before to slow down customers...";
$tut_ext_01b = "";
$tut_ext_02 = "Ordering Bites stalls time temporarily if you use them...";
$tut_ext_02b = "Ordering Beverages completely freezes time when used, but are costly";
$tut_ext_03 = "This is your award room (Click Button to Enter Room)";
$tut_ext_03b = "";
$tut_ext_04 = "This is one of the awards you've won!";
$tut_ext_04b = "Mousing over others will tell you how to win more";
$tut_ext_05 = "Great! Let's go back to the Order Menu.";
$tut_ext_05b = "";
$tut_ext_06 = "Now click the Map Screen!";
$tut_ext_06b = "";
$tut_ext_07 = "Here is the world you're currently playing.";
$tut_ext_07b = "Clicking the World enters into the Round Menu (Click World to Continue)";
$tut_ext_08 = "Every circle here represents a round";
$tut_ext_08b = "You need to complete 10 to go to the next world";
$tut_ext_09 = "Yellow circles are rounds you've completed";
$tut_ext_09b = "Pulsing circles represent the next round in line";
$tut_ext_10 = "This is how many stars you've won for the round you played";
$tut_ext_10b = "3 Gold means you served all customers fast enough";
$tut_ext_11 = "2 Silver means you served at least one customer a little slow";
$tut_ext_11b = "1 Bronze means you served at least one customer too slowly";
$tut_ext_12 = "You can replay rounds you've done already, but for now let's continue playing.";
$tut_ext_12b = "";

/////////////////////////////////////////////////////////////////////////////p
/* Storyboard Text */
/* NOTE : BY DEFAULT "AS A COMPUTER I DONT KNOW THIS LETTER" BECOMES WHATEVER text_field_test FRAME # IS. RIGHT NOW
IT'S SET TO APOSTROPHE AS THAT IS THE ONLY MISUNDERSTOOD LETTER, THIS IS HALF-ASSED AND NEEDS TO BE FIXED IN BETA */

/* IMPORTANT! : VECTORIZED BITMAP TEXT CANNOT BE SMALLER THAN 3.5, MUST NOT HAVE INTEGER SNAP, AND MUST HAVE BILINEAR FILTERING */
/* IMPORTANT! : IF THE FONT IS STARK WHITE, THE LOCAL COMMON FONT IS THE OLD ONE, MUST HAVE BEEN MOVED/REPLACED FROM LOCATION */
/////////////////////////////////////////////////////////////////////////////
$storyboard_intro0 = "Callie was a bright, independent woman who started up her own smoothie stand: Callie's Creations.";
$storyboard_intro1 = "Business was booming and soon word spread across the globe of her healthy, delicious blended shakes. ";
$storyboard_intro2 = "Far away in Scotland, even the King of Aramore had discovered it and invited her to build a stand in his castle.";
$storyboard_intro3 = "Seeing the opportunity, you, Callie, accepted and began your adventure of building a brand across the world!"; 

$storyboard_swamp1 = "After delighting the king and his court, you received word from a shaman in a Louisiana bayou."; 
$storyboard_swamp2 = "Hearing of your great smoothie stand, he begged you to set up one in his humble retreat."; 

$storyboard_airship1 = "The shaman informed you of a nearby airship that was touring Lousiana while on its way to Hawaii and France.";  
$storyboard_airship2 = "You worked out a deal to cater aboard and when you arrived, you noticed the press corps was coming too.";
$storyboard_airship3 = "This was your big chance! Getting Callie's Creations in the newspaper could increase your store's popularity!";   
$storyboard_airship4 = "IMPORTANT: YOU MUST SERVE THE PRESS FAST ENOUGH TO WIN THE ROUND!";

$storyboard_hawaii1 = "Congratulations! You were a hit and your business was expanding now that you made it to the front page!"; 
$storyboard_hawaii2 = "One of the passengers was the owner of a Parisian restaurant and informed you that he'd like a stand as well.";  
$storyboard_hawaii3 = "You graciously accepted. The airship finally landed in Hawaii and you convinced a local retreat to host your stand.";  
$storyboard_hawaii4 = "IMPORTANT: YOU MUST SERVE THE CELEBRITY FAST ENOUGH TO WIN THE ROUND! (Bonus: You earn double winnings!)";

$storyboard_viking1 = "Well done. Now it was time for a well-deserved break. You returned to the airship to rest and prepared for France.";  
$storyboard_viking2 = "While en route, the pilot announced they had to make an emergency landing at the Viking Isle due to engine trouble.";   
$storyboard_viking3 = "You found a place to stay at an inn above a mead hall, and set up shop inside to help pay for the room and board.";  
   
$storyboard_haunted1 = "The vikings loved it! However, the next morning you arrived to find the airship had already left on its voyage to France!";  
$storyboard_haunted2 = "The inn keeper informed you of a train station you could use to catch up with them in the next town, beyond a forest. ";    
$storyboard_haunted3 = "But as you passed through the forest, you encountered creatures. In return for safe passage you offered them tasty smoothies.";

$storyboard_train1 = "It worked! The creatures were full and satisfied. ";
$storyboard_train2 = "As you cleared the forest and made it to the train station, you realized you'd been robbed."; 
$storyboard_train3 = "You tried sneaking aboard the train, but were discovered and offered up your catering services in exchange for passage to France.";   

$storyboard_france1 = "Paris, France."; 
$storyboard_france2 = "You arrived at the restaurant, where the owner from the airship was waiting for you."; 
$storyboard_france3 = "The owner told you that several of the top critics were in town and would be attending tonight.";    
$storyboard_france4 = "IMPORTANT: YOU MUST SERVE THIS CRITIC FAST ENOUGH TO WIN THE ROUND!"; 

$storyboard_metro1 = "The French approved! They were so pleased that they insisted you came to the International Food Convention in New York."; 
$storyboard_metro2 = "You booked your placement and celebrated with a glass of champagne, excited for your big break in New York City.";   
$storyboard_metro3 = "The next day you arrived and marveled at the size of the convention. Being wary though, you spotted crowds of health inspectors abound..."; 
$storyboard_metro4 = "IMPORTANT: YOU MUST SERVE THIS FOOD INSPECTOR FAST ENOUGH TO WIN THE ROUND!";       

$storyboard_hometown1 = "Your big debut was a success! You had won over the crowd and now, after your long, tiresome journey, it was time to go home.";        
$storyboard_hometown2 = "You returned home and decided it was time to turn your smoothie stand into a full fledged venue.";        
$storyboard_hometown3 = "Knowing the town mayor personally, you invited him for free drinks to help smooth the process of getting permits and licenses.";
$storyboard_hometown4 = "IMPORTANT: YOU MUST SERVE THE MAYOR FAST ENOUGH TO WIN THE ROUND!"; 
  
$storyboard_outro1 = "You have proven yourself and spread Callie's Creations all across the world. Who knows what's in store for Callie next!";        
$storyboard_outro2 = "Well done and congratulations!"; 

//////////////////////////////////////////////////////////////////////////////////////
/* TROPHY TEXT AND IMAGES */
//////////////////////////////////////////////////////////////////////////////////////

/* implemented */
$_trophy_trophy1_name = "Overtime";
$_trophy_trophy1_description = "Serve More Than 10 Days In 1 Stand";
$_trophy_trophy1_image = "award_trophiesImageMap";
$_trophy_trophy1_frame = 1;
$_trophy_trophy1_sizex = 11.621;
$_trophy_trophy1_sizey = 23.047;
$_trophy_trophy1_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy2_name = "Super Server";
$_trophy_trophy2_description = "Serve More Than 55 People In 1 Stand";
$_trophy_trophy2_image = "award_trophiesImageMap";
$_trophy_trophy2_frame = 2;
$_trophy_trophy2_sizex = 11.621;
$_trophy_trophy2_sizey = 23.047;
$_trophy_trophy2_activated = 0;

/* implemented */
$_trophy_trophy3_name = "5 In a Row";
$_trophy_trophy3_description = "Serve Five People In a Row";
$_trophy_trophy3_image = "award_trophiesImageMap";
$_trophy_trophy3_frame = 3;
$_trophy_trophy3_sizex = 11.621;
$_trophy_trophy3_sizey = 23.047;
$_trophy_trophy3_activated = 0;

/* implemented */
$_trophy_trophy4_name = "Half Way";
$_trophy_trophy4_description = "Make It Half Way Around The World";
$_trophy_trophy4_image = "award_trophiesImageMap";
$_trophy_trophy4_frame = 4;
$_trophy_trophy4_sizex = 11.621;
$_trophy_trophy4_sizey = 23.047;
$_trophy_trophy4_activated = 0;

/* implemented */
$_trophy_trophy5_name = "Round Trip";
$_trophy_trophy5_description = "Make It All The Way Around The World";
$_trophy_trophy5_image = "award_trophiesImageMap";
$_trophy_trophy5_frame = 5;
$_trophy_trophy5_sizex = 11.621;
$_trophy_trophy5_sizey = 23.047;
$_trophy_trophy5_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy6_name = "50 Served";
$_trophy_trophy6_description = "Serve 50 People";
$_trophy_trophy6_image = "award_trophiesImageMap";
$_trophy_trophy6_frame = 6;
$_trophy_trophy6_sizex = 11.621;
$_trophy_trophy6_sizey = 23.047;
$_trophy_trophy6_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy7_name = "100 Served";
$_trophy_trophy7_description = "Serve 100 People";
$_trophy_trophy7_image = "award_trophiesImageMap";
$_trophy_trophy7_frame = 7;
$_trophy_trophy7_sizex = 11.621;
$_trophy_trophy7_sizey = 23.047;
$_trophy_trophy7_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy8_name = "200 Served";
$_trophy_trophy8_description = "Serve 200 People";
$_trophy_trophy8_image = "award_trophiesImageMap";
$_trophy_trophy8_frame = 8;
$_trophy_trophy8_sizex = 11.621;
$_trophy_trophy8_sizey = 23.047;
$_trophy_trophy8_activated = 0;

/* implemented */
$_trophy_trophy9_name = "Go For The Gold";
$_trophy_trophy9_description = "Get All Gold Stars In 1 Round";
$_trophy_trophy9_image = "award_trophiesImageMap";
$_trophy_trophy9_frame = 9;
$_trophy_trophy9_sizex = 11.621;
$_trophy_trophy9_sizey = 23.047;
$_trophy_trophy9_activated = 0;

/* implemented */
$_trophy_plaque1_name = "Best Stand: Castle";
$_trophy_plaque1_description = "Beat 10 Rounds In The Castle";
$_trophy_plaque1_image = "award_plaquesImageMap";
$_trophy_plaque1_frame = 0;
$_trophy_plaque1_sizex = 17.578;
$_trophy_plaque1_sizey = 12.500;
$_trophy_plaque1_activated = 0;

/* implemented */
$_trophy_plaque2_name = "Best Stand: Swamp";
$_trophy_plaque2_description = "Beat 10 Rounds In The Swamp";
$_trophy_plaque2_image = "award_plaquesImageMap";
$_trophy_plaque2_frame = 1;
$_trophy_plaque2_sizex = 17.578;
$_trophy_plaque2_sizey = 12.500;
$_trophy_plaque2_activated = 0;

/* implemented */
$_trophy_plaque3_name = "Best Stand: Airship";
$_trophy_plaque3_description = "Beat 10 Rounds In The Airship";
$_trophy_plaque3_image = "award_plaquesImageMap";
$_trophy_plaque3_frame = 2;
$_trophy_plaque3_sizex = 17.578;
$_trophy_plaque3_sizey = 12.500;
$_trophy_plaque3_activated = 0;

/* implemented */
$_trophy_plaque4_name = "Best Stand: Hawaii";
$_trophy_plaque4_description = "Beat 10 Rounds In Hawaii";
$_trophy_plaque4_image = "award_plaquesImageMap";
$_trophy_plaque4_frame = 3;
$_trophy_plaque4_sizex = 17.578;
$_trophy_plaque4_sizey = 12.500;
$_trophy_plaque4_activated = 0;

/* implemented */
$_trophy_plaque5_name = "Best Stand: Mead Hall";
$_trophy_plaque5_description = "Beat 10 Rounds In The Mead Hall";
$_trophy_plaque5_image = "award_plaquesImageMap";
$_trophy_plaque5_frame = 4;
$_trophy_plaque5_sizex = 17.578;
$_trophy_plaque5_sizey = 12.500;
$_trophy_plaque5_activated = 0;

/* implemented */
$_trophy_plaque6_name = "Best Stand: Dark Forest";
$_trophy_plaque6_description = "Beat 10 Rounds In The Dark Forest";
$_trophy_plaque6_image = "award_plaquesImageMap";
$_trophy_plaque6_frame = 5;
$_trophy_plaque6_sizex = 17.578;
$_trophy_plaque6_sizey = 12.500;
$_trophy_plaque6_activated = 0;

/* implemented */
$_trophy_plaque7_name = "Best Stand: Train";
$_trophy_plaque7_description = "Beat 10 Rounds In The Train";
$_trophy_plaque7_image = "award_plaquesImageMap";
$_trophy_plaque7_frame = 6;
$_trophy_plaque7_sizex = 17.578;
$_trophy_plaque7_sizey = 12.500;
$_trophy_plaque7_activated = 0;

/* implemented */
$_trophy_plaque8_name = "Best Stand: France";
$_trophy_plaque8_description = "Beat 10 Rounds In France";
$_trophy_plaque8_image = "award_plaquesImageMap";
$_trophy_plaque8_frame = 7;
$_trophy_plaque8_sizex = 17.578;
$_trophy_plaque8_sizey = 12.500;
$_trophy_plaque8_activated = 0;

/* implemented */
$_trophy_plaque9_name = "Best Stand: New York";
$_trophy_plaque9_description = "Beat 10 Rounds In New York";
$_trophy_plaque9_image = "award_plaquesImageMap";
$_trophy_plaque9_frame = 8;
$_trophy_plaque9_sizex = 17.578;
$_trophy_plaque9_sizey = 12.500;
$_trophy_plaque9_activated = 0;

/* implemented */
$_trophy_plaque10_name = "Best Stand: Hometown";
$_trophy_plaque10_description = "Beat 10 Rounds In Your Hometown";
$_trophy_plaque10_image = "award_plaquesImageMap";
$_trophy_plaque10_frame = 9;
$_trophy_plaque10_sizex = 17.578;
$_trophy_plaque10_sizey = 12.500;
$_trophy_plaque10_activated = 0;

/* implemented */
$_trophy_ribbon1_name = "Press Release";
$_trophy_ribbon1_description = "Get a Gold Medal With All Airship Press";
$_trophy_ribbon1_image = "award_ribbonsImageMap";
$_trophy_ribbon1_frame = 0;
$_trophy_ribbon1_sizex = 6.836;
$_trophy_ribbon1_sizey = 14.258;
$_trophy_ribbon1_activated = 0;

/* implemented */
$_trophy_ribbon2_name = "Celebrity Status";
$_trophy_ribbon2_description = "Impress All Hawaiian Celebrities";
$_trophy_ribbon2_image = "award_ribbonsImageMap";
$_trophy_ribbon2_frame = 1;
$_trophy_ribbon2_sizex = 6.836;
$_trophy_ribbon2_sizey = 14.258;
$_trophy_ribbon2_activated = 0;

/* implemented */
$_trophy_ribbon3_name = "Flawless Inspection";
$_trophy_ribbon3_description = "Get a Gold Medal With All Food Inspectors";
$_trophy_ribbon3_image = "award_ribbonsImageMap";
$_trophy_ribbon3_frame = 2;
$_trophy_ribbon3_sizex = 6.836;
$_trophy_ribbon3_sizey = 14.258;
$_trophy_ribbon3_activated = 0;

/* implemented */
$_trophy_ribbon4_name = "New York's Finest Stand";
$_trophy_ribbon4_description = "Impress The Big City 7 Rounds In a Row";
$_trophy_ribbon4_image = "award_ribbonsImageMap";
$_trophy_ribbon4_frame = 3;
$_trophy_ribbon4_sizex = 6.836;
$_trophy_ribbon4_sizey = 14.258;
$_trophy_ribbon4_activated = 0;

/* implemented */
$_trophy_ribbon5_name = "Best of France Magazine";
$_trophy_ribbon5_description = "Get a Gold Medal With All French Critics";
$_trophy_ribbon5_image = "award_ribbonsImageMap";
$_trophy_ribbon5_frame = 4;
$_trophy_ribbon5_sizex = 6.836;
$_trophy_ribbon5_sizey = 14.258;
$_trophy_ribbon5_activated = 0;

/* implemented */
$_trophy_ribbon6_name = "20 Best Bites";
$_trophy_ribbon6_description = "Serve 20 Different Appetizers";
$_trophy_ribbon6_image = "award_ribbonsImageMap";
$_trophy_ribbon6_frame = 5;
$_trophy_ribbon6_sizex = 6.836;
$_trophy_ribbon6_sizey = 14.258;
$_trophy_ribbon6_activated = 0;

/* implemented */
$_trophy_button1_name = "Cleaner Combo";
$_trophy_button1_description = "Clean 4 Dirty Tables In a Row";
$_trophy_button1_image = "award_buttonsImageMap";
$_trophy_button1_frame = 0;
$_trophy_button1_sizex = 3.809;
$_trophy_button1_sizey = 3.906;
$_trophy_button1_activated = 0;

/* implemented */
$_trophy_button2_name = "Frequent Flyer";
$_trophy_button2_description = "Catch 15 Golden Flyers";
$_trophy_button2_image = "award_buttonsImageMap";
$_trophy_button2_frame = 1;
$_trophy_button2_sizex = 3.809;
$_trophy_button2_sizey = 3.906;
$_trophy_button2_activated = 0;

/* implemented */
$_trophy_button3_name = "Happy Days";
$_trophy_button3_description = "No Angry Customers Two Days in a Row";
$_trophy_button3_image = "award_buttonsImageMap";
$_trophy_button3_frame = 2;
$_trophy_button3_sizex = 3.809;
$_trophy_button3_sizey = 3.906;
$_trophy_button3_activated = 0;

/* implemented */
$_trophy_button4_name = "Speedster: Delivery";
$_trophy_button4_description = "Serve a Drink Under The Minimum Time";
$_trophy_button4_image = "award_buttonsImageMap";
$_trophy_button4_frame = 3;
$_trophy_button4_sizex = 3.809;
$_trophy_button4_sizey = 3.906;
$_trophy_button4_activated = 0;

/* implemented */
$_trophy_button5_name = "Speedster: Order Taker";
$_trophy_button5_description = "Take an Order Under The Minimum Time";
$_trophy_button5_image = "award_buttonsImageMap";
$_trophy_button5_frame = 4;
$_trophy_button5_sizex = 3.809;
$_trophy_button5_sizey = 3.906;
$_trophy_button5_activated = 0;

/* implemented */
$_trophy_button6_name = "Speedster: Appetizer";
$_trophy_button6_description = "Serve an Appetizer Under The Min. Time";
$_trophy_button6_image = "award_buttonsImageMap";
$_trophy_button6_frame = 5;
$_trophy_button6_sizex = 3.809;
$_trophy_button6_sizey = 3.906;
$_trophy_button6_activated = 0;

/* implemented */
$_trophy_mount1_name = "Close Shave";
$_trophy_mount1_description = "Serve a Customer Right Before Leaving";
$_trophy_mount1_image = "award_mountsImageMap";
$_trophy_mount1_frame = 0;
$_trophy_mount1_sizex = 9.082;
$_trophy_mount1_sizey = 9.082;
$_trophy_mount1_activated = 0;

/* implemented */
$_trophy_mount2_name = "Upward Spiral";
$_trophy_mount2_description = "Click 20 Vortexes";
$_trophy_mount2_image = "award_mountsImageMap";
$_trophy_mount2_frame = 1;
$_trophy_mount2_sizex = 9.082;
$_trophy_mount2_sizey = 9.082;
$_trophy_mount2_activated = 0;

/* implemented */
$_trophy_mount3_name = "Mega Manager";
$_trophy_mount3_description = "Serve All Stands More Than 10 Rounds Each";
$_trophy_mount3_image = "award_mountsImageMap";
$_trophy_mount3_frame = 2;
$_trophy_mount3_sizex = 9.082;
$_trophy_mount3_sizey = 9.082;
$_trophy_mount3_activated = 0;

/* implemented */
$_trophy_mount4_name = "Sold Out";
$_trophy_mount4_description = "Beat Minimum Round Time";
$_trophy_mount4_image = "award_mountsImageMap";
$_trophy_mount4_frame = 3;
$_trophy_mount4_sizex = 9.082;
$_trophy_mount4_sizey = 9.082;
$_trophy_mount4_activated = 0;

/* implemented */
$_trophy_dollar_name = "First Paycheck";
$_trophy_dollar_description = "Collect Your First Paycheck";
$_trophy_dollar_image = "first_dollarImageMap";
$_trophy_dollar_frame = 0;
$_trophy_dollar_sizex = 15.039;
$_trophy_dollar_sizey = 13.086;
$_trophy_dollar_activated = 0;



$award_unlocked = "Award Unlocked: ";

/* Level Selection Menu */

$_level_world_text1 = "Castle";
$_level_world_text2 = "Swamp";
$_level_world_text3 = "Airship";
$_level_world_text4 = "Hawaii";
$_level_world_text5 = "Viking Isle";
$_level_world_text6 = "Haunted Forest";
$_level_world_text7 = "Train";
$_level_world_text8 = "France";
$_level_world_text9 = "New York";
$_level_world_text10 = "Hometown";


$special_dialog0 = "You Didn't Serve NOL CHAR Fast Enough!" NL "Try Again in";
$special_dialog1 = "You Didn't Serve The Celebrity Fast Enough!" NL "Try Again in";
$special_dialog2 = "You Didn't Serve The Press Fast Enough!" NL "Try Again in";
$special_dialog3 = "You Didn't Serve The Food Inspector Fast Enough!" NL "Try Again in";
$special_dialog4 = "You Didn't Serve The Critic Fast Enough!" NL "Try Again in";
$special_dialog5 = "You Didn't Serve The Mayor Fast Enough!" NL "Try Again in";
$special_dialog6 = "You Angered Too Many Customers!" NL "Try Again in";

$appetizer1_tag_text1 = "Hot Cross Buns";
$appetizer1_tag_text2 = "Crab Beignets";
$appetizer1_tag_text3 = "Gear Cookies";
$appetizer1_tag_text4 = "Taro Poi";
$appetizer1_tag_text5 = "Hot Gruel";
$appetizer1_tag_text6 = "Apples";
$appetizer1_tag_text7 = "Peanuts";
$appetizer1_tag_text8 = "Croissants";
$appetizer1_tag_text9 = "Coffee Cake";
$appetizer1_tag_text10 = "Brownies";

$appetizer2_tag_text1 = "House Wine";
$appetizer2_tag_text2 = "Sweet Tea";
$appetizer2_tag_text3 = "Champagne";
$appetizer2_tag_text4 = "Mai Tai";
$appetizer2_tag_text5 = "Mead";
$appetizer2_tag_text6 = "Witch's Brew";
$appetizer2_tag_text7 = "Ginger Ale";
$appetizer2_tag_text8 = "Red Wine";
$appetizer2_tag_text9 = "Cafe Latte";
$appetizer2_tag_text10 = "Soda Pop";

$entertainer1_tag_text1 = "Lute Player";
$entertainer1_tag_text2 = "Banjo Player";
$entertainer1_tag_text3 = "Bellhop";
$entertainer1_tag_text4 = "Hula Dancer";
$entertainer1_tag_text5 = "Viking Reveler";
$entertainer1_tag_text6 = "Ghost";
$entertainer1_tag_text7 = "Bellhop";
$entertainer1_tag_text8 = "Accordionist";
$entertainer1_tag_text9 = "Bongo Drummer";
$entertainer1_tag_text10 = "Keen Greaser";

$entertainer2_tag_text1 = "Juggler";
$entertainer2_tag_text2 = "Harmonicist";
$entertainer2_tag_text3 = "Magician";
$entertainer2_tag_text4 = "Hula Dancer";
$entertainer2_tag_text5 = "Viking Reveler";
$entertainer2_tag_text6 = "Ghost";
$entertainer2_tag_text7 = "Bellhop";
$entertainer2_tag_text8 = "Violinist";
$entertainer2_tag_text9 = "Bassist";
$entertainer2_tag_text10 = "Dancer";


$storyboard_france1 = "Paris, France."; 
$storyboard_france2 = "You arrived at the restaurant, where the owner from the airship was waiting for you."; 
$storyboard_france3 = "The owner told you that several of the top critics were in town and would be attending tonight.";    
$storyboard_france4 = "IMPORTANT: YOU MUST SERVE THIS CRITIC FAST ENOUGH TO WIN THE ROUND!"; 

$storyboard_metro1 = "The French approved! They were so pleased that they insisted you came to the International Food Convention in New York."; 
$storyboard_metro2 = "You booked your placement and celebrated with a glass of champagne, excited for your big break in New York City.";   
$storyboard_metro3 = "The next day you arrived and marveled at the size of the convention. Being wary though, you spotted crowds of health inspectors abound..."; 
$storyboard_metro4 = "IMPORTANT: YOU MUST SERVE THIS FOOD INSPECTOR FAST ENOUGH TO WIN THE ROUND!";       

$storyboard_hometown1 = "Your big debut was a success! You had won over the crowd and now, after your long, tiresome journey, it was time to go home.";        
$storyboard_hometown2 = "You returned home and decided it was time to turn your smoothie stand into a full fledged venue.";        
$storyboard_hometown3 = "Knowing the town mayor personally, you invited him for free drinks to help smooth the process of getting permits and licenses.";
$storyboard_hometown4 = "IMPORTANT: YOU MUST SERVE THE MAYOR FAST ENOUGH TO WIN THE ROUND!"; 
  
$storyboard_outro1 = "You have proven yourself and spread Callie's Creations all across the world. Who knows what's in store for Callie next!";        
$storyboard_outro2 = "Well done and congratulations!"; 

//////////////////////////////////////////////////////////////////////////////////////
/* TROPHY TEXT AND IMAGES */
//////////////////////////////////////////////////////////////////////////////////////

/* implemented */
$_trophy_trophy1_name = "Overtime";
$_trophy_trophy1_description = "Serve More Than 10 Days In 1 Stand";
$_trophy_trophy1_image = "award_trophiesImageMap";
$_trophy_trophy1_frame = 1;
$_trophy_trophy1_sizex = 11.621;
$_trophy_trophy1_sizey = 23.047;
$_trophy_trophy1_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy2_name = "Super Server";
$_trophy_trophy2_description = "Serve More Than 55 People In 1 Stand";
$_trophy_trophy2_image = "award_trophiesImageMap";
$_trophy_trophy2_frame = 2;
$_trophy_trophy2_sizex = 11.621;
$_trophy_trophy2_sizey = 23.047;
$_trophy_trophy2_activated = 0;

/* implemented */
$_trophy_trophy3_name = "5 In a Row";
$_trophy_trophy3_description = "Serve Five People In a Row";
$_trophy_trophy3_image = "award_trophiesImageMap";
$_trophy_trophy3_frame = 3;
$_trophy_trophy3_sizex = 11.621;
$_trophy_trophy3_sizey = 23.047;
$_trophy_trophy3_activated = 0;

/* implemented */
$_trophy_trophy4_name = "Half Way";
$_trophy_trophy4_description = "Make It Half Way Around The World";
$_trophy_trophy4_image = "award_trophiesImageMap";
$_trophy_trophy4_frame = 4;
$_trophy_trophy4_sizex = 11.621;
$_trophy_trophy4_sizey = 23.047;
$_trophy_trophy4_activated = 0;

/* implemented */
$_trophy_trophy5_name = "Round Trip";
$_trophy_trophy5_description = "Make It All The Way Around The World";
$_trophy_trophy5_image = "award_trophiesImageMap";
$_trophy_trophy5_frame = 5;
$_trophy_trophy5_sizex = 11.621;
$_trophy_trophy5_sizey = 23.047;
$_trophy_trophy5_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy6_name = "50 Served";
$_trophy_trophy6_description = "Serve 50 People";
$_trophy_trophy6_image = "award_trophiesImageMap";
$_trophy_trophy6_frame = 6;
$_trophy_trophy6_sizex = 11.621;
$_trophy_trophy6_sizey = 23.047;
$_trophy_trophy6_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy7_name = "100 Served";
$_trophy_trophy7_description = "Serve 100 People";
$_trophy_trophy7_image = "award_trophiesImageMap";
$_trophy_trophy7_frame = 7;
$_trophy_trophy7_sizex = 11.621;
$_trophy_trophy7_sizey = 23.047;
$_trophy_trophy7_activated = 0;

/* implemented with assumed winability based on logic */
$_trophy_trophy8_name = "200 Served";
$_trophy_trophy8_description = "Serve 200 People";
$_trophy_trophy8_image = "award_trophiesImageMap";
$_trophy_trophy8_frame = 8;
$_trophy_trophy8_sizex = 11.621;
$_trophy_trophy8_sizey = 23.047;
$_trophy_trophy8_activated = 0;

/* implemented */
$_trophy_trophy9_name = "Go For The Gold";
$_trophy_trophy9_description = "Get All Gold Stars In 1 Round";
$_trophy_trophy9_image = "award_trophiesImageMap";
$_trophy_trophy9_frame = 9;
$_trophy_trophy9_sizex = 11.621;
$_trophy_trophy9_sizey = 23.047;
$_trophy_trophy9_activated = 0;

/* implemented */
$_trophy_plaque1_name = "Best Stand: Castle";
$_trophy_plaque1_description = "Beat 10 Rounds In The Castle";
$_trophy_plaque1_image = "award_plaquesImageMap";
$_trophy_plaque1_frame = 0;
$_trophy_plaque1_sizex = 17.578;
$_trophy_plaque1_sizey = 12.500;
$_trophy_plaque1_activated = 0;

/* implemented */
$_trophy_plaque2_name = "Best Stand: Swamp";
$_trophy_plaque2_description = "Beat 10 Rounds In The Swamp";
$_trophy_plaque2_image = "award_plaquesImageMap";
$_trophy_plaque2_frame = 1;
$_trophy_plaque2_sizex = 17.578;
$_trophy_plaque2_sizey = 12.500;
$_trophy_plaque2_activated = 0;

/* implemented */
$_trophy_plaque3_name = "Best Stand: Airship";
$_trophy_plaque3_description = "Beat 10 Rounds In The Airship";
$_trophy_plaque3_image = "award_plaquesImageMap";
$_trophy_plaque3_frame = 2;
$_trophy_plaque3_sizex = 17.578;
$_trophy_plaque3_sizey = 12.500;
$_trophy_plaque3_activated = 0;

/* implemented */
$_trophy_plaque4_name = "Best Stand: Hawaii";
$_trophy_plaque4_description = "Beat 10 Rounds In Hawaii";
$_trophy_plaque4_image = "award_plaquesImageMap";
$_trophy_plaque4_frame = 3;
$_trophy_plaque4_sizex = 17.578;
$_trophy_plaque4_sizey = 12.500;
$_trophy_plaque4_activated = 0;

/* implemented */
$_trophy_plaque5_name = "Best Stand: Mead Hall";
$_trophy_plaque5_description = "Beat 10 Rounds In The Mead Hall";
$_trophy_plaque5_image = "award_plaquesImageMap";
$_trophy_plaque5_frame = 4;
$_trophy_plaque5_sizex = 17.578;
$_trophy_plaque5_sizey = 12.500;
$_trophy_plaque5_activated = 0;

/* implemented */
$_trophy_plaque6_name = "Best Stand: Dark Forest";
$_trophy_plaque6_description = "Beat 10 Rounds In The Dark Forest";
$_trophy_plaque6_image = "award_plaquesImageMap";
$_trophy_plaque6_frame = 5;
$_trophy_plaque6_sizex = 17.578;
$_trophy_plaque6_sizey = 12.500;
$_trophy_plaque6_activated = 0;

/* implemented */
$_trophy_plaque7_name = "Best Stand: Train";
$_trophy_plaque7_description = "Beat 10 Rounds In The Train";
$_trophy_plaque7_image = "award_plaquesImageMap";
$_trophy_plaque7_frame = 6;
$_trophy_plaque7_sizex = 17.578;
$_trophy_plaque7_sizey = 12.500;
$_trophy_plaque7_activated = 0;

/* implemented */
$_trophy_plaque8_name = "Best Stand: France";
$_trophy_plaque8_description = "Beat 10 Rounds In France";
$_trophy_plaque8_image = "award_plaquesImageMap";
$_trophy_plaque8_frame = 7;
$_trophy_plaque8_sizex = 17.578;
$_trophy_plaque8_sizey = 12.500;
$_trophy_plaque8_activated = 0;

/* implemented */
$_trophy_plaque9_name = "Best Stand: New York";
$_trophy_plaque9_description = "Beat 10 Rounds In New York";
$_trophy_plaque9_image = "award_plaquesImageMap";
$_trophy_plaque9_frame = 8;
$_trophy_plaque9_sizex = 17.578;
$_trophy_plaque9_sizey = 12.500;
$_trophy_plaque9_activated = 0;

/* implemented */
$_trophy_plaque10_name = "Best Stand: Hometown";
$_trophy_plaque10_description = "Beat 10 Rounds In Your Hometown";
$_trophy_plaque10_image = "award_plaquesImageMap";
$_trophy_plaque10_frame = 9;
$_trophy_plaque10_sizex = 17.578;
$_trophy_plaque10_sizey = 12.500;
$_trophy_plaque10_activated = 0;

/* implemented */
$_trophy_ribbon1_name = "Press Release";
$_trophy_ribbon1_description = "Get a Gold Medal With All Airship Press";
$_trophy_ribbon1_image = "award_ribbonsImageMap";
$_trophy_ribbon1_frame = 0;
$_trophy_ribbon1_sizex = 6.836;
$_trophy_ribbon1_sizey = 14.258;
$_trophy_ribbon1_activated = 0;

/* implemented */
$_trophy_ribbon2_name = "Celebrity Status";
$_trophy_ribbon2_description = "Impress All Hawaiian Celebrities";
$_trophy_ribbon2_image = "award_ribbonsImageMap";
$_trophy_ribbon2_frame = 1;
$_trophy_ribbon2_sizex = 6.836;
$_trophy_ribbon2_sizey = 14.258;
$_trophy_ribbon2_activated = 0;

/* implemented */
$_trophy_ribbon3_name = "Flawless Inspection";
$_trophy_ribbon3_description = "Get a Gold Medal With All Food Inspectors";
$_trophy_ribbon3_image = "award_ribbonsImageMap";
$_trophy_ribbon3_frame = 2;
$_trophy_ribbon3_sizex = 6.836;
$_trophy_ribbon3_sizey = 14.258;
$_trophy_ribbon3_activated = 0;

/* implemented */
$_trophy_ribbon4_name = "New York's Finest Stand";
$_trophy_ribbon4_description = "Impress The Big City 7 Rounds In a Row";
$_trophy_ribbon4_image = "award_ribbonsImageMap";
$_trophy_ribbon4_frame = 3;
$_trophy_ribbon4_sizex = 6.836;
$_trophy_ribbon4_sizey = 14.258;
$_trophy_ribbon4_activated = 0;

/* implemented */
$_trophy_ribbon5_name = "Best of France Magazine";
$_trophy_ribbon5_description = "Get a Gold Medal With All French Critics";
$_trophy_ribbon5_image = "award_ribbonsImageMap";
$_trophy_ribbon5_frame = 4;
$_trophy_ribbon5_sizex = 6.836;
$_trophy_ribbon5_sizey = 14.258;
$_trophy_ribbon5_activated = 0;

/* implemented */
$_trophy_ribbon6_name = "20 Best Bites";
$_trophy_ribbon6_description = "Serve 20 Different Appetizers";
$_trophy_ribbon6_image = "award_ribbonsImageMap";
$_trophy_ribbon6_frame = 5;
$_trophy_ribbon6_sizex = 6.836;
$_trophy_ribbon6_sizey = 14.258;
$_trophy_ribbon6_activated = 0;

/* implemented */
$_trophy_button1_name = "Cleaner Combo";
$_trophy_button1_description = "Clean 4 Dirty Tables In a Row";
$_trophy_button1_image = "award_buttonsImageMap";
$_trophy_button1_frame = 0;
$_trophy_button1_sizex = 3.809;
$_trophy_button1_sizey = 3.906;
$_trophy_button1_activated = 0;

/* implemented */
$_trophy_button2_name = "Frequent Flyer";
$_trophy_button2_description = "Catch 15 Golden Flyers";
$_trophy_button2_image = "award_buttonsImageMap";
$_trophy_button2_frame = 1;
$_trophy_button2_sizex = 3.809;
$_trophy_button2_sizey = 3.906;
$_trophy_button2_activated = 0;

/* implemented */
$_trophy_button3_name = "Happy Days";
$_trophy_button3_description = "No Angry Customers Two Days in a Row";
$_trophy_button3_image = "award_buttonsImageMap";
$_trophy_button3_frame = 2;
$_trophy_button3_sizex = 3.809;
$_trophy_button3_sizey = 3.906;
$_trophy_button3_activated = 0;

/* implemented */
$_trophy_button4_name = "Speedster: Delivery";
$_trophy_button4_description = "Serve a Drink Under The Minimum Time";
$_trophy_button4_image = "award_buttonsImageMap";
$_trophy_button4_frame = 3;
$_trophy_button4_sizex = 3.809;
$_trophy_button4_sizey = 3.906;
$_trophy_button4_activated = 0;

/* implemented */
$_trophy_button5_name = "Speedster: Order Taker";
$_trophy_button5_description = "Take an Order Under The Minimum Time";
$_trophy_button5_image = "award_buttonsImageMap";
$_trophy_button5_frame = 4;
$_trophy_button5_sizex = 3.809;
$_trophy_button5_sizey = 3.906;
$_trophy_button5_activated = 0;

/* implemented */
$_trophy_button6_name = "Speedster: Appetizer";
$_trophy_button6_description = "Serve an Appetizer Under The Min. Time";
$_trophy_button6_image = "award_buttonsImageMap";
$_trophy_button6_frame = 5;
$_trophy_button6_sizex = 3.809;
$_trophy_button6_sizey = 3.906;
$_trophy_button6_activated = 0;

/* implemented */
$_trophy_mount1_name = "Close Shave";
$_trophy_mount1_description = "Serve a Customer Right Before Leaving";
$_trophy_mount1_image = "award_mountsImageMap";
$_trophy_mount1_frame = 0;
$_trophy_mount1_sizex = 9.082;
$_trophy_mount1_sizey = 9.082;
$_trophy_mount1_activated = 0;

/* implemented */
$_trophy_mount2_name = "Upward Spiral";
$_trophy_mount2_description = "Click 20 Vortexes";
$_trophy_mount2_image = "award_mountsImageMap";
$_trophy_mount2_frame = 1;
$_trophy_mount2_sizex = 9.082;
$_trophy_mount2_sizey = 9.082;
$_trophy_mount2_activated = 0;

/* implemented */
$_trophy_mount3_name = "Mega Manager";
$_trophy_mount3_description = "Serve All Stands More Than 10 Rounds Each";
$_trophy_mount3_image = "award_mountsImageMap";
$_trophy_mount3_frame = 2;
$_trophy_mount3_sizex = 9.082;
$_trophy_mount3_sizey = 9.082;
$_trophy_mount3_activated = 0;

/* implemented */
$_trophy_mount4_name = "Sold Out";
$_trophy_mount4_description = "Beat Minimum Round Time";
$_trophy_mount4_image = "award_mountsImageMap";
$_trophy_mount4_frame = 3;
$_trophy_mount4_sizex = 9.082;
$_trophy_mount4_sizey = 9.082;
$_trophy_mount4_activated = 0;

/* implemented */
$_trophy_dollar_name = "First Paycheck";
$_trophy_dollar_description = "Collect Your First Paycheck";
$_trophy_dollar_image = "first_dollarImageMap";
$_trophy_dollar_frame = 0;
$_trophy_dollar_sizex = 15.039;
$_trophy_dollar_sizey = 13.086;
$_trophy_dollar_activated = 0;



$award_unlocked = "Award Unlocked: ";

/* Level Selection Menu */

$_level_world_text1 = "Castle";
$_level_world_text2 = "Swamp";
$_level_world_text3 = "Airship";
$_level_world_text4 = "Hawaii";
$_level_world_text5 = "Viking Isle";
$_level_world_text6 = "Haunted Forest";
$_level_world_text7 = "Train";
$_level_world_text8 = "France";
$_level_world_text9 = "New York";
$_level_world_text10 = "Hometown";


$special_dialog0 = "You Didn't Serve NOL CHAR Fast Enough!" NL "Try Again in";
$special_dialog1 = "You Didn't Serve The Celebrity Fast Enough!" NL "Try Again in";
$special_dialog2 = "You Didn't Serve The Press Fast Enough!" NL "Try Again in";
$special_dialog3 = "You Didn't Serve The Food Inspector Fast Enough!" NL "Try Again in";
$special_dialog4 = "You Didn't Serve The Critic Fast Enough!" NL "Try Again in";
$special_dialog5 = "You Didn't Serve The Mayor Fast Enough!" NL "Try Again in";
$special_dialog6 = "You Angered Too Many Customers!" NL "Try Again in";

$appetizer1_tag_text1 = "Hot Cross Buns";
$appetizer1_tag_text2 = "Crab Beignets";
$appetizer1_tag_text3 = "Gear Cookies";
$appetizer1_tag_text4 = "Taro Poi";
$appetizer1_tag_text5 = "Hot Gruel";
$appetizer1_tag_text6 = "Apples";
$appetizer1_tag_text7 = "Peanuts";
$appetizer1_tag_text8 = "Croissants";
$appetizer1_tag_text9 = "Coffee Cake";
$appetizer1_tag_text10 = "Brownies";

$appetizer2_tag_text1 = "House Wine";
$appetizer2_tag_text2 = "Sweet Tea";
$appetizer2_tag_text3 = "Champagne";
$appetizer2_tag_text4 = "Mai Tai";
$appetizer2_tag_text5 = "Mead";
$appetizer2_tag_text6 = "Witch's Brew";
$appetizer2_tag_text7 = "Ginger Ale";
$appetizer2_tag_text8 = "Red Wine";
$appetizer2_tag_text9 = "Cafe Latte";
$appetizer2_tag_text10 = "Soda Pop";

$entertainer1_tag_text1 = "Lute Player";
$entertainer1_tag_text2 = "Banjo Player";
$entertainer1_tag_text3 = "Bellhop";
$entertainer1_tag_text4 = "Hula Dancer";
$entertainer1_tag_text5 = "Viking Reveler";
$entertainer1_tag_text6 = "Ghost";
$entertainer1_tag_text7 = "Bellhop";
$entertainer1_tag_text8 = "Accordionist";
$entertainer1_tag_text9 = "Bongo Drummer";
$entertainer1_tag_text10 = "Keen Greaser";

$entertainer2_tag_text1 = "Juggler";
$entertainer2_tag_text2 = "Harmonicist";
$entertainer2_tag_text3 = "Magician";
$entertainer2_tag_text4 = "Hula Dancer";
$entertainer2_tag_text5 = "Viking Reveler";
$entertainer2_tag_text6 = "Ghost";
$entertainer2_tag_text7 = "Bellhop";
$entertainer2_tag_text8 = "Violinist";
$entertainer2_tag_text9 = "Bassist";
$entertainer2_tag_text10 = "Dancer";

