using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsernameContainer : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI nameScoreDisplay;

    public void UserEnter()
    {
        if (username.text == DataManager.instance.bestScoreName)
        {
            DataManager.instance.UserData();
        }
        else
        {
            DataManager.instance.OtherUserData(username);
        }
    }
}
