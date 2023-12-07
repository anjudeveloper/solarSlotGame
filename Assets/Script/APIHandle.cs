using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;


namespace Mkey
{
public class APIHandle : MonoBehaviour
{

    
       //...............................API Intergerate...........................................
    public string saassyApiUrl; // Assign this in the Unity Inspector
    private const string FilePath = "Assets/API/casino game.postman_collection.json"; // Update this with your file path
   
   public IEnumerator PointsToCoins(int points)
    {
        string url = $"{saassyApiUrl}/game/points-to-coins";
        string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI5YTJmMTliNy0zNGVlLTQ5N2UtYmIyZC00YzNkN2MzOWMzMzgiLCJqdGkiOiIxMDNlNzBjODNlN2E2YjYzZTA2NjhiOTJlZGI2NWY2Y2YzNTNjMzg0YmVjMzE1MTkwODNjOGVjNTAxOWY0ZmY4ODM4ZGNjNTYzOGIxNDdkOSIsImlhdCI6MTcwMTgzMzk2MS4yMTEwMzYsIm5iZiI6MTcwMTgzMzk2MS4yMTEwMzksImV4cCI6MTczMzQ1NjM2MS4xNjQ4OSwic3ViIjoiMTQ0Iiwic2NvcGVzIjpbXX0.PfbgfvhqB1tCDusqKhJ9zxiDcBViF5wyM50tjSD2MxvgUlSd_G25u6iBhUyaZF_rwRL5_7uhBxMv7s6Ozn3g7vrw1jqbaNnSYJd3x9WSTWDiy_2wpf1vQX2eg5BuYv9LLqJ_qW1_p1Xj8HJX3iTmnl4xv2lbUOYRq_WxEns5GYuadw_sO6Nu3OJ2_VnC1qSiSCEuO9m5n6mrRDE111E__b_41fZSzTFYPwjjU4KRpJqfWiDVlHm9YoMBKOvapweYuiWZ8SDG6LQoR6Z5x_vRoqDjZuNregO8JoIJHK6pR3-d2J8-5LiwklBmO20o6Z4rGgWwdsl4rSG44g4ZKUbz9AXedmC-fgse5SAbDVpEm8VtEp4F9I2qvnbg8WQEuH5rAWYeF38NFjKItEP6t0AbJ7BHzeVnoGY-n4aqh7eVWPBS2ibhbpb4GXpkYq9YZleg2wCp7Ef4m_dcGR2fGTuuh9I2EIdm9OtDsa1MbhmFdrFAmLeIjam9HbQs8eNphGlu_AL3O7EgkaKBuamHEHPDnjnQvZUYZs2tYd98HamMAas7sGOo1qIiDjDloKle_0c7ogl_7hIrKtYy5X-pBT8HAXEgAyFqWRKzuwIc6JIvEBQDyUVxkXOkSDRlUdAtslrIXiv3OhbKjCZKEqabB54WDZaPX8RWVOngk9A7baWYCFw"; // Replace with your actual bearer token

        WWWForm form = new WWWForm();
        form.AddField("points", points.ToString());

        UnityWebRequest request = UnityWebRequest.Post(url, form);
        request.SetRequestHeader("Authorization", $"Bearer {token}");

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            // Handle successful response
            Debug.Log("Points converted to coins successfully");
            // Example: Update CoinManager script with the received data
            // CoinManager.Instance.UpdateCoins(); // Replace UpdateCoins with your method to update coin count
        }
        else
        {
            // Handle error
            Debug.Log("Error: " + request.error);
        }

       
    }

  


   
    //...............................API Intergerate...........................................

}
}