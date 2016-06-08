## Microsoft Remote Wiring

### Firmata
The Firmata implementation in Microsoft Remote Wiring is taken directly from the official code with
some minor changes. More importantly, the team wrapped it in a WinRT component and pushed many of
the actions to background thread (you will need to marshal back to the UI thread, of course).

It's easy to incorporate the Firmata layer into the solution.

_**DEMO 5: Explore the Firmata protocol layer**_

We aren't going to use the UwpFirmata object directly, so

1. Continue your solution or open a [Starter solution](https://github.com/JAgostoni/pgh-dot-net-remote-wiring/tree/wip/Demo4/Starter/)
2. Open the MainPage.xaml.cs file
3. Create a new variable of type UwpFirmata
4. Use IntelliSense to explore some of the methods

Firmata will tell us ...

- PinCapabilityResponseReceived - What your board can do...
- DigitalPortValueUpdated - When a digital output port has changed ...
- AnaglogValueUpdated - When an analog reading has changed ...
- ... send a varity of commands to the board ...

**That was easy! Next!**

### [NEXT: Remote Wiring >>](msiotwiring_4.md)

[TOP](README.md)