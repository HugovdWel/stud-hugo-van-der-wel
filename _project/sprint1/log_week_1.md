# Log Sprint 1 Week 1

## Comment

> [You may want to use this handy table editor](https://www.tablesgenerator.com/markdown_tables) for editing the individual tables.

> If you want to use Excel/Google Sheets for your log [you can use this vscode plugin to quickly copy/paste the data to a markdown table](https://marketplace.visualstudio.com/items?itemName=TakumiI.markdowntable)

> [Here you can find a list with GitHub emojis](https://github.com/ikatyang/emoji-cheat-sheet/blob/master/README.md)
## Pre start week
|2|Notities maken voor eerste meeting|@everyone |it's most valuable to only not down conclusions, not who made them or what was not conclusively decided |:smiley: |https://docs.google.com/document/d/1JIwDkqlzSG5s6euTEFEtHmld9GdS_manTrdgYCVNV5M/edit?usp=sharing |
|1|Inzitten bij rest van de meeting |@everyone |wasn't really usefull for me. All relevant things would be decided later|:satisfied:| |

|1 |meeting programmers |programmers |a list of questions is send to the design team |:smiley: | |

## Monday 7 November

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half hours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|2 |opening meeting and planning |@everyone, then programming team |Nobody knows anything about the cinemachine, so i'll do the research |:smiley: | |
|5 |Researching cinemachine and creating prototype for the design team |Just me |Good progress, working follow cam with some bugs, and look around ability. Code needs cleanup. |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/issues/6 |
| | | | | | |

## Tuesday 8 November

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half hours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|7 |Cinemachine research / prototype |Did it alone, with discussions with Niels |Follow camera working, made a target group to allow for looking around. Made a visual state machine for "tail" state but it doesn't work yet. I had a lot of problems with finding out to make the state machine work, but for the sake of readability for the art students I think it's worth using the visual state machine instead of a code state machine. It also improves code legibility |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/issues/6 |
| | | | | | |

## Wednesday 9 November

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half hours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|7 |Cinemachine research / prototype / prefabs for use in game |Me and the design team |I found out that the code i wrote to make a freelook camera was unneccesary because the extend of the cinemachine freelook functionalities were far bigger than i thought. Also the side view camera turned out to be a bad idea. I had originally implemented it by making a trigger to switch to the side view camera when the player walked into the trigger area. That means that if the player is meant to walk left to right it works, but if the player walks right to left the camera gets placed the wrong way. I then made a complicated solution by making a overflow trigger between 2 entry triggers, but this was far too complicated so I looked for a different solution. I realized that the dolly track would probably do what's needed, so I did some googling and implemented a dolly prototype. This worked great.|:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/issues/6 |
| | | | | | |

## Thursday 10 November

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half hours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|4|Reviewing pull request and testing the features inside them. |with all members of the programming group |A lot of comments, some refactors, and a lot of code that now complies with the styleguide |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/19 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/18 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/21 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/20 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/17 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/15 |
|3|Refactoring cinemachine code and refining it to be used in the project | |I ended up removing my implementation of the follow camera because the camera's provided by cinemachine are more reliable. The The side camera's are also currently not used in any prefab camera situation because a dolly track is more suited for any task i can think of. I did not delete the camera's however, as they may come in usefull later on. I might still do it during a later refactor if i can't think of a use. |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/issues/6 |

## Friday 11 November

> Optional informative generic comment about this day.

| Time on Task | Task  | With Whom | Results | Emoji | Link |
|---|---|---|---|---|---|
| Round down to hours of half hours | [link to the task](https://github.com/example-link-task-the-task) or description | Names of co workers and team if relevant | Provide important discoveries and/or (technical) considerations and/or learning experiences and/or puzzles and/or frustration, etc. | Examples: <br />:smiley:, :rage:, :scream:, of :satisfied:, <br />other emoji(s), and or description is also satisfactory | [link to results/commit](https://github.com/link-naar-de-commit) |
|2 |pull requests reviews |with the rest of the programming team|4 merged pull requests |:smiley: |https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/26 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/19 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/18 https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/pull/17 |
|3 |Cinemachine flyover camera research and dev, pull request |With some input from design team |Figured out a good way of making a flyaround camera, it is by far the most complicated cinemachine camera. I cannot make a preset out of this one as I did for the other ones. I'll have to make all fly around camera's by hand. |:smiley: | https://github.com/AIM-GAME-PROJECT-group-a/A-Passing-Friend/tree/sub-task/feature-2-addedMoreCameras|
|1 |presentation prep and execution |alone / shown to class |N/A |:smiley: |N/A |