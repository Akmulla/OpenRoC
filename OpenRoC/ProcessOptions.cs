﻿namespace oroc
{
    public class ProcessOptions : INotifyPropertyChangedAuto
    {
        #region private data holders

        private string path;
        private string workingDirectory;
        private bool crashedIfNotRunning;
        private bool crashedIfUnresponsive;
        private bool doubleCheckEnabled;
        private uint doubleCheckDuration;
        private bool gracePeriodEnabled;
        private uint gracePeriodDuration;
        private bool preLaunchScriptEnabled;
        private string preLaunchScriptPath;
        private bool aggressiveCleanupEnabled;
        private bool postCrashScriptEnabled;
        private string postCrashScriptPath;
        private bool screenShotEnabled;
        private bool alwaysOnTopEnabled;
        private bool commandLineEnabled;
        private string commandLine;
        private bool environmentVariablesEnabled;
        private string environmentVariables;

        #endregion

        #region DataBind accessible properties 

        public string Path
        {
            get { return path; }
            set
            {
                if (path == value)
                    return;

                path = value;
                NotifyPropertyChanged();
            }
        }

        public string WorkingDirectory
        {
            get { return workingDirectory; }
            set
            {
                if (workingDirectory == value)
                    return;

                workingDirectory = value;
                NotifyPropertyChanged();
            }
        }

        public bool CrashedIfNotRunning
        {
            get { return crashedIfNotRunning; }
            set
            {
                if (crashedIfNotRunning == value)
                    return;

                crashedIfNotRunning = value;
                NotifyPropertyChanged();
            }
        }

        public bool CrashedIfUnresponsive
        {
            get { return crashedIfUnresponsive; }
            set
            {
                if (crashedIfUnresponsive == value)
                    return;

                crashedIfUnresponsive = value;
                NotifyPropertyChanged();
            }
        }

        public bool DoubleCheckEnabled
        {
            get { return doubleCheckEnabled; }
            set
            {
                if (doubleCheckEnabled == value)
                    return;

                doubleCheckEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public uint DoubleCheckDuration
        {
            get { return doubleCheckDuration; }
            set
            {
                if (doubleCheckDuration == value)
                    return;

                doubleCheckDuration = value;
                NotifyPropertyChanged();
            }
        }

        public bool GracePeriodEnabled
        {
            get { return gracePeriodEnabled; }
            set
            {
                if (gracePeriodEnabled == value)
                    return;

                gracePeriodEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public uint GracePeriodDuration
        {
            get { return gracePeriodDuration; }
            set
            {
                if (gracePeriodDuration == value)
                    return;

                gracePeriodDuration = value;
                NotifyPropertyChanged();
            }
        }

        public bool PreLaunchScriptEnabled
        {
            get { return preLaunchScriptEnabled; }
            set
            {
                if (preLaunchScriptEnabled == value)
                    return;

                preLaunchScriptEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public string PreLaunchScriptPath
        {
            get { return preLaunchScriptPath; }
            set
            {
                if (preLaunchScriptPath == value)
                    return;

                preLaunchScriptPath = value;
                NotifyPropertyChanged();
            }
        }

        public bool AggressiveCleanupEnabled
        {
            get { return aggressiveCleanupEnabled; }
            set
            {
                if (aggressiveCleanupEnabled == value)
                    return;

                aggressiveCleanupEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public bool PostCrashScriptEnabled
        {
            get { return postCrashScriptEnabled; }
            set
            {
                if (postCrashScriptEnabled == value)
                    return;

                postCrashScriptEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public string PostCrashScriptPath
        {
            get { return postCrashScriptPath; }
            set
            {
                if (postCrashScriptPath == value)
                    return;

                postCrashScriptPath = value;
                NotifyPropertyChanged();
            }
        }

        public bool ScreenShotEnabled
        {
            get { return screenShotEnabled; }
            set
            {
                if (screenShotEnabled == value)
                    return;

                screenShotEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public bool AlwaysOnTopEnabled
        {
            get { return alwaysOnTopEnabled; }
            set
            {
                if (alwaysOnTopEnabled == value)
                    return;

                alwaysOnTopEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public bool CommandLineEnabled
        {
            get { return commandLineEnabled; }
            set
            {
                if (commandLineEnabled == value)
                    return;

                commandLineEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public string CommandLine
        {
            get { return commandLine; }
            set
            {
                if (commandLine == value)
                    return;

                commandLine = value;
                NotifyPropertyChanged();
            }
        }

        public bool EnvironmentVariablesEnabled
        {
            get { return environmentVariablesEnabled; }
            set
            {
                if (environmentVariablesEnabled == value)
                    return;

                environmentVariablesEnabled = value;
                NotifyPropertyChanged();
            }
        }

        public string EnvironmentVariables
        {
            get { return environmentVariables; }
            set
            {
                if (environmentVariables == value)
                    return;

                environmentVariables = value;
                NotifyPropertyChanged();
            }
        }

        #endregion
    }
}
