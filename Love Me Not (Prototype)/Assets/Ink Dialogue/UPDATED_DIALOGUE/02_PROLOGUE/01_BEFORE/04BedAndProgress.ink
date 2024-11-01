-> 04BedProgress

=== 04BedProgress ===

EXTERNAL loadNextLevel(buildIndex)
EXTERNAL toggleFairy()
EXTERNAL IncreasePoints(bool zero, bool one, bool two, bool three)
EXTERNAL HasPoints()
EXTERNAL TurnOffPoints()

<color=\#ffffffff>Your bed, after a long, busy day, calls to you.
Is it time to go to sleep
//~HasPoints()
//~IncreasePoints(true, false, false, false)

+ [<color=\#2b252c>Yes] -> YesBed
+ [<color=\#2b252c>No] -> NoBed

=== NoBed ===

<color=\#ffffffff>Hmm, not yet.
//~TurnOffPoints()
Sleep can wait a moment longer.
-> END

=== YesBed ===

<color=\#ffffffff>Falling onto the soft mattress, a sigh escapes your lips.
//~TurnOffPoints()
You're too tired to even sleep on a bed properly.
As your eyes close shut, you think about the day you had.
Your body is sore, the scent of dough on your skin, and the creak of the mattress under you.
All of it makes your body weak as slumber comes.
Sleep is around the corner when a voice calls to you.

<color=\#2f6ad0>What a pathetic, puny human!

<color=\#ffffffff>...
You open your eyes, glancing around the room.
Was that your imagination? Did you really call yourself such a thing?
The perk of sniffing dough all day, you close your eyes once more.
Then you hear it again.

<color=\#2f6ad0>Ignoring me? How dare you ignore me!

~ toggleFairy()

<color=\#ffffffff>Your eyes shot open, the voice far too clear to be part of your imagination.
It doesn't help that a stranger stands before you at the end of your bed.
Before you can ask questions, though, the figure speaks.

<color=\#2f6ad0>Good, you're up.

<color=\#ffffffff>Your eyes watch this stranger, their outfit odd and majestic looking.
Orange hair in a bun, glasses clean and proper, ears pointed at the tips much like her wings.
Wait... Wings?

<color=\#2f6ad0>Hasn't someone told you staring is rude?

<color=\#ffffffff>To their disappointment, you continue to stare.
You've seen many odd people before; you go to school with them.
But none so crazy to wear wings.

<color=\#2f6ad0>Are you done?

<color=\#ffffffff>You shrug.
The being sighs, her blue eyes watching you.
Why you?

<color=\#2f6ad0>I'm sure you're confused.

<color=\#ffffffff>An understatement.
She looks as though she is giving you the chance to speak.

-> Questions1

=== Questions1 ===
Do you dare ask a question?

+ [<color=\#2b252c>"Who?"] ->WhoQuestion
+ [<color=\#2b252c>"What?"] ->WhatQuestion
+ [<color=\#2b252c>"How?"] ->HowQuestion
+ [<color=\#2b252c>"..."] -> BedProgress1

=== WhoQuestion ===

<color=\#ffffffff>Who is this woman, you wonder.
As if she can read your mind, she smirks, speaking up.
//~TurnOffPoints()
<color=\#2f6ad0>You want to know who I am?

<color=\#ffffffff>How did she know that?
Rolling her eyes, she continues.

<color=\#2f6ad0>My name is Kiwi-Apple Raisin Elderberry-Nectarine.

<color=\#ffffffff>She just named a bunch of foods?
Her face deflates as if taking your thoughts to offence.

<color=\#2f6ad0>My friends call me Karen. Karen Fairy.
<color=\#2f6ad0>We aren't friends, human, but you can call me that too.

<color=\#ffffffff>... Interesting name...

-> Questions1

=== WhatQuestion ===

<color=\#ffffffff>Your eyes trail behind her, specifically to what is attached to her back.
//~TurnOffPoints()
A pair of see-through wings shimmer in the moonlight that came through the window.
They sparkled. They looked real even.

<color=\#2f6ad0>They are real.

<color=\#ffffffff>Real? Wings being real?
You may be a high school student, but you aren't stupid.
But as you were about to make up your mind, you watched as those wings moved.
They flutter ever so gracefully—a practice to them even.
She didn't fly. She didn't need to.

<color=\#2f6ad0>I am a Fairy.

<color=\#ffffffff>A Fairy? From Fairytales?
Is she here for your teeth?
She visually scowls, like you said the words, even though it's all in your head.

<color=\#2f6ad0>Excuse you, I would never do such dirty work to take your teeth.
<color=\#2f6ad0>I am far better than that.
<color=\#2f6ad0>I am a Society Fairy.

<color=\#ffffffff>A Society Fairy?
She looks annoyed, and you haven't even said anything.

<color=\#2f6ad0>Humans live within a system.
<color=\#2f6ad0>Daily, they live their lives, make goals, and do dumb stuff.
<color=\#2f6ad0>Pathetic mortal things. All within the system we created.
<color=\#2f6ad0> Sometimes, humans tend to sit outside the norm.
<color=\#2f6ad0>As a Society Fairy, I fix that.
<color=\#2f6ad0>I put those humans back in their place.

<color=\#ffffffff>Weird.

-> Questions1

=== HowQuestion ===

<color=\#ffffffff>You look around your room.
//~TurnOffPoints()
Your window is locked and still firm.
Your front door is closed; frankly, you would know if it was barged in.
Your bathroom door has a loud squeak to it. If they were hiding in there, you would have heard.
But you didn't.
So, how did this person get in?
As if sensing your confusion, the woman stares with a wicked grin.

<color=\#2f6ad0>My, all the entrances are blocked, and yet you wonder how I came here?
<color=\#2f6ad0>You're stupid. Think outside the box.

<color=\#ffffffff>She must have been hiding before you came home.
That means she is a professional lock picker.
But where could she have been hiding?

<color=\#2f6ad0>Or maybe...
<color=\#2f6ad0>I used Magic.

<color=\#ffffffff>Magic?
...
So she is on shrooms?
A loud groan rolls through the air from her direction.
It seems she isn't a very happy type.

-> Questions1

=== BedProgress1 ===

<color=\#ffffffff>You stay silent; you either go in this knowing more or nothing.
//~TurnOffPoints()
What you do know is that this random woman with wings stands before you in your room.
Who is she? What is she? How did she get here?
It doesn't really matter.

<color=\#2f6ad0>So, human.
<color=\#2f6ad0>This is your first time meeting a Fairy. One as great as myself even.

<color=\#ffffffff>You are unsure if you should feel proud or disturbed.
Your lack of a response, though, has her making a face.
Her tone pitching, disgust evident within.

<color=\#2f6ad0>My, you are one of few words.
<color=\#2f6ad0>Don't worry; that makes things easier.
<color=\#2f6ad0>So much easier.

<color=\#ffffffff>You notice something sinister about her.
She is planning something. Something you won't like.

<color=\#2f6ad0>You, pathetic human, are a problem.
<color=\#2f6ad0>A problem that I plan to fix.
<color=\#2f6ad0>What shall I do?

<color=\#ffffffff>A problem, what is this lunatic on about?

<color=\#2f6ad0>Hmm, let's see.
<color=\#2f6ad0>A human boy, an outlier. A problem to the system of Society.
<color=\#2f6ad0>And someone with a lot of free will...

<color=\#ffffffff>For a moment, she appears to be deep in thought.
The next, a smirk imprinted on her features.
And with the snap of her fingers... Nothing happens?
You start to smell that horribly old perfume more though until it feels suffocating.

<color=\#2b252c>COUGH COUGH!

<color=\#ffffffff>You are in the middle of a cough of fits and the strange lady just stands there.
<color=\#ffffffff>Watching...
<color=\#ffffffff>Until finally, the smell disappears. You can finally breathe.

<color=\#2f6ad0>Perfect!

<color=\#ffffffff>The woman, sinister she is, smiles with glee at you.
As you come to your senses, you feel... Strange.
It's like something has changed. But you look the same?

<color=\#2f6ad0>There! Now in the morning you will look completely different!
<color=\#2f6ad0>No need to thank me, but I won't stop you if you do.

<color=\#ffffffff>You did feel different, but you could see that you weren't.
<color=\#ffffffff>You smelt different though.
<color=\#ffffffff>No longer did you smell of sweet bakery goods.
<color=\#ffffffff>Now you smelt... Boring.

<color=\#2f6ad0>Goodness, you loved yourself too much before.
<color=\#2f6ad0>Love the new you now; it will be your new life.

<color=\#ffffffff>New life? This? You were fine with it before?
Change isn't so bad, but you didn't want to change.
You didn't need to change, so why now?

<color=\#2f6ad0>You can speak right?

<color=\#ffffffff>Technically, you can; you just choose not to.

<color=\#2f6ad0>Good. Tell me you love it.

<color=\#ffffffff>What?
Love it? Love this? Love the change? No!
You didn't even get a say in the matter; it just happened.
But you could do just that if she demands you to speak up.

+ [<color=\#ebd38d>"I hate it"] -> CurseResponse
+ [<color=\#ebd38d>"It's horrible"] -> CurseResponse
+ [<color=\#ebd38d>"You Monster"] -> CurseResponse
+ [<color=\#ebd38d>"..."] -> CurseResponse

=== CurseResponse ===

<color=\#ebd38d>I love it.
//~TurnOffPoints()

<color=\#ffffffff>...
. . .
.   .   .
What?

<color=\#2f6ad0>Good! I'm glad you like it, and I'm glad it's working.

<color=\#ffffffff>It's working? What's working?
Why did you say that? You didn't mean to say that, right?

<color=\#2f6ad0>Fuhuhu... Aw, is the human unable to say what he is thinking?
<color=\#2f6ad0>It comes with the gift I gave you.

<color=\#ffffffff>Gift? What is this mad woman speaking of?

<color=\#2f6ad0>Yes, gift. The gift of looking attractive to everyone you meet and...
<color=\#2f6ad0>The gift of being unable to refuse.

<color=\#ffffffff>...
<color=\#ffffffff>That sounds like sexual as-

<color=\#2f6ad0>As an outlier, you will accept the confession of anyone willing to confess to you.
<color=\#2f6ad0>In other words, you will live the life of anyone wants.
<color=\#2f6ad0>You will find love, have a partner, work together, and help your partner with their future.
<color=\#2f6ad0>And your future binds with theirs.

<color=\#ffffffff>Your future? Gone. Just like that? For a life with another?

<color=\#2f6ad0> You are still single right now, but you have school tomorrow.
<color=\#2f6ad0>And at your school are many singles willing to mingle.

<color=\#ffffffff>Older people using slang is so weird.

<color=\#2f6ad0>With your soon attractive appearance and willingness to say yes to them, it will be a piece of cake!
<color=\#2f6ad0>No longer will you be a pain in my behind.

<color=\#ffffffff>...

<color=\#2f6ad0>And while we are at it, what was your name again?

<color=\#ffffffff>Silence. You weren't sure telling the person who cursed you your name would be a good idea.
<color=\#ffffffff>But it doesn't matter; she has an expression of satisfaction.

<color=\#2f6ad0>Bread.

<color=\#ebd38d>Huh?

<color=\#2f6ad0>Your name, it is now Bread.
Fitting, isn't it?

<color=\#ffffffff>As if you couldn't be jabbed further, you're now named after the one thing you crave in life.
The one thing you dream of is now used as a name.
Your name.

<color=\#2f6ad0>Aren't you a joy.
<color=\#2f6ad0>Now. My work here is done.
<color=\#2f6ad0>I'll be watching you, kid, mess up, and you will regret it.

<color=\#ffffffff>...

<color=\#2f6ad0>Ta Ta~

~ toggleFairy()

<color=\#ffffffff>And just like that, the strange woman with wings vanishes.
For a moment, you wonder if what you saw was real.
But after a quick slap to the face, you realise otherwise.
She calls it a gift, but really, it feels like a curse, one that goes against your very goals.
Goals of becoming a Baker in Paris with a name for himself and his passions.
No appearance changes, no name changes, no partners.
No Curse.
You could accept your fate, but a lifetime of misery is too far.
There must be a way to remove the curse, or better yet.
Avoid it entirely.
With a shake of your head, you stand up from your bed.
Now is the time to take a moment.

-> END