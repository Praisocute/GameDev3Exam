
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Praisocute
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}