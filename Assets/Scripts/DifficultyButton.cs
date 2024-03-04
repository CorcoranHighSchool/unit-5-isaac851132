using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;
    public int difficuly;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficuly);
    }
    void SetDifficuly()
    {
        Debug.Log(gameObject.name + "was clicked");
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.StartGame(difficuly);
    }


}
