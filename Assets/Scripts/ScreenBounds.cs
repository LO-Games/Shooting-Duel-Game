using UnityEngine;

public class ScreenBounds : MonoBehaviour {
    
    private float objectHeight;
    private float objectWidth;
    private Vector2 screenBounds;

    void Start () {
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.extents.x;
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.extents.y;
        Camera mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    void Update () {
        Vector3 viewPosition = transform.position;
        viewPosition.x = Mathf.Clamp(viewPosition.x, -screenBounds.x + objectWidth, screenBounds.x - objectWidth);
        viewPosition.y = Mathf.Clamp(viewPosition.y, -screenBounds.y + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPosition;
    }
}
