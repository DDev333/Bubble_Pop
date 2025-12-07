Here is the updated `README.md`. I have corrected the details to remove particle effects and accurately describe the game flow (instant start upon launch and the restart functionality).

-----

# 🫧 Bubble Pop: 2D Mobile Arcade Game

*(Save your pink vector bubble image as `icon.png` in a `Media` folder)*

**Bubble Pop** is a physics-based 2D mobile game built in Unity. The design focuses on immediate gameplay: the game begins instantly upon launching the app, challenging the player to score as high as possible against a countdown timer.

This project demonstrates core Unity development skills, including **RigidBody2D physics**, **automatic spawning systems**, and **scene management** for game loops.

-----

## 📺 Gameplay Demo

*(Place a recording of your game saved as `gameplay_demo.gif` in the `Media` folder)*

> **Quick Look:** Note the smooth floating animation utilizing `Time.deltaTime`, the automatic spawning of bubbles, and the physics-based movement.

-----

## 🚀 Key Features & Technical Implementation

### 1\. Game Flow & Interaction

  * **Instant Start:** Designed for quick sessions, the game logic and spawner initialize immediately when the application (APK) is opened.
  * **Touch Interaction:** Implemented input detection to allow players to "pop" bubbles by tapping them.
  * **Restart Loop:** Once the timer expires, the **Game Over** UI appears, providing a simple "Restart" button to reload the scene and try again immediately.

### 2\. Physics & Movement

  * **Dynamic Floating System:** Bubbles utilize a custom movement script using `Time.deltaTime` to ensure smooth, frame-rate independent floating.
  * **Unity Physics Engine:** Utilizes **CircleCollider2D** and **Rigidbody2D** components to handle basic collisions and movement logic.

### 3\. Core Systems

  * **Automatic Spawner:** A dedicated script instantiates bubble prefabs at random intervals along the bottom of the screen.
  * **Scoring & Timer:**
      * **Score:** Updates dynamically on the UI whenever a bubble is successfully popped.
      * **Timer:** A countdown system that triggers the Game Over state when it reaches zero.
  * **Audio & Animation:** Includes sound effects for interactions and basic animations to enhance the game feel (without heavy particle systems).

-----

## 📂 Project Structure

The project is organized to keep logic and assets clean:

```text
📦 Unity-Bubble-Pop
 ┣ 📂 Assets
 ┃ ┣ 📂 Audio           # SFX and BGM files
 ┃ ┣ 📂 Prefabs         # Pre-configured Bubble objects
 ┃ ┣ 📂 Scenes          # Gameplay Scene (Main)
 ┃ ┣ 📂 Scripts         # C# Logic (Spawner, BubbleMovement, GameManager)
 ┃ ┗ 📂 Sprites         # Bubble assets and UI elements
 ┣ 📂 Media             # Images for this Readme
 ┗ 📜 README.md
```

-----

## 📸 Screenshots

| Active Gameplay | Game Over & Restart |
| :---: | :---: |
|  |  |
*(Save your screenshots as `screenshot_gameplay.jpg` and `screenshot_gameover.jpg` in the `Media` folder)*

-----

## 🛠️ How to Run

1.  **Clone the Repo:**
    ```bash
    git clone https://github.com/yourusername/unity-bubble-pop.git
    ```
2.  **Open in Unity:**
      * Open Unity Hub and select the project folder.
3.  **Play in Editor:**
      * Navigate to `Assets/Scenes/`.
      * Open the main **Gameplay** scene.
      * Press **Play (▶)**.
4.  **Build to Android (Optional):**
      * Go to **File \> Build Settings**.
      * Switch platform to **Android**.
      * Click **Build and Run** to test the APK on a connected device.

-----

## 🔮 Future Improvements

  * [ ] Add a Main Menu scene for better game flow control.
  * [ ] Add particle effects for a more satisfying "pop" visual.
  * [ ] Implement a High Score system that saves data between sessions.

-----

**Developed by Devesh Ghodpage**
*Built with Unity & C\#*