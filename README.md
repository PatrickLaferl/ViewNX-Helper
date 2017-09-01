# ViewNX-Helper
Helper utility for Nikon ViewNX 2.

Nikon ViewNX 2 does not seem to display the progress of the current image editing operation. Because of this, it is not always easy to tell whether an image adjustment has already been applied or not.

This program displays an icon overlayed on top of VievNX, indicating that an operation is still in progress. The icon disappears when the operation has finished.

This is achieved by monitoring the CPU load of the ViewNX process.

The program is displayed in the notification area in the task bar. Right-clicking the icon allows you to start ViewNX, to open the program settings and to close the program.

When the program is started and ViewNX is not running, it is started automatically.

The available settings are as follows.
* Program Path: Path to the executable of ViewNX
* Process Name: Name of the ViewNX process
* Load Treshold: CPU load of ViewNX which is considered busy, in percent
* Update Interval: Interval of CPU load and icon position updates, in milliseconds
