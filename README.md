# Computer System Simulation

Console application written in C# demonstrating the use of interfaces and indexers.

## Description

The project simulates a simple computer system consisting of devices connected to a system unit.

Implemented devices:
- Monitor
- Mouse

Each device supports:
- driver installation
- device testing

The project demonstrates:
- object-oriented programming
- interfaces
- indexers
- encapsulation

---

## Features

- Interface implementation (`IDevice`)
- Polymorphism
- Custom indexer in the `Computer` class
- Device management
- Driver installation simulation
- Device testing simulation

---

## Technologies

- C#
- .NET Console Application

---

## Classes

### IDevice

Interface that defines common behavior for all devices.

Methods:
- `InstallDriver()`
- `TestDevice()`
- `GetInfo()`

---

### Monitor

Represents a monitor device.

---

### Mouse

Represents a mouse device.

---

### Computer

Stores connected devices and provides access to them using an indexer.

Example:

```csharp id="m4t8w2"
computer[0]
computer[1]
