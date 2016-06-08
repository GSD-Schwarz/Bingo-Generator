using System.Collections;
namespace Awsome_Bingo_Karten_Generator
{
    public class Controller
    {
        public bool shouldCaptionsBeSet = false;
        public int gridSize = 0;
        public ArrayList filesArray;
        public ArrayList directoryArray;
        public void setgridSize(int gridSizeToSet)
        {
            gridSize = gridSizeToSet;
        }

        public Controller()
        {
           // GUI_Bingoformular _GUI_Bingoformular = new GUI_Bingoformular(gridSize, _Bilderliste.BingoCards, shouldCaptionsBeSet);
                         
               StorageManager _StorageManager = new StorageManager();
              
              //Bilderliste _Bilderliste = new Drucker();

        }
    }
}