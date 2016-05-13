Authors and Developers:
Olga Bernatska and Sergii Bortnyk
________________________________________________
1. Download Microsoft Synchronization Framework
https://www.microsoft.com/en-us/download/details.aspx?id=23217
OR
Copy SyncSDK-v2.1-x64-ENU.msi from \\FolderSync-master\Synch_UI\Resources

2. Install it - SyncSDK-v2.1-x64-ENU.msi

3. Register Microsoft.Synchronization.dll and Microsoft.Synchronization.Files.dll dlls in GAC
Command: gacutil -i <assembly name>
OR
Run RegisterGAC.bat from \\FolderSync-master\Synch_UI\Resources

4. Run build on x64 Solution Platform
__________________________________________
Next version will include:
- Progress bar and messages about Synch State
- Path validation
- Backup folders for rewritten/deleted files
- UI improvements