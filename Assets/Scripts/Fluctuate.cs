using UnityEngine;

public class Fluctuate : MonoBehaviour
{
    public float scaleFactor = 1.0f;

    public float duration = 2.0f;


    private float timer;

    private int scaleSign = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the timer to 0 at the start
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the timer by the time elapsed since the last frame
        timer += Time.deltaTime;

        // Check if the timer has exceeded the set duration
        if (timer > duration)
        {
            // Direction Reversal Logic

            // Reverse the scaling direction
            // If scaleSign is 1, it becomes -1
            // If scaleSign is -1, it becomes 1
            scaleSign *= -1;

            // Reset the timer back to 0 to start the new cycle
            timer = 0.0f;
        }

        //Scaling Logic

        // Calculate the amount to scale in a frame
        float scaleChangeThisFrame = scaleFactor * scaleSign * Time.deltaTime;

        // Create a Vector3 representing the change for all axes 
        Vector3 scaleAmount = new Vector3(scaleChangeThisFrame, scaleChangeThisFrame, scaleChangeThisFrame);

        // Apply the calculated scale change to the object's current localScale
        transform.localScale += scaleAmount;
    }
}
