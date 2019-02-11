using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }
}
