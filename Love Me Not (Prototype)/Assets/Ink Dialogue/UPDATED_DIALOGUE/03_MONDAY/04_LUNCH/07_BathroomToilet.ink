-> BathroomToilet
EXTERNAL loadNextLevel(buildIndex)

=== BathroomToilet ===

<color=\#ffffffff>It's a bathroom toilet, to be expected.
<color=\#ffffffff>But if memory serves you correctly, paper and water aren't the fondest.
<color=\#ffffffff>The toilet looks big enough to soak the book a few times.
<color=\#ffffffff>Maybe you could soak the Manga book?

+ [<color=\#ebd38d>Soak it] -> YesSoak
+ [<color=\#ebd38d>Leave it] -> NoSoak

=== YesSoak ===
<color=\#ffffffff>Kicking up the seat of the toilet, you force one of the books cover first into the bowl.
<color=\#ffffffff>To better make sure it would be ruined you opened the book up, soaking the pages each.
<color=\#ffffffff>Pulling the book out it was dripping with how overkill you went.
<color=\#ffffffff>Perfect. You repeat the process with the other two books until the floor below had a large puddle.
<color=\#ffffffff>You have successfully acquired three soaked Manga books!
<color=\#ffffffff>DING DONG!

~loadNextLevel(12)
-> END

=== NoSoak ===
<color=\#ffffffff>Maybe something else...

-> END
