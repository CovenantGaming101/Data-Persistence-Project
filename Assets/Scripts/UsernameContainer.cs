using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UsernameContainer : MonoBehaviour
{
    public Text username;
    public Text nameScoreDisplay;

    public void UserEnter()
    {
        if (username.text == DataManager.instance.bestScoreName && username != null)
        {
            DataManager.instance.UserData();
        }
        else if (username != null)
        {
            DataManager.instance.OtherUserData(username);
        }
        else
        {
            Debug.LogError("username Text has returned as null!");
        }
    }
}
