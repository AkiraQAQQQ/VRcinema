# VR Cinema
VR cinema
"What?":
  This project is a VR cinema simulation. It aims at simulating the offline video consuming process.

Design Considerations:
  This project is focusing on create a personal usable VR cinema app. By meaning usable, the users should be able to choose who they want to consume the content with and what they are looking at. Also, the scene should be editable by the user to serve for various means except for watching movie, for example, it can also act as an online band house, party, and conference room.

Overall Solution:
  1. The application is created by unity.
  2. instead of using human-like averter like Oculus Big Screen did, we are using prebuilt averters to decrease the effect of uncanny valley phenomenon. 
  3. An eye tracking sensor technology was researched so that the eye tracking data could be deployed to make the facial expression of the averter more vivid. 
  4. the movement of hands are canceled. Instead, an emoji panel was created to help the users share their emotions. the more usable design of the emoji panel is designed so that it could be applied in the future.
  5. An online interaction system is designed to enable the users using this app both with LAN and WAN. (Not deployed)  
    
"Why?":
  This project is initiated because current available VR applications are not spreading widely, and this should be with reasons. The group members suggested that one of the reasons is that the averters in available applications  are not vivid enough to create an immersive feeling during usage. In this case, the cinema scene was chosen to be the experimental usage of this project since it is one of the most common usages for personal users. After researching on Oculus Big Screen, the official cinema application released by oculus, some of the disadvantages of Oculus Big screen were found. By revising base on the core experience provided by Oculus Big screen, this project might be helping with spreading VR technology by expanding personal ability over online media consumption.

Implementation Considerations:
  1. Although the network system is a essential part of this project, we did not have enough time for it to be deployed, hopefully it can be done in the future.
  2. the turnning is now set to 45 degree per turn, it can be programmed to stepless changing.
  3. destroyable scene is designed in the initial design to make it possible for serving different use. However, it takes longer to go through and understand Oculus developer manual, so this stage is not reached.
  4. the implementation of eye tracking need both parts and mechinal engineering knowledge which are not available currently.\
  5. the implementation of action tracking technology will be a direction, but the space problem need to be solved.

Work devision:
  All the group members participate in the initial design of the project, including brainstorming, direction confirmation, and research on assigned parts.
  Zhe Yang:
    Responsible for 3D modeling, scene building, schedule checking, in-group communication conductor.
  Zhenyu Zhang:
    Responsible for network system coding and testing.
  Dejun Liu:
    Final presentation, material organization, and production test.
