using System.IO;

namespace PrimePotAutoStarter {
    internal class ShortCutCreator {
        private string autoStartFolder;
        private string shortCutUrl;
        private string shortCutName;
        private string shortCutFilePath;
        private bool shortCutExists;

        public ShortCutCreator() {
            autoStartFolder = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

            shortCutUrl = "https://twitch.tv/primepot";
            shortCutName = "PrimePotAutoStarter";
            shortCutFilePath = autoStartFolder + "\\" + shortCutName + ".url";

            shortCutExists = CheckIfFileExists(shortCutFilePath);
        }

        public void Create() {
            CreateShortcut(shortCutName, shortCutUrl);
        }

        private void CreateShortcut(string name, string url) {
            using (StreamWriter writer = new StreamWriter(autoStartFolder + "\\" + name + ".url")) {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=" + url);
                writer.Flush();
            }
        }

        private static bool CheckIfFileExists(string name) {
            if (!File.Exists(name)) {
                return false;
            }
            return true;
        }


    }
}
