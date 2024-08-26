-> 04BedProgress

=== 04BedProgress ===

EXTERNAL loadNextLevel(buildIndex)
EXTERNAL toggleFairy()
<color=\#ffffffff>Your bed, after a long busy day, calls to you.
Is it time to go to sleep?

+ ["Yes"] -> YesBed
+ ["No"] -> NoBed

=== NoBed ===

<color=\#ffffffff>Hmm, not yet.
Sleep can wait a moment longer.
-> END

=== YesBed ===

<color=\#ffffffff>Falling onto the soft mattress, a sigh escapes your lips.
You're too tired to even sleep on a bed properly.
As your eyes close shut, you think about the day you had.
Your body sore, the scent of dough on your skin, and the creak of the mattress under you.
All of it, making your body weak as slumber comes.
Sleep is around the corner when a voice calls to you.

<color=\#2f6ad0>What a pathetic, puny human!

<color=\#ffffffff>...
You open your eyes, glancing around the room.
Was that your imagination? Did you really just call yourself such a thing?
The perks of sniffing dough all day, you close your eyes once more.
Then you hear it again.

<color=\#2f6ad0>Ignoring me? How dare you ignore me!

~ toggleFairy()

<color=\#ffffffff>Your eyes shot open, the voice far too clear to be part of your imagination.
Doesn't help that a stranger stands before you at the end of your bed.
Before you can ask questions though, the figure speaks.

<color=\#2f6ad0>Good, you're up.

<color=\#ffffffff>Your eyes watch this stranger, their outfit odd and majestic looking.
Orange hair in a bun, glasses clean and proper, ears pointed at the tips much like her wings.
Wait... Wings?

<color=\#2f6ad0>Hasn't someone told you staring is rude?

<color=\#ffffffff>To their disappointment, you continue to stare.
You've seen many odd people before, heck you go to school with them.
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

<color=\#2b252c>
+ ["Who?"] ->WhoQuestion
+ ["What?"] ->WhatQuestion
+ ["How?"] ->HowQuestion
+ ["..."] -> BedProgress1

=== WhoQuestion ===

<color=\#ffffffff>Who is this woman, you wonder.
As if she can read your mind, she smirks, speaking up.

<color=\#2f6ad0>You want to know who I am?

<color=\#ffffffff>How did she know that?
Rolling her eyes, she continues.

<color=\#2f6ad0>My name is Kiwi-Apple Raisin Elderberry-Nectarine.

<color=\#ffffffff>She just named a bunch of foods?
Her face deflates, as if taking your thoughts to offense.

<color=\#2f6ad0>My friends call me Karen. Karen Fairy.
We aren't friends, human, but I suppose you can call me that too.

<color=\#ffffffff>... Interesting name...

-> Questions1

=== WhatQuestion ===

<color=\#ffffffff>Your eyes trail to behind her, specifically what is attached to her back.
A pair of see through wings, they sparkle in the moon light that came through the window.
They sparkled. Looked real even.

<color=\#2f6ad0>They are real.

<color=\#ffffffff>Real? Wings being real?
You may be a highschool student, but you aren't stupid.
But as you were about to make up your mind, you watch as those wings move.
They flutter, ever so gracefully. A practice to them even.
She didn't fly. She didn't need to.

<color=\#2f6ad0>I am a Fairy.

<color=\#ffffffff>A Fairy? From Fairytales?
Is she here for your teeth?
She visually scowls, like you said the words even though it's all in your head.

<color=\#2f6ad0>Excuse you, I would never do such dirty work to take your teeth.
I am far better then that.
I am a Society Fairy.

<color=\#ffffffff>A Society Fairy?
She looks annoyed, and you haven't even said anything.

<color=\#2f6ad0>Humans live within a system.
Day by day, they live their lives, make goals, do dumb stuff.
Pathetic mortal things. All within the system we created.
But sometimes, humans tend to sit outside of the norm.
As a Society Fairy, I fix that.
I put those humans back in their place.

<color=\#ffffffff>Weird.

-> Questions1

=== HowQuestion ===

<color=\#ffffffff>You look around your room.
Your window is locked and still firm.
Your front door is closed, and frankly you would know if it was barged in.
Your bathroom door has a loud squeak to it. If they were hiding in there, you would have heard.
But you didn't.
So how did this person get in?
As if sensing your confusion, the woman stares with a wicked grin.

<color=\#2f6ad0>My, all the entrances are blocked, and yet you wonder how I came here?
You're stupid. Think outside the box.

<color=\#ffffffff>She must of been hiding before you came home?
That means she is a professional lock picker.
But where could she have been hiding.

<color=\#2f6ad0>Or maybe...
I used Magic.

<color=\#ffffffff>Magic?
...
So she is on shrooms?
A loud groan rolls through the air from her direction.
She isn't a very happy type it seems.

-> Questions1

=== BedProgress1 ===

<color=\#ffffffff>You stay silent, you either go in this knowing more or nothing.
What you do know, is this random woman with wings stands before you in your room.
Who is she? What is she? How she got here?
It doesn't really matter.

<color=\#2f6ad0>So, human.
This is your first time meeting a Fairy. One as great as myself even.

<color=\#ffffffff>You are unsure if you should feel proud or disturbed.
Your lack of a response though, has her making a face.
Her tone pitching, disgust evident within.

<color=\#2f6ad0>My, you are one of few words.
Don't worry, that makes things easier.
So much easier.

<color=\#ffffffff>You notice something sinister about her.
She is planning something.
Something you won't like.

<color=\#2f6ad0>You, pathetic human, are a problem.
A problem that I plan to fix.
What shall I do?

<color=\#ffffffff>A problem, what is this lunatic on about?

<color=\#2f6ad0>Hmm, let's see.
A human boy, an outlier. A problem to the system of Society.
And someone with a lot of freewill...

<color=\#ffffffff>For a moment, she appears to be deep in thought.
The next, a smirk imprinted on her features.
And with the snap of her fingers, a sparkle of light surrounds me.

<color=\#2b252c>COUGH COUGH!

<color=\#ffffffff>Bright light, high-pitch noise, and the smell of very strong perfume.
Oh it's so gross you might just throw up.

<color=\#ebd38d>URG! COUGH!

<color=\#ffffffff>The light fades, along with the noise and smell.
You can finally breathe.

<color=\#2f6ad0>Perfect!

<color=\#ffffffff>The woman, sinister she is, smiles with glee at you.
As you come to your senses, you feel... Strange.
Like something has changed.

<color=\#2f6ad0>There! Handsome as ever, truly a master at my work.
No need to thank me, but I won't stop you if you do.

<color=\#ffffffff>Your hair...
Your clothes...
Even your smell...
That is not a freshly baked goods smell.
You feel foreign, you appear and feel different.
You don't feel as attractive as you did before.

<color=\#2f6ad0>Goodness, you loved yourself too much before.
Love the new you now, it's going to be your new life.

<color=\#ffffffff>New life? This? You were fine with before?
Change isn't so bad but you didn't want to change.
You didn't need to change, so why now?

<color=\#2f6ad0>You can speak right?

<color=\#ffffffff>Technically, you can, you just choose not to.

<color=\#2f6ad0>Good. Tell me you love it.

<color=\#ffffffff>What?
Love it? Love this? Love the change? No!
You didn't even get a say in the matter, it just happened.
But if she demands you to speak up, you could do just that.

<color=\#ebd38d>
+ ["I hate it"] -> CurseResponse
+ ["It's horrible"] -> CurseResponse
+ ["You Monster"] -> CurseResponse
+ ["..."] -> CurseResponse

=== CurseResponse ===

<color=\#ebd38d>I love it.

<color=\#ffffffff>...
. . .
.   .   .
What?

<color=\#2f6ad0>Good! I'm glad you like it, and I'm glad it's working.

<color=\#ffffffff>It's working? What's working?
Why did you say that? You didn't mean to say that right?

<color=\#2f6ad0>Fuhuhu... Aw, is the human unable to say what he is thinking?
It comes with the gift I gave you?

<color=\#ffffffff>Gift? What is this mad woman speaking of?

<color=\#2f6ad0>Yes, gift. The gift of looking attractive to everyone you meet and...
The gift, of being unable to refuse.

<color=\#ffffffff>...
That sounds like sexual as-

<color=\#2f6ad0>As an outlier, you will accept the confession of anyone who is willing to confess to you.
In other words, you will live the life anyone would want to live.
You will find love, have a partner, work together, help your partner with their future.
And your future, binds with theirs.

<color=\#ffffffff>Your future? Gone. Just like that? For a life with another?

<color=\#2f6ad0>Of course, right now you are still single, but you have school tomorrow.
And at your school is many singles willing to mingle.

<color=\#ffffffff>Older people using slang is so weird.

<color=\#2f6ad0>With your attractive appearance and willingness to say yes to them, it will be a piece of cake!
No longer will you be a pain in my behind.

<color=\#ffffffff>...

<color=\#2f6ad0>And while we are at it, what was your name again?

<color=\#ffffffff>Silence. You weren't sure telling the person who cursed you your name would be a good idea.
But it seems it doesn't matter, she has an expression of satisfaction.

<color=\#2f6ad0>Bread.

<color=\#ebd38d>Huh?

<color=\#2f6ad0>Your name, it is now Bread.
Fitting, ain't it?

<color=\#ffffffff>As if you couldn't be jabbed further, you're now named after the one thing you crave in life.
The one thing you dream of, now used as a name.
Your name.

<color=\#2f6ad0>Aren't you a joy.
Now. My work here is done.
I'll be watching you kid, mess up, and you will regret it.

<color=\#ffffffff>...

<color=\#2f6ad0>Ta Ta~

~ toggleFairy()

<color=\#ffffffff>And just like that, the strange woman with wings vanishes.
For a moment, you wonder if what you saw was real.
But after a quick slap to the face, you realize otherwise.
She calls it a gift, but really, it feels like a curse, one that goes against your very goals.
A baker in Paris making a name for himself for his passions.
No appearance changes, no name changes, no partners.
No Curse.
You could accept your fate, but a lifetime of misery is too far.
There must be a way to remove the curse, or better yet.
Avoid it entirely.
With a shake of your head, you stand up from your bed.
Now is the time to take a moment.

-> END