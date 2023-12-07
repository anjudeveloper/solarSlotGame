using UnityEngine.SceneManagement;
using UnityEngine;

namespace Mkey
{
    public class BackButton : MonoBehaviour
    {
        [SerializeField]
        private bool defaultBehavior = false;

        public static BackButton Instance;

        void Awake()
        {
            if (Instance) Destroy(gameObject);
            else
            {
                Instance = this;
            }
        }

        void Start()
        {
            if(defaultBehavior)  Input.backButtonLeavesApp = true; // default behavior
        }

        void Update()
        {
            if (!defaultBehavior)
            {
                // Make sure user is on Android platform
                if (Application.platform == RuntimePlatform.Android)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 0)
                            Application.Quit();
                        else
                            SceneManager.LoadScene(0);
                    }
                }
            }
        }
    }
}