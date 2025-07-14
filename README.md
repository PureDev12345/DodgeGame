# DodgeGame
Game codes for a simple dodging game.
This is also a step by step guide to making the game.

# Step 1: Create the project
  create a new project in unity editor.

# Step 2: Add the base
  create a cube and extend its lengths.

# Step 3: Add the player
  create a cube and add it infront of the camera. also color the player cube red through material (to make sure the player can be easily seen.). Finally put it under the camera.
also add a character controler in the camera.

# Step 4: Adding boundaries
  add 2 cubes at the edge of the base cube and add the invisible material.(shown in tutorial)

# Step 5: Making obstacle
  create a cube, shape it to a suitable size so that the player can avoid it. make it into a prefab, add obstacle layermask to the prefab. after this delete the cube in game scene.

# Step 6: Adding Scripts
  Create an empty in the game, add "game.cs" scripts in it. Add the "move and destroy.cs" script to the obstacle prefab. add the "movement.cs" script to the camera.

# Step 7: Final Touches
  add all the necessary details in the code. in the "movement.cs" add the character controller from the camera,adjust speed,and add obstacle layer. In "game.cs" add  obstacle prefab. Finally in "move and destroy.cs" adjust speed accordingly in the obstacle prefab.

# Step 8: Enjoy
  The game is complete and now you have completed your first game, have fun, enjoy and experiment. :)

  Final Note, Thanks for supporting me, even if I am just some  guy, you showed support by watching my videos. No amount of thanks can be enough for you. :)
