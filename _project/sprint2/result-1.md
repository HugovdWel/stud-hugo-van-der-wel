# Achieved Sprint 2 Result focus #1

## Description

> Describe the achieved result here. Try to describe a few important (technical) decisions and describe how you've combined your result(s) with the existing systems/

> If possible and/or relevant, also show screenshots and/or git-animations of the results. Make sure to show your results both in the Unity Editor and during Game play.

![Name of the animation](https://github.com/linkt-to-the-animation-in-the-products-and-code-folder)
![Flyaround camera in the demo](https://gyazo.com/ab93c4e6d810724376c8b5cb03c293df.gif)
![Scene view of camera switch and flying](https://gyazo.com/ba17330022a434f7c6245ad686a92fa4.gif)
![png of scene view](https://user-images.githubusercontent.com/47315594/205516065-f92ab1d2-de0d-4d16-88c7-7465d4c2b34c.png)
![dolly track in scene view](https://user-images.githubusercontent.com/47315594/205516236-bc8e0e83-6d34-4519-83e3-fa63c142e6cf.png)
![timeline of animation](https://user-images.githubusercontent.com/47315594/205516293-477edb7b-b198-4508-9a13-efbc725ada15.png)
![code](https://user-images.githubusercontent.com/47315594/205516339-d96cbb57-1afc-40cb-866c-3522b0ed88ee.png)

![]()

> Also provide a link to all commits (or the last commit related to the result). Make sure it is clear which scene(s), objects(s) and scripts are relevant in order to view the results in Unity. To do so, use the table below.

|The commit(s)|The scene(s)|The gameobject(s)|The script(s)|
|---------|--------|--------------|----------|
|[Prototype](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/0a51d13e8ce32c9cb8319a24028989af36bfa520)[Integration](https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/95b3fe22868ba3e24e130b80dc713d41fadbebc7)| Demo level | dollycart | FlyAroundCameraTrigger |



## Research results

> If your focus involved doing a research describe in what way you've answered your research question(s)/
### Method:
Initially I went about answering the research questions by a literature research on google.
After this I made a prototype of the best candidate to see if there would be any unexpected problems.


### Sub-questions:

#### Does Unity provide functionality for the eagle flight mechanic?
Vanilla Unity does not support any camera movement. In order to apply advanced movement to the camera Unity provides the cinemachine package. Therefore the implementation of cameras in Unity without cinemachine installed is very basic.


#### Does cinemachine provide functionality for the eagle flight mechanic?
The cinemachine package does not provide any specific functionality  for the eagle flight mechanic. It does however provide a set of mechanics that allow for the eagle flight to be implemented without any extra code. This can be done by taking a dolly cart camera and placing the track in a flight patern in the sky while having the focus point on the ground. The dolly cart can be moved with a animator component that can be triggered by any script. The camera can be activated by the same animator while the dolly is moving. These functions combined provide a easy to implement eagle cam mechanic.

#### Do any plugins provide functionality for the eagle flight mechanic?
Yes, there are a number of plugins that provide mechanics that can be used to create the eagle flight mechanic. Most of them are reasonably expensive, but there are some free ones. The best candidate is "Camera Path Creator" by "Icch_howw". The plugin provides all the camera mechanics you would want to make the eagle flight mechanic work. It does come with some drawbacks for this project though. 
The plugin uses the default camera system, which would mean we would need to transfer out of the cinemachine system for this shot. It also required the addition to a extra plugin in the project, and hasn't been updated in 6 years.


#### Is it hard to make the mechanic ourself with a default camera?
It is not particularly hard to make the mechanic with the normal camera and scripts. This would however open us up to unforeseen problems. By making the scripts ourselves we would risk bugs, glitches, and issues in integrating with the cinemachine camera system. It would also take longer to implement the eagle flight camera ourselves than to use a plugin or unity provided package.


### Conclusion:
What is the best way for this project to implement the eagle flight mechanic?
There are a lot of potential answers to this question, but the best option based on the results of this study is the cinemachine dolly camera. The integration would be nearly nothing because we already use the cinemachine package. The package is reliable as it has been provided by unity, and it does not take a lot of time or effort to use.
The best plugin is also not a bad choice as it has good reviews and is not very hard to use. It does however come with a number of drawbacks. These include; being abandoned since 6 years, not being integrated with cinemachine, and there is not much documentation.
The last option of making it ourselves is the worst one since it would take a lot of work, and leaves the most chance of bugs being introduced into the game.
In conclusion, the cinemachine dolly track is the best option we have for introducing a eagle flight mechanic into the game.


## Found sources

> Provide a link to the new source(s) you found and used this week to achieve this result.
You may also include sources that turned out not to provide useful information.

1. [Google, for all research](http://www.google.com)  Useful for all questions
2. [https://assetstore.unity.com/packages/tools/camera/camera-path-creator-84074](https://assetstore.unity.com/packages/tools/camera/camera-path-creator-84074)  Useful for question 3
3. [https://assetstore.unity.com/?q=camera%20path&orderBy=1](https://assetstore.unity.com/?q=camera%20path&orderBy=1)  Very useful for answering question 3
4. [https://docs.unity3d.com/Packages/com.unity.cinemachine@2.3/manual/CinemachineDolly.html](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.3/manual/CinemachineDolly.html)  useful for working on a cinemachine prototype
5. [https://www.youtube.com/watch?v=C6MD_eI8c14](https://www.youtube.com/watch?v=C6MD_eI8c14) extremely usefull for prototyping unity cinemachine  

> Also provide a summary of the content of the source and the usefulness and/or effect on the answer.

## Review and reflect on result(s)

> Describe to which extend you've managed to integrate your result(s) in the game, and/or project.

> Also describe to which extend you're happy with these results. Review your planned tasks and the tasks in your logs, reflect on the choice of these tasks in relation to the integration process and the overall result. Try to describe what you will change in your behavior for the next sprint and what you will keep the same in order to improve the integration process.

I am happy with these results. The prototype was successful and I made an implementation of the camera in the terrible thursday. It is sort of challenging to make an integration ready prefab, but that is not a problem as there is only one of these cameras needed in the game. Therefore I can implement it myself. It is not impossible to make a prefab, but the trigger to the camera can differ based on the situation. Therefore I think it better to make adjustments based on the situation.
