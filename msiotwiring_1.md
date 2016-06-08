## Microsoft Remote Wiring

### Basics / Getting Started

Microsoft's Remote Wiring framework is an open source C++, Windows Runtime Component (winmd) available through NuGet or GitHub. The framework allows you to interact with a microcontroller over a serial (USB, Bluetooth, Network) connection.

You can snag it a couple ways:

1. Add it using NuGet to your Universal Windows App
   - Search for package name: windows-remote-arduino
2. Clone the official repo
   - https://github.com/ms-iot/remote-wiring
3. Clone my patched repo
   - https://github.com/JAgostoni/remote-wiring

If using the repo above, adding it in as a git submodule tracks the remote repository along side your project repo.
Of course, that repository also uses a submodule.  And this repository ....

![My God! It's Full of Submodules](assets/submodules.jpg)
    
    git submodule add https://github.com/JAgostoni/remote-wiring
    git submodule update --init --recursive

This will clone the repo into a folder called remote-wiring.

_**DEMO 3: Starting a Remote Wiring Project**_

Create a new UWP project, pull in the Remote Wiring code.

Do this:

1. Launch Visual Studio 2015
2. Create a new Blank Windows Universal App
   - Or ... just use the [Starter solution](https://github.com/JAgostoni/pgh-dot-net-remote-wiring/tree/wip/Demo3/Starter/RemoteWiringDemo)
3. Open the Package Manager Console
4. Using NuGet Package?
  - Install-Package windows-remote-arduino
5. Pulling in the submodule?
   - git submodule add https://github.com/JAgostoni/remote-wiring
   - git submodule update --init --recursive
   - Include project from remote-wiring\Microsoft.Maker.win10\Microsoft.Maker.RemoteWiring
   - ... and remote-wiring\Microsoft.Maker.win10\Microsoft.Maker.Firmata
   - ... and remote-wiring\source\Serial\Microsoft.Maker.Serial.win10
   - Add references to the three newly added projects to the UWP project
6. Build. Hope. Success?
  - Oh yeah ... forgot to tell you to pick an architecture like x64 ... C++, amirite?

Completed solution [HERE](https://github.com/JAgostoni/pgh-dot-net-remote-wiring/tree/wip/Demo3/Complete/)

### The Three Libraries
There are three libraries which come with Remote Wiring...
- Serial-Wiring: Sets up a data stream with your Arduino
- Firmata: Layer on top of Serial-Wiring implementing the Firmata protocol
- Remote-Wiring: A easier to digest API against Firmata

You can use then in succeeding levels of abstraction.

### [NEXT: Serial Wiring >>](msiotwiring_2.md)

[TOP](README.md)
