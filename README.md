# CoreHole
CoreHole will be a 3D Unity game about mining. You will gradually excavate down deeper and deeper, using real-world methodologies to prevent your pit from collapsing in on yourself while using the minerals you excavate to fund your journey down to the core of the planet. 


Planned features include:

Over 20 unique types of rock and soil to dig through

Over 15 unique minerals to mine up and sell

Mineral veins of different concentrations


Structure details:
Base Unity Engine requirements result in the structure of the first layers of the repository. The Assets folder inside of the repository contains all of the structure that developers have control over. Materials in the Materials folder will control the visual appearance of objects inside of the game, while meshes from the Meshes folder will control the shape of the objects. Prefabs are used to create copies of specific objects with specific behaviors and will be stored in the Prefabs folder, with subfolders being made according to need, such as the Popups folder that is already present. Scenes are where the objects inside of the game are placed and will be able to act, and are stored in the Scenes folder. Scriptable Objects are objects that have behaviors specified by scripts, of which there are various types, which will all be stored in the ScriptableObjects folder. The most common type of Scriptable Object, the EventChannel, will have its own folder inside of this folder, as well as folders for each unique type of event channel that is created. The Scripts folder will contain all of the code for this project, and will also be subdivided. The subdivisions in this will be the Interfaces, Monobehaviors, ScriptableObjects, and Structs folders. The Interfaces folder will contain all of the interfaces that are created for this project. It may be further subdivided depending on how many interfaces get created. The Monobehaviors is similar, as it will contain all Monobehaviors that do not fit any of the other folders in the Scripts folder, and will be further subdivided into categories once those categories become apparent. One of these that has been preemptively created is the Popups folder, which will define behavior for various types of popups, such as confirmation popups or simple message popups. The ScriptableObjects folder inside of the Scripts folder will be where the behaviors for the various types of scriptable objects are defined. As such it also has the EventChannels folder, though it will not have subdivided folders for the different types of event channel as they only need their behavior defined once. The structs folder will contain the various structs that are needed to enable variables to be set in the Unity Editor windows, as it is not compatible with some types otherwise. The last folder in the Assets folder, the Settings folder, contains various assets that affect the functionality of the editor itself.
