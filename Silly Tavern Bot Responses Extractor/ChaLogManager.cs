using Newtonsoft.Json;
using Silly_Tavern_Bot_Responses_Extractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public List<Message> GetBotsResponses(List<Message> messages)
        {
            try
            {
                List<Message> ap = null;
                if (messages != null)
                {
                    //ap = new List<Message>();
                    ap = messages.FindAll(m => m.IsUser == false).ToList();
                }



                return ap;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string ExportMessagesToText(List<Message> messages,
            Boolean removeFirstParagraph)
        {
            try
            {
                string ap= null;
                if (messages != null)
                {
                    //ap = new List<Message>();
                    foreach (var message in messages)
                    {
                        if (removeFirstParagraph  )
                        {
                            ap += RemoveFirstParagraph(message.Mes);
                        }
                        else
                        {
                            ap += message.Mes;
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
        public string ExportAllMessagesToText(List<Message> messages,
          Boolean removeFirstParagraph)
        {
            try
            {
                string ap = null;
                if (messages != null)
                {
                    //ap = new List<Message>();
                    foreach (var message in messages)
                    {
                        if (removeFirstParagraph)
                        {
                            ap += RemoveFirstParagraph(message.Mes);
                        }
                        else
                        {
                            ap += message.Mes;
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

        private string RemoveFirstParagraph(string messege)
        {
            try
            {
                string ap = null;
                if (messege != null)
                {
                    var paragraphs = messege.Split(new string[] { "\n\n",
                        "\n\n" }, StringSplitOptions.None);
                    if (paragraphs.Length > 1)
                    {
                        string result = string.Join("\n\n", paragraphs[1..]);
                        ap = result;

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
