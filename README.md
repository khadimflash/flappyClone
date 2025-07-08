<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity-3c77fa?style=for-the-badge&logo=unity" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/Platform-PC-2dba4e?style=for-the-badge" />
</p>

# FlappyClone

A Unity project that recreates the classic Flappy Bird gameplay using C#. This repository is organized according to Unity’s standards and includes all main assets, scripts, settings, and package dependencies necessary to run and modify the game.

---

## 🚀 Features

- Faithful clone of the original Flappy Bird mechanics
- Built with Unity and C# for easy extensibility
- Modular structure: prefabs, scripts, scenes, sprites, and settings
- Unity Input System integration
- Universal Render Pipeline ready

---

## 🧠 Skills Developed

Working on this project allowed me to develop and strengthen the following skills:

- **Unity Game Development:** Setting up projects, scene management, and using Unity Editor tools
- **C# Programming:** Writing, organizing, and debugging efficient and modular game scripts
- **Object-Oriented Design:** Creating reusable components and maintaining clean code architecture
- **Physics Simulation:** Implementing 2D physics for realistic game mechanics and collision detection
- **Prefab Management:** Designing and utilizing prefabs for scalable game objects (like pipes)
- **Sprite & Asset Management:** Organizing and importing sprites and assets for optimal performance
- **Input System Integration:** Configuring and handling user input using Unity’s new Input System
- **UI Design:** Creating simple and responsive UI for score, game over, and instructions
- **Render Pipeline Configuration:** Setting up and customizing Universal Render Pipeline (URP)
- **Version Control:** Managing project files and collaborating with Git and GitHub
- **Package Management:** Adding and updating dependencies via Unity’s Package Manager
- **Project Organization:** Maintaining a clear and scalable project hierarchy

---

## 🗂️ Project Structure

```
.
├── Assets/
│   ├── DefaultVolumeProfile.asset
│   ├── InputSystem_Actions.inputactions
│   ├── Pipe.prefab
│   ├── Sceness/
│   ├── Script/
│   ├── Settings/
│   ├── Sprites/
│   └── UniversalRenderPipelineGlobalSettings.asset
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/
├── UserSettings/
├── .gitignore
├── .vsconfig
├── README.md
```
- **Assets/**: Main game content, including prefabs (e.g. `Pipe.prefab`), input actions, render pipeline settings, and subfolders for scenes, scripts, settings, and sprites.
- **Packages/**: Unity package manifest and lock file for dependency management.
- **ProjectSettings/**: Configuration files for Unity project settings (audio, graphics, input, quality, etc.).
- **UserSettings/**: User-specific preferences and layout info.
- **.gitignore / .vsconfig**: Git and Visual Studio configuration.
- **README.md**: This documentation file.

View full file listing:  
- [Assets/](https://github.com/khadimflash/flappyClone/tree/main/Assets)  
- [Packages/](https://github.com/khadimflash/flappyClone/tree/main/Packages)  
- [ProjectSettings/](https://github.com/khadimflash/flappyClone/tree/main/ProjectSettings)  
- [UserSettings/](https://github.com/khadimflash/flappyClone/tree/main/UserSettings)  

---

## 🛠️ How to Run

1. **Clone the Repository**
   ```bash
   git clone https://github.com/khadimflash/flappyClone.git
   ```

2. **Open in Unity**
   - Recommended Unity version: *(see `ProjectSettings/ProjectVersion.txt` for exact version)*
   - Use the Unity Hub to add and open the project folder.

3. **Play**
   - Open a scene from the `Assets/Sceness/` directory.
   - Press the Play button in Unity Editor.

---

## 📁 Key Directories & Files

- **Assets/Script/**: Contains all C# scripts for game logic.
- **Assets/Sceness/**: Contains Unity scenes for different game states or levels.
- **Assets/Sprites/**: Game art and sprites.
- **Assets/Settings/**: Custom or project-wide settings.
- **Packages/manifest.json**: Describes all required Unity packages, including dependencies like Input System or URP.
- **ProjectSettings/**: Unity’s system and project configuration (audio, graphics, build, etc.).

---

## 🎮 Controls

- Uses Unity's Input System (`Assets/InputSystem_Actions.inputactions`).
- Controls can be customized via Unity’s Input System.

---

## ✨ Customization

- Add or modify scripts in `Assets/Script/`.
- Adjust game assets in `Assets/Sprites/` and prefabs in `Assets/`.
- Change project settings via the Unity Editor or by editing files in `ProjectSettings/`.

---

## 📦 Dependencies

- See `Packages/manifest.json` for a list of required Unity packages.
- Universal Render Pipeline is set via `Assets/UniversalRenderPipelineGlobalSettings.asset`.

---

## 🤝 Contributing

Pull requests are welcome! Please fork this repository and submit any improvements you make.


---

> **Note:**  
> Some directory listings above may be incomplete. Check the [Assets/](https://github.com/khadimflash/flappyClone/tree/main/Assets) folder on GitHub for the full asset list.

---

Made with ❤️ in Unity and C#
