using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnimeList
{
    class mal_animelist_manager
    {
        public static string[] get_table(int status,string username,bool manga = false)
        {
            List<string> category_list = new List<string>();
            Debug.WriteLine("[MyAnimeList_get_table]: Starting get table from "+username);
            string url = "https://myanimelist.net/animelist/"+ username + "?status="+ status.ToString();
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
                    Regex match_anime = new Regex(@"data-items=([\s\S]*?);}]");
                    Match match_anime_data = match_anime.Match(data);
                    if (match_anime_data.Success)
                    {
                        foreach (string anime in match_anime_data.Groups[1].Value.ToString().Split('}'))
                        {
                            category_list.Add(
                                one_line_regex(new Regex(@"anime_id&quot;:([\s\S]*?),&quot;"), anime)
                                + "|"+
                                one_line_regex(new Regex(@"anime_num_episodes&quot;:([\s\S]*?),&quot;"), anime)
                                + "|" +
                                one_line_regex(new Regex(@"score&quot;:([\s\S]*?),&quot;"), anime)
                                + "|" +
                                one_line_regex(new Regex(@"anime_title&quot;:&quot;([\s\S]*?)&quot;,&quot;"), anime)
                                + "|" +
                                one_line_regex(new Regex(@"anime_image_path&quot;:&quot;([\s\S]*?)&quot;,&quot;"), anime).Replace(@"\", "")
                                );
                        }
                    }
            }
            return category_list.ToArray();
        }


        public static string one_line_regex(Regex regex, string match, int group = 1)
        {
            Debug.WriteLine("[OneLineRegex]:" + match);
            Regex _regex = regex;
            Match _match = _regex.Match(match);
            Debug.WriteLine("[OneLineRegex]:" + _match.Groups[group].Value);
            return _match.Groups[group].Value.ToString();
        }
        public static Image get_image(string url)
        {
            Debug.WriteLine("GetImage: " + url);
            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url.Trim());
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                return img;
            }
            catch (ArgumentException)
            {
                return null;
            }
            catch (WebException)
            {
                return null;
            }
        }
    }
}
