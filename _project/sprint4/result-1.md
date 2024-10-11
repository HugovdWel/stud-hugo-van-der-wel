# Achieved Sprint 4 Result focus #1

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

![Name of the animation](https://github.com/linkt-to-the-animation-in-the-products-and-code-folder)

> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Link to the commits](https://github.com/link-to-the-animatie)| Name of the scene(s) | Path to the GameObject that uses the script(s) | Name of the scripts


### Camera zone bugfix
There is a bug where loading the game locks the camera perspective if the player dies in a cam zone. The ideal result is that the camera perspective is the correct one.
Result: Successfully fixed. The problem existed in the fact that the player never exited the camera zone trigger collider since the player teleported out. The solution was altering the state machine that regulates camera states. It now takes the player death state as a reason to exit the special camera state. 

<img width="689" alt="image" src="https://user-images.githubusercontent.com/47315594/212564919-101a2e37-b6f4-4ea0-b98b-ab8a62ae1713.png">
There were then more issues because the UI controller unfreezes the player controlls every single frame, which caused the player camera lock to break in every camera zone. I fixed that by implementing a boolean that stops the UI update when the player enters a camera zone.

<img width="655" alt="image" src="https://user-images.githubusercontent.com/47315594/212565100-dffa1110-28dd-48e4-9d36-2df250c06b72.png">



### Asha cutscene
There will be a dialogue file that is played inside Asha's house. I need to make a make house that uses a background png and shows Asha talking.
Result: There is now a cabin far below the world, where the cutschene plays. It has walls to block out external light, and a basic Asha model without any scripts that's permanently doing the talking animation. The left wall glows purple to show that Asha is really inside the room. I initially had the right wall shine blue, but Luc and India didn't like that.
There is a camera in the room, and the cutscene activates by setting that camera to active. The only integration in the main scene is dragging the prefab into the scene and draggin the camera into Asha's camera list. The script then got a [Camera:1] tag, and it worked.
When fog was added that needed to be turned off when entering the cutscene.

<img width="267" alt="image" src="https://user-images.githubusercontent.com/47315594/212563667-a37ef35c-b67a-43cd-a713-77d46bcd81a2.png">
Location of house

<img width="729" alt="image" src="https://user-images.githubusercontent.com/47315594/212563694-0b75c70c-da00-49fa-b092-2a0c57aedb72.png">
Scene inside house

<img width="743" alt="image" src="https://user-images.githubusercontent.com/47315594/212563704-a175bb04-8ac8-4cd6-9499-ba0b894a85c8.png">
Asha model

![Gif of the cutscene](https://gyazo.com/e3f4018cb2e25a179df8c608ad604ce9.gif)

<img width="657" alt="image" src="https://user-images.githubusercontent.com/47315594/212564048-32a668e8-9f0b-4506-b023-d7be95a7815d.png">
Script with camera reference



### Npc loading at checkpoints
Right now Asha teleports back to the start when loading a checkpoint. The ideal outcome is that she's standing next to her house when any checkpoint is loaded.
Result: Asha now teleports to a node, and that node is immediately set as her destination. That way the node effects (such as a new dialogue file) can also be triggered.


### Npc script improvements
The NPCs must have at the very least 1 path node right now, or the script throws errors and crashes. The ideal outcome is that the NPC's do not need a pathnode.
Result: Fixed. there is now a nullcheck that allows for the skipping of all start functions that activate routes. 

<img width="654" alt="image" src="https://user-images.githubusercontent.com/47315594/212564505-6deab88e-aa65-4a76-ab48-f9a0dc06dd1c.png">
Script with git blame with edit dates. 

<img width="238" alt="image" src="https://user-images.githubusercontent.com/47315594/212564547-2c4ee69c-4fa4-4a5c-b920-0a42f5397969.png">
In the update it also does a null check to see if the path node has been updates. This way it instantly starts a new route if it is set.


### Memory bugfix
The memories show the "F to interact" button while inside the memory. This tooltip should be hidden while inside the memory.
Result: I ended up having to extract the code that handles memories from the UI controller. Then there was a second problem where the UI controller update loop constantly kept adding the tooltip back onto the schreen. This was because the item was only removed from the gameworld after the memory completed. By removing the item before the memory started, the player cannot see the memory, and therefore the tooltip anymore.

<img width="543" alt="image" src="https://user-images.githubusercontent.com/47315594/212566147-aff7439a-428e-4cc8-b2bb-1a29f57362fb.png">
code where the order was changed


## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for next sprint and what you will keep the same in order to improve the integration process.

I am extremely pleased that we were able to integrate every single open task that we planned to do. Although admittedly we did work two full work days on the last day of work to make that happen.
Maybe next project we should keep following the git workflow more closely near the deadlines. This deadline we kind of just told other people to appove a request, and if there was nothing worrying in the file differences, they just approved without testing. This causes a massive speed up for work speed, but a much higher chance of bugs being unnoticed.

