using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    //Code derived from lecture on March 21, to be used as a bonus for the game
    // Start is called before the first frame update
    Transform camShake;
    public float timeOfShake;
    public float rangeOfCam;
    Vector3 originPos;

    void Start()
    {
        camShake = Camera.main.transform;
        originPos = camShake.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShakeyCam());
        }
        IEnumerator ShakeyCam()
        {
            float timeElapsed = 0;
            while (timeElapsed < timeOfShake)
            {
                Vector3 position = originPos + Random.insideUnitSphere * rangeOfCam;
                position.z = originPos.z;
                camShake.position = position;
                timeElapsed += Time.deltaTime;
                yield return 0;
            }
            camShake.position = originPos;
        }

    }
}
