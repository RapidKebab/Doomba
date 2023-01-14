using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    public GameObject player;
    public GameObject[] ending;
    public Text endText;
    bool over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null && !over) {
            over = true;
            endGame();
        }
        if (over && Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void endGame() {
        foreach (GameObject g in ending)
        {
            g.SetActive(true);
            endText.text = "You survived " + (int)Time.timeSinceLevelLoad + " seconds";
        }
    }
}
