using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MonsterAR.Utility
{
    public class SceneController : Singleton<SceneController>
    {        
        public void GoToScene(string sceneName){
            SceneManager.LoadScene(sceneName);
        }

        public void Restart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }    
}
