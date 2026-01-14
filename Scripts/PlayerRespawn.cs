
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;

    void Start()
    {
        string scene = SceneManager.GetActiveScene().name;

    
    if (scene != "Menu" && PlayerPrefs.GetFloat("checkPointPositionX") != 0)
    {
        transform.position = new Vector2(
            PlayerPrefs.GetFloat("checkPointPositionX"),
            PlayerPrefs.GetFloat("checkPointPositionY")
        );
    }
    }

    public void ReachedCheckPoint(float x, float y)
    {
        string scene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetFloat("checkPointPositionX", x);

        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }
    
    public void PlayerDamaged()
    {
        animator.Play("Hit");
        ResetCheckPoint();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetCheckPoint()
    {
        PlayerPrefs.DeleteKey("checkPointPositionX");
        PlayerPrefs.DeleteKey("checkPointPositionY");
    }

    
}
