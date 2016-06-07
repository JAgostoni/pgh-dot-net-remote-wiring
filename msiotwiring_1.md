## Microsoft Remote Wiring

### Basics / Getting Started

Microsoft's Remote Wiring framework is an open source C++, windows universal library (winmd) available through NuGet or GitHub.

You can snag it a couple ways:

1. Add it using NuGet to your Universal Windows App
   - Search for package name: windows-remote-arduino
2. Clone the official repo
   - https://github.com/ms-iot/remote-wiring
3. Clone my patched repo
   - https://github.com/JAgostoni/remote-wiring

If using the repo above, adding it in as a git submodule tracks the remote repository along side your project repo.
    
    git submodule add https://github.com/JAgostoni/remote-wiring

This will clone the repo into a folder called remote-wiring.

### [NEXT: Serial Wiring >>](msiotwiring_2.md)

[TOP](README.md)