using UnityEngine;
using TMPro;

public class CheckpointController : MonoBehaviour
{
    public CheckpointController next;
    public MeshRenderer left;
    public MeshRenderer right;
    public bool isFirst = false;
    int laps = 0;
    public TextMeshProUGUI laplbl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        VehicleController vehicle = other.gameObject.GetComponent<VehicleController>();
        if (vehicle != null && vehicle.target == this)
        {
            if (isFirst)
            {
                laplbl.text = string.Format("Laps: {0}", laps);
                laps++;
            }
            vehicle.target = next;
            next.left.materials[0].color = Color.red;
            next.right.materials[0].color = Color.red;
            left.materials[0].color = Color.white;
            right.materials[0].color = Color.white;
        }
    }
}
