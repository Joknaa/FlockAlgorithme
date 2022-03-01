using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class FlockAgent : MonoBehaviour {
    private Collider2D _agentCollider;
    public Collider2D _AgentCollider => _agentCollider;

    private Flock agentFlock;
    public Flock AgentFlock => agentFlock;

    void Start() {
        _agentCollider = GetComponent<Collider2D>();
    }

    public void Initialize(Flock flock) {
        agentFlock = flock;
    }

    public void Move(Vector2 velocity) {
        transform.up = velocity;
        transform.position += (Vector3) velocity * Time.deltaTime;
    }
}