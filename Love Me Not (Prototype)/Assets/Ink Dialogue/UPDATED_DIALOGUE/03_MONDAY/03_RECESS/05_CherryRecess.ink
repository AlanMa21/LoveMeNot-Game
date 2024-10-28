EXTERNAL loadNextLevel(buildIndex)
-> CherryRecess

EXTERNAL IncreasePoints(bool zero, bool one, bool two, bool three)
EXTERNAL HasPoints()
EXTERNAL TurnOffPoints()

=== CherryRecess ===
<color=\#de4065>Oh, hi Kazu- I mean, Bread!
<color=\#ffffffff>Cherry approached you, it seems you got too close.
<color=\#de4065>Um, whatcha doing walking around here?
<color=\#de4065>Small worl- uh, Class, yeah, heh.
<color=\#ffffffff>Gosh she is so awkward.
<color=\#de4065>Anyways, you look like you are looking for something, maybe I can help?
<color=\#ffffffff>You fought the urge to stay silent, to not tell her your plans.
<color=\#ffffffff>But the effects of the curse surrendered you to your knowledge.
<color=\#ebd38d>Manga.
<color=\#de4065>Manga? Wait you like Manga too?!
<color=\#ffffffff>The smile on her face widened, sickening so.
<color=\#ffffffff>She practically grabbed your hand, moving excitedly.
<color=\#de4065>Wow we have so much in common! I was afraid that you wouldn't...
<color=\#de4065>Ahem! Bread, would you like to read Manga with me?
<color=\#ffffffff>Now? In the middle of your mission? You can't agree to this.
<color=\#ffffffff>But... Maybe it's possible.

~HasPoints()
~IncreasePoints(true, true, false, false)

+ [<color=\#ebd38d>No] -> SameResponse
+ [<color=\#ebd38d>Get away from me] -> SameResponse
+ [<color=\#ebd38d>Get away from me] -> SameResponse

=== SameResponse ===
<color=\#ebd38d>Sure.
<color=\#de4065>Really? Hah! O-Okay! Come, we don't have much more time before the end of Recess!
<color=\#ffffffff>You failed your mission, but it's not too late.
<color=\#ffffffff>For the rest of the class, you and Cherry sit at her desk.
<color=\#ffffffff>You both read the Manga you were spending the Recess to find.
<color=\#ffffffff>She also allows you to keep the Manga, meaning you still have a chance.
<color=\#ffffffff>DING DONG!

~loadNextLevel(7)
-> END