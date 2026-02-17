using UnityEngine;

    //This code is a snippet from https://www.youtube.com/watch?v=UcYfEfJW_mk // also put this in asset declaration form
    public class NewMonoBehaviourScript : MonoBehaviour
    {
    [SerializeField] float backAngle = 65f;
    [SerializeField] float sideAngle = 155f;
    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    private void LateUpdate()
    {
        Vector3 camFowardVector = new Vector3(Camera.main.transform.foward.x, 0f, Camera.main.transform.foward.z)
            Debug.DrawRay(Camera.main.transform.position, camFowardVector * 5f, Colour.Magenta);

        float signedAngle = Vector3.SignedAngle(mainTransform.foward, camFowardVector, Vector3.up);

        Vector2 animationDirection = new Vector2(0f, -1f);

        float angle = Mathf.Abs(signedAngle);

        //This changes the side angle based on what side the camera is viewing the slime from
        if (angle < backAngle)
        {
            //back Animation
            animationDirection = new Vector2(0f, -1f); 
        }
        else if (angle < sideAngle)
        {
            //side Animation
            animationDirection = new Vector2(1f, 0f);

            if (signedAngle < 0f) // will have to pass in own angle here
            {
                //left side
                animationDirection = new Vector2(1f, 0f)
            }
            else
            {
                //right side
                animationDirection = new Vector2(1f, 0f)
            }
        }
        else
        {
            //Front Animation
            animationDirection = new Vector2(0f, 1f);
        }



    }
