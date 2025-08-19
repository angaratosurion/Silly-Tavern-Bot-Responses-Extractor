using Silly_Tavern_Bot_Responses_Extractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Silly_Tavern_Bot_Responses_Extractor
{
    public  class ChaLogManager
    {

        public List<Message> GetMessages( string inputFile)
        {
			try
			{
                List<Message> ap = null;
                if (inputFile != null)
                {
                    ap = new List<Message>();
                    foreach (var line in File.ReadLines(inputFile))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var entry = JsonConvert.DeserializeObject<Message>(line);
                        if (entry?.Mes != null)
                        {
                            ap.Add(entry);


                        }
                    }

                }





                            return ap;


            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
