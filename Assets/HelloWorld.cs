using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float timer = 0.0f;
    float waitTime = 1.0f;
    int counter = 0;

    void Update()
    {
        timer += Time.deltaTime;

        //Debug.Log("counter value = " + timer);

        if (timer >= waitTime)
        {
            //Debug.Log("counter value = " + counter);

            timer -= waitTime;

            counter = counter + 1;

            transform.position = new Vector3(0, 1, 0); 

            //counter++;

        }
    }
}
