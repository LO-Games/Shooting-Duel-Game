using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DestroyOnTrigger : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 3;
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject firePrefab;
    private TextMeshPro tmp;
    private string nextSceneName = "GameOverScene";
    public static string winnerTag;

    private void OnTriggerEnter(Collider other){
         if(other.tag == triggeringTag && enabled){
            maxHitPoints--;
            tmp.text = maxHitPoints.ToString();
            Destroy(other.gameObject);
            if(maxHitPoints == 0){
                SetWinner(this.tag);
                StartCoroutine(MoveNextSceneAfterTwoSeconds());
            }
        }
    }

    IEnumerator MoveNextSceneAfterTwoSeconds(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<KeyboardSpawner>().enabled = false;
        tmp.GetComponent<TextMeshPro>().enabled = false;
        Instantiate(firePrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(nextSceneName);
    }

    public static void SetWinner(string tag){
        if(tag == "Cube1"){
            winnerTag = "Cube2";
        } else {
            winnerTag = "Cube1";
        }
    }

    // Start is called before the first frame update
    void Start()
    {    
        Transform hitPoints = transform.Find("HitPoints");
        if (hitPoints != null){
            tmp = hitPoints.GetComponent<TextMeshPro>();
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
