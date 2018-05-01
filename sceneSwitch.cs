using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour {

    public void GoToFirstScene() {
        SceneManager.LoadScene("first");
    }

    public void GoToSecondScene() {
        SceneManager.LoadScene("second");
    }

}
