# FlappyBirdRedesigned
### School Asignment  

A "simple" C# Windows Forms game. If you know what FlappyBird is, and I know you do, then you know what's this all about.
The whole "game" is hard-coded from scratch, which means I have coded all of the functionalities that there are, for **instance** the collision detection is achieved using complicated if that compares X, Y, maxX and maxY (using this I was able to get all the edges that might collide), coordinates of the player (**the bird**) and of course also with every rendered column. **I'll try to explain:** 
  
maxY ----- 
     |   |
 y x ----- maxX
   
So now I know all the **bounds** of the player and also the column. 
  
During development I had no idea that PictureBox has a property **bound**, which has method **intersectWith()** and I would have to reinvent the wheel, but it happened.
  
