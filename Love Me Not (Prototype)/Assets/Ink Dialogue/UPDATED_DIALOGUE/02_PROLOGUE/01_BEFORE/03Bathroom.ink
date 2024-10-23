VAR teleportLocationX = 0
VAR teleportLocationY = 0

-> 03Bathroom

=== 03Bathroom ===

<color=\#ffffffff>The bathroom door. It matches the design of the rest of the apartment.
On the other side is, of course, the bathroom.
You place your hand on the door handle; it's cold-tempered metal within your grasp.
Shall you enter?

+ [<color=\#2b252c>Yes] -> AltYesBathroom
+ [<color=\#2b252c>No] -> NoBathroom

=== YesBathroom ===

<color=\#ffffffff>Turning the knob of the door, you enter the bathroom...

    ~ teleportLocationX = 10
    ~ teleportLocationY = 5
-> END

=== NoBathroom ===

<color=\#ffffffff>Slowly, you remove your hand from the door handle, staring at the door.
-> END

=== AltYesBathroom ===

<color=\#ffffffff>Unfortunately, the door handle wouldn't move.
It seems you will need someone to come over to fix it, might even need to use the neighbors bathroom for a while.
It's totally not because the Devs of the game hadn't gotten a chance to figure out how to do Inky Teleportation...
Oh well.

-> END