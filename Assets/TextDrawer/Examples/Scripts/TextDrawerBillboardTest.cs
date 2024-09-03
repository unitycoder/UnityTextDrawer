using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDrawerBillboardTest : MonoBehaviour
{
    public TextDrawer.TextPivot Pivot;

    private void LateUpdate()
    {
        TextDrawer.DrawTextFacingCamera("Billboard", 12f, Color.red, transform.position);
    }
}
