# TreasurySettingsEditor

A portable Windows Forms application for managing FFXI Treasury addon settings.

## Features
- Add, edit, and delete character and item settings in `settings.xml` via a user-friendly UI
- Supports Drop, Pass, and Lot lists for each character or global
- Resizable window, grouped controls, and clear section titles

## How to Build
1. Open `Treasury.sln` in Visual Studio
2. Build the solution (Debug or Release)
3. The EXE and required DLLs will be in `data/TreasurySettingsEditor/bin/Release/net6.0-windows/`

## How to Release
- Copy all files from the build output folder to your `Treasury/data/` folder
- Do **not** include `settings.xml` if you want users to provide their own
- Zip and distribute the folder

## How to Use
- Unzip and place the EXE and DLLs in your `Treasury/data/` folder
- Run `TreasurySettingsEditor.exe`
- Edit your settings as needed

## Development
- Source code is in `data/TreasurySettingsEditor/`
- Contributions welcome!

## License
MIT or your preferred license
