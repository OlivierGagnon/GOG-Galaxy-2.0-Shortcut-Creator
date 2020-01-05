using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using IWshRuntimeLibrary;
using System.IO;

namespace GOG_Shortcut_Creator
{
    public partial class Main : Form
    {        public Main()
        {
            InitializeComponent();
            listBoxGames.Select();
            List<Game> games = BuildList();
            foreach (Game game in games)
            {
                listBoxGames.Items.Add(game);
            }
        }
        public static List<Game> BuildList()
        {
            List<Game> games = new List<Game>();
            SQLiteDataReader rdr = GetDB();
            while (rdr.Read())
            {
                Game game = new Game();
                game.name = rdr.GetString(1);
                game.gameId = rdr.GetString(0);
                games.Add(game);
            }
            return games;
        }
        public static SQLiteDataReader GetDB()
        {
            string cs = @"Data Source=C:\ProgramData\GOG.com\Galaxy\storage\galaxy-2.0.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();
            string stm = @"SELECT trim(GamePieces.releaseKey,'gog_'), trim(trim(GamePieces.value,'{""title"":""'),'""}') FROM GamePieces
                            JOIN GamePieceTypes ON GamePieces.gamePieceTypeId = GamePieceTypes.id
                            WHERE releaseKey IN
                            (SELECT platforms.name || '_' || InstalledExternalProducts.productId FROM InstalledExternalProducts
                            JOIN Platforms ON InstalledExternalProducts.platformId = Platforms.id
                            UNION
                            SELECT 'gog_' || productId FROM InstalledProducts)
                            AND GamePieceTypes.type = 'originalTitle'";
            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
        public static void CreateShortcut(Game game, string path)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (char c in invalid)
            {
                game.name = game.name.Replace(c.ToString(), "");
            }
            string shortcutLocation = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), game.name + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = $"Launch {game.name} through GOG Galaxy 2.0";
            shortcut.TargetPath = path;
            shortcut.Arguments = "/command=runGame /gameId=" + game.gameId; ;
            shortcut.Save();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (browseGalaxyClient.ShowDialog() == DialogResult.OK)
            {
                string file = browseGalaxyClient.FileName;
                textBoxGalaxyClient.Text = file;
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Game game = (Game)listBoxGames.SelectedItem;
            CreateShortcut(game, textBoxGalaxyClient.Text);
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Game game = (Game)listBoxGames.SelectedItem;
            CreateShortcut(game, textBoxGalaxyClient.Text);
        }
    }
    public class Game
    {
        public string name;
        public string gameId;
        public override string ToString()
        {
            return name;
        }
    }
}
