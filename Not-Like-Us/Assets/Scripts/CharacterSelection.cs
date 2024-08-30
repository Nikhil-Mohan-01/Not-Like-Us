using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public static string selectedCharacter;

    public void KendrickSelect()
    {
        selectedCharacter = "Kendrick";
    }

    public void DrakeSelect()
    {
        selectedCharacter = "Drake";
    }

    public void LoadPlayer()
    {
        if (selectedCharacter == "Kendrick")
        {
            SceneManager.LoadScene("Kendrick");
        }
        if (selectedCharacter == "Drake")
        {
            SceneManager.LoadScene("Drake");
        }
        else
        {
            SceneManager.LoadScene("Kendrick");
        }
    }
}
