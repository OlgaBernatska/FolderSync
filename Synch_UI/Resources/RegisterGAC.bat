@Echo OFF
cd "C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools"
gacutil /i "C:\Users\serhiyb\Downloads\FolderSync-master\FolderSync-master\Synch_UI\Resources\Microsoft.Synchronization.dll"
gacutil /i "C:\Users\serhiyb\Downloads\FolderSync-master\FolderSync-master\Synch_UI\Resources\Microsoft.Synchronization.Files.dll"
Pause&Exit