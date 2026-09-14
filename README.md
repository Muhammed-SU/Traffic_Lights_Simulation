# 🚦 Traffic Lights Simulation

A simple **4-way traffic light simulation** developed using **C# and Windows Forms**.

The project simulates a crossroads where four traffic lights operate in sequence. Only one traffic light is allowed to open at a time, while the other three remain red.

## ✨ Features

* 🚦 Four independent traffic light controls
* 🔴 Red, 🟠 Yellow, and 🟢 Green states
* ⏱️ Countdown timer for each light
* 🔄 Automatic continuous traffic light sequence
* 🚫 Only one traffic light is green at a time
* 🟠 Yellow transition before the next traffic light becomes green
* 🖥️ Built with Windows Forms
* 🧩 Reusable `ctrlTraficLight` UserControl
* ♾️ Automatic cycle repetition

## 🔄 Traffic Light Sequence

The traffic lights operate continuously in the following order:

```text
TL1 🟢    TL2 🔴    TL3 🔴    TL4 🔴
   ↓
TL1 🟠    TL2 🔴    TL3 🔴    TL4 🔴
   ↓
TL1 🔴    TL2 🟠    TL3 🔴    TL4 🔴
   ↓
TL1 🔴    TL2 🟢    TL3 🔴    TL4 🔴
   ↓
TL1 🔴    TL2 🟠    TL3 🔴    TL4 🔴
   ↓
TL1 🔴    TL2 🔴    TL3 🟠    TL4 🔴
   ↓
TL1 🔴    TL2 🔴    TL3 🟢    TL4 🔴
   ↓
TL1 🔴    TL2 🔴    TL3 🟠    TL4 🔴
   ↓
TL1 🔴    TL2 🔴    TL3 🔴    TL4 🟠
   ↓
TL1 🔴    TL2 🔴    TL3 🔴    TL4 🟢
   ↓
🔄 Repeat
```

## 📷 Screenshots
<img src="./turkce.png" width="100%" />

<img src="./turkce.png" width="100%" />
---

## 🛠️ Technologies

* **C#**
* **.NET Framework**
* **Windows Forms**
* **Visual Studio**

## 📁 Project Structure

```text
Traffic-Lights-Sim/
│
├── Form1.cs
├── Form1.Designer.cs
│
├── ctrlTraficLight.cs
├── ctrlTraficLight.Designer.cs
│
├── Properties/
│   └── Resources.resx
│
└── Traffic-Lights-Sim.sln
```

### `Form1`

Acts as the main controller of the crossroads and manages the sequence of the four traffic lights.

### `ctrlTraficLight`

A reusable Windows Forms `UserControl` responsible for:

* Light state
* Countdown
* Red/Yellow/Green transitions
* Timer management
* Light events

## ⚙️ Default Timing

| Light     |   Duration |
| --------- | ---------: |
| 🔴 Red    | 10 seconds |
| 🟠 Yellow |  3 seconds |
| 🟢 Green  | 10 seconds |

These values can be customized through the `ctrlTraficLight` properties.

## 🚀 Getting Started

1. Clone the repository:

```bash
git clone https://github.com/your-username/Traffic-Lights-Sim.git
```

2. Open the `.sln` file in **Visual Studio**.

3. Build the project.

4. Run the application.

5. The traffic lights will automatically start and continue cycling.

## 🎯 Purpose

This project was created as a practice project for learning:

* C# Windows Forms
* User Controls
* Events and Event Handlers
* Timers
* State management
* Object-oriented programming
* Simulation logic

## 📌 Future Improvements

Possible future features include:

* 🚗 Adding moving cars
* 🚘 Vehicle queues
* 🚶 Pedestrian crossings
* 🚑 Emergency vehicle priority
* 🚦 Traffic sensors
* 📊 Traffic density simulation
* 🎛️ Configurable traffic light durations
* 🔊 Traffic and pedestrian sounds
