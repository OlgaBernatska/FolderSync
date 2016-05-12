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
        BothDirection, LocalToRemote, RemoteToLocal
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
            set
            {
                localPath = value;
            }
        }

        public string RemotePath
        {
            set
            {
                remotePath = value;
            }
        }

        public SyncDirectionEnum SyncDirection
        {
            set
            {
                syncDirection = value;
            }
        }


        //public string ExcludeFolders
        //{
        //    set
        //    {
        //        _filter.SubdirectoryExcludes.Add(value);
        //    }
        //}

        //public string ExcludeFiles
        //{
        //    set
        //    {
        //        _filter.FileNameExcludes.Add(value);
        //    }
        //}

        //public string IncludeFiles
        //{
        //    set
        //    {
        //        _filter.FileNameIncludes.Add(value);
        //    }
        //}

        //public void ClearExcludeFolders()
        //{
        //    _filter.SubdirectoryExcludes.Clear();
        //}

        //public void ClearExcludeFiles()
        //{
        //    _filter.FileNameExcludes.Clear();
        //}

        //public void ClearIncludeFiles()
        //{
        //    _filter.FileNameIncludes.Clear();
        //}

        public SyncDirectionOrder SetDirection(SyncDirectionEnum syncDirection)
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
                        return SyncDirectionOrder.UploadAndDownload;
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


        //public void OnceSynch(string path1, string path2, SyncDirectionEnum syncDirection)
        //{
        //    FileSyncScopeFilter _filter = new FileSyncScopeFilter();
        //    FileSyncOptions _options = FileSyncOptions.None;
        //    FileSyncProvider folderProvider1 = new FileSyncProvider(path1, _filter, _options);
        //    FileSyncProvider folderProvider2 = new FileSyncProvider(path2, _filter, _options);
        //    SyncOrchestrator synchOrchestrator = new SyncOrchestrator();
        //    synchOrchestrator.LocalProvider = folderProvider1;
        //    synchOrchestrator.RemoteProvider = folderProvider2;
        //    synchOrchestrator.Direction = SetDirection(syncDirection);
        //    synchOrchestrator.Synchronize();
        //}

        public void ScheduledMinSynchronize(int schedulerPeriodMin)
        {
            int schedulerPeriod = schedulerPeriodMin * 1000;
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

        //private void ScedulerTimer(int schedulerPeriodMs, string path1, string path2, SyncDirectionEnum syncDirection)
        //{
        //    System.Windows.Forms.Timer MyTimerMin = new System.Windows.Forms.Timer();
        //    MyTimerMin.Interval = schedulerPeriodMs;
        //    MyTimerMin.Tick += new EventHandler((s,e) => MyTimer_Tick(s,e, path1, path2,  syncDirection));
        //    MyTimerMin.Start();
        //}

        //private void MyTimer_Tick(object sender, EventArgs e, string path1, string path2, SyncDirectionEnum syncDirection)
        //{            
        //    OnceSynch(path1, path2, syncDirection);
        //}

        //private void ScedulerTimer(int schedulerPeriodMs, string path1, string path2, SyncDirectionEnum syncDirection)
        //{
        //    System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
        //    MyTimer.Interval = schedulerPeriodMs;
        //    MyTimer.Tick += (sender, eventArgs) =>
        //    {
        //        OnceSynch(path1, path2, syncDirection);
        //    };
        //}


        //public event EventHandler<TimerElapsedArgs> TimerElapsed;

        //protected virtual void OnTimerElapsed(TimerElapsedArgs e)
        //{            
        //    if (TimerElapsed != null)
        //    {
        //        TimerElapsed(this, e);
        //    }
        //}





    }

    //public class TimerElapsedArgs : EventArgs
    //{
    //    public int schedulerPeriodMs { get; set; }
    //    public string path1 { get; set; }
    //    public string path2 { get; set; }
    //    public SyncDirectionEnum syncDirection { get; set; }
    //}

}
//int schedulerPeriodMs, string path1, string path2, SyncDirectionEnum syncDirection
