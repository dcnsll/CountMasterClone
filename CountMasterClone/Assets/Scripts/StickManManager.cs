using UnityEngine;
using DG.Tweening;

public class StickManManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem blood;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("RED") && other.transform.parent.childCount > 0)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            Instantiate(blood, transform.position, Quaternion.identity);
        }


        switch (other.tag)
        {

            case "RED":
               if (other.transform.parent.childCount > 0)
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }

                break;


             case "Jump":

                transform.DOJump(transform.position, 1f, 1, 1f).SetEase(Ease.Flash).OnComplete(PlayerManager.PlayerManagerInstance.FormatStickMan);

                break;
        }

    }
}
