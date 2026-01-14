using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public TMP_Text text;
    public string levelName;
    private int playerCollidersInside = 0;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCollidersInside++;
            text.gameObject.SetActive(true);
            
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {       
            playerCollidersInside--;
            if(playerCollidersInside <= 0)
            {
                text.gameObject.SetActive(false);
            }           
        }
    }

    void Update()
    {
        if(playerCollidersInside > 0 && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
