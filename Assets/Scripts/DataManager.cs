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

        if (string.IsNullOrEmpty(bestScoreName))
        {
            Debug.LogWarning("it's null or empty in the Awake method!");
        }
    }

    private void Start()
    {
        usernameContainer = GameObject.Find("Canvas").GetComponent<UsernameContainer>();

        if (string.IsNullOrEmpty(bestScoreName))
        {
            Debug.LogWarning("It's null or empty in the Start method!");
        }
        else
        {
            Debug.Log($"It's set as {bestScoreName} during Start");
        }
    }

    public void UserData()
    {
        Debug.Log($"Your name is {bestScoreName}");
        BestScore();
        Debug.Log("The correct code was run...Right?");
    }

    public void OtherUserData(TextMeshProUGUI nameData)
    {
        usernameData = nameData.text;
        Debug.Log($"Your name is {usernameData}");
        if (string.IsNullOrEmpty(bestScoreName))
        {
            Debug.LogWarning("It's null or empty in the OtherUserData method!");
        }
        BestScore();
        if (string.IsNullOrEmpty(bestScoreName))
        {
            Debug.LogWarning("It's null or empty in the OtherUserData method- AFTER BestScore is called, specifically");
        }
        Debug.Log("Ah. The wrong code was run.");
    }

    public void ScoreData(int points)
    {
        userScoreData = points;
    }

    public void BestScore()
    {
        // Debug the values of bestScoreName and userScoreData
        Debug.Log($"Best Score Name: {bestScoreName}, Best Score Value: {userScoreData}");

        if (string.IsNullOrEmpty(bestScoreName))
        {
            Debug.LogWarning("bestScoreName is null or empty!");
        }
    
        // Concatenate properly
        usernameContainer.nameScoreDisplay.text = $"Best Score: {bestScoreName} {userScoreData}";
    }


}
