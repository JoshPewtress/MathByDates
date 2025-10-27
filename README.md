# MathByDates
A skill check program for C# Fundamentals. Dealing with parsing dates entered by the user into DateOnly objects and comparing them against a stated number of days.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Logic Breakdown / Tasks](#logic-breakdown--tasks)
- [Code Structure](#code-structure)

## Overview
This project demonstrates the ability to work with:
- Verifying and obtaining user input
- Parsing Date objects from strings
- Extracting int's from Date object comparisons
- Loops and Conditionals

## Features
- Generates a random target number.
- Prompts user for two strings.
- Parses the strings into DateOnly objects.
- Compares dates to today's date to get number of days between.
- Adds the guessed number of days together.
- Compares summed days against the target number of days.
- If the guessed days are within 5 of the target, a victory condition is met.

## Logic Breakdown / Tasks
- [x] Store random number.
- [x] Read user input.
- [x] Parse input to DateOnly objects.
- [x] Subtract guess from today's date.
- [x] Compare summed dates to random number.

## Code Structure
- `Program.cs` - Entry point.
- `Helper.cs` - Static class containing:
    - `RunProgram()` - Conductor method to call private methods and run game.
    - `GetUserInput()` - Prompt user for input.
    - `ParseInputToDateOnly()` - Validates input for valid strings, converting to DateOnly if valid, else calls `GetUserInput()` until input is valid.
    - `SumTotalDays()` - Compares guessed days to today's date to get number of days between, sums the total for the two guesses.
    - `DetermineResult()` - Prints win/loss messages.
