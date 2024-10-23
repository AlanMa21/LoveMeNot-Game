-> ClassA1
EXTERNAL loadNextLevel(buildIndex)

=== ClassA1 ===
<color=\#C7C7C7>Alright Class! Let's see if you are smart.
<color=\#C7C7C7>Let's see, who shall I quiz today...
<color=\#C7C7C7>You, new kid, do you have what it takes?
<color=\#C7C7C7>Hah! That was rhetorical. Let's begin!
-> Question1

=== Question1 ===
<color=\#C7C7C7>Question 1 - In Brazil, what language is spoken?

+ [<color=\#ebd38d>Portuguese] -> CorrectQ1
+ [<color=\#ebd38d>English] -> IncorrectQ1
+ [<color=\#ebd38d>Brazilian] -> IncorrectQ1
+ [<color=\#ebd38d>French] -> IncorrectQ1

=== CorrectQ1 ===
<color=\#C7C7C7>Correct!
//Give EXP
-> Question2

=== IncorrectQ1 ===
<color=\#C7C7C7>Incorrect!
-> Question2

=== Question2 ===
<color=\#C7C7C7>Next Question!
<color=\#C7C7C7>Question 2 - How many alphabets does the Japanese language have?

+ [<color=\#ebd38d>Four] -> IncorrectQ2
+ [<color=\#ebd38d>One] -> IncorrectQ2
+ [<color=\#ebd38d>Three] -> CorrectQ2
+ [<color=\#ebd38d>Two] -> IncorrectQ2

=== CorrectQ2 ===
<color=\#C7C7C7>Correct!
//Give EXP
-> Question3

=== IncorrectQ2 ===
<color=\#C7C7C7>Incorrect!
-> Question3

=== Question3 ===
<color=\#C7C7C7>Are you ready for this one?
<color=\#C7C7C7>Question 3 - Who discovered gravity by an apple falling on their head?

+ [<color=\#ebd38d>Marissaman Curry] -> IncorrectQ3
+ [<color=\#ebd38d>Chream Dawip] -> IncorrectQ3
+ [<color=\#ebd38d>Sweetephen (Potato) Hashking] -> IncorrectQ3
+ [<color=\#ebd38d>Instaant Newdles] -> CorrectQ3

=== CorrectQ3 ===
<color=\#C7C7C7>Correct!
//Give EXP
-> Question4

=== IncorrectQ3 ===
<color=\#C7C7C7>Incorrect!
-> Question4

=== Question4 ===
<color=\#C7C7C7>Almost there!
<color=\#C7C7C7>Question 4 - How many fingers do you have?

+ [<color=\#ebd38d>I have fingers?] -> IncorrectQ4
+ [<color=\#ebd38d>Nubs] -> CorrectQ4
+ [<color=\#ebd38d>Ten] -> IncorrectQ4
+ [<color=\#ebd38d>Eight] -> IncorrectQ4

=== CorrectQ4 ===
<color=\#C7C7C7>Correct!
//Give EXP
-> Question5

=== IncorrectQ4 ===
<color=\#C7C7C7>Incorrect!
-> Question5

=== Question5 ===
<color=\#C7C7C7>Last Question!
<color=\#C7C7C7>Question 5 - How tall are you?

+ [<color=\#ebd38d>60 Pixels] -> CorrectQ5
+ [<color=\#ebd38d>6'2 Feet] -> IncorrectQ5
+ [<color=\#ebd38d>184cm] -> IncorrectQ5
+ [<color=\#ebd38d>1.7m] -> IncorrectQ5

=== CorrectQ5 ===
<color=\#C7C7C7>Correct!
//Give EXP
-> Class1ADone

=== IncorrectQ5 ===
<color=\#C7C7C7>Incorrect!
-> Class1ADone

=== Class1ADone ===
<color=\#C7C7C7>That's all my questions for this lesson, see you in the next class!
DING DONG!
~loadNextLevel(8)
-> END