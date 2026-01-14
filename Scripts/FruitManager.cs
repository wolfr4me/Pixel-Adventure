using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FruitManager : MonoBehaviour
{
    

    public GameObject transition;

    public TMP_Text totalFruits;

    public TMP_Text fruitsCollected;

    private int totalFruitsInLevel;

    void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }
    private void Update() 
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }

    public void AllFruitsCollected()
    {
        
        if (transform.childCount == 0)
        {
            Debug.Log("No quedas mas frutas");
            
            Invoke("ChangeScene", 1);
            transition.SetActive(true);
            Invoke("ChangeScene", 1);

        }
    }
    
    void ChangeScene()    
    {
    int nivelActual = SceneManager.GetActiveScene().buildIndex;
        if (nivelActual == 3)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
