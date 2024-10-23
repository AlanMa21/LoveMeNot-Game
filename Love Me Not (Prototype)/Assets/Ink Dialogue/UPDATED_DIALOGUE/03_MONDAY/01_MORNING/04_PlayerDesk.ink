-> PlayerDesk1

EXTERNAL loadNextLevel(buildIndex)

=== PlayerDesk1 ===

<color=\#ffffffff>Are you ready to sit down for class?

+ [<color=\#ebd38d>Yes]-> ClassDeskYes
+ [<color=\#ebd38d>No]-> ClassDeskNo

=== ClassDeskYes ===
DING DONG
<color=\#ffffffff>The Bell...
<color=\#ffffffff>Time for the first class.
~loadNextLevel(7)

-> END

=== ClassDeskNo ===
<color=\#ffffffff>Maybe I can look around a little bit before the bell.

-> END