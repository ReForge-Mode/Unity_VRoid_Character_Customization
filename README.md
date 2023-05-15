# VRoid Character Customization in Unity
A lot of people has been asking for character customization of VRoid models in Unity. Here's how you do it!

Huge credit to these guys who made this possible!
- UniVRM plugin: https://github.com/vrm-c/UniVRM
- VRoid Free Model: https://hub.vroid.com/en/users/36144806

<p align="center"><img src="https://github.com/FFaUniHan/Unity_VRoid_Character_Customization/blob/main/Demo.gif" width=60% height=60%></p>


# Tutorial Video
Here are the video tutorial for the process and the unofficial documentation. 

[![Thumbnail!](https://github.com/FFaUniHan/Unity_VRoid_Character_Customization/blob/main/Video.jpg)](https://youtu.be/2miJLS6C_fY "How to Create Character Customization in Unity using VRoid Models")

# Instructions
Once you download and extract the zip file or clone the project to your Git application, open it in Unity Hub. This project uses Unity version 2022.2.15f1, earlier versions of Unity might not work, and later versions might break some of the scripts. To download a specific version of Unity, go to this website https://unity3d.com/get-unity/download/archive. After you download and install the Unity version, you can add this version of Unity back to Unity Hub and open it.

# For the Missing Prefab Error
You need to reimport every VRM files in the project so Unity can recognize it. It only takes a minute. Here's how:

[![Thumbnail!](https://github.com/FFaUniHan/Unity_VRoid_Character_Customization/blob/main/Video2.jpg)](https://youtu.be/-jC4NamKS0M "VRoid Missing Prefabs Problem? Here's a quick fix!")

# VRoid Guideline Issue
I was recently informed that this customization system may be against VRoid terms of service (https://vroid.com/en/studio/guidelines)</b>

> "You cannot use VRoid Studio to create an application that can deform meshes and/or can create 3D models like avatars and items by combining meshes and/or textures."

So I messaged VRoid team and got an email back from VRoid. Here's what they said:

> "If the application does not have an export function, it is not considered to have a function for creating avatars, items, or other 3D models"

So, I guess it's okay as long as you use it internally inside your game. 

Here's the screenshot of my communication with VRoid team. On a side note, I am impressed they reply without hours. Bravo!

<p align="center"><img src="https://github.com/FFaUniHan/Unity_VRoid_Character_Customization/blob/main/Email.jpg" width=100% height=100%></p>
