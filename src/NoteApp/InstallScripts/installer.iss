#define URL "https://github.com/CyberAndrey77/NoteApp"
#define ExeName "NoteAppUI.exe"
#define Name "NoteApp"
#define Version "0.0.1"

[Setup]
AppId={{59F628AE-79AD-4A60-8757-84560EB97CA8}
AppName={#Name}
AppVersion={#Version}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}
DefaultDirName={pf}\{#Name}
DefaultGroupName={#Name}
DisableProgramGroupPage=yes
OutputBaseFilename=NoteAppSetup
SetupIconFile="..\..\icon.ico"
UninstallDisplayName=uninslall
OutputDir = "Installers"      
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\NoteAppUI.exe"; DestDir: "{app}"
Source: "Release\*.dll"; DestDir: "{app}"
Source: "..\..\icon.ico"; DestDir: "{app}"

[Icons]
Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"; WorkingDir: "{app}"; IconFilename: {app}\icon.ico
Name: "{group}\uninslall"; Filename: "{uninstallexe}"; IconFilename: {app}\icon.ico
Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon; IconFilename: {app}\icon.ico