# Achieved Sprint 1 Result focus #1

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

![Name of the animation](https://github.com/linkt-to-the-animation-in-the-products-and-code-folder)
![freelook](https://gyazo.com/c38556fccc22aaf4741adc6100b2296c)

> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Link to the commits](https://github.com/link-to-the-animatie)| Name of the scene(s) | Path to the GameObject that uses the script(s) | Name of the scripts
|[Link to the commits](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/29/commits)| CinemachineResearch.unity | Prefabs/Cinemachine/prototype/playerPrototype |CAMERA_STATE CamErrorHandler CameraController LocalAreaCameraController CamPrototypePlayerController

## Research results

> If your focus involved doing a research describe in what way you've answered your research question(s)/

Research question 1:
Is the Unity Cinemachine a good fit for our project?

Answer:
Yes, the Unity Cinemachine a good fit for our project. The Unity Cinemachine provides functionalities that do everything we want in this project with very little code.


Research question 2:
Do we need to write any code to add to the Unity Cinemachine camera's?

Answer:
We may need to write some code to add to the Unity Cinemachine camera's. The freelook camera that re-centers itself on the player works without any code. However, if we want any special camera's -a locked perspective cam for example- then we will need to write some code. This will mainly be code that alters the priority of camera's based on what area the player is in.

Research question 3:
How are transitions between camera's done in cinemachine?

Answer:
Transitions between camera's in cinemachine can be done in a number of ways. The main methods are; ease in, ease out, or cut. You can set these transitions per camera, change the default settings. You can also set a custom curve for the camera to follow when floating over to another camera.

## Found sources

> Provide a link to the new source(s) you found and used this week to achieve this result.
You may also include sources that turned out not to provide useful information.

1. [Google](http://www.google.com)  Used to find resources. Exceptionally usefull.
2. [Unity about dollytracks](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.3/manual/CinemachineDolly.html) Very usefull for explaining how to setup a dolly track.
3. [Unity cinemachine tutorials](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/index.html) Very usefull for explaining how to get started with cinemachine.


> Also provide a summary of the content of the source and the usefulness and/or effect on the answer.

## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.
All of my code will be integrated with the final project, so i'm happy about that. I did make 2 camera's that could not be used in the project. Both of these are useless because Cinemachine provides better camera's, even if they take a bit more effort.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for next sprint and what you will keep the same in order to improve the integration process.

The cinemachine does a lot more than I expected from the workshop provided by the cinemachine research group. It has got some problems with reported bugs not being solved though. I have run into this during my research, but I don't have any suitable research question to not this issue under.
The research part of this research was fairly easy as cinemachine is a well documented and commonly used part of Unity. Therefore for all issues I had I was able to find
