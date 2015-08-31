# Vaulter
Fallout Shelter Save Editor

Found a program to decrypt the Fallout Shelter save files from Android but
that was all it did, so I've decided to start making something with a few
more features to make editing the save data even easier and hopefully safer.

In the very very very early stages, seriously don't expect much!

Implemented so far:
- Decrypt and open files in .sav format (only tested saves from Android)
- Encrypt and save files in .sav format
- Rough cut of the class structure to hold data from the decrypted JSON
- Editing of vault: Name
- Editing of stored: Caps, Energy, Food, Water, StimPack and RadAway (tested on Android)

Notes:
- Uses the JSON.net library to simplify reading the save data
- Only tested with saves from Android
- I'm very new to C# so if I do anything too nasty do let me know, I'm here to learn too!
- I'm not particularly keen to include LunchBox manipulation, I don't want to discourage Bethesda from continuing to improve the game in the future
- When copying your edited save file back to your Android device ensure that you completely close Fallout Shelter first. Failing to do may result in your changes being overwritten by the running app.
	  
	  Fork, share and enjoy :)
