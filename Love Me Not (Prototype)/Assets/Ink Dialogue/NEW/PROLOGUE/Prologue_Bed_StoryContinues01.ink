EXTERNAL loadNextLevel(buildIndex)
EXTERNAL toggleFairy()

-> AfterSunQuestionOne

=== AfterSunQuestionOne ===
//AKA, when interacting with bed.


MC: (Tired) "Ah, finally!"

//MC (Pixels) jumps onto the bed, maybe a sleeping sprite?

MC: "Oh sleep, how I desire you and your everlasting comfort."
MC: "Cure the pain in my feet; bring me forever slumber!"
MC: "Make me forget this tragic reality I live within..."

UNKNOWN: "What a pathetic puny human!"
~ toggleFairy()

//MC (Pixels) jumps with a shake effect/animation.

MC: (Shock) "What?!"
...

//Dialogue rectangle could disappear for a good 5 seconds to show the unmoving nature of the room. Nothing has changed.

MC: (Tired) "Gosh, am I that tired that I'm starting to hear things?"

UNKNOWN: "And it is a STUPID one at that!"

//Unknown, aka Karen Fairy, magically appears in the middle of the room. Her identity is hidden behind the smoke and dust.

MC: (Shock) "AHH!"
MC: "WHAT IN THE-"
MC: "COUGH COUGH!"

UNKNOWN: "Did I tell you that you could die a silly death?"
UNKNOWN: "Cease your pathetic wails at once!"

MC: "COUGH COUGH... Wha- COUGH."
MC: I can't breathe!
MC: This smoke...
MC: It smells like old wrinkly lady perfume!

//A little smoke animation where it looks like an explosion, revealing Karen Fairy in all her glory before the smoke fades away.

UNKNOWN: (Angry) "How DARE you call me OLD and WRINKLY!"

MC: (Shock) "I-I..."
MC: Wait, how does she know that?!
MC: I didn't say it out loud, did I?

UNKNOWN: (Strict) "Urg. Pathetic."

MC: "W-Who are you?!"
MC: "What are you doing in my room?"
MC: "Why is there some pixie-crazy old lady in my room?"

//In MC's outburst, he should get up from bed and stand before the Unknown individual / Karen Fairy.

UNKNOWN: (Angry) "EXCUSE YOU!" - Intense shake animation
UNKNOWN: "I AM NOT A PIXIE!"
UNKNOWN: (Strict) "Those little winged shits are scandalous harlots; I would never be as indecent and ravenous like them."

MC: (Shock) "..."

UNKNOWN: (Neutral) "..."
UNKNOWN: (Furious) "I'M A FAIRY YOU NITWIT!"

MC: (Shock) "Okay! Okay!"
MC: A Fairy? Am I seriously seeing a Fairy?
MC: Either this is the craziest dream, I'm having a very dark illegal trip, or I have just gone bat shit crazy.

UNKNOWN: (Strict) "Humans think of the most bizarre and otherworldly things to explain reality with."

MC: (Confused) "What?"

UNKNOWN: (Neutral) "You seem confused,"
UNKNOWN: (Strict)
UNKNOWN: "And your thoughts are getting annoying."

MC: "..."
MC: You can hear my thoughts?

UNKNOWN: (Angry) "Enough questions!"
UNKNOWN: (Strict) "You, disgusting human, have been chosen by yours truly to get an upgrade in your pathetic life."

MC: (Confused) "Huh?"

UNKNOWN: (Neutral) "... Idiot."

MC: (Tired) "What? Woah, hold up."
MC: "None of this is making any sense. YOU don't make sense."
MC: "You're a... Fairy. In my house-"
MC: (Shock) "Is this breaking and entering?! I should call the police."

UNKNOWN: (Smug) "The Police? Hah!"
UNKNOWN: (Mocking) "They won't be able to do anything."

MC: (Neutral) "What makes you so sure?"

UNKNOWN: (Smug) "Because I am a Fairy!"
UNKNOWN: "Only those I want to see me can see me."
UNKNOWN: "We smart beings have been able to stay hidden from your stupidity and technology for centuries."
UNKNOWN: (Neutral) "Unless you're the Tooth Fairy, he had one job and ruined that too."
UNKNOWN: (smug) "However, anyone that knows of our existence and chooses to speak up about it usually ends up in a big white building far away."
UNKNOWN: "Oh, what were they called again?"
-> SunQuestionTwo



=== SunQuestionTwo ===
+ ["OLD PEOPLE HOME?"] -> OldPeopleHome
+ ["ASYLUM?"] -> Asylum
+ ["HOSPITAL?"] -> Hospital
+ ["..."] -> SilenceOne

=== OldPeopleHome ===
UNKNOWN: (Angry) "What is with you and the elderly?!"
UNKNOWN: (Strict) "You know what, I don't care!"
-> AfterSunQuestionTwo

=== Asylum ===
//These buttons, excluding the "Old People Home?" and "..." don't affect the dialogue received. It will just continue.
-> AfterSunQuestionTwo

=== Hospital ===
//These buttons, excluding the "Old People Home?" and "..." don't affect the dialogue received. It will just continue.
-> AfterSunQuestionTwo

=== SilenceOne ===
UNKNOWN: (Neutral) "Nothing?"
UNKNOWN: (Angry) "I asked you a question! You should still answer it."
UNKNOWN: (Strict) "Hmpf. Whatever, I don't even want your stupid question."

-> AfterSunQuestionTwo

=== AfterSunQuestionTwo ===
UNKNOWN: (Strict) "It was a rhetorical question."
UNKNOWN: (neutral) "Though, you like you are going to burst due to some unanswered questions."
UNKNOWN: (Smug) "Go on then, speak your mind with that filthy human mouth."
-> SunQuestionThree



=== SunQuestionThree ===
+ ["WHO ARE YOU?"] -> WhoAreYou
+ ["WHAT ARE YOU?"] -> WhatAreYou
+ ["ARE YOU SURE YOU ARE A FAIRY?"] -> AreYouAFairy
+ ["WHY DO YOU SMELL LIKE OLD LADIES?"] -> WhyDoYouSmellOld
+ [No More Questions] -> AfterSunQuestionThree

=== WhoAreYou ===
UNKNOWN: (Neutral) "Of course, humans learn about one another through verbal conversation."
UNKNOWN: "Such lacking creatures you are indeed."
UNKNOWN: (Smug) "Alright, if you insist."
UNKNOWN: (Strict) "My name is Kendal Andrea Rosalie Esmeralda Nirvana."

MC: (Neutral) "Kendal... What?"

UNKNOWN: (Strict) "Oh my Fairy Dust..."
UNKNOWN: "Karen. Just call me Karen."
//After her name is revealed, her name will change from UNKNOWN to Karen Fairy. Turn the name from false to true for the rest of the game.

MC: (Confused) "Karen... But you are a Fairy..."
MC: "Karen Fairy?"

KAREN FAIRY: (Angry) "..."
KAREN FAIRY: (Neutral) "You know what, yeah, sure, why not."
KAREN FAIRY: "Now that you know my name, is there anything else your puny brain wishes to know?"
-> SunQuestionThree

=== WhatAreYou ===
UNKNOWN/KAREN FAIRY: (Strict) "I'm a Fairy, I already told you this."

MC: (Neutral) "No, I mean, what kind of Fairy are you?"
MC: "I highly doubt you are looking to take my teeth."

UNKNOWN/KAREN FAIRY: (strict) "Ew gross, no."
UNKNOWN/KAREN FAIRY: (Smug) "I am a Society Fairy."

MC: (Confused) "A Society Fairy?"

UNKNOWN/KAREN FAIRY: (angry) "Yes, I just said that!"

MC: "Jeez... And what does a Society Fairy do?"

UNKNOWN/KAREN FAIRY: (Strict) "We get stupid outliers like you back into the natural equation you were made to fit within."

MC: "Wha?"

UNKNOWN/KAREN FAIRY: "Next question."
-> SunQuestionThree

=== AreYouAFairy ===
UNKNOWN/KAREN FAIRY: (Neutral) "..."
UNKNOWN/KAREN FAIRY: "Really?"

MC: (Neutral) "You could be a homeless man in a crazy outfit after snorting some crack."

UNKNOWN/KAREN FAIRY: (Angry) "OH FOR FU-"
UNKNOWN/KAREN FAIRY: "URG!"
UNKNOWN/KAREN FAIRY: "Can a homeless man magically appear from thin air with smoke and dust?"

MC: "Honestly..."

UNKNOWN/KAREN FAIRY: (Strict) "Dunce. That is what you are. Dunce."

MC: (Tired) "Yeesh."
MC: "You're a Fairy, right? Can't Fairies fly?"

UNKNOWN/KAREN FAIRY: (Strict) "Correct."

MC: "And... Fairies have magical powers, right? Do you have powers too?"

UNKNOWN/KAREN FAIRY: (Neutral) "Yes, I have magical powers.

MC: (neutral) "Okay, so..."

UNKNOWN/KAREN FAIRY: (Angry) "I'm a Fairy okay! Accept it!"
-> SunQuestionThree

=== WhyDoYouSmellOld ===
UNKNOWN/KAREN FAIRY: (Furious) "I DO NOT SMELL LIKE OLD LADIES!"

MC: (Shock) "Well, it's just that-"

UNKNOWN/KAREN FAIRY: (Angry) "It's the perfume. Now shut up."

MC: (Tired) "Yes Ma'am."

//Questions end here and continue with the planned dialogue.
-> SunQuestionThree

=== AfterSunQuestionThree ===
KAREN FAIRY: (Strict) "Good gracious, you ask many questions."

MC: (Confused) "I actually have one more question..."

KAREN FAIRY: (Angry) "Well, out with it then; I don't have all night."

MC: "Why are you here?"
MC: "Like, yes, you are a Fairy, but why are you here in front of me?"
MC: "What do you want?"

KAREN FAIRY: (Strict) "I think you have this mixed around. It's not about what I want."
KAREN FAIRY: "It's about what YOU want."

MC: (Confused)
MC: "Me? But I don't want anything."

KAREN FAIRY: "A high school boy. He is both a loser and a loner."
KAREN FAIRY: "A no-friends nobody, I'd say."

MC: (Tired)
MC: "What does me being lonely have to do with you?"

KAREN FAIRY: (Smug) "I'm a Society Fairy."
KAREN FAIRY: "It is my job to-"

MC: "Fix the outliers, yes, I heard you the-"

KAREN FAIRY: (Angry) "Don't interrupt me!"
KAREN FAIRY: (Neutral) "Ah-hem."
KAREN FAIRY: "I'm here to fix you."

MC: (Confused) "Fix me? And how do you plan to do that?"

KAREN FAIRY: (Smug) "Simple."

//Dialogue box disappears as Karen Fairy lifts her wand and shoots at MC. The screen flashes a bright light as a magical mist cloud covers MC, hiding his appearance. Karen Fairy lowers her wand.

KAREN FAIRY: "There! You have been fixed."
KAREN FAIRY: "You are now Bread"

//For MC's line, do not show his sprite until after his pixel appearance has been revealed.

MC: "Cough Cough!"

//The mist falls and disappears, revealing MC as BREAD.

BREAD: (Shock) "What did you do? Why did yo-"
BREAD: "Wait. What am I wearing? And why is my hair lighter?"

KAREN FAIRY: "You have been gifted! I do not need your puny thanks."
KAREN FAIRY: "But since you are so overjoyed, I shall take it nonetheless."
KAREN FAIRY: "I am definitely not trying to boost my own ego."

BREAD: "Well, just changing my appearance isn't that bad, I guess."

KAREN FAIRY: (Strict) "Oh no, I didn't just change your appearance."
KAREN FAIRY: "I have also altered your aura and social abilities to fit within our system."
KAREN FAIRY: "For example, tell me I am a wonderful Fairy."

BREAD: (Confused) What?
-> SunQuestionFour



=== SunQuestionFour ===
+ ["NO! WHY SHOULD I?!"] -> SunCursedResponse
+ ["YOU ARE A PAIN-IN-MY-ASS FAIRY!"] -> SunCursedResponse
+ ["..."] -> SunCursedResponse
//Each question results in the same response due to the game mechanics (curse)

=== SunCursedResponse ===
BREAD: (Neutral) You are a wonderful Fairy.
BREAD: (Disgusted) ...
BREAD: (Confused) ...
BREAD: (Shocked) W-What?!
BREAD: I didn't mean to say that.
BREAD: Why did I say that?!
-> AfterSunQuestionFour

=== AfterSunQuestionFour ===
KAREN FAIRY: (Mockery) "See. When speaking with them, you will easily submit to someone with your words."

BREAD: (Shock) WHAT?!
BREAd: I didn't ask for this!
BREAD: And why can't I say what I am thinking?!

KAREN FAIRY: (Strict) "It's because of the gift I cast on you that makes it so you cannot actually say anything like that."

BREAD: (Confused) Gift? How is this a gift!
BREAD: (Disgusted) You- YOU CURSED ME!

KAREN FAIRY: (Mockery) "Cursed you? Nooo~."
KAREN FAIRY: "I simply enchanted you to have the ability to bring people your way naturally; I am doing you a favour."

BREAD: (Tired) And making it so I cannot speak my actual words?
BREAD: I never agreed to this!

KAREN FAIRY: (Angry) "Well, tough! Now you are fixed and can live your life being loved."
KAREN FAIRY: "Isn't that what someone as idiotic and pathetic as yourself has ever wanted from another human being?"

BREAD: (Disgusted) Not like this!

KAREN FAIRY: (Smug) "Well, you are stuck like this for good."
KAREN FAIRY: "I'm giving you a new chance at life. A new romantic chance at that."

BREAD: Unbelievable.

KAREN FAIRY: (Mockery) "It's your life, darling."
KAREN FAIRY: "Just know that the power of the gift will lead you towards your perfect future."
KAREN FAIRY: (Strict) "Now, I must go. You have wasted plenty of my time already, and I am a busy Fairy."
KAREN FAIRY: "I'll see you again soon, so don't fuck this up."
~ toggleFairy()

//Magic Fairy dust rises where KAREN FAIRY stands, engulfing her within it before disappearing inside the dust and the magic itself. 5 second silence before bringing dialogue back up.

BREAD: (Neutral) ...
BREAD: "So she could hear my thoughts..."
BREAD: (Tired) "I don't understand any of this; maybe this was all a bad dream after all, and I will wake up any moment."
BREAD: Yeah, that must be it.
BREAD: ...
BREAD: I should go back to bed just incase.
//Exit dialogue, enable player movement.


-> END