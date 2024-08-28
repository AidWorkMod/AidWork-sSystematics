using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTheScene : MonoBehaviour
{
    //the name of the
    public string scenename = "the scene name";

    void Start()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
