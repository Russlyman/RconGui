# RconGui
<p>
  <a href="https://github.com/Russlyman/RconGui/releases/latest" alt="Release">
    <img src="https://img.shields.io/github/v/release/Russlyman/RconGui" /></a>
  <a href="https://github.com/Russlyman/RconGui/blob/main/LICENSE" alt="License">
    <img src="https://img.shields.io/github/license/Russlyman/RconGui" /></a>
</p>

RconGui is a graphical interface for interacting with game servers that implement the Quake III Arena RCon protocol.

While RconGui should support all implementations of the Quake III RCon protocol, the underlying .NET library I created to address the RCon client has only been tested with FiveM. Feel free to raise an issue if you experience any problems.

## Download

**For Windows x64 only!**

- Download the ZIP file from the assets section in the [latest release](https://github.com/Russlyman/RconGui/releases/latest)
- Extract ZIP into folder
- Run RconGui.exe
## Build Yourself
**You must install .NET 6 to build this project!**

- Download and extract the latest [source code](https://github.com/Russlyman/RconGui/archive/refs/heads/main.zip)
- Navigate to the folder that contains `README.MD`
- Run the command `dotnet publish RconGui -c Release -o publish -r win-x64 -p:PublishSingleFile=true -p:PublishReadyToRun=true --self-contained`
- See the `publish` folder which contains the freshly built binary
## License

This project is licensed under MIT which can be viewed from the `LICENSE` file.

This project utilises third party libraries which have been licensed under their own respective licenses and can be viewed from the `THIRDPARTYLEGALNOTICES` file.
