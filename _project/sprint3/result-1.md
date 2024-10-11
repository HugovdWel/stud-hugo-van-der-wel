# Achieved Sprint 3 Result focus #1

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.


Game scene path of yarn with new node types
![Game scene path of yarn with new node types](https://user-images.githubusercontent.com/47315594/208318641-ed106409-d006-4cb6-80db-349bf798a2ef.png)

Ball of yarn jumping
![Ball of yarn jumping](https://gyazo.com/6b37d03313e0b148d766754f47aa464c.gif)

Ball of yarn running
![Ball of yarn running](https://gyazo.com/64983cdefec2e754df50c6a990aeea54.gif)

Ball of yarn positioning
![Ball of yarn positioning](https://gyazo.com/e295689990f4b54683465ef2f1d6270d.gif)

View of the gameobject of a teleporting pathnode
![View of the gameobject of a teleporting pathnode](https://user-images.githubusercontent.com/47315594/208319183-026e69ff-7e40-4024-9bc4-8b49192f5a9f.png)



> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.


I have modified the npc system to both support more actions, as well as be more user friendly. The UI has been improved, as well as the code readability. There is a script that allows a ball to follow a npc controller, and the npc's can now teleport (with or without bringing the ball) as well as some other new abilities.



|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Link to the commits](https://github.com/link-to-the-animatie)| Name of the scene(s) | Path to the GameObject that uses the script(s) | Name of the scripts


![image](https://user-images.githubusercontent.com/47315594/208320081-de383db7-88dc-47e3-91e4-e49e64d6d453.png)

https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits

All contributions can be found in the yarn tech scene.

The scripts are:
NpcBallController NpcMovementController PathNodeController

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



All functions are fully integrated in the game. In hindsight I would have added some more features, as it can be a lot of trouble to controll the ball in a complex scene. I will not add these functions, as it would take a lot of time and I already made it work.



It took a lot longer than I thought it would because it was a lot less straight forward than I expected, and the npc controller was very overly complicated. Next time I would try to get the criterea more clear early on to avoid these issues.

I had to refactor the npc controller because the different effects were applied in sperate pieces of code, creating a chaotic and hard to understand class that even I could not easily add code to. This ended up being good for the code quality but bad for my time, as it was so complicated in the first place because it has to do a lot of complicated things. And then I added the ball which complicated things even more.
