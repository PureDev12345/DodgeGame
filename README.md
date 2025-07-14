# DodgeGame
Game codes for a simple dodging game.
This is also a step by step guide to making the game.

# Step 1: Create the project
  create a new project in unity editor.

# Step 2: Add the base
  create a cube and extend its lengths.

# Step 3: Add the player
  create a cube and add it infront of the camera. also color the camera red through material (to make sure the player can be easily seen.). Finally put it under the camera.

# Step 4: Adding boundaries
  add 2 cubes at the edge of the base cube and add the invisible material.(shown in tutorial)

# Step 5: Making obstacle
  create a cube, shape it to a suitable size so that the player can avoid it. make it into a prefab, add obstacle layermask to the prefab. after this delete the cube in game scene.

# Step 6: Adding Scripts:
  Create an empty in the game, add "game.cs" scripts in it. Add the "move and destroy.cs" script to the prefab. add the "movement.cs" script to
