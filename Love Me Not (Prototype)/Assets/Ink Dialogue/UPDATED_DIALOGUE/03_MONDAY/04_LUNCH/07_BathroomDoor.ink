-> BathroomDoor
EXTERNAL loadNextLevel(buildIndex)

=== BathroomDoor ===

<color=\#ffffffff>Are you sure you want to leave?
<color=\#ffffffff>You haven't done anything to the Mangas, Cherry might try to ask you out.
<color=\#ffffffff>If you leave, your practically accepting the curse. Don't do that.
<color=\#ffffffff>Will you leave?

+ [<color=\#ebd38d>Stay] -> NoDoor
+ [<color=\#ebd38d>Leave] -> YesDoor

=== NoDoor ===
<color=\#ffffffff>Good choice.

-> END

=== YesDoor ===
<color=\#ffffffff>Wrong choice...
<color=\#ffffffff>DING DONG!

~loadNextLevel(16)
-> END
