using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HelperJSON : MonoBehaviour
{
    #region singleton
    public static HelperJSON instanceHelperJSON;
    private void Awake()
    {
        if (instanceHelperJSON == null)
        {
            LoadJson();
            instanceHelperJSON = this;
        }
    }
    #endregion

    private class HelperJSON_OrderData
    {
        public string Title;
        public string From;
        public string OrderContent;
    }

    List<HelperJSON_OrderData> helperJSON_OrderData;
    public void LoadJson()
    {
//        HelperJSON_OrderData loadedData = new HelperJSON_OrderData();

        using (StreamReader r = new StreamReader("UndoneQuests.json"))
        {
            string json = r.ReadToEnd();            
            helperJSON_OrderData = JsonConvert.DeserializeObject<List<HelperJSON_OrderData>>(json);

            Debug.Log(helperJSON_OrderData.Count);

            Debug.Log(helperJSON_OrderData[0].Title);

            //helperJSONDatas = npcList;
        }
    }


}
