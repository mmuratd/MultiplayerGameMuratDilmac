# Unity Multiplayer Game Project
![image](https://github.com/mmuratd/MultiplayerGameBootcampMuratDilmac/assets/76118329/f2bab002-48fc-40e7-926b-1de3948ec79c)

This Unity project is a multiplayer game that utilizes Netcode for synchronization. It features a variety of gameplay enhancements to create an engaging multiplayer experience.

## Features

- **Character Movement:** Synchronized movement for the main character.
- **Jumping:** Netcode-enabled jumping for the character. Server-side implementation for reliable synchronization.
- **Custom Character Models:** Ability to replace the default character model with a new one, synchronized over the network.
- **Interactive UI:** Unity Canvas with a panel for creating health-reducing objects at specific points in the scene. Includes input fields and buttons for dynamic object creation.
- **Object Generator Class:** Implemented a "Generator" class for automatic creation of health-reducing objects in the game environment.
- **InGameConsole Integration:** Use the InGameConsole from Task 4 to spawn health-reducing objects with prompt commands (e.g., "Spawn DeadlyObject 5").
- **Health Bar:** Added health bars to characters, synchronized over the network. Each character starts with 100 health, and colliding with health-reducing objects deducts 20 health.
- **Animated Health Bar:** Integrated an animation for the health bar using the Microbar Animated Health Bar from the Unity Asset Store.
- **Health Bar Orientation:** Ensured that health bars always face the camera, following guidance from the YouTube tutorial "HealthBar Animation Example."

## Getting Started

Follow the steps in the [Installation](#installation) section to set up and run the project on your machine. Additionally, ensure that you have the required Unity3D and Netcode for GameObjects dependencies installed.

## Usage

- Launch the server executable to start a game server.
- Launch the client executable to connect to the server.
- Experience synchronized multiplayer gameplay with jumping, custom character models, interactive UI, and health bars.

## Contributing

If you would like to contribute to the project, follow the steps outlined in the [Contributing](#contributing) section.

## License

This project is licensed under the [MIT License](LICENSE.md).

## Acknowledgments

- Thank you to the Unity community for the support and resources.
- Special thanks to the creators of Microbar Animated Health Bar and the contributors to the InGameConsole asset.

