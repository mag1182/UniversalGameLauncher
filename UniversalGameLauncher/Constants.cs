using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher
{
    class Constants : Application {

        /// <summary>
        /// Core game info
        /// </summary>
        public static readonly string GAME_TITLE = "ReturnToParadise";
        public static readonly string LAUNCHER_NAME = "RTP Launcher";

        /// <summary>
        /// Paths & urls
        /// </summary>
        public static readonly string DESTINATION_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GAME_TITLE);
        public static readonly string ZIP_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".zip");
        public static readonly string GAME_EXECUTABLE_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".exe");
        public static readonly string VERSION_URL = "http://returnofparadise.com/Launcher/version.txt";
        public static readonly string APPLICATION_ICON_URL = "http://returnofparadise.com/Launcher/DUP.ico"; // Needs to be .ico
        public static readonly string LOGO_URL = "http://returnofparadise.com/Launcher/Placeholder_Logo_280x58.png"; // Ideally around 283x75
        public static readonly string BACKGROUND_URL = "http://returnofparadise.com/Launcher/VP4.png";
        public static readonly string PATCH_NOTES_URL = "http://returnofparadise.com/Launcher/updates.xml";
        public static readonly string CLIENT_DOWNLOAD_URL = "http://returnofparadise.com/Launcher/ReturnToParadise.zip";

        
        /// <summary>
        /// Navigation bar buttons
        /// </summary>
        public static readonly string NAVBAR_BUTTON_1_TEXT = "Website";
        public static readonly string NAVBAR_BUTTON_1_URL = "http://returnofparadise.com";
        public static readonly string NAVBAR_BUTTON_2_TEXT = "Wiki";
        public static readonly string NAVBAR_BUTTON_2_URL = "http://returnofparadise.com/Wiki/";
        public static readonly string NAVBAR_BUTTON_3_TEXT = "Progress";
        public static readonly string NAVBAR_BUTTON_3_URL = "https://trello.com/b/vM0IlfjS/return-to-paradise";
        public static readonly string NAVBAR_BUTTON_4_TEXT = "Support";
        public static readonly string NAVBAR_BUTTON_4_URL = "https://www.patreon.com/Return_To_Paradise";
        public static readonly string NAVBAR_BUTTON_5_TEXT = "Discord";
        public static readonly string NAVBAR_BUTTON_5_URL = "https://discord.gg/6gbCx52fGY";

        // Modify this array if you're adding or removing a button
        public static readonly string[] NAVBAR_BUTTON_TEXT_ARRAY = {NAVBAR_BUTTON_1_TEXT, NAVBAR_BUTTON_2_TEXT, NAVBAR_BUTTON_3_TEXT,
                                                                    NAVBAR_BUTTON_4_TEXT, NAVBAR_BUTTON_5_TEXT };

        /// <summary>
        /// Settings
        /// </summary>
        public static bool SHOW_VERSION_TEXT = true;
        public static bool AUTOMATICALLY_BEGIN_UPDATING = false;
        public static bool AUTOMATICALLY_LAUNCH_GAME_AFTER_UPDATING = false;
        public static bool SHOW_ERROR_BOX_IF_PATCH_NOTES_DOWNLOAD_FAILS = true;

    }
}
