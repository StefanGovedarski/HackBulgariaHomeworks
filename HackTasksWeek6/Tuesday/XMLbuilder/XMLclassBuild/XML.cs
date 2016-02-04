using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace XMLclassBuild
{
    public class XML
    {
        private Dictionary<string, int> xmlTags = new Dictionary<string, int>();
        private List<string> openedTags = new List<string>();
        private StreamWriter sw;

        public XML(string TextFilePathName)
        {
            if(!(File.Exists(TextFilePathName)))
            {
                try
                {
                    File.Create(TextFilePathName);
                }
                catch
                {
                    throw new DirectoryNotFoundException("The inputed file path is wrong.Try again.");
                }
            }
            if(File.Exists(TextFilePathName))
            {
                sw = new StreamWriter(TextFilePathName);
            }
        }

        public void OpenTag(string TagName)
        {
            if(xmlTags.ContainsKey(TagName)&&xmlTags[TagName] == 0)
            {
                throw new XMLTagIsAlreadyOpen("A tag with this name is already opened.Close the tag and try again");
            }
            xmlTags.Add(TagName, 0);
            sw.Write("<" + TagName + ">");
            openedTags.Add(TagName);
        }
        public void AddAtribute(string attrName , string attrValue)
        {
            if (openedTags == null && openedTags.Count == 0)
            {
                throw new ThereAreNoOpenTags("All of the existing tags have been closed already.");
            }
            else
            {
                sw.Write("<element>" +attrName +"=" + attrValue   +"</element>");
            }
        }
        public void AddText(string Text)
        {
            if(openedTags == null && openedTags.Count ==0)
            {
                throw new ThereAreNoOpenTags("All of the existing tags have been closed already.");
            }
            else
            {
                sw.Write("<text>" + Text + "</text>");
            }
        }
        public void CloseTag()
        {
            if(openedTags == null)
            {
                throw new ThereAreNoOpenTags("All of the existing tags have been closed already.");
            }
            else
            {
                xmlTags[openedTags.Last<string>()] = 1;
                sw.Write("</" + (openedTags.Last<string>()) +  ">");
                openedTags.Remove(openedTags.Last<string>());
                
            }
        }
        public void Finish()
        {
            if (openedTags.Count == 0 && openedTags == null)
            {
                throw new ThereAreNoOpenTags("All of the existing tags have been closed already.");
            }
            else
            {
                openedTags.Reverse();
                for (int i = 0; i < openedTags.Count; i++)
                {
                    sw.Write("</" + openedTags[i] + ">");
                    if(xmlTags[openedTags[i]]==0)
                    {
                        xmlTags[openedTags[i]]= 1;
                    }
                }
                sw.Close();
                openedTags.Clear();
            }
        }
    }
}
