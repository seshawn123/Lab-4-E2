using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickPoint : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        PointsText.Instance.AddScore(1);
        #region observer
        clicked?.Invoke();
        #endregion
    }
}
