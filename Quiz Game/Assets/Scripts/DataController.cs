using System.Collections;
using System.Collections.Generic;
// System.IO namespace contains functions related to loading and saving files
using System.IO;        
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// To manage all of the data
/// </summary>

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;    // if size 1, we'll have 1 round

    // load the json file
    private string gameDataFileName = "data.json";


    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadGameData();
        LoadPlayerProgress();

        SceneManager.LoadScene("MenuScreen");
    }


    
    void Update()
    {
        
    }


    /// <summary>
    /// supply the round data to the game controller
    /// </summary>
    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0];     // we know we're only going to have data at index 0 in RoundData array, we could pas in an int to say what data we want to return, what round we're in etc.

    }

    private void LoadGameData()
    {
        // path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in 
        // the Editor, and the StreamAssets folder in the build
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        if (File.Exists(filePath))
        {
            // read the jason file into a string
            string dataAsJson = File.ReadAllText(filePath);

            // pass the json to JsonUtility, tell it to create a gameobject
            // from it

            //GameData
        }

    }
}
