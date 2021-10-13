using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickHP : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        HPText.Instance.TakeDamage(10);
        #region observer
        clicked?.Invoke();
        #endregion
    }
}
