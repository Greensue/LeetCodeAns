using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {
public static IEnumerator Do() {
　　print("Do now");
　　yield return new WaitForSeconds(2);
　　print("Do 2 seconds later");
}
void Awake() {
　　Do();　　　　//执行DO，但是do后的语句继续执行
　　print("This is printed immediately");
}
