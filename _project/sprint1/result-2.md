# Achieved Sprint 1 Result focus #2

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

![Name of the animation](https://github.com/linkt-to-the-animation-in-the-products-and-code-folder)

> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Link to the commits](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/41/commits)| NPC_dev_scene | N/A: any object that can use the navmesh will work with this script | NpcMovementController 
|[Link to the commits](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/41/commits)| NPC_dev_scene | Prefab/Npc/Pathnode | ShowObjectOnlyInEditor PathnodeEventTrigger 

## Research results

> If your focus involved doing a research describe in what way you've answered your research question(s)/

What are our most important qualifications for a method of making NPC's walk?
The most important qualifications for a method of making NPC's walk are the following:
1. Easy to use
    It needs to be easy for whoever builds the levels to make or change paths.
2. Reliable
    It needs to be able to deal with unexpected circomstances such as the player getting in the way of a path
3. Triggers
    It needs to be able to trigger events when a certain position has been reached.


What options can be used to make a NPC travel from one place to another according to the qualifiers?
The first opion to make a NPC travel according to the qualifiers is to have the NPC walk on a navmesh. The advantages of this option are that it is easy to implement, and it is simple.
The second option is to make a NPC travel on a navmesh, but adding vector3 locations in order to specify a path the NPC needs to travel. The advantages of this are that this way the NPC doesn't hug the optimal route. This looks weired because normal people to hug walls in order to save 0.05 seconds. The disavantages of this are that it takes a lot of work to find waypoint coordinates and enter into the route.
The third option is to make the NPC travel on the navmesh by using gamobjects as waypoints. The advantages of this are that it's easy tp drag around waypoints and set a route. It is more work than option one, but less than option two. It also allows for clear trigger areas. 
The forth option is to make a waypoint system where we make a waypoint system that has NPC's travel from waypoint to waypoint, regardless of navmesh.

What is the best way we can make a NPC travel from one place to another?
The best method is using game object waypoints with the unity navmesh. This combines the lowest effort, most features and great visual overview. 


## Found sources

> Provide a link to the new source(s) you found and used this week to achieve this result.
You may also include sources that turned out not to provide useful information.

1. [https://www.reddit.com/r/Unity2D/comments/9it5vi/best_way_to_move_a_character_npc/](https://www.reddit.com/r/Unity2D/comments/9it5vi/best_way_to_move_a_character_npc/) Usefull for providing info about some common issues that standard methods have.
2. [hhttps://www.quora.com/How-do-I-make-an-NPC-move-in-Unity](https://www.quora.com/How-do-I-make-an-NPC-move-in-Unity)  Very usefull for giving an overview of some good options on how movement can be achieved.
3. [https://stackoverflow.com/questions/61731488/npc-moving-through-the-walls](https://stackoverflow.com/questions/61731488/npc-moving-through-the-walls) Usefull for providing info about some common issues that standard methods have.
4. [https://www.red-gate.com/simple-talk/development/dotnet-development/creating-a-simple-ai-with-unity-and-c/](https://www.red-gate.com/simple-talk/development/dotnet-development/creating-a-simple-ai-with-unity-and-c/) Usefull for inspiration about features that can matter to NPC movement.

> Also provide a summary of the content of the source and the usefulness and/or effect on the answer.

## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for next sprint and what you will keep the same in order to improve the integration process.

I underestimated how long this research would take. As a result I am not yet done with the implementation of the NPC movement, and only managed to finish the research prototypes within the sprint. As a result this research is not as extensive as I wanted it to be. The integration is also non existend as of right now. This is also due to the low amount of time I had to work on this research. The prototypes work, but are not yet ready for integration.