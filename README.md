# Mario-Stair-Case-Problem
Problem 2
Toward the beginning of World 1-1 in Nintendo’s Super Mario Brothers, Mario must hop over adjacent pyramids of blocks.


Let’s recreate those pyramids in C#, albeit in text, using hashes (#) for bricks. Each hash is a bit taller than it is wide, so the pyramids themselves are also taller than they are wide.

   #  #
  ##  ##
 ###  ###
####  ####


Let’s allow the user to decide just how tall the pyramid should be by first prompting them for a positive integer between, 1 and 8, inclusive. Here’s how the program might work if the user inputs 8 when prompted:

Height: 
8
       #  #
      ##  ##
     ###  ###
    ####  ####
   #####  #####
  ######  ######
 #######  #######
########  ########


Here’s how the program might work if the user inputs 4 when prompted:
Height: 
4
   #  #
  ##  ##
 ###  ###
####  ####


If the user doesn’t input a positive integer between 1 and 8, inclusive, when prompted, the program should re-prompt the user until they cooperate:

Height: 
-1
Invalid Input.
Height: 
0
Invalid Input.
Height: 
42
Invalid Input.
Height: 
Wow wow wee wa
Invalid Input.
Height: 
4
   #  #
  ##  ##
 ###  ###
####  ####


Notice that the ‘gaps’ between adjacent pyramids are equal to the width of two hashes (two spaces), irrespective of the pyramids’ height.
