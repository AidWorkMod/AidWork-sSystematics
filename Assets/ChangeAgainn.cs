using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeAgainn : MonoBehaviour
{
    // lmao
    public string sceneNAem = "duh nameh";

    void Start()
    {
        Changeit();
    }

    void Changeit()
    {
        SceneManager.LoadScene(sceneNAem);
    }
}
