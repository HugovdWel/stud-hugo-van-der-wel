# Achieved Sprint 3 Result focus #2

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

Scene view
![Scene view](https://user-images.githubusercontent.com/47315594/208317597-74c49b74-a686-40df-b4ce-3542da1afbf6.png)

View of the gameobject of a pathnode
![View of the gameobject of a pathnode](https://user-images.githubusercontent.com/47315594/208317664-3812cfce-4115-478e-82ad-9d5188f3bec2.png)

Document with the new syntax that is used in a node
![Document with the new syntax that is used in a node](https://user-images.githubusercontent.com/47315594/208317683-3cdb17d7-3aaa-4db2-be68-78b195bf08ae.png)

dialogue switching
![dialogue switching](https://gyazo.com/76ab6b74dacd6316dead5a6448fdacf4.gif)

Script stop start
![Script stop start](https://user-images.githubusercontent.com/47315594/208317996-e201c531-df74-437d-b668-acc7ad1118ae.png)




> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Link to the commits](https://github.com/link-to-the-animatie)| Name of the scene(s) | Path to the GameObject that uses the script(s) | Name of the scripts


![image](https://user-images.githubusercontent.com/47315594/208104152-32900eb0-b701-4296-94bc-8fa0f7560ae9.png) https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/203/commits

All contributions can be found in the game scene.

The scripts are:
StopNpcStartDialog DialogBuilder UIController

The result is that the Asha dialogue has been loaded in the game scene, and that a lot of functions have been added to the dialogue system. It can now load in new dialogue files on the run. You also have a dialogue that can only be accessed once. This is all specifically added to support the requirements set by design for dialogue in the scene.


## Research results

> If your focus involved doing a research describe in what way you've answered your research question(s)/

## Found sources

> Provide a link to the new source(s) you found and used this week to achieve this result.
You may also include sources that turned out not to provide useful information.

1. [link to source](http://www.google.com)  

> Also provide a summary of the content of the source and the usefulness and/or effect on the answer.

## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for next sprint and what you will keep the same in order to improve the integration process.

It went really well. There were some features that the dialogue system didn't have, but that needed. Nathan and I worked together to quickly make the system more robust and add the functionality we needed to realize the requirements of Nick from design. 
the ~ syntax indicates that the script should only be accessible once, and the stop start script makes sure the npc waits at a node until the player has interacted with the npc. We have made it a low coupling class by using c# events instead of a object reference. This did introduce some gliches at first, but remove a lot of dependencies.
I would like to do this much sooner than the day before the terrible thursday next time, as we were under heavy stress caused by time pressure. 
You can see the system work at it's best in the opening scene with Asha.
