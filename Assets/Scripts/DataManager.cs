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
        Debug.Log("The correct code was run...Right?");
    }

    public void OtherUserData(TextMeshProUGUI nameData)
    {
        usernameData = nameData.text;
        Debug.Log($"Your name is {usernameData}");
        BestScore();
        Debug.Log("Ah. The wrong code was run.");
    }

    public void ScoreData(int points)
    {
        userScoreData = points;
    }

    public void BestScore()
    {
        usernameContainer.nameScoreDisplay.text += $"Best Score: {bestScoreName} {userScoreData}";
    }

}
