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

    _ Twinkle, twinkle little start V is equal to IR (V=IR), up above the sky so high, P is equal to VI (P=VI)_
    
    _ Add resistors in series: R = R1 + R2 + R3 _
    
    _ Inversely add them in parallel: 1/R = 1/R1 + 1/R2 + 1/R3 _
- Let the resistor take the hit for you:

![Sorry!  I couldn't resist](assets/resist.jpg)

** These won't be needed at the user group meeting but they are here for your reference! **

### What's an Arduino?
- An open source hardware specification
- A prototyping platform
- Damn cheap! (like $5 cheap.  $12 for a more spacious version. $25 version supports Arduino)
- Crazy easy to program (AVR-C is way simple, we'll use C#)

TBD - SIMPLE DEMO OF ARDUINO IDE AND AVR-C


## BIO - Jason Agostoni
Jason Agostoni has over 18 years of experience in software development, architecture, design, and several years of experience in project management. He has had the opportunity to work in nearly every industry and knowledge domain from healthcare to professional sports teams.  Jason helps companies and teams envision, design and construct end-to-end solutions for any size need.  He has been responsible for small mobile applications all the way up to massive scale integration solutions processing 5+ million transactions daily. In addition to software development experience, Jason has spent time developing content for and performing mentoring including mobile development, Azure and cloud services, BizTalk, Team Foundation Server (TFS), software architecture and general .NET.

{ [BLOG](http://jason.agostoni.net) } | { [Twitter](http://twitter.com/JAgostoni) } | { [LinkedIn](https://www.linkedin.com/in/jagostoni) }