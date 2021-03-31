# Code-401-Lab06-07: Zoo

**Author**: Nathan Hall
**Version**: 0.1.4 (increment the patch/fix version number up if you make more commits past your first submission)

## Overview
<!-- Provide a high level overview of what this application is and why you are building it, beyond the fact that it's an assignment for a Code Fellows 401 class. (i.e. What's your problem domain?) -->
A zoo application to simulate the required interactions to run a zoo.

## Getting Started
<!-- What are the steps that a user must take in order to build this app on their own machine and get it running? -->
Clone repo and open solution in Microsoft Virtual Studio. Build and run.

Dependancies:
- .NET 5.0
- C#

## Example
<!-- Show them what looks like and how how to use the application.  -->
The application currently can only be tested.

## Architecture
<!-- Provide a detailed description of the application design. What technologies (languages, libraries, etc) you're using, and any other relevant design information. -->
[UML Drawing](Assets/CreateAZoo.png)

Encapsulation is keeping data privately within the Class. This project does not make good utilization of this principal.

Abstraction is taking commonly utilized properties and methods and moving them to a class that is implemented. The abstraction can also be used to ensure a class will have a method you expect. An example of this is the `Feed()` method and the `Gender` property.

Inheritance is a great way to use abstraction as it involves ensuring other classes have expected methods and properties. Refer to abstraction for examples.

Polymorphism allows objects to be unique depending on the context. The concrete Classes such as Ragdoll and Koala are examples.

Interfaces allow the ability to ensure objects have desired functionality.
I implemented it with a has claws for climbing and attacking and a has fur for fur length pattern and color.

## Change Log
<!-- Use this are to document the iterative changes made to your application as each feature is successfully implemented. Use time stamps. Here's an example:

01-01-2001 4:59pm - Added functionality to add and delete some things. -->