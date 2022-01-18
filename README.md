# Ray Cast Engine C#

This is a First-Person ray cast game using Lode's tutorial rewritten to C# (https://lodev.org/cgtutor/raycasting.html)

## RoadMap
* This game is currently only in Winforms but it will be changed to monogame framework for DirectX
because this is running on winforms and resizing the form to a bigger resolution will drastically lower the fps

## How to use
* Once in game press 'm' to lock cursor and look around with mouse (move with W A S D keys)
* Scroll up or down to change field of view
* Currently no sprites are added, if you want to add aprite, you can add sprite values to sprite field and specify which texture index to use.
Any texture will work but if the image is bigger than 256x256 the extra length will be cut off.