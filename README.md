# PlayMaker ProceduralMusicGenerator
 PlayMaker actions for ProceduralMusicGenerator in Unity

Gracious thanks to Stick and Bindle for <b>Procedural Music Generator</b> on the Unity Asset Store.  
https://assetstore.unity.com/packages/audio/music/procedural-music-generator-192532

<small><i>These PlayMaker actions are compatable with Procedural Music Generator 2.0 (released June 13, 2022)</i></small>

INSTRUCTIONS:   
Copy the MusicGeneratorPlaymaker folder to your Unity Assets. Actions appear in the PlayMaker Action Browser.

suggested uses
  
1. PLAY GENERATIVE SOUNDTRACKS  
(RPG, visual novel, open world, etc)  

The basic idea is to load configs and let them play in the background.
  
– Load PMG Configs by name  
– Play, Pause, and Stop  
– Fade In/Out, and set the Master Volume  
– Get the Generator State (know when PMG is ready, initializing, playing, etc)  
– Read config data (Name, Key, Scale, Tempo, etc),  
– Get an array of the custom Instrument Names  
  
2. MANIPULATE GENERATIVE COMPOSITIONS  
(interactive and reactive music)  

Exposes many of PMG's functions and variables to PlayMaker state machines. You can create evolving compositions beyond PMG's configs limitations, and create game mechanics that interact with the music.
  
– Override, Get and Set Groups  
– Set odds on GroupChange, ProgressionChange, LeitmotifTheme, KeyChange  
– suspend Leitmotif notes  
– Create percussion breaks, instrument solos, and alternate arrangements  
– trigger instrument succession notes picked by the Generator (always in harmony)   
– State machine events for NotePlayed, NewMeasure, and ProgressionGenerated  
– Synchronize PlayMaker states with the soundtrack's evolution, and vice-versa  
– Trigger lights, particles, animations and more!
  
3. INSTRUMENTS, SEQUENCERS, and DRUM MACHINES  
(Music toys, Synths, and Rhythm boxes)  

PMG's Editer UI is the best app for programming configs, but with these actions you can connect PMG to abstract interfaces, program beat-loops, and trigger instrument samples.  PMG can feed notes to 3rd-party synths and Midi soundfonts.
  
– Free-Play PMG Instruments and Percussion  
– Set Tempo, Key, Scale, and Time Signature  
– Read the current harmonic Chord Progression  
– Edit Leitmotif’s 8-progression chords in real-time, individually or as an array  
– Mute and Solo individual instruments  
– Sort Instruments by their custom names, by percussion type, or synth  
– Set the ManualBeats on any Instrument  
– create a 16-step sequencer or harmonic rhythm machine!   
– Intercept notes from a specific Instrument and suppress Generator from playing  
– Route individual instruments via PlayMaker (to Midi, OSC, Helm Synth, etc)  
  


4. WHAT THESE ACTIONS CAN’T DO  
(PMG features that are not yet supported)  
  
– Writing/saving Configs  
– Play 'SingleClip' Measures  
– Control AudioMixer Global SFX  
– Control AudioMixer Instrument SFX  
– Control Synth parameters  


  
