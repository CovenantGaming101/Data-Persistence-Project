using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    private UsernameContainer usernameContainer;

    public string usernameData;
    public string bestScoreName = "default";
    public int userScoreData;

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

    private void Start()
    {
        usernameContainer = GameObject.Find("Canvas").GetComponent<UsernameContainer>();
    }

    public void UserData()
    {
        Debug.Log($"Your name is {bestScoreName}");
        BestScore();
        Debug.Log("UserData was run!");
    }

    public void OtherUserData(TextMeshProUGUI nameData)
    {
        usernameData = nameData.text;
        Debug.Log($"Your name is {usernameData}");
       
        BestScore();
       
        Debug.Log("OtherUserData was run!");
    }

    public void ScoreData(int points)
    {
        userScoreData = points;
    }

    public void BestScore()
    {
        // Debug the values of bestScoreName and userScoreData
        Debug.Log($"Best Score Name: {bestScoreName}, Best Score Value: {userScoreData}");
    
        // Concatenate properly
        usernameContainer.nameScoreDisplay.text = $"Best Score: {bestScoreName} {userScoreData}";
    }


}
