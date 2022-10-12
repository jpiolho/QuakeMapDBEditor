# Quake MapDB Editor

A .NET Core utility program to edit Quake 2021 Enhanced mapdb.json

![Program](/docs/program.png)

## Auto Generation

The editor features a tool that allows auto generating map and mod entries by searching and analyzing installed mods on your computer.

* Searches for maps inside maps folder and .pak files
* Automatically pulls the map title from the bsp
* Automatically determines the capabilities of the map based on info_player_start, info_player_deathmatch and info_player_coop. As well if there's a .nav file available for bot support.
* Supports searching in both Quake (installed mods) and Saved Games folder (downloaded addons)

### Mod Name
When writing the mod entry, it will search for a file `mod.json` inside the mod folder (Currently doesn't support pak). This file contains the display name for the mod:
```json
{
  "name": "My mod name here"
}
```
