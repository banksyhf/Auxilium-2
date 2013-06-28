using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Auxilium
{
    [Serializable]
    public class Options
    {
        public bool Timestamps { get; set; }

        public bool ChatNotifications { get; set; }

        public bool MinimizeToTray { get; set; }

        public bool AudioNotification { get; set; }

        public bool SpaceMessages { get; set; }

        public bool JoinLeaveEvents { get; set; }

        public bool WriteMessages { get; set; }


        public bool RememberFormSize { get; set; }
        public Size FormSize { get; set; }

        public bool RememberFont { get; set; }
        public SerializableFont Font { get; set; }



        public static readonly string Path = System.IO.Path.Combine(Application.StartupPath, "auxilium.xml");


        public Options()
        {
            this.Timestamps = true;
            this.ChatNotifications = true;
            this.SpaceMessages = true;
            //this.Font = new Font("Segoe UI", 8.25f);
            //this.FormSize = new Size(610, 398);
        }

        public static Options Load()
        {
            if (!File.Exists(Path))
            {
                Options options = new Options();
                options.Save();
                return options;
            }
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Options));
                using (FileStream fs = File.OpenRead(Path))
                {
                    return (Options)xml.Deserialize(fs);
                }
            }
            catch
            {
                Options options = new Options();
                options.Save();
                return options;
            }
        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Options));

            using (FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(fs, this);
                fs.Close();
            }
        }
    }
}