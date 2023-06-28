//using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


namespace ProductMicroservice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TranslatorController : ControllerBase
{
   
    [HttpGet("{input}", Name ="TranslateEnglistToFrench")]
    public IActionResult TranslateEnglistToFrench(string input)
    {
        var response = TranslateText(input);
        return new OkObjectResult(response);
    }

    private string TranslateText(string input)
    {
        // Set the language from/to in the url (or pass it into this function)
        string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
        "en", "fr", Uri.EscapeUriString(input));
        HttpClient httpClient = new HttpClient();
        string result = httpClient.GetStringAsync(url).Result;

        //Get all json data
        //var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
        var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);

        //Extract just the first array element (This is the only data we are interested in)
        var translatonItems = jsonData[0];

        //Translation Data
        string translation = "";

        //Loop through the collection extracting the translated objects
        foreach(object item in translatonItems)
        {
            //Convert the item array to IEnumerable
            IEnumerable translationLineObject = item as IEnumerable;

             // Convert the IEnumerable translationLineObject to a IEnumerator
            IEnumerator translationLineString = translationLineObject.GetEnumerator();

            // Get first object in IEnumerator
            translationLineString.MoveNext();

            //Save its value (translated text)
            translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
        }

            //Remove first blank character
            if(translation.Length > 1)
            {
                translation = translation.Substring(1);
            }

            return translation;

    }


}