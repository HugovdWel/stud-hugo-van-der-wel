# Achieved Sprint 2 Result focus #2

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

![Nodes as seen in runtimes with gizmos on. Trigger node triggering.](https://gyazo.com/cc756b2ec36887de82681148f2aa118c)
![Nodes as seen in runtimes with gizmos on. Trigger node triggering.](https://user-images.githubusercontent.com/47315594/205515884-f47927ef-8c8d-417a-ab60-19eadf8edbd5.png)
![View of test track with many different types of nodes in edit mode.](https://cdn.discordapp.com/attachments/1036702759254237184/1044929304024317962/image.png)
![View of NPC following the nodes in patrol mode in game mode. Shows how navmesh is active.](https://gyazo.com/1fbfbb2bc752e26b761c70c96b89e67d)
![NpcMoveNodeTriggerScript](https://user-images.githubusercontent.com/47315594/205516390-60d77f19-a09d-4512-b640-4b948e501f02.png)
![Top of NPC movement controller](https://user-images.githubusercontent.com/47315594/205516421-834b973b-5662-445e-b946-c0438a730938.png)
![Bottom of NPC movement controller](https://user-images.githubusercontent.com/47315594/205516444-36227ce7-2df5-4d2a-903a-0851366537aa.png)
![Nodes in demo scene](https://user-images.githubusercontent.com/47315594/205516511-f4b435c7-751e-432c-a88a-f71572dae86f.png)
![Nodes hiding in demo scene when it runs](https://user-images.githubusercontent.com/47315594/205516524-34bd22da-2c46-4c90-b1f5-bf7d44271681.png)
![Node config component](https://user-images.githubusercontent.com/47315594/205516551-183adee8-cb99-4efb-b421-f5971e9f0d61.png)




> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[28 commits in pull req](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/89/commits)| Name of the scene(blockout scene, npv dev scene) | NPC | Name of the scripts

## Research results

> If your focus involved doing a research describe in what way you've answered your research question(s)/


### Sub questions:
Are there any plugins that implement character movement?
There is a small number of plugins that implement vehicle movement, but those are against fairly high prices. I could find no free unity plugins that provide the type of character movement system that we need.


#### Does Unity provide a package for character movement?
Unity provides the navmesh component in the base project. There is no need to install any extra packages.The navmesh agent does not provide all the functionality that we want. It lacks the option to queue destinations, and the characters slow down when approaching a waypoint. These problems can be fixed by making a controller class. 


#### How hard is it to implement character movement ourselves ?
To fully implement character movement ourselves  would by marginally more difficult that using the unity navmesh agent. It would however lack the navmesh functionality that the navmesh agent can use. Therefore it is not recommendable to ignore the unity navmesh agent and make our own implementation.


### Main question:
What is the best way to implement the movement of NPC's in this project?
The best way to implement NPC navigation and movement in this project is by using the Unity navmesh agent in combination with a controller class we will create. The controller class is needed because we want to create a linked set of destinations, which the navmeshagent does not support.

## Found sources

> Provide a link to the new source(s) you found and used this week to achieve this result.
You may also include sources that turned out not to provide useful information.

1. [google](http://www.google.com)  Extremely useful
2. [https://docs.unity3d.com/ScriptReference/AI.NavMeshAgent.html](https://docs.unity3d.com/ScriptReference/AI.NavMeshAgent.html)  Useful for showing navmesh agent and it's limitations
3. [https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html](https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html)  Useful for showing how navmesh works
4. [https://assetstore.unity.com/?q=npc%20movement&orderBy=1](https://assetstore.unity.com/?q=npc%20movement&orderBy=1)  Not useful because this plugin costs a lot of money.
5. [https://assetstore.unity.com/?q=npc%20movement&orderBy=1](https://assetstore.unity.com/?q=npc%20movement&orderBy=1)  Useful for determining the plugins unity provides for character movement.

> Also provide a summary of the content of the source and the usefulness and/or effect on the answer.

## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for next sprint and what you will keep the same in order to improve the integration process.

The final navmesh system is integrated in the demolevel and works almost perfectly. The only thing that is missing is the ability to rotate npc's on a node. It turned into a system with many options for the level designer. These include setting the speed, the rounding distance and the wait time at a node. The NPC can also trigger a script when it arrives at a node. I will probably iterate on the system next sprint in order to add the shortcomings I discovered during the integration. I am very happy with how the end product turned out. I added a visual aid on every node so that the level designer can see where the nodes are and what effect they have. This is extremely useful and I will keep implementing features like this.
