# MythicTracker
Progress tracker for Magic: The Gathering Arena

Copy the files to any folder, and run from there.

This tracker is designed to show your progress through the ladder to Mythic in Arena. The program shows your progress though each rank, the number of wins needed to reach Mythic, how much time is left in the season, and your current rank.

Wins and losses are tracked by using the toolbar buttons. The win and loss buttons default to 1 win and 1 loss against the ladder. 

The drop-down options allow you to register 2-step wins (Gold and lower), and no-step losses (when you are at the bottom of a rank, or first few losses at a new rank). These options still count as a single win or loss against the record.

The program does not track progress automatically; it must be done manually.  The following hot keys are defined if you do not wish to task swap while in Arena (if you are streaming):

Ctrl + Plus: Win, advance 1 step.
Ctrl + Alt + Plus: Win, advance 2 steps.
Ctrl + Minus: Lose, go back 1 step.
Ctrl + Alt + Minus: Lose, Go back 0 steps.

The program generates text files that can be fed into OBS:
* games.txt - contains the number of games remaining (Games remaining: n).
* rank.txt - contains your current rank (Rank level-wins).
* records.txt - contains the win/loss record for the session. This resets everytime the program is run.
* season.txt - contains the win/loss record for the season. This record accumulates until reset.
* streak.txt - contains the current win/loss streak.

The location to save the files can be set in the Settings dialog. 

The status bar contains additional stats. For the current session and the season, the total number of games played and the winning percentage.

The program will save your progress upon closing.

Application now includes Undo functionality that allows you to undo the last action taken. The app only has 1 level of undo.
