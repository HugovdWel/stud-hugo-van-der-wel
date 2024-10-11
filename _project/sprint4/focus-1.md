# Describe Sprint 4 focus #1

## Description of the intended result(s)

> Provide a description of the result here.

> If you are doing a research, try to come up with the research question or questions.

> It is likely that around half way the project you will pick up a wider variety of small tasks or bug fixes. In this situation you can collect these tasks in a single focus. 

### Camera zone bugfix
There is a bug where loading the game locks the camera perspective if the player dies in a cam zone. The ideal result is that the camera perspective is the correct one.
If this bug is not fixed, the game can become unplayable due to the player not seeing their character.

### Asha cutscene
There will be a dialogue file that is played inside Asha's house. I need to make a make house that uses a background png and shows Asha talking.
I will need to make it look like te scene is actually happening in the house. This will probably include lights since there are glowing vials on the background of the image, and Asha is a witch. I'll also try to implement it without any additional scripts, as those will clutter up the assets folders.

### Npc loading at checkpoints
Right now Asha teleports back to the start when loading a checkpoint. The ideal outcome is that she's standing next to her house when any checkpoint is loaded.
For this issue Niels depends on me to help fix it due to my knowledge of the NPC system. If I cannot help solve this properly it will take Niels a long time to figure out how the NPC ststem is working, and that is very bad for the integration speed in general as he is working in the main scene for this.

### Npc script improvements
The NPC's must have at the very least 1 path node right now, or the script throws errors and crashes. The ideal outcome is that the NPC's do not need a pathnode.
If I do not fix this problem the NPCs can either move or not move at all during the game. That would be a great burden for design to deal with, as it is to be expected that some NPCs will start moving a different route during the run of the game.

### Memory bugfix
The memories show the "F to interact" button while inside the memory. This tooltip should be hidden while inside the memory.
This problem breaks the player out of the moment of the memory. For game flow sake it must be fixed.


## Project integration

> Explain the way your results are integrated in the complete game. Specify from which team(s) and people you need input from and which team(s) and people will likely use your results. Use the table below

| Result | Input From (team - person) | Output To (team - person) |
|---|---|---|
|Camera zone bugfix |Niels, programming. Found the bug and told me how to reproduce it |Niels, programming. Reported the bug was fixed |
|Asha cutscene |Luc, product owner; India, art lead. Art had already made the background png I was supposed to use, so they provided that one as well as feedback and suggested changes for the fake house. | India, Luc. Based on the initial assignment and background I got, I made the house and showed it to them to recieve feedback|
|Npc loading at checkpoints |Niels asked me for help on the issue. Showed me what was happening and asked how my NPC controller could best be used to fix it |Niels. He implemented the fix |
|Npc script improvements |Luka. He came with the request to fix the bug. |Niels, Luka. They needed my code to stop the errors. |
|Memory bugfix |Luka Nathan. They both had input about where the bug might be happening. |Niels. He was assembling the scene, and needed to know where to store the memories. |

## Planned tasks

> Provide a idea of the tasks you think you need to do in order to obtain the intended result(s). Use the table below.

| When (indication) | Task | With Whom (from which team) |
|---|---|---|
|Week 1 |Fix cam bug and open pull request |Alone  |
|Week 1 |Create Asha cutscene |Alone  |
|Week 1 |Implement Asha cutscene in main scene |Niels  |
|Week 1 |Npc loading at checkpoints |Niels  |
|Week 1 |Npc script improvements |Alone  |
|Week 1 |Memory bugfix |Luka, Nathan  |
|  |  |  |

Side note: the few days of week 2 are meant solely for integration.
