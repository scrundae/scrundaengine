# scrundaengine
A silly test I made. Now that I'm starting to get this class stuff better, I've been improving the engine in newer editions!
# Tutorial - Starting off
Start off by creating a "Console App". Then, add scrundaengine as a reference. Finally, we can start coding.

Lets start off by adding the engine.

Type in your main class: "Engine engine = new Engine"

(Note that you can call Engine whatever you want, but just make sure that when you use code up ahead, you call "engine" what you call it here).

Great, now you can use the engine.
# Tutorial - Points
Lets start by adding points to our window using a very simple rendering method. We can create a new point by typing in: "engine.PlotPoint(int x, int y, string pointDefiner)"

The X integer is the X position of the point. The Y integer is the Y position of the point. Note that due to the extremely basic text rendering, the X jumps are heigher than the Y jumps.

The point definer is what the point will look like in game. So if you set it to the character "X", it will take the shape of the character "X".
# Tutorial - Recording text entered
When using Engine.Record(), it will command the console to ask for user input. This will then be stored to "globalUserRecord"
# Tutorial - Recording keys pressed
When using Engine.Scrape(), it will command the console to check which key is being pressed. This will then be stored to "globalUserScrape"
# That's it
I recommend you use newer versions of the engine. This version is incredibly basic and difficult to use.
