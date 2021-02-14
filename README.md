# Singleton-test
Basic program to test singleton. Unity version: 2019.3.5.f1

This program consists in two scenes: "Denmark" (Scene1) and "Vinland" (Scene2). The singleton is the KingOfTheWorld 
Game Object and is persistent between scenes. In "Denmark", after clicking in the "To Vinland" button, "Vinland" is 
loaded and the singleton persists (KingOfTheWorld). In "Vinland", after clicking in "To Denmark" button, "Denmark" 
is loaded again and the singleton keeps persisting, but now with 2 Kings (2 KingOfTheWorld Game Objects). I setted 
a timer to destroy the second instance and to be possible to see in the inspector that this instance is destroyed. 
When a second instance is destroyed, I print a message in the console and increase in 1 the kills counter in the scene 
(like the real king killing the fake king). I also change the name of the real king for each kill, adding the number 
of kills in the Game Object name (KingOfTheWorld1, KingOfTheWorld2,...), to be easier to differenciate the persistent 
instance and the instances that are destroyed.


