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
                if ( inputFile !=null )
                {
                    foreach (var line in File.ReadLines(inputFile))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var entry = JsonConvert.DeserializeObject<Chat>(line);
                        if (entry != null && !entry.IsUser && !string.IsNullOrWhiteSpace(entry.Messages))
                        {
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
