# Computer Vision
This is a collection of sample projects I'm using to get familiar with various open cv features. My goal is to better understand the current state of computer vision technology so that I can make informed and realistic design decisions.

**Key areas of interest:**
* Face Detection
* Face Recognition
* Object Recognition
* Marker detection
* Image Processing


## Open CV + Unity
So far, this project incorporates the Open CV + Unity asset bundle (not included in this repo, available: https://www.assetstore.unity3d.com/en/#!/content/85928). At this point, I'd need to develop an interface that expose some of the features to the unity editor.

![Open CV Face Detection](/OpenCVPlusUnity/opencv-facerec.png)
_Face detection_
![Open CV Object Recognition](/OpenCVPlusUnity/opencv-objects.png)
_Object Recognition_
![Open CV Contours](/OpenCVPlusUnity/opencv-contours.png)
_Edge Detection_


## Open CV For Unity
 This project incorporates the _Open CV for Unity_ asset bundle (not included in this repo, available: https://www.assetstore.unity3d.com/en/#!/content/21088). For quickly hacking on Open CV inside of Unity, I recommend this plugin over the other. There is better integration with the Unity Editor and is IMO easier to use for quick explorations.

A quick example was an app that I made that detects a face and subsequently activates objects. In this case, I activated a "Happy Birthday" sound effect and confetti video object. I was able to wire this up in just a few minutes. This is a silly example of how you can use Unity and Open CV. Next up will be to detect the face location and attach an object to it.

![Open CV Face Detection](/OpenCVForUnity/open-cv-happybirthday.png)
_Happy Birthday! Face detection..._