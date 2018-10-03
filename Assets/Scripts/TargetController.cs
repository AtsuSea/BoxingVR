using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    public List<GameObject> targets;
    public GameObject targetPrefab;
    public Transform PlayerTransform;

    // Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < targets.Count; i++)
        {
            GameObject data = targets[i];
            data.transform.LookAt(PlayerTransform);
        }
    }

    public void StartGame()
    {
        targets.Clear();
        StartCoroutine("Game");
    }

    private IEnumerator Game()
    {
        for(int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(1.0f);
            Vector3 position = new Vector3();
            position.x = Random.Range(-1f, 1f);
            position.y = Random.Range(0.8f, 1.2f);
            position.z = Random.Range(-0.5f, 0.5f);
            targets.Add(Instantiate(targetPrefab, position, Quaternion.identity));
        }
        
    }

}
