using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class RandomMsgs : MonoBehaviour
{

    int index;
    TextMeshProUGUI text;
    PhotonView view;
    

    void Start()
    {
        view = GetComponent<PhotonView>();

        if (view.IsMine)
        {
            
            text = GetComponent<TextMeshProUGUI>();
            index = Random.Range(0, 300);


            if (index == 0)
            {
                text.text = "This message has a "+  + 1/300 +"% chance of appearing. You are lucky!";
            }

            if (index == 1)
            {
                text.text = "Join our Discord!";
            }

            if (index == 2)
            {
                text.text = "Press Alt + F4 to see an Easter Egg!";
            }

            if (index == 3)
            {
                text.text = "Kinda sus!";
            }

            if (index == 4)
            {
                text.text = "Memes Everywhere!";
            }

            if (index == 5)
            {
                text.text = "The best game ever!";
            }

            if (index == 6)
            {
                text.text = "Made by lucasof!";
            }

            if (index == 7)
            {
                text.text = "Amazing graphics!";
            }

            if (index == 8)
            {
                text.text = "The devs are going crazy!";
            }

            if (index == 9)
            {
                text.text = "Yes, of course!";
            }

            if (index == 10)
            {
                text.text = "I don't know what to write here!";
            }

            if (index == 11)
            {
                text.text = "HAHA, LOL!";
            }

            if (index == 12)
            {
                text.text = "Time for speedrun!";
            }

            if (index == 13)
            {
                text.text = "Hey, Dave, you fool!";
            }

            if (index == 14)
            {
                text.text = "Who is Dave?";
            }

            if (index == 15)
            {
                text.text = "Wooooooow!";
            }

            if (index == 16)
            {
                text.text = "I wish this game had spaceships!";
            }

            if (index == 17)
            {
                text.text = "I like to write random messages!";
            }

            if (index == 18)
            {
                text.text = "Ooooops! A bug where found!";
            }

            if (index == 19)
            {
                text.text = "Uhuuuuuuu!";
            }

            if (index == 20)
            {
                text.text = "Apples!";
            }

            if (index == 21)
            {
                text.text = "Random Message!";
            }

            if (index == 22)
            {
                text.text = "Heeeeey!";
            }

            if (index == 23)
            {
                text.text = "Memes and more memes!";
            }

            if (index == 24)
            {
                text.text = "I like cookies!";
            }

            if (index == 25)
            {
                text.text = "Help Me!";
            }

            if (index == 26)
            {
                text.text = "Kabooooom!";
            }

            if (index == 27)
            {
                text.text = "Try getting all achievements";
            }

            if (index == 28)
            {
                text.text = "Yoooooo!";
            }

            if (index == 29)
            {
                text.text = "Be peaceful!";
            }

            if (index == 30)
            {
                text.text = "OwO!";
            }

            if (index == 31)
            {
                text.text = "Defuse th Bomb!";
            }

            if (index == 32)
            {
                text.text = "Nice one!";
            }

            if (index == 33)
            {
                text.text = "Bomb has been defused!";
            }

            if (index == 34)
            {
                text.text = "I used to be an adventurer like you!";
            }

            if (index == 35)
            {
                text.text = "Not based on a block game, of course!";
            }

            if (index == 36)
            {
                text.text = "Rush B!";
            }

            if (index == 37)
            {
                text.text = "4554 is a good seed!";
            }

            if (index == 38)
            {
                text.text = "Punching a tree with only your hands is a bad idea!";
            }

            if (index == 39)
            {
                text.text = "Hey, you! You're finally awake!";
            }

            if (index == 40)
            {
                text.text = "I stay on the lobby for the music!";
            }

            if (index == 41)
            {
                text.text = "OMG!";
            }

            if (index == 42)
            {
                text.text = "I like random messages!";
            }

            if (index == 43)
            {
                text.text = "Indie!";
            }

            if (index == 44)
            {
                text.text = "No, I'm not copying that game!";
            }

            if (index == 45)
            {
                text.text = "I should sleep!";
            }

            if (index == 46)
            {
                text.text = "Follow us on Twitter!";
            }

            if (index == 47)
            {
                text.text = "@teamlazycat";
            }

            if (index == 48)
            {
                text.text = "Made with Unity!";
            }

            if (index == 49)
            {
                text.text = "I'm tired of writing messages!";
            }

            if (index == 50)
            {
                text.text = "This message have the '50' ID!";
            }

            if (index == 51)
            {
                text.text = "hedfijkafewfu!";
            }

            if (index == 52)
            {
                text.text = "100$ ? SERIOUSLY!?";
            }

            if (index == 53)
            {
                text.text = "Play with your friends!";
            }

            if (index == 54)
            {
                text.text = "A wild <Name> appears!";
            }

            if (index == 55)
            {
                text.text = "Rock!";
            }

            if (index == 56)
            {
                text.text = "Diamonds! Uh, wrong game..";
            }

            if (index == 57)
            {
                text.text = "I understood that reference!";
            }

            if (index == 58)
            {
                text.text = "If you got this message, print and send me on twitter: @lucazof";
            }

            if (index == 59)
            {
                text.text = "Congratulations!";
            }

            if (index == 60)
            {
                text.text = "Lotus!";
            }

            if (index == 61)
            {
                text.text = "Object reference not set to an instance of an object!";
            }

            if (index == 62)
            {
                text.text = "Made in C#!";
            }

            if (index == 63)
            {
                text.text = "You are connected to a Photon Server!";
            }

            if (index == 64)
            {
                text.text = "Online!";
            }

            if (index == 65)
            {
                text.text = "RandomMsgs.cs is the name of this script!";
            }

            if (index == 66)
            {
                text.text = "Music by... no one apparently!";
            }

            if (index == 67)
            {
                text.text = "Don't destroy your keyboard!";
            }

            if (index == 68)
            {
                text.text = "Mom, get the camera!";
            }

            if (index == 69)
            {
                text.text = "Spooky Scary Skeleton!";
            }

            if (index == 70)
            {
                text.text = "I like videogames!";
            }

            if (index == 71)
            {
                text.text = "Hello, World!";
            }

            if (index == 72)
            {
                text.text = "Zzzzzzzz!";
            }

            if (index == 73)
            {
                text.text = "Yes! Gold is better than Iron!";
            }

            if (index == 74)
            {
                text.text = "Get in the F***** robot, Shinji!";
            }

            if (index == 75)
            {
                text.text = "How many messages they have?";
            }

            if (index == 76)
            {
                text.text = "Homework? Nah, Let's build a base!";
            }

            if (index == 77)
            {
                text.text = "Do your homework!";
            }

            if (index == 78)
            {
                text.text = "#@$%&#$*!";
            }

            if (index == 79)
            {
                text.text = "I drink coffee to play all night!";
            }

            if (index == 80)
            {
                text.text = "Arthur, get out the tank!";
            }

            if (index == 81)
            {
                text.text = "Good Morning!";
            }

            if (index == 82)
            {
                text.text = "Good Afternoon!";
            }

            if (index == 83)
            {
                text.text = "Good Night!";
            }

            if (index == 84)
            {
                text.text = "Noog Dight!";
            }

            if (index == 85)
            {
                text.text = "PC GAMER!";
            }

            if (index == 86)
            {
                text.text = "#1 Victory Royal!";
            }

            if (index == 87)
            {
                text.text = "NullPointerException: null!";
            }

            if (index == 88)
            {
                text.text = "Don't get Dehydrated!";
            }

            if (index == 89)
            {
                text.text = "We do a bit of trolling!";
            }

            if (index == 90)
            {
                text.text = "A wise man once said:";
            }

            if (index == 91)
            {
                text.text = "Only 10% of my viewers are subscribed!";
            }

            if (index == 92)
            {
                text.text = "You Died!";
            }

            if (index == 93)
            {
                text.text = "Plin, Plin, Plon!";
            }

            if (index == 94)
            {
                text.text = "Bomb has been planted!";
            }

            if (index == 95)
            {
                text.text = "Drop me AWP!";
            }

            if (index == 96)
            {
                text.text = "Did I ever tell you the definition of insanity?";
            }

            if (index == 97)
            {
                text.text = "I like easter eggs!";
            }

            if (index == 98)
            {
                text.text = "Click on this message 5 times and see the magic happening!";
            }

            if (index == 99)
            {
                text.text = "I think your save is corrupted! Just Kidding!";
            }

            if (index == 100)
            {
                text.text = "That was the 100th message I wrote!";
            }

            if (index == 101)
            {
                text.text = "Pro Gamer Move!";
            }

            if (index == 102)
            {
                text.text = "Earth is Round!";
            }

            if (index == 103)
            {
                text.text = "Praise the sun!";
            }

            if (index == 104)
            {
                text.text = "The gods of Olympus abandoned me!";
            }

            if (index == 105)
            {
                text.text = "You picked the wrong house, fool!";
            }

            if (index == 106)
            {
                text.text = "Let's back to programming!";
            }

            if (index == 107)
            {
                text.text = "Trees!";
            }

            if (index == 108)
            {
                text.text = "You have my sword!";
            }

            if (index == 109)
            {
                text.text = "Build a base!";
            }

            if (index == 110)
            {
                text.text = "Unironically Good!";
            }

            if (index == 111)
            {
                text.text = "Error 404, Not Found!";
            }

            if (index == 112)
            {
                text.text = "Nop!";
            }

            if (index == 113)
            {
                text.text = "Run, Forest, Run!";
            }

            if (index == 114)
            {
                text.text = "Why is the Queen so OP?";
            }

            if (index == 115)
            {
                text.text = "Checkmate!";
            }

            if (index == 116)
            {
                text.text = "I'M 1 HP!!!";
            }

            if (index == 117)
            {
                text.text = "Made in Brazil!";
            }

            if (index == 118)
            {
                text.text = "1337!";
            }

            if (index == 119)
            {
                text.text = "Like a Boss!";
            }

            if (index == 120)
            {
                text.text = "Avaiable on itch.io!";
            }

            if (index == 121)
            {
                text.text = "Indeed!";
            }

            if (index == 122)
            {
                text.text = "I'm Hungry!";
            }

            if (index == 123)
            {
                text.text = "No way Dude!";
            }

            if (index == 124)
            {
                text.text = "It's dangerous to go alone! Take This.";
            }

            if (index == 125)
            {
                text.text = "And my bow!";
            }

            if (index == 126)
            {
                text.text = "And my axe!";
            }

            if (index == 127)
            {
                text.text = "Beep Boop!";
            }

            if (index == 128)
            {
                text.text = "Still Alive!";
            }

            if (index == 129)
            {
                text.text = "Go touch grass (Not virtual one)";
            }

            if (index == 130)
            {
                text.text = "Calm down, tryhard!";
            }

            if (index == 131)
            {
                text.text = "Brrrrrr!";
            }

            if (index == 132)
            {
                text.text = "More than 1000 lines of code!";
            }

            if (index == 133)
            {
                text.text = "That's the way it is!";
            }

            if (index == 134)
            {
                text.text = "Why my joystick isn't working!?";
            }

            if (index == 135)
            {
                text.text = "No Pain No Gain!";
            }

            if (index == 136)
            {
                text.text = "Also try Cold Race!";
            }

            if (index == 137)
            {
                text.text = "Penguins!";
            }

            if (index == 138)
            {
                text.text = "A dragon! I saw a dragon!";
            }

            if (index == 139)
            {
                text.text = "Source on GitHub!";
            }

            if (index == 140)
            {
                text.text = "Very Funny!";
            }

            if (index == 141)
            {
                text.text = "Spoooky!";
            }

            if (index == 142)
            {
                text.text = "What a Noob!";
            }

            if (index == 143)
            {
                text.text = "Why do I hear Boss Music?";
            }

            if (index == 144)
            {
                text.text = "This game is getting Rust!";
            }

            if (index == 145)
            {
                text.text = "Sheesh!";
            }

            if (index == 146)
            {
                text.text = "Splaaash!";
            }

            if (index == 147)
            {
                text.text = "r/woooosh";
            }

            if (index == 148)
            {
                text.text = "LMAO!";
            }

            if (index == 149)
            {
                text.text = "You didn't see this!";
            }

            if (index == 150)
            {
                text.text = "Where are the blocks?";
            }

            if (index == 151)
            {
                text.text = "Strike me down, Zeus!";
            }

            if (index == 152)
            {
                text.text = "Zooooooom!";
            }

            if (index == 153)
            {
                text.text = "Very Cool!";
            }

            if (index == 154)
            {
                text.text = "I like cats!";
            }

            if (index == 155)
            {
                text.text = "I like dogs!";
            }

            if (index == 156)
            {
                text.text = "Turtle!";
            }

            if (index == 157)
            {
                text.text = "Sharp and Shiny!";
            }

            if (index == 158)
            {
                text.text = "Be careful!";
            }

            if (index == 159)
            {
                text.text = "A chest isn't always a chest!";
            }

            if (index == 160)
            {
                text.text = "Worms on the ground!";
            }

            if (index == 161)
            {
                text.text = "Magic!";
            }

            if (index == 162)
            {
                text.text = "Sup!";
            }

            if (index == 163)
            {
                text.text = "Is there a Ghost?";
            }

            if (index == 164)
            {
                text.text = "Procedural Map Generation!";
            }

            if (index == 165)
            {
                text.text = "Subscribe at Sebastian Lague!";
            }

            if (index == 166)
            {
                text.text = "Gooooaaaaal!";
            }

            if (index == 167)
            {
                text.text = "I SAW HEROBRINE!";
            }

            if (index == 168)
            {
                text.text = "Just Chilling!";
            }

            if (index == 169)
            {
                text.text = "Shift + Tab doesn't work!";
            }

            if (index == 170)
            {
                text.text = "Avaiable on GameJolt!";
            }

            if (index == 171)
            {
                text.text = "YceMC the best server ever!";
            }

            if (index == 172)
            {
                text.text = "Call me on Skype!";
            }

            if (index == 173)
            {
                text.text = "Bots are invading!";
            }

            if (index == 174)
            {
                text.text = "Light the way!";
            }

            if (index == 175)
            {
                text.text = "It's comfy here!";
            }

            if (index == 176)
            {
                text.text = "Is this working?";
            }

            if (index == 177)
            {
                text.text = "Theres an error on line 467";
            }

            if (index == 178)
            {
                text.text = "I fixed the error on line 467!";
            }

            if (index == 179)
            {
                text.text = "Ultra Realistic!";
            }

            if (index == 180)
            {
                text.text = "The ceiling is lava!";
            }

            if (index == 181)
            {
                text.text = "The floor is water!";
            }

            if (index == 182)
            {
                text.text = "Text.text = 'Text.text'";
            }

            if (index == 183)
            {
                text.text = "Doesn't even make sense!";
            }

            if (index == 184)
            {
                text.text = "Check on your map!";
            }

            if (index == 185)
            {
                text.text = "Yaaaaaaay!";
            }

            if (index == 186)
            {
                text.text = "1.e4 is the best!";
            }

            if (index == 187)
            {
                text.text = "100% Memes!";
            }

            if (index == 188)
            {
                text.text = "Joooooj!";
            }

            if (index == 189)
            {
                text.text = "Good Luck!";
            }

            if (index == 190)
            {
                text.text = "Mr. Rabbit are angry!";
            }

            if (index == 191)
            {
                text.text = "qwerty!";
            }

            if (index == 192)
            {
                text.text = "CAPTAIN, LOOK!";
            }

            if (index == 193)
            {
                text.text = "TROLLOLOLOLO!";
            }

            if (index == 194)
            {
                text.text = "Call the Police!";
            }

            if (index == 195)
            {
                text.text = "There's a lot of scripts here!";
            }

            if (index == 196)
            {
                text.text = "Assets/Scripts/UI/RandomMsgs.cs";
            }

            if (index == 197)
            {
                text.text = "Can you help me testing the multiplayer?";
            }

            if (index == 198)
            {
                text.text = "There is an imposter among us!";
            }

            if (index == 199)
            {
                text.color = Color.blue;
                text.text = "I like blue!";
            }

            if (index == 200)
            {
                text.text = "Two Hundred!";
            }


            if (index == 201)
            {
                text.text = "Away from Keyboard!";
            }

            if (index == 202)
            {
                text.text = "Whats Up, Player?";
            }

            if (index == 203)
            {
                text.text = "Don't you have better games to play?";
            }

            if (index == 204)
            {
                text.text = "I'm an AI and I'll rule the world! ";
            }

            if (index == 205)
            {
                text.text = "Have you ever seen the rain?";
            }

            if (index == 206)
            {
                text.text = "Epic Phrase!";
            }

            if (index == 207)
            {
                text.text = "<Insert real cool Splash Text here!>";
            }

            if (index == 208)
            {
                text.text = "Uhh, I don't think so!";
            }

            if (index == 209)
            {
                text.text = "Call your friends!";
            }

            if (index == 210)
            {
                text.text = "!looC yreV";
            }

            if (index == 211)
            {
                text.text = "Loading...";
            }

            if (index == 212)
            {
                text.text = "I really like spaceships!";
            }

            if (index == 212)
            {
                text.text = "Burritos!";
            }

            if (index == 213)
            {
                text.text = "Tacos!";
            }

            if (index == 214)
            {
                text.text = "I would like to order a pizza!";
            }

            if (index == 215)
            {
                text.text = "Incredible!";
            }

            if (index == 216)
            {
                text.text = "Let's take the Battle Bus!";
            }

            if (index == 217)
            {
                text.text = "Did I ask?";
            }

            if (index == 218)
            {
                text.text = "Who asked?";
            }

            if (index == 219)
            {
                text.text = "Doubledoor asked calmly!";
            }

            if (index == 220)
            {
                text.text = "Pão de Queijo!";
            }

            if (index == 221)
            {
                text.text = "Vector3 vector3 = New Vector3(x,y,z);";
            }

            if (index == 222)
            {
                text.text = "Shhhhhh!";
            }

            if (index == 223)
            {
                text.text = "Bread and Fish!";
            }

            if (index == 224)
            {
                text.text = "Are you spanish?";
            }

            if (index == 225)
            {
                text.text = "Rise and Shine, Mr Freeman!";
            }

            if (index == 226)
            {
                text.text = "Switching to your pistol is faster than reloading!";
            }

            if (index == 227)
            {
                text.text = "You knew there are no limitations on how much characters I can put on these messages? I can write anything that I want, this is pretty cool!";
            }

            if (index == 228)
            {
                text.text = "Fur Elise!";
            }

            if (index == 229)
            {
                text.text = "Big Brain Time!";
            }

            if (index == 230)
            {
                text.text = "Mitril? We don't have it here!";
            }

            if (index == 231)
            {
                text.text = "Fairy Enough!";
            }

            if (index == 232)
            {
                text.text = "Fus Ro Dah!";
            }

            if (index == 233)
            {
                text.text = "If someone wants to buy this game for 2 billion dolars, tell me!";
            }

            if (index == 234)
            {
                text.text = "Gotta go fast!";
            }
            if (index == 235)
            {
                text.text = "¡uʍop ǝpᴉsdn";
            }

            if (index == 236)
            {
                text.text = "Explooooosiooon!";
            }

            if (index == 237)
            {
                text.text = "No Idea!";
            }

            if (index == 238)
            {
                text.text = "Wheeeat!";
            }

            if (index == 239)
            {
                text.text = "I believe I can fly!";
            }

            if (index == 240)
            {
                text.text = "Ultra Advanced!";
            }

            if (index == 241)
            {
                text.text = "Ctrl + C / Ctrl + V";
            }

            if (index == 242)
            {
                text.text = "Hey, take breaks sometimes!";
            }

            if (index == 243)
            {
                text.text = "Titanium Armor is cool!";
            }

            if (index == 244)
            {
                text.text = "Under development!";
            }

            if (index == 245)
            {
                text.text = "This was written 06/19/2022 at 6:45 PM!";
            }

            if (index == 246)
            {
                text.text = "World Record for Random Messages! (or not)";
            }

            if (index == 247)
            {
                text.text = "Am I on youtube?";
            }

            if (index == 248)
            {
                text.text = "Made by Lazy Cat Games!";
            }

            if (index == 249)
            {
                text.text = "Well Played!";
            }

            if (index == 250)
            {
                text.text = "I tried so hard, and got so far!";
            }

            if (index == 251)
            {
                text.text = "Itadakimasu!";
            }

            if (index == 252)
            {
                text.text = "One man's army!";
            }

            if (index == 253)
            {
                text.text = "You are Breathtaking!";
            }

            if (index == 254)
            {
                text.text = "Wake the F*** Up, Samurai.";
            }

            if (index == 255)
            {
                text.text = "Bravo!";
            }

            if (index == 256)
            {
                text.text = "0! = 1";
            }

            if (index == 257)
            {
                text.text = "E = m * c²";
            }

            if (index == 258)
            {
                text.text = "The misty mountains cold!";
            }

            if (index == 259)
            {
                text.text = "The book is on the table!";
            }

            if (index == 260)
            {
                text.text = "Nah!";
            }

            if (index == 261)
            {
                text.text = "Finally trees!";
            }

            if (index == 262)
            {
                text.text = "What a sync!";
            }

            if (index == 263)
            {
                text.text = "Yup!";
            }

            if (index == 264)
            {
                text.text = "Zoooooom!";
            }

            if (index == 265)
            {
                text.text = "J!";
            }

            if (index == 266)
            {
                text.text = "01100011 01101111 01101111 01101100!";
            }

            if (index == 267)
            {
                text.text = "Zombies everywhere!";
            }

            if (index == 268)
            {
                text.text = "Build!";
            }

            if (index == 269)
            {
                text.text = "Is the only one I have!";
            }

            if (index == 270)
            {
                text.text = "¯|_(ツ)_/¯";
            }

            if (index == 271)
            {
                text.text = "Working on it!";
            }

            if (index == 272)
            {
                text.text = "Thank you for playing my game!";
            }

            if (index == 273)
            {
                text.text = "Free to play!";
            }

            if (index == 274)
            {
                text.text = "Not on Steam! (yet)";
            }

            if (index == 275)
            {
                text.text = "This is the road to madness!";
            }

            if (index == 276)
            {
                text.text = "Surfing on Internet!";
            }

            if (index == 277)
            {
                text.text = "Not AAA!";
            }

            if (index == 278)
            {
                text.text = "I'm tired!";
            }

            if (index == 279)
            {
                text.text = "Now with multiplayer!";
            }

            if (index == 280)
            {
                text.text = "I don't know!";
            }

            if (index == 281)
            {
                text.text = "Get off the lobby!";
            }

            if (index == 282)
            {
                text.text = "Not infinite!";
            }

            if (index == 283)
            {
                text.text = "Hardcore!";
            }

            if (index == 284)
            {
                text.text = "Don't try cheating!";
            }

            if (index == 285)
            {
                text.text = "Hey, listen!";
            }

            if (index == 286)
            {
                text.text = "The moon is right there!";
            }

            if (index == 287)
            {
                text.text = "At this point, I don't know what to write anymore!";
            }

            if (index == 288)
            {
                text.text = "Wolf!";
            }

            if (index == 289)
            {
                text.text = "What a lazy cat!";
            }

            if (index == 290)
            {
                text.text = "Meow!";
            }

            if (index == 291)
            {
                text.text = "We need more muneh!";
            }

            if (index == 292)
            {
                text.text = "I got a plan!";
            }

            if (index == 293)
            {
                text.text = "Creative!";
            }

            if (index == 294)
            {
                text.text = "Roses are Red, Violets are blue. Ctrl c + Ctrl v, I took your code!";
            }

            if (index == 295)
            {
                text.text = "Pretty Sky!";
            }

            if (index == 296)
            {
                text.text = "Two Glocks!";
            }

            if (index == 297)
            {
                text.text = "Just Wandering!";
            }

            if (index == 298)
            {
                text.text = "Finally!";
            }

            if (index == 299)
            {
                text.text = "Replant the trees!";
            }

            if (index == 300)
            {
                text.text = "Yoink!";
            }
        }
    }


}
