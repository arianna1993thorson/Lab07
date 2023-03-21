using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersitenceManager : MonoBehaviour 
{ 

    public static DataPersitenceManager manager
    {
        get;
        private set;
    }
    private GameData gameData;
    private FileDataHandler dataHandler;
    [SerializeField] private string fileName;        

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath,fileName);
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void LoadGame()
    {
        this.gameData = dataHandler.Load();
        if(this.gameData == null)
        {
            Debug.Log("No Data was found, initialize game with the default");
            NewGame();
        }
        Debug.Log("Loaded score " + gameData.score);
    }

    public void SaveGame()
    {
        
    }
}
