

🟦 Falling Blocks

A fast paced 2D survival game built in Unity where the player dodges falling blocks that increase in difficulty over time.

⸻

🎮 Game Overview

Falling Blocks is a minimal arcade survival game.

You control a player object that can move horizontally across the screen. Blocks fall from the top at random positions, sizes, speeds, and rotations. The longer you survive, the harder the game becomes.

Your objective is simple:

Survive as long as possible.


⸻

🕹 Controls

Key	Action
A / Left Arrow	Move Left
D / Right Arrow	Move Right
Space	(Restart after Game Over)

The player wraps around screen boundaries.
If you exit from the left side, you reappear on the right, and vice versa.

⸻

⚙ Core Systems Implemented

1️⃣ Player Movement
	•	Horizontal movement using Unity Input System
	•	Movement normalized to prevent diagonal speed boosts
	•	Frame rate independent movement using Time.deltaTime
	•	Screen wrap using calculated camera boundary

⸻

2️⃣ Falling Block Spawner
	•	Random spawn interval using Mathf.Lerp
	•	Spawn time decreases as difficulty increases
	•	Random:
	•	Spawn position
	•	Block size
	•	Rotation angle
	•	Spawn above camera view for natural falling effect

⸻

3️⃣ Dynamic Difficulty System

A fully custom difficulty progression system.
	•	Difficulty increases linearly over 60 seconds
	•	Difficulty value ranges from 0 to 1
	•	Used to scale:
	•	Spawn frequency
	•	Falling speed

Mathf.Lerp(min, max, Difficulty.getDifficultyPercentage())

Difficulty resets on game restart.

⸻

4️⃣ Block Physics
	•	Blocks fall using transform.Translate
	•	Speed scales with difficulty
	•	Blocks destroy themselves when off screen

⸻

5️⃣ Collision Detection
	•	2D Trigger Colliders
	•	On collision:
	•	Player is destroyed
	•	Game Over event triggered

⸻

6️⃣ Game Over System
	•	Event driven using C# Action
	•	Displays:
	•	Game Over UI
	•	Seconds survived
	•	Stops gameplay
	•	Allows restart via Space key
	•	Resets:
	•	Difficulty
	•	Time scale
	•	Scene

⸻

🧠 Concepts Practiced

This project focuses on mastering Unity fundamentals:
	•	MonoBehaviour lifecycle (Start, Update)
	•	Camera calculations
	•	Aspect ratio handling
	•	Orthographic camera math
	•	Time management (Time.time, Time.deltaTime, Time.timeSinceLevelLoad)
	•	Scene reloading
	•	Static systems
	•	Event based architecture
	•	Procedural spawning
	•	Boundary calculations
	•	Screen space to world space logic
	•	Randomization
	•	Basic UI with TextMeshPro
	•	Git version control

⸻

🖥 Technical Details

Engine: Unity
Render Pipeline: Universal Render Pipeline
Input System: Unity Input System
Language: C#
Platform Built For: macOS

⸻

📈 Difficulty Formula

Difficulty percentage:

(Time.time - gameStartTime) / secondsToMaxDifficulty

Clamped between 0 and 1.

⸻

🎨 Design Philosophy

Minimal.
Responsive.
Skill based.

No power ups.
No score multipliers.
Just survival.

⸻

🚀 Future Improvements
	•	Score leaderboard
	•	Sound effects
	•	Particle effects on collision
	•	Increasing spawn lanes
	•	Power ups
	•	Mobile touch support
	•	Menu system
	•	Pause system
	•	Difficulty curves instead of linear scaling

⸻

📦 Project Structure

Assets/
 ├── Scripts/
 │    ├── Movement.cs
 │    ├── FallingDown.cs
 │    ├── BlocksD.cs
 │    ├── Difficulty.cs
 │    └── GameOver.cs
 ├── Prefab/
 ├── Scenes/
 └── Settings/

Packages/
ProjectSettings/


⸻

👨‍💻 Author

Vansh Srivastava

Built as a Unity fundamentals project to understand core gameplay systems and difficulty scaling.

⸻
