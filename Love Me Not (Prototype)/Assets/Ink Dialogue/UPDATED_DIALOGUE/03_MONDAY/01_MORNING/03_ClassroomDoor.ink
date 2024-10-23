-> ClassroomDoorMonday

EXTERNAL loadNextLevel(buildIndex)

=== ClassroomDoorMonday ===

<color=\#ffffffff>You stand before your classroom door, feeling slight unease.
<color=\#ffffffff>Nothing bad has happened, maybe it was all just a prank after all?
<color=\#ffffffff>No... Dismissing it would be delusional.
<color=\#ffffffff>You know what you saw.
<color=\#ffffffff>Are you ready?

+ [<color=\#ebd38d>Yes]-> ClassroomEnter
+ [<color=\#ebd38d>No]-> ClassroomWait

=== ClassroomEnter ===
<color=\#ffffffff>It's now or never.
<color=\#ffffffff>Go towards the door.
~loadNextLevel(6)
-> END

=== ClassroomWait ===
<color=\#ffffffff>There is still time to explore before you must enter.

-> END