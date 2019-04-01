## Authors
Matthew Castronova  
Corinne Green  
Rebecca Medina  
Alex Pasieka  
Thomas Ryszkiewicz  

## What kind of experience do you want to build? (AR/VR/XR)
- AR

## What toolstack do you want to use? (Unity, Web, others on request)
- Unity

## What SDK would you like to use? (GoogleVR, SteamVR, OpenVR, AFrame, Vuforia, ARCore, AR.js, others on request)
- ARCore

## What hardware will you target?
- Android, possibly iOS if Unity supports building

## Who is the target user?
- Tourists or proespective students on on-campus tours. They will have smart phones (specifically Android, and iOS if
we can manage to build it in Unity), and have enough knowledge to run basic applications on them. They do not need to
be technically savy or have any advanced technology. Parents and students are equally encouraged to try the application.
To match with the environment at RIT of inclusivity, we are aiming for an application both hearing and deaf/HoH people 
can use. 

## Concept of Application
Our application will be an interactive tour app designed for the RIT campus. Users will be able to select destinations,
which will then give them a path to follow to reach the chosen destination. Buildings and other landmarks will display
information in the form of a text bubble. Users will be able to click these text bubbles to get more information in the 
form of website links, videos, or simply more detailed text.

 Our application will be made so it matches the RIT aesthetic. We will be using the color palatte consisting of orange 
 and brown. Our design will be minimalistic, so as not to detract from the campus which is the point of the app. We want to
 help increase the knowledge of campus by showing the campus, not added objects or distractions. Sound will also be minimal 
 so as not to be intrusive. A sound effect will play when the user reaches their chosen destination. 

 Interactions will be minimal, with the main goal to be to get the user to interact with the campus by exploring it on foot.
 In-app interactions will include selecting desired locations, and clicking info boxes for more information. The user will also
 move the phone to be able to find the path defined for them.

 ### Summary

- Scene Design: Match the aesthetic of RIT's design (orange, brown, tigers)
- Interactions: Click on AR objects for more info about location (i.e. websites, videos, etc.)
- Sound/Haptic Feedback: Potential sound effect upon arrival at location (vibrations for deaf or HOH students)

## Initial Research

Before continuing work on this plan, we must determine whether it is possible to use GPS to determine building and object 
location. We believe this is possible through the Google Maps API, which may also be able to provide us with paths, 
but we need to investigate how this will work in Unity with ARCore. 

- Using GPS (Google Maps API, etc.) with ARCore
- Placing AR objects at GPS coordinates
- RIT's tunnel system and campus map
- Text-to-Speech (potential add-on feature)

