using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Auxilium.Updating
{
    internal class Updater
    {
        public event UpdateProgressEventHandler UpdateProgress;

        public delegate void UpdateProgressEventHandler(int percentage);

        private void OnUpdateProgress(int percentage)
        {
            if (UpdateProgress != null)
                UpdateProgress(percentage);
        }

        public string Link { get; set; }

        public string ChangeLog { get; set; }

        public string Version { get; set; }

        public bool UpdaterOpen { get; set; }

        private string _updateCheckUrl;
        private string _currentVersion;
        private string _lastVersion;

        public Updater(string url, string currentVersion)
        {
            this._updateCheckUrl = url;
            this._currentVersion = currentVersion;
        }

        public bool UpdateAvailable()
        {
            WebClient wc = new WebClient();
            string xml = wc.DownloadString(this._updateCheckUrl);

            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                string version = reader.GetValue("Version");

                if (UpdaterOpen && version == _lastVersion)
                    return false;

                _lastVersion = version;

                string link = reader.GetValue("Link");
                string changeLog = reader.GetValue("ChangeLog");

                this.Link = link;
                this.Version = version;
                this.ChangeLog = changeLog;

                if (version != this._currentVersion)
                    return true;

                return false;
            }
        }

        public void StartUpdate()
        {
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(new Uri(Link), "update.zip");
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int percentage = (int)(Math.Round((decimal)e.BytesReceived / (decimal)e.TotalBytesToReceive) * 100);

            OnUpdateProgress(percentage);
        }

        private void wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            File.WriteAllBytes("updater.exe", Properties.Resources.Updater);

            Process.Start("updater.exe", string.Format("\"{0}\" \"{1}\"", "update.zip", Application.ExecutablePath));
            Environment.Exit(0);
        }
    }

    internal static class ExtensionMethods
    {
        public static string GetValue(this XmlReader reader, string s)
        {
            reader.ReadToFollowing(s);
            return reader.ReadElementContentAsString();
        }
    }
}