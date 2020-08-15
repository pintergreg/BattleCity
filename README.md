# BattleCity

2D game stub rendered completely by AvaloniaUI

Port of https://github.com/kekekeks/Avalonia.BattleCity to Avalonia 0.9.12 (and .NET Core 3.0) which is a port of https://github.com/hacklex/PekaCity to Avalonia by [@kekekeks](https://github.com/kekekeks).

- Using ReactiveUI instead of PropertyChangedBase

![Demo](.github/demo.gif?raw=true "Demo")

## What is this? Why?

Well, this is a stub for a 2D game. The purpose of the project was to demonstrate that one can write a 2D game in AvaloniaUI without writing any rendering code.
## Features

- 2D Tiles. Not yet animated, but animating won't be a problem, I guess
- Cell-aligned game objects
- No rendering code, everything is done using AvaloniaUI data binding and a few ValueConverters
