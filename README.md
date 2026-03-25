#  Dice Guessing Game

##  Overview

This is a simple dice guessing game.

The player chooses a number from 1 to 6.
The system generates a random dice result.
If the player's guess is correct → Win
If not → Lose

The system also tracks:

* Number of plays
* Number of wins
* Number of losses

---

##  Actor

* Player

---

## Use Case: Play Game

### Description

Player plays the dice guessing game.

### Steps

1. Player selects a number (1–6)
2. Player clicks "Play"
3. System generates a random number
4. System compares result with player's choice
5. System displays result (Win/Lose)
6. System updates statistics

---

## Functional Requirements

* System must allow user to choose a number from 1 to 6
* System must generate a random result
* System must compare result with user's choice
* System must display win or lose message
* System must track play count, win count, and lose count

---

## Non-Functional Requirements

* UI must be simple and easy to use
* System response time should be fast (<1 second)
* Random result must be fair

---

## Activity Diagram

Start
→ Choose number
→ Click Play
→ Generate random number
→ Compare result
→ Show Win/Lose
→ Update statistics
→ End

---

##  Technologies Used

* C# WinForms
* .NET Framework

---

## Author

* Minh Vy
  
