using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public string usernameData;
    public int userScoreData;
    public Dictionary<string, int> highScore = new Dictionary<string, int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UserData(TextMeshProUGUI nameData)
    {
        usernameData = nameData.text;
        highScore.Add(usernameData, userScoreData);
    }

}
