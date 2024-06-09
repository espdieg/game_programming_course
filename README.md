# game_programming_course
This repository contains the entire contents of a game programming project. I collaborated on this project with three other team members and it was a team effort to put everything together. If you'd like to skip ahead and just play the game it can be found [here](https://github.com/espdieg/game_programming_course/tree/main/Executable) 🕹️ 

### Gameplay overview:

  Our game is a simple 2D platformer where the objective is to shoot spawning enemies and remain alive as long as possible. Our player (stickman) is equipped with projectiles (detergent) and can run and jump on different platforms. It faces three types of opponents which are jerseys, pants, and hats. The jeans and jerseys continuously spawn in different areas and follow predetermined paths either North-South or East-West. The hats are spawned in only once at the beginning of the game and these know the player location and follow it around. Enemies have a health of 1 and once they are hit with detergent they vanish and our score is increased. The player has a health of 5 and loses 1 health each time it makes contact with an enemy. Once health reaches 0 the player is destroyed and there is a prompt asking for user to start game all over.

### [Executable folder](https://github.com/espdieg/game_programming_course/tree/main/Executable)
  This folder contains a link to download our executable from our Google drive and play the game yourself. 😄

### [Prefabs folder](https://github.com/espdieg/game_programming_course/tree/main/Prefabs) 
  This folder contains all the prefabs we used and are downloadable if you'd like to use them yourself. We do not own these, we made use of them from free resources online.

### [Scenes folder](https://github.com/espdieg/game_programming_course/tree/main/Scenes)
  Our game comprises of two scenes which are 'MainMenu' and 'SampleScene'. 'MainMenu' is just the main menu and 'SampleScene' is where the game is played. Both are accessible in this folder.

### [Scripts folder](https://github.com/espdieg/game_programming_course/tree/main/Scripts)
  Contains all of the scripts we created for our game. Down below I've included the name of each script and a brief summary of what it performs. Feel free to check them out! 📜

    BoxController - Updates the 3 text boxes in our game for score, health, and game over.
    CloseButton - After the popup window has been opened, when we click close this script is called. Closes popup and resumes time which resumes game.
    DetergentMovement - When we instantiate a new projectile (detergent) this script uses RigidBody for movement and also detects collisions, performs calls accordingly.
    EnemyHealth - This is called to destroy enemy gameObject when it collides with projectile. Also calls for an update to the score.
    EnemyMovement - Attached to the hats, this script allows these enemies to know the current player location and move towards it.
    EnemySpawn - We pass in prefabs and this spawns enemies at a preset spawnRate.
    GearController - This opens settings menu if it is not opened yet. It also pauses time which in effect pauses the game in the background.
    JeansAI - Attached to the jeans, this script continuously moves jean enemies up and down within the camera.
    LoadMainMenu - Within the popup menu if we click on the main menu button this script is called and loads scene 'MainMenu'.
    MovingPlatform - In the game background there is a ladder, this script moves an invisible one-way platform up and down to allow player to "use" ladder.
    PauseManager - This pauses time in order to pause game when the menu is opened.
    PlatformPlayer - Performs player movement, animations, detects collisions with enemies, and destroys player if health is 0.
    PlayerShoot - If we receive a mouse click, shoot detergent projectile in the correct direction.
    QuitGame - When a user clicks the 'quit game' button this script is called to quit application.
    SettingsPopup - This opens or closes the popup settings window whenever called. Also has a boolean method to return state of popup.
    ShirtAI - Attached to the jerseys, this script continuously moves jersey enemies left and right within the camera.
    StartButton - Re-loads our Sample Scene when a user clicks the Start button
    StartScreenManager - This simply loads 'SampleScene' when we click the start button. SampleScene is where our game is played.

Please feel free to email me if there are any issues accessing any packages.
