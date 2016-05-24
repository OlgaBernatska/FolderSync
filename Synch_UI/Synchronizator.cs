using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;
using System.Timers;


namespace Synch_UI
{
    public enum SyncDirectionEnum
    {
        LocalToRemote, BothDirection,  RemoteToLocal // Bug fix - default - one direction, LocalToRemote switched to be first in the list
    }

    public class Synchronizator
    {
        private SyncDirectionEnum syncDirection;
        private string localPath;
        private string remotePath;
        private FileSyncScopeFilter filterForLocalPath = new FileSyncScopeFilter();
        private FileSyncScopeFilter filterForRemotePath = new FileSyncScopeFilter();
        private FileSyncOptions options = FileSyncOptions.None;        

        public string LocalPath
        {
            set { localPath = value; }
        }

        public string RemotePath
        {
            set { remotePath = value; }
        }

        public SyncDirectionEnum SyncDirection
        {
            set { syncDirection = value; }
        }

        public string ExcludeFoldersLocalPath
        {
            set { filterForLocalPath.SubdirectoryExcludes.Add(value); }
        }

        public string ExcludeFilesLocalPath
        {
            set { filterForLocalPath.FileNameExcludes.Add(value); }
        }

        public string IncludeFilesLocalPath
        {
            set { filterForLocalPath.FileNameIncludes.Add(value); }
        }

        public string ExcludeFoldersRemotePath
        {
            set { filterForRemotePath.SubdirectoryExcludes.Add(value); }
        }

        public string ExcludeFilesRemotePath
        {
            set { filterForRemotePath.FileNameExcludes.Add(value); }
        }

        public string IncludeFilesRemotePath
        {
            set { filterForRemotePath.FileNameIncludes.Add(value); }
        }

        public void ClearExcludeFoldersLocalPath()
        {
            filterForLocalPath.SubdirectoryExcludes.Clear();
        }

        public void ClearExcludeFilesLocalPath()
        {
            filterForLocalPath.FileNameExcludes.Clear();
        }

        public void ClearIncludeFilesLocalPath()
        {
            filterForLocalPath.FileNameIncludes.Clear();
        }

        public void ClearExcludeFoldersRemotePath()
        {
            filterForRemotePath.SubdirectoryExcludes.Clear();
        }

        public void ClearExcludeFilesRemotePath()
        {
            filterForRemotePath.FileNameExcludes.Clear();
        }

        public void ClearIncludeFilesRemotePath()
        {
            filterForRemotePath.FileNameIncludes.Clear();
        }

        private SyncDirectionOrder SetDirection(SyncDirectionEnum syncDirection)
        {
            switch (syncDirection)
            {
                case SyncDirectionEnum.BothDirection:
                    {                        
                        return SyncDirectionOrder.UploadAndDownload;
                    }
                case SyncDirectionEnum.LocalToRemote:
                    {
                        return SyncDirectionOrder.Upload;
                    }
                case SyncDirectionEnum.RemoteToLocal:
                    {
                        return SyncDirectionOrder.Download;
                    }
                default:
                    {
                        return SyncDirectionOrder.Upload; // bug fix - in UI the default is one direction, class aligned accordingly
                    }
            }
        }
        

        public void OnceSynch()
        {
            FileSyncProvider localProvider1 = new FileSyncProvider(localPath, filterForLocalPath, options);
            FileSyncProvider remoteProvider2 = new FileSyncProvider(remotePath, filterForRemotePath, options);
            SyncOrchestrator synchOrchestrator = new SyncOrchestrator();
            synchOrchestrator.LocalProvider = localProvider1;
            synchOrchestrator.RemoteProvider = remoteProvider2;
            synchOrchestrator.Direction = SetDirection(syncDirection);
            synchOrchestrator.Synchronize();
        }

        public void ScheduledMinSynchronize(int schedulerPeriodMin)
        {
            int schedulerPeriod = schedulerPeriodMin * 60 * 1000;
            ScedulerTimer(schedulerPeriod);
        }

        public void ScheduledHourSynchronize(int schedulerPeriodHour)
        {
            int schedulerPeriod = schedulerPeriodHour * 60 * 60 * 1000;
            ScedulerTimer(schedulerPeriod);
        }

        public void ScheduledDaySynchronize(int schedulerPeriodDay)
        {
            int schedulerPeriod = schedulerPeriodDay * 24 * 60 * 60 * 1000;
            ScedulerTimer(schedulerPeriod);
        }

        private void ScedulerTimer(int schedulerPeriodMs)
        {
            System.Windows.Forms.Timer MyTimerMin = new System.Windows.Forms.Timer();
            MyTimerMin.Interval = schedulerPeriodMs;
            MyTimerMin.Tick += MyTimer_Tick;
            MyTimerMin.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            FileSyncProvider localProvider1 = new FileSyncProvider(localPath, filterForLocalPath, options);
            FileSyncProvider remoteProvider2 = new FileSyncProvider(remotePath, filterForRemotePath, options);
            SyncOrchestrator synchOrchestrator = new SyncOrchestrator();
            synchOrchestrator.LocalProvider = localProvider1;
            synchOrchestrator.RemoteProvider = remoteProvider2;
            synchOrchestrator.Direction = SetDirection(syncDirection);
            synchOrchestrator.Synchronize();
        }
    }

}
