; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{72BD0FEE-55E8-4617-8DB8-08BDC76CEA48}
AppName=������ �������
AppVersion=1.5
;AppVerName=������ ������� 1.5
AppPublisher=ISUCT, Inc.
AppPublisherURL=http://isuct.ru/
AppSupportURL=http://isuct.ru/
AppUpdatesURL=http://isuct.ru/
DefaultDirName=C:\ISUCT\������ �������
DefaultGroupName=������ �������
AllowNoIcons=yes
InfoBeforeFile=C:\Users\������\Dropbox\calculation-of-profit\CalculationOfProfit\bin\Release\Resources\help.txt
OutputDir=C:\Users\������\Dropbox\calculation-of-profit
OutputBaseFilename=calculation_of_profit
SetupIconFile=C:\Users\������\Dropbox\calculation-of-profit\CalculationOfProfit\bin\Release\Resources\icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\������\Dropbox\calculation-of-profit\CalculationOfProfit\bin\Release\CalculationOfProfit.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\������\Dropbox\calculation-of-profit\CalculationOfProfit\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\������ �������"; Filename: "{app}\CalculationOfProfit.exe"
Name: "{commondesktop}\������ �������"; Filename: "{app}\CalculationOfProfit.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\CalculationOfProfit.exe"; Description: "{cm:LaunchProgram,������ �������}"; Flags: nowait postinstall skipifsilent

