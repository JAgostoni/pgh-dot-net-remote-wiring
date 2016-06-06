# Pittsburgh .NET User Group - Remote Wiring, Arduinos and More
Learn how to connect to and control your Arduino using Microsoft's Remote Wiring API. We will connect a Universal Windows Application (UWP) 
to a microcontroller (Arduino UNO) to react to tapping some wired-up hardware buttons. After, we'll continue the journey by sending these button
presses up as telemtry events to an Azure IoT hub ... and then back again as a Microsoft Band WebTile

## Getting Started

###Some things we'll need:

- Arduino compatible micro-controller ([here's mine](http://www.amazon.com/dp/B00E5WJSHK/ref=cm_sw_r_tw_dp_H8lvxb1224T12))
- Arduino IDE (to install Standard Firmata)
 - [Download](https://www.arduino.cc/en/Main/Software) it from Arduino.cc
 - I used Choclatey.org (choco install arduino)
- Visual Studio 2015
- CLONE this repo (I use submodules so a .ZIP download isn't going to cut it ;) )
- You should probably go ahead and learn Ohm's law:

    _Twinkle, twinkle little start V is equal to IR (V=IR), up above the sky so high, P is equal to VI (P=VI)_
    
    _Add resistors in series: R = R1 + R2 + R3_
    
    _Inversely add them in parallel: 1/R = 1/R1 + 1/R2 + 1/R3_

- Let the resistor take the hit for you:

![Sorry!  I couldn't resist](assets/resist.jpg)

**These won't be needed at the user group meeting but they are here for your reference!**

---

### What's an Arduino?

- An open source hardware specification
- A prototyping platform
- Damn cheap! (like $5 cheap.  $12 for a more spacious version. $25 version supports Arduino)
- Crazy easy to program (AVR-C is way simple, we'll use C#)\
- Or program one graphically with ArduBlock and ModKit (and other Blockly GDEs)

_**Demo 1 - Blinky!**_  - [Code Here](Demo 1 - Simple Arduino)

1. Wire up your Arudino similar to the diagram above
2. Open the Arduino IDE, start a new sketch
3. In the setup() method, set the pinMode to OUTPUT
4. In the loop() method, alternate the state of the pin with delays

Does it look like this?

![Should look like this](assets/flashy.png)

---

### What's StandardFirmata?
Standardized protocol for communicating with microcontrollers from more general purpose computers (like your PC, Mac, RaspberryPi).

- Based on the MIDI format (really? cool!)
- Client libraries available in just about every language
- Easily uploaded to your arduino

_**DEMO: Uploading Standard Firmata**_

1. Connect your board
2. Open the Arduino IDE
3. Ensure youre board and port are selected (Tools->Board, Tools->Port)
4. Open the StandardFirmata sketch (File->Examples->Firmata->StandardFirmata)
5. Upload. Done.

**Now we can get started with C#!** 

---

## Microsoft Remote Wiring
...


## Button Band IoT End-to-End
...

![My God! It's Full of Submodules](assets/submodules.jpg)
---

## BIO - Jason Agostoni
Jason Agostoni has over 18 years of experience in software development, architecture, design, and several years of experience in project management. He has had the opportunity to work in nearly every industry and knowledge domain from healthcare to professional sports teams.  Jason helps companies and teams envision, design and construct end-to-end solutions for any size need.  He has been responsible for small mobile applications all the way up to massive scale integration solutions processing 5+ million transactions daily. In addition to software development experience, Jason has spent time developing content for and performing mentoring including mobile development, Azure and cloud services, BizTalk, Team Foundation Server (TFS), software architecture and general .NET.

{ [BLOG](http://jason.agostoni.net) } | { [Twitter](http://twitter.com/JAgostoni) } | { [LinkedIn](https://www.linkedin.com/in/jagostoni) }