# IGME 480.01 Final Project Documentation 

## Authors
Matthew Castronova  
Corinne Green  
Rebecca Medina  
Alex Pasieka  
Thomas Ryszkiewicz  

## Project Design
The RIT AR Campus Tour is a Unity Android application that utilizes the GPS, compass, and Vuforia's augmented reality camera to provide enhanced views and information on the academic, dormitory, and dining services on RIT’s campus. Views of RIT’s campus are enhanced with blurbs of information that a visitor or prospective student on RIT’s campus might want to know. Our AR Campus Tour allows visitors to learn about buildings on RIT's campus easily and on their own, allowing the user to search for and navigate to campus buildings through the interface.

### Target User
The target user for the RIT AR Campus Tour is visitors or prospective students interested in learning more about RIT’s campus locations and landmarks. Furthermore, the application can also be useful to students of all years trying to navigate to different buildings for their classes.

### Hardware Platform
The RIT AR Campus Tour is supported by Android devices with Android version 6 and up.

### Visual and Auditory Scene Design
The design of the application takes inspiration from RIT’s homepage, using the same block quotes, fonts, and colors to mimic the look and feel of RIT’s brand. The minimalistic design and color scheme flow throughout the application in each scene.

The RIT AR Campus Tour starts with a menu screen that allows the user to start the tour, view information about the application, see a directory of all the locations available through the tour, view credits for developer and asset contributions, and quit the application. 

Because this is an RIT AR Campus Tour, we were mindful of the fact that RIT houses one of the largest technical colleges in the world for students who are deaf and hard of hearing and therefore did not want to heavily saturate the application with sound cues or elements that rely on sound.

## Interactions Developed
The RIT AR Campus Tour utilizes touch interactions that allow the user to toggle between seeing more or less information at a specific location. Using the Android GPS hardware and the hardcoded longitude and latitude values of RIT buildings and landmarks, the user is shown building and landmark information based on their current location.

## User-Interface Elements
As stated, the RIT AR Campus Tour uses touch interactions which includes use of the Canvas’ button component. The Canvas resolution is set to scale with the device’s respective screen size and elements are anchored to specific positions to ensure a cohesive and responsive design. The application uses portrait mode, therefore, the UI is more minimalistic to avoid clutter while still providing the necessary, useful information to the user.

The application implements non-diegetic and spatial UI. The non-diegetic UI can be seen in things like the menu, about, and credit screens. Furthermore, the non-diegetic UI can be seen in the "see more" and "see less" and “close” buttons seen in the location information blurbs. The spatial UI exists in the AR 3D tiger which appears on the ground plane for the user to follow.

## How We Approached Designing an AR Experience
During our brainstorming session, we tried to think of applications which would be based in the real world and use AR to add more to the world, rather than override it. We also wanted to make an application that was independent of extra tactlie objects that would be required. For example, we did not want to create a card game which would recognize the card and add a model to it because then in addition to the phone with the AR experience, cards and the handling of these cards would be required.  

We decided to create an app which would allow the user to go on a tour of the RIT campus. We felt that this application provided something useful to the user as well as had a solid base in the real world.  

When thinking of how to use AR in a tour-like setting, we had several ideas. Our first was to use the ARCore cloud targets to place targets in specified locations. This would add more of an AR feel to the app, and allow us to place objects with significance to the area. For example, we might be able to place people of importance next to the buildings that are dedicated to them, or show major events which took place at the location. However, as this is a touring application, the objects would have to be placed so that the user would be sure to encounter them. 

We instead decided to use a pop-up canvas to display information on buildings. This would ensure that the user would see the information and did not have to go hunting around to find objects they weren't certain existed. For the AR aspect, we added a "tour guide" or compass to guide the user to the next location in the tour. While this implementation decreases the AR interaction, it provides a better or more consistent user experience. If we were to be making this application for a building or museum, where the area covered by the user is less, it would be preferrable to use pre-placed AR objects or use image recognition. 

## Work Developed by Each Member

### Matthew Castronova 
- Created the path
- Created material for image recognition objects

### Corinne Green  
- Designed and created all scenes
- Did all work on canvases
- Worked to get the tiger to follow the player and animate

### Rebecca Medina  
- Setting up prefabs in the Unity Scene
- Getting images and blurbs for the treasure hunt
- Wrote the questions to be used for the treasure hunt 
- Wrote the collision detection script and started the path finding script
- Got most GPS locations to be used by building boundary and building selection

### Alex Pasieka  
- Wrote the Directory Scene for selecting specific buildings
- Created image recognition targets
- Put image recognition targets and objects in Unity

### Thomas Ryszkiewicz  
- Added sound
- Worked on compass and GPS
- Worked on getting the compass to point in the correct direction
- Testing/Debugging

## Evaluation of Final Project
### Pros
- A pro of our team is that we were very adaptive to challenges. We did not dwell on failures or setbacks, but thought of new solutions and different features we would be able to implement.
- Our app is aimed for both kids and adults. The information we present might be more interesting to older audiences, but with the treasure hunt we appeal to kids as well. For different events, the treasure hunt can be used with prizes aimed toward the specific audience. 
- While one might say a drawback of our project is that the QR images need to be posted for people to find, even if the images are not up, the user can walk through campus and learn information about buildings through the GPS implementation. This allows for some customization of the experience. If a user does not want to search for the QR images, they do not need to in order to benifit from our application.

### Cons
- Sound is more of an add-on than an enhancment to the experience. 
- We frequently changed our goal and the technologies we were using as problems came up. This made it difficult to develop for. It also made it hard to keep track of the actual work people did as a lot of features had to get cut due to other aspects not working.

### Lessons Learned
 - Even if something seems like it might work, unless you have it completely working, it might fail
 - Having backups is important
 - We learned a lot about the RIT campus
 - When using both GitHub and Google Drive, things can get a bit confusing. However, GitHub is good for code and Drive is good for larger or more collaborative files like images.

### What we would do differently
- Research more thoroughly all of the technologies and uses of technologies we will be using
- When researching, make quick small prototypes testing the technology to be used for each feature
- At the start of the project we were very good about keeping track of issues and milestones in GitHub, but at the end of the project we weren't as meticulous. If continuing, we would do a better job of this and have more descriptive issues so we wouldn't have two people working on the same problem. 

## Tech Stack
- Unity 2018.3.7
- Vuforia

## Citations
- Tiger Asset: https://assetstore.unity.com/packages/3d/characters/animals/golden-tiger-55797
- RIT Images: https://commons.wikimedia.org/wiki/Category:Buildings_of_the_Rochester_Institute_of_Technology



