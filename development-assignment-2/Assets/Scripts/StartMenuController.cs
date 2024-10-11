using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public string nextSceneName;
    private void OnEnter(){
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
}
