# Log Week 1

## Comment

> [You may want to use this handy table editor](https://www.tablesgenerator.com/markdown_tables) for editing the individual tables.

> If you want to use Excel/Google Sheets for your log [you can use this vscode plugin to quickly copy/paste the data to a markdown table](https://marketplace.visualstudio.com/items?itemName=TakumiI.markdowntable)

> [Here you can find a list with GitHub emojis](https://github.com/ikatyang/emoji-cheat-sheet/blob/master/README.md)

## Monday 5 December

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half ours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|3 |Started on prototype yarn movement |Some input from Niels and Nick from design |It is shockingly hard to give a ball orders based on a npc controller. I've tried a few ways, but it either looks fake or the ball doesn't turn |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/25c8f4cb68e24c72572f8194e88d6ef8a768e549 |
|4 |finishing yarn movement |Alone |I've figured out how to make the ball follow the player. There need to be 2 seperate objects. One inivisible with the npc controller scripts, and one with the ball and only a script that makes it jump and follow the controller object. This way the guide follows the ball can follow complicated paths while remaining in a state of chaos. |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/95c3553dac4b4a5b405b95782ce9627af406cdb4 |


## Tuesday 6 December

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half ours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|4 | integrate yarn movement with npc movement |Alone |The npc movement system was already a bit bloated with features in the way it was written. It had basically a super class with a load of funtions that do one single thing. Integration is pain and I think I'm going to have to refactor it. |:sad: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/5f826077a26c7589189cb0e40301b6e0625f7f14 |
|3 | refactored npc movement |Alone |The main problem in refactoring the npc movement is removing the variables component. I implemented it in the first place to give designers a clear field where they can input settings. Now however with the extra variables that are comming in it's become cluttered and you can't get an overview anymore, so I'm reworking it into serialized vars. It's more complicated than expected. |:stressed: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/ea651b3fb515aee0f90c97327dfbcebfe990f914 |

## Wednesday 7 December

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half ours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|1 |Meeting with Daniël |With Daniël and pro team |I got a good score, it made me happy because I was scared about having to do the researches again |:happy: |N/A |
|1 |Discussion with design for yarn |Nick from design |Design doesn't have a clear image of what they want the ball of yarn to do. Nick said that Victor would get back to me later that day with a more detailed list of what the ball needs to do, but I haven't heard back yet so I'll just continue making the code more readable |:confused: |N/A |
|5 |Refactored npc movement |Alone |Finished the refactor, but now I'm running into a load of bugs that I myself introduced :)  Ending on a frustrating node because there is a bug that I don't understand. I have to ask for help tomorrow because I'm probably missing something stupid obvious that anyone else would see in 5 seconds. |:frustrated: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/2c81f2219b1cc76b1c43fe8a73c664d46d56c570 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/157/commits/1a9332dc3de54a1c56e99328bf42de0a02541c3f |

## Thursday 8 December

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half ours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|2 |Pull requests, mostly dialogue |Nathan |There are now a load of pull requests all of the sudden. Yay for integrating on time though. The dialogue system is finally good enough to go into develop. I had to do a few review rounds and I had some disagreements with Nathan, but nothing I really care about so I just ignored those after discussing them with Nathan. Somehow the syleguide hadn't been checked on a lot of the code, so I got to make a load of comments, which was fun. |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/143 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/81 |
|3 |Bugfix npc movement |Luka from programming, Victor from design |I asked Luka to look at the problem and he identified what went wrong from looking at the editor for 5 seconds :)   Turns out I accidentally skipped 1 node ahead with everything I did. It's fixed now and I made a pull request |:smiley: | |
|2 |More pull request reviews |Nick, Luka, Danny, Niels |There was a bit of discussion within programming about how we would handle some things art did wrong with their pull requests. Otherwise not much to remark about the reviews. |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/147 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/156#pullrequestreview-1210220864 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/155 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/154 |

## Friday 9 December

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half ours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|5 |Yarn movement pull request review cycle |Danny |Once again working on the yarn. There were some small things I missed that Danny found during the pull request, but the main problem was something I discovered during my preperation for the show your work. The teleport functionality broke a lot of other path node behaviours, so I had to prototype a few different ways to make that work reliably. |:frustrated: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/9e57f72edca13d3e23ba087847256288f0b0b919 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/2447e8ab52e65d68e7b78d35303ce61635b3c739 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/5a5d1f27304589e6f98220b879a5dbc5007f13b5 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/commit/b13e80e2a87d4b444d3e781fd90c70e70c41047b |
|1 |Show your work |Whole group |It was fun, sound made some good things this time, and art made more houses. |:smiley: |N/A |
|2 |Pull requests |Niels, Luka |Lot of pull requests, not much of note |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/154 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/143 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/146 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/155 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/156 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/159 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/160 |
