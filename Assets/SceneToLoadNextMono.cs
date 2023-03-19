using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class SceneToLoadNextMono : MonoBehaviour
{
    
    public string m_sceneNameToLoad="Put your name scene here";

    [ContextMenu("RequestToLoadNextScene")]
    public void RequestToLoadNextScene(){
         SceneManager.LoadScene(m_sceneNameToLoad);
    }    


}
