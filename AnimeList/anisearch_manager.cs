using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimeList
{
    class anisearch_manager
    {
        public static string[] get_table(int userid, int page = 1)
        {
            try
            {
                List<string> list = new List<string>();
                Debug.WriteLine("[AniSearch_get_table]: Starting get table from " + userid);
                string url = "https://www.anisearch.de/member/" + userid.ToString() + "/anime/index/?char=all&page=" + page.ToString() + "&sort=rating&order=desc&view=1&limit=100&title=&titlex=";
                Debug.WriteLine(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 5000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                    string data = readStream.ReadToEnd();
                    string table_data = mal_animelist_manager.one_line_regex(new Regex(@"<ul class=""gallery header"">([\s\S]*?)<\/ul>"), data);
                    Regex ItemRegex = new Regex(@"<li([\s\S]*?)<\/li>");
                    foreach (Match ItemMatch in ItemRegex.Matches(table_data))
                    {
                        ItemMatch.Value.ToString();
                        Debug.WriteLine("[AnisearchItem]" + ItemMatch.Value.ToString());
                        list.Add(
                        mal_animelist_manager.one_line_regex(new Regex(@"<a href=""anime\/ ([\s\S] *?), "), ItemMatch.Value.ToString()).Replace('"', ' ').Trim()
                        + "|" +
                        mal_animelist_manager.one_line_regex(new Regex(@"<\/span><span class=""title"" itemprop=""name"">([\s\S]*?)<\/span>"), ItemMatch.Value.ToString()).Replace('"', ' ').Trim()
                        + "|" +
                        mal_animelist_manager.one_line_regex(new Regex(@"<meta itemprop=""image"" content=""([\s\S]*?)"""), ItemMatch.Value.ToString()).Replace('"', ' ').Trim().Replace("anime", "images/anime")
                        + "|" +
                        mal_animelist_manager.one_line_regex(new Regex(@"<div class=""text scrollbox"">([\s\S]*?)<\/div>"), ItemMatch.Value.ToString()).Replace('"', ' ').Trim()
                         );
                    }
                    Debug.WriteLine("Site" + mal_animelist_manager.one_line_regex(new Regex(@"<span class=""pagenav-pages"">([\s\S]*?)<\/span>"), data).Replace("Seite " + page + " von ", "").Trim());
                    try
                    {
                        if (Int32.Parse(mal_animelist_manager.one_line_regex(new Regex(@"<span class=""pagenav-pages"">([\s\S]*?)<\/span>"), data).Replace("Seite " + page + " von ", "").Trim()) != page)
                        {
                            Debug.WriteLine("Load site " + (page + 1));
                            foreach (string a in get_table(userid, page + 1))
                            {
                                list.Add(a);
                            }
                        }
                    }
                    catch (FormatException)
                    {

                    }
                }
                return list.ToArray();

            }
            catch (WebException) {
                return null;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }
        }
    }
}
