using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{

    private const string Scene = "MainScene";

    public void Play(){
        SceneManager.LoadScene(Scene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
