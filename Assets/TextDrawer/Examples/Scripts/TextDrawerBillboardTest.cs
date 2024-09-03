using UnityEngine;

namespace SimpleText.Samples
{
    public class TextDrawerBillboardTest : MonoBehaviour
    {
        public TextDrawer.TextPivot Pivot;

        Vector3[] positions = new Vector3[100];
        Color[] colors = new Color[100];

        private void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                positions[i] = transform.position + Random.insideUnitSphere * 25f;
                colors[i] = Random.ColorHSV();
            }

        }

        private void LateUpdate()
        {
            for (int i = 0; i < 100; i++)
            {
                TextDrawer.DrawTextFacingCamera("Billboard" + i, 12f, colors[i], positions[i]);
            }
        }
    }
}