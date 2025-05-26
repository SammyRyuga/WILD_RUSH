using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGenerator : MonoBehaviour
{
    public GameObject[] Scene;

    [SerializeField] private int zPos = 50;
    [SerializeField] private bool createScene = false;
    [SerializeField] private int sceneNum;

    void Update()
    {
        if (!createScene)
        {
            createScene = true;
            StartCoroutine("SceneGen");
        }
    }

    IEnumerator SceneGen()
    {
        sceneNum = Random.Range(0, 3);
        GameObject newScene = Instantiate(Scene[sceneNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        Destroy(newScene, 500f);
        yield return new WaitForSeconds(3);
        createScene = false;
    }
}
