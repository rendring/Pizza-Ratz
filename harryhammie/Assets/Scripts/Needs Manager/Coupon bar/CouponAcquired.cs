using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CouponAcquired : MonoBehaviour
{

    public bool AcquiredCoupon;

    public PermaStates Coupons;

    public bool playOnce;

    public GameObject ChooseCoupon, Slot1, Slot2, Slot3;

    public GameObject Bakery, Baking, Beverages, CannedFood, Dairy, Meat, Others, Produce, Veggie;

    public GameObject CanvasCoupon;

    List<GameObject> ListCoupon = new List<GameObject>();




    Vector3 S1;
    Vector3 S2;
    Vector3 S3;

    private void Start()
    {
        S1 = Slot1.transform.position;
        S2 = Slot2.transform.position;
        S3 = Slot3.transform.position;

        ListCoupon.Add(Bakery);
        ListCoupon.Add(Baking);
        ListCoupon.Add(Beverages);
        ListCoupon.Add(CannedFood);
        ListCoupon.Add(Dairy);
        ListCoupon.Add(Meat);
        ListCoupon.Add(Others);
        ListCoupon.Add(Produce);
        ListCoupon.Add(Veggie);




    }

    public void RandomCoupons()
    {


        int prefabIndex = UnityEngine.Random.Range(0, 9);
        int prefabIndex2 = UnityEngine.Random.Range(0, 4);
        int prefabIndex3 = UnityEngine.Random.Range(4, 9);

        ChooseCoupon.SetActive(true);

        GameObject SlotFirst = Instantiate(ListCoupon[prefabIndex], S1, Quaternion.identity) as GameObject;

        SlotFirst.transform.parent = CanvasCoupon.transform.parent;

        GameObject SlotSecond = Instantiate(ListCoupon[prefabIndex2], S2, Quaternion.identity);

        SlotSecond.transform.parent = CanvasCoupon.transform.parent;

        GameObject SlotThird = Instantiate(ListCoupon[prefabIndex3], S3, Quaternion.identity);


        SlotThird.transform.parent = CanvasCoupon.transform.parent;


    }

  

}
