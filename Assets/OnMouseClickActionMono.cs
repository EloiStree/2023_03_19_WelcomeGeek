using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseClickActionMono : MonoBehaviour
{

    public UnityEvent m_onClickAction;
    private void OnMouseDown()
    {
        m_onClickAction.Invoke();
    }
}
