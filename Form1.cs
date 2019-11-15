using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Collection
{
    public partial class GameCollectionLibrary : Form
    {
        bool dontRunHandler = false;
        private const int GAMELIMIT = 20; /* This is here to allow other developers to use this code with greater limits. */
        private static String[] names = new String[GAMELIMIT];
        private static String[] genres = new String[GAMELIMIT];
        private static String[] platforms = new String[GAMELIMIT];
        private static int count = 0; /* Start At 0 */

        public GameCollectionLibrary()
        {
            createInputDir();
            try
            {
                readFile("mygames");
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
            InitializeComponent();
            displayGames();
        }

        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontRunHandler == false)
            {
                int ind = gameListBox.SelectedIndex;
                dontRunHandler = true;
                updateTitles(ind);
            }
            //gameListBox.SelectedIndex = ind;
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                updateCollections(nameText.Text, platformText.Text, genreText.Text);
                displayGames();
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            clearGames();
            displayGames();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            genreText.Text = "";
            platformText.Text = "";
        }
        private void delete_Click(object sender, EventArgs e)
        {
            removeGame(gameListBox.SelectedIndex);
            shuffleGames();
            displayGames();
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                updateGame(gameListBox.SelectedIndex, nameText.Text, platformText.Text, genreText.Text);
                shuffleGames(); /* If they updated a empty record. */
                displayGames();
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void sort_Click(object sender, EventArgs e)
        {
            bubbleSort();
            displayGames();
        }
        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                readFile(filenameText.Text);
                displayGames();
            }
            catch(IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void binaryS_Click(object sender, EventArgs e)
        {
            binarySearchWrapper(nameText.Text);
        }
        private void searchL_Click(object sender, EventArgs e)
        {
            linearSearchWrapper(nameText.Text);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            saveFile();
        }

        /******************************************************************
         * NAME: displayGames
         * PURPOSE: To update the display gameListBox with all games in arrays.
         * IMPORTS: EventHandler onchangedindex
         * EXPORTS: None
         * ***************************************************************/
        private void displayGames()
        {
            bubbleSort();
            int ind = gameListBox.SelectedIndex;
            gameListBox.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (names[i] == null)
                { /* No More Games. */
                    Console.Out.Write("At value: " + i + " there are no more games, now filling with emptys.");
                    gameListBox.Items.Add("Empty");
                }
                else
                { /* Games */
                    gameListBox.Items.Add(String.Format("{0} {1} {2}", names[i], platforms[i].ToUpper(), genres[i]));
                }
            }
            countBox.Text = count.ToString();
            if (ind >= 0 && ind < GAMELIMIT)
            {
                gameListBox.SelectedIndex = ind;
            }
            dontRunHandler = false;
        }
        /******************************************************************
        * NAME: updateCollections
        * PURPOSE: To update the game collection
        * IMPORTS: String inGame, String inPlatform, String inGenre
        * EXPORTS: None
        * ***************************************************************/
        private void updateCollections(String inGame, String inPlatform, String inGenre)
        {
            if (inGame == null || inGame.Length < 1)
            {
                throw new ArgumentException("inGame is invalid/empty!");
            }
            else if (inPlatform == null || inPlatform.Length < 1)
            {
                throw new ArgumentException("Platform is invalid/empty!");
            }
            else if (inGenre == null || inGenre.Length < 1)
            {
                throw new ArgumentException("Genre is invalid/empty!");
            }
            else if (count == 20)
            {
                throw new ArgumentException("Cannot add anymore games!");
            }
            else
            { /* Inputs Valid */
                names[count] = inGame;
                platforms[count] = inPlatform;
                genres[count] = inGenre;
                count++;
                Console.Out.Write(String.Format("Added Game: {0}, Genre: {1}, Platform: {2}, to relevant arrays, count now at {3}", inGame, inGenre, inPlatform, count));
            }
        }
        /******************************************************************
        * NAME: clearGames
        * PURPOSE: To clear the game collection.
        * IMPORTS: None
        * EXPORTS: None
        * ***************************************************************/
        private void clearGames()
        {
            Array.Clear(names, 0, GAMELIMIT);
            Array.Clear(platforms, 0, GAMELIMIT);
            Array.Clear(genres, 0, GAMELIMIT);
            count = 0;
        }
        /******************************************************************
        * NAME: removeGame
        * PURPOSE: remove selected game
        * IMPORTS: int index
        * EXPORTS: None
        * ***************************************************************/
        private void removeGame(int index)
        {
            if (index < 0 || index > (GAMELIMIT - 1))
            {
                Console.Out.Write("Strange Index Input, Ignoring Selection.");
            }
            else
            {
                names[index] = null;
                genres[index] = null;
                platforms[index] = null;
                if (count != 0)
                {
                    count--;
                }
            }
        }
        /******************************************************************
        * NAME: shuffleGames
        * PURPOSE: shuffle game arrays.
        * IMPORTS: None
        * EXPORTS: None
        * ***************************************************************/
        private void shuffleGames()
        {
            names = shuffle(names);
            genres = shuffle(genres);
            platforms = shuffle(platforms);
        }
        private String[] shuffle(String[] selectedArray)
        {
            String[] temp = new String[selectedArray.Length];
            int k = 0;
            for (int i = 0; i < selectedArray.Length; i++)
            {
                if (selectedArray[i] != null)
                {
                    temp[k] = selectedArray[i];
                    k++;
                }
            }
            return temp;
        }
        /******************************************************************
        * NAME: updateGame
        * PURPOSE: update selected game with input values.
        * IMPORTS: int selected, String name, String platform, String genre
        * EXPORTS: None
        * ***************************************************************/
        private void updateGame(int selected, String name, String platform, String genre)
        {
            if (selected < 0 || selected > GAMELIMIT) { throw new ArgumentException("Invalid Selection To Update."); }
            else if (name == null || name.Length < 1) { throw new ArgumentException("Invalid Name input."); }
            else if (platform == null || platform.Length < 1) { throw new ArgumentException("Invalid Platform input."); }
            else if (genre == null || genre.Length < 1) { throw new ArgumentException("Invalid Genre input."); }
            else
            {
                if (names[selected] == null)
                { /* Updating A Empty Record. */
                    names[selected] = name;
                    platforms[selected] = platform;
                    genres[selected] = genre;
                    count++;
                }
                else
                { /* Updating a normal record. */
                    names[selected] = name;
                    platforms[selected] = platform;
                    genres[selected] = genre;
                }
            }
        }
        /******************************************************************
        * NAME: bubbleSort
        * PURPOSE: sort arrays based off name using bubbleSort algorithm. (can not finish early, bad bubblesort algorithm, can be improved!)
        * IMPORTS: None
        * EXPORTS: None
        * ***************************************************************/
        private void bubbleSort()
        {
            for (int i = 0; i < (GAMELIMIT - 1); i++)
            {
                for (int k = i + 1; k < GAMELIMIT; k++)
                {
                    if (names[i] != null && names[k] != null && names[i].CompareTo(names[k]) > 0)
                    {
                        String tempName = names[i];
                        String tempGenre = genres[i];
                        String tempPlatform = platforms[i];
                        names[i] = names[k];
                        platforms[i] = platforms[k];
                        genres[i] = genres[k];
                        names[k] = tempName;
                        genres[k] = tempGenre;
                        platforms[k] = tempPlatform;
                    }
                }
            }
        }
        /******************************************************************
        * NAME: createInputDir
        * PURPOSE: create directory inputFiles for .dat Files if it doesnt exist.
        * IMPORTS: None
        * EXPORTS: None
        * ***************************************************************/
        private void createInputDir()
        {
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(System.Environment.CurrentDirectory + "\\InputFiles"))
                {
                    Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\InputFiles");
                }
            }
            catch (Exception)
            {
                // Directory Exists.
            }
        }
        /******************************************************************
        * NAME: readFile
        * PURPOSE: reads input file and saves information.
        * IMPORTS: String filename
        * EXPORTS: None
        * ***************************************************************/
        private void readFile(String filename)
        {
            if (filename == null || filename.Length < 1)
            {
                throw new IOException("Inputted Filename is invalid!");
            }
            else if (filename.Contains("."))
            {
                throw new IOException("input filename should not contain a . (dont include fileExtension.)");
            }
            else if (!File.Exists(System.Environment.CurrentDirectory + "\\InputFiles\\" + filename + ".dat"))
            {
                throw new IOException("file " + filename + ".dat does not exist");
            }
            else
            {
                beginRead(System.Environment.CurrentDirectory + "\\InputFiles\\" + filename + ".dat");
            }
        }
        private void beginRead(String path)
        {
            clearGames();
            StreamReader sr = File.OpenText(path);
            try
            { /* Lines Should be: Name,Platform,Genre\n */
                String line = sr.ReadLine();
                while (line != null && line != "")
                {
                    String[] lines = line.Split(',');
                    if (lines.Length != 3)
                    {
                        throw new IOException("Expected Line Format To Be Name,Platform,Genre");
                    }
                    try
                    {
                        updateCollections(lines[0], lines[1], lines[2]);
                    }
                    catch (ArgumentException exc2)
                    {
                        MessageBox.Show(exc2.Message);
                    }
                    line = sr.ReadLine();
                }
                sr.Close(); // Close Stream.
            }
            catch (IOException exc)
            {
                throw exc;
            }
        }
        /******************************************************************
        * NAME: saveFile
        * PURPOSE: saves games to mygames.dat
        * IMPORTS: None
        * EXPORTS: None
        * ***************************************************************/
        private void saveFile()
        { /* Saves to mygames.dat */
            try
            {
                StreamWriter sw = File.CreateText(System.Environment.CurrentDirectory + "\\InputFiles\\" + "mygames.dat");
                for (int i = 0; i < count; i++)
                {
                    sw.WriteLine(String.Format("{0},{1},{2}", names[i], platforms[i], genres[i]));
                }
                sw.Close();
                MessageBox.Show("Successfully Saved Game");
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        /******************************************************************
        * NAME: updateTitles
        * PURPOSE: titles updated to selected ind
        * IMPORTS: int ind
        * EXPORTS: None
        * ***************************************************************/
        private void updateTitles(int ind)
        {
            if (ind >= 0 && ind < GAMELIMIT)
            {
                if (names[ind] != null)
                {
                    nameText.Text = names[ind];
                    platformText.Text = platforms[ind];
                    genreText.Text = genres[ind];
                    displayGames();
                }
                else
                {
                    nameText.Text = "";
                    platformText.Text = "";
                    genreText.Text = "";
                    displayGames();
                }
            }
        }
        /******************************************************************
        * NAME: binarySearch
        * PURPOSE: Performs a recursive binary search for input string.
        * IMPORTS: String name
        * EXPORTS: None
        * ***************************************************************/
        private void binarySearchWrapper(String name)
        {
            if (name != null)
            {
                binarySearch(0, count, name);
            }
            else
            {
                MessageBox.Show("Please enter a name to search");
            }
        }
        private void binarySearch(int left, int right, String name)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                int comparision = name.CompareTo(names[mid]);
                if (comparision == 0)
                {
                    genreText.Text = genres[mid];
                    platformText.Text = platforms[mid];
                }
                else if (comparision < 0)
                {
                    binarySearch(left, mid - 1, name); // recurse left
                }
                else
                {
                    binarySearch(mid+1, right, name); // recurse right
                }
            }
            else
            {
                nameText.Text = "";
                genreText.Text = "";
                platformText.Text = "";
                MessageBox.Show("Cannot find game " + name);
            }
        }
        /******************************************************************
        * NAME: linearSearch
        * PURPOSE: Performs a linear search for input string.
        * IMPORTS: String name
        * EXPORTS: None
        * ***************************************************************/
        private void linearSearchWrapper(String name)
        {
            int foundInd = -1;
            for (int i = 0; i < count; i++)
            {
                if (name.Equals(names[i]))
                {
                    foundInd = i;
                }
            }
            if (foundInd >= 0)
            {
                genreText.Text = genres[foundInd];
                platformText.Text = platforms[foundInd];
            }
            else
            {
                nameText.Text = "";
                genreText.Text = "";
                platformText.Text = "";
                MessageBox.Show("Cannot find game " + name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameCollectionLibrary_Load(object sender, EventArgs e)
        {

        }
    }
}
