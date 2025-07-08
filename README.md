# 🎯 Switch Master (Command Pattern)

This game is a simple switch base project where each switch triggers a light. all the execution is stored and used to perform **Undo, Redo and Replay**.

---
## Gameplay

https://github.com/user-attachments/assets/e63c3f26-7366-4d3b-a8bb-442a70abf064

---
## 🧠 What I Learned

- ✅ Practical implementation of the **Command Pattern** in a game setting.
- ✅ How to design and use the **5 core components** of the Command Pattern:
  - **Abstract Command**
  - **Concrete Command**
  - **Command Invoker**
  - **Client**
  - **Receiver**
- ✅ How to **store, undo, redo**, and **replay** player actions using a **command history system**.
- ✅ The difference between **true command-based replay**.
- ✅ Better understanding of **modular input handling** and **action control** in strategy games.

---

## 🕹️ Gameplay Overview

- 🎮 Player can switch on lights by clicking on switches corresponding to them.
- ↩️ Player can **undo** their previous moves.
- ↩️ Player can **redo** their moves after a undo.
- 🔁 At any time, the player can **replay the entire match** — every move re-executed step-by-step.
- 🧠 All actions are recorded as **commands**, not animations, for perfect replays.

---

## ⚙️ Features

- ✅ **Command Pattern Architecture**:
  - Modular, extensible, and clean structure.
- ✅ **Undo System**:
  - Reverts the most recent action using the stored command.
- ✅ **Redo System**:
  - Re-executes a previously undone command using the stored command history.
- ✅ **Replay System**:
  - Re-executes every command in sequence with proper delay.
- ✅ **Command History Stack**:
  - Maintains order and integrity of all issued commands.
- ✅ **Separation of Concerns**:
  - Decouples input, action execution, and game state updates.


---

## 💡 How It Works

### 🔑 Command Pattern Flow

1. **Client**: Issues a command (e.g., move or attack).
2. **Command Invoker**: Executes the command and stores it in history.
3. **Receiver**: Performs the actual logic (e.g., moving a unit).
4. **Command History**: Stores commands for undo/replay.
5. **Replay System**: Iterates over the command history and replays them one-by-one.

---

## 🛠️ Tech Stack

- **Unity Engine**
- **C#**
- **Command Design Pattern**
- **Stack-based History System**

---

## 📚 Key Takeaways

- Learned how the **Command Pattern** enables flexible and reversible action control.
- Built a **replay system** without video — through pure re-execution of logic.
- Modular system design that can easily scale with more unit actions or AI scripting.
