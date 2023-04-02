using System.Collections;
using UnityEngine;

public class WinnerDisplay : MonoBehaviour
{
    [SerializeField] private SpriteRenderer cube1Renderer;
    [SerializeField] private SpriteRenderer cube2Renderer;

    // Start is called before the first frame update
    void Start()
    {
        if (DestroyOnTrigger.winnerTag == "Cube1")
        {
            cube1Renderer.enabled = true;
            cube2Renderer.enabled = false;
        }
        else if (DestroyOnTrigger.winnerTag == "Cube2")
        {
            cube2Renderer.enabled = true;
            cube1Renderer.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
