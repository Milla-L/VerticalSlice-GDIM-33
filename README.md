## Milestone 1
### Visual Script
One of my visual scripts is the Player Chat script. It progresses my dialogue and monitors the relationship interger and reacts accordingly. The visual script takes the code from the C# scripts and then creates a custom event that uses these scripts to then go through the dialogue system. The visual script first goes through to get rid of the old buttons and script nodes. Then it progresses onto the next scriptable object in the order or whichever one was chosen. From there, the text for the buttons is set up to display the right player responces and NPC dialogue before being instanciated into the screen. 
### Updated Breakdown
<img width="1149" height="890" alt="Updated Breakdown" src="https://github.com/user-attachments/assets/bad4dc18-c458-4556-975a-81733cb61439" />
I changed the Dialogue UI to be the Script Machine because I no longer required a C# script to do what I needed to update the UI as it needed to be. I was able to fix this in my script machine entirely making it an easy swap out. I also changed one of my other boxes to be the Canvas. Because I was no longer doing a UI catch all, I wanted to include the Canvas because that is a majority of where my actual visual aspects are coming from. The state machine in my game currently works by looking at the friendship scene variable and checking if it abover 50 to play one button click noise and if it is below 50 to play a different one. This way it tracks where the player's relationship is. The relationship scene variable is adjusted by other visual scripts in the code. 

## Milestone 2
### Task Breakdown
My complicating game feature for this milestone is making new events occur based on friendship level with the player. This just means that based on the friendship level being either good or bad, a new event will play it out for each at the end of my demo. 
1. I will add more dialogue with more chances to increase/decrease friendship level so that the demo has clear set states.
- Add in more dialogue leading pathways
- More dialogue layers to accomodate the increase and decreasing
- Add more chances for increasing/decreasing and keeping neutral level
2. I will make a physical indicator of the friendship level to be accessed on the screen.
- Set up a slider on the UI canvas and scale it
- Add slider/bar that hooks up to the friendship variable
- Make sure it anchors right in Unity and Build
3. I will edit my state machine to set up a different transition for each.
- Arrange the states to call on the new events
- Make sure the states call properly according to the frienship variable constraint

### Task Breakdown After Coding
The task breakdown was very useful for getting stuff done. It gave me a basic guideline of what to do and in what order so that I was kept in relative order and helped guide along my thoughts on what needed to happen and when. I would do something like this again where I make a general to do list and stuck to it. 

### Visual Script Graph
I hook my C# dialogue script up to a lot of my visual scripts. My most evident/expansive one is the one which controls my player dialogue and increase and decrease of the Friendship variable. This is the main big graph and it all stems from that one C# New Dialogue Event script. This serves as the key architecture in my game because it is what both progresses the dialogue through its motions and transforms the main variable in the game so that the Friendship variable can change and cause the new ending in the cliff following along all the left most options. The graph below clearly calls on that custom event to then branch off of to be interactable to the player. 
<img width="1798" height="1292" alt="C# Custom Event to Script Graph" src="https://github.com/user-attachments/assets/52b4828d-0481-41d9-b08c-51b34d2c31fe" />

### Unity Feature
The Unity feature that I would like graded are the Scriptable Objects. They are the key factors in my game and, because I am doing a visual novel, are the largest and most expansive components with three layers of dialogue for all pathways and four layers for two of the third layer dialogue choices. I have an alternate event that happens based on the dialogue options and friendship level of the player that occurs on one of these pathways which to get is as simple as choosing all of the left-most buttons to then give an alternate end to the rest of the options. 
