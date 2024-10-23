-> LunchCaught
EXTERNAL loadNextLevel(buildIndex)
EXTERNAL IncreasePoints(bool zero, bool one, bool two, bool three)
EXTERNAL HasPoints()

=== LunchCaught ===

<color=\#de4065>Bread!
<color=\#ffffffff>The fluffball of a woman grabs you, finally caught you after your attempted escape.
<color=\#de4065>Gosh you run so quickly, I was trying to call out to you for ages.
<color=\#ffffffff>And that's exactly why you were running away.
<color=\#de4065>I wanted to ask if... Maybe you'd like to read some Manga together?
<color=\#ffffffff>Together? But your mission-
<color=\#ebd38d>Sure.

EXTERNAL TurnOffPoints()
~HasPoints()
~IncreasePoints(true, true, true, false)

<color=\#ffffffff>URG STUPID CURSE!
<color=\#de4065>R-Really? Yay! We are gonna have so much fun together!
<color=\#ffffffff>She takes your hand with a red blush on her face.
<color=\#ffffffff>This was your last chance at freedom, and you failed.
<color=\#ffffffff>For the rest of Lunch, you and Cherry read the Manga you had.
<color=\#ffffffff>DING DONG!

~loadNextLevel(16)
-> END